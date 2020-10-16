import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { AddFeedComponent } from './addfeed.component';

describe('AddCategoryComponent', () => {
  let component: AddFeedComponent;
  let fixture: ComponentFixture<AddFeedComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ AddFeedComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(AddFeedComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
