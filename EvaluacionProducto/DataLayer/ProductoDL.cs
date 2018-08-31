using EvaluacionProducto.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace EvaluacionProducto.DataLayer
{
    public class ProductoDL
    {

        public ConexionBD Bd { get; set; }
        public SqlCommand cmd { get; set; }

        public ProductoDL() // constructor
        {
            Bd = new ConexionBD();
        }//fin constructor 

        public List<Producto> Listar()
        {
            List<Producto> listProducto = new List<Producto>();

            Bd.Cnx.Open();
            cmd = new SqlCommand("Select * From Producto", Bd.Cnx);
            SqlDataReader rs;
            rs = cmd.ExecuteReader();

            while (rs.Read())
            {
                Producto pro = new Producto();
                
                pro.IdProducto = Convert.ToInt32(rs["IdProducto"]);
                pro.codigo = rs["codigo"].ToString();
                pro.nombre = rs["nombre"].ToString();
               

                listProducto.Add(pro);


            }//fin while
            Bd.Cnx.Close();
            return listProducto;



        }// Fin Listar 






    }
}