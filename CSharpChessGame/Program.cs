using System;
using tabuleiro;

namespace CSharpChessGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Tabuleiro tab = new Tabuleiro(8,8);

            Tela.imprimirTabuleiro(tab);
           
        }
    }
}
