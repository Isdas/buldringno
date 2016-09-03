"use strict";
var router_deprecated_1 = require('@angular/router-deprecated');
var home_1 = require('./components/home');
var problems_1 = require('./components/problems');
var boulders_1 = require('./components/boulders');
var boulderProblems_1 = require('./components/boulderProblems');
var account_1 = require('./components/account/account');
exports.Routes = {
    home: new router_deprecated_1.Route({ path: '/', name: 'Home', component: home_1.Home }),
    problems: new router_deprecated_1.Route({ path: '/problems', name: 'Problems', component: problems_1.Problems }),
    boulders: new router_deprecated_1.Route({ path: '/boulders', name: 'Boulders', component: boulders_1.Boulders }),
    boulderProblems: new router_deprecated_1.Route({ path: '/boulders/:id/problems', name: 'BoulderProblems', component: boulderProblems_1.BoulderProblem }),
    account: new router_deprecated_1.Route({ path: '/account/...', name: 'Account', component: account_1.Account })
};
exports.APP_ROUTES = Object.keys(exports.Routes).map(function (r) { return exports.Routes[r]; });
