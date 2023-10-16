import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { SignUpComponent } from './sign-up/sign-up.component';
import { LoginComponent } from './login/login.component';
import { AdminComponent } from './admin/admin.component';
import { AuthGuard } from './guards/auth.guard';
import { GetBookCarComponent } from './get-book-car/get-book-car.component';
import { UserComponent } from './user/user.component';
import { UserBookedCarComponent } from './user-booked-car/user-booked-car.component';

const routes: Routes = [
  {path:"",component:LoginComponent},
  {path:"signup",component:SignUpComponent},
  {path:'login',component:LoginComponent},
  {path:"getBookCar",component:GetBookCarComponent, canActivate: [AuthGuard],
  data: {
    role: 'Admin'
  }},
  {path:"admin",component:AdminComponent, canActivate: [AuthGuard],
  data: {
    role: 'Admin'
  }},
  {path:"user",component:UserComponent,canActivate:[AuthGuard], data:{role:'User'}},
  {path:"userBookCar",component:UserBookedCarComponent,canActivate:[AuthGuard], data:{role:'User'}}
  // {path:'**'}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
