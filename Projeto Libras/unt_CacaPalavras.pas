unit unt_CacaPalavras;

interface

uses
  Windows, Messages, SysUtils, Variants, Classes, Graphics, Controls, Forms,
  Dialogs, StdCtrls, ImgList, pngimage, ExtCtrls, Buttons, jpeg;

type
  Tfrm_CacaPalavras = class(TForm)
    lbPastel: TLabel;
    lbPipa: TLabel;
    lbBola: TLabel;
    GroupBox1: TGroupBox;
    Image1: TImage;
    Image2: TImage;
    Image3: TImage;
    Image4: TImage;
    Image5: TImage;
    Image6: TImage;
    Image7: TImage;
    Image8: TImage;
    Image9: TImage;
    Image10: TImage;
    Image11: TImage;
    Image12: TImage;
    Image13: TImage;
    Image14: TImage;
    Image15: TImage;
    Image16: TImage;
    Image17: TImage;
    Image18: TImage;
    Image19: TImage;
    Image20: TImage;
    Image21: TImage;
    Image22: TImage;
    Image23: TImage;
    Image24: TImage;
    Image25: TImage;
    Image26: TImage;
    Image27: TImage;
    Image28: TImage;
    Image29: TImage;
    Image30: TImage;
    Image31: TImage;
    Image32: TImage;
    Image33: TImage;
    Image34: TImage;
    Image35: TImage;
    Image36: TImage;
    Image37: TImage;
    Image38: TImage;
    Image39: TImage;
    Image40: TImage;
    Image41: TImage;
    Image42: TImage;
    Image43: TImage;
    Image44: TImage;
    Image45: TImage;
    Image46: TImage;
    Image47: TImage;
    Image48: TImage;
    Image49: TImage;
    Image50: TImage;
    Image51: TImage;
    Image52: TImage;
    Image53: TImage;
    Image54: TImage;
    Image55: TImage;
    Image56: TImage;
    Image57: TImage;
    Image58: TImage;
    Image59: TImage;
    Image60: TImage;
    ImageList1: TImageList;
    btVerificar: TButton;
    btRiscar: TButton;
    lbCaixa: TLabel;
    lbBoneca: TLabel;
    lbVaca: TLabel;
    lbLapis: TLabel;
    lbPapa: TLabel;
    lbDado: TLabel;
    btAtualizar: TButton;
    lbSelecionado: TLabel;
    Label1: TLabel;
    Button1: TButton;
    Button2: TButton;
    procedure bt1KeyDown(Sender: TObject; var Key: Word; Shift: TShiftState);
    procedure bt1KeyUp(Sender: TObject; var Key: Word; Shift: TShiftState);
    procedure btVerificarClick(Sender: TObject);
    procedure Image18Click(Sender: TObject);
    procedure Image21Click(Sender: TObject);
    procedure btResetClick(Sender: TObject);
    procedure btRiscarClick(Sender: TObject);
    procedure btAtualizarClick(Sender: TObject);
    procedure Image1Click(Sender: TObject);
    procedure Image2Click(Sender: TObject);
    procedure Image3Click(Sender: TObject);
    procedure Image5Click(Sender: TObject);
    procedure Image6Click(Sender: TObject);
    procedure Image7Click(Sender: TObject);
    procedure Image8Click(Sender: TObject);
    procedure Image9Click(Sender: TObject);
    procedure Image10Click(Sender: TObject);
    procedure Image4Click(Sender: TObject);
    procedure Image11Click(Sender: TObject);
    procedure Image12Click(Sender: TObject);
    procedure Image13Click(Sender: TObject);
    procedure Image14Click(Sender: TObject);
    procedure Image15Click(Sender: TObject);
    procedure Image16Click(Sender: TObject);
    procedure Image17Click(Sender: TObject);
    procedure Image19Click(Sender: TObject);
    procedure Image20Click(Sender: TObject);
    procedure Image30Click(Sender: TObject);
    procedure Image29Click(Sender: TObject);
    procedure Image28Click(Sender: TObject);
    procedure Image27Click(Sender: TObject);
    procedure Image26Click(Sender: TObject);
    procedure Image25Click(Sender: TObject);
    procedure Image24Click(Sender: TObject);
    procedure Image23Click(Sender: TObject);
    procedure Image22Click(Sender: TObject);
    procedure Image31Click(Sender: TObject);
    procedure Image32Click(Sender: TObject);
    procedure Image33Click(Sender: TObject);
    procedure Image34Click(Sender: TObject);
    procedure Image35Click(Sender: TObject);
    procedure Image36Click(Sender: TObject);
    procedure Image37Click(Sender: TObject);
    procedure Image38Click(Sender: TObject);
    procedure Image39Click(Sender: TObject);
    procedure Image58Click(Sender: TObject);
    procedure Image40Click(Sender: TObject);
    procedure Image41Click(Sender: TObject);
    procedure Image42Click(Sender: TObject);
    procedure Image43Click(Sender: TObject);
    procedure Image44Click(Sender: TObject);
    procedure Image45Click(Sender: TObject);
    procedure Image46Click(Sender: TObject);
    procedure Image47Click(Sender: TObject);
    procedure Image48Click(Sender: TObject);
    procedure Image59Click(Sender: TObject);
    procedure Image57Click(Sender: TObject);
    procedure Image56Click(Sender: TObject);
    procedure Image55Click(Sender: TObject);
    procedure Image54Click(Sender: TObject);
    procedure Image53Click(Sender: TObject);
    procedure Image52Click(Sender: TObject);
    procedure Image51Click(Sender: TObject);
    procedure Image49Click(Sender: TObject);
    procedure Image50Click(Sender: TObject);
    procedure Image60Click(Sender: TObject);
    procedure Button2Click(Sender: TObject);

  private
    { Private declarations }
  public
  var
    NumPalavras: integer;
    press: boolean;
    str: String;
    var palavras: array [1 .. 10] of String;
  end;

var
  frm_CacaPalavras: Tfrm_CacaPalavras;

implementation

uses unt_TelaVitoria, unt_Menu;

{$R *.dfm}

{procedure RiscarPalavra(i: Integer; Sender: TObject);
begin

  case i of
     1 : lbCasa.Caption := 'q';


  end;
end;
    }

procedure Tfrm_CacaPalavras.bt1KeyDown(Sender: TObject; var Key: Word;
  Shift: TShiftState);
begin
  press := true;
end;

procedure Tfrm_CacaPalavras.bt1KeyUp(Sender: TObject; var Key: Word;
  Shift: TShiftState);
begin
  press := false;
end;

