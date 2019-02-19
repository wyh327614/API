using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Model;
using BLL;

namespace WebAPI.UI.Controllers
{
    public class OrderController : ApiController
    {
        OrderBLL BLL = new OrderBLL();
        public int Add(Orders orders)
        {
            return BLL.Add(orders);
        }
        public int Delete(int id)
        {
            return BLL.Delete(id);
        }
        public List<Orders> GetData()
        {
            return BLL.GetData();
        }
        public int Update(Orders orders)
        {
            return BLL.Update(orders);
        }
    }
}
