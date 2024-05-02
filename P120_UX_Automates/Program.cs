using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P120_UX_Automates
{
    internal static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //Création de la vue
            Vue.Menu menu = new Vue.Menu();
            Vue.Standard standard = new Vue.Standard();
            Vue.Disneyland disneyland = new Vue.Disneyland();
            Vue.ParisVisite paris = new Vue.ParisVisite();
            Vue.Aeroport aeroport = new Vue.Aeroport();

            //Création du modèle
            Modele.DataTicket DataTicket = new Modele.DataTicket();

            //Création du contrôleur
            Controleur.ControlTickets controlTickets = new Controleur.ControlTickets(menu, standard, disneyland, paris, aeroport, DataTicket);


            Application.Run(menu);
        }
    }
}
