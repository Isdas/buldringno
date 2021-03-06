﻿import { Component, OnInit } from '@angular/core';
import { CORE_DIRECTIVES, FORM_DIRECTIVES } from '@angular/common';
import { RouterLink, RouteParams } from '@angular/router-deprecated'
import { Area } from '../core/domain/area';
import { Boulder } from '../core/domain/boulder';
import { Paginated } from '../core/common/paginated';
import { DataService } from '../core/services/dataService';
import { UtilityService } from '../core/services/utilityService';
import { NotificationService } from '../core/services/notificationService';
import { OperationResult } from '../core/domain/operationResult';

@Component({
    selector: 'areaView',
    providers: [NotificationService],
    templateUrl: './app/components/areaView.html',
    directives: [RouterLink]
})
export class AreaView extends Paginated implements OnInit {
    private _areasAPI : string = 'api/areas/';
    private _areaId: string;
    private _area: Area;
    private _boulders: Array<Boulder>;
    private _displayingTotal: number;
    private _areaTitle: string;

    constructor(public dataService: DataService,
                public utilityService: UtilityService,
                public notificationService: NotificationService,
                public routeParam: RouteParams) {
                super(0, 0, 0);
    }

    ngOnInit() {
        this._areaId = this.routeParam.get('id');
        this._areasAPI += this._areaId + '/boulders/';
        this.dataService.set(this._areasAPI, 12);
        this.getAreaBoulders();
    }

    getAreaBoulders(): void {
        this.dataService.get(this._page)
            .subscribe(res => {

                var data: any = res.json();

                this._boulders = data.Items;
                this._displayingTotal = this._boulders.length;
                this._page = data.Page;
                this._pagesCount = data.TotalPages;
                this._totalCount = data.TotalCount;
                this._areaTitle = this._boulders[0].AreaTitle;
            },
            error => {

                if (error.status == 401 || error.status == 302) {
                    this.utilityService.navigateToSignIn();
                }

                console.error('Error: ' + error)
            },
            () => console.log(this._boulders));
    }

    search(i): void {
        super.search(i);
        this.getAreaBoulders();
    };

    convertDateTime(date: Date) {
        return this.utilityService.convertDateTime(date);
    }

    delete(boulder: Boulder) {
        var _removeResult: OperationResult = new OperationResult(false, '');

        this.notificationService.printConfirmationDialog('Er du sikker på at du vil slette bulderet?',
            () => {
                this.dataService.deleteResource(this._areasAPI + boulder.Id)
                    .subscribe(res => {
                        _removeResult.Succeeded = res.Succeeded;
                        _removeResult.Message = res.Message;
                    },
                    error => console.error('Error: ' + error),
                    () => {
                        if (_removeResult.Succeeded) {
                            this.notificationService.printSuccessMessage(boulder.Title + ' fjernet fra område.');
                            this.getAreaBoulders();
                        }
                        else {
                            this.notificationService.printErrorMessage('Kunne ikke fjerne bulderet');
                        }
                    });
            });
    }
}