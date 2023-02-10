import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { Router } from '@angular/router';
import { CollaboratorDTO } from 'src/app/dto/client';
import { AuthService } from 'src/app/services/auth.service';
import { TokenService } from 'src/app/services/token.service';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit {
  loginForm!:FormGroup;
  collab!:CollaboratorDTO;
  public isAuth: boolean = false;
  
  constructor(private router:Router,private formBuilder:FormBuilder,public authservice:AuthService,private tokenService:TokenService) { }
  login()
  {
   this.authservice.login(this.loginForm.value).subscribe(
    data=>
    {
      if(data.collaborator!=undefined)
      {
        let role:string=`${data.collaborator.profilId}`;
        console.log(role);
        localStorage.setItem('profilId',role);
        
          localStorage.setItem("currentUserId",`${data.collaborator.id}`);
        
      }
      if(data.token!=null)
      {
        this.tokenService.saveToken(data.token);
        this.router.navigate(["/dashboard"]);
        this.isAuth = true;
      }

    },
    err=>console.log(err)
   );
   
  }
  ngOnInit(): void {
    this.loginForm = this.formBuilder.nonNullable.group(
      {password:['',Validators.required],
      userName:['',Validators.required]
      
      }
    );
  }

}
