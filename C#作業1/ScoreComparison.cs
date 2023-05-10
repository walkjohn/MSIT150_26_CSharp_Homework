using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C_作業1
{
    public partial class ScoreComparison : Form
    {
        public ScoreComparison()
        {
            InitializeComponent();
        }

        Subject sub;

        private void SubjectAndScore()
        {
            int score = 0, score1 = 0, score2 = 0;
            bool isNumChinese = int.TryParse(txtChinese.Text, out score);

            if (!isNumChinese)
            {
                MessageBox.Show("請輸入國文的正確分數");
                txtChinese.Clear();
                txtChinese.Focus();
            }
            else
                sub.Chinese = int.Parse(txtChinese.Text);


            bool isNumEnglish = int.TryParse(txtEnglish.Text, out score1);
            if (!isNumEnglish)
            {
                MessageBox.Show("請輸入英文的正確分數");
                txtEnglish.Clear();
                txtEnglish.Focus();
            }
            else
                sub.English = int.Parse(txtEnglish.Text);

            bool isNumMath = int.TryParse(txtMath.Text, out score2);
            if (!isNumMath)
            {
                MessageBox.Show("請輸入數學的正確分數");
                txtMath.Clear();
                txtMath.Focus();
            }
            else
                sub.Math = int.Parse(txtMath.Text);

            //sub.Chinese = int.Parse(txtChinese.Text);
            //sub.English = int.Parse(txtEnglish.Text);
            //sub.Math = int.Parse(txtMath.Text);
        }

       

        private void btnSave_Click(object sender, EventArgs e)
        {
            sub.Name=txtName.Text;
            SubjectAndScore();

        }

        private void btnShowSave_Click(object sender, EventArgs e)
        {
            sub.Name = txtName.Text;
            SubjectAndScore();
            labScore.Text = $"姓名:{sub.Name}\n國文:{sub.Chinese}分\n英文:{sub.English}分\n數學:{sub.Math}分";
            //待修:必須按下儲存後才會顯示
        }

        private void btnHighVSLow_Click(object sender, EventArgs e)
        {
            SubjectAndScore();

            if(sub.Chinese> sub.English && sub.Chinese> sub.Math && sub.English> sub.Math)
                labScoreCompare.Text = $"最高分科目成績為:國文{sub.Chinese}分\n最低分科目成績為:數學{sub.Math}分";

            if (sub.Chinese > sub.English && sub.Chinese > sub.Math && sub.Math > sub.English)
                labScoreCompare.Text = $"最高分科目成績為:國文{sub.Chinese}分\n最低分科目成績為:英文{sub.English}分";

            if (sub.English > sub.Chinese && sub.English > sub.Math && sub.Chinese > sub.Math)
                labScoreCompare.Text = $"最高分科目成績為:英文{sub.English}分\n最低分科目成績為:數學{sub.Math}分";

            if (sub.English > sub.Chinese && sub.English > sub.Math && sub.Math > sub.Chinese)
                labScoreCompare.Text = $"最高分科目成績為:英文{sub.English}分\n最低分科目成績為:國文{sub.Chinese}分";

            if (sub.Math > sub.Chinese && sub.Math > sub.English && sub.Chinese > sub.English)
                labScoreCompare.Text = $"最高分科目成績為:數學{sub.Math}分\n最低分科目成績為:英文{sub.English}分";

            if (sub.Math > sub.Chinese && sub.Math > sub.English && sub.English > sub.Chinese)
                labScoreCompare.Text = $"最高分科目成績為:數學{sub.Math}分\n最低分科目成績為:國文{sub.Chinese}分";

            if (sub.Chinese == sub.English && sub.Chinese > sub.Math)
                labScoreCompare.Text = $"最高分科目成績為:國文/英文{sub.Chinese}分\n最低分科目成績為:數學{sub.Math}分";
            if (sub.Chinese == sub.English && sub.Chinese < sub.Math)
                labScoreCompare.Text = $"最高分科目成績為:數學{sub.Math}分\n最低分科目成績為:國文/英文{sub.Chinese}分";

            if (sub.Chinese == sub.Math && sub.Chinese > sub.English)
                labScoreCompare.Text = $"最高分科目成績為:國文/數學{sub.Chinese}分\n最低分科目成績為:英文{sub.English}分";
            if (sub.Chinese == sub.Math && sub.Chinese < sub.English)
                labScoreCompare.Text = $"最高分科目成績為:英文{sub.English}分\n最低分科目成績為:國文/數學{sub.Chinese}分";

            if (sub.English == sub.Math && sub.Chinese > sub.English)
                labScoreCompare.Text = $"最高分科目成績為:國文{sub.Chinese}分\n最低分科目成績為:英文/數學{sub.English}分";
            if (sub.English == sub.Math && sub.Chinese < sub.English)
                labScoreCompare.Text = $"最高分科目成績為:英文/數學{sub.English}分\n最低分科目成績為:國文{sub.Chinese}分";

            if (sub.English == sub.Math && sub.Chinese == sub.English)
                labScoreCompare.Text = $"三個科目同分:{sub.Chinese}分";



        }
    }
}
