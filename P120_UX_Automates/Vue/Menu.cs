///ETML
///Auteur : Kaeno Eyer
///Date : 18.04.2024
///Description : Code de la Vue de la page Menu
///
using System;
using System.Windows.Forms;
using System.Resources;

namespace P120_UX_Automates.Vue
{
    public partial class Menu : Form
    {
        Controleur.ControlTickets _controller;
        public Controleur.ControlTickets Controller { get { return _controller; } set { _controller = value; } }
        ResourceManager language;
        public Menu()
        {
            InitializeComponent();
        }

        /*Méthodes permettant de changer la langue du menu en cliquant
          sur un bouton assigné à la langue souhaitée*/
        private void btnFrancais_Click(object sender, EventArgs e)
        {
            foreach (Button languages in pnlLanguages.Controls)
            {
                languages.Enabled = true;
            }
            btnFrancais.Enabled = false;
            language = new ResourceManager(typeof(Langues.FR));
            _controller.UpdateLang(language);
        }
        
        private void btnEnglish_Click(object sender, EventArgs e)
        {
            foreach (Button languages in pnlLanguages.Controls)
            {
                languages.Enabled = true;
            }
            btnEnglish.Enabled = false;
            language = new ResourceManager(typeof(Langues.EN));
            _controller.UpdateLang(language);
        }

        private void btnDeutsch_Click(object sender, EventArgs e)
        {
            foreach (Button languages in pnlLanguages.Controls)
            {
                languages.Enabled = true;
            }
            btnDeutsch.Enabled = false;
            language = new ResourceManager(typeof(Langues.DE));
            _controller.UpdateLang(language);
        }

        private void btnItaliano_Click(object sender, EventArgs e)
        {
            foreach (Button languages in pnlLanguages.Controls)
            {
                languages.Enabled = true;
            }
            btnItaliano.Enabled = false;
            language = new ResourceManager(typeof(Langues.ITA));
            _controller.UpdateLang(language);
        }

        private void btnEspanol_Click(object sender, EventArgs e)
        {
            foreach (Button languages in pnlLanguages.Controls)
            {
                languages.Enabled = true;
            }
            btnEspanol.Enabled = false;
            language = new ResourceManager(typeof(Langues.ESP));
            _controller.UpdateLang(language);
        }

        /// <summary>
        /// Met à jour la langue dans la page Menu
        /// </summary>
        /// <param name="RMANAGER"></param>
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

        /*Méthodes permettant d'aller sur la page souhaité en fonction du bouton assigé à la page */
        private void btnStandard_Click(object sender, EventArgs e)
        {
            this.Hide();
            _controller.SwitchView("Standard");
        }

        private void btnDisneyland_Click(object sender, EventArgs e)
        {
            this.Hide();
            _controller.SwitchView("Disney");
        }

        private void btnParisVisite_Click(object sender, EventArgs e)
        {
            this.Hide();
            _controller.SwitchView("Paris");
        }

        private void btnAeroport_Click(object sender, EventArgs e)
        {
            this.Hide();
            _controller.SwitchView("Aeroport");
        }
    }
}
