
using System.Collections.Generic;
namespace ExamenWEB3.Models
{
    public class Producto
    {

        private static List<ProductoViewModel> _productos = new List<ProductoViewModel>()
      {
          new ProductoViewModel{Id=1, Name="arroz"},
           new ProductoViewModel{Id=2, Name="azucar"},
            new ProductoViewModel{Id=3, Name="yerba"},
             new ProductoViewModel{Id=4, Name="tomate"}
      };

        public List<ProductoViewModel> GetProductos()
        {
            return _productos;
        }
    }
}

