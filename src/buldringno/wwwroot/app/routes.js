"use strict";
var router_deprecated_1 = require('@angular/router-deprecated');
var home_1 = require('./components/home');
var problemsList_1 = require('./components/problemsList');
var areas_1 = require('./components/areas');
var area_1 = require('./components/area');
var boulders_1 = require('./components/boulders');
var boulderProblems_1 = require('./components/boulderProblems');
var account_1 = require('./components/account/account');
var users_1 = require('./components/users');
var about_1 = require('./components/about');
exports.Routes = {
    home: new router_deprecated_1.Route({ path: '/', name: 'Home', component: home_1.Home }),
    problemsList: new router_deprecated_1.Route({ path: '/problems/:id', name: 'ProblemsList', component: problemsList_1.ProblemsList }),
    areas: new router_deprecated_1.Route({ path: '/areas', name: 'Areas', component: areas_1.Areas }),
    area: new router_deprecated_1.Route({ path: '/areas/:id/boulders', name: 'Area', component: area_1.Area }),
    boulders: new router_deprecated_1.Route({ path: '/boulders', name: 'Boulders', component: boulders_1.Boulders }),
    boulderProblems: new router_deprecated_1.Route({ path: '/boulders/:id/problems', name: 'BoulderProblems', component: boulderProblems_1.BoulderProblems }),
    account: new router_deprecated_1.Route({ path: '/account/...', name: 'Account', component: account_1.Account }),
    users: new router_deprecated_1.Route({ path: '/users', name: 'Users', component: users_1.Users }),
    about: new router_deprecated_1.Route({ path: '/about', name: 'About', component: about_1.About }),
};
exports.APP_ROUTES = Object.keys(exports.Routes).map(function (r) { return exports.Routes[r]; });
//# sourceMappingURL=routes.js.map