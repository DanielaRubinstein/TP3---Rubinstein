using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Negocio;
using Dominio;

namespace WebForm___VoucherPromo
{
    public partial class FormularioCliente : System.Web.UI.Page
    {
        private List<Cliente> listadoCliente;
        protected void Page_Load(object sender, EventArgs e)
        {
            var idPremio = Convert.ToInt64(Request.QueryString["idPremio"]);


        }

        protected void btnEnviar_Click(object sender, EventArgs e)
        {

        }

        protected void txtDni_TextChanged(object sender, EventArgs e)
        {
            int dni = int.Parse(DNI.Text);
            ClienteNegocio clienteNegocio = new ClienteNegocio();
            Cliente cliente = new Cliente();
            Response.Redirect("FormularioClienteFilled.aspx");


            //Cliente cliente = new Cliente();
            //Cliente viejoCliente = ClienteNegocio.traer(dni);

            //first_name.Text = cliente.Nombre;
            //last_name.Text = cliente.Apellido;




        }
    }
}