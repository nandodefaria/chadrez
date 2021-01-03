namespace tabuleiro
{
    abstract class Peca
    {
        public Posicao posicao {get; set; }
        public Cor cor { get; private set; }
        public int qntMovimentos { get; private set; }

        public Tabuleiro tab { get; private set; }

        public Peca(Tabuleiro tab, Cor cor)
        {
            this.posicao = null;
            this.tab = tab;
            this.cor = cor;
            this.qntMovimentos = 0;
        }
        public void decrementarQntMovimentos()
        {
            qntMovimentos--;
        }
        public void incrementarQntMovimentos()
        {
            qntMovimentos++;
        }
       
        public bool existemMovimentosPossiveis()
        {
            bool[,] mat = movimentosPossiveis();
            for(int l=0; l< tab.linhas; l++)
            {
                for(int c=0; c< tab.colunas; c++)
                {
                    if (mat[l, c])
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        public bool podeMoverPara(Posicao pos)
        {
            return movimentosPossiveis()[pos.linha, pos.coluna];
        }
        public abstract bool[,] movimentosPossiveis();
    }
}
