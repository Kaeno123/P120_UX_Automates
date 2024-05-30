///ETML
///Auteur : Kaeno Eyer
///Date : 18.04.2024
///Description : Code de la Vue de la page Standard
///
using System;
using System.Drawing;
using System.Resources;
using System.Windows.Forms;

namespace P120_UX_Automates.Vue
{
    public partial class Standard : Form
    {
        Controleur.ControlTickets _controller;
        Tickets _tickets;
        double _price = 0;
        string _ticketSave = "Ticket enregistré";

        public Controleur.ControlTickets Controller { get { return _controller; } set { _controller = value; } }
        public Standard()
        {
            InitializeComponent();
            /*language = new ResourceManager("P120_UX_Automates.Langues.FR", typeof(Standard).Assembly);
            _ticketSave = language.GetString("Ticket enregistré");*/
        }

        /// <summary>
        /// Retourne au menu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReturn_Click(object sender, EventArgs e)
        { 
            this.Hide();
            _controller.SwitchView("Menu");
        }

        /// <summary>
        /// Conserve le choix de l'user et ce que ça implique
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void btnAdult_Click(object sender, EventArgs e)
        {
            btnAdult.Font = new Font(btnAdult.Font, btnAdult.Font.Style | FontStyle.Underline);
            btnReductPrice.Font = new Font(btnAdult.Font, btnAdult.Font.Style & ~FontStyle.Underline);
            _price = 1.50;
        }

        /// <summary>
        /// Conserve le choix de l'user et ce que ça implique
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnChild_Click(object sender, EventArgs e)
        {
            btnReductPrice.Font = new Font(btnAdult.Font, btnAdult.Font.Style | FontStyle.Underline);
            btnAdult.Font = new Font(btnAdult.Font, btnAdult.Font.Style & ~FontStyle.Underline);
            _price = 1;
        }

        /// <summary>
        /// Détermine le choix de l'user entre Adulte et Tarif réduit
        /// </summary>
        /// <returns>Retourne le choix de ticket</returns>
        public string WhichType()
        {
            string choicePerson = "";

            if (btnAdult.Font.Underline is true)
            {
                choicePerson = btnAdult.Text;
            }
            else if (btnReductPrice.Font.Underline is true)
            {
                choicePerson = btnReductPrice.Text;
            }
            return choicePerson;
        }

        /// <summary>
        /// Vérifie si l'user à tout séléctionné, si oui, il l'enregistre et envoie un msg de confirmation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnValid_Click(object sender, EventArgs e)
        {
            if (WhichType() == "" || coboxQuantity.Text == "")//Vérifie si le client a bien séléctionné les éléments nécéssaires
            {
                MessageBox.Show("Veuillez séléctionner le type et la quantité !", "Attention");
            }
            else
            {
                _tickets = new Tickets(lblStandard.Text,WhichType(), _price, dateTime.Value.ToString());
                _tickets.Number = Convert.ToInt16(coboxQuantity.Text);

                //Vérifie que le ticket n'a pas déjà été choisi, de cette manière la database et l'affichage se porte mieux
                if (_controller.CheckTicketSelected(_tickets, _tickets.Number) is false)
                {
                    _controller.AddTicket(_tickets);
                }
                MessageBox.Show(_ticketSave);
            }
        }

        /// <summary>
        /// Met à jour la langue dans la page Standard
        /// </summary>
        /// <param name="RMANAGER">Langue choisie lors de l'appelle de la méthode</param>
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

        /// <summary>
        /// Mène à la page récapitulative
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGoNext_Click(object sender, EventArgs e)
        {
            if (_controller.VerifiyTicket() is true)//Vérifie si le client a validé au moins un ticket
            {                
                this.Hide();
                _controller.SwitchView("Recap");
            }
            else
            {
                MessageBox.Show("Veuillez séléctionner le type et la quantité !", "Attention");
            }
        }
    }
}