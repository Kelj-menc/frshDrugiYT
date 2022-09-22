using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frshDrugiYT
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblHello.Text = "Hello World";
        }

        private void btnSet_Click(object sender, EventArgs e)
        {
            lblHello.Text = "Hello world again..";
        }

        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            lblHello.Text = "Text has been canceled";
        }
    }
}
