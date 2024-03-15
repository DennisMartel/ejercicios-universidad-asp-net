using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Ejercicios
{
    public partial class Ejercicio1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_calcular_Click(object sender, EventArgs e)
        {
            lbl_resultado.Visible = true;

            try {
                double descuento = 0;
                double porcentajeAplicado = 0;
                double monto = Convert.ToDouble(txt_totalcompra.Text.ToString());

                if (monto >= 1 && monto <= 100)
                {
                    porcentajeAplicado = 10;
                    descuento = monto * 0.10;
                }

                if (monto > 100 && monto <= 400)
                {
                    porcentajeAplicado = 15;
                    descuento = monto * 0.15;
                }

                if (monto > 400 && monto <= 600)
                {
                    porcentajeAplicado = 20;
                    descuento = monto * 0.20;
                }

                if (monto > 600)
                {
                    porcentajeAplicado = 25;
                    descuento = monto * 0.25;
                }
                lbl_resultado.ForeColor = System.Drawing.Color.Green;
                lbl_resultado.Text = $@"Monto comprado: {monto:0.00}<br />
                                      Porcentaje aplicado de descuento: {porcentajeAplicado}%<br />
                                      Monto del descuento: {descuento:0.00}<br />
                                      Total a pagar: {(monto - descuento):0.00}";
            } catch (FormatException ex) {
                lbl_resultado.ForeColor = System.Drawing.Color.Red;
                lbl_resultado.Text = "Error: " + ex.Message;
            }
        }
    }
}