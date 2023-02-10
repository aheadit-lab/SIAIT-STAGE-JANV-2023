import { Component, OnInit } from '@angular/core';
import { CategoryClient, CategoryDTO, CollaboratorClient, CollaboratorDTO, MenuClient, MenuDTO, ModuleClient, ModuleDTO } from 'src/app/dto/client';
import { TokenService } from 'src/app/services/token.service';

@Component({
  selector: 'app-dashboard',
  templateUrl: './dashboard.component.html',
  styleUrls: ['./dashboard.component.css']
})
export class DashboardComponent implements OnInit {
  Category !: CategoryDTO[] | undefined;
  showFiller: { [id: number]: boolean } = {};
  Modules!: ModuleDTO[];
  Menus: MenuDTO[] | undefined = [];
  id!: number;
  role!:string | null;
  currentUser!: CollaboratorDTO;
  constructor(private clientService: CategoryClient, 
    private moduleServ: ModuleClient, 
    private tokenService:TokenService,
    private menuServ: MenuClient, 
    
    private serviceCollab: CollaboratorClient) { }

  toggleMenu(module: ModuleDTO) {
    this.showFiller[module.id!] = !(this.showFiller[module.id!]);

  }

  showMenus(id:number)
  {
    return this.showFiller[id];
  }

  getMenusByModule = (module: ModuleDTO) => this.Menus?.filter(m => m.moduleId === module.id);
  
  disconnect()
  {
    this.tokenService.clearToken();
    localStorage.removeItem('currentUserId');
    localStorage.removeItem('profilId');
    window.location.reload();
  }


 

  ngOnInit(): void {
     this.clientService.get().subscribe(data=>console.log(data))
    this.moduleServ.get().subscribe(data => {
      this.Modules = data;
      this.role=localStorage.getItem('profilId');
      if(Number(this.role)!=1)
      {
        this.Modules=this.Modules.filter(m=>!m.onlySuperUser);
      }
      
      this.Modules.forEach(m => this.showFiller[m.id!] = false);
    });

    this.menuServ.get().subscribe(data => {
      
      this.Menus = data;
      if(Number(this.role)!=1)
      {
        this.Menus=this.Menus.filter(m=>!m.onlySuperUser);
      }
      else 
      {
        this.Menus=this.Menus.filter(m=>m.title!="Ma fiche collaborateur");
      }
    });
    
  }

}
