using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P120_UX_Automates.Vue
{
    public partial class TypeOfPayment : Form
    {
        Controleur.ControlTickets _controller;
        public Controleur.ControlTickets Controller { get { return _controller; } set { _controller = value; } }
        public TypeOfPayment()
        {
            InitializeComponent();
        }

        private void btnCash_Click(object sender, EventArgs e)
        {
            this.Hide();
            _controller.SwitchView("Payment");
        }

        private void btnCreditCard_Click(object sender, EventArgs e)
        {
            this.Hide();
            _controller.SwitchView("Payment");
        }

        private void btnGooglePay_Click(object sender, EventArgs e)
        {
            this.Hide();
            _controller.SwitchView("Payment");
        }

        public void UpdateLang(ResourceManager RMANAGER)
        {
            ResourceManager rManager = RMANAGER;

            foreach (Control c in Controls)
            {
                if (rManager.GetString(c.Name) != null)
                {
                    c.Text = rManager.GetString(c.Name);
                }
            }
        }
    }
}
