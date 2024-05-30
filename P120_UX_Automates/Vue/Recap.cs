///ETML
///Auteur : Kaeno Eyer
///Date : 02.05.2024
///Description : Code de la Vue de la page Recap
///
using System;
using System.Resources;
using System.Windows.Forms;

namespace P120_UX_Automates.Vue
{
    public partial class Recap : Form
    {
        Controleur.ControlTickets _controller;
        public Controleur.ControlTickets Controller { get { return _controller; } set { _controller = value; } }

        public Recap()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Montre les tickets enregistrés
        /// </summary>
        public void ShowTickets()
        {
            lbl_recap.Text = _controller.ShowTicketsDataQty();
            lbl_date.Text = _controller.ShowTicketsDate();
            lbl_price.Text = _controller.ShowTicketsPrice();
        }

        /// <summary>
        /// Retourne au menu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNo_Click(object sender, EventArgs e)
        {
            this.Hide();
            _controller.SwitchView("Menu");
        }

        /// <summary>
        /// Mène à la page Choix de paiement
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnYes_Click(object sender, EventArgs e)
        {
            this.Hide();
            _controller.SwitchView("typeOfPayment");
        }

        /// <summary>
        /// Met à jour la langue dans la page Recap
        /// </summary>
        /// <param name="RMANAGER"></param>
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
