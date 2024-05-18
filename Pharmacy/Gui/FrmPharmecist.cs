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
    public partial class FrmPharmecist : Form
    {
        private PharmecistDB tblPharmecist;
        private Pharmecist thisPharmecist;
        private bool flagAdd;
        private bool flagUpdate;



        public FrmPharmecist()
        {
            InitializeComponent();
            tblPharmecist = new PharmecistDB();
            flagAdd = false;
            flagUpdate = false;
            dgSearch.DataSource = tblPharmecist.GetList().Where(x => x.Status).Select(x => new { תז = x.KodPh, פלאפון = x.PelPh, שם_רוקח = x.Name, פעיל = x.Status }
              ).ToList();


            notPossible();
        }
        private void Possible()
        {
            panel2.Visible = true;
            panel1.Visible = false;
            txtK.ReadOnly = false;
            txtPel.ReadOnly = false;
            txtName.ReadOnly = false;
        }
        private void notPossible()
        {
            flagAdd = false;
            txtK.ReadOnly = true;
            panel2.Visible = false;
            panel1.Visible = true;
            txtK.ReadOnly = true;
            txtPel.ReadOnly = false;
            txtName.ReadOnly = false;
        }



        private void btnRefresh_Click(object sender, EventArgs e)
        {
            dgSearch.DataSource = tblPharmecist.GetList().Where(x => x.Status).Select(x => new { תז = x.KodPh, פלאפון = x.PelPh, שם_רוקח = x.Name, פעיל = x.Status }
                ).ToList();
        }
        private void txtK_TextChanged(object sender, EventArgs e)
        {
            dgSearch.DataSource = tblPharmecist.GetList().Where(x => x.KodPh.ToString().StartsWith(txtK.Text)).Select(x => new { תז = x.KodPh, פלאפון = x.PelPh, שם_רוקח = x.Name, פעיל = x.Status }
            ).ToList();

        }
        private void txtName_TextChanged(object sender, EventArgs e)
        {
            dgSearch.DataSource = tblPharmecist.GetList().Where(x => x.Name.StartsWith(txtName.Text)).Select(x => new { תז = x.KodPh, פלאפון = x.PelPh, שם_רוקח = x.Name, פעיל = x.Status }
                        ).ToList();

        }
        private void txtPel_TextChanged(object sender, EventArgs e)
        {
            dgSearch.DataSource = tblPharmecist.GetList().Where(x => x.PelPh.StartsWith(txtPel.Text)).Select(x => new { תז = x.KodPh, פלאפון = x.PelPh, שם_רוקח = x.Name, פעיל = x.Status }
             ).ToList();


        }
        private void chbP_CheckedChanged(object sender, EventArgs e)
        {
            dgSearch.DataSource = tblPharmecist.GetList().Where(x => x.Status.Equals(chbP.Checked)).Select(x => new { תז = x.KodPh, פלאפון = x.PelPh, שם_רוקח = x.Name, פעיל = x.Status }
             ).ToList();

        }
        private void btnNew_Click(object sender, EventArgs e)
        {
            flagAdd = true;
            flagUpdate = false;
            txtK.ReadOnly = false;
            txtK.Text = tblPharmecist.GetNextKey().ToString(); ;
            txtPel.Text = "";
            chbP.Checked = true;
            Possible();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgSearch.SelectedRows.Count > 0)
            {
                string st = dgSearch.SelectedRows[0].Cells[0].Value.ToString();
                thisPharmecist = tblPharmecist.Find(st);
                Fill(thisPharmecist);
                flagUpdate = true;
                flagAdd = false;
                Possible();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            if (flagUpdate)
                if (CreateFields(thisPharmecist))
                {
                    DialogResult r = MessageBox.Show("אישור עידכון", "האם לעדכן רוקח זה ", MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                    if (r == DialogResult.Yes)
                    {
                        tblPharmecist.UpdateRow(thisPharmecist);
                        dgSearch.DataSource = tblPharmecist.GetList().Where(x => x.Status.Equals(chbP.Checked)).Select(x => new { תז = x.KodPh, פלאפון = x.PelPh, שם_רוקח = x.Name, פעיל = x.Status }
                    ).ToList();
                        txtK.Text = "";
                        txtPel.Text = "";
                        txtName.Text = "";

                        notPossible();
                    }
                }
            if (flagAdd)
            {
                Pharmecist c = new Pharmecist();
                if (this.tblPharmecist.Find(txtK.Text.ToString()) == null)
                {
                    if (CreateFields(c))
                    {
                        DialogResult r = MessageBox.Show("אישור הוספה", "האם להוסיף רוקח זה ", MessageBoxButtons.YesNo,
                      MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                        if (r == DialogResult.Yes)
                        {
                            tblPharmecist.AddNew(c);
                            dgSearch.DataSource = tblPharmecist.GetList().Where(x => x.Status.Equals(chbP.Checked)).Select(x => new { תז = x.KodPh, פלאפון = x.PelPh, שם_רוקח = x.Name, פעיל = x.Status }).ToList();


                            notPossible();
                        }
                    }

                }

            }




        }
        private bool CreateFields(Pharmecist c)
        {
            bool ok = true;
            errorProvider1.Clear();
            try
            {
                c.KodPh = Convert.ToInt32(txtK.Text);
            }

            catch (Exception ex)
            {
                errorProvider1.SetError(txtK, ex.Message);
                ok = false;
            }
            try
            {
                c.Name = txtName.Text;
            }

            catch (Exception ex)
            {
                errorProvider1.SetError(txtName, ex.Message);
                ok = false;
            }


            try
            {
                c.PelPh = txtPel.Text;
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
            txtPel.Text = "";
            txtName.Text = "";
            errorProvider1.Clear();
        }

        private void btnClient_Click(object sender, EventArgs e)
        {
            if (dgSearch.SelectedRows.Count > 0)
            {
                string st = dgSearch.SelectedRows[0].Cells[0].Value.ToString();
                thisPharmecist = tblPharmecist.Find(st);
                Fill(thisPharmecist);
            }
        }

        private void Fill(Pharmecist p)
        {
            if (tblPharmecist.Size() > 0)
            {
                txtK.Text = p.KodPh.ToString();
                txtName.Text = p.Name.ToString();
                txtPel.Text = p.PelPh.ToString();
                chbP.Checked = (p.Status.Equals(true));

            }

            else
            {
                txtK.Text = "";

                txtPel.Text = "";
                chbP.Checked = false;

            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (dgSearch.SelectedRows.Count > 0)
            {
                DialogResult r = MessageBox.Show("אישור מחיקה", "האם למחוק לקוח זה ", MessageBoxButtons.YesNo,
                             MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);

                if (r == DialogResult.Yes)
                {
                    string st = dgSearch.SelectedRows[0].Cells[0].Value.ToString();
                    tblPharmecist.DeleteStatus(st);

                }
            }
        }

        private void FrmPharmecist_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            flagUpdate = true;
            flagAdd = false;
            dgSearch.DataSource = tblPharmecist.GetList().Select(x => new { תז = x.KodPh, פלאפון = x.PelPh, שם_רוקח = x.Name, פעיל = x.Status }
             ).ToList();
        }
    }
}