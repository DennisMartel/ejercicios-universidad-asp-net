using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Ejercicios
{
    public partial class Ejercicio7 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            CreateTable();
        }

        public void CreateTable()
        {
            TableRow tRow = null;

            for (int i = 1; i <= 100; i++)
            {
                TableCell tCell = new TableCell()
                {
                    ID = "tCell" + i
                };

                Button btn = new Button
                {
                    ID = "btn-" + i,
                    Text = i.ToString(),
                    CssClass = "btnTablaMultiplicar",
                };

                btn.Click += btn_tabla_selecionada_Click;

                tCell.Controls.Add(btn);

                if (i % 20 == 1)
                {
                    tRow = new TableRow()
                    { 
                        ID = "tRow" + (i / 20)
                    };

                    CrearTabla.Rows.Add(tRow);
                }

                tRow.Cells.Add(tCell);
            }
        }

        protected void btn_tabla_selecionada_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            int numero = Convert.ToInt32(btn.Text);
            string tabla = "";

            for (int i = 1; i <= 10; i++)
            {
                tabla += $"{numero} x {i} = {numero * i}<br />";
            }
            lbl_tablaSeleccionada.Text = tabla;
        }
    }
}