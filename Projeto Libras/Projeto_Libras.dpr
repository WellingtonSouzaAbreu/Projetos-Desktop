program Projeto_Libras;

uses
  Forms,
  unt_CacaPalavras in 'unt_CacaPalavras.pas' {frm_CacaPalavras},
  unt_TelaVitoria in 'unt_TelaVitoria.pas' {frm_TelaVitoria},
  unt_Menu in 'unt_Menu.pas' {frm_Menu},
  unt_Dicas_CacaPalavras in 'unt_Dicas_CacaPalavras.pas' {frm_Dica_CacaPalavras},
  unt_JogoMemoria in 'unt_JogoMemoria.pas' {frm_JogoMemoria},
  unt_Dica_JogoMemoria in 'unt_Dica_JogoMemoria.pas' {frm_Dica_JogoMemoria};

{$R *.res}

begin
  Application.Initialize;
  Application.MainFormOnTaskbar := True;
  Application.CreateForm(Tfrm_Menu, frm_Menu);
  Application.CreateForm(Tfrm_CacaPalavras, frm_CacaPalavras);
  Application.CreateForm(Tfrm_TelaVitoria, frm_TelaVitoria);
  Application.CreateForm(Tfrm_Dica_CacaPalavras, frm_Dica_CacaPalavras);
  Application.CreateForm(Tfrm_JogoMemoria, frm_JogoMemoria);
  Application.CreateForm(Tfrm_Dica_JogoMemoria, frm_Dica_JogoMemoria);
  Application.Run;
end.
