using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace PasswordVault
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGenerateDSte_Click(object sender, EventArgs e)
        {
            PasswordGenerator generator = new PasswordGenerator();

            generator.LettersEnabled = this.cbLetterDSte.Checked;
            generator.UpperCaseEnabled = this.cbCapitalsDSte.Checked;
            generator.NumbersEnabled = this.cbNumDSte.Checked;
            generator.SpecialEnabled = this.cbSpecialDSte.Checked;

            string output = generator.generate((int)this.numericUpDown1.Value);

            if (output == null)
            {
                MessageBox.Show("Must check one box lol");

                return;
            }

            this.txbOutputDSte.Text = output;
        }

        private void CheckChanged(object sender, EventArgs e)
        {
            if (!cbCapitalsDSte.Checked && !cbLetterDSte.Checked && !cbNumDSte.Checked && !cbSpecialDSte.Checked)
            {
                cbCapitalsDSte.Checked = true;
            }
        }
    }
}
