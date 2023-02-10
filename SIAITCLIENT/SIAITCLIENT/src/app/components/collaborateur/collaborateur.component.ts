import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormControl, FormGroup, Validators } from '@angular/forms';
import { ActivatedRoute, Router } from '@angular/router';
import { CategoryClient, CategoryDTO, CivilStatusClient, CivilStatusDTO, CollaboratorClient, CollaboratorDTO, GradeClient, GradeDTO, QualificationClient, QualificationDTO } from 'src/app/dto/client';
import{Location}from'@angular/common';
@Component({
  selector: 'app-collaborateur',
  templateUrl: './collaborateur.component.html',
  styleUrls: ['./collaborateur.component.css']
})
export class CollaborateurComponent implements OnInit {
id!:number;
collaborateur:CollaboratorDTO=new CollaboratorDTO();
updatedCollab:CollaboratorDTO=new CollaboratorDTO();
public collaborator: any = {};
public collaboratorForm!:FormGroup;

public categories!:CategoryDTO[];
public civilStatuses!:  CivilStatusDTO [];
public qualifications!:QualificationDTO [];
public grades!:GradeDTO [];
public ismine: boolean = false;
public disableCareerFields: boolean = false;

private selectedTabIndex: number = 0;

// public setSelectedTab($event) {
//     this.selectedTabIndex = $event.index;
//     this.gridStateService.setSelectedTab(this, this.selectedTabIndex);
// }

constructor(private route: ActivatedRoute,
    private router: Router,
    private collaboratorService: CollaboratorClient,
    private qualificationService: QualificationClient,
    private civilStatusService: CivilStatusClient,
    private categoryService: CategoryClient,
    private gradeService: GradeClient,
    private location: Location,
   public fb:FormBuilder,
    private activateRoute:ActivatedRoute
   ) {}

ngOnInit() {
  this.categoryService.get().subscribe(data=>this.categories=data);

  this.qualificationService.get().subscribe(data=>this.qualifications=data);


  this.gradeService.get().subscribe(data=>this.grades=data);


  this.civilStatusService.get().subscribe(data=>this.civilStatuses=data);


  this.id = this.activateRoute.snapshot.params['id'];


  this.collaboratorForm = this.collaboratorForm || new FormGroup({
    firstNameControl: new FormControl('', Validators.required),
    lastNameControl: new FormControl('', Validators.required),
    telControl: new FormControl(''),
    emailControl: new FormControl('', [Validators.required, Validators.email]),
    salaryControl: new FormControl({value:'',disabled:true}),
    hiringDateControl: new FormControl('', Validators.required),
    birthDateControl: new FormControl(new Date(), Validators.required),
    cnssControl: new FormControl('', Validators.required),
    cinControl: new FormControl('', Validators.required),
    registrationNumberControl: new FormControl('', Validators.required),
    bbanControl: new FormControl({value:'',disabled:true}, Validators.required),
    leaveBalanceControl: new FormControl({value:'',disabled:true}, Validators.required),
    numberOfChildlrenControl: new FormControl({value:'',disabled:true}, Validators.required),
    houseHolderControl: new FormControl(this.collaborateur.houseHolder),
    categoryControl: new FormControl({value:'',disabled:true}, Validators.required),
    qualificationControl: new FormControl({value:'',disabled:true}, Validators.required),
    civilStatusControl: new FormControl({value:'',disabled:true}, Validators.required),
    gradeControl: new FormControl({value:'',disabled:true}, Validators.required),
    sexControl: new FormControl('', Validators.required)
})


   this.collaboratorService.getBYId(this.id).subscribe(data=>{this.collaborateur=data;
    // this.collaboratorForm=this.fb.nonNullable.group({
    //   firstNameControl:[this.collaborateur?.firstName,Validators.required],
    //   lastNameControl:[this.collaborateur?.lastName,Validators.required],
    //   telControl:[this.collaborateur?.phoneNumber,Validators.required],
    //   categoryControl:[this.collaborateur?.category,Validators.required],
    //   emailControl:[this.collaborateur?.email,Validators.required],
    //   salaryControl:[this.collaborateur?.salary],
    //   hiringDateControl:[this.collaborateur?.hiringDate,Validators.required]}) 
   
  });
   
}
save()
{
 // console.log(this.collaborateur)
 this.collaboratorService.update(this.id,this.collaborateur).subscribe();
}
public loadCollaborator() {
    // this.collaboratorService.getOneDetails(this.id).subscribe((response: any) => {
    //     this.collaborator = response.data;
    //     this.isMine();
    // });
}

public canEdit() {
   // return (this.id && this.userService.hasAction("#EDIT_COLLABORATORS")) || (!this.id && this.userService.hasAction("#ADD_COLLABORATORS"));
}
public goBack() {
  this.location.back(); 
}
private disabledFields() {
    this.disableCareerFields = true;
    let controls = ['salaryControl', 'bbanControl', 'numberOfChildlrenControl', 'houseHolderControl', 'leaveBalanceControl'];
    for (let control of controls) {
        this.collaboratorForm.controls[control].disable();
    }
}

public toggleHouseHolder() {
    // if (!this.disableCareerFields)
    //     this.collaborator.houseHolder = !this.collaborator.houseHolder
}

// private loadEnumerations(cb: () => any = null) {
//     return forkJoin([
//         this.categoryService.find({ sort: { 'name': 'asc' } }),
//         this.qualificationService.find({ sort: { 'name': 'asc' } }),
//         this.civilStatusService.find({ sort: { 'name': 'asc' } }),
//         this.gradeService.find({ sort: { 'name': 'asc' } })
//     ]
//     ).subscribe(([response1, response2, response3, response4]: Array<any>) => {
//         this.categories = response1.data;
//         this.qualifications = response2.data;
//         this.civilStatuses = response3.data;
//         this.grades = response4.data;
//         if (cb)
//             cb();
//     });
// }

// public saveError: string = null;
// public save() {
//     this.saveError = null;
//     let query;
//     if (this.id)
//         query = this.collaboratorService.update(this.collaborator);
//     else
//         query = this.collaboratorService.create(this.collaborator);
//     query.subscribe((response: any) => {
//         this._snackBar.open('Opération efféctuée avec succés !', 'OK', {
//             duration: 3000,
//             horizontalPosition: "center",
//             verticalPosition: "bottom",
//         });
//         if (!this.collaborator.id) {
//             this.collaborator = response.data;
//             this.router.navigate(["collaborators/edit", this.collaborator.id]);
//         }
//     }, (response: any) => {
//         if (response.error && response.error.data) {
//             if (response.error.data.code === "#UNITICY_ERROR") {
//                 let fields = response.error.data.fields;
//                 if (fields.length > 1)
//                     this.saveError = "Les champs " + fields.join(', ') + " doivent etre uniques";
//                 else
//                     this.saveError = "Le champ " + fields[0] + " doit etre unique";
//             }
//         }
//     });

// }

public isMine() {
    this.ismine = this.id === 0;
}

public isAuthorizedToSave() {
    // if (this.id)
    //     return this.userService.hasAction("#EDIT_COLLABORATORS");
    // return this.userService.hasAction("#ADD_COLLABORATORS");
}

public disableAllFormControls() {
    for (let controlName in this.collaboratorForm.controls)
        this.collaboratorForm.controls[controlName].disable();
}


}

