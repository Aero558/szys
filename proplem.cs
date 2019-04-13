using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 随机出题_四则运算_
{
    class proplem
    {
        Random rnd = new Random();
        public int a;
        public int b;
        public int c;
        public int d;
        public string Proplem(string str,out int result)
        {
            a = rnd.Next(1, 5);
            b = rnd.Next(20);
            c = rnd.Next(20);
            d = rnd.Next(20);
            if (a == 1)
            {
                str = str = Convert.ToString(b +"+"+ c+"-"+d+"="); ;
                result = b + c-d;
            }
            else if (a == 2 && b > c)
            {
                str = Convert.ToString(b + "-" + c + "+"+d+"=");
                result = b - c+d;
            }
            else if (a == 4 && c != 0 && b % c == 0)
            {
                str =Convert.ToString(b + "/" + c +"+"+d+ "=");
                result = b / c+d;
            }
            else
            {
                str = Convert.ToString(b + "*" + c + "-"+d+"=");
                result = b * c-d;
            }
            return str;
        }
       
    }
}
