#include <iostream>
#include <array>
using namespace std;

int main() {

int numeros[10];
int vetorpar[10];
int vetorimpar[10];
int i=0;

  cout << "Insira 10 números inteiros!" << endl;

  for (i=0; i<=9; i++ ) {
    
    cout << "Número " << i+1 << ": ";
    cin >> numeros[i];
  }

  for (int p=0; p<=9; p++) {
  if (numeros[p] % 2 == 0 ) {
    vetorpar[p] = numeros[p];
  }

  else {
    vetorimpar[p] = numeros[p];
  }
}
  cout << "Números pares: ";
 for(int x =0; x <= 9; x++) {
    cout << vetorpar[x] << " ";
 }
  
  cout << "Números ímpares: ";
  for(int y =0; y <= 9; y++) {
      cout << vetorimpar[y] << " ";
   }
}