using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P120_UX_Automates
{
    public partial class Standard : Form
    {
        public Standard()
        {
            InitializeComponent();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            this.Close();
            menu.Show();
        }
    }
}
