namespace C_作業1
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.labName1 = new System.Windows.Forms.Label();
            this.labName2 = new System.Windows.Forms.Label();
            this.labName3 = new System.Windows.Forms.Label();
            this.labName4 = new System.Windows.Forms.Label();
            this.txtName1 = new System.Windows.Forms.TextBox();
            this.txtName2 = new System.Windows.Forms.TextBox();
            this.txtName3 = new System.Windows.Forms.TextBox();
            this.txtName4 = new System.Windows.Forms.TextBox();
            this.btnName1 = new System.Windows.Forms.Button();
            this.btnName2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labName1
            // 
            this.labName1.AutoSize = true;
            this.labName1.BackColor = System.Drawing.Color.Transparent;
            this.labName1.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labName1.Location = new System.Drawing.Point(32, 58);
            this.labName1.Name = "labName1";
            this.labName1.Size = new System.Drawing.Size(52, 19);
            this.labName1.TabIndex = 0;
            this.labName1.Text = "姓名:";
            // 
            // labName2
            // 
            this.labName2.AutoSize = true;
            this.labName2.BackColor = System.Drawing.Color.Transparent;
            this.labName2.Font = new System.Drawing.Font("新細明體", 14F);
            this.labName2.Location = new System.Drawing.Point(32, 101);
            this.labName2.Name = "labName2";
            this.labName2.Size = new System.Drawing.Size(117, 19);
            this.labName2.TabIndex = 1;
            this.labName2.Text = "English Name:";
            // 
            // labName3
            // 
            this.labName3.AutoSize = true;
            this.labName3.BackColor = System.Drawing.Color.Transparent;
            this.labName3.Font = new System.Drawing.Font("新細明體", 14F);
            this.labName3.Location = new System.Drawing.Point(32, 147);
            this.labName3.Name = "labName3";
            this.labName3.Size = new System.Drawing.Size(52, 19);
            this.labName3.TabIndex = 2;
            this.labName3.Text = "性別:";
            // 
            // labName4
            // 
            this.labName4.AutoSize = true;
            this.labName4.BackColor = System.Drawing.Color.Transparent;
            this.labName4.Font = new System.Drawing.Font("新細明體", 14F);
            this.labName4.Location = new System.Drawing.Point(32, 194);
            this.labName4.Name = "labName4";
            this.labName4.Size = new System.Drawing.Size(52, 19);
            this.labName4.TabIndex = 3;
            this.labName4.Text = "星座:";
            // 
            // txtName1
            // 
            this.txtName1.Font = new System.Drawing.Font("新細明體", 14F);
            this.txtName1.Location = new System.Drawing.Point(156, 55);
            this.txtName1.Name = "txtName1";
            this.txtName1.Size = new System.Drawing.Size(144, 30);
            this.txtName1.TabIndex = 4;
            // 
            // txtName2
            // 
            this.txtName2.Font = new System.Drawing.Font("新細明體", 14F);
            this.txtName2.Location = new System.Drawing.Point(156, 98);
            this.txtName2.Name = "txtName2";
            this.txtName2.Size = new System.Drawing.Size(144, 30);
            this.txtName2.TabIndex = 5;
            // 
            // txtName3
            // 
            this.txtName3.Font = new System.Drawing.Font("新細明體", 14F);
            this.txtName3.Location = new System.Drawing.Point(156, 144);
            this.txtName3.Name = "txtName3";
            this.txtName3.Size = new System.Drawing.Size(144, 30);
            this.txtName3.TabIndex = 6;
            // 
            // txtName4
            // 
            this.txtName4.Font = new System.Drawing.Font("新細明體", 14F);
            this.txtName4.Location = new System.Drawing.Point(156, 191);
            this.txtName4.Name = "txtName4";
            this.txtName4.Size = new System.Drawing.Size(145, 30);
            this.txtName4.TabIndex = 7;
            // 
            // btnName1
            // 
            this.btnName1.Font = new System.Drawing.Font("新細明體", 14F);
            this.btnName1.Location = new System.Drawing.Point(74, 259);
            this.btnName1.Name = "btnName1";
            this.btnName1.Size = new System.Drawing.Size(175, 41);
            this.btnName1.TabIndex = 8;
            this.btnName1.Text = "Say Hello";
            this.btnName1.UseVisualStyleBackColor = true;
            this.btnName1.Click += new System.EventHandler(this.btnName1_Click);
            // 
            // btnName2
            // 
            this.btnName2.Font = new System.Drawing.Font("新細明體", 14F);
            this.btnName2.Location = new System.Drawing.Point(74, 327);
            this.btnName2.Name = "btnName2";
            this.btnName2.Size = new System.Drawing.Size(175, 38);
            this.btnName2.TabIndex = 9;
            this.btnName2.Text = "Say Hi";
            this.btnName2.UseVisualStyleBackColor = true;
            this.btnName2.Click += new System.EventHandler(this.btnName2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(485, 389);
            this.Controls.Add(this.btnName2);
            this.Controls.Add(this.btnName1);
            this.Controls.Add(this.txtName4);
            this.Controls.Add(this.txtName3);
            this.Controls.Add(this.txtName2);
            this.Controls.Add(this.txtName1);
            this.Controls.Add(this.labName4);
            this.Controls.Add(this.labName3);
            this.Controls.Add(this.labName2);
            this.Controls.Add(this.labName1);
            this.Name = "Form1";
            this.Text = "Hello 你好嗎";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labName1;
        private System.Windows.Forms.Label labName2;
        private System.Windows.Forms.Label labName3;
        private System.Windows.Forms.Label labName4;
        private System.Windows.Forms.TextBox txtName1;
        private System.Windows.Forms.TextBox txtName2;
        private System.Windows.Forms.TextBox txtName3;
        private System.Windows.Forms.TextBox txtName4;
        private System.Windows.Forms.Button btnName1;
        private System.Windows.Forms.Button btnName2;
    }
}

