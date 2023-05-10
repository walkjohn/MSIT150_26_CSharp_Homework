using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C_作業1
{
    public partial class Picture_Viewer_Show : Form
    {
        public Picture_Viewer_Show()
        {
            InitializeComponent();
        }
        public void Pic1Show()
        {
            picBShow.Image = Image.FromFile("C:\\Users\\User\\Desktop\\C#練習\\作業\\C#作業1\\Resources\\ilovec.jpg");
        }
        public void Pic2Show()
        {
            picBShow.Image = Image.FromFile("C:\\Users\\User\\Desktop\\C#練習\\作業\\C#作業1\\Resources\\ilovec 1.jpg");
        }
        public void Pic3Show()
        {
            picBShow.Image = Image.FromFile("C:\\Users\\User\\Desktop\\C#練習\\作業\\C#作業1\\Resources\\Shiba.png");
        }
        public void Pic4Show()
        {
            picBShow.Image = Image.FromFile("C:\\Users\\User\\Desktop\\C#練習\\作業\\C#作業1\\Resources\\shiba1.jpg");
        }
        public void Pic5Show()
        {
            picBShow.Image = Image.FromFile("C:\\Users\\User\\Desktop\\C#練習\\作業\\C#作業1\\Resources\\shiba 3.jpg");
        }
        public void Pic6Show()
        {
            picBShow.Image = Image.FromFile("C:\\Users\\User\\Desktop\\C#練習\\作業\\C#作業1\\Resources\\shiba 4.jpg");
        }
        public void Pic7Show()
        {
            picBShow.Image = Image.FromFile("C:\\Users\\User\\Desktop\\C#練習\\作業\\C#作業1\\Resources\\strawberry.jpg");
        }
        public void Pic8Show()
        {
            picBShow.Image = Image.FromFile("C:\\Users\\User\\Desktop\\C#練習\\作業\\C#作業1\\Resources\\chocolate.jpg");
        }
        public void Pic9Show()
        {
            picBShow.Image = Image.FromFile("C:\\Users\\User\\Desktop\\C#練習\\作業\\C#作業1\\Resources\\taro.jpg");
        }
        public void Pic10Show()
        {
            picBShow.Image = Image.FromFile("C:\\Users\\User\\Desktop\\C#練習\\作業\\C#作業1\\Resources\\puff.jpg");
        }

    }
}
