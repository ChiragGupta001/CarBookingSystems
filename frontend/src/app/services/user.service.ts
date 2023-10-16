import { Injectable } from '@angular/core';
import { HttpService } from './http.service';
import { AccountService } from './account.service';

@Injectable({
  providedIn: 'root'
})
export class UserService {

  product : any ;
  token:any;

  url:string="https://localhost:7150/api/Car/";
  constructor(private http:HttpService,private account:AccountService) 
  {}

  AddCar(data:any){
    this.http.Post(this.url + "AddCar",data).subscribe((res)=>
    {
      console.log(res);
    },(error)=>
    { 
      console.log(error)
    });
  }

  UserId(){
    this.token = localStorage.getItem("token");
    return this.account.decodeToken(this.token, 'id');
  }

}