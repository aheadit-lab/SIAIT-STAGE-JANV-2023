import {  Component, OnInit, ViewChild } from '@angular/core';
import { MatDialog } from '@angular/material/dialog';
import { MatPaginator } from '@angular/material/paginator';
import { MatSort } from '@angular/material/sort';
import { MatTableDataSource } from '@angular/material/table';
import { AddProjectComponent } from 'src/app/diag/add-project/add-project.component';
import { ConfirmDiagComponent } from 'src/app/diag/confirm-diag/confirm-diag.component';
import { ModifyProjectComponent } from 'src/app/diag/modify-project/modify-project.component';
import { CollaboratorClient, ProjectClient, ProjectDTO } from 'src/app/dto/client';

@Component({
  selector: 'app-projets',
  templateUrl: './projets.component.html',
  styleUrls: ['./projets.component.css']
})
export class ProjetsComponent implements OnInit {
Manager:string="";
 firstName :string= "";
   lastName:string = "";
   dd!:any[];
  dataSource= new MatTableDataSource<ProjectDTO>();
projets!:ProjectDTO[]

@ViewChild(MatPaginator) paginator!: MatPaginator;
@ViewChild(MatSort) sort!: MatSort;
  displayedColumns: string[] = ['Nom','Nombre de jours', 'Nombre de jours consommé', 'ManagerId','Actif','Externe','actions'];

  constructor(public dialog: MatDialog,
    private serviceProjet:ProjectClient,
    private serviceCollaborateur:CollaboratorClient,
    ) { }

  supprimerProjet(id:number)
  {
    const dialogRef = this.dialog.open(ConfirmDiagComponent,
      {
        width: '20%',
        height: 'auto'
      });
    dialogRef.afterClosed().subscribe(result => {
      if (result == true) {
    this.serviceProjet.delete(id).subscribe(data=> this.listerProjets());
      }});
   

  }

  modifierProjet(element:ProjectDTO)
  {
    const dialogRef = this.dialog.open(ModifyProjectComponent,
      {
        width: '38%',
        height: '60%',
        data: {
          projet: element,
          id:element.id
        }
      });
    dialogRef.afterClosed().subscribe(data=> this.listerProjets());
  }

  ajouterProjet()
{
  let project: ProjectDTO = new ProjectDTO();
  project.id = 0;
  const dialogRef = this.dialog.open(AddProjectComponent,
    {
      width: '38%',
      height: '60%',
      data: {
        projet: project,}
      
    });
  dialogRef.afterClosed().subscribe(data=> this.listerProjets())
}


applyFilter(event: Event) {
  const filterValue = (event.target as HTMLInputElement).value;
  this.dataSource.filter = filterValue.trim().toLowerCase();

  if (this.dataSource.paginator) {
    this.dataSource.paginator.firstPage();
  }
}



listerProjets()
{
  this.serviceProjet.get().subscribe(data=>{this.projets=data;
   
    this.dataSource=new MatTableDataSource(this.projets);
    this.dataSource.paginator=this.paginator;})
}
  ngOnInit(): void {
   this.listerProjets();

    }
     
  

}
