﻿using System;
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
    public partial class Standard : Form
    {
        Controleur.ControlTickets _controller;
        Tickets _tickets;
        string _choicePerson = "";
        double _price = 0;

        public Controleur.ControlTickets Controller { get { return _controller; } set { _controller = value; } }
        public Standard()
        {
            InitializeComponent();

            for (int i = 1; i < 11; i++)
            {
                lstboxQuantity.Items.Add(i.ToString());
            }
        }

        /// <summary>
        /// Retourne au menu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReturn_Click(object sender, EventArgs e)
        { 
            this.Close();
            _controller.SwitchView("Menu");
        }

        /// <summary>
        /// Lorsque le client choisi le ticket adulte
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void btnAdult_Click(object sender, EventArgs e)
        {
            btnAdult.Font = new Font(btnAdult.Font, btnAdult.Font.Style | FontStyle.Underline);
            btnChild.Font = new Font(btnAdult.Font, btnAdult.Font.Style & ~FontStyle.Underline);
            _choicePerson = "Adulte";
            _price = 1.50;
        }

        /// <summary>
        /// Lorsque le client choisi le ticket enfant
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnChild_Click(object sender, EventArgs e)
        {
            btnChild.Font = new Font(btnAdult.Font, btnAdult.Font.Style | FontStyle.Underline);
            btnAdult.Font = new Font(btnAdult.Font, btnAdult.Font.Style & ~FontStyle.Underline);
            _choicePerson = "Enfant";
            _price = 1;
        }

        /// <summary>
        /// Valide le choix d'un ticket tout en vérifiant si les conditions sont présentes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnValid_Click(object sender, EventArgs e)
        {
            if (_choicePerson == "" || lstboxQuantity.Text == "")//Vérifie si le client a bien séléctionné les éléments nécéssaires
            {
                MessageBox.Show("Veuillez séléctionner le type et la quantité !", "Attention");
            }
            else
            {
                for (int i = 0; i < Convert.ToInt16(lstboxQuantity.Text); i++)
                {
                    _tickets = new Tickets(_choicePerson, _price, DateTime.UtcNow);
                    _controller.AddTicket(_tickets);
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
                Recap recap = new Recap();
                this.Close();
                recap.Show();                
            }
            else
            {
                MessageBox.Show("Veuillez séléctionner le type et la quantité !", "Attention");
            }
        }
    }
}