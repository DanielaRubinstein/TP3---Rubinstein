using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using System.Data.SqlClient;

namespace Negocio
{
    public class ProductoNegocio
    {
        public List<Producto> listar()
        {
            List<Producto> lista = new List<Producto>();
            AccesoDatos accesoDatos = new AccesoDatos();
            Producto producto;
            try
            {
                accesoDatos.SetearConsulta("select Id, Titulo, Descripcion, URLImagen from Productos");
                accesoDatos.AbrirConexion();
                accesoDatos.ejecutarConsulta();

                while (accesoDatos.Lector.Read())
                {
                    producto = new Producto();
                    producto.ID = (Int64)accesoDatos.Lector["Id"];
                    producto.Titulo = accesoDatos.Lector["Titulo"].ToString();
                    producto.Descripcion = accesoDatos.Lector["Descripcion"].ToString();
                    producto.UrlImagen = accesoDatos.Lector["URLImagen"].ToString();
                    lista.Add(producto);
                }
                return lista;

            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                accesoDatos.cerrarConexion();
            }
        }

    }
}
