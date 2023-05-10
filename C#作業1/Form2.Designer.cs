namespace C_作業1
{
    partial class Form2
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
            this.btnWhoAreYou = new System.Windows.Forms.Button();
            this.btnSelfDefinedMethod = new System.Windows.Forms.Button();
            this.btnReturnBirthYear = new System.Windows.Forms.Button();
            this.btnMyClass = new System.Windows.Forms.Button();
            this.btnEncapsulation = new System.Windows.Forms.Button();
            this.btnPartialClass = new System.Windows.Forms.Button();
            this.btnMember = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnWhoAreYou
            // 
            this.btnWhoAreYou.Font = new System.Drawing.Font("新細明體", 20F);
            this.btnWhoAreYou.Location = new System.Drawing.Point(34, 41);
            this.btnWhoAreYou.Name = "btnWhoAreYou";
            this.btnWhoAreYou.Size = new System.Drawing.Size(334, 76);
            this.btnWhoAreYou.TabIndex = 0;
            this.btnWhoAreYou.Text = "Who are you?";
            this.btnWhoAreYou.UseVisualStyleBackColor = true;
            this.btnWhoAreYou.Click += new System.EventHandler(this.btnWhoAreYou_Click);
            // 
            // btnSelfDefinedMethod
            // 
            this.btnSelfDefinedMethod.Font = new System.Drawing.Font("新細明體", 20F);
            this.btnSelfDefinedMethod.Location = new System.Drawing.Point(34, 132);
            this.btnSelfDefinedMethod.Name = "btnSelfDefinedMethod";
            this.btnSelfDefinedMethod.Size = new System.Drawing.Size(334, 76);
            this.btnSelfDefinedMethod.TabIndex = 1;
            this.btnSelfDefinedMethod.Text = "Self Defined Method";
            this.btnSelfDefinedMethod.UseVisualStyleBackColor = true;
            this.btnSelfDefinedMethod.Click += new System.EventHandler(this.btnSelfDefinedMethod_Click);
            // 
            // btnReturnBirthYear
            // 
            this.btnReturnBirthYear.Font = new System.Drawing.Font("新細明體", 20F);
            this.btnReturnBirthYear.Location = new System.Drawing.Point(34, 214);
            this.btnReturnBirthYear.Name = "btnReturnBirthYear";
            this.btnReturnBirthYear.Size = new System.Drawing.Size(334, 76);
            this.btnReturnBirthYear.TabIndex = 2;
            this.btnReturnBirthYear.Text = "Return Birth Year";
            this.btnReturnBirthYear.UseVisualStyleBackColor = true;
            this.btnReturnBirthYear.Click += new System.EventHandler(this.btnReturnBirthYear_Click);
            // 
            // btnMyClass
            // 
            this.btnMyClass.Font = new System.Drawing.Font("新細明體", 20F);
            this.btnMyClass.Location = new System.Drawing.Point(34, 296);
            this.btnMyClass.Name = "btnMyClass";
            this.btnMyClass.Size = new System.Drawing.Size(334, 76);
            this.btnMyClass.TabIndex = 3;
            this.btnMyClass.Text = "My Class";
            this.btnMyClass.UseVisualStyleBackColor = true;
            this.btnMyClass.Click += new System.EventHandler(this.btnMyClass_Click);
            // 
            // btnEncapsulation
            // 
            this.btnEncapsulation.Font = new System.Drawing.Font("新細明體", 20F);
            this.btnEncapsulation.Location = new System.Drawing.Point(398, 41);
            this.btnEncapsulation.Name = "btnEncapsulation";
            this.btnEncapsulation.Size = new System.Drawing.Size(334, 76);
            this.btnEncapsulation.TabIndex = 4;
            this.btnEncapsulation.Text = "封裝";
            this.btnEncapsulation.UseVisualStyleBackColor = true;
            this.btnEncapsulation.Click += new System.EventHandler(this.btnEncapsulation_Click);
            // 
            // btnPartialClass
            // 
            this.btnPartialClass.Font = new System.Drawing.Font("新細明體", 20F);
            this.btnPartialClass.Location = new System.Drawing.Point(398, 132);
            this.btnPartialClass.Name = "btnPartialClass";
            this.btnPartialClass.Size = new System.Drawing.Size(334, 76);
            this.btnPartialClass.TabIndex = 5;
            this.btnPartialClass.Text = "Partial Class";
            this.btnPartialClass.UseVisualStyleBackColor = true;
            this.btnPartialClass.Click += new System.EventHandler(this.btnPartialClass_Click);
            // 
            // btnMember
            // 
            this.btnMember.Font = new System.Drawing.Font("新細明體", 20F);
            this.btnMember.Location = new System.Drawing.Point(398, 214);
            this.btnMember.Name = "btnMember";
            this.btnMember.Size = new System.Drawing.Size(334, 76);
            this.btnMember.TabIndex = 6;
            this.btnMember.Text = "會員資料";
            this.btnMember.UseVisualStyleBackColor = true;
            this.btnMember.Click += new System.EventHandler(this.btnMember_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnMember);
            this.Controls.Add(this.btnPartialClass);
            this.Controls.Add(this.btnEncapsulation);
            this.Controls.Add(this.btnMyClass);
            this.Controls.Add(this.btnReturnBirthYear);
            this.Controls.Add(this.btnSelfDefinedMethod);
            this.Controls.Add(this.btnWhoAreYou);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnWhoAreYou;
        private System.Windows.Forms.Button btnSelfDefinedMethod;
        private System.Windows.Forms.Button btnReturnBirthYear;
        private System.Windows.Forms.Button btnMyClass;
        private System.Windows.Forms.Button btnEncapsulation;
        private System.Windows.Forms.Button btnPartialClass;
        private System.Windows.Forms.Button btnMember;
    }
}