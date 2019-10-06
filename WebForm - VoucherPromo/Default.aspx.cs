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
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {


        }

        protected void btnEnviar_Click(object sender, EventArgs e)
        {
            if (txtVoucher.Text.Trim() != "")
            {
                if (VoucherNegocio.verificar(txtVoucher.Text.Trim()))
                {
                    Session.Add("CodigoVoucher", txtVoucher.Text.Trim());
                    Response.Redirect("Premio.aspx");
                }
                else
                {
                    Session["Error" + Session.SessionID] = "El codigo es invalido";
                    Response.Redirect("Error.aspx");
                    //ScriptManager.RegisterStartupScript(this, typeof(Page), "alert", "M.toast({ html: 'Voucher inválido' })", true);
                }
            }
            else
            {
                Session["Error" + Session.SessionID] = "Campo vacio";
                Response.Redirect("Error.aspx");
                //ScriptManager.RegisterStartupScript(this, typeof(Page), "alert", "M.toast({html: Campo vacio})", true);
            }

        }
    }
}