import { HomeComponent } from "./main/home/home.component";
import { RouterModule } from '@angular/router';
import { AppComponent } from './app.component';
import { NgModule } from "@angular/core";
import { LoginComponent } from "./account/login.component";

/**
 * Base routing module
 * 
 */
@NgModule({
    imports: [
        RouterModule.forRoot([
                { path: '', component: HomeComponent },
                { path: 'login', component: LoginComponent }
    
            
        ])
    ],
    exports: [ RouterModule ]
})
export class AppRoutingModule { }