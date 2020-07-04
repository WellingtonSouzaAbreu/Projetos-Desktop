
  // Proced. Cramer ........ ln 30
	// Proced. Escalonamnto .. ln 191
	// Programa Principal .... ln 420

Program Calculador_de_Lineares3x4;
procedure Separa;
            Begin
               Writeln();
               Writeln('----------------------------------------------------------');
               Readkey;
              Writeln();
            End;
Procedure Wrkey;
            Begin
              Writeln();
              Readkey;
            End;
Procedure Matriz_modelo;
var
   i: integer;          
					  Begin   
               For i := 1 to 3 do        //Apresenta matriz modelo
               Writeln(' x', i, '  y', i,'  z', i, '  = r', i);
               Writeln();
               Writeln(' Escreva sua matriz de acordo com o modelo acima ^ ');
               Writeln();
            End;
						
/////////////////////// Inicio do procedimento Cramer ///////////////////////////////////////////////////////////////  
   
Procedure Cramer;
Var
   DETg, DETx, DETy, DETz: real;  
   x1, x2, x3, y1, y2 , y3, z1, z2, z3, DP, DS, r1, r2, r3: integer;
Begin
   Clrscr;
   Writeln('////////////// Metodo de Cramer //////////////');
   Matriz_modelo;
   
   Writeln();
   write(' x1 = ');
   readln(x1);
   Gotoxy(12,9);
   write(' y1 = ');   
   readln(y1);
   Gotoxy(24,9);
   write(' z1 = ');        //Recebe valores da 1º Linha
   readln(z1);
   Gotoxy(36,9);
   write(' r1 = ');   
   readln(r1);   
  	                                  
   write(' x2 = ');
   readln(x2);
   Gotoxy(12,10);
   write(' y2 = ');   
   readln(y2); 
	 Gotoxy(24,10);             //Recebe valores da 2º Linha
   write(' z2 = ');
   readln(z2);
   Gotoxy(36,10);
   write(' r2 = ');   
   readln(r2);          
			                               
   write(' x3 = ');
   readln(x3);
   Gotoxy(12,11);
   write(' y3 = ');   
   readln(y3);
   Gotoxy(24,11);
   write(' z3 = ');         //Recebe valores da 3º Linha
   readln(z3); 
   Gotoxy(36,11);   
   write(' r3 = ');   
   readln(r3);
   Separa;

///////////////////////////////////////////////////////////////////////////////////////////////////
    
   writeln(' DETg');
   Writeln();
   Writeln('');
   Writeln(' | ', x1, '  ', y1, '  ', z1, '  = ', r1, ' |');
   Writeln(' | ', x2, '  ', y2, '  ', z2, '  = ', r2, ' |');
   Writeln(' | ', x3, '  ', y3, '  ', z3, '  = ', r3, ' |');
   Wrkey;
    
   Writeln(' | ', x1, '  ', y1, '  ', z1, '  ', x1, '  ', y1, ' |');   
   Writeln(' | ', x2, '  ', y2, '  ', z2, '  ', x2, '  ', y2, ' |');
   Writeln(' | ', x3, '  ', y3, '  ', z3, '  ', x3, '  ', y3, ' |');
   Wrkey;                                                      
                                                                        //Determinante Geral
   DP := (x1 * y2 * z3) + (y1 * z2 * x3) + (z1 * x2 * y3);    
   DS := (z1 * y2 * x3) + (x1 * z2 * y3) + (y1 * x2 * z3);
   writeln(' Diagonal principal: ', DP);
   writeln(' Diagonal Secundaria: ', DS);
   DETg := DP - DS;
   Wrkey;
   writeln('          Determinante Geral: ', DETg:2:2);
   If DETg = 0 then
     Begin
        Writeln();
        Writeln(' Nao e possivel realizar uma divisao por 0 ... SI');
        Delay(800);
        Writeln();
        Exit;
     End;    
   Separa;
   
