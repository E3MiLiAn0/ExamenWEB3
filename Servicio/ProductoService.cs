using ExamenWEB3.Models;
using System.Collections.Generic;
namespace ExamenWEB3.Servicio
{
    public interface ProductoService
    {

         void guardarProducto(ProductoViewModel producto);
         ProductoViewModel buscarProductoPorId(int id);

        List<ProductoViewModel> ObtenerTodos();
    }
}
