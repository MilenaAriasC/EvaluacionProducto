using EvaluacionProducto.DataLayer;
using EvaluacionProducto.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EvaluacionProducto.BussinesLayer
{
    public class InventarioBL
    {
        public InventarioDL inventariodl = new InventarioDL();
        public List<Inventario> listar()
        {
            return inventariodl.Listar();
        }//fin listar
        public void guardar(Inventario inventario)
        {
            inventariodl.Guardar(inventario);
        }//fin guardar
       

       
        public Inventario buscar(int IdInventario)
        {
            return inventariodl.Buscar(IdInventario);
        }
        internal void guardar(object inventario)
        {
            throw new NotFiniteNumberException();
        }
    }
}