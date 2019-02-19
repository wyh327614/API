using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using DAL;
namespace BLL
{
    public class AddressBll
    {
        AddressDal dal = new AddressDal();
        public int Add(Addresses t)
        {
            return dal.Add(t);
        }

        public int Delete(int id)
        {
            return dal.Delete(id);
        }

        public List<Addresses> GetData()
        {
            return dal.GetData();
        }

        public int Update(Addresses t)
        {
            return dal.Update(t);
        }
    }
}
