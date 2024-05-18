using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pharmacy.Models;

namespace Pharmacy.DB
{
    class OrderDetailsDB : GeneralDB


    {
        protected List<OrderDetails> list = new List<OrderDetails>();
        public OrderDetailsDB() : base("OrderDetails")
        {
        }
        private void DataTableToList()
        {
            foreach (DataRow dr in table.Rows)
            {
                list.Add(new OrderDetails(dr));
            }
        }

        public List<OrderDetails> GetList()
        {
            list.Clear();
            DataTableToList();
            return list;
        }
        public OrderDetails Find(string code, string code1)
        {
            return this.GetList().Find(x => x.KodO.ToString() == code && x.KodM.ToString() == code1);
        }
        public void DeleteRow(string code, string code1)
        {
            OrderDetails client = this.Find(code, code1);
            if (client != null)
            {

                client.Dr.Delete();
                this.Update();
            }
        }

        public void UpdateRow(OrderDetails c)
        {
            c.PutInto();
            this.Update();
        }
        public void AddNew(OrderDetails c)
        {
            c.Dr = table.NewRow();
            c.PutInto();
            this.Add(c.Dr);
        }


    }
}

