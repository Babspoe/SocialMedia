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
using static SocialMedia___Sociout.StaticFunctions;
using static System.Net.WebRequestMethods;

namespace SocialMedia___Sociout
{
    public partial class Sociout : Form
    {
        int gebruikersId = 1;
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

        public dbFunctions db = new dbFunctions();

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
                        newUC.ToProfiel = OpenProfile;
                        flpGebruikersZoeken.Controls.Add(newUC);
                    }
                    
                }
            }
        }

        private void Sociout_Load(object sender, EventArgs e)
        {
            tpZoeken.Parent = null;
            Homepage_Load();
            Persoonlijk_Load();
            Zoekpage_Load();
        }

        private void Zoekpage_Load()
        {
            
        }
        #region Homepage
        private void Homepage_Load()
        {
            foreach (var post in db.SelectBericht(BerichtenOpvraag.Alles))
            {
                var control = new PostUserControl(post);
                control.OpenReacties += new EventHandler(OpenReactions);
                control.OpenProfile += new EventHandler(OpenProfile);
                flpHomePage.Controls.Add(control);
            }
        }

        public void OpenReactions(object sender, EventArgs e)
        {
            //Naar Reacties van bericht
        }

        public void OpenProfile(object sender, EventArgs e)
        {
            var gebruiker = new gebruiker();
            var post = (Control)sender;
            while (!(post is PostUserControl || post is GebruikerZoekUC))
            {
                post = post.Parent;
            }
            if(post is PostUserControl)
            {
                gebruiker = ((PostUserControl)post).bericht.gebruiker;
            }
            else
            {
                gebruiker = db.SelectGebruiker(((GebruikerZoekUC)post).id);
            }
            if (tcPaginas.TabPages.ContainsKey("tpProfiel"))
            {
                if (!((TabPage)tcPaginas.GetControl(tcPaginas.TabPages.IndexOfKey("tpProfiel"))).Controls.ContainsKey(gebruiker.id))
                {
                    tcPaginas.TabPages.RemoveByKey("tpProfiel");
                }
                else
                {
                    tcPaginas.SelectTab("tpProfiel");
                    return;
                }
            }
            if(Convert.ToInt32(gebruiker.id) == gebruikersId)
            {
                tcPaginas.SelectTab("tpPersoonlijk");
            }
            else
            {
                var tp = new TabPage { Parent = tcPaginas, Name = "tpProfiel", Text = "Profiel" };
                tp.Controls.Add(new ProfielUserControl(gebruiker, this) { Name = gebruiker.id });
                tcPaginas.SelectTab(tp);
            }
        }
        private void tabopenen(object sender, EventArgs e)
        {
            TabControl tc = (TabControl)sender;
            //MessageBox.Show(tc.SelectedIndex.ToString());
            if (tc.SelectedTab != tpZoeken)
            {
                tpZoeken.Parent = null;
            }
            
        }

        #endregion
        #region Persoonlijk
        private void Persoonlijk_Load()
        {
            tpPersoonlijk.Controls.Add(new ProfielUserControl(db.SelectGebruiker(gebruikersId), this, true) { Dock = DockStyle.Fill });
        }
        #endregion
    }
}
