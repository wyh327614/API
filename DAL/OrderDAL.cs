using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using IDataHelp;
using System.Data;
using Newtonsoft.Json;

namespace DAL
{
    public class OrderDAL : Inter<Orders>
    {
        public int Add(Orders t)
        {
            string sql = $"insert into Orders values('{t.UserId}','{t.GoodsId}','{t.OrderNum}','{t.AddressId}','{t.OrderState}')";
            return DBHelper.ExecuteNonQuery(sql);
        }

        public int Delete(int id)
        {
            string sql = $"delete from Orders where OrderId = {id}";
            return DBHelper.ExecuteNonQuery(sql);
        }

        public List<Orders> GetData()
        {
            string sql = "select * from Orders";
            DataTable table = DBHelper.GetDataTable(sql);
            string json = JsonConvert.SerializeObject(table);
            List<Orders> list = JsonConvert.DeserializeObject<List<Orders>>(json);
            return list;
        }

        public int Update(Orders t)
        {
            string sql = $"update Orders set UserId='{t.UserId}',GoodsId='{t.GoodsId}',OrderNum='{t.OrderNum}',AddressId='{t.AddressId}',OrderState='{t.OrderState}' where OrderId={t.OrderId}";
            return DBHelper.ExecuteNonQuery(sql);
        }
    }
}
