using P120_UX_Automates.Modele;
using P120_UX_Automates.Vue;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P120_UX_Automates.Controleur
{
    public class ControlTickets
    {
        private Aeroport _aeroportView;
        private Disneyland _disneLandView;
        private Vue.Menu _menuView;
        private ParisVisite _parisVisiteView;
        private Standard _standardView;
        private DataTicket _dataView;
        private Recap _recapView;
        private TypeOfPayment _typeOfPaymentView;
        private Payment _paymentView;
        

        public ControlTickets(Vue.Menu menu, Standard standard, Disneyland disney, ParisVisite paris, Aeroport aeroport, DataTicket dataTicket, Recap recap, TypeOfPayment typeOfPayment, Payment payment)
        {
            _menuView = menu;
            _dataView = dataTicket;
            _standardView = standard;
            _disneLandView = disney;
            _parisVisiteView = paris;
            _aeroportView = aeroport;
            _recapView = recap;
            _typeOfPaymentView = typeOfPayment;
            _paymentView = payment;

            _menuView.Controller = this;
            _dataView.Controller = this;
            _standardView.Controller = this;
            _disneLandView.Controller = this;
            _parisVisiteView.Controller = this;
            _aeroportView.Controller = this;
            _recapView.Controller = this;
            _typeOfPaymentView.Controller = this;
            _paymentView.Controller = this;
        }
       
        /// <summary>
        /// 
        /// </summary>
        /// <param name="nameView"></param>
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
            else if(nameView == "Recap")
            {
                _recapView.ShowTickets();
                _recapView.Show();
            }
            else if (nameView == "typeOfPayment")
            {
                _typeOfPaymentView.Show();
            }
            else if (nameView == "Payment")
            {
                _paymentView.Show();
            }
        }

        /// <summary>
        /// Met à jour les langues sur toutes les pages
        /// </summary>
        /// <param name="RMANAGER"></param>
        public void UpdateLang(ResourceManager RMANAGER)
        {
            _aeroportView.UpdateLang(RMANAGER);
            _disneLandView.UpdateLang(RMANAGER);
            _menuView.UpdateLang(RMANAGER);
            _parisVisiteView.UpdateLang(RMANAGER);
            _standardView.UpdateLang(RMANAGER);
            _recapView.UpdateLang(RMANAGER);
            _typeOfPaymentView.UpdateLang(RMANAGER);
            _paymentView.UpdateLang(RMANAGER);
        }

        /// <summary>
        /// Ajoute un ticket à la base de données
        /// </summary>
        /// <param name="ticket"></param>
        public void AddTicket(Tickets ticket)
        {
            _dataView.Tickets.Add(ticket);
        }

        /// <summary>
        /// Supprime un ticket de la base de données
        /// </summary>
        /// <param name="ticket"></param>
        public void RemoveTicket(Tickets ticket)
        {
            _dataView.Tickets.Remove(ticket);
        }
        
        /// <summary>
        /// Affiche le récapitulatif des tickets choisies
        /// </summary>
        /// <returns>Retourne la chaine de caractère contenant toutes les informations</returns>
        public string ShowTicketsData()
        {
            string tickets = "Quantité               Type                 Date                        Prix\n\n";
            double sum = 0;
            foreach(Tickets ticket in _dataView.Tickets)
            {
                tickets += $"X{ticket.Number}                            {ticket.ticketName}             {ticket.ProperDate}          {ticket.price} CHF\n";
                sum += ticket.price * ticket.Number;
            }
            tickets += $"\n----------------------------------------------------------------------------------------------\n                                                                                               {sum} CHF";
            return tickets;
        }

        /// <summary>
        /// Vérifie si le client a validé au moins un ticket avant de passer au paiement
        /// </summary>
        /// <returns></returns>
        public bool VerifiyTicket()
        {
            bool numberOk = false;

            if (_dataView.Tickets.Count > 0)
            {
                numberOk = true;
            }
            return numberOk;
        }        
    }
}
