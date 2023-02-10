import { Component, Inject, OnInit, Optional } from '@angular/core';
import { MatDialogRef, MAT_DIALOG_DATA } from '@angular/material/dialog';
import { CollaboratorClient, CollaboratorDTO } from 'src/app/dto/client';

@Component({
  selector: 'app-detail-collaborateur',
  templateUrl: './detail-collaborateur.component.html',
  styleUrls: ['./detail-collaborateur.component.css']
})
export class DetailCollaborateurComponent implements OnInit {

  collaborateur: CollaboratorDTO = new CollaboratorDTO();
  title!: string ;
  buttonName!: string;
  emailPattern: string = "^[a-z0-9._%+-]+@[a-z0-9.-]+\.[a-z]{2,4}$";
id!:number;


  constructor(private servicecollabo: CollaboratorClient, public dialogRef: MatDialogRef<DetailCollaborateurComponent>,
    //@Optional() is used to prevent error if no data is passed
    @Optional() @Inject(MAT_DIALOG_DATA) public data: any) { }

  ngOnInit(): void {
    this.collaborateur = this.data.collaborateur;
    this.id=this.data.id;
    if (this.collaborateur.id != 0) {
      this.title = "Modifier" + " " + this.collaborateur.firstName + " " + this.collaborateur.lastName;
      this.buttonName = "Modifier"
    }
  }

  close(){
    this.dialogRef.close("close"); 
  }

  saveEmploy() {
   
    //cas modif : else if id!=0
   
      this.servicecollabo.update(this.id,this.collaborateur).subscribe(
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
