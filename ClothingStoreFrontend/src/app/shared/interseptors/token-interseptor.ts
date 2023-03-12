import {  HttpErrorResponse, HttpEvent, HttpHandler, HttpInterceptor, HttpRequest } from '@angular/common/http';
import { Injectable, Injector } from '@angular/core';
import {  catchError, throwError, switchMap, Observable } from 'rxjs';
import { TokenModel } from '../models/tokenModel';
import { AuthService } from '../services/auth.service';

@Injectable({
  providedIn: 'root'
})
export class TokenInterceptor implements HttpInterceptor {
  
  constructor(private inject: Injector, private authService: AuthService) { }

  intercept(request: HttpRequest<any>, next: HttpHandler): Observable<HttpEvent<unknown>> {
    let tokenModel = new TokenModel()
    tokenModel = this.authService.getTokens()
    this.authService = this.inject.get(AuthService)
    request = request.clone({
      setHeaders:{
        Authorization: 'Bearer ' + tokenModel.accessToken
      }
    })
    return next.handle(request).pipe(
      catchError((err:any)=>{
        if(err instanceof HttpErrorResponse){
          if(err.status === 401){
             return this.handleUnAuthorizedError(request, next)
          }
        } 
        return throwError(()=> console.log(err))
      })
    )
  }

  handleUnAuthorizedError(req: HttpRequest<any>, next: HttpHandler){
    let tokenModel = new TokenModel()
    tokenModel = this.authService.getTokens()
    return this.authService.renewToken(tokenModel).pipe(
      switchMap((data: TokenModel)=>{
        localStorage.setItem('accessToken', data.accessToken)
        localStorage.setItem('refreshToken', data.refreshToken)
        req = req.clone({
        setHeaders:{
          Authorization: 'Bearer ' + data.accessToken
        }
        })
        return next.handle(req)
        }),
          catchError((err)=>{
            return throwError(()=>{
              console.log(err)
            })
          })
        )
  }
}