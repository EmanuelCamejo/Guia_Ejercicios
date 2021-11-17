using System;
using System.Data.SqlClient;

namespace Persona
{
    public class PersonaDAO
    {
        SqlConnection connection; // Puente.
        SqlCommand command;      // Quien lleva la consulta.
        SqlDataReader reader;   // Quien trae los datos.

        static ConexionSql()
        {
            connection = new SqlConnection(@"Data Source = [Nombre del servidor];
                                Database = [Nombre de la base de datos];
                                Trusted_Connection = True;");

            command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.Connection = connection;
        }

        public static void Guardar()
        {

        }

        public static void Leer()
        {
            
        }

        public static void LeerPorID()
        {
            
        }

        public static void Modificar()
        {
            
        }
        
        public static void Borrar()
        {
            
        }
    }
}
