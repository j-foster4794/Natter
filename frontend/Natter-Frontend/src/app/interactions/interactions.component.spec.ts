import { ComponentFixture, TestBed } from '@angular/core/testing';

import { InteractionsComponent } from './interactions.component';

describe('InteractionsComponent', () => {
  let component: InteractionsComponent;
  let fixture: ComponentFixture<InteractionsComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [InteractionsComponent]
    });
    fixture = TestBed.createComponent(InteractionsComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
