using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
using Model;
using IDataHelp;

namespace DAL
{
    public class UsersDal:Inter<Users>
    {
        //连接字符webconfig连接字符串
        IDbConnection conn = new SqlConnection(ConfigurationSettings.AppSettings["conntionstring"]);

        public List<Users> GetData()
        {
            using (conn)
            {
                return conn.Query<Users>("select * from Users").ToList<Users>();
            }
        }
        /// <summary>
        /// 登陆方法
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public Users Login(Users user)
        {
            using (conn)
            {
                return conn.QueryFirst<Users>("select * from Users where UserName='@UserName' and UserPwd='@UserPwd'", user);
            }
        }
        /// <summary>
        /// 用户注册方法
        /// </summary>
        /// <param name="t"></param>
        /// <returns></returns>
        public int Add(Users t)
        {
            using (conn)
            {
                return conn.Execute("insert into Users values('@UserName','@UserPwd','@Phone')", t);
            }
        }

        public int Delete(int id)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// 修改使用
        /// </summary>
        /// <param name="t"></param>
        /// <returns></returns>
        public int Update(Users t)
        {
            using (conn)
            {
                return conn.Execute("update Users set UserName='@UserName',UserPwd='@UserPwd',Phone='@Phone' where UserId='@UserId'", t);
            }
        }
    }
}
