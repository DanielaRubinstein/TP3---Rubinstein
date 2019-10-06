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
    public partial class Premios : System.Web.UI.Page
    {
        public List<Producto> listaPremios { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                ProductoNegocio premio = new ProductoNegocio();
                listaPremios = premio.listar();

            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
    }
}