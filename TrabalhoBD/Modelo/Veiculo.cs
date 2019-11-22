using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TrabalhoBD.Modelo
{
    public class Veiculo
    {
        public int id { get; set; }
        public string fabricante { get; set; }
        public string modelo { get; set; }
        public DateTime ano_fabricacao { get; set; }
        public string placa { get; set; }
        public string uf { get; set; }

        public Veiculo()
        {
            this.id = 0;
            this.fabricante = "";
            this.modelo = "";
            this.ano_fabricacao = DateTime.Now;
            this.placa = "";
            this.uf = "";
        }

        public Veiculo(int aid, string afabricante, string amodelo, DateTime aano_fabricacao, string aplaca, string auf)
        {
            this.id = aid;
            this.fabricante = afabricante;
            this.modelo = amodelo;
            this.ano_fabricacao = aano_fabricacao;
            this.placa = aplaca;
            this.uf = auf;
        }
    }

}