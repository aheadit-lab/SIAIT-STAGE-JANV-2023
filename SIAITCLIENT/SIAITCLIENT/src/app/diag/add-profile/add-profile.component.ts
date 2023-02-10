import { Component, Inject, OnInit, Optional } from '@angular/core';
import { MatDialogRef, MAT_DIALOG_DATA } from '@angular/material/dialog';
import { ProfilClient, ProfilDTO } from 'src/app/dto/client';
import { ModifyProfilComponent } from '../modify-profil/modify-profil.component';

@Component({
  selector: 'app-add-profile',
  templateUrl: './add-profile.component.html',
  styleUrls: ['./add-profile.component.css']
})
export class AddProfileComponent implements OnInit {
  profil: ProfilDTO = new ProfilDTO();
  title: string ='Ajouter un profil';
  buttonName="Ajouter";
  id!:number;
  constructor(private serviceProfil:ProfilClient,public dialogRef: MatDialogRef<AddProfileComponent>,
    //@Optional() is used to prevent error if no data is passed
    @Optional() @Inject(MAT_DIALOG_DATA) public data: any) { }
  ngOnInit(): void 
  {
    
  }

  close(){
    this.dialogRef.close("close"); 
  }

  saveProfile()
  {
    this.serviceProfil.create(this.profil).subscribe(
      data => {
      
        this.dialogRef.close(true)

      },
      error => {
        console.log(error)
        this.dialogRef.close(false)

      }
    )
  
  }

}
