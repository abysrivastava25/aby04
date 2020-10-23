import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit {
alert:boolean=false;
email:string;
password:string;
  constructor( private route:Router) { }

  ngOnInit(): void {
  }
  logIn(){
    if(this.email == "admin@test.com"&& this.password == "test123"){
    this.route.navigateByUrl('/buy');
  }
  else{
    alert("Please enter valid info");
  }

}
}
