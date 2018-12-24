import { Component, OnInit } from '@angular/core';
import { LogInfo } from '../LogInfo';
import { UserService } from '../user.service';
import { DataService } from '../data.service';
import { User } from '../User';
import { Router } from '@angular/router';
import { HttpErrorResponse } from '@angular/common/http';


@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit {
  userName: string;
  password: string;
  data: User;
  isLoginError: boolean = false;
  loginfo: LogInfo;
  constructor(private userservice: UserService, private dataservice: DataService, private router: Router) {
  }

  ngOnInit() {
    if (this.dataservice.curUser.UserId != -1)
      this.router.navigate(['logout']);
  }

  checkIfUserValid() {
    this.loginfo = {
      UserName: this.userName,
      PassWord: this.password
    };
    this.userservice.login(this.loginfo).subscribe((data: number) => {
      this.dataservice.curUser.UserId = data; this.router.navigate(['main']);
    }, (err: HttpErrorResponse) => {
      alert("Unvalid user name or password.");
    });
  }

  register() {
    this.loginfo = {
      UserName: this.userName,
      PassWord: this.password
    };
    this.userservice.register(this.loginfo).subscribe((data: number) => {
      this.dataservice.curUser.UserId = data; this.router.navigate(['main']);
    }, (err: HttpErrorResponse) => {
      alert("The user name have already exsited.");
    });
  }

}
