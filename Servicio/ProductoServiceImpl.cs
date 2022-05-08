using ExamenWEB3.Models;
using System.Collections.Generic;
using System.Linq;

namespace ExamenWEB3.Servicio
{
    public class ProductoServiceImpl : ProductoService
    {

        static Producto producto = new Producto();
        List<ProductoViewModel> listaProductos = producto.GetProductos();
        public ProductoViewModel buscarProductoPorId(int id)
        {
            foreach (ProductoViewModel producto in listaProductos)
            {
                if (producto.Id == id)
                { return producto; }
            }
            return null;
        }


        public void guardarProducto(ProductoViewModel producto)
        {
            int id = ObtenerIdMasUno();
            producto.Id = id;
            listaProductos.Add(producto);
        }

        public List<ProductoViewModel> ObtenerTodos()
        {
            return listaProductos;
        }

        private int ObtenerIdMasUno
            ()
        {
            return listaProductos.Max(o => o.Id) + 1;
        }

    }
}
