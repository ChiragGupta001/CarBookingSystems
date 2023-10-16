import { Component, OnInit } from '@angular/core';
import { HttpService } from '../services/http.service';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { ActivatedRoute, Router } from '@angular/router';
import { AccountService } from '../services/account.service';
import { UserService } from '../services/user.service';
import { Time } from '@angular/common';
import { MessageService } from 'primeng/api';

@Component({
  selector: 'app-user',
  templateUrl: './user.component.html',
  styleUrls: ['./user.component.css']
})

export class UserComponent implements OnInit {
  
  products: any;
  id: any;
  carId: any;
  userId: any;
  totalRent: any;
  from: Date = new Date();
  to: Date = new Date();
  pricePerHr: any
  CarformData: FormData = new FormData();

  constructor(private http: HttpService, private fb: FormBuilder, private router: ActivatedRoute, private user: UserService, private messageServices: MessageService, private route:Router) { }

  ngOnInit(): void {
    this.http.Get(this.url + "GetCar").subscribe((res) => {
      this.products = res;
    })
  }

  url: string = "https://localhost:7150/api/Car/";

  CarForm: FormGroup = this.fb.group({
    To: ['', Validators.required],
    From: ['', Validators.required],
    carId: [],
    id: []
  })

  get toDate() {
    return this.CarForm.controls['To'];
  }

  get fromDate() {
    return this.CarForm.controls['From'];
  }


  getTotalPrice(value: any) {
    // this.to = value.To;
    this.http.Post(this.url + "GetTotalRent", value).subscribe(
      (res: any) => {
        this.totalRent = res * this.pricePerHr;
      }
    )
  }

  CarBook(value: any) {
    this.carId = value.carId;
    this.pricePerHr = value.pricePerHour;
    this.userId = this.user.UserId();
    // console.log(this.carId);
    // console.log(this.userId);
  }

  GetBookCar(){
    this.route.navigate(['userBookCar']);
  }

  BookCar(item: any) {
    this.CarformData.append('From', item.From);
    this.CarformData.append('To', item.To);
    this.CarformData.append('carId', this.carId);
    this.CarformData.append('id', this.userId);
    this.http.Post(this.url + "CarBooking", this.CarformData).subscribe(
      (res) => {
        setTimeout(() => this.messageServices.add({
          severity: 'success',
          summary: 'Car Booked',
          detail: 'Car Booked Successfully'
        }), 300
        );
      },
      (error) => {
        setTimeout(() => this.messageServices.add({
          severity: 'error',
          summary: 'Booking Failed',
          detail: 'Something went wrong'
        }), 300
        );
      }
    );
  }
}