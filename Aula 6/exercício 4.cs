
using System;
class HelloWorld {
  static void Main() {
      
    int soma = 0;
    Console.Write("Digite um número: ");
    int numero = int.Parse(Console.ReadLine());
    
    string algarismos = (numero*numero).ToString();
    
    for (int i = 0; i <algarismos.Length; i++) {
        int algarismo = int.Parse(algarismos[i].ToString());
        soma += algarismo;
    }
    
    Console.WriteLine($"O quadrado do número {numero} é {algarismos}, e a soma dos seus dígitos é {soma}");
}
}