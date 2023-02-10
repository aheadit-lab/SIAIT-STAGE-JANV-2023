import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormControl, FormGroup, Validators } from '@angular/forms';
import { EntityClient, EntityDTO } from 'src/app/dto/client';
import{Location}from'@angular/common';

@Component({
  selector: 'app-entity',
  templateUrl: './entity.component.html',
  styleUrls: ['./entity.component.css']
})
export class EntityComponent implements OnInit {
  public entityForm!:FormGroup;

  public entity:EntityDTO=new EntityDTO();
  constructor(private serviceEntity:EntityClient,
    private location: Location,
    public fb:FormBuilder) { }



    save()
{
 
 this.serviceEntity.update(1,this.entity).subscribe();
}



public goBack() {
  this.location.back(); 
}

  ngOnInit(): void {
    this.serviceEntity.getBYId(1).subscribe(data=>this.entity=data);


    this.entityForm = this.entityForm || new FormGroup({
      creationDateControl: new FormControl('', Validators.required),
      employerCodeControl: new FormControl('', Validators.required),
      exploitationCodeControl: new FormControl(''),
      emailControl: new FormControl('', [Validators.required, Validators.email]),
      nameControl: new FormControl('', Validators.required),
      rneControl: new FormControl('', Validators.required),
      socialSecuritySchemeControl: new FormControl(''),
      taxRegistrationNumberControl: new FormControl('', Validators.required),
      addressControl: new FormControl('', Validators.required),
      telephoneControl: new FormControl('', Validators.required),
      tradeRegisterControl: new FormControl('', Validators.required)
    
        
      
    })
  }

}
