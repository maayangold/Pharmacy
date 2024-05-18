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

namespace Pharmacy.Gui
{
    public partial class FrmMedician : Form
    {
        private MedicianDB tblMedician;
        private Medician thisMedician;
        private bool flagAdd;
        private bool flagUpdate;
        private KindMDB tblKindM;
        private CompeniesDB tblcompenies;


        public FrmMedician()
        {
            InitializeComponent();
            tblMedician = new MedicianDB();
            tblcompenies = new CompeniesDB();
            flagAdd = false;
            flagUpdate = false;
            tblKindM = new KindMDB();
            dgSearch.DataSource = null;
            cmbk.DataSource = tblKindM.GetList();
            cmbC.DataSource = tblcompenies.GetList();
             dgSearch.DataSource = tblMedician.GetList().Where(x=>x.Status).Select(x => new {
                קוד_תרופה = x.KodM, שם_תרופה = x.NameM, מרשם = x.Mirsham,סוג_תרופה = x.ThisKindM().Teur,שם_חברה = x.ThisCompeny().NameC
                , מחיר_מספק = x.Price, מחיר_ללא_מרשם = x.PriceNo, מחיר_עם_מרשם = x.PriceYes,
                כמות = x.Amount,תאריך_תפוקה = x.DateT,פעיל = x.Status  }).ToList();
            notPossible();
        }
        private void Possible()
        {
            panel2.Visible = true;
            panel1.Visible = false;
            txtK.ReadOnly= true; 
            txtName.ReadOnly = false;
            txtP.ReadOnly = false;
            txtPNo.ReadOnly = false;
            txtPYes.ReadOnly = false;
            txtAmount.ReadOnly = false;
            cmbk.Enabled = true;
            cmbC.Enabled = true;
           
                

        }
        private void notPossible()
        {
            flagAdd = false;
            panel2.Visible = false;
            panel1.Visible = true;
            txtK.ReadOnly = false;
            txtName.ReadOnly = false;
            txtP.ReadOnly = true;
            txtPNo.ReadOnly = true;
            txtPYes.ReadOnly = true;
            txtAmount.ReadOnly = true;
            cmbk.Enabled = true;
            cmbC.Enabled = true;
            txtK.Text = "";
            txtName.Text = "";
            txtP.Text = "";
            txtPNo.Text = "";
            txtPYes.Text = "";
            txtAmount.Text = ""; 
            dt.Value = DateTime.Today;
            cmbk.Text = "";
            cmbC.Text = "";
            chbM.Checked = false;
            chbP.Checked = false;
        }



        private void btnRefresh_Click(object sender, EventArgs e)
        {
            dgSearch.DataSource = tblMedician.GetList().Where(x=>x.Status).Select(x => new {
                קוד_תרופה = x.KodM, שם_תרופה = x.NameM, מרשם = x.Mirsham,סוג_תרופה = x.ThisKindM().Teur,שם_חברה = x.ThisCompeny().NameC
                , מחיר_מספק = x.Price, מחיר_ללא_מרשם = x.PriceNo, מחיר_עם_מרשם = x.PriceYes,
                כמות = x.Amount,תאריך_תפוקה = x.DateT,פעיל = x.Status  }).ToList();
            txtK.Text = ""; 
            txtName.Text = "";
            txtP.Text = "";
            txtPNo.Text = "";
            txtPYes.Text = "";
            txtAmount.Text = "";
            dt.Value = DateTime.Today;
            cmbk.Text = "";
            cmbC.Text = "";
           



        }
        private void txtK_TextChanged(object sender, EventArgs e)
        {
            dgSearch.DataSource = tblMedician.GetList().Where(x =>x.Status && x.KodM.ToString().StartsWith(txtK.Text)).Select(x => new {
                 קוד_תרופה = x.KodM, שם_תרופה = x.NameM, מרשם = x.Mirsham,סוג_תרופה = x.ThisKindM().Teur,שם_חברה = x.ThisCompeny().NameC
                , מחיר_מספק = x.Price, מחיר_ללא_מרשם = x.PriceNo, מחיר_עם_מרשם = x.PriceYes,
                כמות = x.Amount,תאריך_תפוקה = x.DateT,פעיל = x.Status  }).ToList();

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            dgSearch.DataSource = tblMedician.GetList().Where(x => x.Status && x.NameM.StartsWith(txtName.Text)).Select(x => new {
                  קוד_תרופה = x.KodM, שם_תרופה = x.NameM, מרשם = x.Mirsham,סוג_תרופה = x.ThisKindM().Teur,שם_חברה = x.ThisCompeny().NameC
                , מחיר_מספק = x.Price, מחיר_ללא_מרשם = x.PriceNo, מחיר_עם_מרשם = x.PriceYes,
                כמות = x.Amount,תאריך_תפוקה = x.DateT,פעיל = x.Status  }).ToList();

        }
        private void txtAmount_TextChanged(object sender, EventArgs e)
        {dgSearch.DataSource = tblMedician.GetList().Where(x => x.Status && x.NameM.StartsWith(txtName.Text)).Select(x => new {
                  קוד_תרופה = x.KodM, שם_תרופה = x.NameM, מרשם = x.Mirsham,סוג_תרופה = x.ThisKindM().Teur,שם_חברה = x.ThisCompeny().NameC
                , מחיר_מספק = x.Price, מחיר_ללא_מרשם = x.PriceNo, מחיר_עם_מרשם = x.PriceYes,
                כמות = x.Amount,תאריך_תפוקה = x.DateT,פעיל = x.Status  }).ToList();


        }

