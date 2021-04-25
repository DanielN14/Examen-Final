using System;

namespace Ejercicio_1.APP
{
    public partial class Ejercicio_1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblMensaje.Text = "";
            lblError.Text = "";
        }

        protected void btnCrearTabla_Click(object sender, EventArgs e)
        {
            tablasColumnas tablaColumna = new tablasColumnas();
            try
            {
                tablaColumna.CrearTablas(txtNombreTabla.Value);
                lblMensaje.Text = "Tabla: " + txtNombreTabla.Value + " creada correctamente";
            }
            catch (Exception ex)
            {
                lblError.Text = "Error:" + ex.Message;
            }
        }

        protected void btnAgregarColumna_Click(object sender, EventArgs e)
        {
            tablasColumnas tablaColumna = new tablasColumnas();
            try
            {
                tablaColumna.CrearColumnas(txtNombreTabla.Value, txtColumna.Value);
                lblMensaje.Text = "Columna: " + txtColumna.Value + " creada correctamente";
            }
            catch (Exception ex)
            {
                lblError.Text = "Error:" + ex.Message;
            }
        }
    }
}