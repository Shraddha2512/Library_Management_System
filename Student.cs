using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_con_sblib
{
    class Student : LibraryBooks, ILib
    {
        public Student() : base()
        {
            bksBorrowed = 0;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    bookIssue[i, j] = 0;
                }
            }
        }

        public bool searchB(string s)
        {
            bool a = true;
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 1; j++)
                {
                    String ff = book[i, j].ToString();
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

        public void borrow(String bor, DateTime t)
        {
            if (bor.Equals("b"))
            {
                Console.WriteLine("SORRY!! THIS BOOK IS ONLY FOR REFERENCE.");
                return;
            }
            Console.WriteLine(this.bksBorrowed);
            if (this.bksBorrowed < 2)
            {
                bookIssue[this.bksBorrowed, 0] = bor;
                bookIssue[this.bksBorrowed, 1] = t;
                this.bksBorrowed++;
            }
            else
            {
                Console.WriteLine("Sorry! You cannot borrow anymore books!!!!");
                Console.WriteLine("");
            }
        }
        public void returnBook(string s)
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 1; j++)
                {
                    if (book[i, j].Equals(s))
                    {
                        book[i, j + 1] = (int)book[i, j + 1] + 1;
                    }
                }
            }
            for (int i = 0; i < 1; i++)
            {
                for (int j = 0; j < 1; j++)
                {
                    if (this.bookIssue[i, j].Equals(s))
                    {
                        TimeSpan? f;

                        f = DateTime.Today - (DateTime)this.bookIssue[i, j + 1];

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
        public void Details()
        {
            Console.WriteLine("Name" + "   " + "Issue Date");
            for (int i = 0; i < this.bksBorrowed; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write(this.bookIssue[i, j] + "     " + "      ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("");
        }
    }
}