using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using capaNegocio;

namespace consultorioWeb.Medico
{
    public partial class RecetaMedica : System.Web.UI.Page
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

            if (!IsPostBack)
            {
                if (Request.Params["id"] != null)
                {
                    int id = Convert.ToInt32(Request.Params["id"]);
                    controlAcceso.Activo = id;
                    capaNegocio.FichaPaciente ficha = new capaNegocio.FichaPaciente();

                    GridView1.DataSource = capaNegocio.MedicamentosColeccion.ReadAll();
                    GridView1.DataBind();

                    ficha.Id_ficha_paciente = id;
                    ficha.Read();
                    lblID.Text = id.ToString();
                    capaNegocio.Paciente pac = new capaNegocio.Paciente();
                    pac.Id = ficha.IdPaciente;
                    pac.Read();
                    capaNegocio.Usuario usuario = new capaNegocio.Usuario();
                    usuario.Id = pac.IdUsuario;
                    usuario.Read();
                    lblNombre.Text = usuario.Pnombre + " " + usuario.Snombre + " " + usuario.Appaterno + " " + usuario.Apmaterno;
                    lblRut.Text = usuario.Rut + "-" + usuario.Dv;
                    panel.Enabled = false;
                    btnAgregar.Enabled = false;

                }
                else {

                    Response.Redirect("../Login.aspx");
                }
                
            }


            if (controlAcceso.Id == 0)
            {
                Response.Redirect("../Login.aspx");
            }          
        }

        protected void paginacion(object sender, GridViewPageEventArgs e)
        {

            GridView1.PageIndex = e.NewPageIndex;
            GridView1.DataSource = capaNegocio.ClasesListar.FichaLColeccion.generarListado();
            GridView1.DataBind();
        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                capaNegocio.Clases.RecetaMedica receta = new capaNegocio.Clases.RecetaMedica();
                
                int id = Convert.ToInt32(Request.Params["id"]);
                receta.IdFicha = id;
                receta.Cant = Convert.ToInt32(txtCantidad.Text);
                receta.Dia = Convert.ToInt32(txtDias.Text);
                receta.Hora = Convert.ToInt32(txtHoras.Text);
                receta.Glosa = txtGlosa.Text;
                receta.IdReceta = capaNegocio.Control.Contadores.contadorIdReceta() + 1;
                receta.IdMedicamento = Convert.ToInt32(GridView1.SelectedRow.Cells[1].Text);
                lblMensaje.Text = "";
                if (receta.Create())
                {
                    lblMensaje.Text = "Creado";
                }
                else {

                    lblMensaje.Text = "No se creo";
                }
            }
            catch (Exception ex)
            {

                lblMensaje.Text = ex.Message;
            }
           
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

            int id = Convert.ToInt32(lblID.Text);
            List<capaNegocio.Clases.RecetaMedica> listar = new List<capaNegocio.Clases.RecetaMedica>();
            listar = capaNegocio.Clases.RecetaListar.generarReceta(id);
            bool estado = false;
            int idMe = Convert.ToInt32(GridView1.SelectedRow.Cells[1].Text);
            foreach (capaNegocio.Clases.RecetaMedica item in listar)
            {
                if (item.IdMedicamento == idMe)
                {
                    estado = true;
                    break;
                }
            }
            if (estado)
            {
                lblMensaje.Text = "Medicamento ya fue utilizado";
                panel.Enabled = false;
                lblMedicamento.Text = "";
            }
            else {
                panel.Enabled = true;
                lblMedicamento.Text = GridView1.SelectedRow.Cells[2].Text;
                lblMensaje.Text = "";
            }


       }

    
        protected void btnCalculate_Click(object sender, EventArgs e)
        {
            int cant = Convert.ToInt32(txtCantidad.Text);
            int dias = Convert.ToInt32(txtDias.Text);
            int horas = Convert.ToInt32(txtHoras.Text);
            double resultado = (dias * 24);
            resultado = (resultado / (horas * 1.0));
            resultado = resultado * cant;
            txtGlosa.Text = resultado.ToString();
            btnAgregar.Enabled = true;
            panel.Enabled = true;
        }

        protected void btnVolver_Click(object sender, EventArgs e)
        {
            Response.Redirect("FichaPaciente.aspx?id=" + lblID.Text);
                      
        }

      
    }
}