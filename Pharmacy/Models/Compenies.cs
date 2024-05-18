using Pharmacy.Utilities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy.Models
{
   public class Compenies 
    
{
    public DataRow Dr;
    private int kodC;
    private string nameC;
    private string nameP;
    private string pel;
    private bool status;

      public Compenies()
    {
    }
    public Compenies(DataRow dr)
    {
       this.Dr = dr;
       this.kodC = Convert.ToInt32(dr["kodC"].ToString());
       this.nameC = dr["nameC"].ToString();
       this.nameP = dr["nameP"].ToString();
       this.pel = dr["pel"].ToString();
       this.status = dr["status"].Equals(true);
    }
    public int KodC
        { get => kodC; set => kodC = value; }
    public string NameC
        {
        get { return this.nameC; }
        set
        {
           if (ValidateUtil.IsHebrew(value.ToString()))
                    nameC = value;
            else
                throw new Exception(" שם שגוי");

        }

    }
        public string NameP
        {
            get { return this.nameP; }
            set
            {
                if (ValidateUtil.IsHebrew(value.ToString()))
                    nameP = value;
                else
                    throw new Exception(" שם שגוי");

            }

        }

        public string Pel
        {
            get { return this.pel; }
            set
            {
                if (ValidateUtil.IsCellPhone(value.ToString()))
                    pel = value;
                else
                    throw new Exception(" פלאפון שגוי");

            }
        }






        public bool Status { get => status; set => status = value; }

    public void PutInto()
    {
        Dr["kodC"] = this.kodC;
        Dr["nameC"] = this.nameC;
        Dr["nameP"] = this.nameP;
        Dr["Pel"] = this.Pel;
        Dr["status"] = this.status;

    }

    public override string ToString()
    {
        return nameC ;
    }
   }



}
