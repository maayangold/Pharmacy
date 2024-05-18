using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pharmacy.Models;


namespace Pharmacy.DB
{
    class SalesDB : GeneralDB
    {
        protected List<Sales> list = new List<Sales>();
        public SalesDB() : base("Sales")
        {
        }
        private void DataTableToList()
        {
            foreach (DataRow dr in table.Rows)
            {
                list.Add(new Sales(dr));
            }
        }

        public List<Sales> GetList()
        {
            list.Clear();
            DataTableToList();
            return list;
        }
        public Sales Find(string code)
        {
            return this.GetList().Find(x => x.KodSale.ToString() == code);
        }
        public void DeleteRow(string code)
        {
            Sales client = this.Find(code);
            if (client != null)
            {

                client.Dr.Delete();
                this.Update();
            }
        }
        public void UpdateRow(Sales c)
        {
            c.PutInto();
            this.Update();
        }
        public void AddNew(Sales c)
        {
            c.Dr = table.NewRow();
            c.PutInto();
            this.Add(c.Dr);
        }
        public int GetNextKey()
        {
            if (this.Size() == 0)
                return 1;
            return this.GetList().Max(x => x.KodSale) + 1;

        }


    }
}
