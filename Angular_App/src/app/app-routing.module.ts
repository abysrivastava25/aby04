import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

import { ListItemsComponent } from './components/list-items/list-items.component'
import { CartPageComponent } from './components/cart-page/cart-page.component'
import { BuyPageComponent } from './components/buy-page/buy-page.component'
import { LoginComponent } from './components/login/login.component';

import { AboutComponent } from './components/about/about.component';

const routes: Routes = [
  {
    path: '',
    component: ListItemsComponent
  },
  {
    path: 'about',
    component: AboutComponent
  },
  {
    path: 'cart',
    component: CartPageComponent
  },
  {
    path: 'login',
    component: LoginComponent
  },
  {
    path: 'buy',
    component: BuyPageComponent 
  }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
