import { Component, OnInit } from '@angular/core';
import { Register } from 'src/app/shared/models/register';
import { AuthService } from 'src/app/shared/services/auth.service';

@Component({
  selector: 'app-register',
  templateUrl: './register.component.html',
  styleUrls: ['./register.component.css']
})
export class RegisterComponent implements OnInit {

  constructor(private authService: AuthService) {
    localStorage.clear()
   }

  registerModel: Register = new Register

  ngOnInit(): void {
  }

  register(){
    this.authService.register(this.registerModel)
  }

}
