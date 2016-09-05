import { Component, OnInit } from '@angular/core';
import { CORE_DIRECTIVES, FORM_DIRECTIVES } from '@angular/common';
import { Router, RouterLink } from '@angular/router-deprecated'
import { User } from '../core/domain/user';
import { Paginated } from '../core/common/paginated';
import { DataService } from '../core/services/dataService';
import { UtilityService } from '../core/services/utilityService';
import { NotificationService } from '../core/services/notificationService';
import { Routes, APP_ROUTES } from '../routes';

@Component({
    selector: 'users',
    providers: [NotificationService],
    templateUrl: './app/components/users.html',
    directives: [CORE_DIRECTIVES, FORM_DIRECTIVES, RouterLink]
})
export class Users extends Paginated implements OnInit {
    private _usersAPI: string = 'api/users/';
    private _users: Array<User>;
    private routes = Routes;

    constructor(public usersService: DataService,
                public utilityService: UtilityService,
                public notificationService: NotificationService,
                public router: Router) {
        super(0, 0, 0);
    }

    ngOnInit() {
        this.routes = Routes;
        this.usersService.set(this._usersAPI, 3);
        this.getUsers();
    }

    getUsers(): void {
        this.usersService.get(this._page)
            .subscribe(res => {               
                var data:any = res.json();
                this._users = data.Items;
                this._page = data.Page;
                this._pagesCount = data.TotalPages;
                this._totalCount = data.TotalCount;
            },
            error => {

                if (error.status == 401 || error.status == 404) {
                    this.notificationService.printErrorMessage('Autentisering kreves');
                    this.utilityService.navigateToSignIn();
                }
            });
    }

    search(i): void {
        super.search(i);
        this.getUsers();
    };

    convertDateTime(date: Date) {
        return this.utilityService.convertDateTime(date);
    }
}