using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_con_sblib
{
    public interface INew
    {
        bool searchN(string s);
        void borrowN(string bor, DateTime t);
        void returnN(string s);
       
    }
}