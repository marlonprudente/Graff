using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Security.Cryptography;
using System.Text;
using Database.Classes;

namespace CodingChallenge
{
    public partial class About : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

            }
        }

        protected void ButtonCriar_Click(object sender, EventArgs e)
        {
            Usuario_Manager.NovoUsuario(TextBoxLogin.Text, TextBoxSenha.Text);
        }
    }
}