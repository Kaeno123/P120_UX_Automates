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
    public partial class TypeOfPayment : Form
    {
        public TypeOfPayment()
        {
            InitializeComponent();
        }

        private void btnCash_Click(object sender, EventArgs e)
        {
            Payment payment = new Payment();
            this.Close();
            payment.Show();
        }

        private void btnCreditCard_Click(object sender, EventArgs e)
        {
            Payment payment = new Payment();
            this.Close();
            payment.Show();
        }

        private void btnGooglePay_Click(object sender, EventArgs e)
        {
            Payment payment = new Payment();
            this.Close();
            payment.Show();
        }
    }
}
