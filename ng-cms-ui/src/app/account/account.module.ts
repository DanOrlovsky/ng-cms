import { NgModule } from '@angular/core';
import { MatInputModule } from '@angular/material/input'
import { MatFormFieldModule, MatFormField } from '@angular/material/form-field';
import { MatCardModule } from '@angular/material/card';
import { LoginComponent } from './login.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { FontAwesomeModule } from '@fortawesome/angular-fontawesome';
import { MatButtonModule } from '@angular/material/button';
import { FormsModule } from '@angular/forms';
@NgModule({
    imports: [
        MatInputModule,
        MatButtonModule,
        BrowserAnimationsModule,
        MatFormFieldModule,
        MatCardModule,
        FontAwesomeModule,
        FormsModule,
    ],
    declarations: [
        LoginComponent
    ]
})

export class AccountModule {

}