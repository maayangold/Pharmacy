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
    class Orders
    {
        public DataRow Dr;
        private int kodO;
        private int kodC;
        private DateTime dateO;
        private double priceAll;
        private bool supak;
        private DateTime dateA;
        public Orders()
        {
        }
        public Orders(DataRow dr)
        {
            this.Dr = dr;
            this.KodO = Convert.ToInt32(dr["kodO"].ToString());
            this.KodC = Convert.ToInt32(dr["kodC"].ToString());
            this.dateO = Convert.ToDateTime(dr["dateO"].ToString());
            this.priceAll = Convert.ToDouble(dr["priceAll"].ToString());
            this.Supak = dr["supak"].Equals(true);
            this.dateA = Convert.ToDateTime(dr["dateA"].ToString());
        }

        public int KodO { get => kodO; set => kodO = value; }

        public int KodC { get => kodC; set => kodC = value; }

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
    
        public DateTime DateO
        {
            get { return dateO; }
            set
            {
                if (value >= DateTime.Today)
                    dateO = value;
                else
                    throw new Exception(" תאריך שגוי");

            }
        }

        public bool Supak { get => supak; set => supak = value; }
        public DateTime DateA
        {
            get { return dateA; }
            set
            {
                if (value >= DateTime.Today)
                    dateA = value;
                else
                    throw new Exception(" תאריך שגוי");

            }
        }

        public void PutInto()
        {
            Dr["kodO"] = this.kodO;
            Dr["kodC"] = this.kodC;
            Dr["priceAll"] = this.priceAll;
            Dr["supak"] = this.supak;
            Dr["dateO"] = this.dateO;
            Dr["dateA"] = this.dateA;

        }

        public override string ToString()
        {
            return KodO+" "+ dateO + " " + supak;
        }
        public Compenies ThisCompeny()
        {
            CompeniesDB tblC = new CompeniesDB();
            return tblC.GetList().First(x => x.KodC == this.kodC);
        }
    }
}
