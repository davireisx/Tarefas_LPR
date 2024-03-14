using System;
class HelloWorld {
  static void Main() {
    
    Console.Write("Digite um número: ");
    int numero = int.Parse(Console.ReadLine());
    
    if (numero % 2 == 0) {
    Console.WriteLine($"O número {numero} é par!");
    }
    
    else {
    Console.WriteLine($"O número {numero} é impar!");    
    }
  }
}