using System;

namespace Ejercicio_3.APP
{
    public partial class Ejercicio_3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string baseDatosEjer3 = "Ejercicio 3";
            string tablaEjer3 = "tabla1Ejercicio3";

            Conexion conexion = new Conexion();

            GridViewTabla1.DataSource = (conexion.ExecuteAndFillDT("SELECT * FROM " + tablaEjer3 + "", baseDatosEjer3));
            GridViewTabla1.DataBind();

            lblTabla1.Text = "Base de datos: " + baseDatosEjer3 + ", tabla: " + tablaEjer3;
        }

        protected void btnGuardarTabla_Click(object sender, EventArgs e)
        {
            string baseDatosEjer3 = "Ejercicio 3";

            string baseDatosEjer1 = "Ejercicio 1";
            string tablaEjer1 = "tabla1Ejercicio1";

            Conexion conexion = new Conexion();

            conexion.Execute("INSERT INTO [Ejercicio 1].dbo.tabla1Ejercicio1 (Nombre, Apellido, Edad)"+
                " SELECT Nombre, Apellido, Edad FROM[Ejercicio 3].dbo.tabla1Ejercicio3", baseDatosEjer3);

            GridViewTabla2.DataSource = (conexion.ExecuteAndFillDT("SELECT * FROM " + tablaEjer1 + "", baseDatosEjer1));
            GridViewTabla2.DataBind();

            lblTabla2.Text = "Base de datos: " + baseDatosEjer1 + ", tabla: " + tablaEjer1;

        }
    }
}