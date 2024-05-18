using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pharmacy.Models;
namespace Pharmacy.DB
{
    class CompeniesDB : GeneralDB

    {
        protected List<Compenies> list = new List<Compenies>();
        public CompeniesDB() : base("Compenies")
        {
        }
        private void DataTableToList()
        {
            foreach (DataRow dr in table.Rows)
            {
                list.Add(new Compenies(dr));
            }
        }

        public List<Compenies> GetList()
        {
            list.Clear();
            DataTableToList();
            return list;
        }
        public Compenies Find(string code)
        {
            return this.GetList().Find(x => x.KodC.ToString() == code);
        }
        public void DeleteRow(string code)
        {
            Compenies client = this.Find(code);
            if (client != null)
            {

                client.Dr.Delete();
                this.Update();
            }
        }
        public void DeleteStatus(string code)
        {
            Compenies p = this.Find(code);
            if (p != null)
            {
                p.Status = false;
                this.UpdateRow(p);
            }
        }
        public void UpdateRow(Compenies c)
        {
            c.PutInto();
            this.Update();
        }
        public void AddNew(Compenies c)
        {
            c.Dr = table.NewRow();
            c.PutInto();
            this.Add(c.Dr);
        }
        public int GetNextKey()
        {
            if (this.Size() == 0)
                return 1;
            return this.GetList().Max(x => x.KodC) + 1;

        }


    }
}

