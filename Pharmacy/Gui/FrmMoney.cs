using Pharmacy.DB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;

namespace Pharmacy.Gui
{
    public partial class FrmMoney : Form    
    {
        private OrdersDB tblOrder;
        private SalesDB tblSale;
        public FrmMoney()
        {
            InitializeComponent();
            tblOrder = new OrdersDB();
            tblSale= new SalesDB();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

      
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cmbMonth.Text != "" && cmbYear.Text != "")
            {
                int a = Convert.ToInt32(cmbMonth.Text);
                int b = Convert.ToInt32(cmbYear.Text);
                dgMoney.DataSource = tblOrder.GetList().Where(x => x.DateO.Month == a && x.DateO.Year==b).Select(x => new {תאריך=x.DateO.Date, הוצאות = x.PriceAll }).ToList();
                dgIn.DataSource = tblSale.GetList().Where(x => x.DateSale.Month == a && x.DateSale.Year == b).Select(x => new { תאריך = x.DateSale.Date, הכנסות = x.PriceAll }).ToList();
                txtSumA.Text = tblSale.GetList().Where(x => x.DateSale.Month == a && x.DateSale.Year == b).Sum(x => x.PriceAll).ToString();
                txtSumH.Text = tblOrder.GetList().Where(x => x.DateO.Month == a && x.DateO.Year == b).Sum(x => x.PriceAll).ToString();
            }
        }

        private void FrmMoney_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
