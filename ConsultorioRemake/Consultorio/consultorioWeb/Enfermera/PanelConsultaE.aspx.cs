using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using capaNegocio;

namespace consultorioWeb.Enfermera
{
    public partial class PanelConsultaE : System.Web.UI.Page
    {
        private int idFicha = 0;

        private ControlAcceso controlAcceso
        {
            get
            {
                if (Session["MiUsuario"] == null)
                {
                    Session["MiUsuario"] = new ControlAcceso();
                }
                return (ControlAcceso)Session["MiUsuario"];
            }
            set { Session["MiUsuario"] = value; }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            bntRevisar.Enabled = false;
            lblFecha.Text = DateTime.Now.ToString();
            Usuario usuario = new Usuario();
            usuario.Id = controlAcceso.IdUsuario;
            usuario.Read();
            lblNombre.Text = usuario.Pnombre + " " + usuario.Snombre + " " + usuario.Appaterno + " " + usuario.Apmaterno;
            lblRut.Text = usuario.Rut.ToString();

            if (!IsPostBack)
            {
                GridView1.DataSource = capaNegocio.ClasesListar.FichaLColeccion.generarListado();
                GridView1.DataBind();

                if (controlAcceso.Id==0)
                {
                    Response.Redirect("/Login.aspx");
                }
            }
        }
       

        protected void seleccion(object sender, EventArgs e)
        {
            bntRevisar.Enabled = true;

        }

        protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GridView1.PageIndex = e.NewPageIndex;
            GridView1.DataSource = capaNegocio.ClasesListar.FichaLColeccion.generarListado();
            GridView1.DataBind();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            controlAcceso = new ControlAcceso();
            Response.Redirect("/Login.aspx");
        }

        protected void bntRevisar_Click(object sender, EventArgs e)
        {
            Response.Redirect("/Login.aspx");
        }
    }
}