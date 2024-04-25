using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P120_UX_Automates.Modele
{
    internal class DataTicket
    {
        Controleur.ControlTickets _controller;
        bool _canGoNext = false;//Contrôle si l'user a validé le choix d'au moins un ticket avant d'accepter de passer au récap

        List<string> _dataTicket = new List<string>();
        public List<string> dataTicket { get { return _dataTicket; } set { _dataTicket = value; } }
        public bool CanGoNext { get { return _canGoNext; } set { _canGoNext = value; } }


    }
}
