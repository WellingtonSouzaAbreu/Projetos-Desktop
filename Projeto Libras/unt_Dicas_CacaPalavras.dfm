object frm_Dica_CacaPalavras: Tfrm_Dica_CacaPalavras
  Left = 0
  Top = 0
  Caption = 'Como Jogar'
  ClientHeight = 749
  ClientWidth = 1370
  Color = clBtnFace
  Font.Charset = DEFAULT_CHARSET
  Font.Color = clWindowText
  Font.Height = -19
  Font.Name = 'Tahoma'
  Font.Style = []
  OldCreateOrder = False
  WindowState = wsMaximized
  PixelsPerInch = 96
  TextHeight = 23
  object Label1: TLabel
    Left = 48
    Top = 161
    Width = 175
    Height = 53
    Caption = 'Objetivo:'
    Font.Charset = ANSI_CHARSET
    Font.Color = clWindowText
    Font.Height = -47
    Font.Name = 'Times New Roman'
    Font.Style = []
    ParentFont = False
  end
  object Label2: TLabel
    Left = 120
    Top = 224
    Width = 1033
    Height = 53
    Caption = '* Encontre todas as 9 palavras que est'#227'o embaralhadas'
    Font.Charset = ANSI_CHARSET
    Font.Color = clWindowText
    Font.Height = -47
    Font.Name = 'Times New Roman'
    Font.Style = []
    ParentFont = False
  end
  object Label3: TLabel
    Left = 48
    Top = 294
    Width = 236
    Height = 53
    Caption = 'Como jogar:'
    Font.Charset = ANSI_CHARSET
    Font.Color = clWindowText
    Font.Height = -47
    Font.Name = 'Times New Roman'
    Font.Style = []
    ParentFont = False
  end
  object Label4: TLabel
    Left = 120
    Top = 350
    Width = 1224
    Height = 53
    Caption = 
      '* Clique sobre sobre as letras na sequ'#234'ncia para formar a palavr' +
      'a'
    Font.Charset = ANSI_CHARSET
    Font.Color = clWindowText
    Font.Height = -47
    Font.Name = 'Times New Roman'
    Font.Style = []
    ParentFont = False
  end
  object Label5: TLabel
    Left = 120
    Top = 413
    Width = 1158
    Height = 53
    Caption = '* Para desmarcar uma sele'#231#227'o, clique novamente em alguma '
    Font.Charset = ANSI_CHARSET
    Font.Color = clWindowText
    Font.Height = -47
    Font.Name = 'Times New Roman'
    Font.Style = []
    ParentFont = False
  end
  object Label6: TLabel
    Left = 152
    Top = 461
    Width = 398
    Height = 53
    Caption = 'figura j'#225' selecionada.'
    Font.Charset = ANSI_CHARSET
    Font.Color = clWindowText
    Font.Height = -47
    Font.Name = 'Times New Roman'
    Font.Style = []
    ParentFont = False
  end
  object Label7: TLabel
    Left = 496
    Top = 39
    Width = 425
    Height = 76
    Caption = 'Ca'#231'a-Palavras'
    Font.Charset = ANSI_CHARSET
    Font.Color = clWindowText
    Font.Height = -67
    Font.Name = 'Bauhaus 93'
    Font.Style = []
    ParentFont = False
  end
  object btJogar: TButton
    Left = 1072
    Top = 608
    Width = 248
    Height = 73
    Caption = 'Jogar'
    Font.Charset = ANSI_CHARSET
    Font.Color = clWindowText
    Font.Height = -37
    Font.Name = 'Times New Roman'
    Font.Style = []
    ParentFont = False
    TabOrder = 0
    OnClick = btJogarClick
  end
  object Button1: TButton
    Left = 48
    Top = 608
    Width = 248
    Height = 73
    Caption = 'Menu'
    Font.Charset = ANSI_CHARSET
    Font.Color = clWindowText
    Font.Height = -37
    Font.Name = 'Times New Roman'
    Font.Style = []
    ParentFont = False
    TabOrder = 1
    OnClick = Button1Click
  end
end