////////////////////////////////////////////////////////////////////////////////////////////////////    
    
   writeln('DETx');
   Writeln();
   Writeln('   *');
   Writeln(' | ', r1, '  ', y1, '  ', z1, '  = ', r1, ' |');
   Writeln(' | ', r2, '  ', y2, '  ', z2, '  = ', r2, ' |'); 
   Writeln(' | ', r3, '  ', y3, '  ', z3, '  = ', r3, ' |'); 
   Wrkey;
   
   Writeln(' | ', r1, '  ', y1, '  ', z1, '  ', r1, '  ', y1, ' |');   
   Writeln(' | ', r2, '  ', y2, '  ', z2, '  ', r2, '  ', y2, ' |');
   Writeln(' | ', r3, '  ', y3, '  ', z3, '  ', r3, '  ', y3, ' |');
   Wrkey;
                                                                  //Determinante de X
   DP := (r1 * y2 * z3) + (y1 * z2 * r3) + (z1 * r2 * y3);    
   DS := (z1 * y2 * r3) + (r1 * z2 * y3) + (y1 * r2 * z3);
   writeln('Diagonal principal: ', DP);
   writeln('Diagonal Secundaria: ', DS);
   DETx := DP - DS;
   DETx := DETx / DETg;
   Wrkey;
   writeln('          DETx: ', DETx:2:2); 
	 Separa;
///////////////////////////////////////////////////////////////////////////////////////////////////////////
		
   writeln('DETy');
   Writeln();
   Writeln('      *');
   Writeln(' | ', x1, '  ', r1, '  ', z1, '  = ', r1, ' |');
   Writeln(' | ', x2, '  ', r2, '  ', z2, '  = ', r2, ' |');
   Writeln(' | ', x3, '  ', r3, '  ', z3, '  = ', r3, ' |');
   Wrkey;
             
   Writeln(' | ', x1, '  ', r1, '  ', z1, '  ', x1, '  ', r1, ' |');   
   Writeln(' | ', x2, '  ', r2, '  ', z2, '  ', x2, '  ', r2, ' |');
   Writeln(' | ', x3, '  ', r3, '  ', z3, '  ', x3, '  ', r3, ' |');
   Wrkey;
   
   DP := (x1 * r2 * z3) + (r1 * z2 * x3) + (z1 * x2 * r3);    
   DS := (z1 * r2 * x3) + (x1 * z2 * r3) + (r1 * x2 * z3);   
   Wrkey;                                                     //Determinante  de Y
   
   writeln('Diagonal principal: ', DP);
   writeln('Diagonal Secundaria: ', DS);
   DETy := DP - DS;
   DETy := DETy / DETg;
   Wrkey;
   writeln('          DETy: ', DETy:2:2); 
	 Separa;
	
///////////////////////////////////////////////////////////////////////////////////////////////////////
     
   writeln('DETz');
   Writeln();
   Writeln('         *');
   Writeln(' | ', x1, '  ', y1, '  ', r1, '  = ', r1, ' |');
   Writeln(' | ', x2, '  ', y2, '  ', r2, '  = ', r2, ' |');
   Writeln(' | ', x3, '  ', y3, '  ', r3, '  = ', r3, ' |');
   Wrkey;
   
   Writeln(' | ', x1, '  ', y1, '  ', r1, '  ', x1, '  ', y1, ' |');   
   Writeln(' | ', x2, '  ', y2, '  ', r2, '  ', x2, '  ', y2, ' |');
   Writeln(' | ', x3, '  ', y3, '  ', r3, '  ', x3, '  ', y3, ' |');
   Wrkey;
    
   DP := (x1 * y2 * r3) + (y1 * r2 * x3) + (r1 * x2 * y3);    
   DS := (r1 * y2 * x3) + (x1 * r2 * y3) + (y1 * x2 * r3);      //Determinante de Z
   
   writeln('Diagonal principal: ', DP);
   writeln('Diagonal Secundaria: ', DS);
   DETz := DP - DS;
   DETz := DETz / DETg; 
   Wrkey;    
   writeln('          DETz: ', DETz:2:2); 
   
   writeln('--------------------------------------------------------');	  
   Readkey;                
End;
	
/////////////////////// Fim do procedimento Cramer ///////////////////////////////////////////////////////////////                                               
/////////////////////// Inicio do procedimento Escalonamento /////////////////////////////////////////////////////

Procedure Escalonamento;
Var
   Mp: Array[1..3, 1..4] of integer;
   M12, M13: Array[1..2, 1..4] of integer;
   M1213: Array[1..2, 1..3] of integer;
   i, j, m, C: integer;
   x, y, z: Real;
   R, Pn: String;   
