using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoInventario.Modelos
{
    public class Producto
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Numero de Serie es Requerido")]
        [MaxLength(60)]
        public string NumeroSerie { get; set; }

        [Required(ErrorMessage = "Descripcion es Requerido")]
        [MaxLength(100)]
        public string Descripcion { get; set; }

        [Required(ErrorMessage = "Precio es Requerido")]
        public double Precio { get; set; }

        [Required(ErrorMessage = "Costo es Requerido")]
        public double Costo { get; set; }
        public string ImagenUrl { get; set; }

        [Required(ErrorMessage = "Estado es Requerido")]
        public bool Estado { get; set; }

        //navegacion de llaves foraneas

        [Required(ErrorMessage = "CategoriaId es Requerido")]
        public int CategoriaId { get; set; }

        [ForeignKey(nameof(CategoriaId))]
        public Categoria Categoria { get; set; }

        [Required(ErrorMessage = "MarcaId es Requerido")]
        public int MarcaId { get; set; }

        [ForeignKey(nameof(MarcaId))]
        public Marca Marca { get; set; }

        //campo de recursividad - relacionar un producto consigo mismo
        public int? PadreId { get; set; }
        public virtual Producto Padre { get; set; }
    }
}
