
namespace Ejercicio_1
{
    public class tablasColumnas
    {
        public void CrearTablas(string Nombre)
        {
            Conexion conexion = new Conexion();
            conexion.Execute("CREATE TABLE[Ejercicio 1].[dbo].[" + Nombre + "](Id INT IDENTITY)");   
        }

        public void CrearColumnas(string Nombre, string Columna)
        {
            Conexion conexion = new Conexion();
            conexion.Execute("ALTER TABLE " + Nombre + " ADD " + Columna + " varchar(50)");
        }
    }
}