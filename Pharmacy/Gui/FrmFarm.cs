using System;
using Pharmacy.DB;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Pharmacy.Models;

namespace Pharmacy.Gui
{
    public partial class FrmFarm : Form
    {
        private PharmecistDB tblPhrmecist;
        private SalesDB tblSales;
        public FrmFarm()
        {
            InitializeComponent();
            tblPhrmecist = new PharmecistDB();
            tblSales = new SalesDB();
            cmbF.DataSource = tblPhrmecist.GetList();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void cmbF_SelectedIndexChanged(object sender, EventArgs e)
        {
            int a = ((Pharmecist)cmbF.SelectedItem).KodPh;
            dgJob.DataSource = tblSales.GetList().Where(x => x.KodPh == a).Select(x => new { הוצאות = x.PriceAll }).ToList();
        }

        private void FrmFarm_Load(object sender, EventArgs e)
        {

        }
    }
}
