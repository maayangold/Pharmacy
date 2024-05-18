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
    public partial class FrmCompeny : Form
    {
        private CompeniesDB tblCompenies;
        private Compenies thisCompenies;
        private bool flagAdd;
        private bool flagUpdate;



        public FrmCompeny()
        {
            InitializeComponent();
            tblCompenies = new CompeniesDB();
            flagAdd = false;
            flagUpdate = false;
             dgSearch.DataSource = tblCompenies.GetList().Where(x=> x.Status).Select(x => new{קוד_חברה = x.KodC,שם_חברה =x.NameC,שם_ספק =x.NameP
             ,פלאפון = x.Pel,  פעיל = x.Status }).ToList();
            notPossible();
        }
        private void Possible()
        {
            panel2.Visible = true;
            panel1.Visible = false;
            txtK.ReadOnly = true;
            txtPel.ReadOnly = false;
            txtNane.ReadOnly = false;
            txtP.ReadOnly = false;

        }
        private void notPossible()
        {
            flagAdd = false;
            panel2.Visible = false;
            panel1.Visible = true;
            txtK.ReadOnly = false;
            txtPel.ReadOnly = false;
            txtNane.ReadOnly = false;
            txtP.ReadOnly = false;
             
        }



        private void btnRefresh_Click(object sender, EventArgs e)
        {
            dgSearch.DataSource = tblCompenies.GetList().Where(x=> x.Status).Select(x => new{קוד_חברה = x.KodC,שם_חברה =x.NameC,שם_ספק =x.NameP
             ,פלאפון = x.Pel,  פעיל = x.Status }).ToList();
          
              

        }
        private void txtK_TextChanged(object sender, EventArgs e)
        {
            dgSearch.DataSource = tblCompenies.GetList().Where(x =>x.Status&& x.KodC.ToString().StartsWith(txtK.Text)).Select(x => new {
                קוד_חברה = x.KodC, שם_חברה = x.NameC, שם_ספק = x.NameP ,פלאפון = x.Pel,  פעיל = x.Status }).ToList(); 

        }

        private void txtPel_TextChanged(object sender, EventArgs e)
        {
            dgSearch.DataSource = tblCompenies.GetList().Where(x => x.Status && x.Pel.StartsWith(txtP.Text)).Select(x => new {
                קוד_חברה = x.KodC,  שם_חברה = x.NameC,   שם_ספק = x.NameP, פלאפון = x.Pel,  פעיל = x.Status}).ToList();

         }

        private void txtNane_TextChanged(object sender, EventArgs e)
        {dgSearch.DataSource = tblCompenies.GetList().Where(x => x.Status && x.NameC.StartsWith(txtNane.Text)).Select(x => new {
                קוד_חברה = x.KodC,  שם_חברה = x.NameC,   שם_ספק = x.NameP, פלאפון = x.Pel,  פעיל = x.Status}).ToList();


        }

        private void txtP_TextChanged(object sender, EventArgs e)
        {
            dgSearch.DataSource = tblCompenies.GetList().Where(x => x.Status && x.NameP.StartsWith(txtP.Text)).Select(x => new {
                קוד_חברה = x.KodC,  שם_חברה = x.NameC,   שם_ספק = x.NameP, פלאפון = x.Pel,  פעיל = x.Status}).ToList();

        }



        private void chbP_CheckedChanged(object sender, EventArgs e)
        {
            dgSearch.DataSource = tblCompenies.GetList().Where(x => x.Status && x.Status.Equals(chbP.Checked)).Select(x => new {  
            קוד_חברה = x.KodC, שם_חברה = x.NameC, שם_ספק = x.NameP, פלאפון = x.Pel, פעיל = x.Status }).ToList();

    }
        private void btnNew_Click(object sender, EventArgs e)
        {
            flagAdd = true;
            flagUpdate = false;
            txtK.ReadOnly = false;
            txtK.Text = tblCompenies.GetNextKey().ToString();
            txtPel.Text = "";
            chbP.Checked = true;
            Possible();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgSearch.SelectedRows.Count > 0)
            {
                string st = dgSearch.SelectedRows[0].Cells[0].Value.ToString();
                thisCompenies = tblCompenies.Find(st);
                Fill(thisCompenies);
                flagUpdate = true;
                flagAdd = false;
                Possible();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            if (flagUpdate)
                if (CreateFields(thisCompenies))
                {
                    DialogResult r = MessageBox.Show("אישור עידכון", "האם לעדכן חברה זו ", MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                    if (r == DialogResult.Yes)
                    {
                        tblCompenies.UpdateRow(thisCompenies);
                        txtK.Text = "";
                        txtNane.Text = "";
                        txtPel.Text = "";
                        txtP.Text = "";
                        notPossible();
                    }
                }
            if (flagAdd)
            {
                Compenies c = new Compenies();
                if (this.tblCompenies.Find(txtK.Text.ToString()) == null)
                {
                    if (CreateFields(c))
                    {
                        DialogResult r = MessageBox.Show("אישור הוספה", "האם להוסיף חברה זו ", MessageBoxButtons.YesNo,
                      MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                        if (r == DialogResult.Yes)
                        {
                            tblCompenies.AddNew(c);
                             dgSearch.DataSource = tblCompenies.GetList().Where(x => x.Status.Equals(chbP.Checked)).Select(x => new {  
                       קוד_חברה = x.KodC, שם_חברה = x.NameC, שם_ספק = x.NameP, פלאפון = x.Pel, פעיל = x.Status }).ToList();
                            notPossible();
                        }
                    }

                }

            }

        }
        private bool CreateFields(Compenies c)
        {
            bool ok = true;
            errorProvider1.Clear();
            try
            {
                c.KodC = Convert.ToInt32(txtK.Text);
            }

            catch (Exception ex)
            {
                errorProvider1.SetError(txtK, ex.Message);
                ok = false;
            }
            try
            {
                c.NameC = txtNane.Text;
            }

            catch (Exception ex)
            {
                errorProvider1.SetError(txtNane, ex.Message);
                ok = false;
            }
            try
            {
                c.NameP = txtP.Text;
            }

            catch (Exception ex)
            {
                errorProvider1.SetError(txtP, ex.Message);
                ok = false;
            }
            try
            {
                c.Pel = txtPel.Text;
            }

            catch (Exception ex)
            {
                errorProvider1.SetError(txtPel, ex.Message);
                ok = false;
            }
            c.Status = (chbP.Checked == true);
            return ok;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            notPossible();
            txtK.Text = "";
            txtNane.Text = "";
            txtPel.Text = "";
            txtP.Text = "";
            errorProvider1.Clear();
        }

        private void btnClient_Click(object sender, EventArgs e)
        {
            if (dgSearch.SelectedRows.Count > 0)
            {
                string st = dgSearch.SelectedRows[0].Cells[0].Value.ToString();
                thisCompenies = tblCompenies.Find(st);
                Fill(thisCompenies);
            }
        }

        private void Fill(Compenies p)
        {
            if (tblCompenies.Size() > 0)
            {
                txtK.Text = p.KodC.ToString();
                txtNane.Text = p.NameC.ToString();
                txtP.Text = p.NameP.ToString();
                txtPel.Text = p.Pel.ToString();
                chbP.Checked = (p.Status.Equals(true));

            }

            else
            {
                txtK.Text = "";
                txtNane.Text = "";
                txtP.Text = "";
                txtPel.Text = "";
                chbP.Checked = false;

            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (dgSearch.SelectedRows.Count > 0)
            {
                DialogResult r = MessageBox.Show("אישור מחיקה", "האם למחוק חברה זו ", MessageBoxButtons.YesNo,
                             MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);

                if (r == DialogResult.Yes)
                {
                    string st = dgSearch.SelectedRows[0].Cells[0].Value.ToString();
                    tblCompenies.DeleteStatus(st);

                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            dgSearch.DataSource = tblCompenies.GetList().Select(x => new{קוד_חברה = x.KodC,שם_חברה =x.NameC,שם_ספק =x.NameP
             ,פלאפון = x.Pel,  פעיל = x.Status }).ToList();
          
        }

        private void FrmCompeny_Load(object sender, EventArgs e)
        {

        }
    }
}

