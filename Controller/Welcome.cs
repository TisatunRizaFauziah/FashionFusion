using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FashionFusion.Controller
{
    internal class Welcome
    {
        public static class WelcomeAdmin
        {
            public static string namaAdmin { get; private set; }

            public static void SetLoggedInUser(string nama)
            {
                namaAdmin = nama;
            }
        }

    }
}
