import { Component, OnInit } from '@angular/core';
import { UserService } from '../services/user.service';
import { HttpService } from '../services/http.service';
import { Router } from '@angular/router';

@Component({
  selector: 'app-get-book-car',
  templateUrl: './get-book-car.component.html',
  styleUrls: ['./get-book-car.component.css']
})
export class GetBookCarComponent implements OnInit {
  products: any;
  ngOnInit(): void {
    this.http.Get("https://localhost:7150/api/Car/GetBookCar").subscribe((res) => {
      console.log(res);
      this.products = res;
    })
  }

  constructor(private user: UserService, private http: HttpService, private router: Router) { }

  goBack() {
    this.router.navigate(['admin']);
  }

}