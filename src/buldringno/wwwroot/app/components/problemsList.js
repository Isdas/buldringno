"use strict";
var __extends = (this && this.__extends) || function (d, b) {
    for (var p in b) if (b.hasOwnProperty(p)) d[p] = b[p];
    function __() { this.constructor = d; }
    d.prototype = b === null ? Object.create(b) : (__.prototype = b.prototype, new __());
};
var __decorate = (this && this.__decorate) || function (decorators, target, key, desc) {
    var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
    if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
    else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
    return c > 3 && r && Object.defineProperty(target, key, r), r;
};
var __metadata = (this && this.__metadata) || function (k, v) {
    if (typeof Reflect === "object" && typeof Reflect.metadata === "function") return Reflect.metadata(k, v);
};
var core_1 = require('@angular/core');
var router_deprecated_1 = require('@angular/router-deprecated');
var paginated_1 = require('../core/common/paginated');
var dataService_1 = require('../core/services/dataService');
var utilityService_1 = require('../core/services/utilityService');
var ProblemsList = (function (_super) {
    __extends(ProblemsList, _super);
    function ProblemsList(problemsService, utilityService, routeParam) {
        _super.call(this, 0, 0, 0);
        this.problemsService = problemsService;
        this.utilityService = utilityService;
        this.routeParam = routeParam;
        this._problemsAPI = 'api/problems/';
    }
    ProblemsList.prototype.ngOnInit = function () {
        this._problemsGradeID = this.routeParam.get('id');
        this._problemsAPI += this._problemsGradeID + '/problems/';
        this.problemsService.set(this._problemsAPI, 12);
        this.getProblems();
    };
    ProblemsList.prototype.getProblems = function () {
        var _this = this;
        this.problemsService.get(this._page)
            .subscribe(function (res) {
            var data = res.json();
            _this._problems = data.Items;
            _this._page = data.Page;
            _this._pagesCount = data.TotalPages;
            _this._totalCount = data.TotalCount;
            _this._problemsGradeID = _this._problems[0].Grade;
        }, function (error) { return console.error('Error: ' + error); });
    };
    ProblemsList.prototype.search = function (i) {
        _super.prototype.search.call(this, i);
        this.getProblems();
    };
    ;
    ProblemsList.prototype.convertDateTime = function (date) {
        return this.utilityService.convertDateTime(date);
    };
    ProblemsList = __decorate([
        core_1.Component({
            selector: 'problems-list',
            providers: [dataService_1.DataService],
            templateUrl: './app/components/problemsList.html',
            directives: [router_deprecated_1.RouterLink]
        }), 
        __metadata('design:paramtypes', [dataService_1.DataService, utilityService_1.UtilityService, router_deprecated_1.RouteParams])
    ], ProblemsList);
    return ProblemsList;
}(paginated_1.Paginated));
exports.ProblemsList = ProblemsList;
//# sourceMappingURL=problemsList.js.map