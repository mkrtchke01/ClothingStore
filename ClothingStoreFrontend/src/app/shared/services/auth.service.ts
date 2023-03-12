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
      this.setTokens(data);
      this.router.navigate([''])
    })
  }

  register(reg: Register){
    return this.http.post(this.apiUrl + '/signUp', reg).subscribe((data:any)=>{
      this.setTokens(data);
      this.router.navigate([''])
    })
  }

  checkIsAuthorithed(){
    return localStorage.getItem('accessToken') != null
  }

  getTokens(){
    let tokenModel: TokenModel = new TokenModel()
    tokenModel.accessToken = localStorage.getItem('accessToken') || ''
    tokenModel.refreshToken = localStorage.getItem('refreshToken') || ''
    return tokenModel
  }
  setTokens(tokenModel : TokenModel){
    localStorage.setItem('accessToken', tokenModel.accessToken)
    localStorage.setItem('refreshToken', tokenModel.refreshToken)
  }

  renewToken(token: TokenModel){
    return this.http.post<any>(this.apiUrl + '/refresh', token)
  }
}
