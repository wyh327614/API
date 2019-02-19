using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using IDataHelp;
using DAL;

namespace BLL
{
    public class OrderBLL : Inter<Orders>
    {
        OrderDAL DAL = new OrderDAL();
        public int Add(Orders t)
        {
            return DAL.Add(t);
        }

        public int Delete(int id)
        {
            return DAL.Delete(id);
        }

        public List<Orders> GetData()
        {
            return DAL.GetData();
        }

        public int Update(Orders t)
        {
            return DAL.Update(t);
        }
    }
}
