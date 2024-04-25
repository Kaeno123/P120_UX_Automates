using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P120_UX_Automates.Vue
{
    public partial class Recap : Form
    {
        public Recap()
        {
            InitializeComponent();
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            this.Close();
            menu.Show();
        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            TypeOfPayment typeOfPayment = new TypeOfPayment();
            this.Close();
            typeOfPayment.Show();
        }
    }
}
