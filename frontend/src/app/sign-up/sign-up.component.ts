import { Component, ElementRef, OnInit, ViewChild } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { PasswordValidator } from '../shared/PasswordValidator';
import { InputTextModule } from 'primeng/inputtext';
import { ButtonModule } from 'primeng/button';
import { AccountService } from '../services/account.service';
import { ImageCroppedEvent } from 'ngx-image-cropper';

@Component({
  selector: 'app-sign-up',
  templateUrl: './sign-up.component.html',
  styleUrls: ['./sign-up.component.css']
})

export class SignUpComponent implements OnInit {

  @ViewChild('cropper', { static: true }) cropper!: ElementRef;
  SignUpFormData: FormData = new FormData();
  imgChangeEvt: any = '';
  cropImgPreview: any = '';
  image: any = '';
  ngOnInit() { }

  constructor(private formbuilder: FormBuilder, private account: AccountService) { }

  SignUpForm: FormGroup = this.formbuilder.group({
    Name: ['', [Validators.required]],
    UserName: ['', [Validators.required]],
    Email: ['', Validators.required, Validators.email],
    Profile: [File, [Validators.required]],
    PhoneNumber: ['', [Validators.required]],
    Password: ['', [Validators.required, Validators.minLength(7)], Validators.pattern('(?=.*\d)(?=.*[a-z])(?=.*[A-Z])(?=.*[@$!%*#?&^_-]).{8,}')],
    ConfirmPassword: ['']
  }, { validators: PasswordValidator });

  get Names() {
    return this.SignUpForm.controls['Name'];
  }

  get UserNames() {
    return this.SignUpForm.controls['UserName'];
  }

  get email() {
    return this.SignUpForm.controls['Email'];
  }

  get profile() {
    return this.SignUpForm.controls['Profile'];
  }

  get password() {
    return this.SignUpForm.controls['Password'];
  }

  get phone() {
    return this.SignUpForm.controls['PhoneNumber'];
  }

  onFileChange(event: any): void {
    this.imgChangeEvt = event;
  }

  cropImg(e: ImageCroppedEvent) {
    this.cropImgPreview = e.objectUrl;
    const reader = new FileReader();
    reader.onload = (e: ProgressEvent<FileReader>) => {
      if (e.target?.result) {
        const dataUrl = e.target.result as string;
        const byteString = atob(dataUrl.split(',')[1]);
        const mimeString = dataUrl.split(',')[0].split(':')[1].split(';')[0];
        const arrayBuffer = new ArrayBuffer(byteString.length);
        const uintArray = new Uint8Array(arrayBuffer);

        for (let i = 0; i < byteString.length; i++) {
          uintArray[i] = byteString.charCodeAt(i);
        }

        const blob = new Blob([arrayBuffer], { type: mimeString });
        this.SignUpFormData.delete('Profile');
        const uniqueId = Math.random() * 1000;
        this.SignUpFormData.append('Profile', blob, `${uniqueId}file.jpg`);
      }
    };
    this.image = e.blob;
    reader.readAsDataURL(this.image);
  }

  imgLoad() {
    // display cropper tool
  }

  initCropper() {
    // init cropper
  }

  imgFailed() {
    // error msg
  }

  SignUp(value: any) {
    this.SignUpFormData.append('Name', value.Name);
    this.SignUpFormData.append('UserName', value.UserName);
    this.SignUpFormData.append('Email', value.Email);
    this.SignUpFormData.append('PhoneNumber', value.PhoneNumber);
    this.SignUpFormData.append("Password", value.Password);
    this.SignUpFormData.append('ConfirmPassword', value.ConfirmPassword);
    this.account.SignUp(this.SignUpFormData).subscribe((res) =>
      console.log(res))
  }
}