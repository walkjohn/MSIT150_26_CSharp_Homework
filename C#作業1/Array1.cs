using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media.Media3D;

namespace C_作業1
{
    public partial class Array1 : Form
    {
        public Array1()
        {
            InitializeComponent();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            int num = 0;
            bool isNum = int.TryParse(txtOddEven.Text, out num);

            if (!isNum || num <= 0)
            {
                MessageBox.Show("請輸入一整數");
                txtOddEven.Clear();
                txtOddEven.Focus();
            }
            else
            {
                if ((num % 2) == 0)
                    labResult.Text = $"輸入之{num}為偶數";
                else
                    labResult.Text = $"輸入之{num}為奇數";
            }
        }

        private void btnSquare1010_Click(object sender, EventArgs e)
        {
            labResult.Text = "";
            int num0 = 0, num1 = 1;

            for (int i = 1; i < 11; i++)
            {
                if ((i % 2) != 0)
                {
                    for (int j = 1; j < 11; j++)
                    {
                        if ((j % 2) != 0)
                            labResult.Text += $" {num1} ";
                        else if ((j % 2) == 0 && j != 10)
                            labResult.Text += $" {num0} ";
                        else
                            labResult.Text += $" {num0} " + "\n";
                    }
                }
                else
                {
                    for (int k = 1; k < 11; k++)
                    {
                        if ((k % 2) != 0)
                            labResult.Text += $" {num0} ";
                        else if ((k % 2) == 0 && k != 10)
                            labResult.Text += $" {num1} ";
                        else
                            labResult.Text += $" {num1} " + "\n";
                    }
                }
            }
        }

        private void btnSquare10_Click(object sender, EventArgs e)
        {
            labResult.Text = "";
            int num0 = 0, num1 = 1;

            for (int i = 1; i < 11; i++)
            {
                if (i == 1 || i == 10)
                {
                    for (int j = 1; j < 11; j++)
                    {
                        if (j != 10)
                            labResult.Text += $" {num1} ";
                        else
                            labResult.Text += $" {num1} " + "\n";
                    }
                }
                else
                {
                    for (int k = 1; k < 11; k++)
                    {
                        if (k == 1)
                            labResult.Text += $" {num1} ";
                        else if (k == 10)
                            labResult.Text += $" {num1} " + "\n";
                        else
                            labResult.Text += $" {num0} ";
                    }
                }
            }
        }

        private void btnSquare01_Click(object sender, EventArgs e)
        {
            labResult.Text = "";
            int num0 = 0, num1 = 1;

            for (int i = 1; i < 11; i++)
            {
                if (i == 1 || i == 10)
                {
                    for (int j = 1; j < 11; j++)
                    {
                        if (j != 10)
                            labResult.Text += $" {num0} ";
                        else
                            labResult.Text += $" {num0} " + "\n";
                    }
                }
                else
                {
                    for (int k = 1; k < 11; k++)
                    {
                        if (k == 1)
                            labResult.Text += $" {num0} ";
                        else if (k == 10)
                            labResult.Text += $" {num0} " + "\n";
                        else
                            labResult.Text += $" {num1} ";
                    }
                }
            }
        }


        void Swap(ref int A, ref int B)
        {
            int T = A;
            A = B;
            B = T;
        }
        private void btnSwap_Click(object sender, EventArgs e)
        {
            labResult.Text = "";
            int n1 = 100, n2 = 200;
            labResult.Text += $"換位前n1={n1}，n2={n2}\n";

            Swap(ref n1, ref n2);
            labResult.Text += $"換位後n1={n1}，n2={n2}";
        }


        int[] ExampleArr1 = { 1, 5, 6, 8, 7, 97, 54, 887, 65, 578 };


        private void btnArrayOddEven_Click(object sender, EventArgs e)
        {
            string result = "";
            int odd = 0, even = 0;
            for (int i = 0; i < ExampleArr1.Length; i++)
            {
                result += $" {ExampleArr1[i]}, ";

                if (ExampleArr1[i] % 2 == 0)
                    even++;
                else
                    odd++;
            }
            result = result.Substring(0, result.Length - 2);  //substring方法，保留從字串索引0~字串長度，-2為減掉最後的", "

            labResult.Text = $"int陣列ExampleArr1[{result}]\n奇數共{odd}個\n偶數共{even}個";
        }

        private void btnArrayMaxMini_Click(object sender, EventArgs e)
        {
            string result = "";
            int max = ExampleArr1[0], mini = ExampleArr1[9];

            for (int i = 0; i < ExampleArr1.Length; i++)
            {
                result += $" {ExampleArr1[i]}, ";

                if (ExampleArr1[i] - max > 0)
                    max = ExampleArr1[i];
                else
                    continue;
            }

            for (int j = 0; j < ExampleArr1.Length; j++)
            {
                if (ExampleArr1[j] - mini < 0)
                    mini = ExampleArr1[j];
                else
                    continue;
            }

            result = result.Substring(0, result.Length - 2);

            labResult.Text = $"int陣列ExampleArr1[{result}]\n最大值為{max}\n最小值為{mini}";

        }

