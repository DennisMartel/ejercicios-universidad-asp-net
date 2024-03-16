using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Ejercicios
{
    public partial class Ejercicio4 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_calcular_Click(object sender, EventArgs e)
        {
            lbl_resultado.Visible = true;

            try
            {
                double descuento = 0;
                double monto = Convert.ToDouble(txt_totalcompra.Text);

                if (monto > 0 && monto <= 1000)
                {
                    descuento = monto * 0.10;
                }

                if (monto > 1000 && monto <= 3000)
                {
                    descuento = monto * 0.20;
                }

                if (monto > 3000)
                {
                    descuento = monto * 0.30;
                }

                lbl_resultado.ForeColor = System.Drawing.Color.Green;
                lbl_resultado.Text = $@"Monto del descuento: {descuento:0.00}<br />
                                      Total a pagar: {(monto - descuento):0.00}";
            }
            catch (FormatException ex)
            {
                lbl_resultado.ForeColor = System.Drawing.Color.Red;
                lbl_resultado.Text = "Error: " + ex.Message;
            }
        }
    }
}