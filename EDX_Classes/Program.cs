using System;


namespace EDX_Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is the student's first name?");
            string firstName = Console.ReadLine();
            Console.WriteLine("What is the student's last name?");
            string lastName = Console.ReadLine();
            Console.WriteLine("What is the student's birthdate?");
            string birthdtae = Console.ReadLine();
            Console.WriteLine("What is the student's addressLine1?");
            string addressLine1 = Console.ReadLine();
            Console.WriteLine("What is the student's addressLine2?");
            string addressLine2 = Console.ReadLine();
            Console.WriteLine("What city does student live?");
            string city = Console.ReadLine();
            Console.WriteLine("What is the student's postal number?");
            int postal = Int32.Parse(Console.ReadLine());
            Console.WriteLine("What country does student live?");
            string country = Console.ReadLine();

        }
    }
}
