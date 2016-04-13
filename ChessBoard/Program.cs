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
                    
                
            }
            
            Console.ReadKey();
        }
    }
}
