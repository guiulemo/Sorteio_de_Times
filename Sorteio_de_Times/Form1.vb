Imports VB = Microsoft.VisualBasic

Module Modulo1
    Public AListaJ As String() = Form1.ListaJ.Lines
    Public AListaC As String() = Form1.ListaC.Lines
    Public InterromperProcesso As Boolean

    Public Sub Wait(ByVal seconds As Single)
        Static start As Single
        start = VB.Timer()
        Do While VB.Timer() < start + seconds
            If InterromperProcesso = True Then
                Exit Sub
            End If
            System.Windows.Forms.Application.DoEvents()
        Loop
    End Sub

    Public Function RefCxTxtJ(ByVal x As Integer)
        Dim CaixaTxtJ As Control = Nothing
        Dim SearchedControlsJ = Form1.Controls.Find(key:="SortJ" & x, searchAllChildren:=True)

        If SearchedControlsJ.Count = 1 Then
            CaixaTxtJ = SearchedControlsJ(0)
        End If

        Return CaixaTxtJ
    End Function

    Public Function RefCxTxtC(ByVal x As Integer)
        Dim CaixaTxtC As Control = Nothing
        Dim SearchedControlsC = Form1.Controls.Find(key:="SortC" & x, searchAllChildren:=True)

        If SearchedControlsC.Count = 1 Then
            CaixaTxtC = SearchedControlsC(0)
        End If

        Return CaixaTxtC
    End Function

    Public Function RefLogo(ByVal x As Integer)
        Dim LogoR As PictureBox = Nothing
        Dim SearchedPic = Form1.Controls.Find(key:="Logo" & x, searchAllChildren:=True)

        If SearchedPic.Count = 1 Then
            LogoR = SearchedPic(0)
        End If

        Return LogoR
    End Function

    Public Function RefPanel(ByVal x As Integer)
        Dim PanelRef As Panel = Nothing
        Dim SearchedPan = Form1.Controls.Find(key:="JColor" & x, searchAllChildren:=True)

        If SearchedPan.Count = 1 Then
            PanelRef = SearchedPan(0)
        End If

        Return PanelRef
    End Function

    Public Function AdequaNome(ByVal e As String)
        Dim Nome As String
        Nome = LCase(Replace(Replace(Replace(e, " ", "_"), "-", "_"), "&", "e"))
        Return Nome
    End Function

End Module

