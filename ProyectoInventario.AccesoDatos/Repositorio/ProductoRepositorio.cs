using Microsoft.AspNetCore.Mvc.Rendering;
using ProyectoInventario.AccesoDatos.Data;
using ProyectoInventario.AccesoDatos.Repositorio.IRepositorio;
using ProyectoInventario.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoInventario.AccesoDatos.Repositorio
{
    public class ProductoRepositorio : Repositorio<Producto>, IProductoRepositorio
    {
        private readonly ApplicationDbContext _db;
        public ProductoRepositorio(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Actualizar(Producto producto)
        {
            var ProductoBD = _db.Productos.FirstOrDefault(b => b.Id == producto.Id);

            if (ProductoBD != null)
            {

                if (ProductoBD.ImagenUrl != null)
                {
                    ProductoBD.ImagenUrl = ProductoBD.ImagenUrl;
                }

                ProductoBD.NumeroSerie = producto.NumeroSerie;
                ProductoBD.Descripcion = producto.Descripcion;
                ProductoBD.Precio = producto.Precio;
                ProductoBD.Costo = producto.Costo;
                ProductoBD.Estado = producto.Estado;
                ProductoBD.CategoriaId = producto.CategoriaId;
                ProductoBD.MarcaId = producto.MarcaId;
                ProductoBD.PadreId = producto.PadreId;
                ProductoBD.ImagenUrl = producto.ImagenUrl;

                _db.SaveChanges();
            }
        }

        public IEnumerable<SelectListItem> ObtenerTodosDropDownLista(string obj)
        {
            if (obj == "Categoria")
            {
                return _db.Categorias.Where(c => c.Estado == true).Select(c => new SelectListItem
                {
                    Text = c.Nombre,
                    Value = c.Id.ToString()
                });
            }
            if (obj == "Marca")
            {
                return _db.Categorias.Where(m => m.Estado == true).Select(c => new SelectListItem
                {
                    Text = c.Nombre,
                    Value = c.Id.ToString()
                });
            }
            if (obj == "Producto")
            {
                return _db.Productos.Where(m => m.Estado == true).Select(c => new SelectListItem
                {
                    Text = c.Descripcion,
                    Value = c.Id.ToString()
                });
            }
            return null;
        }
    }
}
