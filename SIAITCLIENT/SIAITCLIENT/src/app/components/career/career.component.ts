import { Component, OnInit,Input } from '@angular/core';
import { MatDialog } from '@angular/material/dialog';
import { AddCareerComponent } from 'src/app/diag/add-career/add-career.component';
import { ConfirmDiagComponent } from 'src/app/diag/confirm-diag/confirm-diag.component';
import { ModifyCareerComponent } from 'src/app/diag/modify-career/modify-career.component';
import { CareerClient, CareerDTO } from 'src/app/dto/client';

@Component({
  selector: 'app-career',
  templateUrl: './career.component.html',
  styleUrls: ['./career.component.css']
})
export class CareerComponent implements OnInit {
  @Input() collaboratorId: number | undefined;

  careers!:CareerDTO[];
role!:number;

  constructor(public dialog: MatDialog,private serviceCareer:CareerClient) { }
  addCareer()
  {
    let career: CareerDTO = new CareerDTO();
    career.id = 0;
    const dialogRef = this.dialog.open(AddCareerComponent,
      {
        width: '39%',
        height: '81%',
        data: {
          career: career,
          id:this.collaboratorId
        
        }
        
      });
    dialogRef.afterClosed().subscribe(data=> this.listerCareer())
  }

  modifyCareer(career:CareerDTO)
  {
    const dialogRef = this.dialog.open(ModifyCareerComponent,
      {
        width: '39%',
        height: '85%',
        data: {
          career: career,
          id:career.id
        }
      });
    dialogRef.afterClosed().subscribe(data=> this.listerCareer());
  }

  deleteCareer(id:number)
  {
    const dialogRef = this.dialog.open(ConfirmDiagComponent,
      {
        width: '20%',
        height: 'auto'
      });
    dialogRef.afterClosed().subscribe(result => {
      if (result == true) {
    this.serviceCareer.delete(id).subscribe(data=> this.listerCareer());
      }});
   
  }

  listerCareer()
  {
    this.serviceCareer.get().subscribe(data=>{
      this.careers=data.filter(elt=>elt.collaboratorId==this.collaboratorId)
    })
  }

  testUser()
  {
    return !(this.role!=1);
    
  }
 
  ngOnInit(): void {
   this.listerCareer();
this.role=Number(localStorage.getItem("profilId"));
  }

}
