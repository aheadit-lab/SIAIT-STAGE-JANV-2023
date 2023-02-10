import { Component, OnInit } from '@angular/core';
import { MatDialogRef } from '@angular/material/dialog';

@Component({
  selector: 'app-confirm-diag',
  templateUrl: './confirm-diag.component.html',
  styleUrls: ['./confirm-diag.component.css']
})
export class ConfirmDiagComponent implements OnInit {

  constructor(public dialogRef: MatDialogRef<ConfirmDiagComponent>) { }

  ngOnInit(): void {
  }
  confirm(){
    this.dialogRef.close(true)
   }
   close(){
     this.dialogRef.close();
   }
}
