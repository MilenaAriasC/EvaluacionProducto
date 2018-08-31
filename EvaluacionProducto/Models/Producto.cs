using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EvaluacionProducto.Models
{
    public class Producto
    {
        public int IdProducto { get; set; }
        public String codigo { get; set; }
        public String nombre { get; set; }
        public String descripcion { get; set; }
        
    }
}