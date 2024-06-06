using System;
class HelloWorld {
  static void Main() {
    
    int contador = 0;
    int somador = 0;
     
      
    Console.Write("Quantos números serão digitados? ");
    int numeros = int.Parse(Console.ReadLine());
    int numeros2 = numeros;
    
    while(numeros>0) {
        
    Console.Write("Insira o número: ");
    contador = int.Parse(Console.ReadLine());
    
    if (contador%2==0) {
    somador += contador; 
  }
  numeros--;
}
   double media = somador/numeros2;
   Console.Write($"A média dos números é {media}");
}
}