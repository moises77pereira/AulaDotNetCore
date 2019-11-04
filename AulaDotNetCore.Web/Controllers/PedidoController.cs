using AulaDotNetCore.Dominio.Contratos;
using Microsoft.AspNetCore.Mvc;

namespace AulaDotNetCore.Web.Controllers
{
    public class PedidoController :Controller
    {
        private IPedidoRepositorio _pedidoRepositorio;
        public PedidoController(IPedidoRepositorio pedidoRepositorio)
        {
            this._pedidoRepositorio = pedidoRepositorio;
        }
    }
}
