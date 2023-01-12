using dbLibrary;
using SocialMedia___Sociout.User_Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SocialMedia___Sociout
{
    public partial class Sociout : Form
    {
        int gebruikersId;
        public Sociout(int GebruikersId)
        {
            InitializeComponent();
            gebruikersId = GebruikersId;
        }

        dbFunctions db = new dbFunctions();

        //Voor de tabpages de tekst horizontaal zettens
        private void tcPaginas_DrawItem(object sender, DrawItemEventArgs e)
        {
            var g = e.Graphics;
            var text = this.tcPaginas.TabPages[e.Index].Text;
            var sizeText = g.MeasureString(text, this.tcPaginas.Font);

            var x = e.Bounds.Left + 3;
            var y = e.Bounds.Top + (e.Bounds.Height - sizeText.Height) / 2;

            g.DrawString(text, this.tcPaginas.Font, Brushes.Black, x, y);
        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                //Laat de zoekresultatenpage zien
                MessageBox.Show("Je klikte op Enter", "Zoeken");
            }
        }

        private void Sociout_Load(object sender, EventArgs e)
        {
            Homepage_Load();
        }

        private void Homepage_Load()
        {
            foreach(var post in db.SelectBericht())
            {
                var control = new PostUserControl(post);
                control.OpenReacties += new EventHandler(OpenReactions);
                flpHomePage.Controls.Add(control);
            }
        }

        private void OpenReactions(object sender, EventArgs e)
        {
            MessageBox.Show("DIT IS EEN REACTIE!");
        }

    }
}
