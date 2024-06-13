
using System;

class Program {
    static void Main() {
    int[,] a = new int[3, 3];
        int[,] b = new int[3, 3];
        int[,] resultado = new int[3, 3];

     
    Console.WriteLine("Digite a matriz A de 9 valores:");
    for (int linha = 0; linha < 3; linha++) {
        
        for (int coluna = 0; coluna < 3; coluna++) {
        Console.Write($"A[{linha},{coluna}]: ");
        a[linha, coluna] = int.Parse(Console.ReadLine());
        }
    }

       
    Console.WriteLine("Digite a matriz B de 9 valores:");
    for (int linha = 0; linha < 3; linha++) {
        for (int coluna = 0; coluna < 3; coluna++) {
            Console.Write($"B[{linha},{coluna}]: ");
            b[linha, coluna] = int.Parse(Console.ReadLine());
            }
        }

        
    for (int linha = 0; linha < 3; linha++) {
        for (int coluna = 0; coluna < 3; coluna++) {
            
            resultado[linha, coluna] = 0;
            for (int k = 0; k < 3; k++) {
            resultado[linha, coluna] += a[linha, k] * b[k, coluna];
            }
        }
    }

       
    Console.WriteLine("A matriz da multiplicação a * b é:");
    for (int linha = 0; linha < 3; linha++) {
        for (int coluna = 0; coluna < 3; coluna++) {
            Console.Write(resultado[linha, coluna] + " ");
            }
            Console.WriteLine();
         
    }
 }
}
    