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
            //MessageBox.Show(gebruikersId +"");
        }
        public Sociout()
        {
            InitializeComponent();
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
                //MessageBox.Show("Je klikte op Enter", "Zoeken");
                tpZoeken.Parent = tcPaginas;
                tcPaginas.SelectedTab = tpZoeken;

                //vul FLP
                flpGebruikersZoeken.Controls.Clear();

                List<gebruikerZoek> geb = db.SelectGebruikerZoek(txtSearch.Text);
                for (int i = 0; i < geb.Count; i++)
                {
                    if (geb[i].id != gebruikersId)
                    {
                        GebruikerZoekUC newUC = new GebruikerZoekUC(geb[i].id, geb[i].naam, geb[i].volgers, gebruikersId.ToString());
                        //Event ToProfiel nog zetten
                        flpGebruikersZoeken.Controls.Add(newUC);
                    }
                    
                }
            }
        }

        private void Sociout_Load(object sender, EventArgs e)
        {
            tpZoeken.Parent = null;
            //Homepage_Load();
            //Zoekpage_Load();
        }

        private void Zoekpage_Load()
        {
            
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
            //Naar Reacties van bericht
        }

        private void OpenProfile(object sender, EventArgs e)
        {
            MessageBox.Show("DIT IS EEN PROFIEL OPENER");
            //Functie om profiel te openen van persoon
        }

        private void tabopenen(object sender, EventArgs e)
        {
            TabControl tc = (TabControl)sender;
            //MessageBox.Show(tc.SelectedIndex.ToString());
            if (tc.SelectedIndex != 4)
            {
                tpZoeken.Parent = null;
            }
            
        }

        protected void UserControl_ButtonClick(object sender, EventArgs e)
        {
            //handle the event 
        }
    }
}
