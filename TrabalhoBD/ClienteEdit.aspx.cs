using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TrabalhoBD
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void ButtonS_Click(object sender, EventArgs e)
        {
            Modelo.Cliente iCliente;
            DAL.ClienteDAL iClienteDAL;
            var data1 = Request["DATA"];


            iCliente = new Modelo.Cliente(int.Parse(Session["id"].ToString()), TextBoxNOME.Text, DateTime.Parse(data1), TextBoxCPF.Text);


            iClienteDAL = new DAL.ClienteDAL();


            iClienteDAL.Update(iCliente);


            Response.Redirect("~\\Cliente.aspx");
        }




    }
}