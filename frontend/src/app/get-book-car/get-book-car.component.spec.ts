import { ComponentFixture, TestBed } from '@angular/core/testing';

import { GetBookCarComponent } from './get-book-car.component';

describe('GetBookCarComponent', () => {
  let component: GetBookCarComponent;
  let fixture: ComponentFixture<GetBookCarComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [GetBookCarComponent]
    });
    fixture = TestBed.createComponent(GetBookCarComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
