using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient; //meto la libreria para poder usar sql
using System.Collections.Concurrent; //meto la libreria para poder usar collections 

namespace PruebaAdoNetEMpleados
{
    public class RepoEmpleados
    {
        //Meto td el texto del sql borrando los dos ultimos parametros y el penultimo en una variable para no tener que meterlo cada vez que abro una coneccion al server
        private string cadenaConexion = "Data Source=NOTEBOOK_LU\\SQLEXPRESS;Initial Catalog=Pureba1Empleados;Integrated Security=True;Persist Security Info=False;Pooling=False;Encrypt=False";
        private List<Empleado> listaEmpleados;

        public RepoEmpleados()
        {
            listaEmpleados = new List<Empleado>();
        }

        public IReadOnlyCollection<Empleado> ListarEmpleados() //creo una funcion para listar los objetos con el IReadOnlyCollection para mas seguridad, esto limita mi pc a solo leer la lista, no modificarla
        {
            using (SqlConnection conexion = new SqlConnection(cadenaConexion)) //creo una conexion dandole nombre y asignandole la variable con todos los datos del server
            {
                conexion.Open();
                string consulta = "Select IdEmpleado, Nombre, Apellido, Dni FROM Empleado"; //creo una variable consulta con los datos que le quiero pedir a mi lista del server
                //el select vasicamente es un leer y el from dice de que tabla

                using (SqlCommand comando = new SqlCommand(consulta, conexion)) //creo un comando dandole la variable consulta y la conexion
                {
                    using (SqlDataReader lector = comando.ExecuteReader()) //creo un lector que ejecuta el comando
                    {
                        listaEmpleados.Clear();
                        while (lector.Read()) //mientras el lector lea (osea una iteracion)
                        {
                            Empleado empleado = new Empleado(); //creo un objeto empleado
                            empleado.IdEmpleado = lector.GetInt32(0); //el 0 es la posicion del dato que quiero leer, en este caso el idEmpleado
                            empleado.Nombre = lector.GetString(1); //el 1 es la posicion del dato que quiero leer, en este caso el Nombre
                            empleado.Apellido = lector.GetString(2); //el 2 es la posicion del dato que quiero leer, en este caso el Apellido
                            empleado.Dni = lector.GetInt32(3).ToString(); //el 3 es la posicion del dato que quiero leer, en este caso el Dni
                            listaEmpleados.Add(empleado); //agrego a la lista de empleados el objeto empleado que acabo de crear y llenar con datos
                        }
                    }
                }

            }
            return listaEmpleados.AsReadOnly(); //devuelvo la lista de empleados como una lista de solo lectura
        }

        public void AgregarEmpleado(Empleado empleado) //creo una funcion para agregar empleados
        {
            using (SqlConnection conexion = new SqlConnection(cadenaConexion)) //creo una conexion dandole nombre y asignandole la variable con todos los datos del server
            {
                conexion.Open();
                string consulta = "INSERT INTO Empleado (Nombre, Apellido, Dni) VALUES (@nombre, @apellido, @dni)"; //creo una variable consulta con los datos que le quiero pedir a mi lista del server
                //el insert into es un agregar y el values son los valores que le quiero agregar
                using (SqlCommand comando = new SqlCommand(consulta, conexion)) //creo un comando dandole la variable consulta y la conexion
                {
                    comando.Parameters.AddWithValue("@nombre", empleado.Nombre); //agrego el parametro nombre con el valor del objeto empleado que me pasan por parametro
                    comando.Parameters.AddWithValue("@apellido", empleado.Apellido); //agrego el parametro apellido con el valor del objeto empleado que me pasan por parametro
                    comando.Parameters.AddWithValue("@dni", empleado.Dni); //agrego el parametro dni con el valor del objeto empleado que me pasan por parametro
                    comando.ExecuteNonQuery(); //ejecuto el comando(el nonquery es porque no espero ningun resultado, solo ejecuto) es como el void del sql
                }
            }
        }

        public void EliminarEmpleado(int idEmpleado)
        {
            using (SqlConnection conexion = new SqlConnection(cadenaConexion))
            {
                conexion.Open();
                string consulta = "DELETE FROM Empleado WHERE IdEmpleado = @idEmpleado"; //creo una variable consulta con los datos que le quiero pedir a mi lista del server
                using (SqlCommand comando = new SqlCommand(consulta, conexion)) //creo un comando dandole la variable consulta y la conexion
                {
                    comando.Parameters.AddWithValue("@idEmpleado", idEmpleado); //agrego el parametro idEmpleado con el valor que me pasan por parametro
                    comando.ExecuteNonQuery(); //ejecuto el comando(el nonquery es porque no espero ningun resultado, solo ejecuto) es como el void del sql
                }
            }
        }

        public void ModificarEmpleado(Empleado empleado)
        {
            using (SqlConnection conexion = new SqlConnection(cadenaConexion)) //creo una conexion dandole nombre y asignandole la variable con todos los datos del server
            {
                conexion.Open(); //abro la conexion
                string consulta = "UPDATE Empleado SET Nombre=@nombre, Apellido=@apellido, Dni=@dni WHERE IdEmpleado=@idEmpleado"; //creo una variable consulta con los datos que le quiero pedir a mi lista del server
                using (SqlCommand comando = new SqlCommand(consulta, conexion)) // creo un comando dandole la variable consulta y la conexion
                {
                    comando.Parameters.AddWithValue("@idEmpleado", empleado.IdEmpleado);//agrego el parametro idEmpleado con el valor del objeto empleado que me pasan por parametro
                    comando.Parameters.AddWithValue("@nombre", empleado.Nombre);//agrego el parametro nombre con el valor del objeto empleado que me pasan por parametro
                    comando.Parameters.AddWithValue("@apellido", empleado.Apellido);//agrego el parametro apellido con el valor del objeto empleado que me pasan por parametro
                    comando.Parameters.AddWithValue("@dni", empleado.Dni);//agrego el parametro dni con el valor del objeto empleado que me pasan por parametro
                    comando.ExecuteNonQuery();//ejecuto el comando(el nonquery es porque no espero ningun resultado, solo ejecuto) es como el void del sql
                }
            }
        }

    }
}
