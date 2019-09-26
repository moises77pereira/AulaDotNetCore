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
  constructor(private router: Router, private activatedRouter: ActivatedRoute, private usuarioServico: UsuarioServico) {
  }
  ngOnInit(): void {
    this.returnUrl = this.activatedRouter.snapshot.queryParams['returnUrl'];
    this.usuario = new Usuario();
  }
  entrar() {
    this.usuarioServico.verificarUsuario(this.usuario).subscribe(
      data => {
        var usuarioRetorno: Usuario;
        usuarioRetorno = data;
        sessionStorage.setItem("usuario-autenticado", "1");
        sessionStorage.setItem("email-usuario", usuarioRetorno.email);
        if (this.returnUrl == null)
          this.router.navigate(['/']);
        else
          this.router.navigate([this.returnUrl]);
      },
      err => {
        this.mensagem = err.error;
        sessionStorage.setItem("usuario-autenticado", "0");
      }
    );
    //if (this.usuario.email == "moises@gmail.com" && this.usuario.senha == "123") {
    //  sessionStorage.setItem("usuario-autenticado", "1");
    //  this.router.navigate([this.returnUrl]);
    //} else {
    //  sessionStorage.setItem("usuario-autenticado", "0");
    //}
  }  
}
