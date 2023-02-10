import { Component, OnInit,Inject, Optional } from '@angular/core';
import { MatDialogRef, MAT_DIALOG_DATA } from '@angular/material/dialog';
import { CareerClient, CareerDTO, CategoryClient, CategoryDTO, CivilStatusClient, CivilStatusDTO, CollaboratorClient, CollaboratorDTO, GradeClient, GradeDTO, ProfilClient, ProfilDTO, QualificationClient, QualificationDTO } from 'src/app/dto/client';

@Component({
  selector: 'app-ajouter-collab',
  templateUrl: './ajouter-collab.component.html',
  styleUrls: ['./ajouter-collab.component.css']
})
export class AjouterCollabComponent implements OnInit {
  collaborateur: CollaboratorDTO = new CollaboratorDTO();
  title:string= "Ajouter un collaborateur ";
  buttonName: string="Add";
  emailPattern: string = "^[a-z0-9._%+-]+@[a-z0-9.-]+\.[a-z]{2,4}$";
id!:number;
public categories!:CategoryDTO[];
public civilStatuses!:  CivilStatusDTO [];
public qualifications!:QualificationDTO [];
public profils!:ProfilDTO[];
public grades!:GradeDTO [];
public career:CategoryDTO=new CategoryDTO();
  constructor(
    private servicecollabo:CollaboratorClient,
    public dialogRef: MatDialogRef<AjouterCollabComponent>, 
    private qualificationService: QualificationClient,
    private civilStatusService: CivilStatusClient,
    private categoryService: CategoryClient,
    private gradeService: GradeClient,
    private profilService:ProfilClient,
    private careerService:CareerClient,
  @Optional() @Inject(MAT_DIALOG_DATA) public data: any) { }
  ngOnInit(): void {
    this.collaborateur = this.data.collaborateur;
    this.categoryService.get().subscribe(data=>this.categories=data);

    this.qualificationService.get().subscribe(data=>this.qualifications=data);
  
  
    this.gradeService.get().subscribe(data=>this.grades=data);
  
  
    this.civilStatusService.get().subscribe(data=>this.civilStatuses=data);

    this.profilService.get().subscribe(data=>this.profils=data);

    
  
  }
  close(){
    this.dialogRef.close("close"); 
  }

  saveEmploy() {
   
    //cas modif : else if id!=0
   
      this.servicecollabo.create(this.collaborateur).subscribe(
        data => {
         this.careerService.create(this.collaborateur).subscribe();
          this.dialogRef.close(true)

        },
        error => {
          console.log(error)
          this.dialogRef.close(false)

        }
      )
    
  }
}
function ngOnInit() {
  throw new Error('Function not implemented.');
}

