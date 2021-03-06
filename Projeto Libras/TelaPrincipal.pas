unit TelaPrincipal;

interface

uses
  Windows, Messages, SysUtils, Classes, Graphics, Controls, Forms, Dialogs,
  Buttons, StdCtrls, ExtCtrls, Menus;

type
  TFormTelaPrincipal = class(TForm)
    LabelPontos: TLabel;
    btnReinicia: TButton;
    AreaDoJogo: TPanel;
    btnLetra_R: TSpeedButton;
    btnSinal_C: TSpeedButton;
    btnSinal_O: TSpeedButton;
    btnLetra_M: TSpeedButton;
    btnLetra_A: TSpeedButton;
    btnSinal_K: TSpeedButton;
    btnLetra_C: TSpeedButton;
    btnLetra_K: TSpeedButton;
    btn_Letra_O: TSpeedButton;
    btnSinal_M: TSpeedButton;
    btnSinal_A: TSpeedButton;
    btnSinal_D: TSpeedButton;
    btnLetra_D: TSpeedButton;
    btnSinal_F: TSpeedButton;
    btnLetra_F: TSpeedButton;
    btnLetra_B: TSpeedButton;
    btnSinal_B: TSpeedButton;
    btnLetra_Y: TSpeedButton;
    btnSinal_Y: TSpeedButton;
    btnLetra_E: TSpeedButton;
    btnSinal_E: TSpeedButton;
    btnLetra_L: TSpeedButton;
    btnSinal_L: TSpeedButton;
    Cronometro: TTimer;
    chkEmbaralha: TCheckBox;
    btnSinal_R: TSpeedButton;
    btnLetra_S: TSpeedButton;
    btnSinal_S: TSpeedButton;
    btnLetra_X: TSpeedButton;
    btnSinal_X: TSpeedButton;
    GroupBox1: TGroupBox;
    btMenu: TButton;
    procedure ClickBotao(Sender: TObject);
    procedure CronometroTimer(Sender: TObject);
    procedure btnReiniciaClick(Sender: TObject);
    procedure FormCreate(Sender: TObject);
    procedure btnCartaSerena1Click(Sender: TObject);
  private
    B1,B2: TSpeedButton;  // O par de bot�es de cada jogada...
    Pontos, Acertos: integer;
    procedure PerdePontos(N: integer);
    procedure GanhaPontos(N: integer);
    procedure FimDeJogo(mensagem: string);
  public
    procedure ReiniciaJogo;
    procedure LimpaBotao(Botao: TSpeedButton);
    procedure Embaralha;
  end;

var
  FormTelaPrincipal: TFormTelaPrincipal;

implementation

{$R *.DFM}

procedure TFormTelaPrincipal.ReiniciaJogo;
begin
  B2 := nil;
  {o "nil" acima significa que B2 estar� VAZIA
  e n�o apontar� para NENHUM bot�o!}
  Pontos  := 120;  // inicia com 60 pontos
  Acertos := 0;
  {Limpa todos os bot�es:}
  LimpaBotao(btnSinal_L);
  LimpaBotao(btnSinal_R);
  LimpaBotao(btnSinal_K);
  LimpaBotao(btnSinal_F);
  LimpaBotao(btnSinal_Y);
  LimpaBotao(btnSinal_D);
  LimpaBotao(btnSinal_M);
  LimpaBotao(btnSinal_E);
  LimpaBotao(btnSinal_O);
  LimpaBotao(btnSinal_C);
  LimpaBotao(btnLetra_L);
  LimpaBotao(btnLetra_R);
  LimpaBotao(btnLetra_K);
  LimpaBotao(btnLetra_F);
  LimpaBotao(btnLetra_Y);
  LimpaBotao(btnLetra_D);
  LimpaBotao(btnLetra_M);
  LimpaBotao(btnLetra_E);
  LimpaBotao(btn_Letra_O);
  LimpaBotao(btnLetra_C);
  LimpaBotao(btnLetra_A);
  LimpaBotao(btnLetra_B);
  LimpaBotao(btnSinal_A);
  LimpaBotao(btnSinal_B);
  LimpaBotao(btnSinal_C);
  LimpaBotao(btnLetra_C);
  LimpaBotao(btnSinal_S);
  LimpaBotao(btnLetra_S);
  LimpaBotao(btnSinal_X);
  LimpaBotao(btnLetra_X);
  if chkEmbaralha.Checked then
    Embaralha;

  AreaDoJogo.Enabled := True;
  Cronometro.Enabled := True;  // liga o cronometro
end;

procedure TFormTelaPrincipal.CronometroTimer(Sender: TObject);
begin
  PerdePontos(1);  // perde um ponto por segundo
end;