procedure Tfrm_CacaPalavras.btAtualizarClick(Sender: TObject);
begin
    if image1.Height = 95 then
        begin
            image1.Height := 105;
            image1.Width := 105;
            image1.left := image1.left - 5;
            image1.top := image1.top - 5;
        end;

    if image2.Height = 95 then
        begin
            image2.Height := 105;
            image2.Width := 105;
            image2.left := image2.left - 5;
            image2.top := image2.top - 5;
        end;

    if image3.Height = 95 then
        begin
            image3.Height := 105;
            image3.Width := 105;
            image3.left := image3.left - 5;
            image3.top := image3.top - 5;
        end;

    if image4.Height = 95 then
        begin
            image4.Height := 105;
            image4.Width := 105;
            image4.left := image4.left - 5;
            image4.top := image4.top - 5;
        end;

    if image5.Height = 95 then
        begin
            image5.Height := 105;
            image5.Width := 105;
            image5.left := image5.left - 5;
            image5.top := image5.top - 5;
        end;

    if image6.Height = 95 then
        begin
            image6.Height := 105;
            image6.Width := 105;
            image6.left := image6.left - 5;
            image6.top := image6.top - 5;
        end;

    if image7.Height = 95 then
        begin
            image7.Height := 105;
            image7.Width := 105;
            image7.left := image7.left - 5;
            image7.top := image7.top - 5;
        end;

    if image8.Height = 95 then
        begin
            image8.Height := 105;
            image8.Width := 105;
            image8.left := image8.left - 5;
            image8.top := image8.top - 5;
        end;

    if image9.Height = 95 then
        begin
            image9.Height := 105;
            image9.Width := 105;
            image9.left := image9.left - 5;
            image9.top := image9.top - 5;
        end;

    if image10.Height = 95 then
        begin
            image10.Height := 105;
            image10.Width := 105;
            image10.left := image10.left - 5;
            image10.top := image10.top - 5;
        end;

    if image11.Height = 95 then
        begin
            image11.Height := 105;
            image11.Width := 105;
            image11.left := image11.left - 5;
            image11.top := image11.top - 5;
        end;

    if image12.Height = 95 then
        begin
            image12.Height := 105;
            image12.Width := 105;
            image12.left := image12.left - 5;
            image12.top := image12.top - 5;
        end;

    if image13.Height = 95 then
        begin
            image13.Height := 105;
            image13.Width := 105;
            image13.left := image13.left - 5;
            image13.top := image13.top - 5;
        end;

    if image14.Height = 95 then
        begin
            image14.Height := 105;
            image14.Width := 105;
            image14.left := image14.left - 5;
            image14.top := image14.top - 5;
        end;

        if image15.Height = 95 then
        begin
            image15.Height := 105;
            image15.Width := 105;
            image15.left := image15.left - 5;
            image15.top := image15.top - 5;
        end;

    if image16.Height = 95 then
        begin
            image16.Height := 105;
            image16.Width := 105;
            image16.left := image16.left - 5;
            image16.top := image16.top - 5;
        end;

    if image17.Height = 95 then
        begin
            image17.Height := 105;
            image17.Width := 105;
            image17.left := image17.left - 5;
            image17.top := image17.top - 5;
        end;

    if image18.Height = 95 then
        begin
            image18.Height := 105;
            image18.Width := 105;
            image18.left := image18.left - 5;
            image18.top := image18.top - 5;
        end;

    if image19.Height = 95 then
        begin
            image19.Height := 105;
            image19.Width := 105;
            image19.left := image19.left - 5;
            image19.top := image19.top - 5;
        end;

    if image20.Height = 95 then
        begin
            image20.Height := 105;
            image20.Width := 105;
            image20.left := image20.left - 5;
            image20.top := image20.top - 5;
        end;

    if image21.Height = 95 then
        begin
            image21.Height := 105;
            image21.Width := 105;
            image21.left := image21.left - 5;
            image21.top := image21.top - 5;
        end;

    if image22.Height = 95 then
        begin
            image22.Height := 105;
            image22.Width := 105;
            image22.left := image22.left - 5;
            image22.top := image22.top - 5;
        end;

    if image23.Height = 95 then
        begin
            image23.Height := 105;
            image23.Width := 105;
            image23.left := image23.left - 5;
            image23.top := image23.top - 5;
        end;

    if image24.Height = 95 then
        begin
            image24.Height := 105;
            image24.Width := 105;
            image24.left := image24.left - 5;
            image24.top := image24.top - 5;
        end;

    if image25.Height = 95 then
        begin
            image25.Height := 105;
            image25.Width := 105;
            image25.left := image25.left - 5;
            image25.top := image25.top - 5;
        end;

    if image26.Height = 95 then
        begin
            image26.Height := 105;
            image26.Width := 105;
            image26.left := image26.left - 5;
            image26.top := image26.top - 5;
        end;

    if image27.Height = 95 then
        begin
            image27.Height := 105;
            image27.Width := 105;
            image27.left := image27.left - 5;
            image27.top := image27.top - 5;
        end;

    if image28.Height = 95 then
        begin
            image28.Height := 105;
            image28.Width := 105;
            image28.left := image28.left - 5;
            image28.top := image28.top - 5;
        end;

    if image29.Height = 95 then
        begin
            image29.Height := 105;
            image29.Width := 105;
            image29.left := image29.left - 5;
            image29.top := image29.top - 5;
        end;

    if image30.Height = 95 then
        begin
            image30.Height := 105;
            image30.Width := 105;
            image30.left := image30.left - 5;
            image30.top := image30.top - 5;
        end;

        /////////////


    if image31.Height = 95 then
        begin
            image31.Height := 105;
            image31.Width := 105;
            image31.left := image31.left - 5;
            image31.top := image31.top - 5;
        end;

    if image32.Height = 95 then
        begin
            image32.Height := 105;
            image32.Width := 105;
            image32.left := image32.left - 5;
            image32.top := image32.top - 5;
        end;

    if image33.Height = 95 then
        begin
            image33.Height := 105;
            image33.Width := 105;
            image33.left := image33.left - 5;
            image33.top := image33.top - 5;
        end;

    if image34.Height = 95 then
        begin
            image34.Height := 105;
            image34.Width := 105;
            image34.left := image34.left - 5;
            image34.top := image34.top - 5;
        end;

    if image35.Height = 95 then
        begin
            image35.Height := 105;
            image35.Width := 105;
            image35.left := image35.left - 5;
            image35.top := image35.top - 5;
        end;

    if image36.Height = 95 then
        begin
            image36.Height := 105;
            image36.Width := 105;
            image36.left := image36.left - 5;
            image36.top := image36.top - 5;
        end;

    if image37.Height = 95 then
        begin
            image37.Height := 105;
            image37.Width := 105;
            image37.left := image37.left - 5;
            image37.top := image37.top - 5;
        end;

    if image38.Height = 95 then
        begin
            image38.Height := 105;
            image38.Width := 105;
            image38.left := image38.left - 5;
            image38.top := image38.top - 5;
        end;

    if image39.Height = 95 then
        begin
            image39.Height := 105;
            image39.Width := 105;
            image39.left := image39.left - 5;
            image39.top := image39.top - 5;
        end;

    if image40.Height = 95 then
        begin
            image40.Height := 105;
            image40.Width := 105;
            image40.left := image40.left - 5;
            image40.top := image40.top - 5;
        end;

    if image41.Height = 95 then
        begin
            image41.Height := 105;
            image41.Width := 105;
            image41.left := image41.left - 5;
            image41.top := image41.top - 5;
        end;

    if image42.Height = 95 then
        begin
            image42.Height := 105;
            image42.Width := 105;
            image42.left := image42.left - 5;
            image42.top := image42.top - 5;
        end;

    if image43.Height = 95 then
        begin
            image43.Height := 105;
            image43.Width := 105;
            image43.left := image43.left - 5;
            image43.top := image43.top - 5;
        end;

    if image44.Height = 95 then
        begin
            image44.Height := 105;
            image44.Width := 105;
            image44.left := image44.left - 5;
            image44.top := image44.top - 5;
        end;

        if image45.Height = 95 then
        begin
            image45.Height := 105;
            image45.Width := 105;
            image45.left := image45.left - 5;
            image45.top := image45.top - 5;
        end;

    if image46.Height = 95 then
        begin
            image46.Height := 105;
            image46.Width := 105;
            image46.left := image46.left - 5;
            image46.top := image46.top - 5;
        end;

    if image47.Height = 95 then
        begin
            image47.Height := 105;
            image47.Width := 105;
            image47.left := image47.left - 5;
            image47.top := image47.top - 5;
        end;

    if image48.Height = 95 then
        begin
            image48.Height := 105;
            image48.Width := 105;
            image48.left := image48.left - 5;
            image48.top := image48.top - 5;
        end;

    if image49.Height = 95 then
        begin
            image49.Height := 105;
            image49.Width := 105;
            image49.left := image49.left - 5;
            image49.top := image49.top - 5;
        end;

    if image50.Height = 95 then
        begin
            image50.Height := 105;
            image50.Width := 105;
            image50.left := image50.left - 5;
            image50.top := image50.top - 5;
        end;

    if image51.Height = 95 then
        begin
            image51.Height := 105;
            image51.Width := 105;
            image51.left := image51.left - 5;
            image51.top := image51.top - 5;
        end;

    if image52.Height = 95 then
        begin
            image52.Height := 105;
            image52.Width := 105;
            image52.left := image52.left - 5;
            image52.top := image52.top - 5;
        end;

    if image53.Height = 95 then
        begin
            image53.Height := 105;
            image53.Width := 105;
            image53.left := image53.left - 5;
            image53.top := image53.top - 5;
        end;

    if image54.Height = 95 then
        begin
            image54.Height := 105;
            image54.Width := 105;
            image54.left := image54.left - 5;
            image54.top := image54.top - 5;
        end;

    if image55.Height = 95 then
        begin
            image55.Height := 105;
            image55.Width := 105;
            image55.left := image55.left - 5;
            image55.top := image55.top - 5;
        end;

    if image56.Height = 95 then
        begin
            image56.Height := 105;
            image56.Width := 105;
            image56.left := image56.left - 5;
            image56.top := image56.top - 5;
        end;

    if image57.Height = 95 then
        begin
            image57.Height := 105;
            image57.Width := 105;
            image57.left := image57.left - 5;
            image57.top := image57.top - 5;
        end;

    if image58.Height = 95 then
        begin
            image58.Height := 105;
            image58.Width := 105;
            image58.left := image58.left - 5;
            image58.top := image58.top - 5;
        end;

    if image59.Height = 95 then
        begin
            image59.Height := 105;
            image59.Width := 105;
            image59.left := image59.left - 5;
            image59.top := image59.top - 5;
        end;

    if image60.Height = 95 then
        begin
            image60.Height := 105;
            image60.Width := 105;
            image60.left := image60.left - 5;
            image60.top := image60.top - 5;
        end;
