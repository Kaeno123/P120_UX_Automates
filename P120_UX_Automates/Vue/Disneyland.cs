using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P120_UX_Automates.Vue
{
    public partial class Disneyland : Form
    {
        string choicePerson = "";
        List<string> _listTicket = new List<string>();
        bool _canGoNext = false;

        public Disneyland()
        {
            InitializeComponent();

            for (int i = 1; i < 11; i++)
            {
                lstboxQuantity.Items.Add(i.ToString());
            }
        }

        private void btnAdult_Click(object sender, EventArgs e)
        {
            btnAdult.Font = new Font(btnAdult.Font, btnAdult.Font.Style | FontStyle.Underline);
            btnChild.Font = new Font(btnAdult.Font, btnAdult.Font.Style & ~FontStyle.Underline);
            choicePerson = "Adulte";
        }

        private void btnChild_Click(object sender, EventArgs e)
        {
            btnChild.Font = new Font(btnAdult.Font, btnAdult.Font.Style | FontStyle.Underline);
            btnAdult.Font = new Font(btnAdult.Font, btnAdult.Font.Style & ~FontStyle.Underline);
            choicePerson = "Enfant";
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            this.Close();
            menu.Show();
        }

        private void btnValid_Click(object sender, EventArgs e)
        {
            _listTicket.Add($"{choicePerson} : {lstboxQuantity.SelectedItem} ticket(s). A partir du {dateTime.Text}.");
            Console.WriteLine(_listTicket[_listTicket.Count - 1]);
            _canGoNext = true;
        }

        private void btnGoNext_Click(object sender, EventArgs e)
        {
            if (_canGoNext is true)
            {
                Recap recap = new Recap();
                this.Close();
                recap.Show();
            }
        }
    }
}
