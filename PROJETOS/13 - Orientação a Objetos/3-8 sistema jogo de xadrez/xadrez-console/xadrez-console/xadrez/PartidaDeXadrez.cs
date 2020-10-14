using System.Collections.Generic;
using tabuleiro;
using xadrez_console.xadrez;

namespace xadrez
{
    class PartidaDeXadrez
    {
        public Tabuleiro tabuleiro { get; private set; }
        public int turno { get; private set; }
        public Cor jogadorAtual { get; private set; }
        public bool terminada { get; private set; }
        private HashSet<Peca> pecas;
        private HashSet<Peca> capturadas;

        public PartidaDeXadrez()
        {
            tabuleiro = new Tabuleiro(8, 8);
            turno = 1;
            jogadorAtual = Cor.Branca;
            terminada = false;
            pecas = new HashSet<Peca>();
            capturadas = new HashSet<Peca>();
            colocarPecas();
        }

        public void executaMovimento(Posicao origem, Posicao destino)
        {
            Peca p = tabuleiro.retirarPeca(origem);
            p.IncrementarQtdMovimentos();
            Peca pecaCapturada = tabuleiro.retirarPeca(destino);
            tabuleiro.colocarPeca(p, destino);
            if (pecaCapturada != null)
            {
                capturadas.Add(pecaCapturada);
            }
        }

        public void realizaJogada(Posicao origem, Posicao destino)
        {
            executaMovimento(origem, destino);
            turno++;
            mudaJogador();
        }

        public void validarPosicaoDeOrigem(Posicao pos)
        {
            if (tabuleiro.peca(pos) == null)
            {
                throw new TabuleiroException("Não existe peça nessa posição");
            }

            if (jogadorAtual != tabuleiro.peca(pos).cor)
            {
                throw new TabuleiroException("A peça de origem escolhida não é a sua");
            }

            if (!tabuleiro.peca(pos).existeMovimentosPossiveis())
            {
                throw new TabuleiroException("Não há movimentos possíveis para a peça escolhida");
            }
        }

        public void validarPosicaoDeDestino(Posicao origem, Posicao destino)
        {
            if (!tabuleiro.peca(origem).podeMoverPara(destino))
            {
                throw new TabuleiroException("Posição de destino inválida");
            }
        }

        private void mudaJogador()
        {
            if (jogadorAtual == Cor.Branca)
            {
                jogadorAtual = Cor.Preta;
            }
            else
            {
                jogadorAtual = Cor.Branca;
            }
        }

        public HashSet<Peca> pecasCapturadas(Cor cor)
        {
            HashSet<Peca> aux = new HashSet<Peca>();

            foreach (var item in capturadas)
            {
                if (item.cor == cor)
                {
                    aux.Add(item);
                }
            }

            return aux;
        }

        public HashSet<Peca> pecasEmJogo(Cor cor)
        {
            HashSet<Peca> aux = new HashSet<Peca>();

            foreach (var item in pecas)
            {
                if (item.cor == cor)
                {
                    aux.Add(item);
                }
            }
            aux.ExceptWith(pecasCapturadas(cor));
            return aux;
        }

        public void colocarNovaPeca(char coluna, int linha, Peca peca)
        {
            tabuleiro.colocarPeca(peca, new PosicaoXadrez(coluna, linha).toPosicao());
            pecas.Add(peca);
        }

        private void colocarPecas()
        {
            colocarNovaPeca('c', 1, new Torre(tabuleiro, Cor.Branca));
            colocarNovaPeca('c', 2, new Torre(tabuleiro, Cor.Branca));
            colocarNovaPeca('d', 2, new Torre(tabuleiro, Cor.Branca));
            colocarNovaPeca('e', 2, new Torre(tabuleiro, Cor.Branca));
            colocarNovaPeca('e', 1, new Torre(tabuleiro, Cor.Branca));
            colocarNovaPeca('d', 1, new Rei(tabuleiro, Cor.Branca));

            colocarNovaPeca('c', 7, new Torre(tabuleiro, Cor.Preta));
            colocarNovaPeca('c', 8, new Torre(tabuleiro, Cor.Preta));
            colocarNovaPeca('d', 7, new Torre(tabuleiro, Cor.Preta));
            colocarNovaPeca('e', 7, new Torre(tabuleiro, Cor.Preta));
            colocarNovaPeca('e', 8, new Torre(tabuleiro, Cor.Preta));
            colocarNovaPeca('d', 8, new Rei(tabuleiro, Cor.Preta));
        }
    }
}
