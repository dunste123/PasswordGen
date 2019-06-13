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
using System.IO;

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
            this.txbSafeLocationDSte.Text = configuration.VaultFileName;
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

        private void BtnGenOrOpenDSte_Click(object sender, EventArgs e)
        {
            if (this.txbMasterPassDSte.Text.Trim() == "")
            {
                MessageBox.Show("Please enter a password");

                return;
            }


            if (File.Exists(_configuration.VaultFileName))
            {
                OpenVault();
            }
            else
            {
                if (this.txbMasterPassDSte.Text != this.txbConfirmPassDSte.Text)
                {
                    MessageBox.Show("Paswords are not the same");

                    return;
                }

                CreateVault();

                MessageBox.Show("Vault created");
            }
        }

        private void OpenVault()
        {
            bool firstLine = true;
            using (FileStream stream = File.OpenRead(_configuration.VaultFileName))
            {
                using (StreamReader reader = new StreamReader(stream))
                {
                    while (!reader.EndOfStream)
                    {
                        string s = reader.ReadLine();
                        Console.WriteLine(s);
                        string decrypted = Crypt.DecryptString(s, this.txbMasterPassDSte.Text, _configuration.IV);
                        if (firstLine)
                        {
                            if (decrypted != this.txbMasterPassDSte.Text)
                            {
                                MessageBox.Show("Incorrect password");
                                break;
                            }
                            _configuration.MasterPass = this.txbMasterPassDSte.Text;
                            firstLine = false;
                        }
                        else
                        {
                            _configuration.Passwords.Add(decrypted);
                        }
                    }
                }
            }

            this.lbPaswordsDSte.Items.Clear();
            _configuration.Passwords.ForEach((a) => this.lbPaswordsDSte.Items.Add(a));
        }

        private void CreateVault()
        {
            _configuration.MasterPass = this.txbMasterPassDSte.Text;
            using (FileStream stream = File.Create(_configuration.VaultFileName))
            {
                using (StreamWriter writer = new StreamWriter(stream))
                {
                    writer.WriteLine(Crypt.EncryptString(this.txbMasterPassDSte.Text, this.txbMasterPassDSte.Text, _configuration.IV));

                    _configuration.Passwords.ForEach((pswd) => {
                        writer.WriteLine(Crypt.EncryptString(pswd, this.txbMasterPassDSte.Text, _configuration.IV));
                    });
                }
            }
        }
    }
}
