import { Injectable, Inject, OnInit } from "@angular/core"
import { HttpClient, HttpHeaders, HttpParams } from "@angular/common/http";
import { Observable } from "rxjs";
import { Produto } from "../../modelo/produto";

@Injectable({
    providedIn: "root"
})
export class ProdutoServico implements OnInit {



    private baseURL: string;
    public produtos: Produto[];
    public produtoId: string;
    constructor(private http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
        this.baseURL = baseUrl;
    }

    ngOnInit(): void {
        this.produtos = [];
        this.produtoId = "";
    }

    get headers(): HttpHeaders {
        return new HttpHeaders().set('content-type', 'application/json');
    }
    get params(): HttpParams {
        return new HttpParams().set('produtoId', this.produtoId);
    }
    public cadastrar(produto: Produto): Observable<Produto> {
        return this.http.post<Produto>(this.baseURL + "api/produto", JSON.stringify(produto), { headers: this.headers });
    }

    public salvar(produto: Produto): Observable<Produto> {
        return this.http.post<Produto>(this.baseURL + "api/produto/salvar", JSON.stringify(produto), { headers: this.headers });
    }

    public deletar(produto: Produto): Observable<Produto[]> {
        return this.http.post<Produto[]>(this.baseURL + "api/produto/deletar", JSON.stringify(produto), { headers: this.headers });
    }

    public obterTodosProdutos(): Observable<Produto[]> {
        return this.http.get<Produto[]>(this.baseURL + "api/produto");
    }

    public obterProduto(produtoId: number): Observable<Produto> {
        this.produtoId = produtoId.toString();
        return this.http.get<Produto>(this.baseURL + "api/produto/obterProduto", { params: this.params });
    }
    public obterProduto2(produtoId: number): Produto {
        this.produtoId = produtoId.toString();
        var produto = this.http.get<Produto>(this.baseURL + "api/produto/obterProduto", { params: this.params });
        var produtoy = new Produto();
        produto.subscribe(
            prod => {                
                produtoy.id = prod.id;
                produtoy.nome = prod.nome;
                produtoy.descricao = prod.descricao;
                produtoy.preco = prod.preco;
                produtoy.nomeArquivo = prod.nomeArquivo;
            },
            e => {
                console.log(e.errors);
            });
        return produtoy;
    }
    public enviarArquivo(arquivoSelecionado: File): Observable<string> {
        const formData: FormData = new FormData();
        formData.append("arquivoEnviado", arquivoSelecionado, arquivoSelecionado.name);
        return this.http.post<string>(this.baseURL + "api/produto/enviarArquivo", formData);
    }
}
