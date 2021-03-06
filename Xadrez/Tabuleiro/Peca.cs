﻿
namespace tabuleiro
{
   abstract class Peca
    {
        public Posicao posicao { get; set; }
        public Cor cor { get; protected set; }
        public int qtd_movimentos { get; protected set; }
        public Tabuleiro tab { get; protected set; }


        public Peca(Tabuleiro tab, Cor cor)
        {
            this.posicao = null;
            this.tab = tab;
            this.cor = cor;
            this.qtd_movimentos = 0;

        }

        public void incrementarQtdMovimentos()
        {
            qtd_movimentos++;
        }

        public abstract bool[,] movimentosPossiveis();                                

    }
}
