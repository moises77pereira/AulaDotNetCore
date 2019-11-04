import { Component, OnInit } from "@angular/core";
import { LojaCarrinhoCompras } from "../carrinho-compras/loja.carrinho.compras";
import { Produto } from "../../modelo/produto";
import { ProdutoServico } from "../../servicos/produto/produto.servico";
import { Pedido } from "../../modelo/pedido";
import { UsuarioServico } from "../../servicos/usuario/usuario.servico";
import { ItemPedido } from "../../modelo/itemPedido";
import { PedidoServico } from "../../servicos/pedido/pedido.servico";
@Component({
    selector: "loja-efetivar",
    templateUrl: "./loja.efetivar.component.html",
    styleUrls: ["./loja.efetivar.component.css"]
})
export class LojaEfetivarComponent implements OnInit {
    public carrinhoCompras: LojaCarrinhoCompras;
    public produtos: Produto[];
    public total: number;
    ngOnInit(): void {
        this.carrinhoCompras = new LojaCarrinhoCompras();
        this.produtos = this.carrinhoCompras.obterProdutos();
        this.atualizarTotal();
    }

    constructor(private usuarioServico: UsuarioServico, private pedidoServico: PedidoServico) {

    }

    public atualizarPreco(produto: Produto, quantidade: number) {
        if (!produto.precoOriginal) {
            produto.precoOriginal = produto.preco;
        }
        if (quantidade <= 0) {
            quantidade = 1
            produto.quantidade = 1;
        }
        produto.preco = produto.precoOriginal * quantidade;
        this.carrinhoCompras.atualizar(this.produtos);
        this.atualizarTotal();
    }
    public remover(produto: Produto) {
        this.carrinhoCompras.removerProduto(produto);
        this.produtos = this.carrinhoCompras.obterProdutos();
        this.atualizarTotal();
    }
    public atualizarTotal() {
        this.total = this.produtos.reduce((acc, produto) => acc + produto.preco, 0);
    }

    public efetivarCompra() {
        let pedido = this.criarPedido();
        this.pedidoServico.efetivarCompra(pedido).subscribe(
            pedidoId => { },
            e => {}
        );
    }

    public criarPedido(): Pedido {
        let pedido = new Pedido();
        pedido.usuarioId = this.usuarioServico.usuario.id;
        pedido.cep = "21520790";
        pedido.cidade = "Rio de Janeiro";
        pedido.estado = "RJ";
        pedido.dataPrevisaoEntrega = new Date();
        pedido.formaPagamentoId = 1;
        pedido.numeroEndereco = "1";
        this.produtos = this.carrinhoCompras.obterProdutos();
        for (let produto of this.produtos) {
            let itemPedido = new ItemPedido();
            itemPedido.produtoId = produto.id;
            if (!produto.quantidade)
                produto.quantidade = 1;
            itemPedido.quantidade = produto.quantidade;
        }
        return pedido;
    }
}
