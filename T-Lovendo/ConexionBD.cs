using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;


// TODO: CREAR DELETE

namespace T_Lovendo
{
    class ConexionBD
    {

        string cadenaConexion = "";

        public ConexionBD()
        {
            // Cadena de conexion de su servidor de BD Sql Server
            this.cadenaConexion = @"Data Source=(local);Initial Catalog=T-LOVENDO;User ID=t-lovendo;Password=t-lovendo"; // <----- coloca aqui tu cadena
        }

        // Metodo para traer datos desde la BD el cual pide como parametro la consulta como string.

        public DataTable traerDatosBD(string query)
        {
            try
            {
                // Genero el objeto de conexión con la base de datos, estableciendo su cadena de conexión.

                SqlConnection conn = new SqlConnection(this.cadenaConexion);

                // Utilizo el Objeto que interactuara con la base de datos y nos sirve para traer datos.
                // con la consulta y un objeto de conexión.

                SqlDataAdapter adaptador = new SqlDataAdapter(query, conn);

                // abro la conexión.

                conn.Open();

                // Genero el objeto datatable el cual puede manejar datos 

                DataTable miTabla = new DataTable();

                // ejecuto el metodo FILL el cual ejecuta la consulta y obtiene los datos, transfiriendose al objeto DataTable
                // el cual obtiene una "FOTO" del resultado de la consulta.

                adaptador.Fill(miTabla);

                // Cierro la conexión.

                conn.Close();

                // Devuelvo el objeto DataTable.

                return miTabla;
            }
            catch (Exception ex)
            {
                // en caso de algun fallo durante el proceso, lo controlo con el catch.

                MessageBox.Show("Ocurrio un error al conectar");

                return null;
            }
        }

        // Metodo de la clase que ejecuta cualquier inserción, actualización o eliminación en la BD.

        public bool manipularDatosBD(string query)
        {
            try
            {
                // Genero el objeto de conexión con la base de datos, estableciendo su cadena de conexión.
                Console.WriteLine(query);
                SqlConnection conn = new SqlConnection(this.cadenaConexion);

                // Utilizo el objeto SqlCommand para ejecutar la acción en la BD, pasandole como parametro
                // la sentencia SQL y la conexión.

                SqlCommand cmd = new SqlCommand(query, conn);

                // Abro la conexión.

                conn.Open();

                // Ejecuto la acción la cual devuelve el numero de filas afectadas.

                int num = cmd.ExecuteNonQuery();

                // cierro la conexión.

                conn.Close();

                // si el numero de filas es superior a 0, si afecto filas.

                if (num > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                // manejo del error

                MessageBox.Show("Ocurrio un error al ejecutar la instrucción");
                return false;
            }

        }



        public bool compruebaConexion()
        {
            try
            {
                // usando el objeto conexión, abro y cierro la conexión para comprobar.

                SqlConnection cnn = new SqlConnection(this.cadenaConexion);

                cnn.Open();
                cnn.Close();

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
