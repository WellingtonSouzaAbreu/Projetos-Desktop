object frm_Dica_JogoMemoria: Tfrm_Dica_JogoMemoria
  Left = 0
  Top = 0
  Caption = 'Como jogar'
  ClientHeight = 749
  ClientWidth = 1370
  Color = clBtnFace
  Font.Charset = DEFAULT_CHARSET
  Font.Color = clWindowText
  Font.Height = -11
  Font.Name = 'Tahoma'
  Font.Style = []
  OldCreateOrder = False
  WindowState = wsMaximized
  PixelsPerInch = 96
  TextHeight = 13
  object Label1: TLabel
    Left = 48
    Top = 137
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
    Top = 200
    Width = 997
    Height = 53
    Caption = '* Encontre todos os pares antes que o tempo termine'
    Font.Charset = ANSI_CHARSET
    Font.Color = clWindowText
    Font.Height = -47
    Font.Name = 'Times New Roman'
    Font.Style = []
    ParentFont = False
    Layout = tlBottom
  end
  object Label3: TLabel
    Left = 48
    Top = 299
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
    Top = 355
    Width = 740
    Height = 53
    Caption = '* Clique em um quadro para desvir'#225'-lo'
    Font.Charset = ANSI_CHARSET
    Font.Color = clWindowText
    Font.Height = -47
    Font.Name = 'Times New Roman'
    Font.Style = []
    ParentFont = False
  end
  object Label5: TLabel
    Left = 120
    Top = 414
    Width = 1241
    Height = 53
    Caption = 
      '* Para acertar voc'#234' deve desvirar uma letra e o seu sinal em lib' +
      'ras'
    Font.Charset = ANSI_CHARSET
    Font.Color = clWindowText
    Font.Height = -47
    Font.Name = 'Times New Roman'
    Font.Style = []
    ParentFont = False
  end
  object Label6: TLabel
    Left = 120
    Top = 473
    Width = 581
    Height = 53
    Caption = '* Cada erro reduz o seu tempo'
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
