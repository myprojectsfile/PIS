import { ProfileModule } from './profile/profile.module';
import { MaterialModule } from './shared/material.module';
import { AuthModule } from './auth/auth.module';
import { AppRoutingModule } from './app-routing.module';
import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { HttpModule } from '@angular/http';
import { AppComponent } from './app.component';
import { ServicesModule } from './services/services.module';
import { HomeComponent } from './home/home.component';

@NgModule({
    declarations: [
        AppComponent,
        HomeComponent
    ],
    imports: [
        BrowserModule,
        FormsModule,
        HttpModule,
        ServicesModule,
        AuthModule,
        MaterialModule,
        AppRoutingModule,
        ProfileModule        
    ],
    providers: [],
    bootstrap: [AppComponent]
})
export class AppModule {
}
