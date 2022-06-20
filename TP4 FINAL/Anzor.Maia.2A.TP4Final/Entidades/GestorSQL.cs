using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class GestorSQL
    {
        public static string cadenaConexion;

        /// <summary>
        /// metodo que se conecta a la base de datos y server donde se encuentran los datos
        /// </summary>
        static GestorSQL()
        {
            GestorSQL.cadenaConexion = "Server = . ; Database = Delivery_Comida_Asiatica; Trusted_Connection = True;";
        }

        /// <summary>
        /// lee los datos que haya en la base de datos
        /// </summary>
        /// <returns></returns>
        public static List<Repartidores> LeerRepartidores()
        {
            List<Repartidores> listaRepartidores = new List<Repartidores>();

            string query = "SELECT * FROM Repartidores";

            //instancia coneccion
            using (SqlConnection connection = new SqlConnection(GestorSQL.cadenaConexion))
            {
                SqlCommand cmd = new SqlCommand(query, connection);
                connection.Open(); //abro coneccion

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    int idRepartidor = reader.GetInt32(0);
                    string nombre = reader.GetString(1);
                    string apellido = reader.GetString(2);
                    string sexo = reader.GetString(3);
                    string numeroContacto = reader.GetString(4);
                    string estadoRepartidor = reader.GetString(5);


                    Repartidores repartidor = new Repartidores(idRepartidor, nombre, apellido, sexo, numeroContacto, estadoRepartidor);
                    listaRepartidores.Add(repartidor);
                   
                }
            }
            return listaRepartidores;
        }

    

        /// <summary>
        /// agrgea repartidores a la base de datos
        /// </summary>
        /// <param name="repartidor"></param>
        public static void AgregarRepartidor(this Repartidores repartidor)
        {
            string query = "INSERT INTO Repartidores (NOMBRE, APELLIDO, SEXO, NUMERO_DE_CONTACTO, ESTADO_REPARTIDOR) VALUES (@NOMBRE, @APELLIDO, @SEXO, @NUMERO_DE_CONTACTO, @ESTADO_REPARTIDOR)";

            SqlConnection connection = null;

            try
            {
                connection = new SqlConnection(GestorSQL.cadenaConexion);
                connection.Open();
                SqlCommand cmd = new SqlCommand(query, connection);

                cmd.Parameters.AddWithValue("NOMBRE", repartidor.Nombre);
                cmd.Parameters.AddWithValue("APELLIDO", repartidor.Apellido);
                cmd.Parameters.AddWithValue("SEXO", repartidor.Sexo);
                cmd.Parameters.AddWithValue("NUMERO_DE_CONTACTO", repartidor.NumeroContacto);
                cmd.Parameters.AddWithValue("ESTADO_REPARTIDOR", repartidor.EstadoEmplado);
                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                if (connection != null && connection.State == System.Data.ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }

    }
}
