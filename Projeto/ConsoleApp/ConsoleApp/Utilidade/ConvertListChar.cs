using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Utilidade
{
    public class ConvertListChar
    {
        public List<char> Convert(List<string> lista)
        {
            var chars = new List<char>();
            foreach (var item in lista)
                chars.AddRange(item.ToCharArray());
            return chars;
        }

    }
}
