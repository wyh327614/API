using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BLL;
using Model;
using Newtonsoft.Json;
 
namespace WebAPI.UI.Controllers
{
    public class UserAPIController : ApiController
    {
        UserSBll bll = new UserSBll();
        /// <summary>
        /// 用户注册使用方法
        /// </summary>
        /// <param name="users"></param>
        /// <returns></returns>
        [HttpPost]
        public int Post(Users users)
        {
            return bll.Add(users);
        }

        /// <summary>
        /// 登陆使用方法
        /// </summary>
        /// <param name="users"></param>
        /// <returns></returns>
        [HttpGet]
        public Users Get(string Name,string Pwd)
        {
            Users users = new Users();
            users.UserName = Name;
            users.UserPwd = Pwd;
            return bll.Login(users);
        }
        /// <summary>
        /// 用户信息修改
        /// </summary>
        /// <param name="users"></param>
        /// <returns></returns>
        [HttpPut]
        public int Put(Users users)
        {
            return bll.Update(users);
        }
    }
}
