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
    public class AddressDal : Inter<Addresses>
    {
        public int Add(Addresses t)
        {
            string sql = string.Format($"insert into Adress values('{t.Consignse}',{t.UserId},'{t.Region}','{t.DetailAddress}','{t.Phone}')");
            return DBHelper.ExecuteNonQuery(sql);
        }

        public int Delete(int id)
        {
            return DBHelper.ExecuteNonQuery($"delete Adress where AdressId=" + id);
        }

        public List<Addresses> GetData()
        {
            DataTable dt = DBHelper.GetDataTable("select * from Adress");
            string str = JsonConvert.SerializeObject(dt);
            List<Addresses> list = JsonConvert.DeserializeObject<List<Addresses>>(str);
            return list;
        }

        public int Update(Addresses t)
        {
            string sql = string.Format($"update  Adress set Consignse='{t.Consignse}',UserId={t.UserId},'Region={t.Region}',DetailAddress='{t.DetailAddress}',Phone='{t.Phone}' where AdressId={t.AddressId}");
            return DBHelper.ExecuteNonQuery(sql);
        }
    }
}
