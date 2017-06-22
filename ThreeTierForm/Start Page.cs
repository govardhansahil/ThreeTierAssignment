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
    public partial class Start_Page : Form
    {
        accessDA dlref = new accessDA();

        public Start_Page()
        {
            InitializeComponent();
        }

        private void lnbutton_Click(object sender, EventArgs e)
        {
            if (dlref.checkun == txtusernameln.Text && dlref.checkpw == txtpasswordln.Text)
            {
                MessageBox.Show("Successfully loggedin");

            }
            else MessageBox.Show("Invalid username or password");
        }
    }
}
