using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dexterity.Login.Models
{
    public class ProfileViewModel
    {
        public Dictionary<string, string> Claims { get; set; }

        public string AccessToken { get; set; }
        public string IdToken { get; set; }
    }
}
