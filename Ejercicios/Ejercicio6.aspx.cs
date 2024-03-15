using System;
using System.Collections.Generic;
using System.EnterpriseServices.CompensatingResourceManager;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Ejercicios
{
    public partial class Ejercicio6 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            CrearTabla();
        }

        protected void generar_tabla_multiplicacion_Click(object sender, EventArgs e)
        {
            ImageButton btn = (ImageButton)sender;
            int numero = Convert.ToInt32(btn.AlternateText);
            string tabla = "";

            for (int i = 1; i <= 10; i++)
            {
                tabla += $"{numero} x {i} = {numero * i}<br />";
            }
            lbl_tablaSeleccionada.Text = tabla;
        }

        public void CrearTabla()
        {
            TableRow tRow = null;

            for (int i = 1; i <= 9; i++)
            {
                TableCell tCell = new TableCell
                {
                    ID = "tcell" + i,
                };

                ImageButton imgBtn = new ImageButton
                {
                    ImageUrl = "Content/Images/numero_" + i + ".png",
                    CssClass = "numeroImg",
                    AlternateText = i.ToString()
                };

                imgBtn.Click += generar_tabla_multiplicacion_Click;

                tCell.Controls.Add(imgBtn);

                if (i % 3 == 1)
                {
                    tRow = new TableRow()
                    {
                        ID = "tRow" + (i / 3)
                    };

                    CrearTablaDinamica.Rows.Add(tRow);
                }

                tRow.Controls.Add(tCell);
            }
        }
    }
}