unit unt_Dicas_CacaPalavras;

interface

uses
  Windows, Messages, SysUtils, Variants, Classes, Graphics, Controls, Forms,
  Dialogs, StdCtrls;

type
  Tfrm_Dica_CacaPalavras = class(TForm)
    Label1: TLabel;
    Label2: TLabel;
    Label3: TLabel;
    Label4: TLabel;
    Label5: TLabel;
    Label6: TLabel;
    btJogar: TButton;
    Button1: TButton;
    Label7: TLabel;
    procedure Button1Click(Sender: TObject);
    procedure btJogarClick(Sender: TObject);
  private
    { Private declarations }
  public
    { Public declarations }
  end;

var
  frm_Dica_CacaPalavras: Tfrm_Dica_CacaPalavras;

implementation

uses unt_CacaPalavras;

{$R *.dfm}

procedure Tfrm_Dica_CacaPalavras.btJogarClick(Sender: TObject);
begin
    frm_CacaPalavras.show;
    frm_Dica_CacaPalavras.Close;
end;

procedure Tfrm_Dica_CacaPalavras.Button1Click(Sender: TObject);
begin
    frm_Dica_CacaPalavras.close;
end;

end.
