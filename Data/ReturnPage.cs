using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Snack_Shack.Data
{
    public static class ReturnPage
    {
        public const string HomePage = "Home/Index";
        public const string MyAccount = "Home/MyAccount";
        public const string PeopleIndex = "People/Index";
        // Keeps track of which page want to go back to
        public static String Name { get; set; }
    }
}
