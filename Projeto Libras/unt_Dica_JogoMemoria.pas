unit unt_Dica_JogoMemoria;

interface

uses
  Windows, Messages, SysUtils, Variants, Classes, Graphics, Controls, Forms,
  Dialogs, StdCtrls;

type
  Tfrm_Dica_JogoMemoria = class(TForm)
    Label1: TLabel;
    Label2: TLabel;
    Label3: TLabel;
    Label4: TLabel;
    Label5: TLabel;
    Label6: TLabel;
    Label7: TLabel;
    btJogar: TButton;
    Button1: TButton;
    procedure btJogarClick(Sender: TObject);
    procedure Button1Click(Sender: TObject);
  private
    { Private declarations }
  public
    { Public declarations }
  end;

var
  frm_Dica_JogoMemoria: Tfrm_Dica_JogoMemoria;

implementation

uses unt_JogoMemoria;

{$R *.dfm}

procedure Tfrm_Dica_JogoMemoria.btJogarClick(Sender: TObject);
begin
    frm_JogoMemoria.show;
    frm_Dica_JogoMemoria.Close;
end;

procedure Tfrm_Dica_JogoMemoria.Button1Click(Sender: TObject);
begin
    frm_Dica_JogoMemoria.close;
end;

end.