procedure TFormTelaPrincipal.ClickBotao(Sender: TObject);
begin
  if B2 = nil then // vazio (ver ReiniciaJogo)
    B2 := B1;  // o bot�o anterior
  B1 := TSpeedButton(Sender);  // O bot�o clicado
  B1.Spacing := 4;   // Retira os espa�os p/ mostrar a figura
  if (B2 = nil) or (B1 = B2)  then
    Exit
  else if B2.Tag = B1.Tag then begin

    B1 := nil;
    B2 := nil;
    GanhaPontos(5);
  end
  else begin  // ERROU!
    LimpaBotao(B2);
    B2 := nil;
    PerdePontos(2);
  end;
end;

procedure TFormTelaPrincipal.PerdePontos(N: integer);
begin
  Pontos := Pontos - N;
  LabelPontos.Caption := 'Pontos: '+IntToStr(Pontos);
  if Pontos <= 0 then
    FimDeJogo('Voc� perdeu...Tente outra VEZ');
end;

procedure TFormTelaPrincipal.GanhaPontos(N: integer);
begin
  Pontos  := Pontos  + N;
  Acertos := Acertos + 1;
  LabelPontos.Caption := 'Pontos: '+IntToStr(Pontos);
  if Acertos = 14 then
    FimDeJogo('Parab�ns! Ganhou!!! ');
end;

procedure TFormTelaPrincipal.FimDeJogo(mensagem: string);
begin
  Cronometro.Enabled := False;  // desliga o cronometro
  ShowMessage('Fim de Jogo: '+mensagem);
  AreaDoJogo.Enabled := False;  // impede de mexer no jogo
end;

procedure TFormTelaPrincipal.btnReiniciaClick(Sender: TObject);
begin
  ReiniciaJogo;
end;

procedure TFormTelaPrincipal.LimpaBotao(Botao: TSpeedButton);
begin
  Botao.Spacing := 200;  // cobre a figura com espa�os
  Botao.Down := False;
end;

procedure TFormTelaPrincipal.FormCreate(Sender: TObject);
begin
  ReiniciaJogo;
end;

procedure TFormTelaPrincipal.Embaralha;
var
  aBotao: array[1..14,1..2] of TSpeedButton;
  i,j, p, id: integer;
  imagem: TBitmap;
  nome: string;
begin
  {Coloca os bot�es no array:}
  aBotao[1][1] := btnSinal_C;
  aBotao[1][2] := btnLetra_C;
  aBotao[2][1] := btnSinal_R;
  aBotao[2][2] := btnLetra_R;
  aBotao[3][1] := btnSinal_D;
  aBotao[3][2] := btnLetra_D;
  aBotao[4][1] := btnSinal_M;
  aBotao[4][2] := btnLetra_M;
  aBotao[5][1] := btnSinal_E;
  aBotao[5][2] := btnLetra_E;
  aBotao[6][1] := btnSinal_O;
  aBotao[6][2] := btn_Letra_O;
  aBotao[7][1] := btnSinal_K;
  aBotao[7][2] := btnLetra_K;
  aBotao[8][1] := btnSinal_F;
  aBotao[8][2] := btnLetra_F;
  aBotao[9][1] := btnSinal_B;
  aBotao[9][2] := btnLetra_B;
  aBotao[10][1] := btnSinal_Y;
  aBotao[10][2] := btnLetra_Y;
  aBotao[11][1] := btnSinal_A;
  aBotao[11][2] := btnLetra_A;
  aBotao[12][1] := btnSinal_L;
  aBotao[12][2] := btnLetra_L;
  aBotao[13][1] := btnSinal_S;
  aBotao[13][2] := btnLetra_S;
  aBotao[14][1] := btnSinal_X;
  aBotao[14][2] := btnLetra_X;

  {Troca as imagens entre os bot�es, aleat�riamente:}
  Randomize;
  imagem := TBitmap.Create;
  for i := 1 to 14 do
    for j := 1 to 2 do begin
      p := Random(13)+1;  // gera um n�mero entre 1..6
      {Guarda as informa��es do bot�o escolhido...}
      id   := aBotao[i][j].Tag;
      imagem.Assign(aBotao[i][j].Glyph);
      nome := aBotao[i][j].Caption;
      {...e troca com o bot�o atual:}
      aBotao[i][j].Glyph.Assign(aBotao[p][j].Glyph);
      aBotao[p][j].Glyph.Assign(imagem);
      aBotao[i][j].Tag := aBotao[p][j].Tag;
      aBotao[p][j].Tag := id;
      aBotao[i][j].Caption := aBotao[p][j].Caption;
      aBotao[p][j].Caption := nome;
    end;
  imagem.Free;
end;

procedure TFormTelaPrincipal.btnCartaSerena1Click(Sender: TObject);
begin
 if B2 = nil then // vazio (ver ReiniciaJogo)
    B2 := B1;  // o bot�o anterior
  B1 := TSpeedButton(Sender);  // O bot�o clicado
  B1.Spacing := 4;   // Retira os espa�os p/ mostrar a figura
  if (B2 = nil) or (B1 = B2)  then
    Exit
  else if B2.Tag = B1.Tag then begin

    B1 := nil;
    B2 := nil;
    GanhaPontos(5);
end;
  end;
end.
