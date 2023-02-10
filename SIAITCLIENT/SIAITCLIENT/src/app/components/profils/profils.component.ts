import { Component, OnInit, ViewChild } from '@angular/core';
import { MatDialog } from '@angular/material/dialog';
import { MatPaginator } from '@angular/material/paginator';
import { MatTableDataSource } from '@angular/material/table';
import { AddProfileComponent } from 'src/app/diag/add-profile/add-profile.component';
import { ConfirmDiagComponent } from 'src/app/diag/confirm-diag/confirm-diag.component';
import { ModifyProfilComponent } from 'src/app/diag/modify-profil/modify-profil.component';
import { ProfilClient, ProfilDTO } from 'src/app/dto/client';

@Component({
  selector: 'app-profils',
  templateUrl: './profils.component.html',
  styleUrls: ['./profils.component.css']
})
export class ProfilsComponent implements OnInit {
  dataSource= new MatTableDataSource<ProfilDTO>();
  Profils!:ProfilDTO[] ;
  constructor(public dialog: MatDialog,private profilService:ProfilClient) { }
  applyFilter(event: Event) {
    const filterValue = (event.target as HTMLInputElement).value;
    this.dataSource.filter = filterValue.trim().toLowerCase();
  
    if (this.dataSource.paginator) {
      this.dataSource.paginator.firstPage();
    }
  }

@ViewChild(MatPaginator) paginator!: MatPaginator;
  displayedColumns: string[] = ['ID','NOM','actions'];

  ajouterProfil()
  {
    let profil: ProfilDTO = new ProfilDTO();
   
    profil.id = 0;
    const dialogRef = this.dialog.open(AddProfileComponent,
      {
        width: '39%',
        height: '40%',
        data:
         {
          profil: profil
         }
        
      });
    dialogRef.afterClosed().subscribe(data=> this.listerProfils())
    
  }


  modifierProfil(element:ProfilDTO)
 { 
  const dialogRef = this.dialog.open(ModifyProfilComponent,
    {
      width: '30%',
      height: '45%',
      data: {
        profil: element,
        id:element.id
      }
    });
  dialogRef.afterClosed().subscribe(data=> this.listerProfils());
 }


supprimerProfil(id:number)
{
  const dialogRef = this.dialog.open(ConfirmDiagComponent,
    {
      width: '20%',
      height: 'auto'
    });
  dialogRef.afterClosed().subscribe(result => {
    if (result == true) {
  this.profilService.delete(id).subscribe(data=> this.listerProfils());
    }});
 
}


listerProfils()
{
  this.profilService.get().subscribe( data=>{this.Profils=data;
    this.dataSource=new MatTableDataSource(this.Profils);
    this.dataSource.paginator=this.paginator;})
}

  ngOnInit(): void
   {
     this.listerProfils();
   }

}
