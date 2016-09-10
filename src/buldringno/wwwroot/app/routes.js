"use strict";
var router_deprecated_1 = require('@angular/router-deprecated');
var home_1 = require('./components/home');
var problems_1 = require('./components/problems');
var areas_1 = require('./components/areas');
var areaBoulders_1 = require('./components/areaBoulders');
var boulders_1 = require('./components/boulders');
var boulderProblems_1 = require('./components/boulderProblems');
var account_1 = require('./components/account/account');
var users_1 = require('./components/users');
var about_1 = require('./components/about');
exports.Routes = {
    home: new router_deprecated_1.Route({ path: '/', name: 'Home', component: home_1.Home }),
    problems: new router_deprecated_1.Route({ path: '/problems', name: 'Problems', component: problems_1.Problems }),
    areas: new router_deprecated_1.Route({ path: '/areas', name: 'Areas', component: areas_1.Areas }),
    areaBoulders: new router_deprecated_1.Route({ path: '/areas/:id/boulders', name: 'AreaBoulders', component: areaBoulders_1.AreaBoulders }),
    boulders: new router_deprecated_1.Route({ path: '/boulders', name: 'Boulders', component: boulders_1.Boulders }),
    boulderProblems: new router_deprecated_1.Route({ path: '/boulders/:id/problems', name: 'BoulderProblems', component: boulderProblems_1.BoulderProblems }),
    account: new router_deprecated_1.Route({ path: '/account/...', name: 'Account', component: account_1.Account }),
    users: new router_deprecated_1.Route({ path: '/users', name: 'Users', component: users_1.Users }),
    about: new router_deprecated_1.Route({ path: '/about', name: 'About', component: about_1.About }),
};
exports.APP_ROUTES = Object.keys(exports.Routes).map(function (r) { return exports.Routes[r]; });
//# sourceMappingURL=routes.js.map