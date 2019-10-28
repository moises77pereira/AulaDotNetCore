import { Component, OnInit } from "@angular/core"
import { Produto } from "../../modelo/produto";
import { ProdutoServico } from "../../servicos/produto/produto.servico";
import { Router } from "@angular/router";
import { UsuarioServico } from "../../servicos/usuario/usuario.servico";
@Component({
    selector: "pesquisa-produto",
    templateUrl: "./pesquisa.produto.component.html",
    styleUrls: ["./pesquisa.produto.component.css"]
})
export class PesquisaProdutoComponent implements OnInit {

    public produtos: Produto[];
    ngOnInit(): void {

    }
    constructor(private produtoServico: ProdutoServico, private router: Router, private usuarioServico: UsuarioServico) {
        if (this.usuarioServico.usuario_administrador()) {
            this.produtoServico.obterTodosProdutos()
                .subscribe(
                    produtos => {
                        this.produtos = produtos;
                    },
                    e => {
                        console.log(e.error);
                    }

                );
        } else
            this.router.navigate(['/entrar']);
    }

    public adicionarProduto() {
        sessionStorage.setItem('produtoSession', "");
        this.router.navigate(['/produto']);
    }

    public deletarProduto(produto: Produto) {
        var retorno = confirm("Deseja realmente deletar o produto selecionado?");
        if (retorno) {
            this.produtoServico.deletar(produto).subscribe(
                produtos => {
                    this.produtos = produtos;
                },
                e => {
                    console.log(e.errors);
                }
            );
        }
    }

    public editarProduto(produto: Produto) {
        sessionStorage.setItem('produtoSession', JSON.stringify(produto));
        this.router.navigate(['/produto']);
    }

}
