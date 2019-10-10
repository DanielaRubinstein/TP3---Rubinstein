using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Dominio;
using Negocio;

namespace WebForm___VoucherPromo
{
    public partial class FormularioClienteFilled : System.Web.UI.Page
    {
        public List<Cliente> listaCliente;
        public Cliente cliente;
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                ClienteNegocio cliente = new ClienteNegocio();
                //var clienteViejo = Convert.ToInt32(Request.QueryString["DNI"]);
                listaCliente = cliente.listar();
                
            }
            catch (Exception ex)
            {

                throw ex;
            }


        }
    }
}