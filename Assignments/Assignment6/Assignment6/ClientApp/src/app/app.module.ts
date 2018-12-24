import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';
import { RouterModule, Routes } from '@angular/router';

import { AppComponent } from './app.component';
import { NavMenuComponent } from './nav-menu/nav-menu.component';
import { HomeComponent } from './home/home.component';
import { CounterComponent } from './counter/counter.component';
import { FetchDataComponent } from './fetch-data/fetch-data.component';
import { ProductService } from './product/product.service';
import { AddOrUpdateProductComponent } from './product/add-or-update-product/add-or-update-product.component';
import { GridProductComponent } from './product/GridProduct.component';

import * as _ from 'lodash';
import { UpdateProductComponent } from './product/update-product/update-product.component';
import { LoginComponent } from './login/login.component';

const appRoutes: Routes = [
  { path: '', component: HomeComponent }
 
    ];

@NgModule({
  declarations: [
    AppComponent,
    NavMenuComponent,
    HomeComponent,
    CounterComponent,
    FetchDataComponent,
    AddOrUpdateProductComponent,
    GridProductComponent,
    UpdateProductComponent,
    LoginComponent
  ],
  imports: [
    BrowserModule.withServerTransition({ appId: 'ng-cli-universal' }),
    HttpClientModule,
    FormsModule,
    RouterModule.forRoot([
      { path: '', component: LoginComponent, pathMatch: 'full' },
      { path: 'counter', component: CounterComponent },
      { path: 'fetch-data', component: FetchDataComponent },
      { path: 'update-product', component: UpdateProductComponent },
      { path: 'home', component: HomeComponent}
    ])
  ],
  providers: [ ProductService ],
  bootstrap: [AppComponent]
})
export class AppModule { }
