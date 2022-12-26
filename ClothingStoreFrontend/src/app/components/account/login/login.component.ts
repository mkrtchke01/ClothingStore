import { Component, OnInit } from '@angular/core';
import { Login } from 'src/app/shared/models/login';
import { AuthService } from 'src/app/shared/services/auth.service';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit {

  constructor(private authService: AuthService) {
    localStorage.clear();
   }

  loginModel: Login = new Login

  
  ngOnInit(): void {
  }

  login(){
    this.authService.login(this.loginModel)
  }

}
