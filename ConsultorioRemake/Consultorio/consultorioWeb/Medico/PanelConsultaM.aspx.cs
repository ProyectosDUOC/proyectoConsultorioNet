using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using capaNegocio;

namespace consultorioWeb.Medico
{
    public partial class PanelConsultaM : System.Web.UI.Page
    {
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

            btnFicha.Enabled = false;
            lblFecha.Text = DateTime.Now.ToString();
            Usuario usuario = new Usuario();
            usuario.Id = controlAcceso.IdUsuario;
            usuario.Read();
            lblNombre.Text = usuario.Pnombre + " " + usuario.Snombre + " " + usuario.Appaterno + " " + usuario.Apmaterno;
            lblRut.Text = usuario.Rut.ToString();
            lblResultado.Text = "";
            lblError.Text = "";

            if (!IsPostBack)
            {
                GridView1.DataSource = capaNegocio.ClasesListar.FichaLColeccion.generarListado();
                GridView1.DataBind();               
            }

            if (controlAcceso.Id==0)
            {
                Response.Redirect("/Login.aspx");
            }

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            controlAcceso = new ControlAcceso();
            Response.Redirect("/Login.aspx");
        }  

        protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GridView1.PageIndex = e.NewPageIndex;
            GridView1.DataSource = capaNegocio.ClasesListar.FichaLColeccion.generarListado();
            GridView1.DataBind();
        }

        protected void Seleccionar(object sender, EventArgs e)
        {
            btnFicha.Enabled = true;
            String id = GridView1.SelectedRow.Cells[1].Text;
            capaNegocio.FichaPaciente ficha = new capaNegocio.FichaPaciente();
            ficha.Id_ficha_paciente = Convert.ToInt32(id);
            ficha.Read();
            if (ficha.IdEnfermera == 0)
            {
                lblError.Text = "Falta Atencion de la Enfermera" + ficha.IdEnfermera + " : "+ ficha.Id_ficha_paciente +"  "+ ficha.Estatura ;
                btnFicha.Enabled = false;
            }
            else
            {
                lblResultado.Text = " Ficha Paciente:" + GridView1.SelectedRow.Cells[1].Text + " Rut: " + GridView1.SelectedRow.Cells[3].Text + " Nombre: " + GridView1.SelectedRow.Cells[4].Text;
                lblError.Text = "";
                btnFicha.Enabled = true; 
            }
           
        }


        protected void btnFicha_Click(object sender, EventArgs e)
        {
            String id = GridView1.SelectedRow.Cells[1].Text;
            capaNegocio.FichaPaciente ficha = new capaNegocio.FichaPaciente();
            ficha.Id_ficha_paciente = Convert.ToInt32(id);
            ficha.Read();
            if (ficha.IdEnfermera == 0)
            {
                lblError.Text = "Falta Atencion de la Enfermera";
                lblResultado.Text = "";
                btnFicha.Enabled = false;
            }
            else
            {
                Response.Redirect("FichaPaciente.aspx?id=" + id);
            }
        }
    }
}