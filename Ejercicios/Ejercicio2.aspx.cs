using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Ejercicios
{
    public partial class Ejercicio2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_calcular_Click(object sender, EventArgs e)
        {
            lbl_resultado.Visible = true;
            try 
            { 
                double sueldo = Convert.ToDouble(txt_sueldo.Text);
                double isss = sueldo > 657.25 ? sueldo * 0.03 : 0;
                double renta = sueldo > 857.15 ? sueldo * 0.10 : 0;
                double afp = sueldo > 450.00 ? sueldo * 0.05 : 0;
                double seguro = sueldo < 1000 ? sueldo * 0.04 : sueldo * 0.06;
                double sueldoNeto = sueldo - isss - renta - afp - seguro;

                lbl_resultado.ForeColor = System.Drawing.Color.Green;
                lbl_resultado.Text = $@"Descuentos aplicados <br />
                                        ISSS: {isss:0.00} <br />
                                        Renta: {renta:0.00} <br />
                                        AFP: {afp:0.00}<br />
                                        Seguro: {seguro:0.00}<br />
                                        ==============================<br />
                                        Salario: {sueldoNeto:0.00}";
            } 
            catch (FormatException ex) 
            { 
                lbl_resultado.ForeColor = System.Drawing.Color.Red;
                lbl_resultado.Text = "Error:" + ex.Message;
            }
        }
    }
}