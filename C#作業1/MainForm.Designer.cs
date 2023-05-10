namespace C_作業1
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.button15 = new System.Windows.Forms.Button();
            this.btnPicViewer = new System.Windows.Forms.Button();
            this.btnPaint = new System.Windows.Forms.Button();
            this.btnNotePad = new System.Windows.Forms.Button();
            this.btnScreenSaver = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.btnGrade = new System.Windows.Forms.Button();
            this.btnScoreComparison = new System.Windows.Forms.Button();
            this.btnOrderFood = new System.Windows.Forms.Button();
            this.btnLoan = new System.Windows.Forms.Button();
            this.btnHello = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("splitContainer1.Panel1.BackgroundImage")));
            this.splitContainer1.Panel1.ForeColor = System.Drawing.SystemColors.Desktop;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(1054, 575);
            this.splitContainer1.SplitterDistance = 96;
            this.splitContainer1.TabIndex = 0;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.splitContainer2.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.splitContainer2.Panel1.Controls.Add(this.button15);
            this.splitContainer2.Panel1.Controls.Add(this.btnPicViewer);
            this.splitContainer2.Panel1.Controls.Add(this.btnPaint);
            this.splitContainer2.Panel1.Controls.Add(this.btnNotePad);
            this.splitContainer2.Panel1.Controls.Add(this.btnScreenSaver);
            this.splitContainer2.Panel1.Controls.Add(this.button10);
            this.splitContainer2.Panel1.Controls.Add(this.button8);
            this.splitContainer2.Panel1.Controls.Add(this.button7);
            this.splitContainer2.Panel1.Controls.Add(this.btnGrade);
            this.splitContainer2.Panel1.Controls.Add(this.btnScoreComparison);
            this.splitContainer2.Panel1.Controls.Add(this.btnOrderFood);
            this.splitContainer2.Panel1.Controls.Add(this.btnLoan);
            this.splitContainer2.Panel1.Controls.Add(this.btnHello);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("splitContainer2.Panel2.BackgroundImage")));
            this.splitContainer2.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.splitContainer2.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.splitContainer2.Size = new System.Drawing.Size(1054, 475);
            this.splitContainer2.SplitterDistance = 269;
            this.splitContainer2.TabIndex = 0;
            // 
            // button15
            // 
            this.button15.Location = new System.Drawing.Point(22, 426);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(223, 28);
            this.button15.TabIndex = 14;
            this.button15.Text = "終極密碼";
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Click += new System.EventHandler(this.button15_Click);
            // 
            // btnPicViewer
            // 
            this.btnPicViewer.Location = new System.Drawing.Point(22, 392);
            this.btnPicViewer.Name = "btnPicViewer";
            this.btnPicViewer.Size = new System.Drawing.Size(223, 28);
            this.btnPicViewer.TabIndex = 13;
            this.btnPicViewer.Text = "Piture Viewer";
            this.btnPicViewer.UseVisualStyleBackColor = true;
            this.btnPicViewer.Click += new System.EventHandler(this.btnPicViewer_Click);
            // 
            // btnPaint
            // 
            this.btnPaint.Location = new System.Drawing.Point(22, 358);
            this.btnPaint.Name = "btnPaint";
            this.btnPaint.Size = new System.Drawing.Size(223, 28);
            this.btnPaint.TabIndex = 12;
            this.btnPaint.Text = "小畫家";
            this.btnPaint.UseVisualStyleBackColor = true;
            this.btnPaint.Click += new System.EventHandler(this.btnPaint_Click);
            // 
            // btnNotePad
            // 
            this.btnNotePad.Location = new System.Drawing.Point(22, 324);
            this.btnNotePad.Name = "btnNotePad";
            this.btnNotePad.Size = new System.Drawing.Size(223, 28);
            this.btnNotePad.TabIndex = 11;
            this.btnNotePad.Text = "記事本";
            this.btnNotePad.UseVisualStyleBackColor = true;
            this.btnNotePad.Click += new System.EventHandler(this.btnNotePad_Click);
            // 
            // btnScreenSaver
            // 
            this.btnScreenSaver.Location = new System.Drawing.Point(22, 290);
            this.btnScreenSaver.Name = "btnScreenSaver";
            this.btnScreenSaver.Size = new System.Drawing.Size(223, 28);
            this.btnScreenSaver.TabIndex = 10;
            this.btnScreenSaver.Text = "螢幕保護程式";
            this.btnScreenSaver.UseVisualStyleBackColor = true;
            this.btnScreenSaver.Click += new System.EventHandler(this.btnScreenSaver_Click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(22, 256);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(223, 28);
            this.button10.TabIndex = 9;
            this.button10.Text = "圈圈叉叉";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(22, 222);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(223, 28);
            this.button8.TabIndex = 7;
            this.button8.Text = "簡單計算機";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(22, 188);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(223, 28);
            this.button7.TabIndex = 6;
            this.button7.Text = "陣列一";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // btnGrade
            // 
            this.btnGrade.Location = new System.Drawing.Point(22, 154);
            this.btnGrade.Name = "btnGrade";
            this.btnGrade.Size = new System.Drawing.Size(223, 28);
            this.btnGrade.TabIndex = 4;
            this.btnGrade.Text = "成績輸入清除";
            this.btnGrade.UseVisualStyleBackColor = true;
            this.btnGrade.Click += new System.EventHandler(this.btnGrade_Click);
            // 
            // btnScoreComparison
            // 
            this.btnScoreComparison.Location = new System.Drawing.Point(22, 120);
            this.btnScoreComparison.Name = "btnScoreComparison";
            this.btnScoreComparison.Size = new System.Drawing.Size(223, 28);
            this.btnScoreComparison.TabIndex = 3;
            this.btnScoreComparison.Text = "最高分最低分比較";
            this.btnScoreComparison.UseVisualStyleBackColor = true;
            this.btnScoreComparison.Click += new System.EventHandler(this.btnScoreComparison_Click);
            // 
            // btnOrderFood
            // 
            this.btnOrderFood.Location = new System.Drawing.Point(22, 86);
            this.btnOrderFood.Name = "btnOrderFood";
            this.btnOrderFood.Size = new System.Drawing.Size(223, 28);
            this.btnOrderFood.TabIndex = 2;
            this.btnOrderFood.Text = "點餐";
            this.btnOrderFood.UseVisualStyleBackColor = true;
            this.btnOrderFood.Click += new System.EventHandler(this.btnOrderFood_Click);
            // 
            // btnLoan
            // 
            this.btnLoan.Location = new System.Drawing.Point(22, 52);
            this.btnLoan.Name = "btnLoan";
            this.btnLoan.Size = new System.Drawing.Size(223, 28);
            this.btnLoan.TabIndex = 1;
            this.btnLoan.Text = "貸款金額試算";
            this.btnLoan.UseVisualStyleBackColor = true;
            this.btnLoan.Click += new System.EventHandler(this.btnLoan_Click);
            // 
            // btnHello
            // 
            this.btnHello.Location = new System.Drawing.Point(22, 18);
            this.btnHello.Name = "btnHello";
            this.btnHello.Size = new System.Drawing.Size(223, 28);
            this.btnHello.TabIndex = 0;
            this.btnHello.Text = "Hello 你好嗎";
            this.btnHello.UseVisualStyleBackColor = true;
            this.btnHello.Click += new System.EventHandler(this.btnHello_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1054, 575);
            this.Controls.Add(this.splitContainer1);
            this.Name = "MainForm";
            this.Text = "C#作業";
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button btnPicViewer;
        private System.Windows.Forms.Button btnPaint;
        private System.Windows.Forms.Button btnNotePad;
        private System.Windows.Forms.Button btnScreenSaver;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button btnGrade;
        private System.Windows.Forms.Button btnScoreComparison;
        private System.Windows.Forms.Button btnOrderFood;
        private System.Windows.Forms.Button btnLoan;
        private System.Windows.Forms.Button btnHello;
    }
}