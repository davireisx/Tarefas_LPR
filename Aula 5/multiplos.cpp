#include <iostream>
using namespace std;
int main()
{
    int numero1,numero2;
    
    cout<<"Digite o primeiro número: ";
    cin >> numero1;
    cout<<"Digite o segundo número: ";
    cin >> numero2;
    
 if(numero1>numero2) {
    
    if (numero1 % numero2 == 0) {
     cout<<"Os números "<< numero1 << " e " << numero2 << " SÃO MÚLTIPLOS" << endl; 
    }
    
    else {
    cout<<"Os números "<< numero1 << " e " << numero2 << " NÃO SÃO MÚLTIPLOS" << endl;
    }
    }
    
 else {
        if (numero1 % numero2 == 0) {
     cout<<"Os números "<< numero1 << " e " << numero2 << " SÃO MÚLTIPLOS" << endl; 
    }
    
    else {
    cout<<"Os números "<< numero1 << " e " << numero2 << " NÃO SÃO MÚLTIPLOS" << endl;
    }
    }
    
    return 0;
}