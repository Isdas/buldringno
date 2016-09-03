import { Route, Router } from '@angular/router-deprecated';
import { Home } from './components/home';
import { Problems } from './components/problems';
import { Boulders } from './components/boulders';
import { BoulderProblem } from './components/boulderProblems';
import { Account } from './components/account/account';
import { Users } from './components/users';

export var Routes = {
    home: new Route({ path: '/', name: 'Home', component: Home }),
    problems: new Route({ path: '/problems', name: 'Problems', component: Problems }),
    boulders: new Route({ path: '/boulders', name: 'Boulders', component: Boulders }),
    boulderProblems: new Route({ path: '/boulders/:id/problems', name: 'BoulderProblems', component: BoulderProblem }),
    account: new Route({ path: '/account/...', name: 'Account', component: Account }),
    users: new Route({ path: '/users', name: 'Users', component: Users }),
};

export const APP_ROUTES = Object.keys(Routes).map(r => Routes[r]);
