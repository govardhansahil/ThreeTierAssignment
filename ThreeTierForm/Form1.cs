using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LogicLayer;

namespace ThreeTierForm
{
    public partial class regpage : Form
    {
        DL datasend = new DL();
        accessDA newentry = new accessDA();
        public regpage()
        {
            InitializeComponent();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (txtpassword.Text == txtconfirmpassword.Text) {
                datasend.userName = txtusername.Text;
                datasend.passWord = txtpassword.Text;
                newentry.Add(datasend);
            MessageBox.Show("Successfully Registered.");


        }
            else MessageBox.Show("Passwords don't match!");
        }

        private void richTextBox4_TextChanged(object sender, EventArgs e)
        {
         
        }

        private void txtusername_TextChanged(object sender, EventArgs e)
        {
   
        }
    }
}
