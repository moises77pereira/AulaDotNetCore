import { Component, OnInit } from "@angular/core";
import { Usuario } from "../../modelo/usuario";
import { UsuarioServico } from "../../servicos/usuario/usuario.servico";

@Component({
  selector: "cadastro-usuario",
  templateUrl: "./cadastro.usuario.component.html",
  styleUrls: ["./cadastro.usuario.component.css"]
})
export class CadastroUsuarioComponent implements OnInit {
    
  public usuario: Usuario;
  public ativar_sppiner: boolean;

  constructor(private usuarioServico: UsuarioServico) {

  }

  ngOnInit(): void {
    this.usuario = new Usuario();
  }

  public cadastrar() {
    //this.ativar_sppiner = true;
    
    //this.usuarioServico.cadastrarUsuario(this.usuario)
    //  .subscribe(
    //    usuarioJson => {

    //    },
    //    e => {

    //    }
    //  );
  }

}