        private void txtDateT_TextChanged(object sender, EventArgs e)
        {dgSearch.DataSource = tblMedician.GetList().Where(x => x.Status && x.NameM.StartsWith(txtName.Text)).Select(x => new {
                  קוד_תרופה = x.KodM, שם_תרופה = x.NameM, מרשם = x.Mirsham,סוג_תרופה = x.ThisKindM().Teur,שם_חברה = x.ThisCompeny().NameC
                , מחיר_מספק = x.Price, מחיר_ללא_מרשם = x.PriceNo, מחיר_עם_מרשם = x.PriceYes,
                כמות = x.Amount,תאריך_תפוקה = x.DateT,פעיל = x.Status  }).ToList();


        }

        private void txtP_TextChanged_1(object sender, EventArgs e)
        {
            dgSearch.DataSource = tblMedician.GetList().Where(x => x.Status && x.Price.ToString()==txtP.Text).Select(x => new {
                  קוד_תרופה = x.KodM, שם_תרופה = x.NameM, מרשם = x.Mirsham,סוג_תרופה = x.ThisKindM().Teur,שם_חברה = x.ThisCompeny().NameC
                , מחיר_מספק = x.Price, מחיר_ללא_מרשם = x.PriceNo, מחיר_עם_מרשם = x.PriceYes,
                כמות = x.Amount,תאריך_תפוקה = x.DateT,פעיל = x.Status  }).ToList();

        }

        private void txtPNo_TextChanged(object sender, EventArgs e)
        {
            dgSearch.DataSource = tblMedician.GetList().Where(x => x.Status && x.PriceNo.ToString()==txtPNo.Text).Select(x => new {
                  קוד_תרופה = x.KodM, שם_תרופה = x.NameM, מרשם = x.Mirsham,סוג_תרופה = x.ThisKindM().Teur,שם_חברה = x.ThisCompeny().NameC
                , מחיר_מספק = x.Price, מחיר_ללא_מרשם = x.PriceNo, מחיר_עם_מרשם = x.PriceYes,
                כמות = x.Amount,תאריך_תפוקה = x.DateT,פעיל = x.Status  }).ToList();

        }

        private void txtPYes_TextChanged(object sender, EventArgs e)
        {dgSearch.DataSource = tblMedician.GetList().Where(x => x.Status && x.PriceYes.ToString()==txtPYes.Text).Select(x => new {
         קוד_תרופה = x.KodM, שם_תרופה = x.NameM, מרשם = x.Mirsham,סוג_תרופה = x.ThisKindM().Teur,שם_חברה = x.ThisCompeny().NameC
       , מחיר_מספק = x.Price, מחיר_ללא_מרשם = x.PriceNo, מחיר_עם_מרשם = x.PriceYes,
                כמות = x.Amount,תאריך_תפוקה = x.DateT,פעיל = x.Status  }).ToList();


        }

        private void cmbk_SelectedIndexChanged(object sender, EventArgs e)
        {dgSearch.DataSource = tblMedician.GetList().Where(x => x.Status && x.KodK==((KindM)cmbk.SelectedItem).KodK   ).Select(x => new {
                  קוד_תרופה = x.KodM, שם_תרופה = x.NameM, מרשם = x.Mirsham,סוג_תרופה = x.ThisKindM().Teur,שם_חברה = x.ThisCompeny().NameC
                , מחיר_מספק = x.Price, מחיר_ללא_מרשם = x.PriceNo, מחיר_עם_מרשם = x.PriceYes,
                כמות = x.Amount,תאריך_תפוקה = x.DateT,פעיל = x.Status  }).ToList();


        }

