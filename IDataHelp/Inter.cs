using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDataHelp
{
    public interface Inter<T>
    {
        List<T> GetData();
        int Add(T t);
        int Delete(int id);
        int Update(T t);
    }
}
