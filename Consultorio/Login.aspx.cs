using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ConsultorioBD;
using System.Data.SqlClient;
using System.Data;

namespace Consultorio
{
    public partial class Login : System.Web.UI.Page
    {
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

            string conStr = "Data Source=SEBA-NB\\SQLEXPRESS;Initial Catalog=Empresas;Integrated Security=true";
            ConsultorioConnection empCon = new ConsultorioConnection(conStr);
            SqlConnection sqlCon = empCon.getConnection();
            SqlCommand sqlComd = sqlCon.CreateCommand();
            sqlComd.CommandType = CommandType.Text;
            sqlComd.CommandText = "select * from empleado";
            SqlDataAdapter adapter = new SqlDataAdapter(sqlComd);
            DataSet dSet = new DataSet();
            adapter.Fill(dSet);
            //gvEmpleados.DataSource = dSet;
            DataBind();
        }
    }
}