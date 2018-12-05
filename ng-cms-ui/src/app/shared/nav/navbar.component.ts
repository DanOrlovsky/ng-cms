import { Component, Injector } from '@angular/core';
import { AppComponentBase } from 'src/shared/app-component-base';


@Component({
    selector: 'cms-navbar',
    templateUrl: './navbar.component.html'
})

export class NavbarComponent extends AppComponentBase {    

    constructor(injector: Injector) {
        super(injector);
    }
}