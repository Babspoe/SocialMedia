using dbLibrary;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Documents;
using System.Windows.Forms;
using static SocialMedia___Sociout.StaticFunctions;

namespace SocialMedia___Sociout.User_Controls
{
    public partial class PostUserControl : UserControl
    {
        public bericht bericht = null;
        public EventHandler OpenReacties
        {
            get
            {
                return null;
            }
            set
            {
                btnReactions.Click+= value;
            }
        }
        public EventHandler Like
        {
            get
            {
                return null;
            }
            set
            {
                btnLike.Click += value;
            }
        }
        public EventHandler OpenProfile
        {
            get
            {
                return null;
            }
            set
            {
                lblGebruikersnaam.Click += value;
                pbProfielAfbeelding.Click += value;
            }
        }

        public PostUserControl(bericht bericht)
        {
            InitializeComponent();
            this.bericht = bericht;
        }

        private void PostUserControl_Load(object sender, EventArgs e)
        {
            ParseLine(bericht.Tekst);
            lblGebruikersnaam.Text = bericht.gebruiker.Gebruikersnaam;
            if(bericht.gebruiker.Afbeelding!= null)
            {
                pbProfielAfbeelding.Image = ByteArrayToImage(bericht.gebruiker.Afbeelding);
            }
            if(bericht.Afbeelding != null)
            {
                pbAfbeelding.Image = ByteArrayToImage(bericht.Afbeelding);
            }
            else
            {
                scContent.Panel1Collapsed = true;
            }
            lblLikes.Text = bericht.Likes.ToString();
        }

        void ParseLine(string line)
        {
            Regex r = new Regex("([ \\t{}():;])");
            String[] tokens = r.Split(line);

            foreach (string token in tokens)
            {
                // Set the tokens default color and font.
                rtxtTekst.SelectionColor = Color.Black;
                rtxtTekst.SelectionFont = new Font("Microsoft Sans Serif", 10, FontStyle.Regular);

                // Check whether the token is a keyword. 
                if (token[0] == '#')
                {

                    rtxtTekst.SelectedRtf = @"{\rtf1 hyperlink:{\field{\*\fldinst HYPERLINK ""https://example.org""}{\fldrslt " + token +"}}} }"; ;
                }
                else
                {
                    rtxtTekst.SelectedText = token;
                }
            }
            //rtxtTekst.SelectedText = "\n";

        }

        private void rtxtTekst_LinkClicked(object sender, LinkClickedEventArgs e)
        {
            MessageBox.Show("Werkt dit?");
        }
    }
}
