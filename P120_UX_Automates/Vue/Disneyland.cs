using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P120_UX_Automates.Vue
{
    public partial class Disneyland : Form
    {
        Controleur.ControlTickets _controller;
        ResourceManager language;
        Tickets _tickets;
        string _choicePerson = "";
        double _price = 0;

        public Controleur.ControlTickets Controller { get { return _controller; } set { _controller = value; } }

        public Disneyland()
        {
            InitializeComponent();

            for (int i = 1; i < 11; i++)
            {
                lstboxQuantity.Items.Add(i.ToString());
            }
        }

        private void btnAdult_Click(object sender, EventArgs e)
        {
            btnAdult.Font = new Font(btnAdult.Font, btnAdult.Font.Style | FontStyle.Underline);
            btnChild.Font = new Font(btnAdult.Font, btnAdult.Font.Style & ~FontStyle.Underline);
            _choicePerson = "Adulte";
            _price = 2;
        }

        private void btnChild_Click(object sender, EventArgs e)
        {
            btnChild.Font = new Font(btnAdult.Font, btnAdult.Font.Style | FontStyle.Underline);
            btnAdult.Font = new Font(btnAdult.Font, btnAdult.Font.Style & ~FontStyle.Underline);
            _choicePerson = "Enfant";
            _price = 1.50;
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
            _controller.SwitchView("Menu");
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

        private void btnValid_Click(object sender, EventArgs e)
        {
            if (_choicePerson == "" || lstboxQuantity.Text == "")//Vérifie si le client a bien séléctionné les éléments nécéssaires
            {
                MessageBox.Show("Veuillez séléctionner le type et la quantité !", "Attention");
            }
            else
            {
                _tickets = new Tickets(_choicePerson, _price, DateTime.UtcNow);
                _controller.AddTicket(_tickets);
                _tickets.Number = Convert.ToInt16(lstboxQuantity.Text);
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
    }
}
