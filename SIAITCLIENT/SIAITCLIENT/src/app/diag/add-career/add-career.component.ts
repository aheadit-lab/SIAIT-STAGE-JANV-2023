import { Component, OnInit, Optional, Inject } from '@angular/core';
import { MatDialogRef, MAT_DIALOG_DATA } from '@angular/material/dialog';
import { CareerClient, CareerDTO, CategoryClient, CategoryDTO, CivilStatusClient, CivilStatusDTO, CollaboratorClient, CollaboratorDTO, GradeClient, GradeDTO, ProfilDTO, QualificationClient, QualificationDTO } from 'src/app/dto/client';

@Component({
  selector: 'app-add-career',
  templateUrl: './add-career.component.html',
  styleUrls: ['./add-career.component.css']
})
export class AddCareerComponent implements OnInit {

  collaborateur: CollaboratorDTO = new CollaboratorDTO();
  title: string = "Ajouter une carrière ";
  buttonName: string = "Add";
  emailPattern: string = "^[a-z0-9._%+-]+@[a-z0-9.-]+\.[a-z]{2,4}$";
  id!: number;
  public categories!: CategoryDTO[];
  public civilStatuses!: CivilStatusDTO[];
  public qualifications!: QualificationDTO[];
  public profils!: ProfilDTO[];
  public grades!: GradeDTO[];
  public collaborateurs!: CollaboratorDTO[];
  public career: CareerDTO = new CareerDTO();
  constructor(
    private serviceCareer: CareerClient,
    public dialogRef: MatDialogRef<AddCareerComponent>,
    private qualificationService: QualificationClient,
    private civilStatusService: CivilStatusClient,
    private categoryService: CategoryClient,
    private gradeService: GradeClient,
    private serviceCollab: CollaboratorClient,
    private careerService: CareerClient,
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
  close() {
    this.dialogRef.close("close");
  }

  saveEmploy() {

    //cas modif : else if id!=0
     this.career.collaboratorId=this.id;
     
    this.serviceCareer.create(this.career).subscribe(
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


