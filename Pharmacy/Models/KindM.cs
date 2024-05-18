using Pharmacy.Utilities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy.Models
{
   public class KindM
    {
        public DataRow Dr;
        private int kodK;
        private string teur;
        public KindM()
        {
        }
        public KindM(DataRow dr)
        {
            this.Dr = dr;
            this.KodK = Convert.ToInt32(dr["kodK"].ToString());
            this.Teur = dr["teur"].ToString();
        }

        public int KodK { get => kodK; set => kodK = value; }
        public string Teur
        {
            get { return this.teur; }
            set
            {
                if (ValidateUtil.IsHebrew(value.ToString()))
                    teur = value;
                else
                    throw new Exception(" שם שגוי");

            }
        }

        public void PutInto()
        {
            Dr["kodK"] = this.kodK;
            Dr["teur"] = this.teur;
           

        }
        public override string ToString()
        {
            return teur;
        }









    }


}
