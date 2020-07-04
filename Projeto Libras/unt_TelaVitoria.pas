unit unt_TelaVitoria;

interface

uses
  Windows, Messages, SysUtils, Variants, Classes, Graphics, Controls, Forms,
  Dialogs, StdCtrls;

type
  Tfrm_TelaVitoria = class(TForm)
    Button1: TButton;
    lbParabens: TLabel;
    procedure Button1Click(Sender: TObject);
  private
    { Private declarations }
  public
    { Public declarations }
  end;

var
  frm_TelaVitoria: Tfrm_TelaVitoria;

implementation

{$R *.dfm}

procedure Tfrm_TelaVitoria.Button1Click(Sender: TObject);
begin
   frm_TelaVitoria.close();
end;

end.
