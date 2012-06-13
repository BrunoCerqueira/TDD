using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ES1TDD
{
    public partial class _default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.Form["txtCodigo"] != null)
            {
                string codigoCupom = Request.Form["txtCodigo"].ToString();
                Cupom cupom = new Cupom(codigoCupom);
                if (cupom.IsValido())
                    ClientScript.RegisterStartupScript(this.GetType(), "Alerta", "Você adicionou " + cupom.getPotz() + " potz.");
                else
                    ClientScript.RegisterStartupScript(this.GetType(), "Alerta", "O código inserido não é válido.");
            }
        }
    }
}