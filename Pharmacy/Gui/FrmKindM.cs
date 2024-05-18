using Pharmacy;
using Pharmacy.DB;
using Pharmacy.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace Keren.GUI
{
    public partial class FrmKindM : Form

    {
        private KindMDB tblKindM;
        private KindM thisKind;

        public FrmKindM()
        {
            InitializeComponent();
            tblKindM = new KindMDB();
            dgKinds.DataSource = tblKindM.GetList();
            dgKinds.DataSource = tblKindM.GetList().Select(x => new { קוד = x.KodK, תאור = x.Teur }).ToList();
            panel1.Visible = false;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            txtK.Text = tblKindM.GetNextKey().ToString();
            txtS.Text = "";
            Possible();
            txtS.Select();

        }
        private void Possible()
        {

            panel1.Visible = true;
            btnNew.Visible = false;
            txtS.ReadOnly =false;
            txtK.ReadOnly = true;
        }
        private void notPossible()
        {

            btnNew.Visible = true;
            panel1.Visible = false;

        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            KindM k = new KindM();
            if (tblKindM.GetList().Exists(x => x.Teur == this.txtS.Text))
            {
                DialogResult r = MessageBox.Show(" שגיאת הוספה", "סוג התרופה כבר קיים ", MessageBoxButtons.OK);
                txtS.Text = "";
            }

            else

                if (CreatedFields(k))
            {
                DialogResult r = MessageBox.Show("אישור ", "האם להוסיף סוג זה ", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);


                if (r == DialogResult.Yes)
                {
                    tblKindM.AddNew(k);
                    dgKinds.DataSource = tblKindM.GetList().Select(x => new { קוד = x.KodK, תאור = x.Teur }).ToList();

                    notPossible();
                }

            }
        }

        private bool CreatedFields(KindM k)
        {
            bool ok = true;
            errorProvider1.Clear();
            k.KodK = Convert.ToInt32(txtK.Text);
            try
            {
                k.Teur = txtS.Text;
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(txtS, ex.Message);
                ok = false;

            }
            return ok;

        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            notPossible();
            errorProvider1.Clear();
        }

        private void FrmKindM_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
