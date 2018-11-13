import { Http } from '@angular/http';
import { Injector } from '@angular/core';

export abstract class AppComponentBase {

    http: Http;
    data: any;

    constructor(injector: Injector) {
        this.http = injector.get(Http);
        this.getConfig();
    }

    async getConfig() {
        console.log("GetConfig")
        const response = await this.http.get('./assets/app.config.json').toPromise();
        this.data = response.json();
        console.log(this.data);
    }

}