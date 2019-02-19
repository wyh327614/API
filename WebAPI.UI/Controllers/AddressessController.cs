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
    public class AddressessController : ApiController
    {
        AddressBll bll = new AddressBll();
        //新增
        [HttpPost]
        public int add(Addresses a)
        {
            return bll.Add(a);
        }
        //显示
        [HttpGet]
        public List<Addresses>show()
        {
            return bll.GetData();
        }
        //删除
        [HttpDelete]
        public int Del(int id)
        {
            return bll.Delete(id);
        }
        //修改
        [HttpPut]
        public int Upd(Addresses a)
        {
            return bll.Update(a);
        }
    }
}
