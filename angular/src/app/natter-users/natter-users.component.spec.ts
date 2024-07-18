import { ComponentFixture, TestBed } from '@angular/core/testing';

import { NatterUsersComponent } from './natter-users.component';

describe('NatterUsersComponent', () => {
  let component: NatterUsersComponent;
  let fixture: ComponentFixture<NatterUsersComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [NatterUsersComponent]
    })
    .compileComponents();
    
    fixture = TestBed.createComponent(NatterUsersComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
