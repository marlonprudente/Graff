using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Database;
using Database.Classes;
using FluentNHibernate.Mapping;

namespace Database.Classes
{
    public class Usuario_Mapping : ClassMap<Usuario>
    {
        public Usuario_Mapping()
        {
            Table("Usuarios");
            Id(x => x.Id);
            Map(x => x.Nome);
            Map(x => x.Senha);
        }
    }
}
