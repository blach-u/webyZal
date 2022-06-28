import { Component, OnInit } from '@angular/core';
import { NgForm } from '@angular/forms';
import { Router } from '@angular/router';
import { Product } from '../models/product.model';
import { ProductService } from '../services/product.service';

@Component({
  selector: 'app-product-add',
  templateUrl: './product-add.component.html',
  styleUrls: ['./product-add.component.css']
})
export class ProductAddComponent{
  product!: Product;

  constructor(
    private productService: ProductService,
    private router: Router) { }

  async onSave(form: NgForm){

    const prod = new Product(
        form.value.id,
        form.value.name,
        form.value.description,
        form.value.price,
        form.value.quantity,
    )
    this.productService.add(prod).subscribe(
      () => this.router.navigate(['home']));
  }
}
