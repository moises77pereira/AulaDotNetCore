import { Injectable, Inject } from "@angular/core";
import { HttpClient, HttpHeaders } from "@angular/common/http";
import { Pedido } from "../../modelo/pedido";
import { Observable } from "rxjs";

@Injectable({
    providedIn:'root'
})
export class PedidoServico {
    
    private baseURL: string;
    constructor(private http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
        this.baseURL = baseUrl;
    }
    get headers(): HttpHeaders {
        return new HttpHeaders().set('content-type', 'application/json');
    }

    public efetivarCompra(pedido: Pedido): Observable<number> {
        return this.http.post<number>(this.baseURL + "api/pedido", JSON.stringify(pedido), { headers: this.headers });
    }
}
