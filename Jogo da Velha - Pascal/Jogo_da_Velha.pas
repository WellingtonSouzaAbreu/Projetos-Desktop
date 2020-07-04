
// By  Wellington Souza

Program Jogo_da_velha;
Var                                                // Escopo Principal... Ln 220
   Posi2: Array[1..9] of String;
   i, Cj, Jogador_X, Jogador_O, Modo: integer;
   Decisao: Char;
   Vj, Vit_X, Vit_O: boolean;

/////////////////////////////////////////////////////////////////////////////////////////

Procedure Alimenta_Jogo_Nul;
Begin                           // Alimenta O jogo com espaços vazios
	 For i := 1 to 9 do
	   Posi2[i] := (' ');
End;

/////////////////////////////////////////////////////////////////////////////////////////

Procedure Modo_de_Jogo;
Begin
   Repeat
	   Clrscr;
	   Writeln(' Selecione o modo de jogo: ');
     Writeln();
 	   Writeln(' [1]  Player vs Player');
 	   Writeln(' [2]  Player vs PC');
 	   Writeln();
 	   Write(' --> ');
 	   Readln(Modo);
	 Until(Modo = 1) or (Modo = 2);
End;

////////////////////////////////////////////////////////////////////////////////////////

Procedure Placar;               // Apresenta o Placar do Jogo
Begin
   Writeln;
   Clrscr;
	 Writeln('  /////// Jogo da Velha //////');
	 Writeln('                                            /// Placar ///');
	 Writeln();                                                               
	 Writeln('                                     Jogador "X"  |  Jogador "O"');
	 Writeln('                                          ', Jogador_X, '       |     ', Jogador_O); 
ENd;

//////////////////////////////////////////////////////////////////////////////////////////////////////////////

Procedure Apresenta_jogo;  
Begin                                                                                                                         
   Writeln('    1 | 2 | 3        ', Posi2[1],' | ', Posi2[2],' | ', Posi2[3]);
   Writeln('   ___|___|___      ___|___|___ ');
   Writeln('    4 | 5 | 6        ', Posi2[4],' | ', Posi2[5],' | ', Posi2[6]);     // Apresenta situacao do jogo
   Writeln('   ___|___|___      ___|___|___ ');
   Writeln('    7 | 8 | 9        ', Posi2[7],' | ', Posi2[8],' | ', Posi2[9]);
   Writeln('      |   |            |   |    ');
	 Writeln(); 
End;

///////////////////////////////////////////////////////////////////////////////////////////////////////////

Procedure Jogada_X;                   // Jogada 'X'
Var
   Jogada: Integer;
Begin          
   Repeat
     Repeat
	     Writeln();
	     Write(' Onde deseja jogar "X" : ');
       Readln(Jogada);
     Until(Jogada > 0) And (Jogada < 10);
     
		 If (Posi2[Jogada] <> ' ') then
	   Begin
		    Writeln(' Posicao inválida...');  
		    Readkey;
		    Clrscr;
		    Placar;
		    Apresenta_jogo;
		 End;    
			            
   Until(Posi2[Jogada] = ' ');    
	 Posi2[Jogada] := 'X';
   Vj := True;			             
End;

////////////////////////////////////////////////////////////////////////////////////////////////////

Procedure Jogada_O;                  // Jogada 'O'
Var
   Jogada: Integer;
Begin          
   Repeat
		 Repeat
		   Writeln();
	     Write(' Onde deseja jogar "O" : ');
       Readln(Jogada);
     Until(Jogada > 0) And (Jogada < 10);
     
		 If (Posi2[Jogada] <> ' ') then
	     Begin
		      Writeln(' Posicao inválida...');  
		      Readkey;
		      Clrscr;
		   End;   
		    Placar;
		    Apresenta_jogo;        
   Until(Posi2[Jogada] = ' ');    
	 Posi2[Jogada] := 'O';
   Vj := True;			             
End;

//////////////////////////////////////////////////////////////////////////////////////

Procedure Jogada_inteligente(A, B, C: Integer);
Var
   Ji1, Ji2, Ji3, Ji4: String;
   Tipo_Jogada: Char;
Begin
	 Ji1 := 'OO ';
	 Ji2 := 'O O';     // Condiçoes de jogada para 'O' ganhar
	 Ji3 := ' OO';	 
	 Tipo_Jogada := 'O';       // Tipo de jogada

	 If i = 2 then
	   Begin
		    Ji1 := 'XX ';
	      Ji2 := 'X X';     // Condiçoes de jogada para interceptar 'X'
	      Ji3 := ' XX';
		 End;
		 
	 If	i = 3 then
	   Begin
		    Ji1 := ' O ';
	      Ji2 := 'O  ';     // Jogada quando não há condição de vencer ou interceptar
	      Ji3 := ' O ';
	      Ji4 := '  O';
		 End; 

   If (Posi2[A] + Posi2[B] + Posi2[C] = Ji1) and (Vj = False) And (Posi2[C] = ' ') then
	   BEgin
		    Posi2[C] := Tipo_Jogada;
				Vj := True;    
	      exit;
		 End;	 
		 	  
   If (Posi2[A] + Posi2[B] + Posi2[C] = Ji2) and (Vj = False) And (Posi2[B] = ' ')then
	   BEgin
		    Posi2[B] := Tipo_Jogada;
				Vj := True;                      // Verifica possibilidades de jogada que poderá levata a uma vitória
	      exit;
		 End;	
		  	  
   If (Posi2[A] + Posi2[B] + Posi2[C] = Ji3) and (Vj = False) And (Posi2[A] = ' ')then
	   BEgin
		    Posi2[A] := Tipo_Jogada;
				Vj := True;    
	      exit;
		 End;	
		 
	 If (Posi2[A] + Posi2[B] + Posi2[C] = Ji3) and (Vj = False) And (Posi2[A] = ' ')then
	   BEgin
		    Posi2[A] := Tipo_Jogada;
				Vj := True;    
	      exit;
		 End;	 	  		  	  		 		  
