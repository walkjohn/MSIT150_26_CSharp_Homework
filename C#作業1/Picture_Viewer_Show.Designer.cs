namespace C_作業1
{
    partial class Picture_Viewer_Show
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
            this.picBShow = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picBShow)).BeginInit();
            this.SuspendLayout();
            // 
            // picBShow
            // 
            this.picBShow.Location = new System.Drawing.Point(0, 0);
            this.picBShow.Name = "picBShow";
            this.picBShow.Size = new System.Drawing.Size(751, 416);
            this.picBShow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBShow.TabIndex = 0;
            this.picBShow.TabStop = false;
            // 
            // Picture_Viewer_Show
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 416);
            this.Controls.Add(this.picBShow);
            this.Name = "Picture_Viewer_Show";
            this.Text = "Picture_Viewer_Show";
            ((System.ComponentModel.ISupportInitialize)(this.picBShow)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picBShow;
    }
}