using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mvcProyectoweb.Models
{
    public class Almacen
    {
        [Key]
        public int id { get; set; }
        [Required(ErrorMessage = "ingrese el nombre del almacen")]
        [Display(Name = "Nombre del Almacen")]

        public string NombreAlmacen { get; set; }
        [Required(ErrorMessage = "la direccion es obligatoria")]

        public string Direccion { get; set; }
        [DataType(DataType.ImageUrl)]
        [Display(Name = "Imagen")]
        public string UrlImagen { get; set; }
        [Display(Name ="Orden de Visualizacion")]
        [Range(1,100, ErrorMessage = "El valor debe estar entre 1 y 100")]
        public int Orden { get; set;}





    }
}
