using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P120_UX_Automates.Modele
{
    public class DataTicket
    {
        Controleur.ControlTickets _controller;
        bool _canGoNext = false;//Contrôle si l'user a validé le choix d'au moins un tickets avant d'accepter de passer au récap

        List<string> _dataTicket = new List<string>();
        List<Tickets> _tickets = new List<Tickets>();

        public Controleur.ControlTickets Controller { get { return _controller; } set { _controller = value; } }
        public List<string> dataTicket { get { return _dataTicket; } set { _dataTicket = value; } }
        public List<Tickets> Tickets { get { return _tickets; } set { _tickets = value; } }
        public bool CanGoNext { get { return _canGoNext; } set { _canGoNext = value; } }


    }
}
