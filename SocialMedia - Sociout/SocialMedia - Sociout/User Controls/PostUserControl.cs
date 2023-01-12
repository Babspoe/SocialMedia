using dbLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SocialMedia___Sociout.User_Controls
{
    public partial class PostUserControl : UserControl
    {
        public dynamic bericht = null;

        public PostUserControl(dynamic bericht)
        {
            InitializeComponent();
            this.bericht = bericht;
        }

        private void PostUserControl_Load(object sender, EventArgs e)
        {
            rtxtTekst.Text = bericht.Tekst;
            lblGebruikersnaam.Text = bericht.gebruiker.Gebruikersnaam;
            pbProfielAfbeelding.Image = bericht.gebruiker.Afbeelding;
            pbAfbeelding.Image = bericht.Afbeelding;
            
        }
    }
}
