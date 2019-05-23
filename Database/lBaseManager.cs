using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database
{
    public interface lBaseManager<T>
    {
        void Save(T entidade);

        void SaveOrUpdate(T entidade);
        void Update(T entidade);
        void Delete(T entidade);
        T ReturnById(int id);
        IList<T> Query();
    }
}
