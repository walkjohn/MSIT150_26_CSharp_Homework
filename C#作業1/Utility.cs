using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C_作業1
{
    public partial class MyClass
    {
        void Method1()
        {
            MessageBox.Show("This is Method1");
        }

        private void Method2()
        {
            MessageBox.Show("This is Method2");
        }

        public void Method3()
        {
            MessageBox.Show("This is Method3");
        }

        internal void Method4()
        {
            MessageBox.Show("This is method4");
        }

        public void Method5()
        {
            Method1();
            Method2();
        }
    }
}

public class Member
{
    public String Name;
    public int Age;
}
