using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Ejercicios
{
    public partial class Ejercicio3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_calcular_Click(object sender, EventArgs e)
        {
            lbl_resultado.Visible = true;

            try 
            {
                int cantidad = Convert.ToInt32(txt_cantidad.Text);
                double descuento = 0;
                double totalPagar = 0;
                double precioArticulo = 10.00;

                if (cantidad >= 1 && cantidad <= 5)
                {
                    descuento = 0.10;
                }

                if (cantidad >= 6 && cantidad <=10)
                {
                    descuento = 0.20;
                }

                if (cantidad >= 11 && cantidad <= 15)
                {
                    descuento = 0.30;
                }

                if (cantidad >= 16 && cantidad <= 20)
                {
                    descuento = 0.40;
                }

                if (cantidad > 20)
                {
                    descuento = 0.50;
                }

                totalPagar = precioArticulo * cantidad * (1 - descuento);

                lbl_resultado.ForeColor = System.Drawing.Color.Green;
                lbl_resultado.Text = $@"Descuento aplicado: {descuento * 100}% <br>
                                        Total a pagar: ${totalPagar:0.00}";
            } 
            catch (FormatException ex) 
            {
                lbl_resultado.ForeColor = System.Drawing.Color.Red;
                lbl_resultado.Text = $@"Error: {ex.Message}";
            }
        }
    }
}