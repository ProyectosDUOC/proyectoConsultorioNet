using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace consultorioWeb.Medico
{
    public partial class RecetaMedica : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void GridView1_SelectedIndexChanging(object sender, GridViewSelectEventArgs e)
        {
            bntRevisar.Enabled = true;
            lblResultado.Text = " Ficha Paciente:" + GridView1.SelectedRow.Cells[1].Text + " Rut: " + GridView1.SelectedRow.Cells[3].Text + " Nombre: " + GridView1.SelectedRow.Cells[4].Text;
            idFicha = Convert.ToInt32(GridView1.SelectedRow.Cells[1].Text);
        }

        protected void paginacion(object sender, GridViewPageEventArgs e)
        {

            GridView1.PageIndex = e.NewPageIndex;
            GridView1.DataSource = capaNegocio.ClasesListar.FichaLColeccion.generarListado();
            GridView1.DataBind();
        }
    }
}