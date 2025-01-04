using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoInventario.Modelos
{
    public class Bodega
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Nombre obligatorio")]
        [MaxLength(60, ErrorMessage = "Nombre maximo de 60 caracteres")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "Descripción obligatorio")]
        [MaxLength(100, ErrorMessage = "Descripción maximo de 100 caracteres")]
        public string Descripcion { get; set; }

        [Required(ErrorMessage = "Estado obligatorio")]
        public bool Estado { get; set; }


    }
}
