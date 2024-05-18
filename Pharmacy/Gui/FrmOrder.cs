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
    public partial class FrmOrder : Form
    {
        private OrdersDB tblOrder;
        private OrderDetailsDB tblOrderdetails;
        private PharmecistDB tblPharmecist;
        private MedicianDB tblmedician;
        private KindMDB tblKind;
        private CompeniesDB tblCompeny;
        private bool flagAdd;
        private bool flagUpdate;
        private Orders thisOrder;
        private OrderDetails thisOrderDetails;
        private Medician thisMedician;
        public FrmOrder()
        {

            InitializeComponent();
            tblOrder = new OrdersDB();
            tblOrderdetails = new OrderDetailsDB();
            tblCompeny = new CompeniesDB();
            thisOrder = new Orders();
            thisOrderDetails = new OrderDetails();

            tblmedician = new MedicianDB();
            tblKind = new KindMDB();
            tblCompeny = new CompeniesDB();
            txtSapak.Text = "";
            cmbCom.Text = "";
            flagAdd = false;
            flagUpdate = false;
            //dgComp.DataSource = tblCompeny.GetList().Select(x => new { קוד_חברה = x.KodC, שם_חברה = x.NameC }).ToList();
            dgOrderDe.DataSource = null;
            dgOrder.DataSource = null;
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
            txtK.ReadOnly = false;
            cmbCom.Text = "";
        }



        private void Possible()
        {
            panel2.Visible = false;
            panel1.Visible = true;
            panel4.Visible = false;
            panel3.Visible = false;
            txtK.ReadOnly = true;
            cmbCom.Enabled = true;

        }


        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        private bool SelectDG(DataGridView dg)
        {
            return (dg.SelectedRows.Count >= 1);

        }


       
        private void UpdateDG()
        {

            dgOrderDe.DataSource = null;
            dgOrder.DataSource = tblOrder.GetList().Select(x => new { קוד_הזמנה = x.KodO, תאריך_הזמנה = x.DateO, שם_חברה = x.ThisCompeny().NameC, סך_סופי = x.PriceAll }).ToList();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            dgOrder.DataSource = tblOrder.GetList().Select(x => new { קוד_הזמנה = x.KodO, תאריך_הזמנה = x.DateO, שם_חברה = x.ThisCompeny().NameC, סך_סופי = x.PriceAll }).ToList();
            dgOrderDe.DataSource = null;
            notPossible();
        }
        private void btnDel_Click(object sender, EventArgs e)
        {
            if (SelectDG(dgOrder))
            {
                tblOrder.DeleteRow(thisOrder.KodO.ToString());

                UpdateDG();
            }
        }

        private void txtK_TextChanged(object sender, EventArgs e)
        {
            dgOrder.DataSource = tblOrder.GetList().Where(x => x.KodO.ToString().StartsWith(txtK.Text)).Select(x => new { קוד_הזמנה = x.KodO, תאריך_הזמנה = x.DateO, שם_חברה = x.ThisCompeny().NameC, סך_סופי = x.PriceAll }).ToList();
        }



        private void cmbCom_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtSapak.Text = ((Compenies)cmbCom.SelectedItem).NameP;
        }

        private void dtSale_ValueChanged(object sender, EventArgs e)
        {
            dtAspaka.Value = dtOrder.Value.AddDays(14);

        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            flagAdd = true;
            flagUpdate = false;
            txtK.ReadOnly = true;
            txtK.Text = tblOrder.GetNextKey().ToString();
            dtOrder.Value = DateTime.Today;
            cmbCom.DataSource = tblCompeny.GetList();
            txtSapak.Text = ((Compenies)cmbCom.SelectedItem).NameP;
            txtSapak.ReadOnly = true;
            
            Possible();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (flagUpdate)
                if (CreateFields(thisOrder))
                {
                    DialogResult r = MessageBox.Show("אישור עידכון", "האם לעדכן  מכירה זו ", MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                    if (r == DialogResult.Yes)
                    {
                        tblOrder.UpdateRow(thisOrder);
                        //txtK.Text = "";
                        //cmbCom.Text = "";
                        notPossible();
                    }
                }
            if (flagAdd)
            {
                Orders c = new Orders();

                if (CreateFields(c))
                {
                    DialogResult r = MessageBox.Show("אישור הוספה", "האם להוסיף  מכירה זו ", MessageBoxButtons.YesNo,
                  MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                    if (r == DialogResult.Yes)
                    {
                        tblOrder.AddNew(c);
                        dgOrder.DataSource = tblOrder.GetList().Where(x => x.KodO == c.KodO).Select(x => new { קוד_הזמנה = x.KodO, תאריך_הזמנה = x.DateO, שם_חברה = x.ThisCompeny().NameC, סך_סופי = x.PriceAll }).ToList();
                        dgOrderDe.DataSource = null;
                        notPossible();
                        thisOrder = tblOrder.Find(c.KodO.ToString());
                    }
                    else
                        notPossible();
                }


            }

        }

        private bool CreateFields(Orders c)
        {
            bool ok = true;
            errorProvider1.Clear();
            try
            {
                c.KodO = Convert.ToInt32(txtK.Text);
            }

            catch (Exception ex)
            {
                errorProvider1.SetError(txtK, ex.Message);
                ok = false;
            }
            try
            {
                c.KodC = ((Compenies)cmbCom.SelectedItem).KodC;
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(cmbCom, ex.Message);
                ok = false;
            }

            try

            {
                c.DateO = dtOrder.Value;
            }

            catch (Exception ex1)
            {
                errorProvider1.SetError(dtOrder, ex1.Message);
                ok = false;
            }
            c.PriceAll = 0;
            return ok;
        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            notPossible();
            txtK.Text = "";
            cmbCom.Text = "";
            errorProvider1.Clear();

        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            if (SelectDG(dgOrder))
            {
                btnDelParit.Visible = true;
                dgOrderDe.DataSource = tblOrderdetails.GetList().Where(x => x.KodO == thisOrderDetails.KodO).Select(x => new { קוד_הזמנה = x.KodO, תרופה = x.ThisMedician().NameM,כמות = x.Amount, מחיר = x.Price }).ToList();
                panel3.Visible = true;
                string st = dgOrder.SelectedRows[0].Cells[2].Value.ToString();
                int kodC=tblCompeny.GetList().FirstOrDefault(x => x.NameC == st).KodC;
                dgMed.DataSource = tblmedician.GetList().Where(x => x.KodC == kodC).Select(x => new { קוד_תרופה = x.KodM, שם_תרופה = x.NameM, מרשם = x.Mirsham, סוג_תרופה = x.ThisKindM().Teur, עלות_מספק = x.Price}).ToList();


            }
        }

        private void btnOkAmount_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            bool ok = true;
            string stK;
            int camut = 0;
            if (SelectDG(dgMed))
            {
                stK = dgMed.SelectedRows[0].Cells[0].Value.ToString();
                thisMedician = tblmedician.Find(stK);
                try
                {
                    camut = Convert.ToInt32(txtAmount.Text);

                }
                catch
                {
                    errorProvider1.SetError(dgMed, "לא נבחרה כמות מספרית");
                    ok = false;

                }
               
              
               
                if (tblOrderdetails.Find(thisOrder.KodO.ToString(), thisMedician.KodM.ToString()) != null)
                {
                    errorProvider1.SetError(dgMed, "פריט זה כבר קיים בהזמנה");
                    ok = false;
                }


                if (ok)
                {
                    string st1 = thisOrder.KodO.ToString();
                    thisOrderDetails = new OrderDetails();
                    thisOrderDetails.KodO = Convert.ToInt32(st1);
                    thisOrderDetails.KodM = thisMedician.KodM;
                    thisOrderDetails.Amount = Convert.ToInt32(txtAmount.Text);

                    double num = Convert.ToDouble(dgMed.SelectedRows[0].Cells[4].Value.ToString());
                    thisOrderDetails.Price = Convert.ToInt32(txtAmount.Text) * num;
                    tblOrderdetails.AddNew(thisOrderDetails);

                    dgOrderDe.DataSource = tblOrderdetails.GetList().Where(x => x.KodO == thisOrder.KodO).Select(x => new { קוד_הזמנה = x.KodO, תרופה = x.ThisMedician().NameM, כמות = x.Amount, מחיר = x.Price }).ToList();



                }
            }
            else
            {
                
                errorProvider1.SetError(txtAmount, "בחר תרופה וקבע כמות מספרית לרכישה");
                txtAmount.Text = "";
            }

        }
        private void UpdateMelay(OrderDetails od, string p)
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
        private void btnUpAspaka_Click(object sender, EventArgs e)
        {
            if (SelectDG(dgOrder))
            {
                chbSopak.Checked = true;
                dtAspaka.Value = DateTime.Today;
                UpdateMelay(thisOrderDetails, "plus");
                notPossible();
            }
            
        }

        private void dgOrder_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (SelectDG(dgOrder))
            {

                thisOrder = tblOrder.Find(dgOrder.SelectedRows[0].Cells[0].Value.ToString());
                dgOrderDe.DataSource = tblOrderdetails.GetList().Where(x => x.KodO == thisOrder.KodO).Select(x => new {  קוד_הזמנה = x.KodO, תרופה = x.ThisMedician().NameM,כמות = x.Amount, מחיר = x.Price }).ToList();
            }
        }

        private void btnFinish_Click(object sender, EventArgs e)
        {
            panel3.Visible = false;
            double sum = tblOrderdetails.GetList().Where(x => x.KodO == thisOrder.KodO).Sum(x => x.Price);
            thisOrder.PriceAll = sum;
            tblOrder.UpdateRow(thisOrder);
            dgOrder.DataSource = tblOrder.GetList().Where(x => x.KodO == thisOrder.KodO).Select(x => new { קוד_הזמנה = x.KodO, תאריך_הזמנה = x.DateO, שם_חברה = x.ThisCompeny().NameC, סך_סופי = x.PriceAll }).ToList();
            dgOrderDe.DataSource = tblOrderdetails.GetList().Where(x => x.KodO == thisOrder.KodO).Select(x => new { קוד_הזמנה = x.KodO, תרופה = x.ThisMedician().NameM, כמות = x.Amount, מחיר = x.Price }).ToList();
            

        }

        private void btnDelParit_Click(object sender, EventArgs e)
        {
            if (SelectDG(dgOrderDe))
            {
                String st1 = dgOrderDe.SelectedRows[0].Cells[0].Value.ToString();
                string st2 = dgOrderDe.SelectedRows[0].Cells[1].Value.ToString();
                string st3 = (tblmedician.GetList().Find(x => x.NameM == st2)).KodM.ToString();
                thisOrderDetails = tblOrderdetails.Find(st1, st3);
                
                tblOrderdetails.DeleteRow(st1, st3);
                UpdateDG();
                double sum = tblOrderdetails.GetList().Where(x => x.KodO == thisOrder.KodO).Sum(x => x.Price);
                thisOrder.PriceAll = sum;
                tblOrder.UpdateRow(thisOrder);
                dgOrder.DataSource = tblOrder.GetList().Where(x => x.KodO == thisOrder.KodO).Select(x => new { קוד_הזמנה = x.KodO, תאריך_הזמנה = x.DateO, שם_חברה = x.ThisCompeny().NameC, סך_סופי = x.PriceAll }).ToList();
                dgOrderDe.DataSource = tblOrderdetails.GetList().Where(x => x.KodO == thisOrder.KodO).Select(x => new { קוד_הזמנה = x.KodO, תרופה = x.ThisMedician().NameM, כמות = x.Amount, מחיר = x.Price }).ToList();
            }

        }

       
    }

}
