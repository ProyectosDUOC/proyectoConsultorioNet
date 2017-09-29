using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ConsultorioBD;
using System.Data.SqlClient;
using System.Data;
using Biblioteca.Control;
using Biblioteca.Clases;

namespace Consultorio
{
    public partial class Login : System.Web.UI.Page
    {
         private ControlAcceso MiUsuario {
            get {
                if (Session["MiUsuario"] == null) {
                    Session["MiUsuario"] = new ControlAcceso();
                }
                return (ControlAcceso)Session["MiUsuario"];
            }
            set { Session["MiUsuario"] = value; }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void btnIngresar_Click(object sender, EventArgs e)
        {           
            string user = Request.Form["txtUsuario"];
            string pass = Request.Form["txtPass"];

            if (user != null)
            {
                if (user.ToLower().Equals("secretaria"))
                {
                    Response.Redirect("/Secretaria/MenuSecretaria.aspx");
                }
                if (user.ToLower().Equals("medico"))
                {
                    Response.Redirect("/Medico/PanelConsultaM.aspx");
                }
                if (user.ToLower().Equals("enfermera"))
                {
                    Response.Redirect("/Enfermera/PanelConsultaE.aspx");
                }
                if (user.ToLower().Equals("administrador"))
                {
                    Response.Redirect("/Admin/Administrador.aspx");
                }

            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            ConsultorioConnection consultorioCon = new ConsultorioConnection();
            SqlConnection sqlCon = consultorioCon.getConnection();
            SqlCommand sqlCmd = sqlCon.CreateCommand();
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.CommandText = "select * from Control_Acceso ca JOIN Tipo_Usuario tu on (ca.id_tipo_usuario = tu.id_tipo_usuario)" ;
            SqlDataAdapter adapter = new SqlDataAdapter(sqlCmd);
            DataSet data = new DataSet();
            adapter.Fill(data);
            gvTest.DataSource = data;
            DataBind();
        }
    }
}