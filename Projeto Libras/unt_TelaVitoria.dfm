object frm_TelaVitoria: Tfrm_TelaVitoria
  Left = 0
  Top = 0
  BorderIcons = []
  ClientHeight = 201
  ClientWidth = 447
  Color = clBtnFace
  Font.Charset = DEFAULT_CHARSET
  Font.Color = clWindowText
  Font.Height = -11
  Font.Name = 'Tahoma'
  Font.Style = []
  OldCreateOrder = False
  Position = poScreenCenter
  PixelsPerInch = 96
  TextHeight = 13
  object lbParabens: TLabel
    Left = 80
    Top = 40
    Width = 300
    Height = 33
    Caption = 'Parab'#233'ns! Voc'#234' venceu!'
    Font.Charset = ANSI_CHARSET
    Font.Color = clWindowText
    Font.Height = -27
    Font.Name = 'Small Fonts'
    Font.Style = []
    ParentFont = False
  end
  object Button1: TButton
    Left = 168
    Top = 128
    Width = 97
    Height = 33
    Caption = 'Voltar ao menu'
    TabOrder = 0
    OnClick = Button1Click
  end
end
