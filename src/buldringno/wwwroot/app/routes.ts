﻿import { Route, Router } from '@angular/router-deprecated';
import { Home } from './components/home';
import { ProblemsList } from './components/problemsList';
import { Areas } from './components/areas';
import { AreaView } from './components/areaView';
import { Boulders } from './components/boulders';
import { BoulderProblems } from './components/boulderProblems';
import { Account } from './components/account/account';
import { Users } from './components/users';
import { About } from './components/about';

export var Routes = {
    home: new Route({ path: '/', name: 'Home', component: Home }),
    problemsList: new Route({ path: '/problems/:id', name: 'ProblemsList', component: ProblemsList }),
    areas: new Route({ path: '/areas', name: 'Areas', component: Areas }),
    areaView: new Route({ path: '/areas/:id/boulders', name: 'AreaView', component: AreaView }),
    boulders: new Route({ path: '/boulders', name: 'Boulders', component: Boulders }),
    boulderProblems: new Route({ path: '/boulders/:id/problems', name: 'BoulderProblems', component: BoulderProblems }),
    account: new Route({ path: '/account/...', name: 'Account', component: Account }),
    users: new Route({ path: '/users', name: 'Users', component: Users }),
    about: new Route({ path: '/about', name: 'About', component: About }),
};

export const APP_ROUTES = Object.keys(Routes).map(r => Routes[r]);