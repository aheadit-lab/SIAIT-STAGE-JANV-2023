import { Component, Inject, OnInit, Optional } from '@angular/core';
import { MatDialogRef, MAT_DIALOG_DATA } from '@angular/material/dialog';
import { CollaboratorClient, CollaboratorDTO, ProjectClient, ProjectDTO } from 'src/app/dto/client';

@Component({
  selector: 'app-add-project',
  templateUrl: './add-project.component.html',
  styleUrls: ['./add-project.component.css']
})
export class AddProjectComponent implements OnInit {
  projet: ProjectDTO = new ProjectDTO();
  title: string = "Ajouter un projet ";
  buttonName: string = "Ajouter";
  id!: number;

  public collaborateurs!: CollaboratorDTO[];

  constructor(

    public dialogRef: MatDialogRef<AddProjectComponent>,

    private serviceCollab: CollaboratorClient,
    private serviceProjet: ProjectClient,
    @Optional() @Inject(MAT_DIALOG_DATA) public data: any) { }


  ngOnInit(): void {

    this.serviceCollab.get().subscribe(data => this.collaborateurs = data)

  }
  close() {
    this.dialogRef.close("close");
  }

  saveEmploy() {

    this.serviceProjet.create(this.projet).subscribe(
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
