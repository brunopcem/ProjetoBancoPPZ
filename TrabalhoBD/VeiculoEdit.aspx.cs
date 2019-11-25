using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TrabalhoBD
{
    public partial class VeiculoEdit : System.Web.UI.Page
    {
        Modelo.Veiculo iVeiculo = new Modelo.Veiculo();
        DAL.VeiculoDAL iVeiculoDAL = new DAL.VeiculoDAL();
        protected void Page_Load(object sender, EventArgs e)
        {

            var id = int.Parse(Session["id"].ToString());
            var a =  iVeiculoDAL.Select(id);
           // TextBoxFAB.Text = a[id-1].fabricante;
           // TextBoxMOD.Text = a[id-1].modelo;
           // TextBoxANO.Text = a[id-1].ano_fabricacao.ToString();
           // TextBoxPLACA.Text = a[id-1].placa;
           // TextBoxUF.Text = a[id-1].uf;


        }

        protected void ButtonS1_Click(object sender, EventArgs e)
        {



            iVeiculo = new Modelo.Veiculo(int.Parse(Session["id"].ToString()), TextBoxFAB.Text, TextBoxMOD.Text, Int32.Parse(TextBoxANO.Text), TextBoxPLACA.Text, TextBoxUF.Text);


            iVeiculoDAL = new DAL.VeiculoDAL();


            iVeiculoDAL.Update(iVeiculo);


            Response.Redirect("~\\Veiculo.aspx");
        }
    }
}
