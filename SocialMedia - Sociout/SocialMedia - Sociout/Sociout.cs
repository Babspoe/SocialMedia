using dbLibrary;
using SocialMedia___Sociout.User_Controls;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Net.Http;
using System.Windows.Forms;
using static SocialMedia___Sociout.StaticFunctions;

namespace SocialMedia___Sociout
{
    public partial class Sociout : Form
    {
        private gebruiker gebruiker;
        int gebruikersId
        { 
            get
            {
                return Convert.ToInt32(gebruiker.id);
            }
            set
            {
                gebruiker = db.SelectGebruiker(value);
            }
        }
        public Sociout(int GebruikersId)
        {
            InitializeComponent();
            gebruikersId = GebruikersId;
        }
        public Sociout()
        {
            InitializeComponent();
            gebruikersId = 2;
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



        private void Sociout_Load(object sender, EventArgs e)
        {
            tpZoeken.Parent = null;
            pbProfiel.Image = ByteArrayToImage(gebruiker.Afbeelding);
            Homepage_Load();
            Persoonlijk_Load();
            BerichtAanmaken_Load();
            Volgend_Load();
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


        #region Zoeken

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
        #endregion
        #region Homepage
        private void Homepage_Load()
        {
            flpHomePage.Controls.Clear();

            foreach (var post in db.SelectBericht(BerichtenOpvraag.Alles))
            {
                var control = new PostUserControl(post,gebruikersId);
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
                tp.Controls.Add(new ProfielUserControl(gebruiker, this, gebruikersId.ToString()) { Name = gebruiker.id });
                tcPaginas.SelectTab(tp);
            }
        }


        #endregion
        #region Volgend
        private void Volgend_Load()
        {
            foreach (var post in db.SelectBericht(BerichtenOpvraag.Volgt, gebruikersId))
            {
                var control = new PostUserControl(post);
                control.OpenReacties += new EventHandler(OpenReactions);
                control.OpenProfile += new EventHandler(OpenProfile);
                flpVolgend.Controls.Add(control);
            }
        }

        #endregion
        #region Persoonlijk
        private void Persoonlijk_Load()
        {
            tpPersoonlijk.Controls.Add(new ProfielUserControl(gebruiker, this, true) { Dock = DockStyle.Fill });
        }
        #endregion
        #region Bericht Aanmaken
        private void BerichtAanmaken_Load()
        {
            tpBerichtAanmaken.Controls.Add(new CreatePostUserControl(gebruiker, this) { Dock = DockStyle.Fill });
        }

        #endregion
    }
}
