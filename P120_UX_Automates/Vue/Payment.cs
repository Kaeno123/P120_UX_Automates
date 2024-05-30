///ETML
///Auteur : Kaeno Eyer
///Date : 02.05.2024
///Description : Code de la Vue de la page Payment
///
using System;
using System.Resources;
using System.Windows.Forms;

namespace P120_UX_Automates.Vue
{
    public partial class Payment : Form
    {
        Controleur.ControlTickets _controller;
        public Controleur.ControlTickets Controller { get { return _controller; } set { _controller = value; } }

        public Payment()
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
        /// Met à jour la langue dans la page Payment
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
