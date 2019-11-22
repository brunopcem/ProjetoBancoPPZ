using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TrabalhoBD
{
    public partial class Veiculo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            DAL.VeiculoDAL aVeiculoDal;
            Modelo.Veiculo aVeiculo;

            if (e.CommandName == "edit")
            {
                string sessao;
                int index = Convert.ToInt32(e.CommandArgument);
                sessao = GridView1.Rows[index].Cells[0].Text;
                Session["id"] = sessao;
                Response.Redirect("~\\VeiculoEdit.aspx");
            }

            if (e.CommandName == "del")
            {
                aVeiculoDal = new DAL.VeiculoDAL();
                int codigo;
                int index = Convert.ToInt32(e.CommandArgument);
                codigo = Convert.ToInt32(GridView1.Rows[index].Cells[0].Text);
                aVeiculoDal.Delete(codigo);
                Response.Redirect("~\\Veiculo.aspx");

            }
        }
    }
}