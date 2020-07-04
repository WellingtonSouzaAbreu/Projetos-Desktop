#include <stdio.h>
#include <stdlib.h>
#include <iostream>
#include <stdbool.h>
#include <string>
#include <time.h>
#include <conio.h>

using namespace std;
void limpa_tela(){
     system("cls");
}

void menu(char *modo_jogo){
     int escolha;
     char tipo_jogo;

     *modo_jogo = 'B';
     while (*modo_jogo == 'B'){
        limpa_tela();
        cout << "\n---------- JOGO DA VELHA ----------\n\n\n";    // Apresenta menu inicial
        cout << "    [1]  Single Player\n\n";
        cout << "    [2]  MultiPlayer\n\n";
        cout << "    [3]  Sobre\n\n";
        cout << "    [4]  Sair\n\n\n";
        cout << " >>> ";
        cin >> escolha;

        switch(escolha){
           case 1:
              *modo_jogo = 'S';
              break;
           case 2:
              *modo_jogo = 'M';         // Verifica as escolhas feitas no menu
              break;
           case 3:
              *modo_jogo = 'B';
              limpa_tela();
              cout << "\n\n      Jogo da velha";
              cout << "\n         v. 2.0";
              cout << "\n   Autor: Wellington Souza.\n\n\n\n";
              system("pause");
              break;
           case 4:
              *modo_jogo = 'X';
              limpa_tela();
              break;
        }
     }
}

void Apresentacao(string *jogador1, string *jogador2, int *pts_x, int *pts_o, char *modo_jogo){
     limpa_tela();
     cout << "\n---------- JOGO DA VELHA ----------\n\n";
     cout << " Nome do jogador 1 (X): ";
     cin >> *jogador1;
     if(*modo_jogo == 'M'){                       // Recebe o nome dos jogadores
        cout << "\n Nome do jogador 2 (O): ";
        cin >> *jogador2;
     }
     cout << "\n";
     limpa_tela();
}

string nome_aleatorio(){
     string nomes[5] = {"Lucas", "Gulherme", "Gabriel", "Joana", "Lucia"};

     srand((unsigned)time(NULL));
     return nomes[rand() % 5];
}

void Apresenta_Placar(string jogador1, string jogador2, int pts_x, int pts_o, char *modo_jogo){
     limpa_tela();

     cout << "\n---------- JOGO DA VELHA ----------\n\n";
     cout << "                                    PLACAR\n";
     cout << "                           " << jogador1 << " = " << pts_x << "  |  " << jogador2 << " = " << pts_o << " \n\n\n";
}

void LimpaJogo(int cont_jogada, char *posicao){
     int i;
     if(cont_jogada = 1){
        for(i = 1; i < 10; i++){
           posicao[i] = ' ';
        }
     }
}

void Apresenta_Jogo(char *posicao){
     cout << "\n  1 | 2 | 3             " << posicao[1] << " | " << posicao[2] << " | " << posicao[3];
     cout << "\n ---+---+---           ---+---+---";
     cout << "\n  4 | 5 | 6             " << posicao[4] << " | " << posicao[5] << " | " << posicao[6];
     cout << "\n ---+---+---           ---+---+---";
     cout << "\n  7 | 8 | 9             " << posicao[7] << " | " << posicao[8] << " | " << posicao[9];
}

void Jogada(int cont_jogada, string jogador1, string jogador2, char *posicao, bool *jogada_valida, char *modo_jogo){
     int jogada;
     char tipo_jogada;

     cout << "\n\n\n ^ Jogue de acordo com o mapa acima\n\n";

     if (cont_jogada % 2 == 1){
        cout << " " << jogador1 << "(X). Onde deseja jogar? ";
        tipo_jogada = 'X';
     }else{
         if(*modo_jogo == 'M'){
            cout << " " << jogador2 << "(O). Onde deseja jogar? ";
            tipo_jogada = 'O';
         }
      };

     if(*modo_jogo == 'M' || cont_jogada % 2 == 1 && *modo_jogo == 'S'){
        cin >> jogada;
        if (posicao[jogada] == ' '){
           posicao[jogada] = tipo_jogada;
           *jogada_valida = true;
        }else{
            cout << "\n Jogada invalida...\n\n";
            system("pause");
         };
      }
 }

