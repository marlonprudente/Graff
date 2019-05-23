using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Database.Classes;



namespace CodingChallenge
{
    public partial class Contact : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButtonCriar_Click(object sender, EventArgs e)
        {
            Produto_Manager.AdicionarProduto(TextBoxNome.Text, decimal.Parse(TextBoxValor.Text));
        }
    }
}