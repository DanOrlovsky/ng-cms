import { Component, Injector } from "@angular/core";
import { UserService } from "src/app/services/user.service";
import { AppComponentBase } from "src/shared/app-component-base";

@Component({
    selector: 'cms-home',
    templateUrl: './home.component.html'
})
export class HomeComponent extends AppComponentBase {
    
    theUrlThing: string = "";

    constructor(injector: Injector,
        private userService: UserService) { 
        super(injector);
    }

    ngOnInit(): void {

    }
}