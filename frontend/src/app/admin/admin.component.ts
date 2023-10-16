import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { UserService } from '../services/user.service';
import { HttpService } from '../services/http.service';
import { Router } from '@angular/router';

@Component({
  selector: 'app-admin',
  templateUrl: './admin.component.html',
  styleUrls: ['./admin.component.css']
})

export class AdminComponent implements OnInit {
  url: string = "https://localhost:7150/api/Car/";
  products: any;
  
  ngOnInit(): void {
    this.http.Get(this.url + "GetCar").subscribe((res) => {
      this.products = res;
    });
  }

  constructor(private fb: FormBuilder,
    private user: UserService,
    private http: HttpService,
    private router: Router
  ) { }

  AddForm: FormGroup = this.fb.group({
    Model: ['', Validators.required],
    Brand: ['', Validators.required],
    PricePerHour: [ , Validators.required],
    Description: ['', Validators.required]
  });

  get model() {
    return this.AddForm.controls['Model'];
  }

  get brand() {
    return this.AddForm.controls['Brand'];
  }

  get description() {
    return this.AddForm.controls['Description'];
  }

  get price() {
    return this.AddForm.controls['PricePerHour'];
  }

  AddCar(value: any) {
    // console.log(value)
    this.user.AddCar(value);
    setTimeout(()=> this.Reload(),300);
  }

  Reload(){
    window.location.reload();
  }

  GetBookCars() {
    this.router.navigate(["getBookCar"]);
  }


  editProduct(product: any) {
  }

  deleteProduct(product: any) {
  }

  Back() {
    this.router.navigate(['admin']);
  }

}