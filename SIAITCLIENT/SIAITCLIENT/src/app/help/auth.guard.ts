import { Injectable } from '@angular/core';
import { ActivatedRouteSnapshot, CanActivate, Router, RouterStateSnapshot, UrlTree } from '@angular/router';
import { Observable } from 'rxjs';
import { TokenService } from '../services/token.service';

@Injectable({
  providedIn: 'root'
})
export class AuthGuard implements CanActivate {
  constructor(private tokenserv:TokenService,private router:Router){}
  canActivate() {
    let token=this.tokenserv.getToken();
    if (token!=null)
    { 
     return true;}
    else 
    {
     
     this.router.navigate(['login']);
     return false;
    }
  }
  
}
