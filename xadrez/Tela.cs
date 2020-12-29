using System;
using tabuleiro;


namespace xadrez
{
    class Tela
    {
        public static void imprimirTabuleiro(Tabuleiro tab)
        {
            for(int l=0; l<tab.linhas; l++)
            {
                for(int c=0; c<tab.colunas; c++)
                {
                    if (tab.peca(l, c) == null)
                    {
                        Console.Write("- ");
                    }
                    else
                    {
                        Console.Write(tab.peca(l, c) + " ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
