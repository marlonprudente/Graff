using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database.Classes
{
    public class Lances
    {
        public virtual int Id { get; set; }
        public virtual Usuario Usuario {get;set;}
        public virtual Produto Produto { get; set; }
        public virtual decimal Lance { get; set; }
    }
}
