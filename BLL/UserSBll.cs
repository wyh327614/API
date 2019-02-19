using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using DAL;
using IDataHelp;

namespace BLL
{
    public class UserSBll
    {
        UsersDal dal = new UsersDal();
        /// <summary>
        /// 登陆方法
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public Users Login(Users user)
        {
            return dal.Login(user);
        }
        /// <summary>
        /// 用户注册方法
        /// </summary>
        /// <param name="t"></param>
        /// <returns></returns>
        public int Add(Users t)
        {
            return dal.Add(t);
        }

        /// <summary>
        /// 修改使用
        /// </summary>
        /// <param name="t"></param>
        /// <returns></returns>
        public int Update(Users t)
        {
            return dal.Update(t);
        }
    }
}
