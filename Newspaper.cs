using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_con_sblib
{
    class Newspaper : LibraryBooks
    {
        public Newspaper() : base()
        {
            newBorrowed = 0;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    newspIssue[i, j] = 0;
                }
            }
        }

       
      
    }
}
