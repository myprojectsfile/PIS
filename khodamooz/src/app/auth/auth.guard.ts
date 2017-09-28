import { MdSnackBar } from '@angular/material';
import { AuthService } from './auth.service';
import { Injectable } from '@angular/core';
import { CanActivate, CanActivateChild, ActivatedRouteSnapshot, RouterStateSnapshot } from '@angular/router';
import { Observable } from 'rxjs/Observable';
import * as RouteClaims from './route.claims';

@Injectable()
export class AuthGuard implements CanActivate, CanActivateChild {
  constructor(private authService: AuthService, private snackBar: MdSnackBar) {
  }
  canActivate(
    next: ActivatedRouteSnapshot,
    state: RouterStateSnapshot): Observable<boolean> | Promise<boolean> | boolean {

    let nextRouteUrl = state.url;
    let routeClaims = this.getRouteClaims(nextRouteUrl);
    let routeCanActivate = true;
    for (let claim of routeClaims) {
      routeCanActivate = routeCanActivate && this.authService.userHasClaim(claim);
    }

    if(!routeCanActivate){
      this.snackBar.open('شما مجوز دسترسی به این بخش را ندارید','خطا',{duration:2000});
    }
    return routeCanActivate;
  }
  canActivateChild(
    next: ActivatedRouteSnapshot,
    state: RouterStateSnapshot): Observable<boolean> | Promise<boolean> | boolean {
    let nextRouteUrl = state.url;
    let routeClaims = this.getRouteClaims(nextRouteUrl);
    let routeCanActivate = true;
    for (let claim of routeClaims) {
      routeCanActivate = routeCanActivate && this.authService.userHasClaim(claim);
    }
    if(!routeCanActivate){
      this.snackBar.open('شما مجوز دسترسی به این بخش را ندارید','خطا',{duration:2000});
    }
    return routeCanActivate;
  }


  getRouteClaims(routeUrl: string) {
    let route = RouteClaims.default.Routes.find(r => r.routeUrl === routeUrl);
    let claims = route.claims;
    return claims;
  }
}
