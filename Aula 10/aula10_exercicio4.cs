using System.Collections.Generic;

using System;
class HelloWorld {
  static void Main() {
      
    Dictionary<string, int> informacoesCidades = new Dictionary<string, int>();
    informacoesCidades.Add("Cachoeira de Minas", 11000);
    informacoesCidades.Add("Santa Rita do Sapucaí", 48000);
    informacoesCidades.Add("Vaticano", 825);
    informacoesCidades.Add("Hum", 25);
    
    int populacaoCachoeira = informacoesCidades["Cachoeira de Minas"];
    int populacaoSantaRita = informacoesCidades["Santa Rita do Sapucaí"];
    int populacaoVaticano = informacoesCidades["Vaticano"];
    int populacaoHum = informacoesCidades["Hum"];
    float media;
    
    media = (populacaoCachoeira + populacaoSantaRita + populacaoVaticano + populacaoHum)/4;
    
    Console.WriteLine("As cidades com população acima da média são: ");
    
    foreach (var cidade in informacoesCidades) if (cidade.Value > media) {
    Console.WriteLine(cidade.Key);
    }
    
    if ((populacaoCachoeira > populacaoSantaRita) && (populacaoCachoeira > populacaoVaticano) && (populacaoCachoeira > populacaoHum) && (populacaoCachoeira > populacaoHum))
    {
        Console.WriteLine("A cidade mais populosa é: Cachoeira");
    }
    
    else if ((populacaoSantaRita > populacaoCachoeira) && (populacaoSantaRita > populacaoVaticano) && (populacaoSantaRita > populacaoHum))
    {
        Console.WriteLine("A cidade mais populosa é: SantaRita");
    }
    
    else if ((populacaoVaticano > populacaoCachoeira) && (populacaoVaticano > populacaoSantaRita) && (populacaoVaticano > populacaoHum))
    {
        Console.WriteLine("A cidade mais populosa é: Vaticano");
    }
    
    else 
    {
        Console.WriteLine("A cidade mais populosa é: Hum");
    }
    
    if ((populacaoCachoeira < populacaoSantaRita) && (populacaoCachoeira < populacaoVaticano) && (populacaoCachoeira < populacaoHum) && (populacaoCachoeira < populacaoHum))
    {
        Console.WriteLine("A cidade menos populosa é: Cachoeira");
    }
    
    else if ((populacaoSantaRita < populacaoCachoeira) && (populacaoSantaRita < populacaoVaticano) && (populacaoSantaRita < populacaoHum))
    {
        Console.WriteLine("A cidade menos populosa é: Santa Rita do Sapucaí");
    }
    
    else if ((populacaoVaticano < populacaoCachoeira) && (populacaoVaticano < populacaoSantaRita) && (populacaoVaticano < populacaoHum))
    {
        Console.WriteLine("A cidade menos populosa é: Vaticano");
    }
    
    else 
    {
        Console.WriteLine("A cidade menos populosa é: Hum");
    }
    
    Console.WriteLine("Digite um valor inteiro correspondente a uma populacao para remover do dicionário de população: ");
    int valor = int.Parse(Console.ReadLine());
    
    Console.WriteLine("Cidade(s) removida(s) do dicionário: ");
    foreach (var cidade in informacoesCidades) if (cidade.Value == valor) {
    Console.WriteLine(cidade.Key);
    }
  }
}