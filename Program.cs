using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_con_sblib
{
    class Program
    {
        static void Main(string[] args)
        {
            String ans = "yes";
            Admin ade = new Admin();
            do
            {
                Console.WriteLine("");
                Console.WriteLine("|-----------------------------------------------------|");
                Console.WriteLine("|---------WELCOME TO LIBRARY MANAGEMENT SYSTEM--------|");
                Console.WriteLine("| Please login into the any of the following accounts:|");
                Console.WriteLine("| 1.Admin                                             |");
                //Console.WriteLine("| 2.Faculty                                           |");
                Console.WriteLine("| 3.Student                                           |");
                Console.WriteLine("| Note: Please enter your choice accordingly          |");
                Console.WriteLine("|-----------------------------------------------------|");
                Console.WriteLine("");
                int ch = int.Parse(Console.ReadLine());
                Program p = new Program();
                switch (ch)
                {

                    case 1:
                        p.adm(ade);
                        break;
                    //case 2:
                    //    Console.WriteLine("Please enter your name");
                    //    String name = Console.ReadLine();
                    //    Console.WriteLine("Please enter your password");
                    //    String pwd = Console.ReadLine();
                    //    int w = ade.facchk(name, pwd);
                    //    if (w == 1)
                    //        p.fac(ade);
                    //    else if (w == 2)
                    //    {
                    //        Console.WriteLine("NEW USER!!!!");
                    //        ade.createFaculty(name, pwd);
                    //        p.fac(ade);
                    //    }
                    //    else
                    //        Console.WriteLine("Wrong password or username!!!!!");
                    //    break;
                    case 3:
                        Console.WriteLine("Please enter your name");
                        String nam = Console.ReadLine();
                        Console.WriteLine("Please enter your Password");
                        String pw = Console.ReadLine();
                        int b = ade.facchk(nam, pw);
                        if (b == 1)
                            p.Stu(ade);
                        else if (b == 2)
                        {
                            Console.WriteLine("New User!!!");
                            ade.createStudent(nam, pw);
                            p.Stu(ade);
                        }
                        else
                            Console.WriteLine("Sorry!!!!! Wrong Password or Username");

                        break;
                    default:
                        Console.WriteLine("Please enter a valid choice.");
                        break;

                }
                Console.WriteLine("Do you want to continue?");
                ans = Console.ReadLine();
            } while (ans.Equals("yes"));
        }

        //public void fac(Admin ade)
        //{
        //    String ans = "yes";
        //    Faculty f = new Faculty();
        //    ade.facNo += 1;
        //    do
        //    {
        //        Console.WriteLine("");
        //        Console.WriteLine("---------------------------------------------------");
        //        Console.WriteLine("|       Please make a choice from the following   |");
        //        Console.WriteLine("|1.Search Books                                   |");
        //        Console.WriteLine("|2.Return Books                                   |");
        //        Console.WriteLine("|3.Borrow Books                                   |");
        //        Console.WriteLine("|4.Renew a Book                                   |");
        //        Console.WriteLine("|5.View book Issue Details                        |");
        //        Console.WriteLine("|6.Read Newspaper                                 |");
        //        Console.WriteLine("|7.Borrow Newspaper                               |");
        //        Console.WriteLine("|8.View borrowed Newspaper Details                |");
        //        Console.WriteLine("|9.Return to main menu                            |");
        //        Console.WriteLine("");
        //        int ch = int.Parse(Console.ReadLine());

        //        switch (ch)
        //        {
        //            case 1:
        //                Console.WriteLine("Enter the name of the book");
        //                String name = Console.ReadLine();

        //                bool p = f.searchB(name);
        //                if (p == true)
        //                    Console.WriteLine("Book found!!");
        //                else
        //                    Console.WriteLine("Book not found!!");
        //                break;

        //            case 2:
        //                Console.WriteLine("Enter the book you want to return");
        //                String g = Console.ReadLine();

        //                f.returnBook(g);
        //                break;

        //            case 3:
        //                Console.WriteLine("Enter the name of the book");
        //                String y = Console.ReadLine();
        //                Console.WriteLine("Enter the issue date");
        //                DateTime t = Convert.ToDateTime(Console.ReadLine());
        //                f.borrow(y, t);
        //                break;

        //            case 4:
        //                Console.WriteLine("Enter the book to renew");
        //                String k = Console.ReadLine();

        //                f.renew(k);

        //                break;
        //            case 5:
        //                f.Details();
        //                break;
        //            case 6:
        //                Console.WriteLine("Enter the name of the newspaper");
        //                String _name = Console.ReadLine();
        //                bool s = f.searchB(_name);
        //                if (s == true)
        //                    Console.WriteLine("Newspaper found!!");
        //                else
        //                    Console.WriteLine("Newspaper not found!!");
        //                break;
        //            case 7:
        //                Console.WriteLine("Enter the name of the book");
        //                String c = Console.ReadLine();
        //                Console.WriteLine("Enter the issue date");
        //                DateTime d = Convert.ToDateTime(Console.ReadLine());
        //                f.borrow(c, d);
        //                break;
        //            case 8:
        //                f.Details();
        //                break;
        //            case 9:
        //                return;


        //        }
        //        Console.WriteLine("Do you want to continue???");
        //        ans = Console.ReadLine();
        //    } while (ans.Equals("yes"));

        //}

        public void Stu(Admin ade)
        {
            String ans = "yes";
            ade.StuNo++;
            Student l = new Student();

            do
            {
                Console.WriteLine("");
                Console.WriteLine("---------------------------------------------------");
                Console.WriteLine("|        Please make a choice from the following  |");
                Console.WriteLine("|1.Search Books                                   |");
                Console.WriteLine("|2.Return Books                                   |");
                Console.WriteLine("|3.Borrow Books                                   |");
                Console.WriteLine("|4.Renew a Book                                   |");
                Console.WriteLine("|5.View book Issue Details                        |");
                Console.WriteLine("|7.View Newspaper                                 |");
                Console.WriteLine("|8.Add Newspaper                                  |");
                Console.WriteLine("|9.Delete Newspaper                               |");
                Console.WriteLine("|6.Return to main menu                            |");
                Console.WriteLine("---------------------------------------------------");
                Console.WriteLine("");
                int ch = int.Parse(Console.ReadLine());

                switch (ch)
                {
                    case 1:
                        Console.WriteLine("Enter the name of the book");
                        String name = Console.ReadLine();

                        bool p = l.searchB(name);
                        if (p == true)
                            Console.WriteLine("Book found!!");
                        else
                            Console.WriteLine("Book not found!!");
                        break;

                    case 2:
                        Console.WriteLine("Enter the book you want to return");
                        String g = Console.ReadLine();

                        l.returnBook(g);
                        break;

                    case 3:
                        Console.WriteLine("Enter the name of the book");
                        String y = Console.ReadLine();
                        Console.WriteLine("Enter the issue date");
                        DateTime t = Convert.ToDateTime(Console.ReadLine());
                        l.borrow(y, t);
                        break;




                    case 4:
                        l.Details();
                        break;
                    case 6:

                        return;

                    //case 7:
                    //    Console.WriteLine("Newspaper name " + " " + "Available copies");

                    //    for (int i = 0; i < 5; i++)
                    //    {
                    //        for (int j = 0; j < 2; j++)
                    //        {
                    //            Console.Write(this.newsp[i, j] + "             ");
                    //        }
                    //        Console.WriteLine("");
                    //    }

                    //    break;


                    //case 8:
                    //    Console.WriteLine("Enter the name of the books");
                    //    String bn = Console.ReadLine();
                    //    Console.WriteLine("Enter the no. of copies you want to add?");
                    //    int nern = int.Parse(Console.ReadLine());
                    //    for (int i = 0; i < 5; i++)
                    //    {
                    //        for (int j = 0; j < 2; j++)
                    //        {
                    //            String sd = newsp[i, j].ToString();
                    //            if (sd.Equals(bn))
                    //            {
                    //                newsp[i, j + 1] = (int)newsp[i, j + 1] + nern;
                    //                break;
                    //            }
                    //        }
                    //    }
                    //    break;

                    //case 9:
                    //    Console.WriteLine("Enter the name of the books");
                    //    String bn1 = Console.ReadLine();
                    //    Console.WriteLine("Enter the no. of copies you want to remove");
                    //    int np2 = int.Parse(Console.ReadLine());
                    //    for (int i = 0; i < 5; i++)
                    //    {
                    //        for (int j = 0; j < 1; j++)
                    //        {
                    //            String sd = newsp[i, j].ToString();
                    //            if (sd.Equals(bn1))
                    //            {
                    //                book[i, j + 1] = (int)newsp[i, j + 1] - n;
                    //                break;
                    //            }
                    //        }
                    //    }

                    //    break;





                }
                Console.WriteLine("Do you want to continue???");
                ans = Console.ReadLine();
            } while (ans.Equals("yes"));

        }
        public void adm(Admin ade)
        {
            String ans = "yes";

            do
            {
                Console.WriteLine("*****");
                //Console.WriteLine("| 1.Manage Faculty              |");
                Console.WriteLine("| 2.Manage Student              |");
                Console.WriteLine("| 3.Maintain Books and Newspaper             |");
                Console.WriteLine("| 4.Return to main menu         |");
               
               
                Console.WriteLine("| Please enter your choice       |");
                Console.WriteLine("*****");
                Console.WriteLine("");
                int ch = int.Parse(Console.ReadLine());

                switch (ch)
                {
                    //case 1:
                    //    ade.viewFac();
                    //    break;
                    case 2:
                        ade.viewStu();
                        break;
                    case 3:
                        ade.catalogue();
                        break;
                   

                }
                Console.WriteLine("Do you want to continue??");
                ans = Console.ReadLine();
            }
            while (ans.Equals("yes"));

        }

    }
}

