#include <iostream>
#include <array>
using namespace std;

int main() {

  int numeros[10];
  int pesquisa;
  int contador=0;

  cout << "Insira 10 números inteiros!" << endl;

  for (int i=0; i<=9; i++ ) {
    
    cout << "Número " << i+1 << ": ";
    cin >> numeros[i];
  }

  cout << "Digite o número que você quer pesquisar: ";
  cin >> pesquisa;
  
  for (int i=0; i<=9; i++) {
      if (numeros[i] == pesquisa) {
          cout << "O número existe e está na posição " << i+1 <<endl;
          contador++;
      }
  }
  cout << "Esse número se repete " << contador << " vezes" << endl;
  
   if (contador == 0)  {
          cout << "ERR0 - O número não existe no vetor!" << endl;
  }
}