Begin
  Repeat
   C := 9;
   Clrscr;
   Writeln('////////////// Metodo de Escalonamento //////////////');
   Writeln();
   Matriz_modelo;
   
   For i := 1 to 3 do
     For j := 1 to 4 do
       Begin
          If j = 1 then
            Begin
               Write(' x', i, ' = ');
               Readln(Mp[i,j]);
               Gotoxy(11,C);
            End;
          If j = 2 then
            Begin
               Write(' y', i, ' = ');
               Readln(Mp[i,j]);
               Gotoxy(22,C);
            End;
          If j = 3 then                  // Recebe valores       
            Begin
               Write(' z', i, ' = ');
               Readln(Mp[i,j]);
               Gotoxy(33,C);
            End;       
          If j = 4 then
            Begin
               Write(' r', i, ' = ');
               Readln(Mp[i,j]);
               C := C + 1;
               Gotoxy(0,C);
            End;     
       End;
   Separa;
               
   For i := 1 to 3 do           //Apresenta sua matriz
     Writeln(' ', i, '   -->  | ', Mp[i,1], 'x  ', Mp[i,2], 'y  ', Mp[i,3], 'z  = ', Mp[i,4]);
   Separa;
   
//////////////////////////////////////////////////////////////////////////////////////////////////
    
   If (Mp[1,1] + Mp[2,1] <> 0) Or (Mp[1,1] > 0) And (Mp[2,1] > 0) Or (Mp[1,1] < 0) And (Mp[2,1] < 0) then
     M := Mp[2,1] * -1
   Else                // Condicao +/- ... 1/2
     M := Mp[2,1];
     
   For i := 1 to 2 do          //Apresenta Ln 1/2
     If (i = 1) then          
       Writeln(' ', i, '   -->  | ', Mp[i,1], 'x  ', Mp[i,2], 'y  ', Mp[i,3], 'z  = ', Mp[i,4], '     (', M, ')')
     Else
       Writeln(' ', i, '   -->  | ', Mp[i,1], 'x  ', Mp[i,2], 'y  ', Mp[i,3], 'z  = ', Mp[i,4], '     (', Mp[1,1], ')');
   Wrkey;
   
   For j := 1 to 4 do
     Begin
        M12[1,j] := M * Mp[1,j];      //Multiplica Ln 1/2
        M12[2,j] := Mp[1,1] * Mp[2,j];     
     End;
   
   For i := 1 to 2 do              // Apresenta Ln 1/2 multiplicada
     Writeln(' ', i, '   -->  | ', M12[i,1], 'x  ', M12[i,2], 'y  ', M12[i,3], 'z  = ', M12[i,4]);
   Wrkey;
   Writeln();
   
   For j := 2 to 4 do             //Soma Ln 1/2
     M12[1,pred(j)] := M12[1,j] + M12[2,j];
                                           //Apresenta a soma da Ln 1/2
   Writeln(' 1,2 >>>>  | ', M12[1,1], 'y  ', M12[1,2], 'z  = ', M12[1,3]);
   Separa;
   
/////////////////////////////////////////////////////////////////////////////////////////////////////////////////
     
   If (Mp[1,1] + Mp[3,1] <> 0) Or (Mp[1,1] > 0) And (Mp[3,1] > 0) Or (Mp[1,1] < 0) And (Mp[3,1] < 0) then
     M := Mp[3,1] * -1
   Else                // Condicao +/- ... 1/3
     M := Mp[3,1];
                            //Apresenta Ln 1/3
   Writeln(' 1   -->  | ', Mp[1,1], 'x  ', Mp[1,2], 'y  ', Mp[1,3], 'z  = ', Mp[1,4], '     (', M, ')');
   Writeln(' 3   -->  | ', Mp[3,1], 'x  ', Mp[3,2], 'y  ', Mp[3,3], 'z  = ', Mp[3,4], '     (', Mp[1,1], ')');
   Wrkey;
     
   For j := 1 to 4 do
     Begin
        M13[1,j] := M * Mp[1,j];      //Multiplica Ln 1/3
        M13[2,j] := Mp[1,1] * Mp[3,j];
     End;
                                    //Apresenta Ln 1/3 multiplicada       
   Writeln(' 1   -->  | ', M13[1,1], 'x  ', M13[1,2], 'y  ', M13[1,3], 'z  = ', M13[1,4]);
   Writeln(' 3   -->  | ', M13[2,1], 'x  ', M13[2,2], 'y  ', M13[2,3], 'z  = ', M13[2,4]);
   Wrkey;
     
   For j := 2 to 4 do             //Soma Ln 1/3
     M13[1,pred(j)] := M13[1,j] + M13[2,j];
   Wrkey;
     
   Writeln(' 1,3 >>>>  | ', M13[1,1], 'y  ', M13[1,2], 'z  = ', M13[1,3]);
   Separa;     
                //Apresenta soma da Ln 1/3
