import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ModifyProjectComponent } from './modify-project.component';

describe('ModifyProjectComponent', () => {
  let component: ModifyProjectComponent;
  let fixture: ComponentFixture<ModifyProjectComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ ModifyProjectComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(ModifyProjectComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
