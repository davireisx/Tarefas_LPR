using System;
class HelloWorld {
  static void Main() {
    
    Console.WriteLine("Seja bem-vindo ao treinamento Jedi!");
    Console.Write("Digite a quantidade de horas de treinamentos por dia do Jedi: ");
    int horaspordia = int.Parse(Console.ReadLine());
    
    int dias = 1000/horaspordia;
    int semanas = dias/5;
    int meses = semanas / (9/2);
    
    
    while (horaspordia > 24) {
        Console.WriteLine ("ERR0");
        Console.Write ("Insira um valor válido: ");
        horaspordia = int.Parse(Console.ReadLine());
    }
    
     Console.WriteLine($"Para atingir 1000 horas de treinamento, será preciso {dias} dias, que correspondem a {semanas} semanas, que correspondem {meses} meses de treino");
  }
}