void combinacoes(int *a, int *b, int *c, int *i, char *tipo_jogada){

     switch(*i){
            case 1:
               *a = 1; *b = 2; *c = 3;
               break;
            case 2:
               *a = 4; *b = 5; *c = 6;
               break;
            case 3:
               *a = 7; *b = 8; *c = 9;
               break;
            case 4:
               *a = 1; *b = 4; *c = 7;
               break;
            case 5:
               *a = 2; *b = 5; *c = 8;
               break;
            case 6:
               *a = 3; *b = 6; *c = 9;
               break;
            case 7:
               *a = 1; *b = 5; *c = 9;
               break;
            case 8:
               *a = 3; *b = 5; *c = 7;
            break;
            case 9:
               if (*tipo_jogada == 'O'){
                  *a = 1; *b = 2; *c = 3;
                  *tipo_jogada = 'X';
                  *i = 2;
               }
         }
 }
void jogada_inteligente(char *posicao, bool *jogada_valida){
      int i, a, b , c, aleatorio;
      char tipo_jogada = 'O';

      for(i = 1; i < 10; i++){
         combinacoes(&a, &b, &c, &i, &tipo_jogada);

            if (posicao[a] == tipo_jogada && posicao[b] == tipo_jogada &&  posicao[c] == ' '){
               posicao[c] = 'O';
               *jogada_valida = true;
               break;
            }if (posicao[a] == tipo_jogada && posicao[b] == ' ' &&  posicao[c] == tipo_jogada){
               posicao[b] = 'O';
               *jogada_valida = true;
               break;
            }if (posicao[a] == ' ' && posicao[b] == tipo_jogada &&  posicao[c] == tipo_jogada){
               posicao[a] = 'O';
               *jogada_valida = true;
               break;
             }

      }
      tipo_jogada = 'O';
      for(i = 1; i < 10; i++){
         if(*jogada_valida == true){
            break;
         }
         combinacoes(&a, &b, &c, &i, &tipo_jogada);

         if (posicao[a] == tipo_jogada && posicao[b] == ' ' &&  posicao[c] == ' '){
            posicao[b] = 'O';
            *jogada_valida = true;
            break;

         }if (posicao[a] == ' ' && posicao[b] == ' ' &&  posicao[c] == tipo_jogada){
            posicao[b] = 'O';
            *jogada_valida = true;
            break;
          }
         if(i == 8){
            break;
         }
      }
      tipo_jogada == 'O';
      for(i = 1; i < 10; i++){
         if(*jogada_valida == true){
            break;
         }
         combinacoes(&a, &b, &c, &i, &tipo_jogada);

         if (posicao[a] == ' ' && posicao[b] == tipo_jogada ){
            posicao[a] = 'O';
            *jogada_valida = true;
            break;
         }if (posicao[a] == tipo_jogada && posicao[b] == ' ' || posicao[c] == tipo_jogada && posicao[b] == ' '){
            posicao[b] = 'O';
            *jogada_valida = true;
            break;
         }if ( posicao[b] == tipo_jogada &&  posicao[c] == ' '){
            posicao[c] = 'O';
            *jogada_valida = true;
            break;
          }
      }
      while (*jogada_valida == false){
         srand((unsigned)time(NULL));
         aleatorio = 1 + (rand() % 9);
         if(posicao[aleatorio] == ' '){
            posicao[aleatorio] = 'O';
            *jogada_valida = true;
         }
      }
}

