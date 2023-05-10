using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace C_作業1
{
    public partial class ScreenSaver : Form
    {
        private Point direction;
        private PictureBox pictureBox;
        private Timer timer;
        public ScreenSaver()
        {
            InitializeComponent();    
        this.StartPosition = FormStartPosition.CenterScreen;
        this.FormBorderStyle = FormBorderStyle.None;
        this.Bounds = Screen.PrimaryScreen.Bounds;
        this.TopMost = true;
        this.DoubleBuffered = true;
        this.BackColor = Color.Black;
        this.direction = new Point(5, 5);
        this.pictureBox = new PictureBox();
        this.pictureBox.Image = Properties.Resources.ilovec; // 將圖片加入到右邊方案總管>方案>Properties>Resources.resx>加入資源>加入現有文件
        this.pictureBox.SizeMode = PictureBoxSizeMode.AutoSize;
        this.pictureBox.Location = new Point(this.Bounds.Width/2 - this.pictureBox.Width / 2, this.Bounds.Height/2 - this.pictureBox.Height /2);
        this.Controls.Add(this.pictureBox);
        this.timer = new Timer();
        this.timer.Interval = 20;
        this.timer.Tick += new EventHandler(timer1_Tick);
        this.timer.Start();
        }


        private void ScreenSaver_MouseClick(object sender, MouseEventArgs e)
        {
            this.Close();
        }

        private void ScreenSaver_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.pictureBox.Location = new Point(this.pictureBox.Location.X + this.direction.X, this.pictureBox.Location.Y + this.direction.Y);
            if (this.pictureBox.Location.X < 0 || this.pictureBox.Location.X + this.pictureBox.Width > this.Bounds.Width)
            {
                this.direction.X = -this.direction.X;
            }
            if (this.pictureBox.Location.Y < 0 || this.pictureBox.Location.Y + this.pictureBox.Height > this.Bounds.Height)
            {
                this.direction.Y = -this.direction.Y;
            }
        }
    }
}
