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
  accessToken: string

  constructor(private http: HttpClient, private router: Router) { }

  readonly apiUrl = 'https://localhost:7190/api/Account'

  login(login: Login){
    return this.http.post(this.apiUrl + '/SignIn', login).subscribe(data=>{
      console.log(data)
      this.token = data
      this.accessToken = this.token.accessToken
      console.log(this.accessToken)
      localStorage.setItem('token', this.accessToken)
      this.router.navigate([''])
    })
  }

  register(reg: Register){
    return this.http.post(this.apiUrl + '/SignUp', reg).subscribe(data=>{
      this.token = data
      this.accessToken = this.token.accessToken
      localStorage.setItem('token', this.accessToken)
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
