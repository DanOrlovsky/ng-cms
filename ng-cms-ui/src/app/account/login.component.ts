import { Component, Injector } from "@angular/core";
import { AppComponentBase } from "src/shared/app-component-base";


@Component({
    templateUrl: './login.component.html',
})
export class LoginComponent extends AppComponentBase { 
    constructor(injector: Injector) {
        super(injector);
    }
}