end;

procedure Tfrm_CacaPalavras.btResetClick(Sender: TObject);
begin
   str := '';
end;

procedure Tfrm_CacaPalavras.btRiscarClick(Sender: TObject);
begin
    if str = 'PIPA' then
        lbPipa.Font.color := clGreen;
    if str = 'BOLA' then
        lbBola.Font.color := clGreen;
    if str = 'PASTEL' then
        lbPastel.Font.color := clGreen;
    if str = 'BONECA' then
        lbBoneca.Font.color := clGreen;
    if str = 'CAIXA' then
        lbCaixa.Font.color := clGreen;
    if str = 'VACA' then
        lbVaca.Font.Color := clGreen;
    if str = 'PAPA' then
        lbPapa.Font.color := clGreen;
    if str = 'DADO' then
        lbDado.Font.color := clGreen;
    if str = 'LAPIS' then
        lbLapis.Font.color := clGreen;

    btAtualizar.Click;
end;

procedure Tfrm_CacaPalavras.btVerificarClick(Sender: TObject);
  var i: integer;
    palavras: array[1..9] of string;
begin
  palavras[1] := 'PIPA';
  palavras[2] := 'BOLA';
  palavras[3] := 'PASTEL';
  palavras[4] := 'BONECA';
  palavras[5] := 'VACA';
  palavras[6] := 'CAIXA';
  palavras[7] := 'PAPA';
  palavras[8] := 'DADO';
  palavras[9] := 'LAPIS';

    for i := 1 to 9 do
        if (str = palavras[i]) then
           begin
               lbSelecionado.caption := str;
               btRiscar.Click;
               ShowMessage('Parabens! Voc� descobriu a palavra ' + str);
               NumPalavras := NumPalavras + 1;
               if NumPalavras = 9 then
                  frm_TelaVitoria.Show;
               str := '';
           end
        else
           lbSelecionado.caption := str;


end;

procedure Tfrm_CacaPalavras.Button2Click(Sender: TObject);
begin
    frm_Menu.Show();
    frm_CacaPalavras.Close;
end;

procedure Tfrm_CacaPalavras.Image10Click(Sender: TObject);
begin
    if image10.Height = 105 then
      begin
        image10.height := 95;
        image10.Width := 95;
        image10.left := image10.left + 5;
        image10.top := image10.top + 5;

        str := str + 'D';
        btVerificar.Click;

      end
      else
        begin
           image10.height := 105;
          image10.Width := 105;
          image10.left := image10.left - 5;
          image10.top := image10.top - 5;
          str := '';
          lbSelecionado.Caption := '';
          btAtualizar.Click;
        end;
