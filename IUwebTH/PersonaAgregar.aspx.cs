using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace IUwebTH
{
    public partial class PersonaAgregar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {

            this.lblMensaje.Text = "";

            if(this.txtCedula.Text.Length == 0)
            {
                this.lblMensaje.Text = "Debes ingresar la cedula";
                this.txtCedula.Focus();
                return; 
            }

            if (this.txtApellidos.Text.Length == 0)
            {
                this.lblMensaje.Text = "Debes ingresar los apellidos";
                this.txtCedula.Focus();
                return;
            }
            try
            {

                int x = BibliotecaDatos.Persona.insertar(this.txtCedula.Text, this.txtApellidos.Text, this.txtNombres.Text, Convert.ToDateTime(this.txtFechNacimiento.Text), Convert.ToDouble(this.txtPeso.Text));
                if (x > 0)
                    this.lblMensaje.Text = "Registro agregado correctamente";
                else
                    this.lblMensaje.Text = "No se pudo agregar el registro";


            }catch(Exception ex)
            {
                this.lblMensaje.Text = ex.Message.ToString();
            }



        }
    }
}