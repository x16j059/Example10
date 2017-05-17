using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Example10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int age = int.Parse(tbxAge.Text);
            if (age == 60)
                LbLResult.Text = "還暦です";
          else if ( age >= 20)
                LbLResult.Text = "成人です";
            else 
                LbLResult.Text = "未成年です";
           
        }
        private void tbxAge_TextChanged(object sender, EventArgs e)
        {
        }
        private void btnJudge_Click(object sender, EventArgs e)
        {
        }
    }
}
