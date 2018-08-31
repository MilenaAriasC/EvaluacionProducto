using EvaluacionProducto.DataLayer;
using EvaluacionProducto.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EvaluacionProducto.BussinesLayer
{
    public class ProductoBL
    {
        public ProductoDL productoDL = new ProductoDL();
        public List<Producto> listar()
        {
            return productoDL.Listar();
        } //fin listar
    }
}