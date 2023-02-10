import { Component, OnInit } from '@angular/core';
import { CategoryClient, CategoryDTO, CivilStatusClient, CivilStatusDTO, CollaboratorClient, CollaboratorDTO, GradeClient, GradeDTO, QualificationClient, QualificationDTO } from 'src/app/dto/client';
import{Location}from'@angular/common';

@Component({
  selector: 'app-ma-fiche-collaborateur',
  templateUrl: './ma-fiche-collaborateur.component.html',
  styleUrls: ['./ma-fiche-collaborateur.component.css']
})
export class MaFicheCollaborateurComponent implements OnInit {

CurrentUser:CollaboratorDTO=new CollaboratorDTO();
public categories!:CategoryDTO[];
public civilStatuses!:  CivilStatusDTO [];
public qualifications!:QualificationDTO [];
public grades!:GradeDTO [];

  constructor(
    private serviceCollaborator:CollaboratorClient,
    private qualificationService: QualificationClient,
    private civilStatusService: CivilStatusClient,
    private categoryService: CategoryClient,
    private gradeService: GradeClient,
    private location:Location
    ) { }
id!:number;

public goBack() {
  this.location.back(); 
}
  ngOnInit(): void 
    {
    
         this.id=Number(localStorage.getItem("currentUserId"));
         
         this.serviceCollaborator.getBYId(this.id).subscribe(data=>this.CurrentUser=data);

         this.categoryService.get().subscribe(data=>this.categories=data);

         this.qualificationService.get().subscribe(data=>this.qualifications=data);
       
       
         this.gradeService.get().subscribe(data=>this.grades=data);
       
       
         this.civilStatusService.get().subscribe(data=>this.civilStatuses=data);
       
       
    }
  

}
