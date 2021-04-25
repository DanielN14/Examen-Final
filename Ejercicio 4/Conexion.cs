using System.Data;
using System.Data.SqlClient;


namespace Ejercicio_4
{
    public class Conexion
    {
        public string ArmarCadenaConexion(string baseDatos)
        {
            string connectionString = @"Data Source=LAPTOP-JQD2SI9A\SQLEXPRESS;Initial Catalog=" + baseDatos + ";Integrated Security=True";
            return connectionString;
        }

        public DataTable ExecuteAndFillDT(string comando,string baseDatos)
        {
            using (SqlConnection cnn = new SqlConnection(ArmarCadenaConexion(baseDatos)))
            {
                cnn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = comando;
                cmd.CommandType = CommandType.Text;
                cmd.Connection = cnn;

                cmd.ExecuteNonQuery();

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                return dt;
            }
        }
    }
}