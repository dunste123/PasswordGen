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
        private Configuration _configuration;
        public Form1(Configuration configuration)
        {
            this._configuration = configuration;
            InitializeComponent();

            this.numericUpDown1.Value = configuration.PasswordLength;

            this.cbLetterDSte.Checked = configuration.LettersEnabled;
            this.cbCapitalsDSte.Checked = configuration.UpperCaseEnabled;
            this.cbNumDSte.Checked = configuration.NumbersEnabled;
            this.cbSpecialDSte.Checked = configuration.SpecialEnabled;
        }

        private void BtnGenerateDSte_Click(object sender, EventArgs e)
        {
            string output =  new PasswordGenerator(_configuration).generate();

            if (output == null)
            {
                MessageBox.Show("Must check one box lol");

                return;
            }

            this.txbOutputDSte.Text = output;
            Clipboard.SetText(output);
        }

        private void CheckChanged(object sender, EventArgs e)
        {
            if (!cbCapitalsDSte.Checked && !cbLetterDSte.Checked && !cbNumDSte.Checked && !cbSpecialDSte.Checked)
            {
                cbCapitalsDSte.Checked = true;
            }

            _configuration.LettersEnabled = this.cbLetterDSte.Checked;
            _configuration.UpperCaseEnabled = this.cbCapitalsDSte.Checked;
            _configuration.NumbersEnabled = this.cbNumDSte.Checked;
            _configuration.SpecialEnabled = this.cbSpecialDSte.Checked;
        }
    }
}
