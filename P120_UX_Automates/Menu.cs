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

namespace P120_UX_Automates
{
    public partial class Menu : Form
    {
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
            UpdateLang(language);
        }
            
        private void btnEnglish_Click(object sender, EventArgs e)
        {
            foreach (Button languages in pnlLanguages.Controls)
            {
                languages.Enabled = true;
            }
            btnEnglish.Enabled = false;
            language = new ResourceManager(typeof(Langues.EN));
            UpdateLang(language);
        }

        private void btnDeutsch_Click(object sender, EventArgs e)
        {
            foreach (Button languages in pnlLanguages.Controls)
            {
                languages.Enabled = true;
            }
            btnDeutsch.Enabled = false;
            language = new ResourceManager(typeof(Langues.DE));
            UpdateLang(language);
        }

        private void btnItaliano_Click(object sender, EventArgs e)
        {
            foreach (Button languages in pnlLanguages.Controls)
            {
                languages.Enabled = true;
            }
            btnItaliano.Enabled = false;
            language = new ResourceManager(typeof(Langues.ITA));
            UpdateLang(language);
        }

        private void btnEspanol_Click(object sender, EventArgs e)
        {
            foreach (Button languages in pnlLanguages.Controls)
            {
                languages.Enabled = true;
            }
            btnEspanol.Enabled = false;
            language = new ResourceManager(typeof(Langues.ESP));
            UpdateLang(language);
        }

        private void UpdateLang(ResourceManager RMANAGER)
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
            Standard standard = new Standard();
            this.Hide();
            standard.Show();
        }

        private void btnDisneyland_Click(object sender, EventArgs e)
        {
            Disneyland disneyland = new Disneyland();
            this.Hide();
            disneyland.Show();
        }

        private void btnParisVisite_Click(object sender, EventArgs e)
        {
            ParisVisite parisVisite = new ParisVisite();
            this.Hide();
            parisVisite.Show();
        }

        private void btnAeroport_Click(object sender, EventArgs e)
        {
            Aeroport aeroport = new Aeroport();
            this.Hide();
            aeroport.Show();
        }
    }
}
