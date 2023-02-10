import { Component, OnInit, Optional,Inject } from '@angular/core';
import { MatDialogRef, MAT_DIALOG_DATA } from '@angular/material/dialog';
import { CareerClient, CareerDTO, CategoryClient, CategoryDTO, CivilStatusClient, CivilStatusDTO, CollaboratorClient, CollaboratorDTO, GradeClient, GradeDTO, QualificationClient, QualificationDTO } from 'src/app/dto/client';

@Component({
  selector: 'app-modify-career',
  templateUrl: './modify-career.component.html',
  styleUrls: ['./modify-career.component.css']
})
export class ModifyCareerComponent implements OnInit {
  career: CareerDTO = new CareerDTO();
  title: string="Modifier Carrriére" ;
  buttonName:string= "Modifier";
  id!:number;


  public categories!: CategoryDTO[];
  public civilStatuses!: CivilStatusDTO[];
  public qualifications!: QualificationDTO[];
  public grades!: GradeDTO[];
  public collaborateurs!: CollaboratorDTO[];

  constructor(private serviceCareer: CareerClient,
     public dialogRef: MatDialogRef<ModifyCareerComponent>,
     private qualificationService: QualificationClient,
     private civilStatusService: CivilStatusClient,
     private categoryService: CategoryClient,
     private gradeService: GradeClient,
     private serviceCollab: CollaboratorClient,
    //@Optional() is used to prevent error if no data is passed
    @Optional() @Inject(MAT_DIALOG_DATA) public data: any) { }

  ngOnInit(): void {
    this.career = this.data.career;
    this.id=this.data.id;

    this.categoryService.get().subscribe(data => this.categories = data);

    this.qualificationService.get().subscribe(data => this.qualifications = data);


    this.gradeService.get().subscribe(data => this.grades = data);


    this.civilStatusService.get().subscribe(data => this.civilStatuses = data);

    this.serviceCollab.get().subscribe(data => this.collaborateurs = data)

    
  }

  close(){
    this.dialogRef.close("close"); 
  }

  saveEmploy() {
   
   
      this.serviceCareer.update(this.id,this.career).subscribe(
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
