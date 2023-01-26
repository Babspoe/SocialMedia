using dbLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
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
        string user;
        bool IsMijzelf = false;
        public ProfielUserControl()
        {
            InitializeComponent();
        }

        public ProfielUserControl(gebruiker g, Sociout p, string User, bool isMijzelf = false)
        {
            gebruiker = g;
            parent = p;
            user = User;
            IsMijzelf = isMijzelf;
            InitializeComponent();
            if (isMijzelf)
            {
                btnVolgen.Hide();
                
            }
            else
            {
                tpBewerken.Parent = null;
            }
        }
        dbFunctions db = new dbFunctions();
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


            //volgt
            //vul FLP
            flpVolgt.Controls.Clear();

            List<gebruikerZoek> geb = db.SelectVolgt(gebruiker.id);
            for (int i = 0; i < geb.Count; i++)
            {
                GebruikerZoekUC newUC = new GebruikerZoekUC(geb[i].id, geb[i].naam, geb[i].volgers, user);
                 newUC.ToProfiel = parent.OpenProfile;
                flpVolgt.Controls.Add(newUC);
            }
            if (IsMijzelf)
            {
                tbNaam.Text = gebruiker.Gebruikersnaam;
                tbEmail.Text = gebruiker.Email;
                tbWachtwoord.Text = Decrypt(gebruiker.Wachtwoord);
                pictureBox1.Image = ByteArrayToImage(gebruiker.Afbeelding);
            }

        }

        private void SetVolgend()
        {
            //Foreach met db functie om alle volgend op te vragen
        }

        private void SetBerichtInFlp(FlowLayoutPanel flp, BerichtenOpvraag bo )
        {
            foreach (var post in parent.db.SelectBericht(bo, Convert.ToInt32(gebruiker.id)))
            {
                var control = new PostUserControl(post, Convert.ToInt32(user));
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            gebruiker geb = new gebruiker()
            {
                Gebruikersnaam = tbNaam.Text,
                Email = tbEmail.Text,
                Wachtwoord = Encrypt(tbWachtwoord.Text),
                Afbeelding = ImageToByteArray(pictureBox1.Image),
            };
            db.UpdateGebruiker(geb);

            MessageBox.Show("opgeslagen");
        }

        private void tpBewerken_Click(object sender, EventArgs e)
        {

        }

        public static string Decrypt(string cipherText)
        {
            cipherText = cipherText.Replace(" ", "+");
            byte[] cipherBytes = Convert.FromBase64String(cipherText);
            using (Aes encryptor = Aes.Create())
            {
                Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes("tijdelijk", new byte[] { 0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76 });
                encryptor.Key = pdb.GetBytes(32);
                encryptor.IV = pdb.GetBytes(16);
                using (MemoryStream ms = new MemoryStream())
                {
                    using (CryptoStream cs = new CryptoStream(ms, encryptor.CreateDecryptor(), CryptoStreamMode.Write))
                    {
                        cs.Write(cipherBytes, 0, cipherBytes.Length);
                        cs.Close();
                    }
                    cipherText = Encoding.Unicode.GetString(ms.ToArray());
                }
            }
            return cipherText;
        }

        private void btnFoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog of = new OpenFileDialog();
            //For any other formats
            of.Filter = "Image Files (*.bmp;*.jpg;*.jpeg,*.png)|*.BMP;*.JPG;*.JPEG;*.PNG";
            if (of.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.ImageLocation = of.FileName;
            }
        }

        public static string Encrypt(string clearText)
        {
            byte[] clearBytes = Encoding.Unicode.GetBytes(clearText);
            using (Aes encryptor = Aes.Create())
            {
                Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes("tijdelijk", new byte[] { 0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76 });
                encryptor.Key = pdb.GetBytes(32);
                encryptor.IV = pdb.GetBytes(16);
                using (MemoryStream ms = new MemoryStream())
                {
                    using (CryptoStream cs = new CryptoStream(ms, encryptor.CreateEncryptor(), CryptoStreamMode.Write))
                    {
                        cs.Write(clearBytes, 0, clearBytes.Length);
                        cs.Close();
                    }
                    clearText = Convert.ToBase64String(ms.ToArray());
                }
            }
            return clearText;
        }
    }
}