///////////////////////////////////////////////////////////////////////////////////////////////////////////    
   
   Writeln(' 1/2 >>>>  | ', M12[1,1], 'y  ',M12[1,2], 'z  = ', M12[1,3]);  //Result. Ln 1/2
   Writeln(' 1/3 >>>>  | ', M13[1,1], 'y  ',M13[1,2], 'z  = ', M13[1,3]);  //Result. Ln 1/3
   Wrkey;
    
   If (M12[1,1] + M13[1,1] <> 0) Or (M12[1,1] > 0) And (M13[11,1] > 0) Or (M12[1,1] < 0) And (M13[11,1] < 0) then
     M := M13[1,1] * -1
   Else                // Condicao +/- ... 1/2 , 1/3
     M := M13[1,1];
          
   Writeln(' 1/2  -->  | ', M12[1,1], 'y  ',M12[1,2], 'z  = ', M12[1,3], '     (', M, ')');  //Result. Ln 1/2
   Writeln(' 1/3  -->  | ', M13[1,1], 'y  ',M13[1,2], 'z  = ', M13[1,3], '     (', M12[1,1], ')');  //Result. Ln 1/3
   Wrkey;
     
   For j := 1 to 3 do
     Begin
        M1213[1,j] := M * M12[1,j];  //Multiplica Ln 1/2, 1/3
        M1213[2,j] := M12[1,1] * M13[1,j];
     End;
     
   Writeln(' 1/2  -->  | ', M1213[1,1], 'y  ',M1213[1,2], 'z  = ', M1213[1,3]);  //Apresentada Ln 1/2, 1/3 multiplicada
   Writeln(' 1/3  -->  | ', M1213[2,1], 'y  ',M1213[2,2], 'z  = ', M1213[2,3]);  //Apresenta Ln 1/2, 1/3 multiplicada
   Wrkey;
     
   For j := 2 to 3 do         //Soma 1/2, 1/3
     M1213[1,pred(j)] := M1213[1,j] + M1213[2,j];
     
   Writeln('             ', M1213[1,1], 'z  = ', M1213[1,2]);    //Calcula valor de Z
   If M1213[1,2] = 0 then
     Begin
        Writeln();
        Writeln(' Não é possivel dividir por 0...');
        Readkey;                                       //Condicao de divisao por 0
        Break;
     End;
	  z := M1213[1,1] / M1213[1,2];
   Writeln('                                  Valor de Z = ', z:2:2);
   Separa;
     
/////////////////////////////////////////////////////////////////////////////////////////////////////////////////// 
     
   If M12[1,2] > 0 then
     Pn := '+'                                               // 1° Linha
   Else
     Pn := ' ';
   Writeln(' 1/2 >>>>  | ', M12[1,1], 'y ', Pn, M12[1,2], 'z  = ', M12[1,3]);
    
   If (M12[1,2] * z )> 0 then
     Pn := '+'                                                // 2° Linha                 //Valor de Y
   Else
     Pn := ' ';
   Writeln('             ', M12[1,1], 'y ', Pn, M12[1,2] * z:2:2, '  = ', M12[1,3]);  
      
   If (M12[1,2] * z * -1) > 0 then
     Pn := '+'                                               // 3° Linha
   Else
     Pn := ' ';
   Writeln('             ', M12[1,1], 'y  = ', (M12[1,3]), ' ', Pn,  (M12[1,2] * z * -1):2:2);
   Writeln('             ', M12[1,1], 'y  = ', (M12[1,3]) + (M12[1,2] * z * -1):2:2);   //Calcula valor de Y
   If M12[1,1] = 0 then
     Begin
        Writeln();
        Writeln(' Não é possivel dividir por 0...');      //Condicao de divisao por 0
        Readkey;
        Break;
     End;
   y := ((M12[1,3]) + (M12[1,2] * z )* -1) / (M12[1,1]);   
   Writeln('                                  Valor de Y = ', y:2:2);
   Separa;
         
