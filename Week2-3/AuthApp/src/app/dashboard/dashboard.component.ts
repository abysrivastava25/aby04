import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { AuthServices } from '../auth-service.service';

@Component({
  selector: 'app-dashboard',
  templateUrl: './dashboard.component.html',
  styleUrls: ['./dashboard.component.css']
})
export class DashboardComponent {
  constructor(private auth: AuthServices, private route: Router) { }
  logOut() {
      this.auth.logout();
      this.route.navigate(['login']);
  }
}