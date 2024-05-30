using P120_UX_Automates.Modele;
using P120_UX_Automates.Vue;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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
        /// Permet de changer de Vue
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
                _paymentView.ShowTickets();
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
        /// <param name="ticket">Ticket que l'on va retirer</param>
        public void RemoveTicket(Tickets ticket)
        {
            _dataView.Tickets.Remove(ticket);
        }

        /// <summary>
        /// Affiche la quantité de ticket en fonction de leur type (Nom) 
        /// </summary>
        /// <returns>Retourne les valeurs susmentionnées</returns>
        public string ShowTicketsDataQty()
        {
            string tickets = "Quantité / Type\n\n";
            foreach (Tickets ticket in _dataView.Tickets)
            {
                if (ticket.Validity == 0)
                {
                    tickets += $"X{ticket.Number}     {ticket.TicketName} / {ticket.Type}\n";
                }
                else
                {
                    tickets += $"X{ticket.Number}     {ticket.TicketName}({ticket.Validity}) / {ticket.Type}\n";
                }
            }
            return tickets;
        }

        /// <summary>
        /// Affiche la date du ticket en fonction de leur type (Nom) 
        /// </summary>
        /// <returns>Retourne la valeur susmentionnée</returns>
        public string ShowTicketsDate()
        {
            string tickets = "Date\n\n";
            foreach (Tickets ticket in _dataView.Tickets)
            {
                tickets += $"{ticket.ProperDate}\n";
            }
            tickets += $"\n\n                    Total   :";
            return tickets;
        }

        /// <summary>
        /// Affiche la date du ticket en fonction de leur type (Nom) 
        /// </summary>
        /// <returns>Retourne la valeur susmentionnée</returns>
        public string ShowTicketsPrice()
        {
            string tickets = "Prix\n\n";
            double sum = 0;
            foreach (Tickets ticket in _dataView.Tickets)
            {
                tickets += $"{ticket.Price} €\n";
                sum += ticket.Price * ticket.Number;
            }
            tickets += $"\n\n{sum} €";
            return tickets;
        }

        /// <summary>
        /// Vérifie si le ticket que l'user souhaite prendre n'a pas été déja choisi
        /// </summary>
        /// <param name="ticket">Ticket choisi</param>
        /// <returns>Retourne un bool disant s'il a déjà été choisi ou pas</returns>
        public bool CheckTicketSelected(Tickets ticket, int quantity)
        {
            bool ticketAlreadySelected = false;
            foreach (Tickets t in _dataView.Tickets)
            {
                if (t.TicketName == ticket.TicketName && t.Type == ticket.Type && t.Date == ticket.Date && t.Validity == ticket.Validity)
                {
                    t.Number += quantity;
                    ticketAlreadySelected = true;
                }
            }
            return ticketAlreadySelected;
        }

        /// <summary>
        /// Vérifie si le client a validé au moins un ticket avant de passer au paiement
        /// </summary>
        /// <returns>Vérifie si l'user a choisi au moins un ticket pour passer au paiement</returns>
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
