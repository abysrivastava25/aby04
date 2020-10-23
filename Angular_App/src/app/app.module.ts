import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { HttpClientModule } from '@angular/common/http';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { ListItemsComponent } from './components/list-items/list-items.component';
import { CartPageComponent } from './components/cart-page/cart-page.component';
import { BuyPageComponent } from './components/buy-page/buy-page.component';

import { BaseService } from './core/http-services/baseService.service'
import { CartService } from './core/data-service/cartService.Service';
import { LoginComponent } from './components/login/login.component';
import { FormsModule } from '@angular/forms';
import { AboutComponent } from './components/about/about.component';




@NgModule({
  declarations: [
    AppComponent,
    ListItemsComponent,
    CartPageComponent,
    BuyPageComponent,
    LoginComponent,
    AboutComponent,
    
  
 
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    FormsModule
   
  ],
  providers: [BaseService,CartService],
  bootstrap: [AppComponent]
})
export class AppModule { }
