import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { CollaborateurComponent } from './components/collaborateur/collaborateur.component';
import { CollaborateursComponent } from './components/collaborateurs/collaborateurs.component';
import { DashboardComponent } from './components/dashboard/dashboard.component';
import { EntityComponent } from './components/entity/entity.component';
import { ErrorComponent } from './components/error/error.component';
import { LoginComponent } from './components/login/login.component';
import { MaFicheCollaborateurComponent } from './components/ma-fiche-collaborateur/ma-fiche-collaborateur.component';
import { MonCompteComponent } from './components/mon-compte/mon-compte.component';
import { PresentationComponent } from './components/presentation/presentation.component';
import { ProfilsComponent } from './components/profils/profils.component';
import { ProjetsComponent } from './components/projets/projets.component';
import { AuthGuard } from './help/auth.guard';

const routes: Routes = [
  {path:"dashboard",title:"menu",component:DashboardComponent,canActivate:[AuthGuard],
  children:[
    {path:"collaborateurs",title:"Collaborateurs", component:CollaborateursComponent},
    {path:"collaborateurs/:id",title:"Collaborateur", component:CollaborateurComponent},
    {path:"profils",title:"Profils", component:ProfilsComponent},
    {path:"maFiche", title:"Ma Fiche Collaborateur", component:MaFicheCollaborateurComponent},
    {path:'projets',title:"Projets",component:ProjetsComponent},
    {path:'compte',title:"Compte",component:MonCompteComponent},
    {path:'entreprise',title:"Entreprise",component:EntityComponent},
    {
      path:'presentation',title:"Presentation",component:PresentationComponent
    },
    {path:'',redirectTo:"presentation",pathMatch:'full'}
  ]

},
  {path:"login",title:"login",component:LoginComponent},
  
  {path:'',redirectTo:"dashboard",pathMatch:'full'},
  {
    path:"**",title:"error",component:ErrorComponent
  }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
