using dbLibrary;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SocialMedia___Sociout.User_Controls
{
    public partial class ReactiesUserControl : UserControl
    {
        public bericht bericht;
        public List<bericht> reacties;
        public gebruiker gebruiker;
        private Sociout parent;

        public ReactiesUserControl()
        {
            InitializeComponent();
        }

        public ReactiesUserControl(bericht b, List<bericht> r, gebruiker g, Sociout p)
        {
            InitializeComponent();
            bericht = b;
            reacties = r;
            gebruiker = g;
            parent = p;
        }

        private void ReactiesUserControl_Load(object sender, EventArgs e)
        {
            splitContainer1.Panel1.Controls.Add(new PostUserControl(bericht, Convert.ToInt32(gebruiker.id)) { Dock = DockStyle.Fill });
            foreach(var item in reacties)
            {
                flpReacties.Controls.Add(new PostUserControl(item, Convert.ToInt32(gebruiker.id)));
            }
            tpAddReactie.Controls.Add(new CreatePostUserControl(gebruiker, parent, bericht.id) { Dock = DockStyle.Fill});

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab == tpReacties)
            {
                flpReacties.Controls.Clear();

                foreach (var item in parent.db.SelectBericht(BerichtenOpvraag.Reacties, bericht.id))
                {
                    flpReacties.Controls.Add(new PostUserControl(item, Convert.ToInt32(gebruiker.id)));
                }
            }
        }
    }
}
