using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TrabalhoBD
{
    public partial class ClienteNovo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButtonS_Click(object sender, EventArgs e)
        {
            Modelo.Cliente iCliente;
            DAL.ClienteDAL iClienteDAL;
            var data1 = Request["DATA"];


            iCliente = new Modelo.Cliente(0,TextBoxNOME.Text, DateTime.Parse(data1), TextBoxCPF.Text);


            iClienteDAL = new DAL.ClienteDAL();


            iClienteDAL.Insert(iCliente);


            Response.Redirect("~\\Cliente.aspx");
        }
    }
}