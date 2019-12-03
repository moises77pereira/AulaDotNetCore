using AulaDotNetCore.Dominio.Contratos;
using Microsoft.AspNetCore.Mvc;
using System;

namespace AulaDotNetCore.Web.Controllers
{
 
    [Route("api/[Controller]")]
    public class PedidoController :Controller
    {
        private readonly IPedidoRepositorio _pedidoRepositorio;
        public PedidoController(IPedidoRepositorio pedidoRepositorio)
        {
            this._pedidoRepositorio = pedidoRepositorio;
        }
        [HttpPost]
        public IActionResult Post([FromBody] Dominio.Entidades.Pedido pedido)
        {
            try
            {
                _pedidoRepositorio.Adicionar(pedido);
                return Ok(pedido.Id);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
    }
}
