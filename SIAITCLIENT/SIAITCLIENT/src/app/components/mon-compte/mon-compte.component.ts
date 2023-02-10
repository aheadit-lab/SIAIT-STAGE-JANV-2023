import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormControl, FormGroup, Validators } from '@angular/forms';
import { CollaboratorClient, CollaboratorDTO } from 'src/app/dto/client';
import{Location}from'@angular/common';
import { PassThrough } from 'stream';

@Component({
  selector: 'app-mon-compte',
  templateUrl: './mon-compte.component.html',
  styleUrls: ['./mon-compte.component.css']
})
export class MonCompteComponent implements OnInit {
  public compteForm!:FormGroup;
  public showPassword : boolean = false;
  id!: number;
  currentUser:CollaboratorDTO=new CollaboratorDTO();
  constructor(private collaborateurService:CollaboratorClient,
    private location: Location,
    public fb:FormBuilder) { }
  save()
  {
   
   this.collaborateurService.update(this.id,this.currentUser).subscribe();
  }
  
  
  
  public goBack() {
    this.location.back(); 
  }
  ngOnInit(): void {

    this.id=Number(localStorage.getItem("currentUserId"));
    this.collaborateurService.getBYId(this.id).subscribe(data=>this.currentUser=data);



    this.compteForm = this.compteForm || new FormGroup({
      firstNameControl: new FormControl('', Validators.required),
      lastNameControl: new FormControl('', Validators.required),
      userNameControl: new FormControl(''),
      emailControl: new FormControl('', [Validators.required, Validators.email]),
      passwordControl: new FormControl('', Validators.required),
      phoneNumberControl: new FormControl('', Validators.required)
   
    })
  }
  
  }
  