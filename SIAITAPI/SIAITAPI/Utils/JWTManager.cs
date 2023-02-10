using Microsoft.IdentityModel.Tokens;
using SIAITAPI.Models;
using System.IdentityModel.Tokens.Jwt;
using System.Reflection;
using System.Security.Claims;
using System.Text;
namespace SIAITAPI.Utils
{
    public class JWTManager
    {
 


      
            public const string SECRET = "YWhlYWRpdDIwMDgtMjAyMA==";

            private static List<string> WhiteList401 = null;

            private static List<string> WhiteList403 = null;

            public static List<string> LoadWhiteList401()
            {
                if (WhiteList401 == null)
                {
                    IConfigurationBuilder Builder = new ConfigurationBuilder()
                       .SetBasePath(Path.GetDirectoryName(Assembly.GetEntryAssembly().Location))
                       .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
                    IConfigurationRoot configuration = Builder.Build();
                    IConfigurationSection section = configuration.GetSection("WhiteList401");
                    WhiteList401 = new List<string>();
                    foreach (IConfigurationSection url in section.GetChildren())
                    {
                        WhiteList401.Add(url.Value);
                    }
                }
                return WhiteList401;
            }

            public static string GenerateToken(Collaborator user)
            {
                JwtSecurityTokenHandler tokenHandler = new JwtSecurityTokenHandler();
                byte[] key = Encoding.UTF8.GetBytes(SECRET);
                SecurityTokenDescriptor tokenDescriptor = new SecurityTokenDescriptor
                {
                    Subject = new ClaimsIdentity(new Claim[]
                    {
                    new Claim(ClaimTypes.Name, user.Id.ToString())
                    }),
                    Expires = DateTime.Now.AddHours(2),
                    SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
                };
                SecurityToken token = tokenHandler.CreateToken(tokenDescriptor);

                return tokenHandler.WriteToken(token);
            }

            public static ClaimsPrincipal ValidateToken(string token)
            {
                return GetPrincipal(token);
            }

            private static ClaimsPrincipal GetPrincipal(string token)
            {
                try
                {
                    JwtSecurityTokenHandler tokenHandler = new JwtSecurityTokenHandler();
                    JwtSecurityToken jwtToken = (JwtSecurityToken)tokenHandler.ReadToken(token);
                    if (jwtToken == null)
                        return null;
                    byte[] key = Encoding.UTF8.GetBytes(SECRET);
                    TokenValidationParameters parameters = new TokenValidationParameters()
                    {
                        RequireExpirationTime = true,
                        ValidateIssuer = false,
                        ValidateAudience = false,
                        IssuerSigningKey = new SymmetricSecurityKey(key),
                        ClockSkew = TimeSpan.Zero
                    };
                    SecurityToken securityToken;
                    ClaimsPrincipal principal = tokenHandler.ValidateToken(token,
                          parameters, out securityToken);
                    return principal;
                }
                catch
                {
                    throw;
                }
            }

            public static int GetUserIdFromPrincipal(ClaimsPrincipal principal)
            {
                if (principal == null)
                    return 0;
                ClaimsIdentity identity = null;
                try
                {
                    identity = (ClaimsIdentity)principal.Identity;
                }
                catch (NullReferenceException)
                {
                    return 0;
                }
                Claim userIdName = identity.FindFirst(ClaimTypes.Name);
                if (userIdName == null)
                    throw new Exception("#USER_CREDENTIALS");
                int userId = 0;
                int.TryParse(userIdName.Value, out userId);
                return userId;
            }
        }
    }

