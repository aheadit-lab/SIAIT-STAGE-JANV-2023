import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { ActionClient, CollaboratorClient, CollaboratorDTO, LoginResponseDTO } from '../dto/client';

@Injectable({
  providedIn: 'root'
})
export class AuthService {
  login(user:CollaboratorDTO):Observable<LoginResponseDTO>{
     return this.serviceclient.login(user.userName,user.password);
  }

  constructor(private serviceclient:CollaboratorClient) 
  {
   
   }
}