end;

procedure Tfrm_CacaPalavras.Image11Click(Sender: TObject);
begin
    if image11.Height = 105 then
      begin
        image11.height := 95;
        image11.Width := 95;
        image11.left := image11.left + 5;
        image11.top := image11.top + 5;

        str := str + 'R';
        btVerificar.Click;

      end
      else
        begin
           image11.height := 105;
          image11.Width := 105;
          image11.left := image11.left - 5;
          image11.top := image11.top - 5;
          str := '';
          lbSelecionado.Caption := '';
          btAtualizar.Click;
        end;
end;

procedure Tfrm_CacaPalavras.Image12Click(Sender: TObject);
begin
    if image12.Height = 105 then
      begin
        image12.height := 95;
        image12.Width := 95;
        image12.left := image12.left + 5;
        image12.top := image12.top + 5;

        str := str + 'L';
        btVerificar.Click;

      end
      else
        begin
           image12.height := 105;
          image12.Width := 105;
          image12.left := image12.left - 5;
          image12.top := image12.top - 5;
          str := '';
          lbSelecionado.Caption := '';
          btAtualizar.Click;
        end;
end;

procedure Tfrm_CacaPalavras.Image13Click(Sender: TObject);
begin
    if image13.Height = 105 then
      begin
        image13.height := 95;
        image13.Width := 95;
        image13.left := image13.left + 5;
        image13.top := image13.top + 5;

        str := str + 'A';
        btVerificar.Click;

      end
      else
        begin
           image13.height := 105;
          image13.Width := 105;
          image13.left := image13.left - 5;
          image13.top := image13.top - 5;
          str := '';
          lbSelecionado.Caption := '';
          btAtualizar.Click;
        end;
end;

procedure Tfrm_CacaPalavras.Image14Click(Sender: TObject);
begin
    if image14.Height = 105 then
      begin
        image14.height := 95;
        image14.Width := 95;
        image14.left := image14.left + 5;
        image14.top := image14.top + 5;

        str := str + 'P';
        btVerificar.Click;

      end
      else
        begin
           image14.height := 105;
          image14.Width := 105;
          image14.left := image14.left - 5;
          image14.top := image14.top - 5;
          str := '';
          lbSelecionado.Caption := '';
          btAtualizar.Click;
        end;
end;

procedure Tfrm_CacaPalavras.Image15Click(Sender: TObject);
begin
     if image15.Height = 105 then
      begin
        image15.height := 95;
        image15.Width := 95;
        image15.left := image15.left + 5;
        image15.top := image15.top + 5;

        str := str + 'I';
        btVerificar.Click;

      end
      else
        begin
           image15.height := 105;
          image15.Width := 105;
          image15.left := image15.left - 5;
          image15.top := image15.top - 5;
          str := '';
          lbSelecionado.Caption := '';
          btAtualizar.Click;
        end;
end;

procedure Tfrm_CacaPalavras.Image16Click(Sender: TObject);
begin
    if image16.Height = 105 then
      begin
        image16.height := 95;
        image16.Width := 95;
        image16.left := image16.left + 5;
        image16.top := image16.top + 5;

        str := str + 'S';
        btVerificar.Click;

      end
      else
        begin
           image16.height := 105;
          image16.Width := 105;
          image16.left := image16.left - 5;
          image16.top := image16.top - 5;
          str := '';
          lbSelecionado.Caption := '';
          btAtualizar.Click;
        end;
end;

procedure Tfrm_CacaPalavras.Image17Click(Sender: TObject);
begin
    if image17.Height = 105 then
      begin
        image17.height := 95;
        image17.Width := 95;
        image17.left := image17.left + 5;
        image17.top := image17.top + 5;

        str := str + 'E';
        btVerificar.Click;

      end
      else
        begin
           image17.height := 105;
          image17.Width := 105;
          image17.left := image17.left - 5;
          image17.top := image17.top - 5;
          str := '';
          lbSelecionado.Caption := '';
          btAtualizar.Click;
        end;
end;

procedure Tfrm_CacaPalavras.Image18Click(Sender: TObject);
begin
    if image18.Height = 105 then
      begin
        image18.height := 95;
        image18.Width := 95;
        image18.left := image18.left + 5;
        image18.top := image18.top + 5;

        str := str + 'O';
        btVerificar.Click;

      end
      else
        begin
           image18.height := 105;
          image18.Width := 105;
          image18.left := image18.left - 5;
          image18.top := image18.top - 5;
          str := '';
          lbSelecionado.Caption := '';
          btAtualizar.Click;
        end;
end;

procedure Tfrm_CacaPalavras.Image19Click(Sender: TObject);
begin
     if image19.Height = 105 then
      begin
        image19.height := 95;
        image19.Width := 95;
        image19.left := image19.left + 5;
        image19.top := image19.top + 5;

        str := str + 'I';
        btVerificar.Click;

      end
      else
        begin
           image19.height := 105;
          image19.Width := 105;
          image19.left := image19.left - 5;
          image19.top := image19.top - 5;
          str := '';
          lbSelecionado.Caption := '';
          btAtualizar.Click;
        end;
end;

procedure Tfrm_CacaPalavras.Image1Click(Sender: TObject);
begin
   if image1.Height = 105 then
      begin
        image1.height := 95;
        image1.Width := 95;
        image1.left := image1.left + 5;
        image1.top := image1.top + 5;

        str := str + 'C';
        btVerificar.Click;

      end
      else
        begin
           image1.height := 105;
          image1.Width := 105;
          image1.left := image1.left - 5;
          image1.top := image1.top - 5;
          str := '';
          lbSelecionado.Caption := '';
          btAtualizar.Click;
        end;
end;

procedure Tfrm_CacaPalavras.Image20Click(Sender: TObject);
begin
     if image20.Height = 105 then
      begin
        image20.height := 95;
        image20.Width := 95;
        image20.left := image20.left + 5;
        image20.top := image20.top + 5;

        str := str + 'A';
        btVerificar.Click;

      end
      else
        begin
           image20.height := 105;
          image20.Width := 105;
          image20.left := image20.left - 5;
          image20.top := image20.top - 5;
          str := '';
          lbSelecionado.Caption := '';
          btAtualizar.Click;
        end;
end;

procedure Tfrm_CacaPalavras.Image21Click(Sender: TObject);
begin
    if image21.Height = 105 then
      begin
        image21.height := 95;
        image21.Width := 95;
        image21.left := image21.left + 5;
        image21.top := image21.top + 5;

        str := str + 'L';
        btVerificar.Click;

      end
      else
        begin
           image21.height := 105;
          image21.Width := 105;
          image21.left := image21.left - 5;
          image21.top := image21.top - 5;
          str := '';
          lbSelecionado.Caption := '';
          btAtualizar.Click;
        end;
