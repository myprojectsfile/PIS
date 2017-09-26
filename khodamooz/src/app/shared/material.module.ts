import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { MdButtonModule, MdDialogModule, MdInputModule, MdSnackBarModule} from '@angular/material';

@NgModule({
  imports: [
    CommonModule,
    BrowserAnimationsModule,
    MdButtonModule,
    MdDialogModule,
    MdInputModule,
    MdSnackBarModule
  ],
  exports: [
    BrowserAnimationsModule,
    MdButtonModule,
    MdDialogModule,
    MdInputModule,
    MdSnackBarModule
  ]
})
export class MaterialModule { }
