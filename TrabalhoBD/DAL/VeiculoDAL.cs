using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.Configuration;
using System.Data.SqlClient;

namespace TrabalhoBD.DAL
{
    public class VeiculoDAL
    {
        string connectionString = "";

        public VeiculoDAL()
        {
            connectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
        }

        [DataObjectMethod(DataObjectMethodType.Select)]
        public List<Modelo.Veiculo> SelectAll()
        {
            Modelo.Veiculo aVeiculo;
            List<Modelo.Veiculo> aListVeiculos = new List<Modelo.Veiculo>();
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "EXEC dbo.SelectALL_Veiculo";
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    aVeiculo = new Modelo.Veiculo(
                       Convert.ToInt32(dr["id"].ToString()),
                       dr["fabricante"].ToString(),
                       dr["modelo"].ToString(),
                       Convert.ToInt32(dr["ano_fabricacao"].ToString()),
                       dr["placa"].ToString(),
                       dr["uf"].ToString()
                       );
                    aListVeiculos.Add(aVeiculo);
                }
            }
            dr.Close();
            conn.Close();
            return aListVeiculos;
        }

        [DataObjectMethod(DataObjectMethodType.Select)]
        public List<Modelo.Veiculo> Select(int id)
        {
            Modelo.Veiculo aVeiculo;
            List<Modelo.Veiculo> aListVeiculos = new List<Modelo.Veiculo>();
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "EXEC dbo.Select_Veiculo @id";
            cmd.Parameters.AddWithValue("@id", id);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    aVeiculo = new Modelo.Veiculo(
                        Convert.ToInt32(dr["id"].ToString()),
                        dr["fabricante"].ToString(),
                        dr["modelo"].ToString(),
                        Convert.ToInt32(dr["ano_fabricacao"].ToString()),
                        dr["placa"].ToString(),
                        dr["uf"].ToString()
                        );
                    aListVeiculos.Add(aVeiculo);
                }
            }
            dr.Close();
            conn.Close();
            return aListVeiculos;
        }

        [DataObjectMethod(DataObjectMethodType.Delete)]
        public void Delete(int id)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand com = conn.CreateCommand();
            SqlCommand cmd = new SqlCommand("EXEC dbo.Delete_Veiculo @id", conn);
            cmd.Parameters.AddWithValue("@id", id);

            cmd.ExecuteNonQuery();

        }

        [DataObjectMethod(DataObjectMethodType.Update)]
        public void Update(Modelo.Veiculo obj)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand com = conn.CreateCommand();
            SqlCommand cmd = new SqlCommand("EXEC dbo.Update_Veiculo @id, @fabricante, @modelo, @ano_fabricacao, @placa, @uf ", conn);
            cmd.Parameters.AddWithValue("@id", obj.id);
            cmd.Parameters.AddWithValue("@fabricante", obj.fabricante);
            cmd.Parameters.AddWithValue("@modelo", obj.modelo);
            cmd.Parameters.AddWithValue("@ano_fabricacao", obj.ano_fabricacao);
            cmd.Parameters.AddWithValue("@placa", obj.placa);
            cmd.Parameters.AddWithValue("@uf", obj.uf);

            // Executa Comando
            cmd.ExecuteNonQuery();
        }

        [DataObjectMethod(DataObjectMethodType.Insert)]
        public void Insert(Modelo.Veiculo obj)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand com = conn.CreateCommand();
            SqlCommand cmd = new SqlCommand("INSERT INTO Veiculo (fabricante, modelo, ano_fabricacao, placa, uf) VALUES(@fabricante, @modelo, @ano_fabricacao, @placa, @uf)", conn);
            cmd.Parameters.AddWithValue("@fabricante", obj.fabricante);
            cmd.Parameters.AddWithValue("@modelo", obj.modelo);
            cmd.Parameters.AddWithValue("@ano_fabricacao", obj.ano_fabricacao);
            cmd.Parameters.AddWithValue("@placa", obj.placa);
            cmd.Parameters.AddWithValue("@uf", obj.uf);

            cmd.ExecuteNonQuery();

        }
    }
}