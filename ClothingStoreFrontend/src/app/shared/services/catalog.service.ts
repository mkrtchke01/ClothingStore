import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Product } from '../models/product';
import { Observable } from 'rxjs'

@Injectable({
    providedIn: 'root'
  })
  export class CatalogService {
  
    products : Product[]
  
    constructor(private http: HttpClient) { }
  
    readonly apiUrl = 'https://localhost:7190/api/Product'

    getAllProducts(){
        return this.http.get<Product[]>(this.apiUrl + "/getAllProducts")
    }
  }