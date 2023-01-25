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
using dbLibrary;
using static SocialMedia___Sociout.StaticFunctions;

namespace SocialMedia___Sociout
{
    public partial class InlogForm : Form
    {
        public InlogForm()
        {
            InitializeComponent();
        }

        dbFunctions db = new dbFunctions();
        private void InlogForm_Load(object sender, EventArgs e)
        {
            if (!db.tryConnection())
            {
                MessageBox.Show("Kan geen verbinding maken met de datebase");
            }

            splitContainer1.Panel2Collapsed = true;
        }

        private void btnSignin_Click(object sender, EventArgs e)
        {
            splitContainer1.Panel1Collapsed = true;
        }

        private void btnTerug_Click(object sender, EventArgs e)
        {
            splitContainer1.Panel2Collapsed = true;
        }

        private void btnRRegistreren_Click(object sender, EventArgs e)
        {
            if (tbRWachtwoord.Text == tbRWachtwoordHerhaal.Text)
            {
                if (IsValidEmail(tbREmail.Text))
                {
                    //MessageBox.Show(db.SelectCheckLogin(tbRNaam.Text));
                    if (db.SelectCheckLogin(tbRNaam.Text) == "")
                    {
                        gebruiker newgebruiker = new gebruiker
                        {
                            Gebruikersnaam = tbRNaam.Text,
                            Email = tbREmail.Text,
                            Wachtwoord = Encrypt(tbRWachtwoord.Text),
                            Afbeelding = ImageToByteArray(pictureBox1.Image),
                        };
                        db.InsertGebruiker(newgebruiker);

                        MessageBox.Show("Gebruiker opgeslagen");

                        splitContainer1.Panel2Collapsed = true;
                    }
                    else
                    {
                        MessageBox.Show("Naam bestaat al");
                    }
                }
                else
                {
                    MessageBox.Show("Geen geldige Email");
                }
            }
            else
            {
                MessageBox.Show("Wachtwoorden niet gelijk");
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

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string[] gebruiker = db.SelectLogin(tbNaam.Text, Encrypt(tbWachtwoord.Text));
            if (gebruiker[0] == "1")
            {
                Sociout m = new Sociout(Convert.ToInt16(gebruiker[1]));
                m.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Gebruiker niet gevonden");
                tbWachtwoord.Text = "";
            }
        }

        bool IsValidEmail(string email)
        {
            var trimmedEmail = email.Trim();

            if (trimmedEmail.EndsWith("."))
            {
                return false; // suggested by @TK-421
            }
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == trimmedEmail;
            }
            catch
            {
                return false;
            }
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
    }
}
