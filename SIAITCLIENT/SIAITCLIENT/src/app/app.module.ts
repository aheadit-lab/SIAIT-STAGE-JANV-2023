import { HttpClient, HttpClientModule, HttpHandler } from '@angular/common/http';
import { InjectionToken, NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { environment } from 'src/environments/environment';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { DashboardComponent } from './components/dashboard/dashboard.component';
import { API_BASE_URL } from './dto/client';
import { LoginComponent } from './components/login/login.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import {MatFormFieldModule} from '@angular/material/form-field';
import { MatInputModule } from '@angular/material/input';
import {MatToolbarModule} from '@angular/material/toolbar';
import {MatIconModule} from '@angular/material/icon';
import {MatSidenavModule} from '@angular/material/sidenav';
import {MatListModule} from '@angular/material/list';
import { TokenInterceptorProvider } from './help/token.interceptor';
import { ErrorComponent } from './components/error/error.component';
import {MatExpansionModule} from '@angular/material/expansion';
import { CollaborateursComponent } from './components/collaborateurs/collaborateurs.component';
import {MatTableModule} from '@angular/material/table';
import {MatPaginatorModule} from '@angular/material/paginator';
import {MatButtonModule} from '@angular/material/button';
import { ConfirmDiagComponent } from './diag/confirm-diag/confirm-diag.component';
import {MatDialogModule} from '@angular/material/dialog';
import { DetailCollaborateurComponent } from './diag/detail-collaborateur/detail-collaborateur.component';
import {MatCardModule} from '@angular/material/card';
import {MatDatepickerModule} from '@angular/material/datepicker';
import { MatNativeDateModule } from '@angular/material/core';
import { AjouterCollabComponent } from './diag/ajouter-collab/ajouter-collab.component';
import {MatCheckboxModule} from '@angular/material/checkbox';
import { ProfilsComponent } from './components/profils/profils.component';
import { CollaborateurComponent } from './components/collaborateur/collaborateur.component';
import {MatSelectModule} from '@angular/material/select';
import {MatTabsModule} from '@angular/material/tabs';
import { CareerComponent } from './components/career/career.component';
import { AddCareerComponent } from './diag/add-career/add-career.component';
import { ModifyCareerComponent } from './diag/modify-career/modify-career.component';
import { ModifyProfilComponent } from './diag/modify-profil/modify-profil.component';
import { AddProfileComponent } from './diag/add-profile/add-profile.component';
import { MaFicheCollaborateurComponent } from './components/ma-fiche-collaborateur/ma-fiche-collaborateur.component';
import { ProjetsComponent } from './components/projets/projets.component';
import { PresentationComponent } from './components/presentation/presentation.component';
import { AddProjectComponent } from './diag/add-project/add-project.component';
import { ModifyProjectComponent } from './diag/modify-project/modify-project.component';
import {MatMenuModule} from '@angular/material/menu';
import { MonCompteComponent } from './components/mon-compte/mon-compte.component';
import { EntityComponent } from './components/entity/entity.component';

@NgModule({
  declarations: [
    AppComponent,
    DashboardComponent,
    LoginComponent,
    ErrorComponent,
    CollaborateursComponent,
    ConfirmDiagComponent,
    
    DetailCollaborateurComponent,
         AjouterCollabComponent,
         ProfilsComponent,
         CollaborateurComponent,
         CareerComponent,
         AddCareerComponent,
         ModifyCareerComponent,
         ModifyProfilComponent,
         AddProfileComponent,
         MaFicheCollaborateurComponent,
         ProjetsComponent,
         PresentationComponent,
         AddProjectComponent,
         ModifyProjectComponent,
         MonCompteComponent,
         EntityComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    BrowserAnimationsModule,
    ReactiveFormsModule,
    MatFormFieldModule,
    MatInputModule,
    MatToolbarModule,
    MatIconModule,
    MatSidenavModule,
    MatListModule,
    MatExpansionModule,
    MatTableModule,
    MatPaginatorModule,
    MatButtonModule,
    MatDialogModule,
    MatCardModule,
    FormsModule,
    MatDatepickerModule,
    MatNativeDateModule,
    MatCheckboxModule,
    MatSelectModule,
    MatTabsModule,
    MatMenuModule
  ],
  providers: [
   {
    provide: API_BASE_URL,
            useValue: environment.apiRoot
   },
   TokenInterceptorProvider
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
