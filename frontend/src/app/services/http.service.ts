import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class HttpService {

  auth_token:any
  headers!: HttpHeaders;
  constructor(private http:HttpClient) {
    this.auth_token = localStorage.getItem("token");
    this.headers = new HttpHeaders({'Content-Type': 'application/json'});
    this.headers = new HttpHeaders().set('Authorization', `Bearer ${this.auth_token}`)
  }

  Post(url:string,data:any){
    console.log(typeof(data));
    return this.http.post(url,data,{headers: this.headers});
  }

  Get(url:string){
    return this.http.get(url,{headers:this.headers});
  }

  Put(url:string, data:any){
    return this.http.put(url,data,{headers:this.headers});
  }

  Delete(url:string,data:any){
    return this.http.delete(url + data,{headers:this.headers})
  }

}