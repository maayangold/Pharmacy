using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pharmacy.Models;
namespace Pharmacy.DB
{
    class OrdersDB : GeneralDB

    {
        protected List<Orders> list = new List<Orders>();
        public OrdersDB() : base("orders")
        {
        }
        private void DataTableToList()
        {
            foreach (DataRow dr in table.Rows)
            {
                list.Add(new Orders(dr));
            }
        }

        public List<Orders> GetList()
        {
            list.Clear();
            DataTableToList();
            return list;
        }
        public Orders Find(string code)
        {
            return this.GetList().Find(x => x.KodO.ToString() == code);
        }
        public void DeleteRow(string code)
        {
            Orders client = this.Find(code);
            if (client != null)
            {

                client.Dr.Delete();
                this.Update();
            }
        }
       
        public void UpdateRow(Orders c)
        {
            c.PutInto();
            this.Update();
        }
        public void AddNew(Orders c)
        {
            c.Dr = table.NewRow();
            c.PutInto();
            this.Add(c.Dr);
        }
        public int GetNextKey()
        {
            if (this.Size() == 0)
                return 1;
            return this.GetList().Max(x => x.KodO) + 1;

        }


    }
}



