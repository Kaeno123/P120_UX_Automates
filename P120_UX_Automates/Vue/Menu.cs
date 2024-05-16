using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
