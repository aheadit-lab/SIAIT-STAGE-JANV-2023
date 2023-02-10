import { Component, OnInit,Optional,Inject } from '@angular/core';
import { MatDialogRef, MAT_DIALOG_DATA } from '@angular/material/dialog';
import { ProfilClient, ProfilDTO } from 'src/app/dto/client';

@Component({
  selector: 'app-modify-profil',
  templateUrl: './modify-profil.component.html',
  styleUrls: ['./modify-profil.component.css']
})
export class ModifyProfilComponent implements OnInit {
  profil: ProfilDTO = new ProfilDTO();
  title!: string ;
  buttonName!: string;
  id!:number;
  constructor(private serviceProfil:ProfilClient,public dialogRef: MatDialogRef<ModifyProfilComponent>,
    //@Optional() is used to prevent error if no data is passed
    @Optional() @Inject(MAT_DIALOG_DATA) public data: any) { }

  close()
  {
    this.dialogRef.close("close"); 
  }
  saveProfile()
  {

    
    this.serviceProfil.update(this.id,this.profil).subscribe(
      data => {
       
        this.dialogRef.close(true)

      },
      error => {
        console.log(error)
        this.dialogRef.close(false)

      }
    )
  }
  ngOnInit(): void {
    this.profil = this.data.profil;
    this.id=this.data.id;
    if (this.profil.id != 0) {
      this.title = "Modifier" + " " + this.profil.name ;
      this.buttonName = "Modifier"
    }
  }

}
