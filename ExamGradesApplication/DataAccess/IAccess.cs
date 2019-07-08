using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public interface IAccess<T>
    {
        void Create(T arg);
        int Delete(int argID);
        int Update(T arg);
        T Select(int argID);
        IEnumerable<T> GetAll();
    }
}
