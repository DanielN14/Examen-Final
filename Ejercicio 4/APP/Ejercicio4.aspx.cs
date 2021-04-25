using System;

namespace Ejercicio_4.APP
{
    public partial class Ejercicio4 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCambioBaseDatos_Click(object sender, EventArgs e)
        {
            string baseDatos = selectBaseDatos.Value;
            string tabla = "";

            if (baseDatos.Equals("Reservar"))
            {
                tabla = "Destino";
            }
            else if (baseDatos.Equals("Libreria"))
            {
                tabla = "Libro";
            }

            Conexion conexion = new Conexion();

            GridView.DataSource = (conexion.ExecuteAndFillDT("SELECT * FROM " + tabla + "", baseDatos));
            GridView.DataBind();
        }
    }
}