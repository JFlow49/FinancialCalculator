namespace Assignment3
{
    partial class frmAssignment3
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
            this.tcMain = new System.Windows.Forms.TabControl();
            this.tpCalculator = new System.Windows.Forms.TabPage();
            this.txtInterestPaid = new System.Windows.Forms.TextBox();
            this.txtPaymentTotal = new System.Windows.Forms.TextBox();
            this.txtNumberOfPayments = new System.Windows.Forms.TextBox();
            this.txtMonthlyPayment = new System.Windows.Forms.TextBox();
            this.txtFixedInterestRate = new System.Windows.Forms.TextBox();
            this.txtLoanAmount = new System.Windows.Forms.TextBox();
            this.cmbYears = new System.Windows.Forms.ComboBox();
            this.btnCalculatePayment = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tpDialogs = new System.Windows.Forms.TabPage();
            this.pnlFont = new System.Windows.Forms.Panel();
            this.lblFont = new System.Windows.Forms.Label();
            this.btnFont = new System.Windows.Forms.Button();
            this.pnlColor = new System.Windows.Forms.Panel();
            this.btnChooseColor = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.tcMain.SuspendLayout();
            this.tpCalculator.SuspendLayout();
            this.tpDialogs.SuspendLayout();
            this.pnlFont.SuspendLayout();
            this.pnlColor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // tcMain
            // 
            this.tcMain.Controls.Add(this.tpCalculator);
            this.tcMain.Controls.Add(this.tpDialogs);
            this.tcMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcMain.Location = new System.Drawing.Point(0, 0);
            this.tcMain.Name = "tcMain";
            this.tcMain.SelectedIndex = 0;
            this.tcMain.Size = new System.Drawing.Size(1302, 1009);
            this.tcMain.TabIndex = 0;
            // 
            // tpCalculator
            // 
            this.tpCalculator.Controls.Add(this.txtInterestPaid);
            this.tpCalculator.Controls.Add(this.txtPaymentTotal);
            this.tpCalculator.Controls.Add(this.txtNumberOfPayments);
            this.tpCalculator.Controls.Add(this.txtMonthlyPayment);
            this.tpCalculator.Controls.Add(this.txtFixedInterestRate);
            this.tpCalculator.Controls.Add(this.txtLoanAmount);
            this.tpCalculator.Controls.Add(this.cmbYears);
            this.tpCalculator.Controls.Add(this.btnCalculatePayment);
            this.tpCalculator.Controls.Add(this.label7);
            this.tpCalculator.Controls.Add(this.label6);
            this.tpCalculator.Controls.Add(this.label5);
            this.tpCalculator.Controls.Add(this.label4);
            this.tpCalculator.Controls.Add(this.label3);
            this.tpCalculator.Controls.Add(this.label2);
            this.tpCalculator.Controls.Add(this.label1);
            this.tpCalculator.Location = new System.Drawing.Point(4, 29);
            this.tpCalculator.Name = "tpCalculator";
            this.tpCalculator.Padding = new System.Windows.Forms.Padding(3);
            this.tpCalculator.Size = new System.Drawing.Size(1294, 976);
            this.tpCalculator.TabIndex = 0;
            this.tpCalculator.Text = "Financial Calculator";
            this.tpCalculator.UseVisualStyleBackColor = true;
            this.tpCalculator.Click += new System.EventHandler(this.tpCalculator_Click);
            // 
            // txtInterestPaid
            // 
            this.txtInterestPaid.Enabled = false;
            this.txtInterestPaid.Location = new System.Drawing.Point(334, 610);
            this.txtInterestPaid.Name = "txtInterestPaid";
            this.txtInterestPaid.ReadOnly = true;
            this.txtInterestPaid.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtInterestPaid.Size = new System.Drawing.Size(231, 26);
            this.txtInterestPaid.TabIndex = 7;
            // 
            // txtPaymentTotal
            // 
            this.txtPaymentTotal.Enabled = false;
            this.txtPaymentTotal.Location = new System.Drawing.Point(334, 542);
            this.txtPaymentTotal.Name = "txtPaymentTotal";
            this.txtPaymentTotal.ReadOnly = true;
            this.txtPaymentTotal.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtPaymentTotal.Size = new System.Drawing.Size(231, 26);
            this.txtPaymentTotal.TabIndex = 6;
            // 
            // txtNumberOfPayments
            // 
            this.txtNumberOfPayments.Enabled = false;
            this.txtNumberOfPayments.Location = new System.Drawing.Point(334, 471);
            this.txtNumberOfPayments.Name = "txtNumberOfPayments";
            this.txtNumberOfPayments.ReadOnly = true;
            this.txtNumberOfPayments.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtNumberOfPayments.Size = new System.Drawing.Size(231, 26);
            this.txtNumberOfPayments.TabIndex = 5;
            // 
            // txtMonthlyPayment
            // 
            this.txtMonthlyPayment.Enabled = false;
            this.txtMonthlyPayment.Location = new System.Drawing.Point(334, 391);
            this.txtMonthlyPayment.Name = "txtMonthlyPayment";
            this.txtMonthlyPayment.ReadOnly = true;
            this.txtMonthlyPayment.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtMonthlyPayment.Size = new System.Drawing.Size(231, 26);
            this.txtMonthlyPayment.TabIndex = 4;
            // 
            // txtFixedInterestRate
            // 
            this.txtFixedInterestRate.Location = new System.Drawing.Point(334, 147);
            this.txtFixedInterestRate.Name = "txtFixedInterestRate";
            this.txtFixedInterestRate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtFixedInterestRate.Size = new System.Drawing.Size(231, 26);
            this.txtFixedInterestRate.TabIndex = 1;
            this.txtFixedInterestRate.Text = "0.0";
            this.txtFixedInterestRate.Validated += new System.EventHandler(this.txtFixedInterestRate_Validated);
            // 
            // txtLoanAmount
            // 
            this.txtLoanAmount.Location = new System.Drawing.Point(334, 74);
            this.txtLoanAmount.Name = "txtLoanAmount";
            this.txtLoanAmount.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtLoanAmount.Size = new System.Drawing.Size(231, 26);
            this.txtLoanAmount.TabIndex = 0;
            this.txtLoanAmount.Text = "0.00";
            this.txtLoanAmount.Validating += new System.ComponentModel.CancelEventHandler(this.txtLoanAmount_Validating);
            // 
            // cmbYears
            // 
            this.cmbYears.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbYears.FormattingEnabled = true;
            this.cmbYears.Items.AddRange(new object[] {
            "5",
            "10",
            "15",
            "20",
            "25",
            "30"});
            this.cmbYears.Location = new System.Drawing.Point(334, 209);
            this.cmbYears.Name = "cmbYears";
            this.cmbYears.Size = new System.Drawing.Size(231, 28);
            this.cmbYears.TabIndex = 2;
            // 
            // btnCalculatePayment
            // 
            this.btnCalculatePayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculatePayment.Location = new System.Drawing.Point(268, 285);
            this.btnCalculatePayment.Name = "btnCalculatePayment";
            this.btnCalculatePayment.Size = new System.Drawing.Size(363, 56);
            this.btnCalculatePayment.TabIndex = 3;
            this.btnCalculatePayment.Text = "Calculate Payment";
            this.btnCalculatePayment.UseVisualStyleBackColor = true;
            this.btnCalculatePayment.Click += new System.EventHandler(this.btnCalculatePayment_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(67, 610);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "Interest Paid:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(67, 542);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Payment Total";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(67, 471);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(161, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Number of Payments:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(67, 398);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Monthly Payment:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(67, 218);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Years:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(67, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Fixed Interest Rate:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Loan Amount:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // tpDialogs
            // 
            this.tpDialogs.Controls.Add(this.pnlFont);
            this.tpDialogs.Controls.Add(this.pnlColor);
            this.tpDialogs.Location = new System.Drawing.Point(4, 29);
            this.tpDialogs.Name = "tpDialogs";
            this.tpDialogs.Padding = new System.Windows.Forms.Padding(3);
            this.tpDialogs.Size = new System.Drawing.Size(1294, 976);
            this.tpDialogs.TabIndex = 1;
            this.tpDialogs.Text = "Dialogs";
            this.tpDialogs.UseVisualStyleBackColor = true;
            // 
            // pnlFont
            // 
            this.pnlFont.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlFont.Controls.Add(this.lblFont);
            this.pnlFont.Controls.Add(this.btnFont);
            this.pnlFont.Location = new System.Drawing.Point(517, 26);
            this.pnlFont.Name = "pnlFont";
            this.pnlFont.Size = new System.Drawing.Size(430, 209);
            this.pnlFont.TabIndex = 1;
            // 
            // lblFont
            // 
            this.lblFont.AutoSize = true;
            this.lblFont.Location = new System.Drawing.Point(49, 153);
            this.lblFont.Name = "lblFont";
            this.lblFont.Size = new System.Drawing.Size(322, 20);
            this.lblFont.TabIndex = 1;
            this.lblFont.Text = "The quick brown fox jumps over the lazy dog,";
            // 
            // btnFont
            // 
            this.btnFont.Location = new System.Drawing.Point(137, 65);
            this.btnFont.Name = "btnFont";
            this.btnFont.Size = new System.Drawing.Size(187, 69);
            this.btnFont.TabIndex = 0;
            this.btnFont.Text = "Choose Font";
            this.btnFont.UseVisualStyleBackColor = true;
            this.btnFont.Click += new System.EventHandler(this.btnFont_Click);
            // 
            // pnlColor
            // 
            this.pnlColor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlColor.Controls.Add(this.btnChooseColor);
            this.pnlColor.Location = new System.Drawing.Point(31, 26);
            this.pnlColor.Name = "pnlColor";
            this.pnlColor.Size = new System.Drawing.Size(410, 209);
            this.pnlColor.TabIndex = 0;
            // 
            // btnChooseColor
            // 
            this.btnChooseColor.Location = new System.Drawing.Point(108, 88);
            this.btnChooseColor.Name = "btnChooseColor";
            this.btnChooseColor.Size = new System.Drawing.Size(184, 44);
            this.btnChooseColor.TabIndex = 0;
            this.btnChooseColor.Text = "Choose Color";
            this.btnChooseColor.UseVisualStyleBackColor = true;
            this.btnChooseColor.Click += new System.EventHandler(this.btnChooseColor_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmAssignment3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1302, 1009);
            this.Controls.Add(this.tcMain);
            this.Name = "frmAssignment3";
            this.Text = "Assignment 3";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tcMain.ResumeLayout(false);
            this.tpCalculator.ResumeLayout(false);
            this.tpCalculator.PerformLayout();
            this.tpDialogs.ResumeLayout(false);
            this.pnlFont.ResumeLayout(false);
            this.pnlFont.PerformLayout();
            this.pnlColor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcMain;
        private System.Windows.Forms.TabPage tpCalculator;
        private System.Windows.Forms.TabPage tpDialogs;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtInterestPaid;
        private System.Windows.Forms.TextBox txtPaymentTotal;
        private System.Windows.Forms.TextBox txtNumberOfPayments;
        private System.Windows.Forms.TextBox txtMonthlyPayment;
        private System.Windows.Forms.TextBox txtFixedInterestRate;
        private System.Windows.Forms.TextBox txtLoanAmount;
        private System.Windows.Forms.ComboBox cmbYears;
        private System.Windows.Forms.Button btnCalculatePayment;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Panel pnlColor;
        private System.Windows.Forms.Button btnChooseColor;
        private System.Windows.Forms.Panel pnlFont;
        private System.Windows.Forms.Label lblFont;
        private System.Windows.Forms.Button btnFont;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.FontDialog fontDialog1;
    }
}

