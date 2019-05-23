using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database.Classes
{
    public class Produto_Manager : BaseManager<Produto>
    {
        public static void AdicionarProduto(string nome, decimal valor)
        {
            var produto = new Produto();
            produto.Nome = nome;
            produto.Valor = valor;

            new BaseManager<Produto>().Save(produto);
            
        }

        public static Produto CarregaProdutoPorId(int produtoId)
        {
            var produto = new BaseManager<Produto>().ReturnById(produtoId);

            return produto;
        }

        public static List<Produto> CarregaProdutos()
        {
            var produtos = new BaseManager<Produto>().Query().OrderBy(x => x.Id).ToList();

            return produtos;
        }
    }
}
