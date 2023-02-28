import { Component, OnInit } from '@angular/core';
import { Product } from 'src/app/shared/models/product';
import { CatalogService } from 'src/app/shared/services/catalog.service';

@Component({
  selector: 'app-catalog',
  templateUrl: './catalog.component.html',
  styleUrls: ['./catalog.component.css']
})
export class CatalogComponent implements OnInit {

  products : Product[]

  constructor(private catalogService : CatalogService) { }

  ngOnInit(): void {
    this.getAllProducts();
  }

  getAllProducts(){
    this.catalogService.getAllProducts().subscribe(data => {
      this.products = data;
    });
  }

}
