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
    public class MarcaRepositorio : Repositorio<Marca>, IMarcaRepositorio
    {
        private readonly ApplicationDbContext _db;
        public MarcaRepositorio(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Actualizar(Marca marca)
        {
            var MarcaBD = _db.Marcas.FirstOrDefault(b => b.Id == marca.Id);
            if (MarcaBD != null)
            {
                MarcaBD.Nombre = marca.Nombre;
                MarcaBD.Descripcion = marca.Descripcion;
                MarcaBD.Estado = marca.Estado;
                _db.SaveChanges();
            }
        }
    }
}
