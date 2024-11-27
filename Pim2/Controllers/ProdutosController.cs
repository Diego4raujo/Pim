using Microsoft.AspNetCore.Mvc;
using Pim2.Data;
using System.Linq;

namespace Pim2.Controllers
{
    public class ProdutosController : Controller
    {
        private readonly PimContext _context;

        public ProdutosController(PimContext context)
        {
            _context = context;
        }

        // Ação que exibe a lista de produtos
        public IActionResult Index()
        {
            // Recuperando todos os produtos do banco de dados
            var produto = _context.Produto.ToList();
            // Retorna a view com a lista de produtos
            return View(produto);
        }
    }
}