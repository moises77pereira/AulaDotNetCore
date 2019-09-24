import { Injectable } from "@angular/core";
import { Router, CanActivate, ActivatedRouteSnapshot, RouterStateSnapshot } from "@angular/router";

@Injectable({
  providedIn: 'root'
})
export class GuardaRotas implements CanActivate {

  constructor(private router: | Router) {

  }
  canActivate(route: ActivatedRouteSnapshot, state: RouterStateSnapshot): boolean {    
    if (sessionStorage.getItem("usuario-autenticado") == "1") {
      return true;
    }
    this.router.navigate(['/entrar'], { queryParams: { returnUrl: state.url } });
    return false;
   }
}
