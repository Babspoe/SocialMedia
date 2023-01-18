using dbLibrary;
using System;
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
            rtxtTekst.Text = bericht.Tekst;
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
    }
}
