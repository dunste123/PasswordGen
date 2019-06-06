using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordVault
{
    public class Configuration
    {
        public int PasswordLength { get; set; }
        public bool LettersEnabled { get; set; }
        public bool UpperCaseEnabled { get; set; }
        public bool SpecialEnabled { get; set; }
        public bool NumbersEnabled { get; set; }

        public Configuration ()
        {
            PasswordLength = 20;
            UpperCaseEnabled = true;
            SpecialEnabled = true;
        }
    }
}
