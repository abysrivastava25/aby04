import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { RouterModule } from '@angular/router';
import { appRoutes } from './app-routing.module';
import { FormsModule } from '@angular/forms';

// Components
import { AppComponent } from './app.component';
import { DashboardComponent } from './dashboard/dashboard.component';
import { loginComponent } from './login/login.component';
import { AuthServices } from './auth-service.service';
import { AuthGuardService } from './auth-guard-service.guard';

// Services

@NgModule({
  declarations: [
    AppComponent,
    DashboardComponent,
    loginComponent
  ],
  imports: [
    BrowserModule,
    FormsModule,
    RouterModule.forRoot(appRoutes)
  ],
  providers: [AuthServices, AuthGuardService],
  bootstrap: [AppComponent]
})
export class AppModule { }