end;

procedure Tfrm_CacaPalavras.Image22Click(Sender: TObject);
begin
     if image22.Height = 105 then
      begin
        image22.height := 95;
        image22.Width := 95;
        image22.left := image22.left + 5;
        image22.top := image22.top + 5;

        str := str + 'D';
        btVerificar.Click;

      end
      else
        begin
           image22.height := 105;
          image22.Width := 105;
          image22.left := image22.left - 5;
          image22.top := image22.top - 5;
          str := '';
          lbSelecionado.Caption := '';
          btAtualizar.Click;
        end;
end;

procedure Tfrm_CacaPalavras.Image23Click(Sender: TObject);
begin
    if image23.Height = 105 then
      begin
        image23.height := 95;
        image23.Width := 95;
        image23.left := image23.left + 5;
        image23.top := image23.top + 5;

        str := str + 'S';
        btVerificar.Click;

      end
      else
        begin
           image23.height := 105;
          image23.Width := 105;
          image23.left := image23.left - 5;
          image23.top := image23.top - 5;
          str := '';
          lbSelecionado.Caption := '';
          btAtualizar.Click;
        end;
end;

procedure Tfrm_CacaPalavras.Image24Click(Sender: TObject);
begin
    if image24.Height = 105 then
      begin
        image24.height := 95;
        image24.Width := 95;
        image24.left := image24.left + 5;
        image24.top := image24.top + 5;

        str := str + 'E';
        btVerificar.Click;

      end
      else
        begin
           image24.height := 105;
          image24.Width := 105;
          image24.left := image24.left - 5;
          image24.top := image24.top - 5;
          str := '';
          lbSelecionado.Caption := '';
          btAtualizar.Click;
        end;
end;

procedure Tfrm_CacaPalavras.Image25Click(Sender: TObject);
begin
    if image25.Height = 105 then
      begin
        image25.height := 95;
        image25.Width := 95;
        image25.left := image25.left + 5;
        image25.top := image25.top + 5;

        str := str + 'T';
        btVerificar.Click;

      end
      else
        begin
           image25.height := 105;
          image25.Width := 105;
          image25.left := image25.left - 5;
          image25.top := image25.top - 5;
          str := '';
          lbSelecionado.Caption := '';
          btAtualizar.Click;
        end;
end;

procedure Tfrm_CacaPalavras.Image26Click(Sender: TObject);
begin
     if image26.Height = 105 then
      begin
        image26.height := 95;
        image26.Width := 95;
        image26.left := image26.left + 5;
        image26.top := image26.top + 5;

        str := str + 'S';
        btVerificar.Click;

      end
      else
        begin
           image26.height := 105;
          image26.Width := 105;
          image26.left := image26.left - 5;
          image26.top := image26.top - 5;
          str := '';
          lbSelecionado.Caption := '';
          btAtualizar.Click;
        end;
end;

procedure Tfrm_CacaPalavras.Image27Click(Sender: TObject);
begin
    if image27.Height = 105 then
      begin
        image27.height := 95;
        image27.Width := 95;
        image27.left := image27.left + 5;
        image27.top := image27.top + 5;

        str := str + 'A';
        btVerificar.Click;

      end
      else
        begin
           image27.height := 105;
          image27.Width := 105;
          image27.left := image27.left - 5;
          image27.top := image27.top - 5;
          str := '';
          lbSelecionado.Caption := '';
          btAtualizar.Click;
        end;
end;

procedure Tfrm_CacaPalavras.Image28Click(Sender: TObject);
begin
    if image28.Height = 105 then
      begin
        image28.height := 95;
        image28.Width := 95;
        image28.left := image28.left + 5;
        image28.top := image28.top + 5;

        str := str + 'P';
        btVerificar.Click;

      end
      else
        begin
           image28.height := 105;
          image28.Width := 105;
          image28.left := image28.left - 5;
          image28.top := image28.top - 5;
          str := '';
          lbSelecionado.Caption := '';
          btAtualizar.Click;
        end;
end;

procedure Tfrm_CacaPalavras.Image29Click(Sender: TObject);
begin
     if image29.Height = 105 then
      begin
        image29.height := 95;
        image29.Width := 95;
        image29.left := image29.left + 5;
        image29.top := image29.top + 5;

        str := str + 'W';
        btVerificar.Click;

      end
      else
        begin
           image29.height := 105;
          image29.Width := 105;
          image29.left := image29.left - 5;
          image29.top := image29.top - 5;
          str := '';
          lbSelecionado.Caption := '';
          btAtualizar.Click;
        end;
end;

procedure Tfrm_CacaPalavras.Image2Click(Sender: TObject);
begin
   if image2.Height = 105 then
      begin
        image2.height := 95;
        image2.Width := 95;
        image2.left := image2.left + 5;
        image2.top := image2.top + 5;

        str := str + 'R';
        btVerificar.Click;

      end
      else
        begin
           image2.height := 105;
          image2.Width := 105;
          image2.left := image2.left - 5;
          image2.top := image2.top - 5;
          str := '';
          lbSelecionado.Caption := '';
          btAtualizar.Click;
        end;
end;



procedure Tfrm_CacaPalavras.Image30Click(Sender: TObject);
begin
    if image30.Height = 105 then
      begin
        image30.height := 95;
        image30.Width := 95;
        image30.left := image30.left + 5;
        image30.top := image30.top + 5;

        str := str + 'V';
        btVerificar.Click;

      end
      else
        begin
           image30.height := 105;
          image30.Width := 105;
          image30.left := image30.left - 5;
          image30.top := image30.top - 5;
          str := '';
          lbSelecionado.Caption := '';
          btAtualizar.Click;
        end;
end;

procedure Tfrm_CacaPalavras.Image31Click(Sender: TObject);
begin
    if image31.Height = 105 then
      begin
        image31.height := 95;
        image31.Width := 95;
        image31.left := image31.left + 5;
        image31.top := image31.top + 5;

        str := str + 'A';
        btVerificar.Click;

      end
      else
        begin
           image31.height := 105;
          image31.Width := 105;
          image31.left := image31.left - 5;
          image31.top := image31.top - 5;
          str := '';
          lbSelecionado.Caption := '';
          btAtualizar.Click;
        end;
end;

