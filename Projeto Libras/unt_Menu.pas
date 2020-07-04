unit unt_Menu;

interface

uses
  Windows, Messages, SysUtils, Variants, Classes, Graphics, Controls, Forms,
  Dialogs, StdCtrls, jpeg, ExtCtrls, pngimage;

type
  Tfrm_Menu = class(TForm)
    Button1: TButton;
    lbNomePrograma: TLabel;
    Button2: TButton;
    Button3: TButton;
    Button4: TButton;
    Button5: TButton;
    Image1: TImage;
    procedure Button3Click(Sender: TObject);
    procedure Button5Click(Sender: TObject);
    procedure Button2Click(Sender: TObject);
  private
    { Private declarations }
  public
    { Public declarations }
  end;

var
  frm_Menu: Tfrm_Menu;

implementation

uses unt_Dicas_CacaPalavras, unt_Dica_JogoMemoria;

{$R *.dfm}

procedure Tfrm_Menu.Button2Click(Sender: TObject);
begin
    frm_Dica_JogoMemoria.show;
end;

procedure Tfrm_Menu.Button3Click(Sender: TObject);
begin
    frm_Dica_CacaPalavras.Show;
end;

procedure Tfrm_Menu.Button5Click(Sender: TObject);
begin
    frm_Menu.Close;
end;

end.
