using P120_UX_Automates.Modele;
using P120_UX_Automates.Vue;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;

namespace P120_UX_Automates.Controleur
{
    public class ControlTickets
    {
        private Aeroport _aeroportView;
        private Disneyland _disneLandView;
        private Menu _menuView;
        private ParisVisite _parisVisiteView;
        private Standard _standardView;
        private DataTicket _data;
        

        public ControlTickets(Menu menu, Standard standard, Disneyland disney, ParisVisite paris, Aeroport aeroport, DataTicket dataTicket)
        {
            _menuView = menu;
            _data = dataTicket;
            _standardView = standard;
            _disneLandView = disney;
            _parisVisiteView = paris;
            _aeroportView = aeroport;

            _menuView.Controller = this;
            _data.Controller = this;
            _standardView.Controller = this;
            _disneLandView.Controller = this;
            _parisVisiteView.Controller = this;
            _aeroportView.Controller = this;
        }

        /// <summary>
        /// Ajoute un ticket à la base de données
        /// </summary>
        /// <param name="ticket"></param>
        public void AddTicket(Tickets ticket)
        {
            _data.Tickets.Add(ticket);
        }

        /// <summary>
        /// Supprime un ticket de la base de données
        /// </summary>
        /// <param name="ticket"></param>
        public void RemoveTicket(Tickets ticket)
        {
            _data.Tickets.Remove(ticket);
        }

        public void SwitchView(string nameView)
        {
            if (nameView == "Standard")
            {
                _standardView.Show();
            }
            else if (nameView == "Disney")
            {
                _disneLandView.Show();
            }
            else if (nameView == "Paris")
            {
                _parisVisiteView.Show();
            }
            else if (nameView == "Aeroport")
            {
                _aeroportView.Show();
            }
            else if (nameView == "Menu")
            {
                _menuView.Show();
            }
        }

        /// <summary>
        /// Met à jour les langues sur toutes les pages
        /// </summary>
        /// <param name="RMANAGER"></param>
        public void UpdateLang(ResourceManager RMANAGER)
        {
            ResourceManager rManager = RMANAGER;

            /*foreach (Control c in Controls)
            {
                if (rManager.GetString(c.Name) != null)
                {
                    c.Text = rManager.GetString(c.Name);
                }
            }*/
        }

        /// <summary>
        /// Vérifie si le client a validé au moins un ticket avant de passer au paiement
        /// </summary>
        /// <returns></returns>
        public bool VerifiyTicket()
        {
            bool numberOk = false;

            if (_data.Tickets.Count > 0)
            {
                numberOk = true;
            }
            return numberOk;
        }
        
    }
}
