import { Component, OnInit } from '@angular/core';
import { CORE_DIRECTIVES, FORM_DIRECTIVES } from '@angular/common';
import { RouterLink, RouteParams } from '@angular/router-deprecated'
import { Problem } from '../core/domain/problem';
import { Paginated } from '../core/common/paginated';
import { DataService } from '../core/services/dataService';
import { UtilityService } from '../core/services/utilityService';
import { NotificationService } from '../core/services/notificationService';
import { OperationResult } from '../core/domain/operationResult';

@Component({
    selector: 'boulder-problem',
    providers: [NotificationService],
    templateUrl: './app/components/boulderProblems.html',
    directives: [RouterLink]
})
export class BoulderProblems extends Paginated implements OnInit {
    private _bouldersAPI: string = 'api/boulders/';
    private _problemsAPI: string = 'api/problems/';
    private _boulderId: string;
    private _problems: Array<Problem>;
    private _displayingTotal: number;
    private _boulderTitle: string;

    constructor(public dataService: DataService,
                public utilityService: UtilityService,
                public notificationService: NotificationService,
                public routeParam: RouteParams) {
                super(0, 0, 0);
    }

    ngOnInit() {
        this._boulderId = this.routeParam.get('id');
        this._bouldersAPI += this._boulderId + '/problems/';
        this.dataService.set(this._bouldersAPI, 12);
        this.getBoulderProblems();
    }

    getBoulderProblems(): void {
        this.dataService.get(this._page)
            .subscribe(res => {

                var data: any = res.json();

                this._problems = data.Items;
                this._displayingTotal = this._problems.length;
                this._page = data.Page;
                this._pagesCount = data.TotalPages;
                this._totalCount = data.TotalCount;
                this._boulderTitle = this._problems[0].BoulderTitle;
            },
            error => {

                if (error.status == 401 || error.status == 302) {
                    this.utilityService.navigateToSignIn();
                }

                console.error('Error: ' + error)
            },
            () => console.log(this._problems));
    }

    search(i): void {
        super.search(i);
        this.getBoulderProblems();
    };

    convertDateTime(date: Date) {
        return this.utilityService.convertDateTime(date);
    }

    delete(problem: Problem) {
        var _removeResult: OperationResult = new OperationResult(false, '');

        this.notificationService.printConfirmationDialog('Are you sure you want to delete the problem?',
            () => {
                this.dataService.deleteResource(this._bouldersAPI + problem.Id)
                    .subscribe(res => {
                        _removeResult.Succeeded = res.Succeeded;
                        _removeResult.Message = res.Message;
                    },
                    error => console.error('Error: ' + error),
                    () => {
                        if (_removeResult.Succeeded) {
                            this.notificationService.printSuccessMessage(problem.Title + ' removed from gallery.');
                            this.getBoulderProblems();
                        }
                        else {
                            this.notificationService.printErrorMessage('Failed to remove problem');
                        }
                    });
            });
    }
}