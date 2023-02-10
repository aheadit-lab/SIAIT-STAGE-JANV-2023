import { Component, Inject, OnInit, Optional } from '@angular/core';
import { MatDialogRef, MAT_DIALOG_DATA } from '@angular/material/dialog';
import { CollaboratorClient, CollaboratorDTO, ProjectClient, ProjectDTO } from 'src/app/dto/client';

@Component({
  selector: 'app-modify-project',
  templateUrl: './modify-project.component.html',
  styleUrls: ['./modify-project.component.css']
})
export class ModifyProjectComponent implements OnInit {
  projet: ProjectDTO = new ProjectDTO();
  
  title: string="Modifier projet" ;
  buttonName:string= "Modifier";
  id!:number;

  public collaborateurs!: CollaboratorDTO[];

  constructor(

    public dialogRef: MatDialogRef<ModifyProjectComponent>,

    private serviceCollab: CollaboratorClient,
    private serviceProjet: ProjectClient,
    @Optional() @Inject(MAT_DIALOG_DATA) public data: any) { }


  ngOnInit(): void {

    this.serviceCollab.get().subscribe(data => this.collaborateurs = data)
    this.projet=this.data.projet;
    this.id=this.data.id;
      
    }

  
  close() {
    this.dialogRef.close("close");
  }

  save() {

    
    this.serviceProjet.update(this.id,this.projet).subscribe(
      data => {
       
        this.dialogRef.close(true)

      },
      error => {
        console.log(error)
        this.dialogRef.close(false)


  });
  }}
