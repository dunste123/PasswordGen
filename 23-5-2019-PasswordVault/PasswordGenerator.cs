using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace PasswordVault
{

    public class PasswordGenerator
    {
        public bool LettersEnabled { get; set; }
        public bool UpperCaseEnabled { get; set; }
        public bool SpecialEnabled { get; set; }
        public bool NumbersEnabled { get; set; }

        private Configuration configuration;

        public PasswordGenerator(Configuration configuration)
        {
            this.configuration = configuration;

            this.LettersEnabled = configuration.LettersEnabled;
            this.UpperCaseEnabled = configuration.UpperCaseEnabled;
            this.SpecialEnabled = configuration.SpecialEnabled;
            this.NumbersEnabled = configuration.NumbersEnabled;
        }

        public String generate()
        {
            return generate(configuration.PasswordLength);
        }

        public string generate(int length)
        {
            StringBuilder builder = new StringBuilder();

            if (this.LettersEnabled)
            {
                builder.Append("abcdefghijklmnopqrstuvwxyz");
            }

            if (this.UpperCaseEnabled)
            {
                builder.Append("ABCDEFGHIJKLMNOPQRSTUVWXYZ");
            }

            if (this.SpecialEnabled)
            {
                builder.Append("~`'!@#$%^&*()_+{}[];:?<>,.");
            }

            if (this.NumbersEnabled)
            {
                builder.Append("1234567890");
            }

            if (builder.Length < 1)
            {
                return null;
            }

            string output = builder.ToString();
            string rand = this.RandomString(output, length);

            WriteToFile(rand);

            return rand;
        }

        private void WriteToFile(string pass)
        {
            if (!File.Exists(configuration.VaultFileName) || configuration.MasterPass == "")
            {
                return;
            }

            using (StreamWriter writer = new StreamWriter(configuration.VaultFileName, true))
            {
                writer.WriteLine(Crypt.EncryptString(pass, configuration.MasterPass, configuration.IV));
            }
        }

        private string RandomString(string valid, int length)
        {
            StringBuilder res = new StringBuilder();
            using (RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider())
            {
                byte[] uintBuffer = new byte[sizeof(uint)];

                while (length-- > 0)
                {
                    rng.GetBytes(uintBuffer);
                    uint num = BitConverter.ToUInt32(uintBuffer, 0);
                    res.Append(valid[(int)(num % (uint)valid.Length)]);
                }
            }

            return res.ToString();
        }
    }
}
