using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Pedidos
{
    public class Cliente
    {
        public int IdCliente { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string Sexo { get; set; }
        public DateTime Fecha_Nacimiento { get; set; }
        public string Tipo_Documento { get; set; }
        public string Num_Documento { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }

        public void Insertar()
        {
            try
            {
                SqlConnection cnx = Conexion.Conectar();
                SqlCommand comando = new SqlCommand();
                cnx.Open();
                comando.Connection = cnx;
                comando.CommandText = "Sp_Insertar_Cliente";
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@Nombre", this.Nombre);
                comando.Parameters.AddWithValue("@Apellidos", this.Apellidos);
                comando.Parameters.AddWithValue("@Sexo", this.Sexo);
                comando.Parameters.AddWithValue("@Fecha_Nacimiento", this.Fecha_Nacimiento);
                comando.Parameters.AddWithValue("@Tipo_Documento", this.Tipo_Documento);
                comando.Parameters.AddWithValue("@Direccion", this.Direccion);
                comando.Parameters.AddWithValue("@Telefono", this.Telefono);
                comando.Parameters.AddWithValue("@Email", this.Email);
                comando.Parameters.AddWithValue("@Num_Documento", this.Num_Documento);
                comando.ExecuteNonQuery();
                cnx.Close();
            }
            catch (Exception)
            {

                throw;
            }
        }
        public void Actualizar()
        {
            try
            {
                SqlConnection cnx = Conexion.Conectar();
                SqlCommand comando = new SqlCommand();
                cnx.Open();
                comando.Connection = cnx;
                comando.CommandText = "Sp_Actualizar_Cliente";
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@IdCliente", this.IdCliente);
                comando.Parameters.AddWithValue("@Nombre", this.Nombre);
                comando.Parameters.AddWithValue("@Apellidos", this.Apellidos);
                comando.Parameters.AddWithValue("@Sexo", this.Sexo);
                comando.Parameters.AddWithValue("@Fecha_Nacimiento", this.Fecha_Nacimiento);
                comando.Parameters.AddWithValue("@Tipo_Documento", this.Tipo_Documento);
                comando.Parameters.AddWithValue("@Direccion", this.Direccion);
                comando.Parameters.AddWithValue("@Telefono", this.Telefono);
                comando.Parameters.AddWithValue("@Email", this.Email);
                comando.Parameters.AddWithValue("@Num_Documento", this.Num_Documento);
                comando.ExecuteNonQuery();
                cnx.Close();
            }
            catch (Exception)
            {

                throw;
            }
        }
        public void Eliminar()
        {
            try
            {
                SqlConnection cnx = Conexion.Conectar();
                SqlCommand comando = new SqlCommand();
                cnx.Open();
                comando.Connection = cnx;
                comando.CommandText = "Sp_Eliminar_Cliente";
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@IdCliente", this.IdCliente);
                comando.ExecuteNonQuery();
                cnx.Close();
            }
            catch (Exception)
            {

                throw;
            }
        }
        public DataTable Listar()
        {
            try
            {
                SqlConnection cnx = Conexion.Conectar();
                SqlCommand comando = new SqlCommand();
                DataSet ds = new DataSet();
                cnx.Open();
                comando.Connection = cnx;
                comando.CommandText = "Sp_Listar_Cliente";
                comando.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter adaptador = new SqlDataAdapter(comando);
                adaptador.Fill(ds);
                cnx.Close();
                return ds.Tables[0];
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
