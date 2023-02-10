import { Component, ViewChild } from '@angular/core';
import { LoginComponent } from './components/login/login.component';
import { TokenService } from './services/token.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'SIAITCLIENT';

  @ViewChild("login")
  login!: LoginComponent;

  constructor(private tokenService: TokenService) {
  }

  public isAuth = () => !!this.tokenService.getToken() || (this.login?.isAuth ??false);

}
