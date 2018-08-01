using System;
using tabuleiro;

namespace xadrez
{
    class partidaDeXadrez
    {
        public Tabuleiro tab { get; private set; }
        private int turno;
        private Cor JogadorAtual;
        public bool terminada {get; private set;}

        public partidaDeXadrez()
        {
            tab = new Tabuleiro(8,8);
            turno = 1;
            JogadorAtual = Cor.Branca;
            colocarPecas();
            terminada = false;

        }

        public void executaMovimento(Posicao origem, Posicao destino)
        {
            Peca p = tab.retirarPeca(origem);
            p.incrementarQtdMovimentos();
            Peca pecaCapturada = tab.retirarPeca(destino);
            tab.colocarPeca(p,destino);

        }

        private void colocarPecas()
        {

            tab.colocarPeca(new Torre(tab, Cor.Branca ), new posicaoXadrez('c',1).toPosicao());
            tab.colocarPeca(new Torre(tab, Cor.Branca ), new posicaoXadrez('c',2).toPosicao());
            tab.colocarPeca(new Torre(tab, Cor.Branca ), new posicaoXadrez('d',2).toPosicao());
            tab.colocarPeca(new Torre(tab, Cor.Branca ), new posicaoXadrez('e',2).toPosicao());
            tab.colocarPeca(new Torre(tab, Cor.Branca ), new posicaoXadrez('e',1).toPosicao());
            tab.colocarPeca(new Rei(tab, Cor.Branca ), new posicaoXadrez('d',1).toPosicao());

             tab.colocarPeca(new Torre(tab, Cor.Preta ), new posicaoXadrez('c',7).toPosicao());
            tab.colocarPeca(new Torre(tab, Cor.Preta ), new posicaoXadrez('c',8).toPosicao());
            tab.colocarPeca(new Torre(tab, Cor.Preta ), new posicaoXadrez('d',7).toPosicao());
            tab.colocarPeca(new Torre(tab, Cor.Preta ), new posicaoXadrez('e',7).toPosicao());
            tab.colocarPeca(new Torre(tab, Cor.Preta ), new posicaoXadrez('e',8).toPosicao());
            tab.colocarPeca(new Rei(tab, Cor.Preta ), new posicaoXadrez('d',8).toPosicao());
           
        }
    }
}