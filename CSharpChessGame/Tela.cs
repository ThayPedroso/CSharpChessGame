using System;
using tabuleiro;

namespace CSharpChessGame
{
    class Tela
    {
        // Lembrete: métodos estáticos pertencem à classe e não aos objetos da classe
        public static void imprimirTabuleiro(Tabuleiro tab)
        {
            for (int i = 0; i < tab.linhas; i++)
            {
                for (int j = 0; j < tab.colunas; j++)
                {
                    if (tab.peca(i, j) == null)
                    {
                        Console.Write("- ");
                    }
                    else
                    {
                        Console.Write(tab.peca(i,j) + " ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
