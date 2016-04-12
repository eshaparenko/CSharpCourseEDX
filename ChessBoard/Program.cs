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
                
            }
            
            Console.ReadKey();
        }
    }
}
