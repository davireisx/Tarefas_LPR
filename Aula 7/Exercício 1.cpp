using namespace std;
#include <iostream>

int funcaoreverso (int reverse) {
    
    int retorno = 0;
    while (reverse) {
        retorno *= 10;
        retorno += reverse%10;
        reverse /= 10;
    }
    cout << "Este é o número de trás para frente: " << retorno << endl;
    return retorno;
}

int main()
{
    int numero;
    
    cout<<"Digite um número inteiro: ";
    cin >> numero;
    
    funcaoreverso(numero);

    return 0;
}