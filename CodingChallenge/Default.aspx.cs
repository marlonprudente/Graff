using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Database.Classes;

namespace CodingChallenge
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CarregaListas();
            }



        }

        public void CarregaListas()
        {
            var usuarios = Usuario_Manager.CarregaUsuarios();
            DropDownListUsuario.DataSource = usuarios;
            DropDownListUsuario.DataValueField = "Id";
            DropDownListUsuario.DataTextField = "Nome";
            DropDownListUsuario.DataBind();

            var produtos = Produto_Manager.CarregaProdutos();
            DropDownListProduto.DataSource = produtos;
            DropDownListProduto.DataValueField = "Id";
            DropDownListProduto.DataTextField = "Nome";
            DropDownListProduto.DataBind();

            GridViewLances.DataSource = Lance_Manager.CarregaLances();
            GridViewLances.DataBind();

        }

        protected void ButtonNovoLance_Click(object sender, EventArgs e)
        {
            string error = LabelErro.Text =  "";
            var usuario = Usuario_Manager.CarregaUsuarioPorId(int.Parse( DropDownListUsuario.SelectedValue));
            var produto = Produto_Manager.CarregaProdutoPorId(int.Parse(DropDownListProduto.SelectedValue));
            var valorLance = decimal.Parse(TextBoxLance.Text);


            Lance_Manager.NovoLace(produto.Id, usuario.Id, valorLance, out error);

            if (!string.IsNullOrWhiteSpace(error))
            {
                LabelErro.Text = $"<div class='alert alert-warning' role='alert'> {error} </div>" ;
            }

            CarregaListas();
        }

        protected void GridViewLances_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                e.Row.Cells[1].Text = Usuario_Manager.CarregaUsuarioPorId(int.Parse(e.Row.Cells[1].Text)).Nome;
                e.Row.Cells[2].Text = Produto_Manager.CarregaProdutoPorId(int.Parse(e.Row.Cells[2].Text)).Nome;
            }
        }
    }
}