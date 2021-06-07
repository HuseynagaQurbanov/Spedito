using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Spedito.Models.Account
{
    public class AccountViewModel
    {
        public RegisterViewModel Register { get; set; }

        public LoginViewModel Login { get; set; }
    }
}
