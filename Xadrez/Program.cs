﻿using System;
using xadrez;
using tabuleiro;
namespace Xadrez
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                partidaDeXadrez partida = new partidaDeXadrez();

                while(!partida.terminada){
                    Console.Clear();
                    Tela.imprimirTabuleiro(partida.tab);                      

                    Console.WriteLine();
                    Console.Write("Origem: ");
                    Posicao origem = Tela.lerPosicaoXadrez().toPosicao();
                    Console.Write("Destino: ");
                    Posicao destino = Tela.lerPosicaoXadrez().toPosicao();

                    partida.executaMovimento(origem, destino);
                    
                }

                 

            }

            catch (TabuleiroException e)
            {
                Console.WriteLine(e.Message);
            }

            Console.ReadLine();
        }
    }
}
