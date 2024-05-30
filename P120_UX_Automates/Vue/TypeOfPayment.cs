///ETML
///Auteur : Kaeno Eyer
///Date : 02.05.2024
///Description : Code de la Vue de la page Type de paiement
///
using System;
using System.Resources;
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

        /// <summary>
        /// Si l'user choisit de payer en cash
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCash_Click(object sender, EventArgs e)
        {
            this.Hide();
            _controller.SwitchView("Payment");
        }

        /// <summary>
        /// Si l'user choisit de payer avec une carte de crédit
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCreditCard_Click(object sender, EventArgs e)
        {
            this.Hide();
            _controller.SwitchView("Payment");
        }

        /// <summary>
        /// Si l'user choisit de payer avec google Pay
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGooglePay_Click(object sender, EventArgs e)
        {
            this.Hide();
            _controller.SwitchView("Payment");
        }

        /// <summary>
        /// Met à jour la langue dans la page TypeOfPayment
        /// </summary>
        /// <param name="RMANAGER">Langue sélectionnée</param>
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
