import { Component, Injector, ViewChild } from "@angular/core";
import { AppComponentBase } from "src/shared/app-component-base";
import { faCoffee } from '@fortawesome/free-solid-svg-icons';
import { FormGroup, NgForm } from "@angular/forms";

@Component({
    templateUrl: './login.component.html',
})
export class LoginComponent extends AppComponentBase { 

    @ViewChild('userInput') userInput: FormGroup;

    loggingIn: boolean = false;
    faCoffee = faCoffee;

    username: string = '';


    constructor(injector: Injector) {
        super(injector);
    }

    login(): void {
        
        console.log(this.username);
        this.loggingIn = true;
    }
}