        private void btnArrayMax_Click(object sender, EventArgs e)
        {
            string result = "";
            int max = ExampleArr1[0];

            for (int i = 0; i < ExampleArr1.Length; i++)
            {
                result += $" {ExampleArr1[i]}, ";

                if (ExampleArr1[i] - max > 0)
                    max = ExampleArr1[i];
                else
                    continue;
            }
            result = result.Substring(0, result.Length - 2);

            labResult.Text = $"int陣列ExampleArr1[{result}]\n最大值為{max}";
        }

        private void btnArrayMini_Click(object sender, EventArgs e)
        {
            string result = "";
            int mini = ExampleArr1[9];

            for (int j = 0; j < ExampleArr1.Length; j++)
            {
                result += $" {ExampleArr1[j]}, ";

                if (ExampleArr1[j] - mini < 0)
                    mini = ExampleArr1[j];
                else
                    continue;
            }

            result = result.Substring(0, result.Length - 2);

            labResult.Text = $"int陣列ExampleArr1[{result}]\n最小值為{mini}";
        }

        private void btnArraySum_Click(object sender, EventArgs e)
        {
            string result = "";
            int sum = 0;

            for (int i = 0; i < ExampleArr1.Length; i++)
            {
                result += $" {ExampleArr1[i]}, ";
                sum += ExampleArr1[i];
            }
            result = result.Substring(0, result.Length - 2);

            labResult.Text = $"int陣列ExampleArr1[{result}]\n陣列總和為為{sum}";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            labResult.Text = "結果";
        }

        private void btnBinary_Click(object sender, EventArgs e)
        {
            int value = 100;
            string binary = Convert.ToString(value, 2);   //將變數轉成二進位
            labResult.Text = binary;
        }

        private void btnLottery_Click(object sender, EventArgs e)
        {
            string result = "";
            int[] randomArray = new int[6];

            Random rnd = new Random();  //產生亂數初始值
            for (int i = 0; i < 6; i++)
            {
                randomArray[i] = rnd.Next(1, 50);   //亂數產生，亂數產生的範圍是1~49

                for (int j = 0; j < i; j++)
                {
                    while (randomArray[j] == randomArray[i])    //檢查是否與前面產生的數值發生重複，如果有就重新產生
                    {
                        j = 0;  //如有重複，將變數j設為0，再次檢查 (因為還是有重複的可能)
                        randomArray[i] = rnd.Next(1, 50);   //重新產生，存回陣列，亂數產生的範圍是1~49
                    }
                }

                result += $" {randomArray[i]} ";
                labResult.Text = $"樂透號碼\n {result}  ";
            }
        }

        private void btn99_Click(object sender, EventArgs e)
        {
            string result = "";
            int a, b, c; //宣告變數a,b,c
            for (a = 1; a < 10; a++) //進行迴圈，使被乘數範圍為1到9
            {
                for (b = 2; b < 10; b++) //進行迴圈，使乘數範圍為2到9
                {
                    c = a * b; //將變數a乘以變數b可得到變數數c，此為乘法中的商數   

                    result += $" {b}x {a}={string.Format("{0:00}", c)}| ";
                }
                result += "\n";

                labResult.Text = $"九九乘法表\n{result}";

            }
        }
        private void btnXmas_Click(object sender, EventArgs e)
        {
            string result = "";
            int num = 0;
            bool isNum = int.TryParse(txtXmas.Text, out num);

            if (!isNum || num <= 0)
            {
                MessageBox.Show("請輸入一整數");
                txtXmas.Clear();
                txtXmas.Focus();
            }
            else
            {
                for (int i = 1; i <= int.Parse(txtXmas.Text); i++)
                {
                    for (int j = 1; j <= i; j++)
                        result += "*";

                    result += "\n";
                }
                labResult.Text = $"{result}";
            }
        }

        string[] ExampleArr2 = { "mother張", "emma", "迪克蕭", "J40", "Candy", "Cindy", "Coconut", "Motherfacker" };
        private void btnMostChar_Click(object sender, EventArgs e)
        {
            //陣列[].length去比較長度

            string result = "", longer="";
            int longest = ExampleArr2[0].Length;

            for (int i = 0; i < ExampleArr2.Length; i++)
            {
                result += $" {ExampleArr2[i]}, ";
               
                if (ExampleArr2[i].Length > longest)
                    //longest = ExampleArr2[i].Length;
                    longer = ExampleArr2[i];
                else
                    continue;
            }
            result = result.Substring(0, result.Length - 2);  //substring方法，保留從字串索引0~字串長度，-2為減掉最後的", "

            labResult.Text = $"int陣列ExampleArr2[{result}]\n字數最多的名字為{longer}";
            //}
        }

       
        private void btnWithCc_Click(object sender, EventArgs e)
        {
            //陣列[].contains去抓是否含有特定字元

            string result = "";
            int cc = 0;

            for (int i = 0; i < ExampleArr2.Length; i++)
            {
                result += $" {ExampleArr2[i]}, ";

                if (ExampleArr2[i].Contains('C') || ExampleArr2[i].Contains('c'))
                  cc++;
                else
                    continue;
            }
            result = result.Substring(0, result.Length - 2);  //substring方法，保留從字串索引0~字串長度，-2為減掉最後的", "

            labResult.Text = $"int陣列ExampleArr2[{result}]\n有C或c的名字有{cc}個";
            //} 
        }

