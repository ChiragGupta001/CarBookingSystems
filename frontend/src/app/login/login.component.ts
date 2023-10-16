import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { AccountService } from '../services/account.service';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { Router } from '@angular/router';
import { of } from 'rxjs';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})

export class LoginComponent implements OnInit {
  token!: any;
  Roles: string;

  ngOnInit() {
    this.token = localStorage.getItem("token");
    if(this.account.isLoggedIn()){
    this.Roles = this.account.decodeToken(this.token, 'role')
    if (this.Roles == "Admin") {
      if (this.account.isLoggedIn()) {
        this.router.navigate(['admin']);
      } else {
        this.router.navigate(['login']);
      }
    } else if (this.Roles == "User") {
      if (this.account.isLoggedIn()) {
        this.router.navigate(['user']);
      } else {
        this.router.navigate(['login']);
      }
    }}
  }

  constructor(private account: AccountService, private fb: FormBuilder, private router: Router) {
    this.Roles = "";
  }

  LoginForm: FormGroup = this.fb.group({
    UserName: ['', Validators.required],
    Password: ['', Validators.required],
    isRemember: [true, Validators.required]
  });

  get password() {
    return this.LoginForm.controls['Password'];
  }

  get UserNames() {
    return this.LoginForm.controls['UserName'];
  }

  login(value: any) {
    this.account.Signin(value).subscribe((res) => {
      localStorage.setItem("token", res.userToken);
      this.Roles = this.account.decodeToken(res.userToken, 'role');
      this.account.login(this.Roles);
      this.account.loger.next(true);
      if (this.Roles == "Admin") {
        this.router.navigate(['admin']);
      } else if (this.Roles == "User") {
        this.router.navigate(['user']);
      }
    })
  }
}