void Verifica_Vitoria(char *posicao, int cont_jogada, bool *vitoria){
     char tipo_jogada;
     int i, a, b, c;
     char venceu;

     if (cont_jogada % 2 == 1){
        tipo_jogada = 'X';
     }else{
         tipo_jogada = 'O';
      };

     for(i = 1; i < 10; i++){
        switch(i){
            case 1:
               a = 1; b = 2; c = 3;
               break;
            case 2:
               a = 4; b = 5; c = 6;
               break;
            case 3:
               a = 7; b = 8; c = 9;
               break;
            case 4:
               a = 1; b = 4; c = 7;
               break;
            case 5:
               a = 2; b = 5; c = 8;
               break;
            case 6:
               a = 3; b = 6; c = 9;
               break;
            case 7:
               a = 1; b = 5; c = 9;
               break;
            case 8:
               a = 3; b = 5; c = 7;
               break;
        }
        if(posicao[a] == tipo_jogada && posicao[b] == tipo_jogada &&  posicao[c] == tipo_jogada){
           *vitoria = true;
           break;
        }
     }
}

int main(){
     int cont_jogada = 9, pts_x = 0, pts_o = 0;
     string jogador1, jogador2;
     char decisao = 's', posicao[10], vencedor, modo_jogo;
     bool jogada_valida, vitoria;


     while(modo_jogo != 'X'){

        if (decisao == 's'){
           menu(&modo_jogo);
        }

        if(modo_jogo == 'S' || modo_jogo == 'M'){
           Apresentacao(&jogador1, &jogador2, &pts_x, &pts_o, &modo_jogo);

           pts_x = 0;
           pts_x = 0;
           cont_jogada = 9;

           if(modo_jogo == 'S'){
              jogador2 = nome_aleatorio();
           }
        }


        while(modo_jogo != 'X' && cont_jogada == 9){
           cont_jogada = 1;
           jogada_valida = false;
           vitoria = false;

           if(cont_jogada == 1){
              LimpaJogo(cont_jogada, posicao);
           }

           for (cont_jogada = 1; cont_jogada < 10; cont_jogada++){
              while(jogada_valida == false){
                 Apresenta_Placar(jogador1, jogador2, pts_x, pts_o, &modo_jogo);
                 Apresenta_Jogo(posicao);

                 Jogada(cont_jogada, jogador1, jogador2, posicao, &jogada_valida, &modo_jogo);

                 if(cont_jogada % 2 == 0 && modo_jogo == 'S'){
                    jogada_inteligente(posicao, &jogada_valida);

                 }
              }
              jogada_valida = false;

              Verifica_Vitoria(posicao, cont_jogada, &vitoria);   //Verifica Vitoria
              vencedor = ' ';
              if (vitoria == true){
                 if (cont_jogada % 2 == 1){
                    vencedor = 'X';
                 }
                 cont_jogada = 9;
                 Apresenta_Placar(jogador1, jogador2, pts_x, pts_o, &modo_jogo);
                 Apresenta_Jogo(posicao);
                 break;
              }
           }
           if(vitoria == true){
              if (vencedor == 'X'){
                 pts_x++;
                 Apresenta_Placar(jogador1, jogador2, pts_x, pts_o, &modo_jogo);
                 Apresenta_Jogo(posicao);
                 cout << "\n\n\n >>> " << jogador1 << "(X) Venceu!\n\n";      // Vitoria x
              }else{
                  pts_o++;
                  Apresenta_Placar(jogador1, jogador2, pts_x, pts_o, &modo_jogo);
                  Apresenta_Jogo(posicao);
                  cout << "\n\n\n >>> " << jogador2 << "(O) Venceu!\n\n";    // Vitoria O
               }
           }
           if (vitoria == false){
              Apresenta_Placar(jogador1, jogador2, pts_x, pts_o, &modo_jogo);        //
              Apresenta_Jogo(posicao);
              cout << "\n\n\n Deu velha!\n\n";
              cont_jogada = 9;
           }if (cont_jogada == 9){
               cout << "\n Deseja continuar? ";
               cin >> decisao;
            }
           if (decisao == 'n' || decisao == 'N'){
              menu(&modo_jogo);
              cont_jogada = 10;
           }
        }
     }
        cout << "\n\n\n Encerrando...\n\n\n";
        system("pause");
        return 0;
}
