namespace C_作業1
{
    partial class OrderFood
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderFood));
            this.label1 = new System.Windows.Forms.Label();
            this.labCart = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCash = new System.Windows.Forms.Button();
            this.btnCard = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.labTotalPrice = new System.Windows.Forms.Label();
            this.btnStrawberry = new System.Windows.Forms.Button();
            this.btnChocolate = new System.Windows.Forms.Button();
            this.btnVanilla = new System.Windows.Forms.Button();
            this.btnTaro = new System.Windows.Forms.Button();
            this.btnClearCart = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(279, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(365, 329);
            this.label1.TabIndex = 1;
            this.label1.Text = "購物清單 Cart";
            // 
            // labCart
            // 
            this.labCart.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labCart.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labCart.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labCart.Location = new System.Drawing.Point(295, 49);
            this.labCart.Name = "labCart";
            this.labCart.Size = new System.Drawing.Size(338, 245);
            this.labCart.TabIndex = 2;
            this.labCart.Text = "尚未點餐";
            this.labCart.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(11, 365);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(262, 121);
            this.label3.TabIndex = 3;
            this.label3.Text = "付款方式 Pay by Cash/Card";
            // 
            // btnCash
            // 
            this.btnCash.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnCash.Location = new System.Drawing.Point(19, 400);
            this.btnCash.Name = "btnCash";
            this.btnCash.Size = new System.Drawing.Size(120, 60);
            this.btnCash.TabIndex = 4;
            this.btnCash.Text = "現金\r\nCash\r\n";
            this.btnCash.UseVisualStyleBackColor = true;
            this.btnCash.Click += new System.EventHandler(this.btnCash_Click);
            // 
            // btnCard
            // 
            this.btnCard.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnCard.Location = new System.Drawing.Point(145, 400);
            this.btnCard.Name = "btnCard";
            this.btnCard.Size = new System.Drawing.Size(120, 60);
            this.btnCard.TabIndex = 5;
            this.btnCard.Text = "信用卡\r\nCard\r\n";
            this.btnCard.UseVisualStyleBackColor = true;
            this.btnCard.Click += new System.EventHandler(this.btnCard_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(148, 468);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 12);
            this.label4.TabIndex = 6;
            this.label4.Text = "信用卡享9折優惠!";
            // 
            // label5
            // 
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(11, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(262, 329);
            this.label5.TabIndex = 7;
            this.label5.Text = "菜單 Menu";
            // 
            // label6
            // 
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.Location = new System.Drawing.Point(279, 365);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(365, 121);
            this.label6.TabIndex = 8;
            this.label6.Text = "總金額 Total Price";
            // 
            // labTotalPrice
            // 
            this.labTotalPrice.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labTotalPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labTotalPrice.Font = new System.Drawing.Font("新細明體", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labTotalPrice.Location = new System.Drawing.Point(410, 412);
            this.labTotalPrice.Name = "labTotalPrice";
            this.labTotalPrice.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labTotalPrice.Size = new System.Drawing.Size(223, 36);
            this.labTotalPrice.TabIndex = 9;
            this.labTotalPrice.Text = "0";
            // 
            // btnStrawberry
            // 
            this.btnStrawberry.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnStrawberry.BackgroundImage")));
            this.btnStrawberry.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnStrawberry.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnStrawberry.Location = new System.Drawing.Point(19, 78);
            this.btnStrawberry.Name = "btnStrawberry";
            this.btnStrawberry.Size = new System.Drawing.Size(120, 97);
            this.btnStrawberry.TabIndex = 10;
            this.btnStrawberry.Text = "草莓泡芙\r\nStrawberry Puff\r\nNTD 80";
            this.btnStrawberry.UseVisualStyleBackColor = true;
            this.btnStrawberry.Click += new System.EventHandler(this.btnStrawberry_Click);
            // 
            // btnChocolate
            // 
            this.btnChocolate.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnChocolate.BackgroundImage")));
            this.btnChocolate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnChocolate.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnChocolate.Location = new System.Drawing.Point(145, 78);
            this.btnChocolate.Name = "btnChocolate";
            this.btnChocolate.Size = new System.Drawing.Size(120, 97);
            this.btnChocolate.TabIndex = 11;
            this.btnChocolate.Text = "巧克力泡芙\r\nChocolate Puff\r\nNTD 70";
            this.btnChocolate.UseVisualStyleBackColor = true;
            this.btnChocolate.Click += new System.EventHandler(this.btnChocolate_Click);
            // 
            // btnVanilla
            // 
            this.btnVanilla.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnVanilla.BackgroundImage")));
            this.btnVanilla.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnVanilla.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnVanilla.Location = new System.Drawing.Point(19, 197);
            this.btnVanilla.Name = "btnVanilla";
            this.btnVanilla.Size = new System.Drawing.Size(120, 97);
            this.btnVanilla.TabIndex = 12;
            this.btnVanilla.Text = "香草奶油泡芙\r\nVanilla Cream Puff\r\nNTD 60";
            this.btnVanilla.UseVisualStyleBackColor = true;
            this.btnVanilla.Click += new System.EventHandler(this.btnVanilla_Click);
            // 
            // btnTaro
            // 
            this.btnTaro.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTaro.BackgroundImage")));
            this.btnTaro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnTaro.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnTaro.Location = new System.Drawing.Point(145, 197);
            this.btnTaro.Name = "btnTaro";
            this.btnTaro.Size = new System.Drawing.Size(120, 97);
            this.btnTaro.TabIndex = 13;
            this.btnTaro.Text = "芋頭泡芙\r\nTaro Puff\r\nNTD 90";
            this.btnTaro.UseVisualStyleBackColor = true;
            this.btnTaro.Click += new System.EventHandler(this.btnTaro_Click);
            // 
            // btnClearCart
            // 
            this.btnClearCart.Font = new System.Drawing.Font("新細明體", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnClearCart.Location = new System.Drawing.Point(512, 305);
            this.btnClearCart.Name = "btnClearCart";
            this.btnClearCart.Size = new System.Drawing.Size(120, 33);
            this.btnClearCart.TabIndex = 14;
            this.btnClearCart.Text = "清除購物清單";
            this.btnClearCart.UseVisualStyleBackColor = true;
            this.btnClearCart.Click += new System.EventHandler(this.btnClearCart_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("新細明體", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(334, 419);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 29);
            this.label2.TabIndex = 15;
            this.label2.Text = "NTD";
            // 
            // OrderFood
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 503);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnClearCart);
            this.Controls.Add(this.btnTaro);
            this.Controls.Add(this.btnVanilla);
            this.Controls.Add(this.btnChocolate);
            this.Controls.Add(this.btnStrawberry);
            this.Controls.Add(this.labTotalPrice);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnCard);
            this.Controls.Add(this.btnCash);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labCart);
            this.Controls.Add(this.label1);
            this.Name = "OrderFood";
            this.Text = "OrderFood";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labCart;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCash;
        private System.Windows.Forms.Button btnCard;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labTotalPrice;
        private System.Windows.Forms.Button btnStrawberry;
        private System.Windows.Forms.Button btnChocolate;
        private System.Windows.Forms.Button btnVanilla;
        private System.Windows.Forms.Button btnTaro;
        private System.Windows.Forms.Button btnClearCart;
        private System.Windows.Forms.Label label2;
    }
}