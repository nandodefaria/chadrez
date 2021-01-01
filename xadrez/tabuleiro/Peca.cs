namespace tabuleiro
{
    class Peca
    {
        public Posicao posicao {get; set; }
        public Cor cor { get; private set; }
        public int qntMovimentos { get; private set; }

        public Tabuleiro tab { get; private set; }

        public Peca(Tabuleiro tab, Cor cor)
        {
            posicao = null;
            this.tab = tab;
            this.cor = cor;
            qntMovimentos = 0;
        }
        public void incrementarQntMovimentos()
        {
            qntMovimentos++;
        }
    }
}
