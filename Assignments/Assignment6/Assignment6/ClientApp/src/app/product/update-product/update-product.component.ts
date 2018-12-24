import { Component, OnInit } from '@angular/core';
import { ProductService } from '../product.service';
import * as _ from 'lodash';

@Component({
  selector: 'app-update-product',
  templateUrl: './update-product.component.html',
  styleUrls: ['./update-product.component.css']
})
export class UpdateProductComponent implements OnInit {
  public productData: Array<any>;
  public currentProduct: any;

  constructor(private productService: ProductService) {
    productService.get().subscribe((data: any) => this.productData = data);
    this.currentProduct = this.setInitialValuesForProductData();
  }
  private setInitialValuesForProductData() {
    return {
      id: undefined,
      name: '',
      isAvailable: false,
    }
  }
  ngOnInit() {

  }
    
}
