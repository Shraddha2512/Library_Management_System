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
                Console.WriteLine("Sorry!! This Book is only for reference.");
                return;
            }
            Console.WriteLine(this.bksBorrowed);
            if (this.bksBorrowed < 3)
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

        

        //public bool searchN(string s)
        //{
        //    bool a = true;
        //    for (int i = 0; i < 5; i++)
        //    {
        //        for (int j = 0; j < 1; j++)
        //        {
        //            String ff = newsp[i, j].ToString();
        //            if (ff.Equals(s))
        //            {
        //                a = true;
        //                return a;
        //            }
        //            else
        //                a = false;
        //        }
        //    }
        //    return a;
        //}

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
           
            bksBorrowed--;
        }
    }
}



        