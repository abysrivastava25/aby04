using System;
using System.Collections.Generic;

namespace token.Models.entityModels
{
    public partial class Login
    {
        public string UserName { get; set; }
        public string Pass { get; set; }
        public string Role { get; set; }
    }
}
