import { Component, OnInit } from '@angular/core';
import { CORE_DIRECTIVES, FORM_DIRECTIVES } from '@angular/common';
import { Router, RouterLink } from '@angular/router-deprecated'
import { Area } from '../core/domain/area';
import { Paginated } from '../core/common/paginated';
import { DataService } from '../core/services/dataService';
import { UtilityService } from '../core/services/utilityService';
import { NotificationService } from '../core/services/notificationService';
import { Routes, APP_ROUTES } from '../routes';

@Component({
    selector: 'areas',
    providers: [NotificationService],
    templateUrl: './app/components/areas.html',
    directives: [CORE_DIRECTIVES, FORM_DIRECTIVES, RouterLink]
})
export class Areas extends Paginated implements OnInit {
    private _areasAPI: string = 'api/areas/';
    private _areas: Array<Area>;
    private routes = Routes;

    constructor(public areasService: DataService,
                public utilityService: UtilityService,
                public notificationService: NotificationService,
                public router: Router) {
        super(0, 0, 0);
    }

    ngOnInit() {
        this.routes = Routes;
        this.areasService.set(this._areasAPI, 3);
        this.getAreas();
    }

    getAreas(): void {
        this.areasService.get(this._page)
            .subscribe(res => {
                var data: any = res.json();
                this._areas = data.Items;
                this._page = data.Page;
                this._pagesCount = data.TotalPages;
                this._totalCount = data.TotalCount;
            },
            error => console.error('Error: ' + error));
    }

    search(i): void {
        super.search(i);
        this.getAreas();
    };

    convertDateTime(date: Date) {
        return this.utilityService.convertDateTime(date);
    }
}