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
    class SaleDetails
    {
        public DataRow Dr;
        private int kodSale;
        private int kodM;
        private bool mirsham;
        private int amount;
        private double price;

        public SaleDetails()
        {
        }
        public SaleDetails(DataRow dr)
        {
            this.Dr = dr;
            this.kodSale = Convert.ToInt32(dr["kodSale"].ToString());
            this.KodM = Convert.ToInt32(dr["kodM"].ToString());
            this.mirsham = dr["mirsham"].Equals(true);
            this.price = Convert.ToDouble(dr["price"].ToString());
            this.amount = Convert.ToInt32(dr["amount"].ToString());

        }


        public int KodSale { get => kodSale; set => kodSale = value; }
        public int KodM { get => kodM; set => kodM = value; }
        public bool Mirsham { get => mirsham; set => mirsham = value; }
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

        public int Amount
        {
            get { return amount; }
            set
            {
                if (ValidateUtil.IsNum(value.ToString()))
                    amount = value;
                else
                    throw new Exception(" כמות שגויה ");
            }
        }

        public void PutInto()
        {
            Dr["kodSale"] = this.kodSale;
            Dr["kodM"] = this.kodM;
            Dr["mirsham"] = this.mirsham;
            Dr["price"] = this.price;
            Dr["amount"] = this.amount;
        }

        public override string ToString()
        {
            return kodSale+" "+ kodM + " " + amount;
        }
        public Medician ThisMedician()
        {
            MedicianDB tblC = new MedicianDB();
            return tblC.GetList().First(x => x.KodM == this.kodM);
        }
    }
}   
