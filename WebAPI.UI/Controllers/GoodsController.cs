using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BLL;
using Model;

namespace WebAPI.UI.Controllers
{
    public class GoodsController : ApiController
    {
        GoodsBLL bll = new GoodsBLL();
        public int Add(Goods goods)
        {
            return bll.Add(goods);
        }
        public int Delete(int id)
        {
            return bll.Delete(id);
        }
        public List<Goods> GetGoods()
        {
            return bll.GetData();
        }
        public int Update(Goods goods)
        {
            return bll.Update(goods);
        }
    }
}
