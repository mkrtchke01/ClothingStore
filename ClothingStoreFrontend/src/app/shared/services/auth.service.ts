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
  refreshToken: string

  constructor(private http: HttpClient, private router: Router) { }

  readonly apiUrl = 'https://localhost:7190/api/Account'

  login(login: Login){
    return this.http.post(this.apiUrl + '/signIn', login).subscribe(data=>{
      console.log(data)
      this.token = data
      this.accessToken = this.token.accessToken
      this.refreshToken = this.token.refreshToken
      console.log(this.accessToken)
      localStorage.setItem('accessToken', this.accessToken)
      localStorage.setItem('refreshToken', this.refreshToken)
      this.router.navigate([''])
    })
  }

  register(reg: Register){
    return this.http.post(this.apiUrl + '/signUp', reg).subscribe(data=>{
      this.token = data
      this.accessToken = this.token.accessToken
      this.refreshToken = this.token.refreshToken
      localStorage.setItem('accessToken', this.accessToken)
      localStorage.setItem('refreshToken', this.refreshToken)
      this.router.navigate([''])
    })
  }

  checkIsAuthorithed(){
    return localStorage.getItem('accessToken') != null
  }

  getToken(){
    return localStorage.getItem('accessToken') || ''
  }
}
