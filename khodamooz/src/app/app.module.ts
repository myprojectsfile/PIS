import { BrowserModule } from "@angular/platform-browser";
import { NgModule } from "@angular/core";
import { NgbModule } from "@ng-bootstrap/ng-bootstrap";
import { FormsModule } from "@angular/forms";
import { HttpModule } from "@angular/http";
import { AppComponent } from "./app.component";
import { LoginComponent } from "./auth/login/login.component";
import { ServicesModule } from "./services/services.module"

@NgModule({
    declarations: [
        AppComponent,
        LoginComponent
    ],
    imports: [
        BrowserModule,
        FormsModule,
        HttpModule,
        NgbModule.forRoot(),
        ServicesModule
    ],
    providers: [],
    bootstrap: [AppComponent],
    entryComponents: [LoginComponent]
})
export class AppModule {
}
