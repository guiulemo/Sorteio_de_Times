Imports VB = Microsoft.VisualBasic
Imports System.Data.SQLite
Imports System.ComponentModel

Module Modulo1
    Public AListaJ As String()
    Public AListaC As String()
    Public InterromperProcesso As Boolean
    Public ExitProgram As Boolean = False
    Public constr As String = "Data Source=SorteioPES.db"

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

    Public Sub GridToArrayJ()
        Dim output(Form1.DataGridView1.Columns.Count * If(Form1.DataGridView1.NewRowIndex <> -1, Form1.DataGridView1.Rows.Count - 1, Form1.DataGridView1.Rows.Count) - 1) As String
        Dim i As Integer = 0

        For Each row As DataGridViewRow In Form1.DataGridView1.Rows
            If row.IsNewRow Then Continue For
            For Each cell As DataGridViewCell In row.Cells
                output(i) = cell.Value.ToString
                i += 1
            Next
        Next
        AListaJ = output
    End Sub

    Public Sub GridToArrayC()
        Dim output(Form1.DataGridView2.Columns.Count * If(Form1.DataGridView2.NewRowIndex <> -1, Form1.DataGridView2.Rows.Count - 1, Form1.DataGridView2.Rows.Count) - 1) As String
        Dim i As Integer = 0

        For Each row As DataGridViewRow In Form1.DataGridView2.Rows
            If row.IsNewRow Then Continue For
            For Each cell As DataGridViewCell In row.Cells
                output(i) = cell.Value.ToString
                i += 1
            Next
        Next
        AListaC = output
    End Sub

    Public Sub Clube_autocomplete()
        Dim consulta As String
        Dim cn As New SQLiteConnection(constr)
        Try
            cn.Open()
        Catch ex As Exception
            cn.Dispose()
            cn = Nothing
            MsgBox(ex.Message)
            Exit Sub
        End Try

        If Form1.Label2.Text = "Lista de Clubes" Then
            consulta = "Select Nome From Clubes Where Selecao = 'N'"
        Else
            consulta = "Select Nome From Clubes Where Selecao = 'S'"
        End If

        Form1.PesquisaC.AutoCompleteCustomSource = Nothing

        Using cmd As New SQLiteCommand(consulta, cn)
            Using rd As SQLiteDataReader = cmd.ExecuteReader
                While rd.Read
                    With Form1.PesquisaC
                        .AutoCompleteCustomSource.Add(rd.Item(0))
                    End With
                End While
                rd.Close()
            End Using
        End Using
        cn.Close()
    End Sub

    Public Sub Jogador_autocomplete()
        Dim cn As New SQLiteConnection(constr)
        Try
            cn.Open()
        Catch ex As Exception
            cn.Dispose()
            cn = Nothing
            MsgBox(ex.Message)
            Exit Sub
        End Try

        Using cmd As New SQLiteCommand("Select Nome From Jogadores", cn)
            Using rd As SQLiteDataReader = cmd.ExecuteReader
                While rd.Read
                    With Form1.AddJ
                        .AutoCompleteCustomSource.Add(rd.Item(0))
                    End With
                End While
                rd.Close()
            End Using
        End Using
        cn.Close()
    End Sub

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

    'SUBs BANCO DE DADOS
    Private Sub dafill(ByVal q As String, ByVal tbl As DataTable, ByVal cn As SQLiteConnection)
        Dim da As New SQLiteDataAdapter(q, cn)
        da.Fill(tbl)
        da.Dispose()
        da = Nothing
    End Sub
    Private Sub ExecuteNonQuery(ByVal query As String, ByVal cn As SQLiteConnection)
        Dim cm As New SQLiteCommand(query, cn)
        cm.ExecuteNonQuery()
        cm.Dispose()
        cm = Nothing
    End Sub

    'SHUFFLE
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
    'BOTÃO SORTEAR
    Public Sub BtnSort_Click(sender As Object, e As EventArgs) Handles BtnSort.Click
        'Confirmação da realização do sorteio
        If BtnRegistrar.Enabled = True Then
            Dim Result As DialogResult
            Result = MsgBox("Tem certeza de que deseja realizar novo sorteio?", MsgBoxStyle.YesNo + MessageBoxIcon.Question, "Novo sorteio")
            If Result = MsgBoxResult.No Then
                Exit Sub
            End If
        End If

        'Transforma os nomes do jogadores e dos times de GRID para ARRAY
        GridToArrayJ()
        GridToArrayC()

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
        BtnSort.Enabled = False
        BtnRegistrar.Enabled = False
        TrackBar1.Enabled = False

        'Limpa todos os campos e habilita o botão para cancelar
        LimparCampos()
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
                SalvaPosicao()
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
                SalvaPosicao()
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
    'BOTÃO REGISTRAR
    Private Sub BtnRegistrar_Click(sender As Object, e As EventArgs) Handles BtnRegistrar.Click
        ResultTorneio.ShowDialog()
    End Sub
    'LIMPAR CAMPOS
    Public Sub LimparCampos()
        For Each c As Object In Panel4.Controls
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
        LimparCampos()
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
        ConfereLimite()
        PesquisaC.Enabled = True
        BtnSort.Enabled = True
        TrackBar1.Enabled = True
        BtnCancel.Enabled = False
        If SortJ1.Text <> Nothing Then
            BtnRegistrar.Enabled = True
        End If
    End Sub

    'ADDJ PRESSIONA ENTER
    Private Sub AddJ_KeyDown(sender As Object, e As KeyEventArgs) Handles AddJ.KeyDown
        If e.KeyCode = Keys.Enter And LCase(Trim(AddJ.Text)) <> Nothing Then

            For Each row As DataGridViewRow In DataGridView1.Rows
                For Each cell As DataGridViewCell In row.Cells
                    If LCase(Trim(cell.Value)) = LCase(Trim(AddJ.Text)) Then
                        MsgBox(UCase(Trim(AddJ.Text)) & " já foi adicionado(a)", MsgBoxStyle.Exclamation, "Atenção")
                        Exit Sub
                    End If
                Next
            Next

            Dim cn As New SQLiteConnection(constr)
            Try
                cn.Open()
            Catch ex As Exception
                cn.Dispose()
                cn = Nothing
                MsgBox(ex.Message)
                Exit Sub
            End Try

            Dim dtc As New DataTable
            Try
                dafill("Select Nome FROM Jogadores where Nome = '" & Trim(AddJ.Text) & "' COLLATE NOCASE", dtc, cn)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            If dtc.Rows.Count > 0 Then
                ExecuteNonQuery("Update Jogadores SET Part_ultimo = 'S' where Nome = '" & Trim(AddJ.Text) & "' COLLATE NOCASE", cn)
            Else
                Try
                    Dim Result As DialogResult
                    Result = MsgBox("Será o primeiro torneio de " & UCase(Trim(AddJ.Text)) & "." & vbCrLf & "Deseja cadastrá-lo(a)?", MsgBoxStyle.YesNo + MessageBoxIcon.Question, "Novo Jogador(a)")
                    If Result = MsgBoxResult.Yes Then
                        ExecuteNonQuery("Insert Into Jogadores (Nome, Pontos, Part_ultimo, Participacoes) values ('" & Trim(AddJ.Text) & "', 0, 'S', 0)", cn)
                    Else
                        dtc.Dispose()
                        dtc = Nothing
                        cn.Close()
                        cn.Dispose()
                        cn = Nothing
                        Exit Sub
                    End If
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End If

            Dim dt As New DataTable
            Try
                dafill("Select Nome From Jogadores Where Part_ultimo = 'S' Order By 1", dt, cn)
                DataGridView1.DataSource = Nothing
                DataGridView1.DataSource = dt
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

            'Seleciona célula do jogador que acabou de ser incluído
            For Each row As DataGridViewRow In DataGridView1.Rows
                For Each cell As DataGridViewCell In row.Cells
                    If LCase(Trim(cell.Value)) = LCase(Trim(AddJ.Text)) Then
                        DataGridView1.CurrentCell = DataGridView1.Rows(cell.RowIndex).Cells(0)
                    End If
                Next
            Next

            dtc.Dispose()
            dtc = Nothing
            dt.Dispose()
            dt = Nothing
            cn.Close()
            cn.Dispose()
            cn = Nothing

            ConfereLimite()
        End If
    End Sub
    'DELETE JOGADOR
    Private Sub DataGridView1_KeyDown(sender As Object, e As KeyEventArgs) Handles DataGridView1.KeyDown
        If e.KeyCode = Keys.Delete And DataGridView1.Rows.Count > 0 Then
            Dim Nome As String = DataGridView1.CurrentCell.Value.ToString()
            Dim Position As Integer = DataGridView1.CurrentCell.RowIndex
            Dim NumLinhas As Integer = DataGridView1.Rows.Count
            Dim cn As New SQLiteConnection(constr)

            If Position + 1 = NumLinhas Then
                Position = Position - 1
            End If

            Try
                cn.Open()
            Catch ex As Exception
                cn.Dispose()
                cn = Nothing
                MsgBox(ex.Message)
                Exit Sub
            End Try

            ExecuteNonQuery("Update Jogadores SET Part_ultimo = 'N' where Nome = '" & Nome & "' COLLATE NOCASE", cn)

            Dim dt As New DataTable
            Try
                dafill("Select Nome From Jogadores Where Part_ultimo = 'S' Order By 1", dt, cn)
                DataGridView1.DataSource = Nothing
                DataGridView1.DataSource = dt
                If NumLinhas > 1 Then
                    DataGridView1.CurrentCell = DataGridView1.Rows(Position).Cells(0)
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

            dt.Dispose()
            dt = Nothing
            cn.Close()
            cn.Dispose()
            cn = Nothing

            If DataGridView1.Rows.Count < 8 Then
                AddJ.Enabled = True
                AddJ.Text = "Adicionar Jogadores"
            End If
        End If
    End Sub
    'PESQUISA CLUBE
    Private Sub PesquisaC_KeyDown(sender As Object, e As KeyEventArgs) Handles PesquisaC.KeyDown
        If e.KeyCode = Keys.Enter And LCase(Trim(PesquisaC.Text)) <> Nothing Then

            For Each row As DataGridViewRow In DataGridView2.Rows
                For Each cell As DataGridViewCell In row.Cells
                    If LCase(Trim(cell.Value)) = LCase(Trim(PesquisaC.Text)) Then
                        MsgBox(UCase(Trim(PesquisaC.Text)) & " já foi adicionado(a)", MsgBoxStyle.Exclamation, "Atenção")
                        Exit Sub
                    End If
                Next
            Next

            Dim cn As New SQLiteConnection(constr)
            Try
                cn.Open()
            Catch ex As Exception
                cn.Dispose()
                cn = Nothing
                MsgBox(ex.Message)
                Exit Sub
            End Try

            Dim dtc As New DataTable
            Try
                dafill("Select Nome FROM Clubes where Nome = '" & Trim(PesquisaC.Text) & "' COLLATE NOCASE", dtc, cn)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            If dtc.Rows.Count > 0 Then
                ExecuteNonQuery("Update Clubes SET ListaSorteio = 'S' where Nome = '" & Trim(PesquisaC.Text) & "' COLLATE NOCASE", cn)
            Else
                MsgBox("Time não localizado", MessageBoxIcon.Exclamation, "Atenção")
                dtc.Dispose()
                dtc = Nothing
                cn.Close()
                cn.Dispose()
                cn = Nothing
                Exit Sub
            End If

            Dim dt As New DataTable
            Try
                dafill("Select Nome From Clubes Where ListaSorteio = 'S' Order By 1", dt, cn)
                DataGridView2.DataSource = Nothing
                DataGridView2.DataSource = dt
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

            'Seleciona célula do time que acabou de ser incluído
            For Each row As DataGridViewRow In DataGridView2.Rows
                For Each cell As DataGridViewCell In row.Cells
                    If LCase(Trim(cell.Value)) = LCase(Trim(PesquisaC.Text)) Then
                        DataGridView2.CurrentCell = DataGridView2.Rows(cell.RowIndex).Cells(0)
                    End If
                Next
            Next

            dtc.Dispose()
            dtc = Nothing
            dt.Dispose()
            dt = Nothing
            cn.Close()
            cn.Dispose()
            cn = Nothing

            PesquisaC.Text = ""
        End If
    End Sub
    'DELETE CLUBE
    Private Sub DataGridView2_KeyDown(sender As Object, e As KeyEventArgs) Handles DataGridView2.KeyDown
        If e.KeyCode = Keys.Delete And DataGridView2.Rows.Count > 0 Then
            Dim Nome As String = DataGridView2.CurrentCell.Value.ToString()
            Dim Position As Integer = DataGridView2.CurrentCell.RowIndex
            Dim NumLinhas As Integer = DataGridView2.Rows.Count
            Dim cn As New SQLiteConnection(constr)

            If Position + 1 = NumLinhas Then
                Position = Position - 1
            End If

            Try
                cn.Open()
            Catch ex As Exception
                cn.Dispose()
                cn = Nothing
                MsgBox(ex.Message)
                Exit Sub
            End Try

            ExecuteNonQuery("Update Clubes SET ListaSorteio = 'N' where Nome = '" & Nome & "' COLLATE NOCASE", cn)

            Dim dt As New DataTable
            Try
                dafill("Select Nome From Clubes Where ListaSorteio = 'S' Order By 1", dt, cn)
                DataGridView2.DataSource = Nothing
                DataGridView2.DataSource = dt
                If NumLinhas > 1 Then
                    DataGridView2.CurrentCell = DataGridView2.Rows(Position).Cells(0)
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

            dt.Dispose()
            dt = Nothing
            cn.Close()
            cn.Dispose()
            cn = Nothing
        End If
    End Sub

    'BOTÃO RANKING
    Private Sub BtnRanking_Click(sender As Object, e As EventArgs) Handles BtnRanking.Click
        Estatisticas.Show()
    End Sub

    'RECUPERAR SORTEIO (F1)
    Private Sub RecupSorteio()
        If BtnRegistrar.Enabled = True Then
            Exit Sub
        End If

        Dim cn As New SQLiteConnection(constr)
        Try
            cn.Open()
        Catch ex As Exception
            cn.Dispose()
            cn = Nothing
            MsgBox(ex.Message)
            Exit Sub
        End Try

        Dim dt0 As New DataTable
        Try
            dafill("SELECT Count(PosPart_ultimo)
        FROM Clubes", dt0, cn)
            If dt0.Rows(0)(0) = 0 Then
                MsgBox("O último torneio já foi registrado", MsgBoxStyle.Information, "Atenção")
                GoTo Encerra
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Dim Result As MsgBoxResult
        Result = MsgBox("Deseja recuperar os dados do último sorteio realizado?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Recuperar sorteio")

        If Result = MsgBoxResult.No Then
            GoTo Encerra
        End If

        Dim dt As New DataTable
        Try
            dafill("Select j.Nome, c.Nome As 'Clube'
                From Jogadores j, Clubes c
                Where j.PosPart_ultimo = c.PosPart_ultimo
                Order By j.PosPart_ultimo", dt, cn)
            Dim Jogadores(dt0.Rows(0)(0) - 1) As String
            Dim Clubes(dt0.Rows(0)(0) - 1) As String
            For i As Integer = 1 To dt.Rows.Count
                Jogadores(i - 1) = dt.Rows(i - 1)(0)
                Clubes(i - 1) = dt.Rows(i - 1)(1)

                RefCxTxtJ(i).Text = dt.Rows(i - 1)(0)
                RefCxTxtC(i).Text = dt.Rows(i - 1)(1)
                Esc = AdequaNome(RefCxTxtC(i).Text)
                RefLogo(i).Image = My.Resources.ResourceManager.GetObject(Esc)

                If My.Resources.ResourceManager.GetObject(Esc) Is Nothing Then
                    RefLogo(i).Image = My.Resources.generic_logo
                Else
                    RefLogo(i).Image = My.Resources.ResourceManager.GetObject(Esc)
                End If
            Next
            AListaJ = Jogadores
            AListaC = Clubes
            BtnRegistrar.Enabled = True
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        dt.Dispose()
        dt = Nothing
Encerra:
        dt0.Dispose()
        dt0 = Nothing
        cn.Close()
        cn.Dispose()
        cn = Nothing
    End Sub

    Public Sub SalvaPosicao()
        Dim cn As New SQLiteConnection(constr)
        Try
            cn.Open()
        Catch ex As Exception
            cn.Dispose()
            cn = Nothing
            MsgBox(ex.Message)
            Exit Sub
        End Try

        ExecuteNonQuery("Update Jogadores SET PosPart_ultimo = NULL", cn)
        ExecuteNonQuery("Update Clubes SET PosPart_ultimo = NULL", cn)

        For i As Integer = 0 To AListaJ.GetUpperBound(0)
            ExecuteNonQuery("Update Jogadores SET Part_ultimo = 'S', PosPart_ultimo = " & i & " where Nome = '" & AListaJ(i) & "'", cn)
            ExecuteNonQuery("Update Clubes SET PosPart_ultimo = " & i & " where Nome = '" & AListaC(i) & "'", cn)
        Next

        cn.Close()
        cn.Dispose()
        cn = Nothing
    End Sub

    'ENTER & LEAVE - CAIXAS DE PESQUISA
    Private Sub PesquisaC_Enter(sender As Object, e As EventArgs) Handles PesquisaC.Enter
        PesquisaC.ForeColor = Color.FromArgb(0)
        PesquisaC.Text = ""
    End Sub
    Private Sub PesquisaC_Leave(sender As Object, e As EventArgs) Handles PesquisaC.Leave
        PesquisaC.ForeColor = Color.FromArgb(109, 109, 109)
        If Label2.Text = "Lista de Clubes" Then
            PesquisaC.Text = "Pesquisar Clubes"
        Else
            PesquisaC.Text = "Pesquisar Seleção"
        End If
    End Sub
    Private Sub AddJ_Enter(sender As Object, e As EventArgs) Handles AddJ.Enter
        AddJ.ForeColor = Color.FromArgb(0)
        AddJ.Text = ""
    End Sub
    Private Sub AddJ_Leave(sender As Object, e As EventArgs) Handles AddJ.Leave
        AddJ.ForeColor = Color.FromArgb(109, 109, 109)
        AddJ.Text = "Adicionar Jogadores"
    End Sub

    'LIMITE JOGADORES
    Public Sub ConfereLimite()
        If DataGridView1.Rows.Count = 8 Then
            AddJ.ForeColor = Color.FromArgb(109, 109, 109)
            AddJ.Enabled = False
            AddJ.Text = "Limite atingido (8)"
        Else
            AddJ.Enabled = True
        End If
    End Sub
    'ALTERNAR CLUBES E SELEÇÕES
    Private Sub Label2_DoubleClick(sender As Object, e As EventArgs) Handles Label2.DoubleClick
        If Label2.Text = "Lista de Clubes" Then
            Label2.Text = "Lista de Seleções"
        Else
            Label2.Text = "Lista de Clubes"
        End If
        Clube_autocomplete()
        PovClubes()
    End Sub

    'POVOA DGV JOGADORES
    Public Sub PovJogadores()
        Dim cn As New SQLiteConnection(constr)
        Try
            cn.Open()
        Catch ex As Exception
            cn.Dispose()
            cn = Nothing
            MsgBox(ex.Message)
            Exit Sub
        End Try

        Dim dt As New DataTable
        Try
            dafill("Select Nome From Jogadores Where Part_ultimo = 'S' Order By 1", dt, cn)
            DataGridView1.DataSource = Nothing
            DataGridView1.DataSource = dt
            ConfereLimite()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        dt.Dispose()
        dt = Nothing
        cn.Close()
        cn.Dispose()
        cn = Nothing
    End Sub
    'POVOA DGV CLUBES
    Public Sub PovClubes()
        Dim cn As New SQLiteConnection(constr)
        Try
            cn.Open()
        Catch ex As Exception
            cn.Dispose()
            cn = Nothing
            MsgBox(ex.Message)
            Exit Sub
        End Try

        Dim dtc As New DataTable
        Try
            ExecuteNonQuery("Update Clubes SET ListaSorteio = 'N'", cn)

            If Label2.Text = "Lista de Clubes" Then
                ExecuteNonQuery("Update Clubes SET ListaSorteio = 'S' where Principal = 'S'", cn)
                dafill("Select Nome From Clubes Where Principal = 'S' Order By 1", dtc, cn)
            Else
                ExecuteNonQuery("Update Clubes SET ListaSorteio = 'S' where Selecao = 'S'", cn)
                dafill("Select Nome From Clubes Where ListaSorteio = 'S' Order By 1", dtc, cn)
            End If

            DataGridView2.DataSource = Nothing
            DataGridView2.DataSource = dtc
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        dtc.Dispose()
        dtc = Nothing
        cn.Close()
        cn.Dispose()
        cn = Nothing
    End Sub

    'FORM1 LOAD
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Clube_autocomplete()
        Jogador_autocomplete()
        PovJogadores()
        PovClubes()
    End Sub
    'FORM1 CLOSING
    Private Sub Form1_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        If BtnRegistrar.Enabled = False Then
            Exit Sub
        End If

        Dim Result As DialogResult
        Result = MsgBox("Deseja registrar o torneio antes de fechar o programa?", MsgBoxStyle.YesNoCancel + MessageBoxIcon.Exclamation, "Registro")
        If Result = MsgBoxResult.Yes Then
            Hide()
            ResultTorneio.ShowDialog()
            ExitProgram = True
            e.Cancel = True
        ElseIf Result = MsgBoxResult.Cancel Then
            e.Cancel = True
        End If
    End Sub

    Private Sub ItemGBD_Click(sender As Object, e As EventArgs) Handles ItemGBD.Click
        BancoDeDados.Show()
    End Sub

    Private Sub ItemRecupSorteio_Click(sender As Object, e As EventArgs) Handles ItemRecupSorteio.Click
        RecupSorteio()
    End Sub
End Class