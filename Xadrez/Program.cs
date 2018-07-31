using System;
using xadrez;
using tabuleiro;
namespace Xadrez
{
    class Program
    {
        static void Main(string[] args)
        {

            posicaoXadrez pos = new posicaoXadrez('c', 7);

            Console.WriteLine(pos);

            Console.WriteLine(pos.toPosicao());

            Console.ReadLine();
        }
    }
}
