using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database.Classes
{
    class Produto_Mapping : ClassMap<Produto>
    {
        public Produto_Mapping()
        {
            Table("Produtos");
            Id(x => x.Id);
            Map(x => x.Nome);
            Map(x => x.Valor);
        }
    }
}