End;


///////////////////////////////////////////////////////////////////////////////////////////////////

Procedure Jogada_O_Pc;
Var
	 Jogada: Integer;
BEgin
	 For i := 1 to 3 do
  	 Begin
     	  Jogada_Inteligente(1, 2, 3);
	   	  Jogada_Inteligente(4, 5, 6);  // Linhas
	   	  Jogada_Inteligente(7, 8, 9);
	
	   	  Jogada_Inteligente(1, 4, 7);
	   	  Jogada_Inteligente(2, 5 ,8);  // Colunas
	   	  Jogada_Inteligente(3, 6, 9);
	
	   	  Jogada_Inteligente(1, 5, 9);   // Diagonais
	   	  Jogada_Inteligente(3, 5, 7);
	   	  
	   End;	 
	
   If Vj = False then
	   Begin
		    Repeat
			    Repeat
				    Jogada := Random(9);
	        Until(jogada < 10) and (Jogada > 0);  
			  Until (Posi2[Jogada] = ' ');  
			  Posi2[Jogada] := 'O';
			  Vj := True;
		 End;
   Apresenta_Jogo;	
End;

///////////////////////////////////////////////////////////////////////////////////// //////
 			 
Procedure Verif_Vitoria;           // Verifica se alguem venceu
Begin 
   Vit_O := False;
	 Vit_X := False;
		 
   If (Posi2[1] + Posi2[2] + Posi2[3] = 'XXX') or (Posi2[4] + Posi2[5] + Posi2[6] = 'XXX') or (Posi2[7] + Posi2[8] + Posi2[9] = 'XXX') then    
		 Vit_X := True;		                   // Vitoria por linha
	 If (Posi2[1] + Posi2[2] + Posi2[3] = 'OOO') or (Posi2[4] + Posi2[5] + Posi2[6] = 'OOO') or (Posi2[7] + Posi2[8] + Posi2[9] = 'OOO') then    
	   Vit_O := True;
	 	 
	 If (Posi2[1] + Posi2[4] + Posi2[7] = 'XXX') or (Posi2[2] + Posi2[5] + Posi2[8] = 'XXX') or (Posi2[3] + Posi2[6] + Posi2[9] = 'XXX') then    
		 Vit_X := True;	                   // Vitoria por coluna
	 If (Posi2[1] + Posi2[4] + Posi2[7] = 'OOO') or (Posi2[2] + Posi2[5] + Posi2[8] = 'OOO') or (Posi2[3] + Posi2[6] + Posi2[9] = 'OOO') then    
	   Vit_O := True;
	   
	 If (Posi2[1] + Posi2[5] + Posi2[9] = 'XXX') or (Posi2[3] + Posi2[5] + Posi2[7] = 'XXX') then
	   Vit_X := True;                       // Vitoria na DIagonal
	 If (Posi2[1] + Posi2[5] + Posi2[9] = 'OOO') or (Posi2[3] + Posi2[5] + Posi2[7] = 'OOO') then
	   Vit_O := True;		  	   
End;

//////////////////////////////////// Programa Principal //////////////////////////////////////////////////////////////
	
Begin  

	 Modo_de_Jogo;
	  		     
	 Repeat
	   Vj := False;	   
		 
		 If (Cj = 12) or (Cj = 0) then            
			 Begin
			    Cj := 2;
          Alimenta_Jogo_Nul;       // Alimenta espaços vazios Jogo da velha	            
		   End;
		   
		 Placar;         // Imprime o Placar                                                                 
		 Apresenta_jogo;   // Imprime a situacao atual do jogo
       
		 If (Cj Mod 2 = 0) and (Cj < 11) then     // Jogada_X
       Jogada_X;     
       	
     If (Cj Mod 2 = 1) and (Cj < 11) and (Modo = 1) then    // Jogada_O
			  Jogada_O;
		  
		 If (Cj Mod 2 = 1) and (Cj < 11) and (Modo = 2) then
		    Jogada_O_Pc;
		    
		 If	(Vj = true) or (Cj > 9) then	  // Contador de Jogadas
       Cj := Cj + 1;
		 
		 Clrscr;
		 Placar;
		 Apresenta_jogo;                     // Atualiza o jogo apos a jogada	   
		 Writeln();
		   
		 Verif_vitoria;                   // Verifica as condições de vitória;
		      
		 If (Vit_X = True) then        // Verifia se houve vitoria de "X"      
       BEgin
			    Jogador_X := Jogador_X + 1;      
					Writeln(' Jogador "X" Venceu essa partida!');
					Cj := 12;
			 ENd;
       
     If (Vit_O = True) then               // Verifia se houve vitoria de "O"             
			 Begin
			    Jogador_O := Jogador_O + 1;  
          Writeln(' Jogador "O" Venceu essa partida!');
			    Cj := 12;
			 End;
     
		 If (Cj = 11) and (Vit_X = false) and (VIT_O = false) then   // Verifica se houve empate (Se deu Velha)
       BEgin 
				  Write(' Deu velha!');
				  Writeln();
				  Cj := 12
		 	 End;			
				  
		 If (Cj = 12) then                // Decisão de nova partida
		   Begin    
			    Writeln();                                          
		      Write(' Deseja jogar mais uma partida S/N ? ');
		      Readln(Decisao);		      
		   End;
         
	 Until(Decisao = 'n') or (Decisao = 'N'); 
	 Writeln();
	 WRiteln(' Encerrando programa...');  // Encerra programa...
	 Delay(300);
End.

