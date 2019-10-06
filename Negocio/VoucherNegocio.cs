using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Negocio
{
    public class VoucherNegocio
    {
        public static Voucher traer(string codVoucher)
        {
            AccesoDatos accesoDatos = new AccesoDatos();
            try
            {
                Voucher cupon = null;
                accesoDatos.SetearConsulta("select CodigoVoucher from Vouchers where Estado=1 and CodigoVoucher=" + codVoucher);
                accesoDatos.AbrirConexion();
                accesoDatos.ejecutarConsulta();
                if (accesoDatos.Lector.Read())
                {
                    cupon = new Voucher();
                    cupon.CodigoVoucher = (string)accesoDatos.Lector["CodigoVoucher"].ToString();
                    cupon.Estado = true;
                }
                return cupon;

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

        public static bool verificar(string codigo)
        {
            AccesoDatos accesoDatos = new AccesoDatos();
            try
            {
                accesoDatos.SetearConsulta("select CodigoVoucher from Vouchers where Estado=0 and CodigoVoucher='" + codigo + "'");
                accesoDatos.AbrirConexion();
                accesoDatos.ejecutarConsulta();
                if (accesoDatos.Lector.Read())
                {
                    return true;
                }
                else
                {
                    return false;
                }
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
