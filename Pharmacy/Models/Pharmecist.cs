using Pharmacy.Utilities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pharmacy.DB;

namespace Pharmacy.Models
{
    public class Pharmecist
    {
        public DataRow Dr;
        private int kodPh;
        private string pelPh;
        private bool status;
        private string name;

        public Pharmecist()
        {
        }
        public Pharmecist(DataRow dr)
        {
            this.Dr = dr;
            this.kodPh = Convert.ToInt32(dr["kodPh"].ToString());
            this.PelPh = dr["pelPh"].ToString();
            this.status = dr["status"].Equals(true);
            this.name= dr["name"].ToString();
        }
        public int KodPh
        { get => kodPh; set => kodPh = value; }
        public string PelPh
        {
            get { return this.pelPh; }
            set
            {
                if (ValidateUtil.IsCellPhone(value.ToString()))
                    pelPh = value;
                else
                    throw new Exception(" פלאפון שגוי");

            }

        }


        public bool Status { get => status; set => status = value; }
        public string Name
        {
            get { return this.name; }
            set
            {
                if (ValidateUtil.IsHebrew(value.ToString()))
                    name = value;
                else
                    throw new Exception(" שם שגוי");

            }

        }
        public void PutInto()
        {
            Dr["kodPh"] = this.kodPh;
            Dr["pelPh"] = this.pelPh;
            Dr["status"] = this.status;
            Dr["name"] = this.Name;
        }

        public override string ToString()
        {
            return name;
        }
    }



}
