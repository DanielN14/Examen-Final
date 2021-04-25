using System;
using System.Data.SqlClient;

namespace Ejercicio_2.APP
{
    public partial class Ejercicio_2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblRespuesta.Text = "";
            lblError.Text = "";
        }
        protected void btnEjecutar_Click(object sender, EventArgs e)
        {
            try
            {
                Conexion conexion = new Conexion();
                conexion.Execute(txtcomando.Value);
                lblRespuesta.Text = "Comando escrito correctamente";
            }
            catch (SqlException se)
            {
                lblError.Text = "Incorrecto: " + se.Message;
            }
        }
    }
}