procedure Tfrm_CacaPalavras.Image32Click(Sender: TObject);
begin
    if image32.Height = 105 then
      begin
        image32.height := 95;
        image32.Width := 95;
        image32.left := image32.left + 5;
        image32.top := image32.top + 5;

        str := str + 'I';
        btVerificar.Click;

      end
      else
        begin
           image32.height := 105;
          image32.Width := 105;
          image32.left := image32.left - 5;
          image32.top := image32.top - 5;
          str := '';
          lbSelecionado.Caption := '';
          btAtualizar.Click;
        end;
end;

procedure Tfrm_CacaPalavras.Image33Click(Sender: TObject);
begin
    if image33.Height = 105 then
      begin
        image33.height := 95;
        image33.Width := 95;
        image33.left := image33.left + 5;
        image33.top := image33.top + 5;

        str := str + 'A';
        btVerificar.Click;

      end
      else
        begin
           image33.height := 105;
          image33.Width := 105;
          image33.left := image33.left - 5;
          image33.top := image33.top - 5;
          str := '';
          lbSelecionado.Caption := '';
          btAtualizar.Click;
        end;
end;

procedure Tfrm_CacaPalavras.Image34Click(Sender: TObject);
begin
    if image34.Height = 105 then
      begin
        image34.height := 95;
        image34.Width := 95;
        image34.left := image34.left + 5;
        image34.top := image34.top + 5;

        str := str + 'F';
        btVerificar.Click;

      end
      else
        begin
           image34.height := 105;
          image34.Width := 105;
          image34.left := image34.left - 5;
          image34.top := image34.top - 5;
          str := '';
          lbSelecionado.Caption := '';
          btAtualizar.Click;
        end;
end;

procedure Tfrm_CacaPalavras.Image35Click(Sender: TObject);
begin
    if image35.Height = 105 then
      begin
        image35.height := 95;
        image35.Width := 95;
        image35.left := image35.left + 5;
        image35.top := image35.top + 5;

        str := str + 'Y';
        btVerificar.Click;

      end
      else
        begin
           image35.height := 105;
          image35.Width := 105;
          image35.left := image35.left - 5;
          image35.top := image35.top - 5;
          str := '';
          lbSelecionado.Caption := '';
          btAtualizar.Click;
        end;
end;

procedure Tfrm_CacaPalavras.Image36Click(Sender: TObject);
begin
    if image36.Height = 105 then
      begin
        image36.height := 95;
        image36.Width := 95;
        image36.left := image36.left + 5;
        image36.top := image36.top + 5;

        str := str + 'U';
        btVerificar.Click;

      end
      else
        begin
          image36.height := 105;
          image36.Width := 105;
          image36.left := image36.left - 5;
          image36.top := image36.top - 5;
          str := '';
          lbSelecionado.Caption := '';
          btAtualizar.Click;
        end;
end;

procedure Tfrm_CacaPalavras.Image37Click(Sender: TObject);
begin
    if image37.Height = 105 then
      begin
        image37.height := 95;
        image37.Width := 95;
        image37.left := image37.left + 5;
        image37.top := image37.top + 5;

        str := str + 'D';
        btVerificar.Click;

      end
      else
        begin
          image37.height := 105;
          image37.Width := 105;
          image37.left := image37.left - 5;
          image37.top := image37.top - 5;
          str := '';
          lbSelecionado.Caption := '';
          btAtualizar.Click;
        end;
end;

procedure Tfrm_CacaPalavras.Image38Click(Sender: TObject);
begin
    if image38.Height = 105 then
      begin
        image38.height := 95;
        image38.Width := 95;
        image38.left := image38.left + 5;
        image38.top := image38.top + 5;

        str := str + 'A';
        btVerificar.Click;

      end
      else
        begin
          image38.height := 105;
          image38.Width := 105;
          image38.left := image38.left - 5;
          image38.top := image38.top - 5;
          str := '';
          lbSelecionado.Caption := '';
          btAtualizar.Click;
        end;
end;

procedure Tfrm_CacaPalavras.Image39Click(Sender: TObject);
begin
    if image39.Height = 105 then
      begin
        image39.height := 95;
        image39.Width := 95;
        image39.left := image39.left + 5;
        image39.top := image39.top + 5;

        str := str + 'D';
        btVerificar.Click;

      end
      else
        begin
          image39.height := 105;
          image39.Width := 105;
          image39.left := image39.left - 5;
          image39.top := image39.top - 5;
          str := '';
          lbSelecionado.Caption := '';
          btAtualizar.Click;
        end;
end;

procedure Tfrm_CacaPalavras.Image3Click(Sender: TObject);
begin
      if image3.Height = 105 then
      begin
        image3.height := 95;
        image3.Width := 95;
        image3.left := image3.left + 5;
        image3.top := image3.top + 5;

        str := str + 'P';
        btVerificar.Click;

      end
      else
        begin
           image3.height := 105;
          image3.Width := 105;
          image3.left := image3.left - 5;
          image3.top := image3.top - 5;
          str := '';
          lbSelecionado.Caption := '';
          btAtualizar.Click;
        end;
end;

procedure Tfrm_CacaPalavras.Image40Click(Sender: TObject);
begin
    if image40.Height = 105 then
      begin
        image40.height := 95;
        image40.Width := 95;
        image40.left := image40.left + 5;
        image40.top := image40.top + 5;

        str := str + 'C';
        btVerificar.Click;

      end
      else
        begin
           image40.height := 105;
          image40.Width := 105;
          image40.left := image40.left - 5;
          image40.top := image40.top - 5;
          str := '';
          lbSelecionado.Caption := '';
          btAtualizar.Click;
        end;
end;

procedure Tfrm_CacaPalavras.Image41Click(Sender: TObject);
begin
    if image41.Height = 105 then
      begin
        image41.height := 95;
        image41.Width := 95;
        image41.left := image41.left + 5;
        image41.top := image41.top + 5;

        str := str + 'C';
        btVerificar.Click;

      end
      else
        begin
           image41.height := 105;
          image41.Width := 105;
          image41.left := image41.left - 5;
          image41.top := image41.top - 5;
          str := '';
          lbSelecionado.Caption := '';
          btAtualizar.Click;
        end;
end;
procedure Tfrm_CacaPalavras.Image42Click(Sender: TObject);
begin
    if image42.Height = 105 then
      begin
        image42.height := 95;
        image42.Width := 95;
        image42.left := image42.left + 5;
        image42.top := image42.top + 5;

        str := str + 'A';
        btVerificar.Click;

      end
      else
        begin
           image42.height := 105;
          image42.Width := 105;
          image42.left := image42.left - 5;
          image42.top := image42.top - 5;
          str := '';
          lbSelecionado.Caption := '';
          btAtualizar.Click;
        end;
end;

