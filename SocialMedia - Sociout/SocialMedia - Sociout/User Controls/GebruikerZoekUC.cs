using dbLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace SocialMedia___Sociout.User_Controls
{
    public partial class GebruikerZoekUC : UserControl
    {
        public EventHandler ToProfiel
        {
            get
            {
                return null;
            }
            set
            {
                button2.Click+= value;
            }
        }

        public GebruikerZoekUC(int idin, string name = "error", string volgers = "error", string gebruikerIn = "error")
        {
            InitializeComponent();
            lblNaam.Text = name;
            lblVolgers.Text = volgers;
            gebruiker = gebruikerIn;
            id = idin;
            naamp = name;
        }
        public int id;
        string gebruiker;
        string naamp;
        private void UserControl1_Load(object sender, EventArgs e)
        {

        }
        dbFunctions db = new dbFunctions();
        private void button1_Click(object sender, EventArgs e)
        {
            //maak volger
            volger newvolger = new volger()
            {
                Volgend = gebruiker,
                Volger = id.ToString(),
                Datum = DateTime.Now,
            };
            db.InsertVolger(newvolger);
            MessageBox.Show("Je volgt nu " + naamp);
        }

        [Browsable(true)]
        [Category("Action")]
        [Description("Invoked when user clicks button")]
        public event EventHandler ButtonClick;

        private void button2_Click(object sender, EventArgs e)
        {
            //bubble the event up to the parent
            if (this.ButtonClick != null)
                this.ButtonClick(this, e);
        }
    }
}
