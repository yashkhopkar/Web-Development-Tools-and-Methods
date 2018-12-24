import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
 
@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit {

  constructor(public router:Router) { }

  email: string;
  password: string;
  ngOnInit() {
  }
  tryLogin(): void {
    if (this.email == 'admin' && this.password == 'admin') {
      this.router.navigate(["home"]);
    } else {
      alert("Invalid credentials");
    }
  }


}
