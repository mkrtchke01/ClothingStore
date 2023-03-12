import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Router } from '@angular/router';
import { Login } from '../models/login';
import { Register } from '../models/register';
import { TokenModel } from '../models/tokenModel';

@Injectable({
  providedIn: 'root'
})
export class AuthService {


  constructor(private http: HttpClient, private router: Router) { }

  readonly apiUrl = 'https://localhost:7190/api/Account'

  login(login: Login){
    return this.http.post(this.apiUrl + '/signIn', login).subscribe((data:any)=>{
      console.log(data.accessToken)
      localStorage.setItem('accessToken', data.accessToken)
      localStorage.setItem('refreshToken', data.refreshToken)
      this.router.navigate([''])
    })
  }

  register(reg: Register){
    return this.http.post(this.apiUrl + '/signUp', reg).subscribe((data:any)=>{
      localStorage.setItem('accessToken', data.accessToken)
      localStorage.setItem('refreshToken', data.refreshToken)
      this.router.navigate([''])
    })
  }

  checkIsAuthorithed(){
    return localStorage.getItem('accessToken') != null
  }

  getAccessToken(){
    return localStorage.getItem('accessToken') || ''
  }

  getRefreshToken(){
    return localStorage.getItem('refreshToken') || ''
  }

  renewToken(token: TokenModel){
    console.log("renewToken")
    return this.http.post<any>(this.apiUrl + '/refresh', token)
  }
}
