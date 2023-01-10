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
                gebruiker newgebruiker = new gebruiker
                {
                    Gebruikersnaam = tbRNaam.Text,
                    Email = tbREmail.Text,
                    Wachtwoord = Encrypt(tbRWachtwoord.Text),
                };
                db.InsertGebruiker(newgebruiker);

                splitContainer1.Panel2Collapsed = true;
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

        }
    }
}
