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
using static SocialMedia___Sociout.StaticFunctions;

namespace SocialMedia___Sociout.User_Controls
{
    public partial class ProfielUserControl : UserControl
    {
        public gebruiker gebruiker;
        private Sociout parent;
        public ProfielUserControl()
        {
            InitializeComponent();
        }

        public ProfielUserControl(gebruiker g, Sociout p, bool isMijzelf = false)
        {
            gebruiker = g;
            parent = p;
            InitializeComponent();
            if (isMijzelf)
            {
                btnVolgen.Hide();
            }
        }

        private void ProfielUserControl_Load(object sender, EventArgs e)
        {
            //Check of je ze volgt



            if(gebruiker.Afbeelding != null)
            {
                pbPfp.Image = ByteArrayToImage(gebruiker.Afbeelding);
            }
            lblProfielNaam.Text = gebruiker.Gebruikersnaam;
            SetBerichtInFlp(flpLaatste, BerichtenOpvraag.Gebruiker);
            SetBerichtInFlp(flpGeliked, BerichtenOpvraag.Geliked);
            SetVolgend();
        }

        private void SetVolgend()
        {
            //Foreach met db functie om alle volgend op te vragen
        }

        private void SetBerichtInFlp(FlowLayoutPanel flp, BerichtenOpvraag bo )
        {
            foreach (var post in parent.db.SelectBericht(bo, Convert.ToInt32(gebruiker.id)))
            {
                var control = new PostUserControl(post);
                control.OpenReacties += new EventHandler(parent.OpenReactions);
                control.OpenProfile += new EventHandler(parent.OpenProfile);
                flp.Controls.Add(control);
            }
        }

        private void btnVolgen_Click(object sender, EventArgs e)
        {
            switch (btnVolgen.Text)
            {
                case "Volgen":
                    //db.InsertVolgen(gebruiker.Id, parent.gebruikersId);
                    break;
                case "OntVolgen":
                    //db.InsertVolgen(gebruiker.Id, parent.gebruikersId);
                    break;
            }
        }
    }
}
