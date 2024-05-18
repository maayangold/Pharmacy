using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pharmacy.Models;

namespace Pharmacy.DB
{
    class SaleDetailsDB: GeneralDB
    
    
    {
        protected List<SaleDetails> list = new List<SaleDetails>();
        public SaleDetailsDB() : base("SaleDetails")
        {
        }
        private void DataTableToList()
        {
            foreach (DataRow dr in table.Rows)
            {
                list.Add(new SaleDetails(dr));
            }
        }

        public List<SaleDetails> GetList()
        {
            list.Clear();
            DataTableToList();
            return list;
        }
        public SaleDetails Find(string code, string code1)
        {
            return this.GetList().Find(x => x.KodSale.ToString() == code&&x.KodM.ToString() == code1);
        }
        public void DeleteRow(string code, string code1)
        {
            SaleDetails client = this.Find(code,code1);
            if (client != null)
            {

                client.Dr.Delete();
                this.Update();
            }
        }
      
        public void UpdateRow(SaleDetails c)
        {
            c.PutInto();
            this.Update();
        }
        public void AddNew(SaleDetails c)
        {
            c.Dr = table.NewRow();
            c.PutInto();
            this.Add(c.Dr);
        }
       

    }
}

