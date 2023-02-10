import { ComponentFixture, TestBed } from '@angular/core/testing';

import { MaFicheCollaborateurComponent } from './ma-fiche-collaborateur.component';

describe('MaFicheCollaborateurComponent', () => {
  let component: MaFicheCollaborateurComponent;
  let fixture: ComponentFixture<MaFicheCollaborateurComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ MaFicheCollaborateurComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(MaFicheCollaborateurComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
