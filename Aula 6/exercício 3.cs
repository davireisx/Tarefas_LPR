#include <iostream>
using namespace std;
int main() {
      
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
