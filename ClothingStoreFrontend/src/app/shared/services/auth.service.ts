import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Router } from '@angular/router';
import { Login } from '../models/login';
import { Register } from '../models/register';

@Injectable({
  providedIn: 'root'
})
export class AuthService {

  token: any
  tokenString: string

  constructor(private http: HttpClient, private router: Router) { }

  readonly apiUrl = 'https://localhost:7242/api/Account'

  login(login: Login){
    return this.http.post(this.apiUrl + '/SignIn', login).subscribe(data=>{
      this.token = data
      this.tokenString = this.token.token
      localStorage.setItem('token', this.tokenString)
      this.router.navigate([''])
    })
  }

  register(reg: Register){
    return this.http.post(this.apiUrl + '/SignUp', reg).subscribe(data=>{
      this.token = data
      this.tokenString = this.token.token
      localStorage.setItem('token', this.tokenString)
      this.router.navigate([''])
    })
  }

  checkIsAuthorithed(){
    return localStorage.getItem('token') != null
  }

  getToken(){
    return localStorage.getItem('token') || ''
  }
}
