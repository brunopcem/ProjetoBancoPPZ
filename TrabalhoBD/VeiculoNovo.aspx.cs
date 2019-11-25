using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TrabalhoBD
{
    public partial class VeiculoNovo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButtonS1_Click(object sender, EventArgs e)
        {
            Modelo.Veiculo iVeiculo;
            DAL.VeiculoDAL iVeiculoDAL;


            iVeiculo = new Modelo.Veiculo(0, TextBoxFAB.Text, TextBoxMOD.Text, Int32.Parse(TextBoxANO.Text), TextBoxPLACA.Text, TextBoxUF.Text);


            iVeiculoDAL = new DAL.VeiculoDAL();


            iVeiculoDAL.Insert(iVeiculo);


            Response.Redirect("~\\Veiculo.aspx");
        }
    }
}