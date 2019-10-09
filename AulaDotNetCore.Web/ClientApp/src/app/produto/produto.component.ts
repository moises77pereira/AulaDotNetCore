import { Component, OnInit } from "@angular/core"
import { Produto } from "../modelo/produto";
import { ProdutoServico } from "../servicos/produto/produto.servico";
import { Router } from "@angular/router";

@Component({
  selector: "app-produto",
  templateUrl: "./produto.component.html",
  styleUrls: ["./produto.component.css"]
})
export class ProdutoComponent implements OnInit {

  public produto: Produto;
  public arquivoSelecionado: File;
  public ativar_spinner: boolean;
  public mensagem: string;
  public produtoCadastrado: boolean;
  

  constructor(private produstoServico: ProdutoServico, private router: Router) {

  }
  ngOnInit(): void {
    var produtoSession = sessionStorage.getItem('produtoSession');
    if (produtoSession) {
      this.produto = JSON.parse(produtoSession);
    } else {
      this.produto = new Produto();
    }
  }

  public inputChange(files: FileList) {
    this.ativarSpinner();
    this.arquivoSelecionado = files.item(0);
    this.produstoServico.enviarArquivo(this.arquivoSelecionado).subscribe(
      nomeArquivo => {
        console.log(nomeArquivo);
        this.produto.nomeArquivo = nomeArquivo;
        this.desativarSpinner();
      },
      e => {
        console.log(e.error);
        this.desativarSpinner();
      }
    );    
  }

  public cadastrar() {
    this.ativarSpinner();
    this.produstoServico.cadastrar(this.produto)
      .subscribe(
        produtoJson => {
          console.log(produtoJson);
          this.mensagem = "";
          this.desativarSpinner();
          this.router.navigate(['/pesquisar-produto']);
        },
        e => {
          this.mensagem = e.error;
          this.desativarSpinner();
        }
    );
  }

  public ativarSpinner() {
    this.ativar_spinner = true;
  }

  public desativarSpinner() {
    this.ativar_spinner = false;
  }
}