Public Class Form1
    Dim NumJog As Integer
    Dim NumClu As Integer
    Dim a As Integer
    Dim i As Integer = 1
    Dim r As New Random
    Dim endT As Integer
    Dim menT As Int32
    Dim maiT As Int32
    Dim Esc As Object
    Private rnd0 As New Random()
    'Procedimento que reordena aleatoriamente uma lista de items
    Public Sub Shuffle(items As String())
        Dim j As Int32
        Dim temp As String

        For n As Int32 = items.Length - 1 To 0 Step -1
            j = rnd0.Next(0, n + 1)
            ' Swap them.
            temp = items(n)
            items(n) = items(j)
            items(j) = temp
        Next n
    End Sub
    'Botão principal que engatilha o sorteio
    Public Sub BtnSort_Click(sender As Object, e As EventArgs) Handles BtnSort.Click
        Organiza() 'Procedimento que organiza as listas de jogadores e times (Linhas em branco, espacos, etc)

        'Armazenam o número de jogadores e de clubes
        If AListaJ.Count > 8 Then
            NumJog = 8
        Else
            NumJog = AListaJ.Count
        End If
        NumClu = AListaC.Count

        'Embaralha a lista de jogadores e clubes
        Shuffle(AListaJ)
        Shuffle(AListaC)

        'Estabelece o intervalo minimo e máximo de tempo que os times ficam "sorteando"
        menT = 50
        maiT = 60
        endT = 0

        'Reseta a variável que controla a ordem de preenchimento das Text Boxes
        i = 1

        If NumJog < 1 Then
            MsgBox("Insira ao menos 1 jogador", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        If NumClu < NumJog Then
            MsgBox("Número de times menor que o de jogadores", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        AddJ.Enabled = False
        PesquisaC.Enabled = False
        'ListaJ.Enabled = False
        'ListaC.Enabled = False
        BtnSort.Enabled = False
        BtnLimpar.Enabled = False
        TrackBar1.Enabled = False

        'Limpa todos os campos e habilita o botão para cancelar
        BtnLimpar_Click(sender, e)
        BtnCancel.Enabled = True

        'Ativa o sorteio
        If TrackBar1.Value = 0 Then
            menT = 0
            maiT = 0
            Timer1.Enabled = True
        ElseIf TrackBar1.Value = 1 Then
            Timer1.Enabled = True
        ElseIf TrackBar1.Value = 2 Then
            Form2.Show()
            Form2.Timer3.Enabled = True
            Form2.ContRegr.Visible = True
        End If
    End Sub
    'Temporizador do sorteio (Efeito roleta níveis 0 e 1)
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim Position As Integer = CInt(Int((NumClu * Rnd()) + 0))

        RefCxTxtJ(i).Text = AListaJ(i - 1)
        RefCxTxtC(i).Text = AListaC(Position)

        Esc = AdequaNome(RefCxTxtC(i).Text)
        RefLogo(i).Image = My.Resources.ResourceManager.GetObject(Esc)

        If My.Resources.ResourceManager.GetObject(Esc) Is Nothing Then
            RefLogo(i).Image = My.Resources.generic_logo
        Else
            RefLogo(i).Image = My.Resources.ResourceManager.GetObject(Esc)
        End If

        endT += 1

        If endT > r.Next(menT, maiT) Then
            Timer1.Enabled = False
            RefCxTxtC(i).Text = AListaC(i - 1)
            Esc = AdequaNome(RefCxTxtC(i).Text)
            If My.Resources.ResourceManager.GetObject(Esc) Is Nothing Then
                RefLogo(i).Image = My.Resources.generic_logo
            Else
                RefLogo(i).Image = My.Resources.ResourceManager.GetObject(Esc)
            End If

            If TrackBar1.Value = 1 Then
                My.Computer.Audio.Play(My.Resources.MiraiBeep, AudioPlayMode.Background)
            End If
            endT = 0
            i += 1
            If i > NumJog Then
                i = 1
                ReativaBtn()
                Exit Sub
            Else
                Timer1.Enabled = True
            End If
        End If
    End Sub
    'Temporizador do sorteio (Efeito roleta nível 2)
    Public Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Dim Position As Integer = CInt(Int((NumClu * Rnd()) + 0))

        RefCxTxtJ(i).Text = AListaJ(i - 1)

        If endT = 0 Then
            Form2.ModDrTxtJ.Text = UCase(AListaJ(i - 1))
            Form2.JColor.BackColor = RefPanel(i).BackColor
            Form2.ContAuxJog.Text = i & "/" & NumJog
            My.Computer.Audio.Play(My.Resources.WE9change, AudioPlayMode.Background)
        End If

        Form2.ModDrTxtC.Text = UCase(AListaC(Position))
        Esc = AdequaNome(Form2.ModDrTxtC.Text)

        If My.Resources.ResourceManager.GetObject(Esc) Is Nothing Then
            Form2.Escudo.Image = My.Resources.generic_logo
        Else
            Form2.Escudo.Image = My.Resources.ResourceManager.GetObject(Esc)
        End If

        endT += 1
        If endT > r.Next(menT, maiT) Then
            Timer2.Enabled = False
            RefCxTxtC(i).Text = AListaC(i - 1)
            Form2.ModDrTxtC.Text = UCase(AListaC(i - 1))
            Esc = AdequaNome(Form2.ModDrTxtC.Text)

            If My.Resources.ResourceManager.GetObject(Esc) Is Nothing Then
                Form2.Escudo.Image = My.Resources.generic_logo
                RefLogo(i).Image = My.Resources.generic_logo
            Else
                Form2.Escudo.Image = My.Resources.ResourceManager.GetObject(Esc)
                RefLogo(i).Image = My.Resources.ResourceManager.GetObject(Esc)
            End If

            My.Computer.Audio.Play(My.Resources.WE9select, AudioPlayMode.Background)
            endT = 0
            i += 1
            If i > NumJog Then
                BtnCancel.Enabled = False
                Wait(3)
                Form2.Close()
                ReativaBtn()
                Exit Sub
            Else
                Wait(3)
                If InterromperProcesso = True Then
                    BtnCancel_Click(sender, e)
                Else
                    Timer2.Enabled = True
                End If
            End If
        End If
    End Sub

    'Limpa todos os campos
    Private Sub BtnLimpar_Click(sender As Object, e As EventArgs) Handles BtnLimpar.Click
        For Each c As Object In Me.Panel4.Controls
            For Each d As Object In c.Controls
                If TypeOf d Is TextBox Then
                    DirectCast(d, TextBox).ResetText()
                ElseIf TypeOf d Is PictureBox Then
                    d.Image = My.Resources.generic_logo
                End If
            Next
        Next
    End Sub
    'Cancela o processo de sorteio
    Public Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        For Each c As Object In Me.components.Components
            If TypeOf c Is Timer Then
                CType(c, System.Windows.Forms.Timer).Stop()
            End If
        Next
        Form2.Close()
        BtnLimpar_Click(sender, e)
        ReativaBtn()
    End Sub
    'Controla o nível de "drama"
    Private Sub TrackBar1_Scroll(sender As Object, e As EventArgs) Handles TrackBar1.Scroll
        If TrackBar1.Value = 0 Then
            Nidrama.Text = "Sem drama"
        ElseIf TrackBar1.Value = 1 Then
            Nidrama.Text = "Suspense"
        ElseIf TrackBar1.Value = 2 Then
            Nidrama.Text = "Dramático"
        End If
    End Sub
    'Reativa os botões
    Public Sub ReativaBtn()
        AddJ.Enabled = True
        PesquisaC.Enabled = True
        'ListaJ.Enabled = True
        'ListaC.Enabled = True
        BtnSort.Enabled = True
        BtnLimpar.Enabled = True
        TrackBar1.Enabled = True
        BtnCancel.Enabled = False
    End Sub
    'Procedimento que remove espaços e linhas em branco das listas de jogadores e clubes
    Public Sub Organiza()
        Dim StrAux0 As String = Nothing
        Dim StrAux1 As String = Nothing

        'Remove linhas em branco ou com espaços na lista de jogadores
        For Each c As String In ListaJ.Lines
            c = c.Trim()
            StrAux0 += c & Environment.NewLine
        Next
        ListaJ.Text = StrAux0
        DelRepetidos(ListaJ)
        ListaJ.Lines = ListaJ.Text.Split(New Char() {ControlChars.Lf}, StringSplitOptions.RemoveEmptyEntries)
        AListaJ = ListaJ.Lines

        'Remove linhas em branco ou com espaços na lista de times
        For Each c As String In ListaC.Lines
            c = c.Trim()
            StrAux1 += c & Environment.NewLine
        Next
        ListaC.Text = StrAux1
        DelRepetidos(ListaC)
        ListaC.Lines = ListaC.Text.Split(New Char() {ControlChars.Lf}, StringSplitOptions.RemoveEmptyEntries)
        AListaC = ListaC.Lines
    End Sub
    'Procedimento que remove os nomes de Jogadores e Clubes repetidos
    Public Sub DelRepetidos(ByVal e As RichTextBox)
        Dim Linha As String = Nothing
        Dim contador As Integer = 0
        Dim lines() As String = e.Lines

        For x = 0 To e.Lines.Count - 1
            Linha = e.Lines(x)
            contador = 0
            For Each c As String In e.Lines
                If LCase(c) = LCase(lines(x)) Then
                    contador += 1
                    If contador > 1 Then
                        lines(x) = ""
                        e.Lines = lines
                    End If
                End If
            Next
        Next
    End Sub

    Private Sub AddJ_Enter(sender As Object, e As EventArgs) Handles AddJ.Enter
        AddJ.ForeColor = Color.FromArgb(0)
        AddJ.Text = ""
    End Sub

    Private Sub AddJ_Leave(sender As Object, e As EventArgs) Handles AddJ.Leave
        AddJ.ForeColor = Color.FromArgb(109, 109, 109)
        AddJ.Text = "Adicionar Jogadores"
    End Sub

    Private Sub AddJ_KeyDown(sender As Object, e As KeyEventArgs) Handles AddJ.KeyDown
        If e.KeyCode = Keys.Enter Then
            ListaJ.Text += Environment.NewLine & AddJ.Text
            Organiza()
            AddJ.Text = ""
        End If
    End Sub

    Private Sub PesquisaC_Enter(sender As Object, e As EventArgs) Handles PesquisaC.Enter
        PesquisaC.ForeColor = Color.FromArgb(0)
        PesquisaC.Text = ""
    End Sub

    Private Sub PesquisaC_Leave(sender As Object, e As EventArgs) Handles PesquisaC.Leave
        PesquisaC.ForeColor = Color.FromArgb(109, 109, 109)
        PesquisaC.Text = "Pesquisar Clubes"
    End Sub

    Private Sub PesquisaC_KeyDown(sender As Object, e As KeyEventArgs) Handles PesquisaC.KeyDown
        If e.KeyCode = Keys.Enter Then
            ListaC.Text += Environment.NewLine & PesquisaC.Text
            Organiza()
            PesquisaC.Text = ""
        End If
    End Sub

End Class