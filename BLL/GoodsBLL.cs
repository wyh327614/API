using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Model;

namespace BLL
{
    public class GoodsBLL
    {
        GoodsDAL dal = new GoodsDAL();
        public int Add(Goods t)
        {
            return dal.Add(t);
        }

        public int Delete(int id)
        {
            return dal.Delete(id);
        }

        public List<Goods> GetData()
        {
            return dal.GetData();
        }

        public int Update(Goods t)
        {
            return dal.Update(t);
        }
    }
}
