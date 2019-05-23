using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Database.Classes
{
    public class Usuario_Manager : BaseManager<Usuario>
    {

        public static Usuario NovoUsuario(string nome, string senha)
        {
            var usuario = new Usuario();
            usuario.Nome = nome;
            SHA256 mySHA256 = SHA256.Create();

            var senhaData = mySHA256.ComputeHash(Encoding.ASCII.GetBytes(senha));
            var senhaCripto = ASCIIEncoding.ASCII.GetString(senhaData);

            usuario.Senha = senhaCripto;
            new BaseManager<Usuario>().Save(usuario);

            return usuario;
        }

        public static Usuario CarregaUsuarioPorId(int usuarioId)
        {
            return new BaseManager<Usuario>().ReturnById(usuarioId);
        }

        public static List<Usuario> CarregaUsuarios()
        {
            var usuarios = new BaseManager<Usuario>().Query().OrderBy(x => x.Id).ToList();

            return usuarios;
        }

        
    }
}
