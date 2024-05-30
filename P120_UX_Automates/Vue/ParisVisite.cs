///ETML
///Auteur : Kaeno Eyer
///Date : 25.04.2024
///Description : Code de la Vue de la page Paris Visite
///
using System;
using System.Drawing;
using System.Resources;
using System.Windows.Forms;

namespace P120_UX_Automates.Vue
{
    public partial class ParisVisite : Form
    {
        Controleur.ControlTickets _controller;
        Tickets _tickets;
        double _price = 0;
        int _nbDays = 0;
        string _ticketSave = "Ticket enregistré";

        public Controleur.ControlTickets Controller { get { return _controller; } set { _controller = value; } }
        public ParisVisite()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Conserve le choix de l'user et ce que ça implique
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdult_Click(object sender, EventArgs e)
        {
            btnAdult.Font = new Font(btnAdult.Font, btnAdult.Font.Style | FontStyle.Underline);
            btnChild.Font = new Font(btnAdult.Font, btnAdult.Font.Style & ~FontStyle.Underline);
        }

        /// <summary>
        /// Conserve le choix de l'user et ce que ça implique
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnChild_Click(object sender, EventArgs e)
        {
            btnChild.Font = new Font(btnAdult.Font, btnAdult.Font.Style | FontStyle.Underline);
            btnAdult.Font = new Font(btnAdult.Font, btnAdult.Font.Style & ~FontStyle.Underline);
        }

        /// <summary>
        /// Détermine le choix de l'user entre Adulte et Enfant
        /// </summary>
        /// <returns>Retourne le choix de ticket</returns>
        public string WhichType()
        {
            string choicePerson = "";

            if (btnAdult.Font.Underline is true)
            {
                choicePerson = btnAdult.Text;
                string[] splitPrice = lbl2e.Text.Split(' ');
                _price = Convert.ToDouble(splitPrice[0]);
            }
            else if (btnChild.Font.Underline is true)
            {
                choicePerson = btnChild.Text;
                string[] splitPrice = lbl1_50e.Text.Split(' ');
                _price = Convert.ToDouble(splitPrice[0]);
            }
            return choicePerson;
        }

        /// <summary>
        /// Met à jour la langue dans la page Paris Visite
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

        /// <summary>
        /// Retourne au Menu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
            _controller.SwitchView("Menu");
        }

        /// <summary>
        /// Vérifie si l'user à tout séléctionné, si oui, il l'enregistre et envoie un msg de confirmation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnValid_Click(object sender, EventArgs e)
        {
            if (WhichType() == "" || coboxQuantity.Text == "" || _nbDays == 0)//Vérifie si le client a bien séléctionné les éléments nécéssaires
            {
                MessageBox.Show("Veuillez séléctionner toutes les options", "Attention");
            }
            else
            {
                _tickets = new Tickets(lblParis.Text, WhichType(), _price, dateTime.Value.ToString(), _nbDays);
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
                MessageBox.Show("Veuillez séléctionner le type, la quantité, et la date de commencement !", "Attention");
            }
        }

        /// <summary>
        /// si l'user choisit une validité de 1 jour
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rdbtn1_CheckedChanged(object sender, EventArgs e)
        {
            foreach (RadioButton item in pnlDays.Controls)
            {
                if (item.Checked is true)
                {
                    _nbDays = Convert.ToInt16(item.Text);
                }
            }
            lbl2e.Text = "2 €";
            lbl1_50e.Text = "1,50 €";
        }

        /// <summary>
        /// si l'user choisit une validité de 3 jours
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rdbtn3_CheckedChanged(object sender, EventArgs e)
        {
            foreach (RadioButton item in pnlDays.Controls)
            {
                if (item.Checked is true)
                {
                    _nbDays = Convert.ToInt16(item.Text);
                }
            }
            lbl2e.Text = "4 €";
            lbl1_50e.Text = "3 €";
        }

        /// <summary>
        /// si l'user choisit une validité de 5 jours
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rdbtn5_CheckedChanged(object sender, EventArgs e)
        {
            foreach (RadioButton item in pnlDays.Controls)
            {
                if (item.Checked is true)
                {
                    _nbDays = Convert.ToInt16(item.Text);
                }
            }
            lbl2e.Text = "6 €";
            lbl1_50e.Text = "4,50 €";
        }
    }
}
