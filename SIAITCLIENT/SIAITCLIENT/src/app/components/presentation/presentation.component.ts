import { Component, OnInit } from '@angular/core';
import { CollaboratorClient, CollaboratorDTO, EntityClient, EntityDTO, QualificationClient, QualificationDTO } from 'src/app/dto/client';

@Component({
  selector: 'app-presentation',
  templateUrl: './presentation.component.html',
  styleUrls: ['./presentation.component.css']
})
export class PresentationComponent implements OnInit {
  currentUser: CollaboratorDTO=new CollaboratorDTO();
  id!:number;
  entite:EntityDTO=new EntityDTO();
  qualification:QualificationDTO=new QualificationDTO();
  constructor(private serviceCollaborator:CollaboratorClient,
    private serviceQualification: QualificationClient,
    private serviceEntité:EntityClient) { }

  ngOnInit(): void {
    this.id=Number(localStorage.getItem("currentUserId"));
         
    this.serviceCollaborator.getBYId(this.id).subscribe(data=>{this.currentUser=data

    this.serviceQualification.getBYId(data.qualificationId!).subscribe(data=>this.qualification=data)
  });

  this.serviceEntité.getBYId(1).subscribe(data=>this.entite=data)
}

}
