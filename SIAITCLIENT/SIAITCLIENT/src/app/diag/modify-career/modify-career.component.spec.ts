import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ModifyCareerComponent } from './modify-career.component';

describe('ModifyCareerComponent', () => {
  let component: ModifyCareerComponent;
  let fixture: ComponentFixture<ModifyCareerComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ ModifyCareerComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(ModifyCareerComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
