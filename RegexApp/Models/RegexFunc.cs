using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;

namespace lab5.Models
{
    public class RegexFunc
    {
        
        public static string? FindRegexInText(string text, string regular)
        {
            Regex r = new Regex(regular);
            string result = "";
          
            MatchCollection m = r.Matches(text);
            foreach (Match x in m) result += (x.Value + "\n");
            return result;
        }
    }
}
