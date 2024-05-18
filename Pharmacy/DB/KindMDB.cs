using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pharmacy.Models;
namespace Pharmacy.DB
{
    class KindMDB : GeneralDB

    {
        protected List<KindM> list = new List<KindM>();
    public KindMDB() : base("Kindm")
    {
    }
    private void DataTableToList()
    {
        foreach (DataRow dr in table.Rows)
        {
            list.Add(new KindM(dr));
        }
    }

    public List<KindM> GetList()
    {
        list.Clear();
        DataTableToList();
        return list;
    }
    public KindM Find(string code)
    {
        return this.GetList().Find(x => x.KodK.ToString() == code);
    }
    public void DeleteRow(string code)
    {
            KindM client = this.Find(code);
        if (client != null)
        {

            client.Dr.Delete();
            this.Update();
        }
    }
    
    public void UpdateRow(KindM c)
    {
        c.PutInto();
        this.Update();
    }
    public void AddNew(KindM c)
    {
        c.Dr = table.NewRow();
        c.PutInto();
        this.Add(c.Dr);
    }
    public int GetNextKey()
    {
        if (this.Size() == 0)
            return 1;
        return this.GetList().Max(x => x.KodK) + 1;

    }


}
}

    