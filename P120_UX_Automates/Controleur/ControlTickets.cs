using P120_UX_Automates.Modele;
using P120_UX_Automates.Vue;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P120_UX_Automates.Controleur
{
    public class ControlTickets
    {
        private Vue.Aeroport _aeroportView;
        private Vue.Disneyland _disneLandView;
        private Vue.Menu _menuView;
        private Vue.ParisVisite _parisVisiteView;
        private Vue.Standard _standardView;
        private Modele.DataTicket _data = new Modele.DataTicket();

        public ControlTickets()
        {
                       
        }
    }
}