//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////     
     
   If (Mp[1,2] > 0) and (Mp[1,3] > 0) then 
     Writeln(' 1   >>>>  | ', Mp[1,1], 'x +', Mp[1,2], 'y +', Mp[1,3], 'z  = ', Mp[1,4]);
	 If (Mp[1,2] < 0) and (Mp[1,3] < 0) then 		 
	   Writeln(' 1   >>>>  | ', Mp[1,1], 'x  ', Mp[1,2], 'y  ', Mp[1,3], 'z  = ', Mp[1,4]);   //1º Linha
   If (Mp[1,2] > 0) and (Mp[1,3] < 0) then 
		 Writeln(' 1   >>>>  | ', Mp[1,1], 'x +', Mp[1,2], 'y  ', Mp[1,3], 'z  = ', Mp[1,4]);
   If (Mp[1,2] < 0) and (Mp[1,3] > 0) then 
		 Writeln(' 1   >>>>  | ', Mp[1,1], 'x  ', Mp[1,2], 'y +', Mp[1,3], 'z  = ', Mp[1,4]);
		                                                                                                          //Valor de X
   If (Mp[1,2] * y > 0) and (Mp[1,3] * z > 0) then
     Writeln('             ', Mp[1,1], 'x +', Mp[1,2] * y:2:2, ' +', Mp[1,3] * z:2:2, '  = ', Mp[1,4]);  
   If (Mp[1,2] * y < 0) and (Mp[1,3] * z < 0) then
     Writeln('             ', Mp[1,1], 'x  ', Mp[1,2] * y:2:2, '  ', Mp[1,3] * z:2:2, '  = ', Mp[1,4]); 
   If (Mp[1,2] * y > 0) and (Mp[1,3] * z < 0) then                                                           //2º Linha
     Writeln('             ', Mp[1,1], 'x +', Mp[1,2] * y:2:2, '  ', Mp[1,3] * z:2:2, '  = ', Mp[1,4]); 
   If (Mp[1,2] * y < 0) and (Mp[1,3] * z > 0) then
     Writeln('             ', Mp[1,1], 'x  ', Mp[1,2] * y:2:2, ' +', Mp[1,3] * z:2:2, '  = ', Mp[1,4]); 
     
   If ((Mp[1,3] * z) * -1 > 0) and (Mp[1,4] > 0) then
     Writeln('             ', Mp[1,1], 'x  = ', Mp[1,2] * y * -1:2:2, ' +', Mp[1,3] * z * -1:2:2, ' +', Mp[1,4]);
   If ((Mp[1,3] * z) * -1 < 0) and (Mp[1,4] < 0) then  
     Writeln('             ', Mp[1,1], 'x  = ', Mp[1,2] * y * -1:2:2, '  ', Mp[1,3] * z * -1:2:2, '  ', Mp[1,4]);
   If ((Mp[1,3] * z) * -1 > 0) and (Mp[1,4] < 0) then                                                                     //3º Linha
     Writeln('             ', Mp[1,1], 'x  = ', Mp[1,2] * y * -1:2:2, ' +', Mp[1,3] * z * -1:2:2, '  ', Mp[1,4]);
   If ((Mp[1,3] * z) * -1 < 0) and (Mp[1,4] > 0) then 
     Writeln('             ', Mp[1,1], 'x  = ', Mp[1,2] * y * -1:2:2, '  ', Mp[1,3] * z * -1:2:2, ' +', Mp[1,4]);
     
   Writeln('             ', Mp[1,1], 'x  = ', (Mp[1,2] * y * -1) + ( Mp[1,3] * z * -1) + (Mp[1,4]):2:2);
     
   If Mp[1,1] = 0 then
     Begin
        Writeln();
        Writeln(' Não é possivel dividir por 0...');    //Condicao de divisao por 0
        Readkey;
        Break;
     End;
   x := ((Mp[1,2] * y * -1) + ( Mp[1,3] * z * -1) + (Mp[1,4])) / (Mp[1,1]);      //Calculaa valor de X
   Writeln('                                  Valor de x = ', x:2:2);
   Separa;
  Until(R <> 'a'); 
End;		
		 
//////////////////////////////////////Fim do procedimento Escalonamento///////////////////////////////////////////////////////////////////////////
    
///////////////////////////////////// Escopo do principal do programa ///////////////////////////////////////////// 

Var
   R: Char;
   E: Integer;
Begin
	 Repeat
	   Clrscr;;
	   Writeln('/////////////// Calculador de Sistemas Lineares /////////////////////////////');
	   Writeln();	   
		 Writeln(' [1]  Metodo de Cramer');
		 Writeln(' [2]  Escalonamento');
		 Writeln(); 		 
		 Write(' Escolha um metodo para realizar seu cálculo: ');
		 Readln(E);
		 If E = 1 then
		   Cramer;
		 If E = 2 then
		   Escalonamento;
		 If	(E <> 1) and (E <> 2) then
		   Writeln(' Numero invalido...');   
		 
	   Write(' Deseja calcular mais algum sistema S/N? ');
		 Readln(R) 
	 Until(R = 'n') or ( R = 'N');
End.