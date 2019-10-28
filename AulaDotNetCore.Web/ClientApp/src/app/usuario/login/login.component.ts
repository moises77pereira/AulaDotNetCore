import { Component, OnInit } from "@angular/core"
import { Usuario } from "../../modelo/usuario";
import { Router, ActivatedRoute } from "@angular/router";
import { UsuarioServico } from "../../servicos/usuario/usuario.servico";

@Component({
  selector: "app-login",
  templateUrl: "./login.component.html",
  styleUrls:["./login.component.css"]
})
export class LoginComponent implements OnInit {
    
  public usuario;
  public returnUrl: string;
  public mensagem: string;
  public ativar_sppiner: boolean;
  constructor(private router: Router, private activatedRouter: ActivatedRoute, private usuarioServico: UsuarioServico) {
  }
  ngOnInit(): void {
    this.returnUrl = this.activatedRouter.snapshot.queryParams['returnUrl'];
    this.usuario = new Usuario();
  }
  entrar() {
    this.ativar_sppiner = true;
    this.usuarioServico.verificarUsuario(this.usuario).subscribe(
      usuario_json => {
        this.usuarioServico.usuario = usuario_json;
        if (this.returnUrl == null)
          this.router.navigate(['/']);
        else
          this.router.navigate([this.returnUrl]);
      },
      err => {
        this.mensagem = err.error;
        this.ativar_sppiner = false;
      }
    );
  }  
}
