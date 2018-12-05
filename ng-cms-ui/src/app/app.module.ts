// MODULES
import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { MaterialComponentsModule } from './core/material-components.module';
import { HttpModule } from '@angular/http';
import { AppRoutingModule } from './app.routing';
// COMPONENTS
import { AppComponent } from './app.component';
import { HomeComponent } from './main/home/home.component';
import { AccountModule } from './account/account.module';
import { NavbarComponent } from './shared/nav/navbar.component'
// SERVICES 
import { UserService } from './services/user.service';


@NgModule({
  declarations: [
    AppComponent,
    HomeComponent,
    NavbarComponent,
  ],
  imports: [
    BrowserModule,
    AccountModule,
    MaterialComponentsModule,
    HttpModule,
    AppRoutingModule
  ],
  providers: [ UserService ],
  bootstrap: [AppComponent]
})
export class AppModule { }
