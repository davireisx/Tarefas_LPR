#include <iostream>
#include <list>
using namespace std;

int main()
{
    list <int> numeros;
    
    for (int i = 0; i<100; i++) {
        numeros.push_back (rand ()% 100);
    }
    
    numeros.sort();
    
    cout << "PASSO 1:" << endl;
    for (int num : numeros) {
        cout << num <<endl;
    }
    
    cout <<"PASSO 2:" << endl;
    
    auto it = numeros.begin();

    
	while (it != numeros.end()) {
	    
	    if(*it%2==0) {
	       it = numeros.erase(it);
	    }
	    else 
	    {
	        it++;
	    }
	    
    }
    for (int ordem : numeros) {
        cout << ordem <<endl;
	}
	

    return 0;
}