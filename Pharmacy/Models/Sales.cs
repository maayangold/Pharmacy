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
    class Sales
    {
        public DataRow Dr;
        private int kodSale;
        private DateTime dateSale;
        private int kodPh;
        private double priceAll;
        private string ofenP;
        private String id;
        private DateTime dateTokef;
        private int num;

        public Sales()
        {
        }
        public Sales(DataRow dr)
        {
            this.Dr = dr;
            this.kodSale = Convert.ToInt32(dr["kodSale"].ToString());
            this.dateSale = Convert.ToDateTime(dr["dateSale"].ToString());
            this.KodPh = Convert.ToInt32(dr["kodPh"].ToString());
            this.priceAll = Convert.ToDouble(dr["priceAll"].ToString());
            this.ofenP = dr["ofenP"].ToString();
            this.id = dr["id"].ToString();
            this.dateTokef = Convert.ToDateTime(dr["dateTokef"].ToString());
            this.num = Convert.ToInt32(dr["num"].ToString());
        }

        public int KodSale { get => kodSale; set => kodSale = value; }
        public DateTime DateSale
        {
            get { return dateSale; }
            set
            {
                if (value >= DateTime.Today)
                    dateSale = value;
                else
                    throw new Exception(" תאריך שגוי");

            }
        }

        public int KodPh { get => kodPh; set => kodPh = value; }
        public double PriceAll
        {
            get { return priceAll; }
            set
            {
                if (ValidateUtil.IsNum(value.ToString()))
                    priceAll = value;
                else
                    throw new Exception("מחיר שגוי");
            }
        }

        public DateTime DateTokef
        {
            get { return dateSale; }
            set
            {
                if (value >= DateTime.Today)
                    dateTokef = value;
                else
                    throw new Exception(" תאריך שגוי");

            }
        }


        public string Id
        {
            get { return this.id; }
            set
            {
                if (ValidateUtil.LegalId(value.ToString()))
                    id = value;
                else
                    throw new Exception(" תז שגויה");

            }

        }


        public string OfenP
        {
            get { return this.ofenP; }
            set
            {
                if (ValidateUtil.IsHebrew(value.ToString()))
                    ofenP = value;
                else
                    throw new Exception(" שם שגוי");

            }

        }
        public int Num { get =>num; set => num = value; }

        public void PutInto()
        {
            Dr["kodSale"] = this.kodSale;
            Dr["dateSale"] = this.dateSale;
            Dr["kodPh"] = this.kodPh;
            Dr["priceAll"] = this.priceAll;
            Dr["ofenP"] = this.ofenP;
            Dr["id"] = this.id;
            Dr["dateTokef"] = this.dateTokef;
            Dr["num"] = this.num;

        }





        public override string ToString()
        {
            return kodSale + " " + priceAll;
        }
        public Pharmecist ThisPharmecist()
        {
            PharmecistDB tblC = new PharmecistDB();
            return tblC.GetList().First(x => x.KodPh == this.kodPh);
        }
    }
}
    












   



