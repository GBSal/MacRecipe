using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MacRecipe.Models
{
    public class EmailModel
    {

        public string Name { get; set; }

        public string Selector { get; set; }

        public string InviteToken { get; set; }

       
        public string  HostName { get; set; }

    }
}