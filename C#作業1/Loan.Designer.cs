namespace C_作業1
{
    partial class Loan
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
            this.labLoan = new System.Windows.Forms.Label();
            this.labRate = new System.Windows.Forms.Label();
            this.labInstallment = new System.Windows.Forms.Label();
            this.txtLoan = new System.Windows.Forms.TextBox();
            this.txtRate = new System.Windows.Forms.TextBox();
            this.txtInstallment = new System.Windows.Forms.TextBox();
            this.btnRepayMonth = new System.Windows.Forms.Button();
            this.btnRepayAll = new System.Windows.Forms.Button();
            this.btnReport = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labLoan
            // 
            this.labLoan.AutoSize = true;
            this.labLoan.Font = new System.Drawing.Font("新細明體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labLoan.Location = new System.Drawing.Point(204, 99);
            this.labLoan.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labLoan.Name = "labLoan";
            this.labLoan.Size = new System.Drawing.Size(197, 40);
            this.labLoan.TabIndex = 0;
            this.labLoan.Text = "貸款金額 :";
            // 
            // labRate
            // 
            this.labRate.AutoSize = true;
            this.labRate.Font = new System.Drawing.Font("新細明體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labRate.Location = new System.Drawing.Point(213, 190);
            this.labRate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labRate.Name = "labRate";
            this.labRate.Size = new System.Drawing.Size(188, 40);
            this.labRate.TabIndex = 1;
            this.labRate.Text = "年利率% :";
            // 
            // labInstallment
            // 
            this.labInstallment.AutoSize = true;
            this.labInstallment.Font = new System.Drawing.Font("新細明體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labInstallment.Location = new System.Drawing.Point(135, 284);
            this.labInstallment.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labInstallment.Name = "labInstallment";
            this.labInstallment.Size = new System.Drawing.Size(263, 40);
            this.labInstallment.TabIndex = 2;
            this.labInstallment.Text = "貸款期數(月) :";
            // 
            // txtLoan
            // 
            this.txtLoan.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.txtLoan.Font = new System.Drawing.Font("新細明體", 24F);
            this.txtLoan.Location = new System.Drawing.Point(451, 95);
            this.txtLoan.Margin = new System.Windows.Forms.Padding(4);
            this.txtLoan.Name = "txtLoan";
            this.txtLoan.Size = new System.Drawing.Size(332, 55);
            this.txtLoan.TabIndex = 3;
            this.txtLoan.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLoan_KeyPress);
            // 
            // txtRate
            // 
            this.txtRate.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.txtRate.Font = new System.Drawing.Font("新細明體", 24F);
            this.txtRate.Location = new System.Drawing.Point(451, 190);
            this.txtRate.Margin = new System.Windows.Forms.Padding(4);
            this.txtRate.Name = "txtRate";
            this.txtRate.Size = new System.Drawing.Size(332, 55);
            this.txtRate.TabIndex = 4;
            this.txtRate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRate_KeyPress);
            // 
            // txtInstallment
            // 
            this.txtInstallment.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.txtInstallment.Font = new System.Drawing.Font("新細明體", 24F);
            this.txtInstallment.Location = new System.Drawing.Point(451, 280);
            this.txtInstallment.Margin = new System.Windows.Forms.Padding(4);
            this.txtInstallment.Name = "txtInstallment";
            this.txtInstallment.Size = new System.Drawing.Size(332, 55);
            this.txtInstallment.TabIndex = 5;
            this.txtInstallment.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtInstallment_KeyPress);
            // 
            // btnRepayMonth
            // 
            this.btnRepayMonth.Font = new System.Drawing.Font("新細明體", 24F);
            this.btnRepayMonth.Location = new System.Drawing.Point(51, 409);
            this.btnRepayMonth.Margin = new System.Windows.Forms.Padding(4);
            this.btnRepayMonth.Name = "btnRepayMonth";
            this.btnRepayMonth.Size = new System.Drawing.Size(319, 92);
            this.btnRepayMonth.TabIndex = 6;
            this.btnRepayMonth.Text = "每月應還金額";
            this.btnRepayMonth.UseVisualStyleBackColor = true;
            this.btnRepayMonth.Click += new System.EventHandler(this.btnRepayMonth_Click);
            // 
            // btnRepayAll
            // 
            this.btnRepayAll.Font = new System.Drawing.Font("新細明體", 24F);
            this.btnRepayAll.Location = new System.Drawing.Point(377, 409);
            this.btnRepayAll.Margin = new System.Windows.Forms.Padding(4);
            this.btnRepayAll.Name = "btnRepayAll";
            this.btnRepayAll.Size = new System.Drawing.Size(319, 92);
            this.btnRepayAll.TabIndex = 7;
            this.btnRepayAll.Text = "應還總金額";
            this.btnRepayAll.UseVisualStyleBackColor = true;
            this.btnRepayAll.Click += new System.EventHandler(this.btnRepayAll_Click);
            // 
            // btnReport
            // 
            this.btnReport.Font = new System.Drawing.Font("新細明體", 24F);
            this.btnReport.Location = new System.Drawing.Point(704, 409);
            this.btnReport.Margin = new System.Windows.Forms.Padding(4);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(319, 92);
            this.btnReport.TabIndex = 8;
            this.btnReport.Text = "明細報表";
            this.btnReport.UseVisualStyleBackColor = true;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // Loan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 562);
            this.Controls.Add(this.btnReport);
            this.Controls.Add(this.btnRepayAll);
            this.Controls.Add(this.btnRepayMonth);
            this.Controls.Add(this.txtInstallment);
            this.Controls.Add(this.txtRate);
            this.Controls.Add(this.txtLoan);
            this.Controls.Add(this.labInstallment);
            this.Controls.Add(this.labRate);
            this.Controls.Add(this.labLoan);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Loan";
            this.Text = "本息平均攤還試算";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labLoan;
        private System.Windows.Forms.Label labRate;
        private System.Windows.Forms.Label labInstallment;
        private System.Windows.Forms.TextBox txtLoan;
        private System.Windows.Forms.TextBox txtRate;
        private System.Windows.Forms.TextBox txtInstallment;
        private System.Windows.Forms.Button btnRepayMonth;
        private System.Windows.Forms.Button btnRepayAll;
        private System.Windows.Forms.Button btnReport;
    }
}