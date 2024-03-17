using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Ejercicios
{
    public partial class Ejercicio5 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_calcularNota_Click(object sender, EventArgs e)
        {
            try 
            { 
                string alumno = txt_alumno.Text;
                double nota1 = Convert.ToDouble(txt_e1.Text);
                double nota2 = Convert.ToDouble(txt_e2.Text);
                double nota3 = Convert.ToDouble(txt_e3.Text);
                double nota4 = Convert.ToDouble(txt_e4.Text);
                double nota5 = Convert.ToDouble(txt_e5.Text);

                double notaFinal = (nota1 + nota2 + nota3 + nota4 + nota5) / 5;
                double porcentaje = 100 / 5;
                double puntosGanadosE1 = nota1 / 5;
                double puntosGanadosE2 = nota2 / 5;
                double puntosGanadosE3 = nota3 / 5;
                double puntosGanadosE4 = nota4 / 5;
                double puntosGanadosE5 = nota5 / 5;

                Session["nota1"] = nota1;
                Session["nota2"] = nota2;
                Session["nota3"] = nota3;
                Session["nota4"] = nota4;
                Session["nota5"] = nota5;
                Session["notalFinal"] = notaFinal;
                Session["porcentaje"] = porcentaje;
                Session["puntosE1"] = puntosGanadosE1;
                Session["puntosE2"] = puntosGanadosE2;
                Session["puntosE3"] = puntosGanadosE3;
                Session["puntosE4"] = puntosGanadosE4;
                Session["puntosE5"] = puntosGanadosE5;
                Session["notaFinal"] = notaFinal;

                Response.Redirect("notas.aspx");
            } 
            catch
            {
                
            }
        }
    }
}