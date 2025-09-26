using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaAdoNetEMpleados
{
    internal class RepoSecretarias
    {
        private string cadenaConexion = "Integrated Security=True;Persist Security Info=False;Pooling=False;Encrypt=False";
        private List<Secretaria> listaSecretarias;

        public RepoSecretarias()
        {
            listaSecretarias = new List<Secretaria>();
        }

        public IReadOnlyCollection<Secretaria> ListarSecretarias() //listo las secretarias
        {
            using (SqlConnection conexion = new SqlConnection(cadenaConexion))
            {
                conexion.Open();
                string consulta = "SELECT idSecretaria, Nombre, Nacionalidad, AñoNacimiento FROM Secretaria";

                using (SqlCommand comando = new SqlCommand(consulta, conexion))
                {
                    using (SqlDataReader lector = comando.ExecuteReader())
                    {
                        listaSecretarias.Clear();
                        while (lector.Read())
                        {
                            Secretaria secretaria = new Secretaria();
                            secretaria.IdSecretaria = lector.GetInt32(0);
                            secretaria.Nombre = lector.GetString(1);
                            secretaria.Nacionalidad = lector.GetString(2);
                            secretaria.AñoNacimiento = lector.GetInt32(3);
                            listaSecretarias.Add(secretaria);
                        }
                    }
                }
            }
            return listaSecretarias.AsReadOnly();
        }

        public void AgregarSecretaria(Secretaria secretaria)
        {
            using (SqlConnection conexion = new SqlConnection(cadenaConexion))
            {
                conexion.Open();
                string consulta = "INSERT INTO Secretaria (Nombre, Nacionalidad, AñoNacimiento) Values (@nombre, @nacionalidad, @añoNacimiento)";
                using (SqlCommand comando = new SqlCommand(consulta, conexion))
                {
                    comando.Parameters.AddWithValue("@nombre", secretaria.Nombre);
                    comando.Parameters.AddWithValue("@nacionalidad", secretaria.Nacionalidad);
                    comando.Parameters.AddWithValue("@añoNacimiento", secretaria.AñoNacimiento);
                    comando.ExecuteNonQuery();
                }
            }
        }

        public void ModificarSecretaria(Secretaria secretaria)
        {
            using (SqlConnection conexion = new SqlConnection(cadenaConexion))
            {
                conexion.Open();
                string consulta = "UPDATE Secretaria SET Nombre = @nombre, Nacionalidad = @nacionalidad, AñoNacimiento = @añoNacimiento";
                using (SqlCommand comando = new SqlCommand(consulta, conexion))
                {
                    comando.Parameters.AddWithValue("@nombre", secretaria.Nombre);
                    comando.Parameters.AddWithValue("@nacionalidad", secretaria.Nacionalidad);
                    comando.Parameters.AddWithValue("@añoNacimiento", secretaria.AñoNacimiento);
                    comando.ExecuteNonQuery();
                }
            }
        }

        public void EliminarSecretaria(int IdSecretaria)
        {
            using (SqlConnection conexion = new SqlConnection(cadenaConexion))
            {
                conexion.Open();
                string consulta = "DELETE FROM Secretaria WHERE idSecreria = @idSecretaria";
                using (SqlCommand comando = new SqlCommand(consulta, conexion))
                {
                    comando.Parameters.AddWithValue("@idSecretaria", IdSecretaria);
                    comando.ExecuteNonQuery();
                }
            }
        }
    }
}
