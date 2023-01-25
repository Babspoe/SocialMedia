using dbLibrary;
using System;
using System.Windows.Forms;
using static SocialMedia___Sociout.StaticFunctions;

namespace SocialMedia___Sociout.User_Controls
{
    public partial class CreatePostUserControl : UserControl
    {
        public gebruiker gebruiker;
        public Sociout parent;
        public int berichtId = 0;
        public CreatePostUserControl(gebruiker g, Sociout p, int id = 0)
        {
            gebruiker = g;
            parent = p;
            berichtId = id;
            InitializeComponent();
        }

        public CreatePostUserControl()
        {
            InitializeComponent();
        }

        private void btnSelectAfbeelding_Click(object sender, EventArgs e)
        {
            OpenFileDialog of = new OpenFileDialog();
            //For any other formats
            of.Filter = "Image Files (*.bmp;*.jpg;*.jpeg,*.png)|*.BMP;*.JPG;*.JPEG;*.PNG";
            if (of.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.ImageLocation = of.FileName;
            }
        }

        private void btnPosten_Click(object sender, EventArgs e)
        {
            var bericht = new bericht
            {
                Afbeelding = ImageToByteArray(pictureBox1.Image),
                Tekst = richTextBox1.Text,
                gebruiker = gebruiker,
                berichtId = berichtId
            };

            parent.db.InsertBericht(bericht);
            MessageBox.Show("Gepost");
            richTextBox1.Text = "";
            pictureBox1.Image = null;
            
        }

        private void CreatePostUserControl_Load(object sender, EventArgs e)
        {
            if(berichtId != 0)
            {
                splitContainer1.Panel1Collapsed = true;
            }
        }
    }
}
