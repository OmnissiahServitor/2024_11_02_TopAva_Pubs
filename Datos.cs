using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace _2024_11_02_TopAva_Pubs
{
    class Datos
    {
        SqlConnection connection;

        String cadenaConexion = @"Data Source = DESKTOP-6605P8O\SQLEXPRESS; Integrated Security = true; initial catalog = pubs";

        public SqlConnection abrirConexion()
        {
            try
            {
                connection = new SqlConnection(cadenaConexion);
                connection.Open();

                return connection;
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString(), "Error Conectar BD", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        } // end abrirConexion()

        public void cerrarConexion()
        {
            try
            {
                connection.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString(), "Error Cerrar BD", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        } // end cerrarConexion()

        public bool ejecutarABC(String comando) // altas, bajas y cambios
        {
            try
            {
                SqlCommand command = new SqlCommand(comando, abrirConexion());
                command.ExecuteNonQuery();
                cerrarConexion();
                return true;
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString(), "Error Comando Sql", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        } // end ejecutarABC()

        public DataSet consulta(String comando)
        {
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(comando, abrirConexion());
            try
            {
                
                da.Fill(ds);
                cerrarConexion();
                return ds;
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString(), "Error Consulta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
                return null;
            }
        } // end consulta()
    } // end class Datos
} // end namespace
