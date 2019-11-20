using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace TrabalhoBD.DAL
{
    public class ClienteDAL
    {
        string connectionString = "";

        public ClienteDAL()
        {
            connectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
        }

        [DataObjectMethod(DataObjectMethodType.Select)]
        public List<Modelo.Cliente> SelectAll()
        {
            Modelo.Cliente aCliente;
            List<Modelo.Cliente> aListClientes = new List<Modelo.Cliente>();
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "EXEC dbo.SelectALL_Cliente";
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    aCliente = new Modelo.Cliente(
                       Convert.ToInt32(dr["id"].ToString()),
                       dr["nome"].ToString(),
                       Convert.ToDateTime(dr["data_nascimento"].ToString()),
                       dr["cpf"].ToString()
                       );
                    aListClientes.Add(aCliente);
                }
            }
            dr.Close();
            conn.Close();
            return aListClientes;
        }

        [DataObjectMethod(DataObjectMethodType.Delete)]
        public void Delete(int id)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand com = conn.CreateCommand();
            SqlCommand cmd = new SqlCommand("EXEC dbo.Delete_Cliente @id", conn);
            cmd.Parameters.AddWithValue("@id", id);

            cmd.ExecuteNonQuery();

        }
    }
}