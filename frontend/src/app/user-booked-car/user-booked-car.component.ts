import { Component, OnInit } from '@angular/core';
import { UserService } from '../services/user.service';
import { HttpService } from '../services/http.service';
import { Route, Router } from '@angular/router';

@Component({
  selector: 'app-user-booked-car',
  templateUrl: './user-booked-car.component.html',
  styleUrls: ['./user-booked-car.component.css']
})
export class UserBookedCarComponent implements OnInit {

  products:any
  userId:any;
  url:string ="https://localhost:7150/api/Car/";

  constructor(private user:UserService,
     private http:HttpService,
     private router:Router
     ){}

  ngOnInit(){
    this.userId = this.user.UserId();
    console.log(this.userId);
    this.http.Post(this.url + `GetUserBookCar?userId=${this.userId}`, this.userId).subscribe(   
      (res)=> {this.products = res;
      console.log(res)},
      (error)=>{console.log(error)}
    );
  }

  goBack() {
    this.router.navigate(['user']);
  }
  
}