procedure Tfrm_CacaPalavras.Image43Click(Sender: TObject);
begin
    if image43.Height = 105 then
      begin
        image43.height := 95;
        image43.Width := 95;
        image43.left := image43.left + 5;
        image43.top := image43.top + 5;

        str := str + 'I';
        btVerificar.Click;

      end
      else
        begin
           image43.height := 105;
          image43.Width := 105;
          image43.left := image43.left - 5;
          image43.top := image43.top - 5;
          str := '';
          lbSelecionado.Caption := '';
          btAtualizar.Click;
        end;
end;


procedure Tfrm_CacaPalavras.Image44Click(Sender: TObject);
begin
    if image44.Height = 105 then
      begin
        image44.height := 95;
        image44.Width := 95;
        image44.left := image44.left + 5;
        image44.top := image44.top + 5;

        str := str + 'X';
        btVerificar.Click;

      end
      else
        begin
           image44.height := 105;
          image44.Width := 105;
          image44.left := image44.left - 5;
          image44.top := image44.top - 5;
          str := '';
          lbSelecionado.Caption := '';
          btAtualizar.Click;
        end;
end;

procedure Tfrm_CacaPalavras.Image45Click(Sender: TObject);
begin
    if image45.Height = 105 then
      begin
        image45.height := 95;
        image45.Width := 95;
        image45.left := image45.left + 5;
        image45.top := image45.top + 5;

        str := str + 'A';
        btVerificar.Click;

      end
      else
        begin
           image45.height := 105;
          image45.Width := 105;
          image45.left := image45.left - 5;
          image45.top := image45.top - 5;
          str := '';
          lbSelecionado.Caption := '';
          btAtualizar.Click;
        end;
end;

procedure Tfrm_CacaPalavras.Image46Click(Sender: TObject);
begin
    if image46.Height = 105 then
      begin
        image46.height := 95;
        image46.Width := 95;
        image46.left := image46.left + 5;
        image46.top := image46.top + 5;

        str := str + 'B';
        btVerificar.Click;

      end
      else
        begin
           image46.height := 105;
          image46.Width := 105;
          image46.left := image46.left - 5;
          image46.top := image46.top - 5;
          str := '';
          lbSelecionado.Caption := '';
          btAtualizar.Click;
        end;
end;

procedure Tfrm_CacaPalavras.Image47Click(Sender: TObject);
begin
     if image47.Height = 105 then
      begin
        image47.height := 95;
        image47.Width := 95;
        image47.left := image47.left + 5;
        image47.top := image47.top + 5;

        str := str + 'T';
        btVerificar.Click;

      end
      else
        begin
           image47.height := 105;
          image47.Width := 105;
          image47.left := image47.left - 5;
          image47.top := image47.top - 5;
          str := '';
          lbSelecionado.Caption := '';
          btAtualizar.Click;
        end;
end;

procedure Tfrm_CacaPalavras.Image48Click(Sender: TObject);
begin
    if image48.Height = 105 then
      begin
        image48.height := 95;
        image48.Width := 95;
        image48.left := image48.left + 5;
        image48.top := image48.top + 5;

        str := str + 'W';
        btVerificar.Click;

      end
      else
        begin
           image48.height := 105;
          image48.Width := 105;
          image48.left := image48.left - 5;
          image48.top := image48.top - 5;
          str := '';
          lbSelecionado.Caption := '';
          btAtualizar.Click;
        end;
end;

procedure Tfrm_CacaPalavras.Image49Click(Sender: TObject);
begin
    if image49.Height = 105 then
      begin
        image49.height := 95;
        image49.Width := 95;
        image49.left := image49.left + 5;
        image49.top := image49.top + 5;

        str := str + 'A';
        btVerificar.Click;

      end
      else
        begin
           image49.height := 105;
          image49.Width := 105;
          image49.left := image49.left - 5;
          image49.top := image49.top - 5;
          str := '';
          lbSelecionado.Caption := '';
          btAtualizar.Click;
        end;
end;

procedure Tfrm_CacaPalavras.Image4Click(Sender: TObject);
begin
    if image4.Height = 105 then
      begin
        image4.height := 95;
        image4.Width := 95;
        image4.left := image4.left + 5;
        image4.top := image4.top + 5;

        str := str + 'I';
        btVerificar.Click;

      end
      else
        begin
           image4.height := 105;
          image4.Width := 105;
          image4.left := image4.left - 5;
          image4.top := image4.top - 5;
          str := '';
          lbSelecionado.Caption := '';
          btAtualizar.Click;
        end;
end;

procedure Tfrm_CacaPalavras.Image50Click(Sender: TObject);
begin
    if image50.Height = 105 then
      begin
        image50.height := 95;
        image50.Width := 95;
        image50.left := image50.left + 5;
        image50.top := image50.top + 5;

        str := str + 'L';
        btVerificar.Click;

      end
      else
        begin
           image50.height := 105;
          image50.Width := 105;
          image50.left := image50.left - 5;
          image50.top := image50.top - 5;
          str := '';
          lbSelecionado.Caption := '';
          btAtualizar.Click;
        end;
end;

procedure Tfrm_CacaPalavras.Image51Click(Sender: TObject);
begin
    if image51.Height = 105 then
      begin
        image51.height := 95;
        image51.Width := 95;
        image51.left := image51.left + 5;
        image51.top := image51.top + 5;

        str := str + 'C';
        btVerificar.Click;

      end
      else
        begin
           image51.height := 105;
          image51.Width := 105;
          image51.left := image51.left - 5;
          image51.top := image51.top - 5;
          str := '';
          lbSelecionado.Caption := '';
          btAtualizar.Click;
        end;
end;

procedure Tfrm_CacaPalavras.Image52Click(Sender: TObject);
begin
    if image52.Height = 105 then
      begin
        image52.height := 95;
        image52.Width := 95;
        image52.left := image52.left + 5;
        image52.top := image52.top + 5;

        str := str + 'E';
        btVerificar.Click;

      end
      else
        begin
           image52.height := 105;
          image52.Width := 105;
          image52.left := image52.left - 5;
          image52.top := image52.top - 5;
          str := '';
          lbSelecionado.Caption := '';
          btAtualizar.Click;
        end;
end;

procedure Tfrm_CacaPalavras.Image53Click(Sender: TObject);
begin
    if image53.Height = 105 then
      begin
        image53.height := 95;
        image53.Width := 95;
        image53.left := image53.left + 5;
        image53.top := image53.top + 5;

        str := str + 'N';
        btVerificar.Click;

      end
      else
        begin
           image53.height := 105;
          image53.Width := 105;
          image53.left := image53.left - 5;
          image53.top := image53.top - 5;
          str := '';
          lbSelecionado.Caption := '';
          btAtualizar.Click;
        end;
end;

