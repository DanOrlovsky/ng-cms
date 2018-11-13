import { Injectable } from "@angular/core";
import { Http } from "@angular/http";

@Injectable()
export class UserService {

    data: any;
    
    constructor(private http: Http) { 
        this.getConfig();
    }

    async getConfig() {
        const response = await this.http.get('./assets/app.config.json').toPromise();
        this.data = response.json();
    }


}