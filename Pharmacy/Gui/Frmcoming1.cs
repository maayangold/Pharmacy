using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Pharmacy.DB;
using Pharmacy.Models;
namespace Pharmacy.Gui
{
    public partial class Frmcoming1 : Form
    {
        private OrderDetailsDB tblO;
        private CompeniesDB tblC;
        public Frmcoming1()
        {
            InitializeComponent();
            tblO = new OrderDetailsDB();
            tblC = new CompeniesDB();
            cmbC.DataSource = tblC.GetList();
        }

        private void Frmcoming1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cmbMonth.Text != "" && cmbYear.Text != "")
            {
                int a = Convert.ToInt32(cmbMonth.Text);
                int b = Convert.ToInt32(cmbYear.Text);
                dgJob.DataSource = tblO.GetList().Where(x => x.ThisOrder().DateO.Month == a && x.ThisOrder().DateO.Year == b).Select(x => new {שם_התרופה=x.ThisMedician().NameM,חברה=x.ThisMedician().ThisCompeny().NameC, תאריך_ההזמנה = x.ThisOrder().DateO.Date, כמות = x.Amount,עלות=x.Price }).OrderBy(x=>x.תאריך_ההזמנה).ToList();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (cmbC.Text != "")
            {
                dgJob.DataSource = tblO.GetList().Where(x => x.ThisMedician().KodC ==((Compenies) cmbC.SelectedItem).KodC).Select(x => new { שם_התרופה = x.ThisMedician().NameM, חברה = x.ThisMedician().ThisCompeny().NameC, תאריך_ההזמנה = x.ThisOrder().DateO.Date, כמות = x.Amount, עלות = x.Price }).OrderBy(x => x.תאריך_ההזמנה).ToList();
            }
    }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
 
            this.Hide();
          
        }
    }
}
