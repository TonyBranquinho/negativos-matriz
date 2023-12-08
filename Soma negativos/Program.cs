using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soma_negativos {
    class Program {
        static void Main(string[] args) {

            int m, n, i, j;

            Console.Write("Quantidade de linhas da matriz? ");
            n = int.Parse(Console.ReadLine());
            Console.Write("Quantidade de colunas da matriz? ");
            m = int.Parse(Console.ReadLine());

            int[,] matriz = new int[n, m];

            for (i = 0; i < n; i++) {
                for (j = 0; j < m; j++) {
                    Console.Write("Elemento [" + i + "," + j + "]: ");
                    matriz[i, j] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("VALORES NEGATIVOS:");
            for (i = 0; i < n; i++) {
                for (j = 0; j < m; j++) {
                    if (matriz[i, j] < 0) {
                        Console.WriteLine(matriz[i, j]);
                    }
                }
            }
        }
    }
}
