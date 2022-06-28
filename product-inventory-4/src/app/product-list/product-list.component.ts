import { Component, OnInit } from '@angular/core';
import { Product } from '../models/product.model';
import { ProductService } from '../services/product.service';

@Component({
  selector: 'app-product-list',
  templateUrl: './product-list.component.html',
  styleUrls: ['./product-list.component.css']
})
export class ProductListComponent implements OnInit {
  products: Array<Product> = [];

  constructor(private productService: ProductService) { }

  ngOnInit(): void {
    this.getProducts();
  }

  onDelete(id: number, event: Event) {
    event.stopPropagation();
    this.productService.delete(id).subscribe(
      () => this.getProducts());
  }

  private getProducts() {
    this.productService.get().subscribe(
      products => this.products = products);
  }
}