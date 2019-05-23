using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database.Classes
{
    public class Lance_Mapping : FluentNHibernate.Mapping.ClassMap<Lances>
    {
        public Lance_Mapping()
        {
            Table("Lances");
            Id(x => x.Id);
            References(x => x.Usuario).Column("UsuarioID");
            References(x => x.Produto).Column("ProdutoID");
            Map(x => x.Lance);
        }
    }
}
