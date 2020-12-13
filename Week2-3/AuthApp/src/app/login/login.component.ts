import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { AuthServices } from '../auth-service.service';
import { loginModel } from '../login-model';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class loginComponent {
  public model: loginModel;
  showLoginWarningMessage: boolean = false;
  returnUrl: string = '';

  constructor(
      private auth: AuthServices,
      private router: Router,
      private route: ActivatedRoute) {
      this.model = new loginModel();
  }
  ngOnInit() {
      if (this.auth.validateUserTocken()) {
          //update your logic accordingly
          //this will trigger while user clicks on back button, 
          //before naviagting to login page
          alert('You will be logged out');
      }
      this.auth.logout();
      this.returnUrl = this.route.snapshot.queryParams['returnUrl'] || 'dashboard';
  }

  login() {
      this.showLoginWarningMessage = false;
      if (this.auth.validateUserDetails(this.model)) {
          this.auth.setTocken();
          this.router.navigate([this.returnUrl]);
      } else {
          console.log('Invalid credentials');
          this.showLoginWarningMessage = true;
      }

  }
}