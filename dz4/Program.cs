using TicTacToe;
using Morze;
namespace dz4
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Write what program you need 1 - Morze , 2 - TicTacToe:");
            int a = Convert.ToInt32(Console.ReadLine());
            switch(a)
            {
                case 1:
                    cs2.Morze();
                    break;
                 case 2:
                    cs1.TicTacToe();
                    break;
            }
            
            
        }
    }
}