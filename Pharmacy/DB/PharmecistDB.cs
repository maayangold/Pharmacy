using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pharmacy.Models;

namespace Pharmacy.DB
{
    class PharmecistDB: GeneralDB
    
    {
        protected List<Pharmecist> list = new List<Pharmecist>();
        public PharmecistDB() : base("Pharmecist")
        {
        }
        private void DataTableToList()
        {
            foreach (DataRow dr in table.Rows)
            {
                list.Add(new Pharmecist(dr));
            }
        }

        public List<Pharmecist> GetList()
        {
            list.Clear();
            DataTableToList();
            return list;
        }
        public Pharmecist Find(string code)
        {
            return this.GetList().Find(x => x.KodPh.ToString() == code);
        }
        public void DeleteRow(string code)
        {
            Pharmecist client = this.Find(code);
            if (client != null)
            {

                client.Dr.Delete();
                this.Update();
            }
        }
        public void DeleteStatus(string code)
        {
            Pharmecist p = this.Find(code);
            if (p != null)
            {
                p.Status = false;
                this.UpdateRow(p);
            }
        }
        public void UpdateRow(Pharmecist c)
        {
            c.PutInto();
            this.Update();
        }
        public void AddNew(Pharmecist c)
        {
            c.Dr = table.NewRow();
            c.PutInto();
            this.Add(c.Dr);
        }
        public int GetNextKey()
        {
            if (this.Size() == 0)
                return 1;
            return this.GetList().Max(x => x.KodPh) + 1;

        }


    }
}

    