using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_con_sblib
{
    sealed class Admin : LibraryBooks
    {
       
        public int StuNo;
        public Admin()
        {
           
            StuNo = 0;
        }
      
        String[,] sname = new String[5, 2];
        

        public void createStudent(String name, String pawd)     //[0,0] = student name , [0,1] = student password
        {
            for (int i = 0; i <= this.StuNo; i++)
            {
                for (int j = 0; j < 1; j++)
                {
                    this.sname[i, j] = name;
                }
                for (int j = 1; j < 2; j++)
                {
                    this.sname[i, j] = pawd;
                }
            }

        }

        

        public int Stuchk(String n, String p)
        {
            int dla = 0;
            if (this.StuNo == 0)
            {
                return 2;
            }
            else
            {
                for (int i = 0; i < StuNo; i++)
                {
                    for (int j = 0; j < 1; j++)
                    {
                        if (this.sname[i, j].Equals(n))
                        {
                            dla = 1;
                            if (this.sname[i, j + 1].Equals(n))
                            {
                                return 1;
                            }
                        }
                    }
                }
            }
            if (dla == 0)
                return 2;
            else
                return 0;
        }

      

        public void viewStu()
        {
            Console.WriteLine("Name " + "       " + "Password");
            for (int i = 0; i < this.StuNo; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write(this.sname[i, j] + "        ");
                }
                Console.WriteLine(" ");
            }
        }

        public override void catalogue()
        {
            String ans = "yes";
            do
            {
                Console.WriteLine("************************************************");
                Console.WriteLine("| 1.View available copies of Books             |");
                Console.WriteLine("| 2.Add Books                                  |");
                Console.WriteLine("| 3.Delete Books                               |");
                Console.WriteLine("| 4.View available copies of newspapers        |");
                Console.WriteLine("| 5.Add newspaper                              |");
                Console.WriteLine("| 6.Delete newspaper                           |");
                Console.WriteLine("| 7.Main Menu                                  |");
                Console.WriteLine("| Please Enter your Choice                     |");
                Console.WriteLine("************************************************");
                Console.WriteLine("");
                int n = int.Parse(Console.ReadLine());
                switch(n)
                {
                    case 1:
                        Console.WriteLine("Book ID " + " " + "Available copies");

                    for (int i = 0; i < 5; i++)
                    {
                        for (int j = 0; j < 2; j++)
                        {
                            Console.Write(this.book[i, j] + "             ");
                        }
                        Console.WriteLine("");
                    }

                    break;

                    case 2:
                        Console.WriteLine("Enter the ID of the book");
                    String sn = Console.ReadLine();
                    Console.WriteLine("Enter the no. of copies you want to add");
                    int ner = int.Parse(Console.ReadLine());
                    for (int i = 0; i < 5; i++)
                    {
                        for (int j = 0; j < 2; j++)
                        {
                            String sd = book[i, j].ToString();
                            if (sd.Equals(sn))
                            {
                                book[i, j + 1] = (int)book[i, j + 1] + ner;
                                break;
                            }
                        }
                    }
                    break;

                    case 3:
                        Console.WriteLine("Enter the ID of the books");
                    String sn1 = Console.ReadLine();
                    Console.WriteLine("Enter the no. of copies you want to remove");
                    int n2 = int.Parse(Console.ReadLine());
                    for (int i = 0; i < 5; i++)
                    {
                        for (int j = 0; j < 1; j++)
                        {
                            String sd = book[i, j].ToString();
                            if (sd.Equals(sn1))
                            {
                                book[i, j + 1] = (int)book[i, j + 1] - n2;
                                break;
                            }
                        }
                    }

                    break;
                   

                    case 4:
                        Console.WriteLine("Newspaper ID " + " " + "Available copies");

                        for (int i = 0; i < 5; i++)
                        {
                            for (int j = 0; j < 2; j++)
                            {
                                Console.Write(this.newsp[i, j] + "             ");
                            }
                            Console.WriteLine("");
                        }

                        break;

                    case 5:
                        Console.WriteLine("Enter the ID of the newspaper");
                        String bn = Console.ReadLine();
                        Console.WriteLine("Enter the no. of copies you want to add");
                        int nern = int.Parse(Console.ReadLine());
                        for (int i = 0; i < 5; i++)
                        {
                            for (int j = 0; j < 2; j++)
                            {
                                String sd = newsp[i, j].ToString();
                                if (sd.Equals(bn))
                                {
                                    newsp[i, j + 1] = (int)newsp[i, j + 1] + nern;
                                    break;
                                }
                            }
                        }
                        break;

                    case 6:
                        Console.WriteLine("Enter the ID of the newspaper");
                        String bn1 = Console.ReadLine();
                        Console.WriteLine("Enter the no. of copies you want to remove");
                        int np2 = int.Parse(Console.ReadLine());
                        for (int i = 0; i < 5; i++)
                        {
                            for (int j = 0; j < 1; j++)
                            {
                                String sd = newsp[i, j].ToString();
                                if (sd.Equals(bn1))
                                {
                                    newsp[i, j + 1] = (int)newsp[i, j + 1] - np2;
                                    break;
                                }
                            }
                        }

                        break;

                    case 7:
                        return;
                }


            } while (ans.Equals("yes"));



        }


        

    }

}