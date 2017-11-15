﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Consultorio.Secretaria
{
    public partial class MenuSecretaria : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("/Secretaria/BuscarDoctor.aspx");

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("/Secretaria/PanelConsultaS.aspx");
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Response.Redirect("/Secretaria/AgendarHora.aspx");
        }

        protected void Button7_Click(object sender, EventArgs e)
        {

            Response.Redirect("/Login.aspx");
        }
    }
}