import { Component, OnInit } from '@angular/core';
import { CORE_DIRECTIVES, FORM_DIRECTIVES } from '@angular/common';
import { Router, RouterLink } from '@angular/router-deprecated'
import { Boulder } from '../core/domain/boulder';
import { Paginated } from '../core/common/paginated';
import { DataService } from '../core/services/dataService';
import { UtilityService } from '../core/services/utilityService';
import { NotificationService } from '../core/services/notificationService';
import { Routes, APP_ROUTES } from '../routes';

@Component({
    selector: 'boulders',
    providers: [NotificationService],
    templateUrl: './app/components/boulders.html',
    directives: [CORE_DIRECTIVES, FORM_DIRECTIVES, RouterLink]
})
export class Boulders extends Paginated implements OnInit {
    private _bouldersAPI: string = 'api/boulders/';
    private _boulders: Array<Boulder>;
    private routes = Routes;

    constructor(public bouldersService: DataService,
                public utilityService: UtilityService,
                public notificationService: NotificationService,
                public router: Router) {
        super(0, 0, 0);
    }

    ngOnInit() {
        this.routes = Routes;
        this.bouldersService.set(this._bouldersAPI, 3);
        this.getBoulders();
    }

    getBoulders(): void {
        this.bouldersService.get(this._page)
            .subscribe(res => {               
                var data:any = res.json();
                this._boulders = data.Items;
                this._page = data.Page;
                this._pagesCount = data.TotalPages;
                this._totalCount = data.TotalCount;
            },
            error => console.error('Error: ' + error));
    }

    search(i): void {
        super.search(i);
        this.getBoulders();
    };

    convertDateTime(date: Date) {
        return this.utilityService.convertDateTime(date);
    }
}