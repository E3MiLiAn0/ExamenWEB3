using Microsoft.AspNetCore.Mvc;
using ExamenWEB3.Models;
using ExamenWEB3.Servicio;
using System.Collections.Generic;
namespace ExamenWEB3.Controllers
{
    public class ProductoController : Controller
    {
        ProductoService _productoService;

        public ProductoController(ProductoService productoService)
        {
            _productoService = productoService;
        }

        

        public IActionResult Lista()
        {
            List<ProductoViewModel> listaProductos = _productoService.ObtenerTodos();
            return View(listaProductos);
                
                }
        
    }
}
