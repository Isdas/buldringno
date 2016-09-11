import { Component, OnInit } from '@angular/core';
import { CORE_DIRECTIVES, FORM_DIRECTIVES } from '@angular/common';
import { RouterLink, RouteParams } from '@angular/router-deprecated'
import { Problem } from '../core/domain/problem';
import { Paginated } from '../core/common/paginated';
import { DataService } from '../core/services/dataService';
import { UtilityService } from '../core/services/utilityService';

@Component({
    selector: 'problems-list',
    providers: [DataService],
    templateUrl: './app/components/problemsList.html',
    directives: [RouterLink]
})
export class ProblemsList extends Paginated implements OnInit {
    private _problemsAPI: string = 'api/problems/';
    private _problems: Array<Problem>;
    private _problemsGrade: string;
    private _problemsGradeID: string;

    constructor(public problemsService: DataService,
                public utilityService: UtilityService,
                public routeParam: RouteParams) {
        super(0, 0, 0);
    }

    ngOnInit() {
        this._problemsGradeID = this.routeParam.get('id');
        this._problemsAPI += this._problemsGradeID + '/problems/';
        this.problemsService.set(this._problemsAPI, 12);
        this.getProblems();
    }

    getProblems(): void {
        this.problemsService.get(this._page)
            .subscribe(res => {

                var data: any = res.json();

                this._problems = data.Items;
                this._page = data.Page;
                this._pagesCount = data.TotalPages;
                this._totalCount = data.TotalCount;
                this._problemsGrade = this._problems[0].Grade.replace("+", "").replace("-", "");
            },
            error => console.error('Error: ' + error));
    }

    search(i): void {
        super.search(i);
        this.getProblems();
    };

    convertDateTime(date: Date) {
        return this.utilityService.convertDateTime(date);
    }
}