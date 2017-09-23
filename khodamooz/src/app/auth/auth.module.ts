import { MaterialModule } from './../shared/material.module';
import { FormsModule } from '@angular/forms';
import { SignupComponent } from './signup/signup.component';
import { SigninComponent } from './signin/signin.component';
import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';


@NgModule({
  imports: [
    CommonModule,
    FormsModule,
    MaterialModule
  ],
  declarations: [SigninComponent,SignupComponent],
  entryComponents:[SigninComponent,SignupComponent],
  exports:[SigninComponent,SignupComponent]
})
export class AuthModule { }
