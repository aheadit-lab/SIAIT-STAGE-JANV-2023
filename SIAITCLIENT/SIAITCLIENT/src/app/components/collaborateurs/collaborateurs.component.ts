import { Component, OnInit, ViewChild } from '@angular/core';
import { MatDialog } from '@angular/material/dialog';
import { MatPaginator } from '@angular/material/paginator';
import { MatTableDataSource } from '@angular/material/table';
import { Router } from '@angular/router';
import { AjouterCollabComponent } from 'src/app/diag/ajouter-collab/ajouter-collab.component';
import { ConfirmDiagComponent } from 'src/app/diag/confirm-diag/confirm-diag.component';
import { DetailCollaborateurComponent } from 'src/app/diag/detail-collaborateur/detail-collaborateur.component';
import { CollaboratorClient, CollaboratorDTO } from 'src/app/dto/client';

@Component({
  selector: 'app-collaborateurs',
  templateUrl: './collaborateurs.component.html',
  styleUrls: ['./collaborateurs.component.css']
})
export class CollaborateursComponent implements OnInit {
  dataSource= new MatTableDataSource<CollaboratorDTO>();
  Collaborateurs!:CollaboratorDTO[] ;
  dd!:any[];
  constructor(public dialog: MatDialog,private collabService:CollaboratorClient,private router:Router) { }
  applyFilter(event: Event) {
    const filterValue = (event.target as HTMLInputElement).value;
    this.dataSource.filter = filterValue.trim().toLowerCase();
  
    if (this.dataSource.paginator) {
      this.dataSource.paginator.firstPage();
    }
  }
  

@ViewChild(MatPaginator) paginator!: MatPaginator;
  displayedColumns: string[] = [ 'CIN','Nom','Prénom', 'Email', 'Tél','CNSS','actions'];

  ajouterCollab()
  {
    let collaborateur: CollaboratorDTO = new CollaboratorDTO();
    collaborateur.id = 0;
    const dialogRef = this.dialog.open(AjouterCollabComponent,
      {
        width: '50%',
        height: '86%',
        data: {
          collaborateur: collaborateur,}
        
      });
    dialogRef.afterClosed().subscribe(data=> this.listerCollaborateurs())
  }


  modifierCollaborateur(element:any)
{
  const dialogRef = this.dialog.open(DetailCollaborateurComponent,
    {
      width: '39%',
      height: '80%',
      data: {
        collaborateur: element,
        id:element.id
      }
    });
  dialogRef.afterClosed().subscribe(data=> this.listerCollaborateurs());
}


supprimerCollaborateur(id:number)
{
  const dialogRef = this.dialog.open(ConfirmDiagComponent,
    {
      width: '20%',
      height: 'auto'
    });
  dialogRef.afterClosed().subscribe(result => {
    if (result == true) {
  this.collabService.delete(id).subscribe(data=> this.listerCollaborateurs());
    }});
 
}
showDetails(element:CollaboratorDTO)
{
  
  this.router.navigate(['dashboard/collaborateurs', element.id])
}
listerCollaborateurs()
{
  this.collabService.get().subscribe( data=>{this.Collaborateurs=data;
    this.dataSource=new MatTableDataSource(this.Collaborateurs);
    this.dataSource.paginator=this.paginator;})
}
  ngOnInit(): void {
    
this.listerCollaborateurs();
  }

}
