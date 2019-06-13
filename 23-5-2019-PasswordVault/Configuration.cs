using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordVault
{
    public class Configuration
    {
        public readonly string IV = "1234567890";

        public int PasswordLength { get; set; }
        public bool LettersEnabled { get; set; }
        public bool UpperCaseEnabled { get; set; }
        public bool SpecialEnabled { get; set; }
        public bool NumbersEnabled { get; set; }

        public string VaultFileName { get; set; }
        public string MasterPass { get; set; }

        public List<string> Passwords { get; } = new List<string>();

        public Configuration ()
        {
            PasswordLength = 20;
            UpperCaseEnabled = true;
            SpecialEnabled = true;
            VaultFileName = "duncte123-password-safe.safe";
        }
    }
}
