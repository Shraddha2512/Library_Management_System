using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_con_sblib
{
    class Newspaper : LibraryBooks, INew
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

        public bool searchN(string s)
        {
            bool a = true;
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 1; j++)
                {
                    String ff = newsp[i, j].ToString();
                    if (ff.Equals(s))
                    {
                        a = true;
                        return a;
                    }
                    else
                        a = false;
                }
            }
            return a;
        }

        public void borrowN(String bor, DateTime t)
        {
            if (bor.Equals("b"))
            {
                Console.WriteLine("Sorry!! This Newspaper is only for reference.");
                return;
            }
            Console.WriteLine(this.newBorrowed);
            if (this.newBorrowed < 2)
            {
                newspIssue[this.newBorrowed, 0] = bor;
                newspIssue[this.newBorrowed, 1] = t;
                this.newBorrowed++;
            }
            else
            {
                 Console.WriteLine("Sorry! You cannot borrow anymore Newspapers!!!!");
                Console.WriteLine("");
            }
        }
        public void returnN(string s)
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 1; j++)
                {
                    if (newsp[i, j].Equals(s))
                    {
                        newsp[i, j + 1] = (int)newsp[i, j + 1] + 1;
                    }
                }
            }
            for (int i = 0; i < 1; i++)
            {
                for (int j = 0; j < 1; j++)
                {
                    if (this.newspIssue[i, j].Equals(s))
                    {
                        TimeSpan? f;

                        f = DateTime.Today - (DateTime)this.newspIssue[i, j + 1];

                        if (f?.TotalDays > 15)
                        {
                            Console.WriteLine("Your penalty is" + f?.TotalDays * 2);
                            Console.WriteLine("");
                        }
                    }
                }
            }
            bksBorrowed--;
        }
      
    }
}
