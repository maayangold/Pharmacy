using Keren.GUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Pharmacy.Gui;
using Pharmacy.DB;
using Pharmacy.Models;

namespace Pharmacy
{
    public partial class Form1 : Form
    {
       private MedicianDB tblMedician;
        
        public Form1()
        {
            InitializeComponent();
           
            tblMedician = new MedicianDB();
            dgMed.Visible = false;
            melayLoss();
        }

        private void melayLoss()
        {

            dgMed.DataSource = tblMedician.GetList().Where(x => x.Amount < 5 || x.Status==false).Select(x => new { שם_התרופה=x.NameM, כמות_במלאי=x.Amount }).ToList();
            if(dgMed.Rows.Count>0)
                dgMed.Visible = true;
        }

        private void btnM_Click(object sender, EventArgs e)
        {
            FrmMedician f = new FrmMedician();
           
            f.Show();
        }

        private void btnKM_Click(object sender, EventArgs e)
        {
            FrmKindM f= new FrmKindM();
           
            f.Show();

        }

        private void btnPh_Click(object sender, EventArgs e)
        {
           FrmPharmecist f = new FrmPharmecist();
           
            f.Show();
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            FrmCompeny f = new FrmCompeny();
          
            f.Show();

        }

        private void btnS_Click(object sender, EventArgs e)
        {
            FrmSale f = new FrmSale();
          
            f.Show();
        }

        private void btnO_Click(object sender, EventArgs e)
        {
            FrmOrder f = new FrmOrder();
          
            f.Show();

        }

        

        private void btnMoney_Click(object sender, EventArgs e)
        {
            FrmMoney f = new FrmMoney();
           
            f.Show();
        }

        private void btnJob_Click(object sender, EventArgs e)
        {
            FrmFarm f = new FrmFarm();
           
            f.Show();

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            UpdateMelay();
        }

        private void UpdateMelay()
        {
            List<Medician> lst = tblMedician.GetList().Where(x => x.DateT.Date < DateTime.Today.Date).ToList();
            
            foreach( Medician m in lst)
            {
                m.Status = false;
                tblMedician.UpdateRow(m);
            }
            melayLoss();
        }

        private void btnComing_Click(object sender, EventArgs e)
        {
            Frmcoming1 f = new Frmcoming1();
         
            f.Show();
        }
    }
}
