using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
        }
    }
}
