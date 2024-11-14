#include <iostream>
#include <random>
using namespace std;

int main() {
    random_device numAleatorio;
    uniform_int_distribution<> distribuicao(1,100);
    
    int valorInteiro = distribuicao(numAleatorio);
    int chute;
    
    
    do {
    cout<<"Tente acertar um valor inteiro  entre 1 a 100: ";
    cin >> chute;
    
    if (chute<valorInteiro) {
        cout<< "Você chutou baixo!"<< endl;
    }
    
    else if (chute>valorInteiro) {
         cout << "Você chutou alto!"<< endl;
    }
    
    else{
        cout << "Você acertou!" << endl;
    }
} while(valorInteiro != chute);

   return 0;
}