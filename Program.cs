using System;

namespace MINIPT_3_pg._28
{
    class Program
    {
        static void Main(string[] args)
        {
        string fname;
        string lname;
        string mname;
        string birthmonth;
        string city;
        double birthdate = 0;
        double birthyear = 0;
        double age = 0;
            
            Console.WriteLine();
             Console.WriteLine("  $--//PRESS 'Enter' TO CONTINUE\\--$ ");
            Console.ReadLine();

               Console.WriteLine();
                Console.WriteLine("$--//Enter your First Name: ");
               fname = Convert.ToString(Console.ReadLine());
                 Console.WriteLine();

               Console.WriteLine("$--//Enter your Middle Name: ");
                mname = Convert.ToString(Console.ReadLine());
               Console.WriteLine();

               Console.WriteLine("$--//Enter your Last Name: ");
                lname = Convert.ToString(Console.ReadLine());
               Console.WriteLine();

               Console.WriteLine("$--//Enter your Age: ");
                age = Convert.ToDouble(Console.ReadLine());
               Console.WriteLine();

               Console.WriteLine("$--//Enter your Birth Date: ");
                birthdate = Convert.ToDouble(Console.ReadLine());
               Console.WriteLine("$--//Enter your Birth Month: ");
                 birthmonth = Convert.ToString(Console.ReadLine());
               Console.WriteLine("$--//Enter your Birth Year: ");
                  birthyear = Convert.ToDouble(Console.ReadLine());
               Console.WriteLine();

                Console.WriteLine("$--//Enter your City: ");
                 city = Convert.ToString(Console.ReadLine());
                Console.WriteLine();

                        Console.WriteLine();
                         Console.WriteLine("  $--//STUDENT DETAILS\\--$");
                        Console.WriteLine();

                Console.WriteLine(" ==========================");
                 Console.WriteLine("  $-First Name: {0} \n  $-Middle Name: {1} \n  $-Last Name : {2} \n  $-Age: {3} \n  $-Birth Date: {4} \n  $-Birth Month: {5} \n  $-Birth year: {6} \n  $-City: {7}", fname, mname, lname, age, birthdate, birthmonth, birthyear, city);
                Console.WriteLine();
                  Console.WriteLine();

            Console.WriteLine("PRESS 'Enter' TO EXIT");
            Console.ReadLine();
        }
    }
}
