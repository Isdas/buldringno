import { Route, Router } from '@angular/router-deprecated';
import { Home } from './components/home';
import { Problems } from './components/problems';
import { Areas } from './components/areas';
import { AreaBoulders } from './components/areaBoulders';
import { Boulders } from './components/boulders';
import { BoulderProblems } from './components/boulderProblems';
import { Account } from './components/account/account';
import { Users } from './components/users';
import { About } from './components/about';

export var Routes = {
    home: new Route({ path: '/', name: 'Home', component: Home }),
    problems: new Route({ path: '/problems', name: 'Problems', component: Problems }),
    areas: new Route({ path: '/areas', name: 'Areas', component: Areas }),
    areaBoulders: new Route({ path: '/areas/:id/boulders', name: 'AreaBoulders', component: AreaBoulders }),
    boulders: new Route({ path: '/boulders', name: 'Boulders', component: Boulders }),
    boulderProblems: new Route({ path: '/boulders/:id/problems', name: 'BoulderProblems', component: BoulderProblems }),
    account: new Route({ path: '/account/...', name: 'Account', component: Account }),
    users: new Route({ path: '/users', name: 'Users', component: Users }),
    about: new Route({ path: '/about', name: 'About', component: About }),
};

export const APP_ROUTES = Object.keys(Routes).map(r => Routes[r]);