        private void cmbC_SelectedIndexChanged(object sender, EventArgs e)
        {dgSearch.DataSource = tblMedician.GetList().Where(x => x.Status && x.ThisCompeny().NameC == ((Compenies)cmbC.SelectedItem).NameC).Select(x => new {
                  קוד_תרופה = x.KodM, שם_תרופה = x.NameM, מרשם = x.Mirsham,סוג_תרופה = x.ThisKindM().Teur,שם_חברה = x.ThisCompeny().NameC
                , מחיר_מספק = x.Price, מחיר_ללא_מרשם = x.PriceNo, מחיר_עם_מרשם = x.PriceYes,
                כמות = x.Amount,תאריך_תפוקה = x.DateT,פעיל = x.Status  }).ToList();


        }
    
       private void chbP_CheckedChanged(object sender, EventArgs e)
        {
            dgSearch.DataSource = tblMedician.GetList().Where(x => x.Status && x.Status.Equals(chbP.Checked)).Select(x => new {
                 קוד_תרופה = x.KodM, שם_תרופה = x.NameM, מרשם = x.Mirsham,סוג_תרופה = x.ThisKindM().Teur,שם_חברה=x.ThisCompeny().NameC
                , מחיר_מספק = x.Price, מחיר_ללא_מרשם = x.PriceNo, מחיר_עם_מרשם = x.PriceYes,
                כמות = x.Amount,תאריך_תפוקה = x.DateT,פעיל = x.Status  }).ToList();

        }
        private void btnNew_Click(object sender, EventArgs e)
        {
            flagAdd = true;
            flagUpdate = false;
            txtK.ReadOnly =true;
            txtK.Text = tblMedician.GetNextKey().ToString();
            txtName.Text = "";
            txtP.Text = "";
            txtPNo.Text = "";
            txtPYes.Text = "";
            txtAmount.Text = "";
            dt.Value =DateTime.Today;
            cmbk.Text = "";
            cmbC.Text = "";
            Possible();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgSearch.SelectedRows.Count > 0)
            {
                string st = dgSearch.SelectedRows[0].Cells[0].Value.ToString();
                thisMedician = tblMedician.Find(st);
                Fill(thisMedician);
                flagUpdate = true;
                flagAdd = false;
                Possible();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            if (flagUpdate)
                if (CreateFields(thisMedician))
                {
                    DialogResult r = MessageBox.Show("אישור עידכון", "האם לעדכן  תרופה זו ", MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                    if (r == DialogResult.Yes)
                    {
                        tblMedician.UpdateRow(thisMedician);
                        txtName.Text = "";
                        txtK.Text = "";
                        txtP.Text = "";
                        txtPNo.Text = "";
                        txtPYes.Text = "";
                        txtAmount.Text = "";
                        dt.Value = DateTime.Today;
                        cmbk.Text = "";
                        cmbC.Text = "";
                        notPossible();
                    }
                }
            if (flagAdd)
            {
                Medician c = new Medician();
                if (this.tblMedician.Find(txtK.Text.ToString()) == null)
                {
                    if (CreateFields(c))
                    {
                        DialogResult r = MessageBox.Show("אישור הוספה", "האם להוסיף  תרופה זו ", MessageBoxButtons.YesNo,
                      MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                        if (r == DialogResult.Yes)
                        {
                            tblMedician.AddNew(c);
                            dgSearch.DataSource = tblMedician.GetList().Where(x => x.Status).Select(x => new {
                  קוד_תרופה = x.KodM, שם_תרופה = x.NameM, מרשם = x.Mirsham,סוג_תרופה = x.ThisKindM().Teur,שם_חברה = x.ThisCompeny().NameC
                , מחיר_מספק = x.Price, מחיר_ללא_מרשם = x.PriceNo, מחיר_עם_מרשם = x.PriceYes,
                כמות = x.Amount,תאריך_תפוקה = x.DateT,פעיל = x.Status  }).ToList();
                            notPossible();
                        }
                    }

                }

            }

        }
        private bool CreateFields(Medician c)
        {
            bool ok = true;
            errorProvider1.Clear();
            try
            {
                c.KodM = Convert.ToInt32(txtK.Text);
            }

            catch (Exception ex)
            {
                errorProvider1.SetError(txtK, ex.Message);
                ok = false;
            }
            try
            {
                c.NameM = txtName.Text;
            }

            catch (Exception ex)
            {
                errorProvider1.SetError(txtName, ex.Message);
                ok = false;
            }
            try
            {
                c.KodK =((KindM)(cmbk.SelectedItem)).KodK;

            }

            catch (Exception ex)
            {
                errorProvider1.SetError(cmbk, ex.Message);
                ok = false;
            }
            try
            {
                c.KodC = ((Compenies)(cmbC.SelectedItem)).KodC;

            }

            catch (Exception ex)
            {
                errorProvider1.SetError(cmbC, ex.Message);
                ok = false;
            }
            try
            {
                c.Price = Convert.ToDouble(txtP.Text);
            }

            catch (Exception ex)
            {
                errorProvider1.SetError(txtP, ex.Message);
                ok = false;
            }
            try
            {
                c.PriceNo = Convert.ToDouble(txtPNo.Text);
            }

            catch (Exception ex)
            {
                errorProvider1.SetError(txtP, ex.Message);
                ok = false;
            }
            try
            {
                c.PriceYes = Convert.ToDouble(txtPYes.Text);
            }

            catch (Exception ex)
            {
                errorProvider1.SetError(txtPYes, ex.Message);
                ok = false;
            }
            try
            {
                c.Amount = Convert.ToInt32(txtAmount.Text);
            }

            catch (Exception ex)
            {
                errorProvider1.SetError(txtAmount, ex.Message);
                ok = false;
            }
            try
            {
                c.DateT = dt.Value;
            }

            catch (Exception ex)
            {
                errorProvider1.SetError(dt, ex.Message);
                ok = false;
            }
            c.Status = (chbP.Checked);
            c.Mirsham =(chbM.Checked);
            return ok;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            notPossible();
            errorProvider1.Clear();
        }

        private void btnClient_Click(object sender, EventArgs e)
        {
            if (dgSearch.SelectedRows.Count > 0)
            {
                string st = dgSearch.SelectedRows[0].Cells[0].Value.ToString();
                thisMedician = tblMedician.Find(st);
                Fill(thisMedician);
            }
        }

        private void Fill(Medician p)
        {
            if (tblMedician.Size() > 0)
            {   cmbk.SelectedItem = p.ThisKindM ();
                cmbk.Text = p.ThisKindM().Teur;
                cmbC.SelectedItem = p.ThisCompeny();
                cmbC.Text = p.ThisCompeny().NameC;
                txtK.Text = p.KodM.ToString();
                txtName.Text = p.NameM.ToString();
                txtP.Text = p.Price.ToString();
                txtPYes.Text = p.PriceYes.ToString();
                txtAmount.Text = p.Amount.ToString();
                txtPNo.Text = p.PriceNo.ToString();   
                chbP.Checked = (p.Status.Equals(true));
                chbM.Checked = (p.Status.Equals(true));

            }

            else
            {
               
                txtK.Text = "";
                txtK.Text = "";
                txtName.Text = "";
                txtP.Text = "";
                txtPNo.Text = "";
                txtPYes.Text = "";
                txtAmount.Text = "";
                dt.Value = DateTime.Today;
                cmbk.Text = "";
                cmbC.Text = "";
                chbP.Checked = false;
                chbM.Checked = false;
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (dgSearch.SelectedRows.Count > 0)
            {
                DialogResult r = MessageBox.Show("אישור מחיקה", "האם למחוק תרופה זו ", MessageBoxButtons.YesNo,
                             MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);

                if (r == DialogResult.Yes)
                {
                    string st = dgSearch.SelectedRows[0].Cells[0].Value.ToString();
                    tblMedician.DeleteStatus(st);
                    dgSearch.DataSource = tblMedician.GetList().Where(x => x.Status).Select(x => new {
                        קוד_תרופה = x.KodM,
                        שם_תרופה = x.NameM,
                        מרשם = x.Mirsham,
                        סוג_תרופה = x.ThisKindM().Teur,
                        שם_חברה = x.ThisCompeny().NameC
                 ,
                        מחיר_מספק = x.Price,
                        מחיר_ללא_מרשם = x.PriceNo,
                        מחיר_עם_מרשם = x.PriceYes,
                        כמות = x.Amount,
                        תאריך_תפוקה = x.DateT,
                        פעיל = x.Status
                    }).ToList();




                }
            }
        }

        private void FrmMedician_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            flagUpdate = true;
            flagAdd = false;
            dgSearch.DataSource = tblMedician.GetList().Select(x => new {
                קוד_תרופה = x.KodM,
                שם_תרופה = x.NameM,
                מרשם = x.Mirsham,
                סוג_תרופה = x.ThisKindM().Teur,
                שם_חברה = x.ThisCompeny().NameC
                 ,
                מחיר_מספק = x.Price,
                מחיר_ללא_מרשם = x.PriceNo,
                מחיר_עם_מרשם = x.PriceYes,
                כמות = x.Amount,
                תאריך_תפוקה = x.DateT,
                פעיל = x.Status
            }).ToList();

        }
    }
}


