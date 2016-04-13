using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessBoard
{
    class Program
    {
        static void Main(string[] args)
        {
<<<<<<< HEAD
            for (int i = 0; i < 8; i++)
            {
                
                    if (i % 2 == 0)
                    {
                        for (int j = 0; j < 4; j++)
                        {
                            Console.Write("XO");
                            
                        }
                        Console.WriteLine();
                    }
                    else
                    {
                        for (int j = 0; j < 4; j++)
                        {
                            Console.Write("OX");
                            
                        }
                        Console.WriteLine();
                    }
                    
=======
            for (int j = 0; j <=3; j++)
            {
                if (j % 2 == 0)
                {
                    for (int i = 0; i <= 3; i++)
                    {
                        Console.Write("X0");
                    }
                }
                else
                {
                    for (int i = 0; i <= 3; i++)
                    {
                        Console.WriteLine("0X");
                    }
                }
>>>>>>> 4ac15da15a1b419894df87de714ab6c03c2fabbe
                
            }
            
            Console.ReadKey();
        }
    }
}