procedure Tfrm_CacaPalavras.Image54Click(Sender: TObject);
begin
    if image54.Height = 105 then
      begin
        image54.height := 95;
        image54.Width := 95;
        image54.left := image54.left + 5;
        image54.top := image54.top + 5;

        str := str + 'O';
        btVerificar.Click;

      end
      else
        begin
           image54.height := 105;
          image54.Width := 105;
          image54.left := image54.left - 5;
          image54.top := image54.top - 5;
          str := '';
          lbSelecionado.Caption := '';
          btAtualizar.Click;
        end;
end;

procedure Tfrm_CacaPalavras.Image55Click(Sender: TObject);
begin
    if image55.Height = 105 then
      begin
        image55.height := 95;
        image55.Width := 95;
        image55.left := image55.left + 5;
        image55.top := image55.top + 5;

        str := str + 'B';
        btVerificar.Click;

      end
      else
        begin
           image55.height := 105;
          image55.Width := 105;
          image55.left := image55.left - 5;
          image55.top := image55.top - 5;
          str := '';
          lbSelecionado.Caption := '';
          btAtualizar.Click;
        end;
end;

procedure Tfrm_CacaPalavras.Image56Click(Sender: TObject);
begin
    if image56.Height = 105 then
      begin
        image56.height := 95;
        image56.Width := 95;
        image56.left := image56.left + 5;
        image56.top := image56.top + 5;

        str := str + 'V';
        btVerificar.Click;

      end
      else
        begin
           image56.height := 105;
          image56.Width := 105;
          image56.left := image56.left - 5;
          image56.top := image56.top - 5;
          str := '';
          lbSelecionado.Caption := '';
          btAtualizar.Click;
        end;
end;

procedure Tfrm_CacaPalavras.Image57Click(Sender: TObject);
begin
    if image57.Height = 105 then
      begin
        image57.height := 95;
        image57.Width := 95;
        image57.left := image57.left + 5;
        image57.top := image57.top + 5;

        str := str + 'A';
        btVerificar.Click;

      end
      else
        begin
           image57.height := 105;
          image57.Width := 105;
          image57.left := image57.left - 5;
          image57.top := image57.top - 5;
          str := '';
          lbSelecionado.Caption := '';
          btAtualizar.Click;
        end;
end;

procedure Tfrm_CacaPalavras.Image58Click(Sender: TObject);
begin
    if image58.Height = 105 then
      begin
        image58.height := 95;
        image58.Width := 95;
        image58.left := image58.left + 5;
        image58.top := image58.top + 5;

        str := str + 'O';
        btVerificar.Click;

      end
      else
        begin
          image58.height := 105;
          image58.Width := 105;
          image58.left := image58.left - 5;
          image58.top := image58.top - 5;
          str := '';
          lbSelecionado.Caption := '';
          btAtualizar.Click;
        end;
end;

procedure Tfrm_CacaPalavras.Image59Click(Sender: TObject);
begin
    if image59.Height = 105 then
      begin
        image59.height := 95;
        image59.Width := 95;
        image59.left := image59.left + 5;
        image59.top := image59.top + 5;

        str := str + 'G';
        btVerificar.Click;

      end
      else
        begin
           image59.height := 105;
          image59.Width := 105;
          image59.left := image59.left - 5;
          image59.top := image59.top - 5;
          str := '';
          lbSelecionado.Caption := '';
          btAtualizar.Click;
        end;
end;

procedure Tfrm_CacaPalavras.Image5Click(Sender: TObject);
begin
    if image5.Height = 105 then
      begin
        image5.height := 95;
        image5.Width := 95;
        image5.left := image5.left + 5;
        image5.top := image5.top + 5;

        str := str + 'P';
        btVerificar.Click;

      end
      else
        begin
           image5.height := 105;
          image5.Width := 105;
          image5.left := image5.left - 5;
          image5.top := image5.top - 5;
          str := '';
          lbSelecionado.Caption := '';
          btAtualizar.Click;
        end;
end;

procedure Tfrm_CacaPalavras.Image60Click(Sender: TObject);
begin
     if image60.Height = 105 then
      begin
        image60.height := 95;
        image60.Width := 95;
        image60.left := image60.left + 5;
        image60.top := image60.top + 5;

        str := str + 'A';
        btVerificar.Click;

      end
      else
        begin
           image60.height := 105;
          image60.Width := 105;
          image60.left := image60.left - 5;
          image60.top := image60.top - 5;
          str := '';
          lbSelecionado.Caption := '';
          btAtualizar.Click;
        end;
end;

procedure Tfrm_CacaPalavras.Image6Click(Sender: TObject);
begin
   if image6.Height = 105 then
      begin
        image6.height := 95;
        image6.Width := 95;
        image6.left := image6.left + 5;
        image6.top := image6.top + 5;

        str := str + 'A';
        btVerificar.Click;

      end
      else
        begin
           image6.height := 105;
          image6.Width := 105;
          image6.left := image6.left - 5;
          image6.top := image6.top - 5;
          str := '';
          lbSelecionado.Caption := '';
          btAtualizar.Click;
        end;
end;

procedure Tfrm_CacaPalavras.Image7Click(Sender: TObject);
begin
    if image7.Height = 105 then
      begin
        image7.height := 95;
        image7.Width := 95;
        image7.left := image7.left + 5;
        image7.top := image7.top + 5;

        str := str + 'A';
        btVerificar.Click;

      end
      else
        begin
           image7.height := 105;
          image7.Width := 105;
          image7.left := image7.left - 5;
          image7.top := image7.top - 5;
          str := '';
          lbSelecionado.Caption := '';
          btAtualizar.Click;
        end;
end;

procedure Tfrm_CacaPalavras.Image8Click(Sender: TObject);
begin
    if image8.Height = 105 then
      begin
        image8.height := 95;
        image8.Width := 95;
        image8.left := image8.left + 5;
        image8.top := image8.top + 5;

        str := str + 'B';
        btVerificar.Click;

      end
      else
        begin
           image8.height := 105;
          image8.Width := 105;
          image8.left := image8.left - 5;
          image8.top := image8.top - 5;
          str := '';
          lbSelecionado.Caption := '';
          btAtualizar.Click;
        end;
end;

procedure Tfrm_CacaPalavras.Image9Click(Sender: TObject);
begin
    if image9.Height = 105 then
      begin
        image9.height := 95;
        image9.Width := 95;
        image9.left := image9.left + 5;
        image9.top := image9.top + 5;

        str := str + 'E';
        btVerificar.Click;

      end
      else
        begin
           image9.height := 105;
          image9.Width := 105;
          image9.left := image9.left - 5;
          image9.top := image9.top - 5;
          str := '';
          lbSelecionado.Caption := '';
          btAtualizar.Click;
        end;
end;

end.
