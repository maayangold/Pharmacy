using Pharmacy.DB;
using Pharmacy.Utilities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy.Models
{
   public class Medician
    {
        public DataRow Dr;
        private int kodM;
        private string nameM;
        private bool mirsham;
        private int kodK;
        private double price;
        private double priceYes; 
        private double priceNo;
        private  int kodC;
        private int amount;
        private DateTime dateT;
        private bool status;
        public Medician()
        {
        }

        public Medician(DataRow dr)
        {
            this.Dr = dr;
            this.kodM = Convert.ToInt32(dr["kodM"].ToString());
            this.nameM = dr["naneM"].ToString();
            this.mirsham = dr["mirsham"].Equals(true);
            this.kodK = Convert.ToInt32(dr["kodK"].ToString());
            this.price =Convert.ToDouble( dr["price"].ToString());
            this.priceYes = Convert.ToDouble(dr["priceYes"].ToString());
            this.priceNo = Convert.ToDouble(dr["priceNo"].ToString());
            this.kodC = Convert.ToInt32(dr["kodC"].ToString());
            this.amount = Convert.ToInt32(dr["amount"].ToString());
            this.dateT = Convert.ToDateTime(dr["dateT"].ToString());
            this.status = dr["status"].Equals(true);
            
        }
        public int KodM
        {
            get { return kodM; }
            set { if (ValidateUtil.IsNum(value.ToString()))
                    kodM = value;
                else
                    throw new Exception(" קוד תרופה שגוי");

               }
        }

        public string NameM
        {
            get { return nameM; }
            set
            {
                if (ValidateUtil.IsHebrew(value))
                    nameM = value;
                else
                    throw new Exception(" שם שגוי");
            }
        }

        public bool Mirsham { get => mirsham; set => mirsham = value; }
        public int KodK
        {
            get { return kodK; }
            set
            {
                if (ValidateUtil.IsNum(value.ToString()))
                    kodK = value;
                else
                    throw new Exception(" קוד סוג שגוי");

            }
        }
        public double Price
        {
            get { return price; }
            set
            {
                if (ValidateUtil.IsNum(value.ToString()))
                    price = value;
                else
                    throw new Exception("מחיר שגוי");

            }
        }
        public double PriceYes
        {
            get { return priceYes; }
            set
            {
                if (ValidateUtil.IsNum(value.ToString()))
                    priceYes = value;
                else
                    throw new Exception(" מחיר שגוי");

            }
        }

        public Double PriceNo
        {
            get { return priceNo; }
            set
            {
                if (ValidateUtil.IsNum(value.ToString()))
                    priceNo = value;
                else
                    throw new Exception(" מחיר שגוי");

            }
        }
        public int KodC
        {
            get { return kodC; }
            set
            {
                if (ValidateUtil.IsNum(value.ToString()))
                    kodC = value;
                else
                    throw new Exception(" קוד חברה שגוי");
            }
        }
        public int Amount
        {
            get { return amount; }
            set
            {
                if (ValidateUtil.IsNum(value.ToString()))
                    amount = value;
                else
                    throw new Exception  (" כמות שגויה ");
            }
        }
        public DateTime DateT
        {
            get { return dateT; }
            set
            {
                if (value >= DateTime.Today)
                    dateT = value;
                else
                    throw new Exception(" תאריך שגוי");

            }
        }



        public bool Status { get => status; set => status = value; }




        public void PutInto()
        {
            Dr["kodM"] = this.kodM;
            Dr["naneM"] = this.nameM;
            Dr["mirsham"] = this.mirsham;
            Dr["kodK"] = this.kodK;
            Dr["price"] = this.price;
            Dr["priceYes"] = this.priceYes;
            Dr["priceNo"] = this.priceNo;
            Dr["kodC"] = this.kodC;
            Dr["amount"] = this.amount;
            Dr["dateT"] = this.dateT;
            Dr["status"] = this.status;


        }

        public override string ToString()
        {
            return kodM+" "+nameM +" " +kodK; 
        }

        public Compenies ThisCompeny()
        {
            CompeniesDB tblC = new CompeniesDB();
            return tblC.GetList().First(x => x.KodC == this.kodC);
        }
        public KindM ThisKindM()
        {
            KindMDB tblK = new KindMDB();
            return tblK.GetList().First(x => x.KodK == this.kodK);
        }
    }
}
