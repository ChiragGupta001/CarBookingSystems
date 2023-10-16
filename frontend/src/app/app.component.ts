import { Component, OnInit } from '@angular/core';
import { AccountService } from './services/account.service';
import { Router } from '@angular/router';
import { JwtInterceptor } from '@auth0/angular-jwt';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent implements OnInit{

  title = 'Car Booking System';
  loger!: boolean;
  constructor(private account:AccountService,private router:Router){}

  ngOnInit(){
    this.account.loger.subscribe(res => {
      this.loger = res
    });
    if(this.account.isLoggedIn()){
    this.account.loger.next(true);
    }
  }

  logOut() {
    this.account.logout();
    this.router.navigate(['login']);
  }
}
