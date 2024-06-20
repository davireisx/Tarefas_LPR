
#include <iostream>
#include <array>
#include <string>
using namespace std;

struct Livro {
    string Titulo, Autor;
    int AnoPublicacao, NumeroPaginas;
    float Preco;
};

int main()
{
    array<Livro, 3> biblioteca;
    int opcao, x = 0;
    float precoTotal = 0, somaPaginas = 0, media;

    while (x == 0) {
        cout << "1) Primeiro Livro " << endl;
        cout << "2) Segundo Livro " << endl;
        cout << "3) Terceiro Livro " << endl;
        cout << "4) Calcular o preco total e média dos livros" << endl;
        cout << "5) Fechar Programa" << endl;
        cout << "Escolha uma das opções: ";
        cin >> opcao;


        switch (opcao) {
            case 1:    
                cout << "Forneça as informações do primeiro livro: " << endl;
                cout << "Título: ";
                cin >> biblioteca[0].Titulo;

                cout << "Autor: ";
                cin >> biblioteca[0].Autor;

                cout << "Ano de Publicação: ";
                cin >> biblioteca[0].AnoPublicacao;

                cout << "Número de Páginas: ";
                cin >> biblioteca[0].NumeroPaginas;

                cout << "Preço dos Livro: ";
                cin >> biblioteca[0].Preco;
                break;

            case 2:    
                cout << "Forneça as informações do segundo livro: " << endl;
                cout << "Título: ";
                cin >> biblioteca[1].Titulo;

                cout << "Autor: ";
                cin >> biblioteca[1].Autor;

                cout << "Ano de Publicação: ";
                cin >> biblioteca[1].AnoPublicacao;

                cout << "Número de Páginas: ";
                cin >> biblioteca[1].NumeroPaginas;

                cout << "Preço dos Livro: ";
                cin >> biblioteca[1].Preco;
                break;

            case 3:    
                cout << "Forneça as informações do terceiro livro: " << endl;
                cout << "Título: ";
                cin >> biblioteca[2].Titulo;

                cout << "Autor: ";
                cin >> biblioteca[2].Autor;

                cout << "Ano de Publicação: ";
                cin >> biblioteca[2].AnoPublicacao;

                cout << "Número de Páginas: ";
                cin >> biblioteca[2].NumeroPaginas;

                cout << "Preço dos Livro: ";
                cin >> biblioteca[2].Preco;
                
                break;

            case 4:
                precoTotal = 0;
                somaPaginas = 0;
                for (Livro& livro : biblioteca) {
                    somaPaginas += livro.NumeroPaginas;
                    precoTotal += livro.Preco;
                }

                media = somaPaginas / biblioteca.size();

                cout << "O preço total dos livros cadastrados é de " << precoTotal << " reais" << endl;
                cout << "E a média de páginas dos livros cadastrados é de " << media << endl;
                break;

            case 5:
                x = 1;
                cout << "Saindo..." << endl;
                break;

            default:
                cout << "ERRO - OPÇÃO INVÁLIDA " << endl;
        }
    }

    return 0;
}