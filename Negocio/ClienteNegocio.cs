using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using System.Data.SqlClient;

namespace Negocio
{
    public class ClienteNegocio
    {
        public List<Cliente> listar()
        {
            List<Cliente> lista = new List<Cliente>();
            AccesoDatos accesoDatos = new AccesoDatos();
            Cliente cliente;

            try
            {
                accesoDatos.SetearConsulta("select Id, DNI, Nombre, Apellido, Email, Direccion, Ciudad, CodigoPostal,FechaRegistro from clientes");
                accesoDatos.AbrirConexion();
                accesoDatos.ejecutarConsulta();

                while (accesoDatos.Lector.Read())
                {
                    cliente = new Cliente();
                    cliente.Id = (Int64)accesoDatos.Lector["Id"];
                    cliente.DNI = (int)accesoDatos.Lector["DNI"];
                    cliente.Nombre = accesoDatos.Lector["Nombre"].ToString();
                    cliente.Apellido = accesoDatos.Lector["Apellido"].ToString();
                    cliente.Email = accesoDatos.Lector["Email"].ToString();
                    cliente.Direccion = accesoDatos.Lector["Direccion"].ToString();
                    cliente.Ciudad = accesoDatos.Lector["Ciudad"].ToString();
                    cliente.CP = accesoDatos.Lector["CodigoPostal"].ToString();
                    cliente.Fecha_registro = (DateTime)accesoDatos.Lector["FechaRegistro"];
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

        public Cliente traer(int dni)
        {
            AccesoDatos accesoDatos = new AccesoDatos();
            Cliente cliente;
            try
            {
                cliente = new Cliente();
                accesoDatos.SetearConsulta("Select Id, DNI, Nombre, Apellido, Email, Direccion, Ciudad, CodigoPostal,FechaRegistro from clientes where DNI=" + dni);
                accesoDatos.AbrirConexion();
                accesoDatos.ejecutarConsulta();
                while (accesoDatos.Lector.Read())
                {
                    cliente.DNI = (int)accesoDatos.Lector["dni"];
                    cliente.Nombre = accesoDatos.Lector["Nombre"].ToString();
                    cliente.Apellido = accesoDatos.Lector["Apellido"].ToString();
                    cliente.Email = accesoDatos.Lector["Email"].ToString();
                    cliente.Direccion = accesoDatos.Lector["direccion"].ToString();
                    cliente.Ciudad = accesoDatos.Lector["ciudad"].ToString();
                    cliente.CP = accesoDatos.Lector["CodigoPostal"].ToString();
                }
                return cliente;
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
