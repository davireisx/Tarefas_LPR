#include <array>
#include <iostream>
using namespace std;

int main() {

  int numeros[10];
  int par[10];
  int impar[10];

  cout << "Insira 10 números inteiros!" << endl;

  for (int i = 0; i <= 9; i++) {

    cout << "Número " << i + 1 << ": ";
    cin >> numeros[i];
  }
  
  for (int i = 0; i < 10; i++) {

    if (numeros[i] % 2 == 0) {

      par[i] = numeros[i];

    } else {

      impar[i] = numeros[i];
    }
  }

  cout << "Números pares: ";
  for (int i = 0; i < 10; i++) {
    cout << par[i] << " " << endl;
  }

  cout << "Números ímpares: ";
  for (int i = 0; i < 10; i++) {
    cout << impar[i] << " " << endl;
  }
  return 0;
}