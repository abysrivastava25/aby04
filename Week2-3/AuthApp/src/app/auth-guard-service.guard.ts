import { Injectable } from '@angular/core';
import { CanActivate, Router, ActivatedRouteSnapshot, RouterStateSnapshot } from '@angular/router'
import { AuthServices } from './auth-service.service';
//import { AuthServices } from './authServices';

@Injectable()
export class AuthGuardService {
    constructor(private auth: AuthServices, private router: Router) { }

    canActivate(route: ActivatedRouteSnapshot, state: RouterStateSnapshot) {
        if (this.auth.validateUserTocken()) {
            return true;
        } else {
            this.router.navigate(['/login'], {
                queryParams: {
                    returnUrl: state.url
                }
            });
            return false;
        }
    }
}
