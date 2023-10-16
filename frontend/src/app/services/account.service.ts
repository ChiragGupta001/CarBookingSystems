import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { BehaviorSubject, Observable, Subscription, of } from 'rxjs';
import { JwtHelperService } from '@auth0/angular-jwt';

@Injectable({
  providedIn: 'root'
})

export class AccountService {

  private jwtHelper:JwtHelperService;
  isLogin = false;
  loger = new BehaviorSubject<boolean>(false);
  authToken: any;
  user: any;
  tokenSubscription = new Subscription()
  timeout: any;
  roleAs: string;
  url:string="https://localhost:7150/api/Account/";

  constructor(private http:HttpClient) { 
    this.jwtHelper = new JwtHelperService();
    this.roleAs = "";
    
  }

  SignUp(data:any): Observable<any>{
    return this.http.post(this.url+"SignUp" ,data);
  }

  Signin(data:any):Observable<any>{
    return this.http.post(this.url+"Login" , data);
  }

  decodeToken(token:string, claimKey:string){
    var authToken = this.jwtHelper.decodeToken(token);
    return authToken[claimKey];
  }

  login(value: string) {
    this.isLogin = true;
    this.roleAs = value;
    localStorage.setItem('STATE', 'true');
    localStorage.setItem('ROLE', this.roleAs);
    return of({ success: this.isLogin, role: this.roleAs });
  }

  logout() {
    this.isLogin = false;
    this.roleAs = '';
    localStorage.clear();
    localStorage.setItem('STATE', 'false');
    localStorage.setItem('ROLE', '');
    return of({ success: this.isLogin, role: '' });
  }

  isLoggedIn() {
    const loggedIn = localStorage.getItem('STATE');
    if (loggedIn == 'true')
      this.isLogin = true;
    else
      this.isLogin = false;
    return this.isLogin;
  }

  getRole() {
    return localStorage.getItem('ROLE');
  }

}