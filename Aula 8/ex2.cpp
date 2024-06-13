#include <array>
#include <iostream>
using namespace std;

int main() {

  int numeros[10];
  int valor, total = 0;

  cout << "Insira 10 números inteiros!" << endl;

  for (int i = 0; i <= 9; i++) {

    cout << "Número " << i + 1 << ": ";
    cin >> numeros[i];
  }

  cout << "Digite o número você deseja pesquisar: ";
  cin >> valor;

  for (int i = 0; i < 10; i++) {

    if (numeros[i] == valor) {

      cout << "O número " << valor << " está na posição " << i << endl;
      total++;

    } else {

      cout << "O número " << valor << " não está no vetor." << endl;
    }

    if (i == 9 && total != 0) {
      cout << "O número " << valor << " aparece " << total << " vezes no vetor";
    }

    else {
      cout << "O número " << valor << " não aparece no vetor." << endl;
    }
  }
  return 0;
}