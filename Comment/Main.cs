using System;
using System.Windows.Forms;


namespace Comment
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }



        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnInputEmail_Click(object sender, EventArgs e)
        {
            MyEmail f1 = new MyEmail();
            f1.ShowDialog();
        }

        private void btnCoder_Click(object sender, EventArgs e)
        {
            Coder f2 = new Coder();
            f2.ShowDialog();
        }

    }
}
