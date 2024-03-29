﻿using System;
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

        [DataObjectMethod(DataObjectMethodType.Select)]
        public List<Modelo.Cliente> Select(int id)
        {
            Modelo.Cliente aCliente;
            List<Modelo.Cliente> aListClientes = new List<Modelo.Cliente>();
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "EXEC dbo.Select_Cliente @id";
            cmd.Parameters.AddWithValue("@id", id);
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

        [DataObjectMethod(DataObjectMethodType.Update)]
        public void Update(Modelo.Cliente obj)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand com = conn.CreateCommand();
            SqlCommand cmd = new SqlCommand("EXEC dbo.Update_Cliente @id, @nome, @data_nascimento, @cpf ", conn);
            cmd.Parameters.AddWithValue("@id", obj.id);
            cmd.Parameters.AddWithValue("@nome", obj.nome);
            cmd.Parameters.AddWithValue("@data_nascimento", obj.data_nascimento);
            cmd.Parameters.AddWithValue("@cpf", obj.cpf);

            // Executa Comando
            cmd.ExecuteNonQuery();
        }

        [DataObjectMethod(DataObjectMethodType.Insert)]
        public void Insert(Modelo.Cliente obj)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand com = conn.CreateCommand();
            SqlCommand cmd = new SqlCommand("INSERT INTO Cliente (nome, data_nascimento, cpf) VALUES(@nome, @data_nascimento, @cpf)", conn);
            cmd.Parameters.AddWithValue("@nome", obj.nome);
            cmd.Parameters.AddWithValue("@data_nascimento", obj.data_nascimento);
            cmd.Parameters.AddWithValue("@cpf", obj.cpf);

            cmd.ExecuteNonQuery();

        }
    }
}