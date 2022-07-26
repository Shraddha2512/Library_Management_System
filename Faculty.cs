//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace cs_con_sblib
//{
//    internal class Faculty : LibraryBooks, ILib
//    {
//        public Faculty() : base()
//        {
//            bksBorrowed = 0;
//            for (int i = 0; i < 3; i++)
//            {
//                for (int j = 0; j < 2; j++)
//                {
//                    bookIssue[i, j] = 0;
//                }
//            }
//        }

//        public bool searchB(string s)
//        {
//            bool a = true;
//            for (int i = 0; i < 5; i++)
//            {
//                for (int j = 0; j < 1; j++)
//                {
//                    String ff = book[i, j].ToString();

//                    if (ff.Equals(s))
//                    {
//                        a = true;
//                        return a;
//                    }
//                    else
//                        a = false;
//                }
//            }
//            return a;
//        }
//        public void borrow(String bor, DateTime t)
//        {
//            if (bor.Equals("b"))    //book b cannot be issued as it is only for reference
//            {
//                Console.WriteLine("You cannot borrow this journal , It is for reference only!");
//                return;
//            }

//            if (this.bksBorrowed < 5)
//            {
//                bookIssue[this.bksBorrowed, 0] = bor;  //[1,0]=name, [1,1] = datetime.......[n,n++]
//                bookIssue[this.bksBorrowed, 1] = t;
//                this.bksBorrowed++;
//            }
//            else
//            {
//                Console.WriteLine("Sorry! you are not eligible !!!!!");
//            }
//        }

//        public void returnBook(string s)
//        {
//            for (int i = 0; i < 5; i++)
//            {
//                for (int j = 0; j < 1; j++)
//                {
//                    if (book[i, j].Equals(s))
//                    {
//                        book[i, j + 1] = (int)book[i, j + 1] + 1;
//                    }
//                }
//            }

//            bksBorrowed--;
//        }

//        public void Details()
//        {
//            Console.WriteLine("Name" + " " + "Issue Date");
//            for (int i = 0; i < this.bksBorrowed; i++)
//            {
//                for (int j = 0; j < 2; j++)
//                {
//                    Console.Write(this.bookIssue[i, j] + " " + " ");
//                }
//                Console.WriteLine();
//            }
//        }

//        public void renew(string k)
//        {
//            for (int i = 0; i < this.bksBorrowed; i++)
//            {
//                for (int j = 0; j < 1; j++)
//                {
//                    if (bookIssue[i, j].Equals(k))
//                    {
//                        bookIssue[i, j + 1] = DateTime.Today;
//                    }
//                }
//            }
//            Console.WriteLine("Book has been renewed!!!");
//        }
//    }
//}