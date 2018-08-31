using EvaluacionProducto.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace EvaluacionProducto.DataLayer
{
    public class InventarioDL
    {

        public ConexionBD Bd { get; set; }
        public SqlCommand cmd { get; set; }
        public string IdInventario { get; private set; }

        public InventarioDL()
        {
            Bd = new ConexionBD();
        }
        public List<Inventario> Listar()
        {
            List<Inventario> lInventario = new List<Inventario>();
            Bd.Cnx.Open();

            cmd = new SqlCommand("Select * from Inventario inv, Producto pro where pro.IdProducto=inv.IdProducto", Bd.Cnx);
            SqlDataReader rs;
            rs = cmd.ExecuteReader();
            while (rs.Read())
            {
                Inventario inv = new Inventario();
                inv.IdInventario = Convert.ToInt32(rs["IdInventario"]);
                inv.cantidadexistencia = rs["cantidadexistencia"].ToString();
                inv.cantidadingreso = rs["cantidadingreso"].ToString();
                inv.valoringreso = rs["valoringreso"].ToString();
                inv.fechaingreso = rs["fechaingreso"].ToString();
               inv.Producto.IdProducto = Convert.ToInt32(rs["IdProducto"]);
                inv.Producto.nombre= rs["nombre"].ToString();
                inv.IdProducto = Convert.ToInt32(rs["IdProducto"]);
              
                lInventario.Add(inv);

            }
            // CIERRE WHILE
            Bd.Cnx.Close();
            return lInventario;

        }//fin de listar


        public Inventario Buscar(int Idventario)
        {
            Bd.Cnx.Open();
            cmd = new SqlCommand("Select inv.IdInventario, inv.cantidadexistencia, inv.cantidadingreso, inv.valoringreso, inv.fechaingreso, pro.IdProducto, pro.nombre From [Inventario] as inv,[Producto] as pro where inv.IdProducto=pro.IdProducto and inv.IdInventario=" + IdInventario, Bd.Cnx);
            SqlDataReader rs;
            rs = cmd.ExecuteReader();
            Inventario inv = new Inventario();
            while (rs.Read())
            {
                inv.IdInventario= Convert.ToInt32(rs["IdInventario"]);
                inv.cantidadexistencia = rs["cantidadexistencia"].ToString();
                inv.cantidadingreso = rs["cantidadingreso"].ToString();
                inv.valoringreso = rs["valoringreso"].ToString();
                inv.fechaingreso = rs["fechaingreso"].ToString();
                inv.Producto.IdProducto= Convert.ToInt32(rs["IdProducto"]);
                inv.Producto.nombre=rs["nombre"].ToString();
               
                inv.IdProducto = Convert.ToInt32(rs["IdProducto"]);

            }//FIN WHILE
            Bd.Cnx.Close();
            return inv;
        }//fin buscar


        public bool Guardar(Inventario inventario)
        {
            bool respuesta = false;
            Bd.Cnx.Open();
            cmd = new SqlCommand("Insert into Inventario( cantidadexistencia, cantidadingreso, valoringreso,fechaingreso, IdProducto) values (@cantidadexistente, @cantidadingreso, @valoringreso, @fechaingreso, @IdProducto)", Bd.Cnx);
            cmd.Parameters.AddWithValue("@cantidadexistente", inventario.cantidadexistencia);
            cmd.Parameters.AddWithValue("@cantidadingreso", inventario.cantidadingreso);
            cmd.Parameters.AddWithValue("@valoringreso", inventario.valoringreso);
            cmd.Parameters.AddWithValue("@fechaingreso", inventario.fechaingreso);
            //cmd.Parameters.AddWithValue("@IdInventario", inventario.IdInventario);


            cmd.Parameters.AddWithValue("@IdProducto", inventario.IdProducto);
            cmd.ExecuteNonQuery();
            Bd.Cnx.Close();
            respuesta = true;
            return respuesta;


        }// fin metodo guardar 

    }
}