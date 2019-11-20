using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TrabalhoBD.Modelo
{
    public class Cliente
    {
        public int id { get; set; }
        public string nome { get; set; }
        public DateTime data_nascimento { get; set; }
        public string cpf { get; set; }

        public Cliente()
        {
            this.id = 0;
            this.nome = "";
            this.data_nascimento = DateTime.Now;
            this.cpf = "";
        }

        public Cliente(int aid, string anome, DateTime adata_nascimento, string acpf)
        {
            this.id = aid;
            this.nome = anome;
            this.data_nascimento = adata_nascimento;
            this.cpf = acpf;
        }

    }
}