using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Biblioteca.Control;

namespace Consultorio.Admin
{
    public partial class PanelSector : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Sector sect = new Sector();

            sect.Id = Convert.ToInt32(txtID.Text);
            sect.Nombre = txtNombre.Text;
            L1.Text = sect.AgregarSector();
        }
    }
}