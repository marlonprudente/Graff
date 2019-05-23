using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database.Classes
{
    public class Lance_Manager
    {
        public static Lances NovoLace(int produtoId, int usuarioId, decimal valorLance, out string error)
        {
            error = "";
            bool verificador = VerificaLance(produtoId, valorLance);

            if (verificador)
            {
                var lances = new Lances();
                lances.Produto = Produto_Manager.CarregaProdutoPorId(produtoId);
                lances.Usuario = Usuario_Manager.CarregaUsuarioPorId(usuarioId);
                lances.Lance = valorLance;

                new BaseManager<Lances>().Save(lances);

                return lances;
            }
            else
            {
                error = "Valor nao pode ser menor que o valor do maior lance.";
                return null;
            }            
        }

        public static List<Lances> CarregaLances()
        {
            var lances = new BaseManager<Lances>().Query().OrderByDescending(x => x.Id).ToList();

            return lances;
        }

        public static bool VerificaLance(int produtoId, decimal valorLance)
        {
            
            var maiorLance = new BaseManager<Lances>().Query().Where( x => x.Produto.Id == produtoId)
                .FirstOrDefault();

            if(maiorLance == null)
            {
                return true;
            }

            if(valorLance > maiorLance.Lance)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
