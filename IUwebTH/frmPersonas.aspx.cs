using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace IUwebTH
{
    public partial class frmPersonas : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnMostrar_Click(object sender, EventArgs e)
        {
            this.GriedViewPersonas.DataSource = BibliotecaDatos.Persona.getDatos();
            this.GriedViewPersonas.DataBind();
        }
    }
}