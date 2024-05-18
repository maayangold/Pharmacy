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
    class OrderDetails
    {
        public DataRow Dr;
        private int kodO;
        private int kodM;
        private int amount;
        private double price;

        public OrderDetails()
        {
        }
        public OrderDetails(DataRow dr)
        {
            this.Dr = dr;
            this.kodO = Convert.ToInt32(dr["kodO"].ToString());
            this.KodM = Convert.ToInt32(dr["kodM"].ToString());
            this.price = Convert.ToDouble(dr["price"].ToString());
            this.amount = Convert.ToInt32(dr["amount"].ToString());

        }


        public int KodO { get => kodO; set => kodO = value; }
        public int KodM { get => kodM; set => kodM = value; }
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
            Dr["kodO"] = this.kodO;
            Dr["kodM"] = this.kodM;
            Dr["price"] = this.price;
            Dr["amount"] = this.amount;
        }

        public override string ToString()
        {
            return kodO + " " + kodM + " " + amount;
        }
        public Medician ThisMedician()
        {
            MedicianDB tblC = new MedicianDB();
            return tblC.GetList().First(x => x.KodM == this.kodM);
        }
        public Orders ThisOrder()
        {
            OrdersDB tblC = new OrdersDB();
            return tblC.GetList().First(x => x.KodO == this.kodO);
        }
    }
}   

    