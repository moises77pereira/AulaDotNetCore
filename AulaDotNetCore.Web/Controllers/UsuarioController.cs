using AulaDotNetCore.Dominio.Entidades;
using Microsoft.AspNetCore.Mvc;
using System;

namespace AulaDotNetCore.Web.Controllers
{
    [Route("api/[Controller]")]
    public class UsuarioController:Controller
    {
        [HttpGet]
        public ActionResult Get()
        {
            try
            {
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
        [HttpPost]
        public ActionResult Post()
        {
            try
            {
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpPost("VerificarUsuario")]
        public ActionResult VerificarUsuario([FromBody] Usuario usuario)
        {
            try
            {
                if(usuario.Email == "moises@gmail.com" && usuario.Senha == "123")
                    return Ok(usuario);
                return BadRequest("Usuário ou senha inválido");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
    }
}
