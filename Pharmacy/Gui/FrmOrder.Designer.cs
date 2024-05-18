
namespace Pharmacy.Gui
{
    partial class FrmOrder
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
            this.button1 = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnUpAspaka = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnUp = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCancle = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtK = new System.Windows.Forms.TextBox();
            this.dtOrder = new System.Windows.Forms.DateTimePicker();
            this.cmbCom = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnFinish = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.dgMed = new System.Windows.Forms.DataGridView();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.btnOkAmount = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnDelParit = new System.Windows.Forms.Button();
            this.dgOrderDe = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.dgOrder = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSapak = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.chbSopak = new System.Windows.Forms.CheckBox();
            this.dtAspaka = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgMed)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgOrderDe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Poor Richard", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(1095, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(72, 36);
            this.button1.TabIndex = 43;
            this.button1.Text = "חזור => ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnUpAspaka);
            this.panel4.Controls.Add(this.btnDel);
            this.panel4.Controls.Add(this.btnUp);
            this.panel4.Controls.Add(this.btnNew);
            this.panel4.Controls.Add(this.btnRefresh);
            this.panel4.Location = new System.Drawing.Point(71, 304);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(760, 90);
            this.panel4.TabIndex = 53;
            // 
            // btnUpAspaka
            // 
            this.btnUpAspaka.Font = new System.Drawing.Font("MS PGothic", 18F);
            this.btnUpAspaka.Location = new System.Drawing.Point(40, 24);
            this.btnUpAspaka.Name = "btnUpAspaka";
            this.btnUpAspaka.Size = new System.Drawing.Size(126, 50);
            this.btnUpAspaka.TabIndex = 11;
            this.btnUpAspaka.Text = "עדכן אספקה ";
            this.btnUpAspaka.UseVisualStyleBackColor = true;
            this.btnUpAspaka.Click += new System.EventHandler(this.btnUpAspaka_Click);
            // 
            // btnDel
            // 
            this.btnDel.Font = new System.Drawing.Font("MS PGothic", 18F);
            this.btnDel.Location = new System.Drawing.Point(199, 24);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(119, 50);
            this.btnDel.TabIndex = 10;
            this.btnDel.Text = "בטל הזמנה";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnUp
            // 
            this.btnUp.Font = new System.Drawing.Font("MS PGothic", 18F);
            this.btnUp.Location = new System.Drawing.Point(360, 24);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(151, 50);
            this.btnUp.TabIndex = 8;
            this.btnUp.Text = "עדכן פרטי הזמנה";
            this.btnUp.UseVisualStyleBackColor = true;
            this.btnUp.Click += new System.EventHandler(this.btnUp_Click);
            // 
            // btnNew
            // 
            this.btnNew.Font = new System.Drawing.Font("MS PGothic", 18F);
            this.btnNew.Location = new System.Drawing.Point(553, 24);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(75, 50);
            this.btnNew.TabIndex = 9;
            this.btnNew.Text = "חדש";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnRefresh.Font = new System.Drawing.Font("MS PGothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.Location = new System.Drawing.Point(666, 24);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 50);
            this.btnRefresh.TabIndex = 7;
            this.btnRefresh.Text = "רענן";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnCancle);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Location = new System.Drawing.Point(917, 304);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(188, 76);
            this.panel1.TabIndex = 55;
            // 
            // btnCancle
            // 
            this.btnCancle.BackColor = System.Drawing.Color.LightGray;
            this.btnCancle.Font = new System.Drawing.Font("MS PGothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancle.Location = new System.Drawing.Point(13, 22);
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
            this.btnSave.Location = new System.Drawing.Point(101, 22);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(65, 42);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "שמור";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtK
            // 
            this.txtK.Location = new System.Drawing.Point(883, 81);
            this.txtK.Multiline = true;
            this.txtK.Name = "txtK";
            this.txtK.Size = new System.Drawing.Size(135, 24);
            this.txtK.TabIndex = 52;
            this.txtK.TextChanged += new System.EventHandler(this.txtK_TextChanged);
            // 
            // dtOrder
            // 
            this.dtOrder.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtOrder.Location = new System.Drawing.Point(883, 124);
            this.dtOrder.Name = "dtOrder";
            this.dtOrder.Size = new System.Drawing.Size(135, 20);
            this.dtOrder.TabIndex = 51;
            this.dtOrder.ValueChanged += new System.EventHandler(this.dtSale_ValueChanged);
            // 
            // cmbCom
            // 
            this.cmbCom.FormattingEnabled = true;
            this.cmbCom.Location = new System.Drawing.Point(883, 193);
            this.cmbCom.Name = "cmbCom";
            this.cmbCom.Size = new System.Drawing.Size(135, 21);
            this.cmbCom.TabIndex = 50;
            this.cmbCom.SelectedIndexChanged += new System.EventHandler(this.cmbCom_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label8.Location = new System.Drawing.Point(1039, 193);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 24);
            this.label8.TabIndex = 49;
            this.label8.Text = "שם חברה";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label7.Location = new System.Drawing.Point(1028, 120);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(114, 24);
            this.label7.TabIndex = 48;
            this.label7.Text = "תאריך הזמנה";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnFinish);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Controls.Add(this.dgMed);
            this.panel3.Controls.Add(this.txtAmount);
            this.panel3.Controls.Add(this.btnOkAmount);
            this.panel3.Location = new System.Drawing.Point(210, 424);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(820, 194);
            this.panel3.TabIndex = 47;
            // 
            // btnFinish
            // 
            this.btnFinish.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnFinish.Location = new System.Drawing.Point(19, 134);
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
            this.label12.Location = new System.Drawing.Point(627, 9);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(63, 24);
            this.label12.TabIndex = 50;
            this.label12.Text = "תרופות";
            // 
            // dgMed
            // 
            this.dgMed.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgMed.Location = new System.Drawing.Point(308, 36);
            this.dgMed.Name = "dgMed";
            this.dgMed.Size = new System.Drawing.Size(425, 133);
            this.dgMed.TabIndex = 49;
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(93, 58);
            this.txtAmount.Multiline = true;
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(72, 29);
            this.txtAmount.TabIndex = 48;
            // 
            // btnOkAmount
            // 
            this.btnOkAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnOkAmount.Location = new System.Drawing.Point(107, 99);
            this.btnOkAmount.Name = "btnOkAmount";
            this.btnOkAmount.Size = new System.Drawing.Size(43, 27);
            this.btnOkAmount.TabIndex = 45;
            this.btnOkAmount.Text = "ok";
            this.btnOkAmount.UseVisualStyleBackColor = true;
            this.btnOkAmount.Click += new System.EventHandler(this.btnOkAmount_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnDelParit);
            this.panel2.Controls.Add(this.dgOrderDe);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.dgOrder);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Location = new System.Drawing.Point(87, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(725, 275);
            this.panel2.TabIndex = 46;
            // 
            // btnDelParit
            // 
            this.btnDelParit.Font = new System.Drawing.Font("MS PGothic", 18F);
            this.btnDelParit.Location = new System.Drawing.Point(40, 171);
            this.btnDelParit.Name = "btnDelParit";
            this.btnDelParit.Size = new System.Drawing.Size(94, 71);
            this.btnDelParit.TabIndex = 10;
            this.btnDelParit.Text = "בטל פריט מהזמנה";
            this.btnDelParit.UseVisualStyleBackColor = true;
            this.btnDelParit.Click += new System.EventHandler(this.btnDelParit_Click);
            // 
            // dgOrderDe
            // 
            this.dgOrderDe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgOrderDe.Location = new System.Drawing.Point(153, 162);
            this.dgOrderDe.Name = "dgOrderDe";
            this.dgOrderDe.Size = new System.Drawing.Size(518, 101);
            this.dgOrderDe.TabIndex = 6;
            
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.Location = new System.Drawing.Point(603, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = " פרטי הזמנה";
            // 
            // dgOrder
            // 
            this.dgOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgOrder.Location = new System.Drawing.Point(153, 38);
            this.dgOrder.Name = "dgOrder";
            this.dgOrder.Size = new System.Drawing.Size(501, 94);
            this.dgOrder.TabIndex = 4;
            this.dgOrder.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgOrder_CellContentClick);
            this.dgOrder.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgOrder_CellContentClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label6.Location = new System.Drawing.Point(645, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 24);
            this.label6.TabIndex = 3;
            this.label6.Text = "הזמנות";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(1037, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 24);
            this.label1.TabIndex = 45;
            this.label1.Text = "קוד הזמנה";
            // 
            // txtSapak
            // 
            this.txtSapak.Location = new System.Drawing.Point(881, 230);
            this.txtSapak.Multiline = true;
            this.txtSapak.Name = "txtSapak";
            this.txtSapak.Size = new System.Drawing.Size(137, 24);
            this.txtSapak.TabIndex = 57;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label13.Location = new System.Drawing.Point(1039, 230);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(70, 24);
            this.label13.TabIndex = 56;
            this.label13.Text = "שם ספק";
            // 
            // chbSopak
            // 
            this.chbSopak.AutoSize = true;
            this.chbSopak.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.chbSopak.Location = new System.Drawing.Point(953, 269);
            this.chbSopak.Name = "chbSopak";
            this.chbSopak.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chbSopak.Size = new System.Drawing.Size(87, 29);
            this.chbSopak.TabIndex = 59;
            this.chbSopak.Text = "?סופק";
            this.chbSopak.UseVisualStyleBackColor = true;
            // 
            // dtAspaka
            // 
            this.dtAspaka.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtAspaka.Location = new System.Drawing.Point(883, 162);
            this.dtAspaka.Name = "dtAspaka";
            this.dtAspaka.Size = new System.Drawing.Size(135, 20);
            this.dtAspaka.TabIndex = 61;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label3.Location = new System.Drawing.Point(1028, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 24);
            this.label3.TabIndex = 60;
            this.label3.Text = "תאריך אספקה";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FrmOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(1192, 660);
            this.Controls.Add(this.dtAspaka);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.chbSopak);
            this.Controls.Add(this.txtSapak);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtK);
            this.Controls.Add(this.dtOrder);
            this.Controls.Add(this.cmbCom);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "FrmOrder";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "FomSale";
            this.panel4.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgMed)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgOrderDe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnUp;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCancle;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtK;
        private System.Windows.Forms.DateTimePicker dtOrder;
        private System.Windows.Forms.ComboBox cmbCom;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnFinish;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridView dgMed;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Button btnOkAmount;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnDelParit;
        private System.Windows.Forms.DataGridView dgOrderDe;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgOrder;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSapak;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.CheckBox chbSopak;
        private System.Windows.Forms.DateTimePicker dtAspaka;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button btnUpAspaka;
    }
}