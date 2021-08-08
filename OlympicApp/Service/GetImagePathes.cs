using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlympicApp.Service
{
    public static class GetImagePathes
    {
        public static string GetBackGround(string s)
        {
            string a;
            if (s == "Athlet")
            {
                a=Directory.GetParent(Directory.GetParent(Directory.GetParent("sdasd").ToString()).ToString()).ToString()+ @"\Image\AthletBackO.jpg";
                return a;
            }
            else if (s=="Race")
            {
                a = Directory.GetParent(Directory.GetParent(Directory.GetParent("sdasd").ToString()).ToString()).ToString() + @"\Image\GoodBackOly.png";
                return a;
            }
            a = Directory.GetParent(Directory.GetParent(Directory.GetParent("sdasd").ToString()).ToString()).ToString() + @"\Image\CountryBack.jpg";
            return a;
        }
    }
}
