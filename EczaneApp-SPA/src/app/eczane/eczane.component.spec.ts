/* tslint:disable:no-unused-variable */
import { async, ComponentFixture, TestBed } from '@angular/core/testing';
import { By } from '@angular/platform-browser';
import { DebugElement } from '@angular/core';

import { EczaneComponent } from './eczane.component';

describe('EczaneComponent', () => {
  let component: EczaneComponent;
  let fixture: ComponentFixture<EczaneComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ EczaneComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(EczaneComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
