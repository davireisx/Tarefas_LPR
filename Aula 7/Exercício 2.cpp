#include <iostream>
using namespace std;

void codigo1 () {
    
    int contador = 0;
    int somador = 0;
    int numeros;
     
    cout << "Quantos números serão digitados? ";
    cin >> numeros;
    int numeros2 = numeros;
    
    while(numeros>0) {
        
    cout << "Insira o número: " << endl;
     cin>> contador;
    
      if (contador%2==0) {
      somador += contador; 
      }
      numeros--;
      }
   double media = somador/numeros2;
   cout <<"A média dos números é " << media;
}


void codigo3 () {
    int resultado = 0,numeromax = 500;
    
    for (int numeromultiplo = 50; numeromultiplo <= numeromax; numeromultiplo++) {
        
        if (numeromultiplo%3 == 0) {
            
         if(numeromultiplo%2==1) {
         resultado += numeromultiplo;
        }
        }
    }
  
   cout << "O resultado da soma de todos os números mútliplos de 3 entre 50 e 500 é " << resultado << endl;
  
}

void codigo4 () {
    
    int soma = 0;
    int numero;
    cout << "Digite um número: ";
    cin>>numero;
    
    string algarismos = to_string (numero*numero);
    
    for (int i = 0; i <algarismos.length(); i++) {
        int algarismo = algarismos[i] - '0';
        soma += algarismo;
    }
    
    cout << "O quadrado do número " << numero << " é "<< algarismos << ", e a soma dos seus dígitos é "<< soma;
}

int main()
{
    int resposta;
   cout<< "1) Código 1" << endl;
   cout<< "2) Código 3" << endl;
   cout<< "3) Código 4" << endl;
   cout<< "Digite qual código você quer acessar: ";
   cin >> resposta;

   switch(resposta) {
       case 1:
       codigo1();
       break;
       
       case 2:
       codigo3();
       break;
       
       case 3:
       codigo4();
       break;
       
       default:
       cout <<"ERR0 - Opção inválida!" << endl;
       break;
   }
    return 0;
}
