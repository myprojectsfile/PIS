import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { MdButtonModule, MdDialogModule, MdInputModule } from '@angular/material';

@NgModule({
  imports: [
    CommonModule,
    BrowserAnimationsModule,
    MdButtonModule,
    MdDialogModule,
    MdInputModule
  ],
  exports:[
    BrowserAnimationsModule,
    MdButtonModule,
    MdDialogModule,
    MdInputModule
  ]
})
export class MaterialModule { }
