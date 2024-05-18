
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pharmacy.Models;


namespace Pharmacy.DB
{
    class MedicianDB : GeneralDB

    {
        protected List<Medician> list = new List<Medician>();
        public MedicianDB() : base("Medician")
        {
        }
        private void DataTableToList()
        {
            foreach (DataRow dr in table.Rows)
            {
                list.Add(new Medician(dr));
            }
        }

        public List<Medician> GetList()
        {
            list.Clear();
            DataTableToList();
            return list;
        }
        public Medician Find(string code)
        {
            return this.GetList().Find(x => x.KodM.ToString() == code);
        }
        public void DeleteRow(string code)
        {
            Medician client = this.Find(code);
            if (client != null)
            {

                client.Dr.Delete();
                this.Update();
            }
        }
        public void DeleteStatus(string code)
        {
            Medician p = this.Find(code);
            if (p != null)
            {
                p.Status = false;
                this.UpdateRow(p);
            }
        }
        public void UpdateRow(Medician c)
        {
            c.PutInto();
            this.Update();
        }
        public void AddNew(Medician c)
        {
            c.Dr = table.NewRow();
            c.PutInto();
            this.Add(c.Dr);
        }
        public int GetNextKey()
        {
            if (this.Size() == 0)
                return 1;
            return this.GetList().Max(x => x.KodM) + 1;

        }

       
    }
}


