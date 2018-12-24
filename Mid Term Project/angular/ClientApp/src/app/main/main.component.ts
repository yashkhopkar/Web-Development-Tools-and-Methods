import { Component, OnInit } from '@angular/core';
import { UserService } from '../user.service';
import { DataService } from '../data.service';
import { forEach } from '@angular/router/src/utils/collection';
import { Router } from '@angular/router';
import { HttpErrorResponse } from '@angular/common/http';

@Component({
  selector: 'app-main',
  templateUrl: './main.component.html',
  styleUrls: ['./main.component.css']
})
export class MainComponent implements OnInit {
//  products: Product[];
  qtys: number[] = [];
  
  constructor(private dataservice: DataService, private router: Router) { }

  ngOnInit() {
    //this.productservice.get().subscribe((data: any) => this.products = data);
  }

  test() {
    alert(this.dataservice.curUser.UserId);
   
  }


  getKeys(item) {
    return Object.keys(item);
  }

  start() {
    this.router.navigate(['game']);
  }

  }


