using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EvaluacionProducto.Models
{
    public class Inventario
    {
      
        public int IdInventario { get; set; } 
        public String cantidadexistencia { get; set; }
        public String cantidadingreso { get; set; }
        public String valoringreso { get; set; }
        public String fechaingreso { get; set; }
        
        public Producto Producto { get; set;}
        [Display(Name = "Producto")]
        public int IdProducto { get; set; }

        public Inventario()
        {
            Producto = new Producto();
        }

    }
}