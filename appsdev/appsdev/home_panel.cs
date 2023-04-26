using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace appsdev
{
    public partial class home_panel : UserControl
    {
        public home_panel()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var firstInput = textBox1.Text;
            var secondInput = textBox2.Text;

            var parent = this.Parent as Form1;

            parent.setValueFirst = firstInput;
            parent.setValueSecond = secondInput;




        }
    }
}