        private void btnFor_Click(object sender, EventArgs e)
        {
            int num = 0, num1 = 0, num2 = 0, sumFor = 0;
            bool isNum = int.TryParse(txtFrom.Text, out num);
            bool isNum1 = int.TryParse(txtTo.Text, out num1);
            bool isNum2 = int.TryParse(txtStep.Text, out num2);

            if (!isNum || !isNum1 || !isNum2 ||num <0  || num1 <= 0 || num2 <= 0)
            {
                MessageBox.Show("請輸入一正確整數數值");
            }

            else if(int.Parse(txtTo.Text) % int.Parse(txtStep.Text) == 0)
            {               
                for(int i=0; i<int.Parse(txtTo.Text)/ int.Parse(txtStep.Text); i++) 
                {
                    sumFor += (int.Parse(txtFrom.Text)+ int.Parse(txtStep.Text)*i);       
                }
                labResult.Text = $"{txtFrom.Text} 到 {txtTo.Text} 相隔 {int.Parse(txtStep.Text) - 1}\n加總為 {sumFor}";
            }

            else
            {
                for (int i = 0; i < int.Parse(txtTo.Text) / int.Parse(txtStep.Text)+1; i++)
                {
                    sumFor += (int.Parse(txtFrom.Text) + int.Parse(txtStep.Text) * i);
                }
                labResult.Text = $"{txtFrom.Text} 到 {txtTo.Text} 相隔 {int.Parse(txtStep.Text) - 1}\n加總為 {sumFor}";
            }
        }

        private void btnWhile_Click(object sender, EventArgs e)
        {
            int num = 0, num1 = 0, num2 = 0, sumWhile = 0;
            bool isNum = int.TryParse(txtFrom.Text, out num);
            bool isNum1 = int.TryParse(txtTo.Text, out num1);
            bool isNum2 = int.TryParse(txtStep.Text, out num2);

            if (!isNum || !isNum1 || !isNum2 || num < 0 || num1 <= 0 || num2 <= 0)
            {
                MessageBox.Show("請輸入一正確整數數值");
            }

            else if (int.Parse(txtTo.Text) % int.Parse(txtStep.Text) == 0)
            {
                int i = 0;
                while(i< int.Parse(txtTo.Text) / int.Parse(txtStep.Text))
                {
                    sumWhile += (int.Parse(txtFrom.Text) + int.Parse(txtStep.Text) * i);
                    i++;
                }
                labResult.Text = $"{txtFrom.Text} 到 {txtTo.Text} 相隔 {int.Parse(txtStep.Text) - 1}\n加總為 {sumWhile}";
            }

            else
            {            
                int i = 0;
                while (i < int.Parse(txtTo.Text) / int.Parse(txtStep.Text)+1)
                {
                    sumWhile += (int.Parse(txtFrom.Text) + int.Parse(txtStep.Text) * i);
                    i++;
                }
                labResult.Text = $"{txtFrom.Text} 到 {txtTo.Text} 相隔 {int.Parse(txtStep.Text) - 1}\n加總為 {sumWhile}";
            }
        }

        private void btnDo_Click(object sender, EventArgs e)
        {
            int num = 0, num1 = 0, num2 = 0, sumDo = 0;
            bool isNum = int.TryParse(txtFrom.Text, out num);
            bool isNum1 = int.TryParse(txtTo.Text, out num1);
            bool isNum2 = int.TryParse(txtStep.Text, out num2);

            if (!isNum || !isNum1 || !isNum2 || num < 0 || num1 <= 0 || num2 <= 0)
            {
                MessageBox.Show("請輸入一正確整數數值");
            }

            else if (int.Parse(txtTo.Text) % int.Parse(txtStep.Text) == 0)
            {
                int i = 0;
                do
                {
                    sumDo += (int.Parse(txtFrom.Text) + int.Parse(txtStep.Text) * i);
                    i++;
                } while (i < int.Parse(txtTo.Text) / int.Parse(txtStep.Text));
                labResult.Text = $"{txtFrom.Text} 到 {txtTo.Text} 相隔 {int.Parse(txtStep.Text) - 1}\n加總為 {sumDo}";
            }

            else
            {
                int i = 0;
                do
                {
                    sumDo += (int.Parse(txtFrom.Text) + int.Parse(txtStep.Text) * i);
                    i++;
                } while (i < int.Parse(txtTo.Text) / int.Parse(txtStep.Text)+1);
                labResult.Text = $"{txtFrom.Text} 到 {txtTo.Text} 相隔 {int.Parse(txtStep.Text) - 1}\n加總為 {sumDo}";
            }
        }

        }
    }


    


