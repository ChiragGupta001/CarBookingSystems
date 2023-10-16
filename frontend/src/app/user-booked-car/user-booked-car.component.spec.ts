import { ComponentFixture, TestBed } from '@angular/core/testing';

import { UserBookedCarComponent } from './user-booked-car.component';

describe('UserBookedCarComponent', () => {
  let component: UserBookedCarComponent;
  let fixture: ComponentFixture<UserBookedCarComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [UserBookedCarComponent]
    });
    fixture = TestBed.createComponent(UserBookedCarComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
