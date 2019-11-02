import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { CRUDItemComponent } from './crud-item.component';

describe('CRUDItemComponent', () => {
  let component: CRUDItemComponent;
  let fixture: ComponentFixture<CRUDItemComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ CRUDItemComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(CRUDItemComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
