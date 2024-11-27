using Microsoft.AspNetCore.Mvc;
using Pim2.Data;
using System.Linq;

namespace Pim2.Controllers
{
    public class PedidosController : Controller
    {
        private readonly PimContext _context;

        public PedidosController(PimContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var pedidos = _context.Pedidos.ToList();
            return View(pedidos);
        }
    }
}
