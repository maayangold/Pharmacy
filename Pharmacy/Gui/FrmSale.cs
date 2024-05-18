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
    public partial class FrmSale : Form
    {
        private SalesDB tblSale;
        private SaleDetailsDB tblSaledetails;
        private PharmecistDB tblPharmecist;
        private MedicianDB tblmedician;
        private KindMDB tblKind;
        private CompeniesDB tblCompeny;
        private bool flagAdd;
        private bool flagUpdate;
        private Sales thisSale;
        private SaleDetails thisSaleDetails;
        private Medician thisMedician;

        public FrmSale()
        {
            InitializeComponent();
            tblSale = new SalesDB();
            tblSaledetails = new SaleDetailsDB();
            tblPharmecist = new PharmecistDB();

            cmbPh.DataSource = tblPharmecist.GetList();
            tblmedician = new MedicianDB();
            tblKind = new KindMDB();
            tblCompeny = new CompeniesDB();
            thisSale = new Sales();
            thisSaleDetails = new SaleDetails();
            flagAdd = false;
            flagUpdate = false;
            dgComp.DataSource = tblCompeny.GetList().Select(x => new { קוד_חברה = x.KodC, שם_חברה = x.NameC }).ToList();
            dgSaleDe.DataSource = null;
            dgSale.DataSource = null;
            dgMed.DataSource = null;
            notPossible();

        }

        private void notPossible()
        {
            flagAdd = false;
            flagUpdate = false;
            panel2.Visible = true;
            panel1.Visible = false;
            panel4.Visible = true;
            panel3.Visible = false;
            btnDelParit.Visible = false;
            groupBox2.Visible = false;
            txtK.ReadOnly = false;
            cmbPh.Text = "";

        }



        private void Possible()
        {
            panel2.Visible =false;
            panel1.Visible = true;
            panel4.Visible = false;
            txtK.ReadOnly = true;
            cmbPh.Enabled = true;


        }
        private void txtK_TextChanged(object sender, EventArgs e)
        {
            dgSale.DataSource = tblSale.GetList().Where(x => x.KodSale.ToString().StartsWith(txtK.Text)).Select(x => new { קוד_מכירה = x.KodSale, תאריך_מכירה = x.DateSale, שם_רוקח = x.ThisPharmecist().Name, סך_סופי = x.PriceAll }).ToList();

        }


        private void cmbPh_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgSale.DataSource = tblSale.GetList().Where(x => x.KodPh ==((Pharmecist) cmbPh.SelectedItem).KodPh).Select(x => new { קוד_מכירה = x.KodSale, תאריך_מכירה = x.DateSale, שם_רוקח = x.ThisPharmecist().Name, סך_סופי = x.PriceAll }).ToList();
        }

        private void dtSale_ValueChanged(object sender, EventArgs e)
        {
            dgSale.DataSource = tblSale.GetList().Where(x => x.DateSale == DateTime.Today).Select(x => new { קוד_מכירה = x.KodSale, תאריך_מכירה = x.DateSale, שם_רוקח = x.ThisPharmecist().Name, סך_סופי = x.PriceAll }).ToList();

        }
        private void btnNew_Click(object sender, EventArgs e)
        {
            flagAdd = true;
            flagUpdate = false;
            txtK.ReadOnly = true;
            txtK.Text = tblSale.GetNextKey().ToString();
            dtSale.Value = DateTime.Today;
            cmbPh.DataSource = tblPharmecist.GetList();
            txtPay.Text = "0";
            Possible();


        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            dgSale.DataSource = tblSale.GetList().Select(x => new { קוד_מכירה = x.KodSale, תאריך_מכירה = x.DateSale, שם_רוקח = x.ThisPharmecist().Name, סך_סופי = x.PriceAll }).ToList();
            dgSaleDe.DataSource = null;
            notPossible();
        }

        private void btnUp_Click(object sender, EventArgs e)
          
        {
            if (SelectDG(dgSale))
            {
                thisSale = tblSale.Find(dgSale.SelectedRows[0].Cells[0].Value.ToString());
                btnDelParit.Visible = true;
                errorProvider1.Clear();
                dgSaleDe.DataSource = tblSaledetails.GetList().Where(x => x.KodSale == thisSale.KodSale).Select(x => new { קוד_מכירה = x.KodSale, תרופה = x.ThisMedician().NameM, מרשם = x.Mirsham, כמות = x.Amount, מחיר = x.Price }).ToList();
                panel3.Visible = true;
                groupBox1.Visible = true;
                
            }

        }
        private void ClearControl()
        {
            txtK.Text = "";
            dtSale.Value = DateTime.Today;
            cmbPh.Text = "";
            txtNum.Text = "";
            dgSaleDe.DataSource = null;
            btnDelParit.Visible = false;
            txtK.ReadOnly = false;
            panel3.Visible = false;

        }
        private bool SelectDG(DataGridView dg)
        {
            return (dg.SelectedRows.Count >= 1);

        }
        

        private void Fill(SaleDetails sd)
        {
            double mechir = 0;
            bool f = Convert.ToBoolean(dgMed.SelectedRows[0].Cells[2].Value.ToString());
            double yes = Convert.ToDouble(dgMed.SelectedRows[0].Cells[4].Value.ToString());
            double no = Convert.ToDouble(dgMed.SelectedRows[0].Cells[5].Value.ToString());
            if (f == true)
                mechir = Convert.ToInt32(txtAmount.Text) * yes;
            if (f == false)
                mechir = Convert.ToInt32(txtAmount.Text) * no;
            sd.KodSale = thisSaleDetails.KodSale;
            sd.KodM = thisSaleDetails.KodM;
            sd.Amount = Convert.ToInt32(txtNum.Text);
            sd.Price = mechir;
        }
        private void UpdateDG()
        {
           
                dgSaleDe.DataSource = null;
                dgSale.DataSource = tblSale.GetList().Select(x => new { קוד_מכירה = x.KodSale, תאריך_מכירה = x.DateSale, שם_רוקח = x.ThisPharmecist().Name, סך_סופי = x.PriceAll }).ToList();
            
        }

        private void dgSale_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (SelectDG(dgSale))
            {
               
                thisSale = tblSale.Find(dgSale.SelectedRows[0].Cells[0].Value.ToString());
                dgSaleDe.DataSource = tblSaledetails.GetList().Where(x => x.KodSale == thisSale.KodSale).Select(x => new { קוד_מכירה = x.KodSale, תרופה = x.ThisMedician().NameM, מרשם = x.Mirsham, כמות = x.Amount, מחיר = x.Price }).ToList();
                panel3.Visible = false;
            }
        }

        private void btnOkAmount_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            bool ok = true;
            string stK;
            int camut=0;
            if (SelectDG(dgMed))
            {
                stK = dgMed.SelectedRows[0].Cells[0].Value.ToString();
                thisMedician = tblmedician.Find(stK);
                if (txtAmount.Text == "")
                {
                    errorProvider1.SetError(txtAmount, " בחר כמות");
                    ok = false;

                }
                else
                camut = Convert.ToInt32(txtAmount.Text);

                if(thisMedician.Mirsham && !chbMirsham.Checked)
                {
                    errorProvider1.SetError(chbMirsham, "תרופה זו דורשת מרשם");
                    ok = false;
                }
                


                if (camut > thisMedician.Amount)
                {
                    errorProvider1.SetError(dgMed, "כמות שנמכרה חורגת מהמלאי");
                    ok = false;
                }
                if (tblSaledetails.Find(thisSale.KodSale.ToString(), thisMedician.KodM.ToString()) != null)
                {
                    errorProvider1.SetError(dgMed, "פריט זה כבר קיים במכירה");
                    ok = false;
                }


                if (ok)
                {
                    string st1 = thisSale.KodSale.ToString();
                    thisSaleDetails = new SaleDetails();
                    thisSaleDetails.KodSale = Convert.ToInt32(st1);
                    thisSaleDetails.KodM = thisMedician.KodM;
                    thisSaleDetails.Mirsham = chbMirsham.Checked;
                    thisSaleDetails.Amount = Convert.ToInt32(txtAmount.Text);

                    if (chbMirsham.Checked)
                        thisSaleDetails.Price = camut * thisMedician.PriceYes;
                    else
                        thisSaleDetails.Price = camut * thisMedician.PriceNo;
                    tblSaledetails.AddNew(thisSaleDetails);
                    dgSaleDe.DataSource = tblSaledetails.GetList().Where(x => x.KodSale == thisSale.KodSale).Select(x => new { קוד_מכירה = x.KodSale, תרופה = x.ThisMedician().NameM, מרשם = x.Mirsham, כמות = x.Amount, מחיר = x.Price }).ToList();
                   
                    UpdateMelay(thisSaleDetails, "minus");
                    double sum = tblSaledetails.GetList().Where(x => x.KodSale == thisSale.KodSale).Sum(x => x.Price);

                    thisSale.PriceAll = sum;
                    tblSale.UpdateRow(thisSale);
                    txtPay.Text = sum.ToString();

                }
            }
           else
            {
                ok = false;
                errorProvider1.SetError(dgMed, "בחר תרופה ");
                
            }
            
        }



        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (flagUpdate)
                if (CreateFields(thisSale))
                {
                    DialogResult r = MessageBox.Show("אישור עידכון", "האם לעדכן  מכירה זו ", MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                    if (r == DialogResult.Yes)
                    {
                        tblSale.UpdateRow(thisSale);
                        txtK.Text = "";
                        cmbPh.Text = "";
                        notPossible();
                    }
                }
            if (flagAdd)
            {
                Sales c = new Sales();

                if (CreateFields(c))
                {
                    DialogResult r = MessageBox.Show("אישור הוספה", "האם להוסיף  מכירה זו ", MessageBoxButtons.YesNo,
                  MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                    if (r == DialogResult.Yes)
                    {
                        tblSale.AddNew(c);
                        dgSale.DataSource = tblSale.GetList().Where(x => x.KodSale == c.KodSale).Select(x => new { קוד_מכירה = x.KodSale, תאריך_מכירה = x.DateSale, שם_רוקח = x.ThisPharmecist().Name, סך_סופי = x.PriceAll }).ToList();
                        dgSaleDe.DataSource = tblSaledetails.GetList().Where(x => x.KodSale == c.KodSale).Select(x => new { קוד_מכירה = x.KodSale, תרופה = x.ThisMedician().NameM, מרשם = x.Mirsham, כמות = x.Amount, מחיר = x.Price }).ToList();
                        notPossible();
                        thisSale = tblSale.Find(c.KodSale.ToString());
                    }
                    else
                        notPossible();
                }


            }

        }


        private bool CreateFields(Sales c)
        {
            bool ok = true;
            errorProvider1.Clear();
            try
            {
                c.KodSale = Convert.ToInt32(txtK.Text);
            }

            catch (Exception ex)
            {
                errorProvider1.SetError(txtK, ex.Message);
                ok = false;
            }
            try
            {
                c.KodPh = ((Pharmecist)cmbPh.SelectedItem).KodPh;
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(cmbPh, ex.Message);
                ok = false;
            } 

            try

            {
                c.DateSale = dtSale.Value;
            }

            catch (Exception ex1)
            {
                errorProvider1.SetError(dtSale, ex1.Message);
                ok = false;
            }
            c.PriceAll = 0;
            return ok;
        }

        private void dgComp_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {                            
            if (SelectDG(dgComp))
            {
                string st = dgComp.SelectedRows[0].Cells[0].Value.ToString();
                dgMed.DataSource = tblmedician.GetList().Where(x => x.KodC.ToString() == st && x.Status==true).Select(x => new { קוד_תרופה = x.KodM, שם_תרופה = x.NameM, מרשם = x.Mirsham, סוג_תרופה = x.ThisKindM().Teur, עלות_עם_מרשם = x.PriceYes, עלות_ללא_מרשם = x.PriceNo }).ToList();

            }
        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            notPossible();
            txtK.Text = "";
            cmbPh.Text = "";
            errorProvider1.Clear();
            if (SelectDG(dgSale))
            {
                string st = dgSale.SelectedRows[0].Cells[0].Value.ToString();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool f = false;
            if (thisSale.PriceAll == 0)
            {
                DialogResult r = MessageBox.Show("שגיאת  יציאה , אין פריטים במכירה     ", "האם לבטל  מכירה זו ", MessageBoxButtons.YesNo,
                       MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                if (r == DialogResult.Yes)
                {
                    tblSale.DeleteRow(thisSale.KodSale.ToString());
                    f = true;
                }
                
            }
            if (f)
                 this.Hide();
           
        }

        private void dgComp_Click(object sender, EventArgs e)
        {
            if (SelectDG(dgComp))
            {
                string st = dgComp.SelectedRows[0].Cells[0].Value.ToString();
                dgMed.DataSource = tblmedician.GetList().Where(x => x.KodC.ToString() == st).Select(x => new { קוד_תרופה = x.KodM, שם_תרופה = x.NameM, מרשם = x.Mirsham, סוג_תרופה = x.ThisKindM().Teur, עלות_עם_מרשם = x.PriceYes, עלות_ללא_מרשם = x.PriceNo }).ToList();

            }
        }

        private void txtAmount_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
        }

        private void btnDelParit_Click(object sender, EventArgs e)
        {
            if (SelectDG(dgSaleDe))
            {
                String st1 = dgSaleDe.SelectedRows[0].Cells[0].Value.ToString();
                string st2 = dgSaleDe.SelectedRows[0].Cells[1].Value.ToString();
                string st3 = (tblmedician.GetList().Find(x => x.NameM == st2)).KodM.ToString();
                thisSaleDetails = tblSaledetails.Find(st1, st3);
                UpdateMelay(thisSaleDetails, "plus");
                tblSaledetails.DeleteRow(st1, st3);
                UpdateDG();
                double sum = tblSaledetails.GetList().Where(x => x.KodSale == thisSale.KodSale).Sum(x => x.Price);
                thisSale.PriceAll = sum;
                tblSale.UpdateRow(thisSale);
                txtPay.Text = sum.ToString();
                dgSale.DataSource = tblSale.GetList().Where(x => x.KodSale == thisSale.KodSale).Select(x => new { קוד_מכירה = x.KodSale, תאריך_מכירה = x.DateSale, שם_רוקח = x.ThisPharmecist().Name, סך_סופי = x.PriceAll }).ToList();
                dgSaleDe.DataSource = tblSaledetails.GetList().Where(x => x.KodSale == thisSale.KodSale).Select(x => new { קוד_מכירה = x.KodSale, תרופה = x.ThisMedician().NameM, מרשם = x.Mirsham, כמות = x.Amount, מחיר = x.Price }).ToList();
            }

        }
        private void UpdateMelay(SaleDetails od, string p)
        {
            thisMedician = tblmedician.Find(od.KodM.ToString());
            if (p == "plus")
            {
                thisMedician.Amount += od.Amount;
                tblmedician.UpdateRow(thisMedician);
            }
            if (p == "minus")
            {
                thisMedician.Amount -= od.Amount;
                tblmedician.UpdateRow(thisMedician);
            }

        }
        private void btnFinish_Click(object sender, EventArgs e)
        {

            panel3.Visible = false;
            groupBox2.Visible = true;
            groupBox1.Visible = false;


            double sum=tblSaledetails.GetList().Where(x=>x.KodSale==thisSale.KodSale).Sum(x=>x.Price);
           
            thisSale.PriceAll = sum;
            tblSale.UpdateRow(thisSale);
            dgSale.DataSource = tblSale.GetList().Where(x => x.KodSale == thisSale.KodSale).Select(x => new { קוד_מכירה = x.KodSale, תאריך_מכירה = x.DateSale, שם_רוקח = x.ThisPharmecist().Name, סך_סופי = x.PriceAll }).ToList();
            dgSaleDe.DataSource = tblSaledetails.GetList().Where(x => x.KodSale == thisSale.KodSale).Select(x => new { קוד_מכירה = x.KodSale, תרופה = x.ThisMedician().NameM, מרשם = x.Mirsham, כמות = x.Amount, מחיר = x.Price }).ToList();
            
           
        }

        private void btnOkPay_Click(object sender, EventArgs e)

        {    if(cmbPay.Text == "מזומן")
            {
                thisSale.OfenP = cmbPay.Text.ToString();
                tblSale.UpdateRow(thisSale);
                UpdateDG();
                dgSale.DataSource = tblSale.GetList().Where(x => x.KodSale == thisSale.KodSale).Select(x => new { קוד_מכירה = x.KodSale, תאריך_מכירה = x.DateSale, שם_רוקח = x.ThisPharmecist().Name, סך_סופי = x.PriceAll }).ToList();
                groupBox2.Visible = false;
                notPossible();
            }
      
            
        }

        private void btnOkCredit_Click(object sender, EventArgs e)
        {
            bool ok = true;
            errorProvider1.Clear();
            try
            {
                thisSale.Num = Convert.ToInt32(txtNum.Text);
            }

            catch (Exception ex)
            {
                errorProvider1.SetError(txtNum, ex.Message);
                ok = false;
            }
            try
            {
                thisSale.Id =txtId.Text;
            }

            catch (Exception ex)
            {
                errorProvider1.SetError(txtId, ex.Message);
                ok = false;
            }
            try
            {
                thisSale.DateTokef = dtCredit.Value;
            }

            catch (Exception ex)
            {
                errorProvider1.SetError(dtCredit, ex.Message);
                ok = false;
            }
            if (ok == true)
            {
                thisSale.OfenP = cmbPay.Text.ToString();
                tblSale.UpdateRow(thisSale);
                UpdateDG();
                dgSale.DataSource = tblSale.GetList().Where(x => x.KodSale == thisSale.KodSale).Select(x => new { קוד_מכירה = x.KodSale, תאריך_מכירה = x.DateSale, שם_רוקח = x.ThisPharmecist().Name, סך_סופי = x.PriceAll }).ToList();
                notPossible();
            }

        }

   
        private void btnDel_Click(object sender, EventArgs e)
        {
            if (SelectDG(dgSale))
            {
                thisSale = tblSale.Find(dgSale.SelectedRows[0].Cells[0].Value.ToString());
                tblSale.DeleteRow(thisSale.KodSale.ToString());

                UpdateDG();
            }
        }

        private void dgMed_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            errorProvider1.Clear();

        }

        private void cmbPay_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbPay.Text == "מזומן") 
            { 
                groupBox1.Visible = false;
            btnOkPay.Visible = true;
           }
            if (cmbPay.Text == "אשראי")
            {
                groupBox1.Visible = true;
                btnOkPay.Visible = false;
            }
                

        }

        private void chbMirsham_CheckedChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
        }

        private void dgMed_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            errorProvider1.Clear();
        }

        private void FrmSale_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (thisSale.PriceAll == 0)
            {
                DialogResult r = MessageBox.Show("שגיאת  יציאה , אין פריטים במכירה     ", "האם לבטל  מכירה זו ", MessageBoxButtons.YesNo,
                       MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                if (r == DialogResult.Yes)
                {
                    tblSale.DeleteRow(thisSale.KodSale.ToString());

                }
                else
                    e.Cancel = true;
            }
        }
    }

} 
  


      
       
        
