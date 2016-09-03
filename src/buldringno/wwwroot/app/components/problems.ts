import { Component, OnInit } from '@angular/core';
import { CORE_DIRECTIVES, FORM_DIRECTIVES } from '@angular/common';
import { Router, RouterLink } from '@angular/router-deprecated'
import { Problem } from '../core/domain/problem';
import { Paginated } from '../core/common/paginated';
import { DataService } from '../core/services/dataService';

@Component({
    selector: 'problems',
    providers: [DataService],
    templateUrl: './app/components/problems.html',
    directives: [RouterLink]
})
export class Problems extends Paginated implements OnInit {
    private _problemsAPI: string = 'api/problems/';
    private _problems: Array<Problem>;

    constructor(public problemsService: DataService) {
        super(0, 0, 0);
    }

    ngOnInit() {
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
            },
            error => console.error('Error: ' + error));
    }

    search(i): void {
        super.search(i);
        this.getProblems();
    };
}