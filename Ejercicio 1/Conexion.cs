using System.Data;
using System.Data.SqlClient;

namespace Ejercicio_1
{
    public class Conexion
    {
        string connectionString = @"Data Source=LAPTOP-JQD2SI9A\SQLEXPRESS;Initial Catalog=Ejercicio 1;Integrated Security=True";

        public void Execute(string comando)
        {
            using (SqlConnection cnn = new SqlConnection(connectionString))
            {
                cnn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = comando;
                cmd.CommandType = CommandType.Text;
                cmd.Connection = cnn;

                
                int i = cmd.ExecuteNonQuery();
            }
        }
    }
}