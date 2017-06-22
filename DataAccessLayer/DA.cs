using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class DA
    {
        public static string userName;
        public static string passWord;
        public void Add(string x, string y)
        {
            userName = x;
            passWord = y;
        }
    }
}
