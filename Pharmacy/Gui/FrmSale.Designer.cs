
namespace Pharmacy.Gui
{
    partial class FrmSale
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnOkCredit = new System.Windows.Forms.Button();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtNum = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtCredit = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbPay = new System.Windows.Forms.ComboBox();
            this.btnOkPay = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnDelParit = new System.Windows.Forms.Button();
            this.dgSaleDe = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.dgSale = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnUp = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnFinish = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.dgMed = new System.Windows.Forms.DataGridView();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.chbMirsham = new System.Windows.Forms.CheckBox();
            this.dgComp = new System.Windows.Forms.DataGridView();
            this.btnOkAmount = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbPh = new System.Windows.Forms.ComboBox();
            this.dtSale = new System.Windows.Forms.DateTimePicker();
            this.txtK = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnCancle = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnDel = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.txtPay = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgSaleDe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgSale)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgMed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgComp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnOkCredit);
            this.groupBox1.Controls.Add(this.txtId);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtNum);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.dtCredit);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.groupBox1.Location = new System.Drawing.Point(16, 79);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(246, 139);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "פרטי אשראי";
            this.groupBox1.Visible = false;
            // 
            // btnOkCredit
            // 
            this.btnOkCredit.Location = new System.Drawing.Point(6, 107);
            this.btnOkCredit.Name = "btnOkCredit";
            this.btnOkCredit.Size = new System.Drawing.Size(57, 26);
            this.btnOkCredit.TabIndex = 10;
            this.btnOkCredit.Text = "ok";
            this.btnOkCredit.UseVisualStyleBackColor = true;
            this.btnOkCredit.Click += new System.EventHandler(this.btnOkCredit_Click);
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(34, 45);
            this.txtId.Multiline = true;
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(101, 21);
            this.txtId.TabIndex = 13;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label9.Location = new System.Drawing.Point(150, 48);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(95, 18);
            this.label9.TabIndex = 12;
            this.label9.Text = "תז בעל כרטיס";
            // 
            // txtNum
            // 
            this.txtNum.Location = new System.Drawing.Point(34, 24);
            this.txtNum.Multiline = true;
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(101, 18);
            this.txtNum.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label5.Location = new System.Drawing.Point(163, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 18);
            this.label5.TabIndex = 10;
            this.label5.Text = "מס אשראי";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label4.Location = new System.Drawing.Point(163, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 18);
            this.label4.TabIndex = 9;
            this.label4.Text = "תאריך תוקף";
            // 
            // dtCredit
            // 
            this.dtCredit.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtCredit.Location = new System.Drawing.Point(34, 75);
            this.dtCredit.Name = "dtCredit";
            this.dtCredit.Size = new System.Drawing.Size(101, 21);
            this.dtCredit.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label3.Location = new System.Drawing.Point(168, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 24);
            this.label3.TabIndex = 8;
            this.label3.Text = "אופן תשלום";
            // 
            // cmbPay
            // 
            this.cmbPay.FormattingEnabled = true;
            this.cmbPay.Items.AddRange(new object[] {
            "מזומן",
            "אשראי"});
            this.cmbPay.Location = new System.Drawing.Point(26, 23);
            this.cmbPay.Name = "cmbPay";
            this.cmbPay.Size = new System.Drawing.Size(129, 23);
            this.cmbPay.TabIndex = 7;
            this.cmbPay.SelectedIndexChanged += new System.EventHandler(this.cmbPay_SelectedIndexChanged);
            // 
            // btnOkPay
            // 
            this.btnOkPay.Location = new System.Drawing.Point(6, 52);
            this.btnOkPay.Name = "btnOkPay";
            this.btnOkPay.Size = new System.Drawing.Size(73, 26);
            this.btnOkPay.TabIndex = 0;
            this.btnOkPay.Text = "אישור";
            this.btnOkPay.UseVisualStyleBackColor = true;
            this.btnOkPay.Click += new System.EventHandler(this.btnOkPay_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnDelParit);
            this.panel2.Controls.Add(this.dgSaleDe);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.dgSale);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Location = new System.Drawing.Point(431, 22);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(760, 302);
            this.panel2.TabIndex = 1;
            // 
            // btnDelParit
            // 
            this.btnDelParit.Font = new System.Drawing.Font("MS PGothic", 18F);
            this.btnDelParit.Location = new System.Drawing.Point(12, 204);
            this.btnDelParit.Name = "btnDelParit";
            this.btnDelParit.Size = new System.Drawing.Size(94, 71);
            this.btnDelParit.TabIndex = 10;
            this.btnDelParit.Text = "בטל פריט ממכירה";
            this.btnDelParit.UseVisualStyleBackColor = true;
            this.btnDelParit.Click += new System.EventHandler(this.btnDelParit_Click);
            // 
            // dgSaleDe
            // 
            this.dgSaleDe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgSaleDe.Location = new System.Drawing.Point(112, 183);
            this.dgSaleDe.Name = "dgSaleDe";
            this.dgSaleDe.Size = new System.Drawing.Size(610, 101);
            this.dgSaleDe.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.Location = new System.Drawing.Point(619, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = " פרטי מכירה";
            // 
            // dgSale
            // 
            this.dgSale.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgSale.Location = new System.Drawing.Point(112, 43);
            this.dgSale.Name = "dgSale";
            this.dgSale.Size = new System.Drawing.Size(610, 99);
            this.dgSale.TabIndex = 4;
            this.dgSale.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgSale_CellContentClick);
            this.dgSale.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgSale_CellContentClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label6.Location = new System.Drawing.Point(661, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 24);
            this.label6.TabIndex = 3;
            this.label6.Text = "מכירות";
            // 
            // btnNew
            // 
            this.btnNew.Font = new System.Drawing.Font("MS PGothic", 18F);
            this.btnNew.Location = new System.Drawing.Point(455, 24);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(75, 50);
            this.btnNew.TabIndex = 9;
            this.btnNew.Text = "חדש";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnUp
            // 
            this.btnUp.Font = new System.Drawing.Font("MS PGothic", 18F);
            this.btnUp.Location = new System.Drawing.Point(226, 24);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(162, 50);
            this.btnUp.TabIndex = 8;
            this.btnUp.Text = "עדכן פרטי מכירה";
            this.btnUp.UseVisualStyleBackColor = true;
            this.btnUp.Click += new System.EventHandler(this.btnUp_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnRefresh.Font = new System.Drawing.Font("MS PGothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.Location = new System.Drawing.Point(632, 24);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 50);
            this.btnRefresh.TabIndex = 7;
            this.btnRefresh.Text = "רענן";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label13);
            this.panel3.Controls.Add(this.txtPay);
            this.panel3.Controls.Add(this.btnFinish);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.dgMed);
            this.panel3.Controls.Add(this.txtAmount);
            this.panel3.Controls.Add(this.chbMirsham);
            this.panel3.Controls.Add(this.dgComp);
            this.panel3.Controls.Add(this.btnOkAmount);
            this.panel3.Location = new System.Drawing.Point(-4, 460);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(871, 211);
            this.panel3.TabIndex = 2;
            // 
            // btnFinish
            // 
            this.btnFinish.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnFinish.Location = new System.Drawing.Point(21, 111);
            this.btnFinish.Name = "btnFinish";
            this.btnFinish.Size = new System.Drawing.Size(89, 46);
            this.btnFinish.TabIndex = 51;
            this.btnFinish.Text = "סיום";
            this.btnFinish.UseVisualStyleBackColor = true;
            this.btnFinish.Click += new System.EventHandler(this.btnFinish_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label10.Location = new System.Drawing.Point(171, 58);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(110, 24);
            this.label10.TabIndex = 10;
            this.label10.Text = "כמות לרכישה";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label12.Location = new System.Drawing.Point(548, 9);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(63, 24);
            this.label12.TabIndex = 50;
            this.label12.Text = "תרופות";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label11.Location = new System.Drawing.Point(783, 9);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(57, 24);
            this.label11.TabIndex = 11;
            this.label11.Text = "חברות";
            // 
            // dgMed
            // 
            this.dgMed.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgMed.Location = new System.Drawing.Point(295, 36);
            this.dgMed.Name = "dgMed";
            this.dgMed.Size = new System.Drawing.Size(315, 133);
            this.dgMed.TabIndex = 49;
            this.dgMed.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgMed_CellClick);
            this.dgMed.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgMed_CellContentClick);
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(93, 58);
            this.txtAmount.Multiline = true;
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(72, 29);
            this.txtAmount.TabIndex = 48;
            this.txtAmount.TextChanged += new System.EventHandler(this.txtAmount_TextChanged);
            // 
            // chbMirsham
            // 
            this.chbMirsham.AutoSize = true;
            this.chbMirsham.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.chbMirsham.Location = new System.Drawing.Point(175, 18);
            this.chbMirsham.Name = "chbMirsham";
            this.chbMirsham.Size = new System.Drawing.Size(105, 28);
            this.chbMirsham.TabIndex = 47;
            this.chbMirsham.Text = "?יש מרשם";
            this.chbMirsham.UseVisualStyleBackColor = true;
            this.chbMirsham.CheckedChanged += new System.EventHandler(this.chbMirsham_CheckedChanged);
            // 
            // dgComp
            // 
            this.dgComp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgComp.Location = new System.Drawing.Point(660, 36);
            this.dgComp.Name = "dgComp";
            this.dgComp.Size = new System.Drawing.Size(186, 133);
            this.dgComp.TabIndex = 46;
            this.dgComp.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgComp_CellContentClick);
            this.dgComp.Click += new System.EventHandler(this.dgComp_Click);
            // 
            // btnOkAmount
            // 
            this.btnOkAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnOkAmount.Location = new System.Drawing.Point(21, 58);
            this.btnOkAmount.Name = "btnOkAmount";
            this.btnOkAmount.Size = new System.Drawing.Size(43, 27);
            this.btnOkAmount.TabIndex = 45;
            this.btnOkAmount.Text = "ok";
            this.btnOkAmount.UseVisualStyleBackColor = true;
            this.btnOkAmount.Click += new System.EventHandler(this.btnOkAmount_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(284, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "קוד מכירה";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label7.Location = new System.Drawing.Point(264, 190);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 24);
            this.label7.TabIndex = 4;
            this.label7.Text = "תאריך מכירה";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label8.Location = new System.Drawing.Point(299, 239);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 24);
            this.label8.TabIndex = 5;
            this.label8.Text = "שם רוקח";
            // 
            // cmbPh
            // 
            this.cmbPh.FormattingEnabled = true;
            this.cmbPh.Location = new System.Drawing.Point(95, 244);
            this.cmbPh.Name = "cmbPh";
            this.cmbPh.Size = new System.Drawing.Size(153, 21);
            this.cmbPh.TabIndex = 6;
            this.cmbPh.SelectedIndexChanged += new System.EventHandler(this.cmbPh_SelectedIndexChanged);
            // 
            // dtSale
            // 
            this.dtSale.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtSale.Location = new System.Drawing.Point(95, 190);
            this.dtSale.Name = "dtSale";
            this.dtSale.Size = new System.Drawing.Size(153, 20);
            this.dtSale.TabIndex = 7;
            this.dtSale.ValueChanged += new System.EventHandler(this.dtSale_ValueChanged);
            // 
            // txtK
            // 
            this.txtK.Location = new System.Drawing.Point(95, 124);
            this.txtK.Multiline = true;
            this.txtK.Name = "txtK";
            this.txtK.Size = new System.Drawing.Size(153, 41);
            this.txtK.TabIndex = 8;
            this.txtK.TextChanged += new System.EventHandler(this.txtK_TextChanged);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Poor Richard", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(31, 22);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(76, 35);
            this.button1.TabIndex = 43;
            this.button1.Text = "חזור => ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btnCancle
            // 
            this.btnCancle.BackColor = System.Drawing.Color.LightGray;
            this.btnCancle.Font = new System.Drawing.Font("MS PGothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancle.Location = new System.Drawing.Point(48, 25);
            this.btnCancle.Name = "btnCancle";
            this.btnCancle.Size = new System.Drawing.Size(63, 39);
            this.btnCancle.TabIndex = 10;
            this.btnCancle.Text = "בטל";
            this.btnCancle.UseVisualStyleBackColor = false;
            this.btnCancle.Click += new System.EventHandler(this.btnCancle_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.LightGray;
            this.btnSave.Font = new System.Drawing.Font("MS PGothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(186, 23);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(65, 42);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "שמור";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox1);
            this.groupBox2.Controls.Add(this.cmbPay);
            this.groupBox2.Controls.Add(this.btnOkPay);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.groupBox2.Location = new System.Drawing.Point(873, 447);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox2.Size = new System.Drawing.Size(304, 224);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "פרטי תשלום";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnCancle);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Location = new System.Drawing.Point(47, 308);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(287, 87);
            this.panel1.TabIndex = 44;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnDel);
            this.panel4.Controls.Add(this.btnUp);
            this.panel4.Controls.Add(this.btnNew);
            this.panel4.Controls.Add(this.btnRefresh);
            this.panel4.Location = new System.Drawing.Point(431, 342);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(760, 99);
            this.panel4.TabIndex = 11;
            // 
            // btnDel
            // 
            this.btnDel.Font = new System.Drawing.Font("MS PGothic", 18F);
            this.btnDel.Location = new System.Drawing.Point(40, 24);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(119, 50);
            this.btnDel.TabIndex = 10;
            this.btnDel.Text = "בטל מכירה";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label13.Location = new System.Drawing.Point(131, 173);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(132, 24);
            this.label13.TabIndex = 52;
            this.label13.Text = "סך סופי לתשלום";
            // 
            // txtPay
            // 
            this.txtPay.Location = new System.Drawing.Point(21, 170);
            this.txtPay.Multiline = true;
            this.txtPay.Name = "txtPay";
            this.txtPay.Size = new System.Drawing.Size(104, 29);
            this.txtPay.TabIndex = 53;
            // 
            // FrmSale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(1217, 756);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtK);
            this.Controls.Add(this.dtSale);
            this.Controls.Add(this.cmbPh);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label1);
            this.Name = "FrmSale";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "FomOrder";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmSale_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgSaleDe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgSale)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgMed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgComp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgSaleDe;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgSale;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbPh;
        private System.Windows.Forms.DateTimePicker dtSale;
        private System.Windows.Forms.TextBox txtK;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbPay;
        private System.Windows.Forms.Button btnOkPay;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnUp;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtCredit;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtNum;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox chbMirsham;
        private System.Windows.Forms.DataGridView dgComp;
        private System.Windows.Forms.Button btnOkAmount;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button btnFinish;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridView dgMed;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnCancle;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnDelParit;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnOkCredit;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtPay;
    }
}