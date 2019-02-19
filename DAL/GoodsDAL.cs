using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IDataHelp;
using Model;
using System.Data;
using Newtonsoft.Json;

namespace DAL
{
    public class GoodsDAL : Inter<Goods>
    {
        public int Add(Goods t)
        {
            string sql = string.Format("inset into Goods values('{0}','{1}','{2}','{3}','{4}',{5})",
                t.Photo,t.GoodsName,t.Money,t.ProAddress,t.Type,t.GoodsNum);
            return DBHelper.ExecuteNonQuery(sql);
        }

        public int Delete(int id)
        {
            string sql = "delete from Goods where id=" + id;
            return DBHelper.ExecuteNonQuery(sql);
        }

        public List<Goods> GetData()
        {
            string sql = "select * from Goods";
            DataTable dt = new DataTable(sql);
            string strSql = JsonConvert.SerializeObject(dt);
            List<Goods> list = JsonConvert.DeserializeObject<List<Goods>>(strSql);
            return list;
        }

        public int Update(Goods t)
        {
            string sql =string.Format("update Goods set Photo='{0}',GoodsName='{1}',Money='{2}',ProAddress='{3}',Type='{4}',GoodsNum={5}",
                t.Photo, t.GoodsName, t.Money, t.ProAddress, t.Type, t.GoodsNum);
            return DBHelper.ExecuteNonQuery(sql);
        }
    }
}
