using Microsoft.EntityFrameworkCore;
using SIAITAPI.DAO;
using SIAITAPI.Data;
using SIAITAPI.IDAO;
using SIAITAPI.IServices;
using SIAITAPI.Services;
using SIAITAPI.Utils;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<ModelDbContext>(
    o =>
    {
        o.UseSqlServer(builder.Configuration.GetConnectionString("SqlServer"));
        o.UseLazyLoadingProxies();
    });


builder.Services.AddScoped<ICategoryService, CategoryService>();
builder.Services.AddScoped<ICategoryDAO, CategoryDAO>();

builder.Services.AddScoped<IActionService, ActionService>();
builder.Services.AddScoped<IActionDAO, ActionDAO>();

builder.Services.AddScoped<ICareerService, CareerService>();
builder.Services.AddScoped<ICareerDAO, CareerDAO>();

builder.Services.AddScoped<ICivilStatusService, CivilStatusService>();
builder.Services.AddScoped<ICivilStatusDAO, CivilStatusDAO>();

builder.Services.AddScoped<ICollaborateurService, CollaborateurService>();
builder.Services.AddScoped<ICollaborateurDAO, CollaborateurDAO>();

builder.Services.AddScoped<IEntityService, EntityService>();
builder.Services.AddScoped<IEntityDAO, EntityDAO>();

builder.Services.AddScoped<IGradeService, GradeService>();
builder.Services.AddScoped<IGradeDAO, GradeDAO>();

builder.Services.AddScoped<IMenuService, MenuService>();
builder.Services.AddScoped<IMenuDAO, MenuDAO>();

builder.Services.AddScoped<IModuleService, ModuleService>();
builder.Services.AddScoped<IModuleDAO, ModuleDAO>();

builder.Services.AddScoped<IProfilService, ProfilService>();
builder.Services.AddScoped<IProfilDAO, ProfilDAO>();

builder.Services.AddScoped<IProfilActionService, ProfilActionService>();
builder.Services.AddScoped<IProfilActionDAO, ProfilActionDAO>();

builder.Services.AddScoped<IProfilMenuService, ProfilMenuService>();
builder.Services.AddScoped<IProfilMenuDAO, ProfilMenuDAO>();

builder.Services.AddScoped<IProjetService, ProjectService>();
builder.Services.AddScoped<IProjectDAO, ProjectDAO>();

builder.Services.AddScoped<IQualificationService, QualificationService>();
builder.Services.AddScoped<IQualificationDAO, QualificationDAO>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseCors(x => x
            .AllowAnyOrigin()
            .AllowAnyMethod()
            .AllowAnyHeader());
app.UseHttpsRedirection();

app.UseAuthorization();

app.Use(async (context, next) =>
{
    var request = context.Request;
    if (request.Path == "/api/Collaborator/Login")
    {
        await next.Invoke(context);
        return;
    }
    var authorizationHeader = request.Headers.Authorization;
    var authozationHeaderContent = authorizationHeader.ToString();
    if (!string.IsNullOrEmpty(authozationHeaderContent))
    {
        var split = authozationHeaderContent.Split(' ');
        if (split.Length != 2)
        {
            context.Response.StatusCode = 401;
            await context.Response.WriteAsync("#NO_JWT");
            return;
        }
        try
        {
            string token = split[1];
            var principal = JWTManager.ValidateToken(token);
            context.User = principal;
            await next.Invoke(context);
        }
        catch (Exception)
        {
            context.Response.StatusCode = 401;
            await context.Response.WriteAsync("#NO_JWT");
        }
    }
});

app.MapControllers();

app.Run();
