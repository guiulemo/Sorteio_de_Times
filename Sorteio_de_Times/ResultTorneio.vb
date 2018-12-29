Imports System.ComponentModel
Imports System.Data.SQLite

Public Class ResultTorneio
    Public NomeTimeC As String
    Public NomeTimeV As String

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

    Private Sub ResultTorneio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DgvCamp.Rows.Clear()
        DgvVice.Rows.Clear()

        For i As Integer = 0 To AListaJ.GetUpperBound(0)
            Dim x As String() = {AListaJ(i)}
            DgvCamp.Rows.Add(x)
            DgvVice.Rows.Add(x)
        Next
        DgvCamp.Sort(DgvCamp.Columns(0), System.ComponentModel.ListSortDirection.Ascending)
        DgvCamp.CurrentCell = DgvCamp.Rows(0).Cells(0)

        DgvVice.Sort(DgvVice.Columns(0), System.ComponentModel.ListSortDirection.Ascending)
        DgvVice.CurrentCell = DgvVice.Rows(0).Cells(0)

        DgvCamp_SelectionChanged(sender, e)
        DgvVice_SelectionChanged(sender, e)
    End Sub
    Private Sub DgvCamp_SelectionChanged(sender As Object, e As EventArgs) Handles DgvCamp.SelectionChanged
        Dim Esc As Object
        Dim Jog As String

        If DgvCamp.CurrentCell Is Nothing Then
            Exit Sub
        Else
            Jog = DgvCamp.CurrentCell.Value
        End If

        For i As Integer = 0 To AListaJ.GetUpperBound(0)
            If AListaJ(i) = Jog Then
                Esc = AdequaNome(AListaC(i))
                NomeTimeC = AListaC(i)
                If My.Resources.ResourceManager.GetObject(Esc) Is Nothing Then
                    EscudoC.Image = My.Resources.generic_logo
                Else
                    EscudoC.Image = My.Resources.ResourceManager.GetObject(Esc)
                End If
                Exit Sub
            End If
        Next
    End Sub
    Private Sub DgvVice_SelectionChanged(sender As Object, e As EventArgs) Handles DgvVice.SelectionChanged
        Dim Esc As Object
        Dim Jog As String

        If DgvVice.CurrentCell Is Nothing Then
            Exit Sub
        Else
            Jog = DgvVice.CurrentCell.Value
        End If

        For i As Integer = 0 To AListaJ.GetUpperBound(0)
            If AListaJ(i) = Jog Then
                Esc = AdequaNome(AListaC(i))
                NomeTimeV = AListaC(i)
                If My.Resources.ResourceManager.GetObject(Esc) Is Nothing Then
                    EscudoV.Image = My.Resources.generic_logo
                Else
                    EscudoV.Image = My.Resources.ResourceManager.GetObject(Esc)
                End If
                Exit Sub
            End If
        Next
    End Sub

    Private Sub BtnSalvar_Click(sender As Object, e As EventArgs) Handles BtnSalvar.Click
        Dim Campeao As String = DgvCamp.CurrentCell.Value
        Dim Vice As String = DgvVice.CurrentCell.Value
        Dim idJC As Integer
        Dim idCC As Integer
        Dim idJV As Integer
        Dim idCV As Integer
        Dim Dt As String = DateTime.Now.ToString("dd/MM/yyyy")
        Dim Result As MsgBoxResult

        If Campeao = Vice Then
            MsgBox("Jogador campeão não pode ser igual ao vice!", MessageBoxIcon.Exclamation, "Atenção")
            Exit Sub
        End If

        Result = MsgBox("Campeão: " & UCase(Campeao) & vbCrLf & "Vice: " & UCase(Vice) & vbCrLf & vbCrLf & "Confirmar?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirmação")
        If Result = MsgBoxResult.No Then
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

        Dim tblC As New DataTable
        Try
            dafill("SELECT J
                    FROM
                    (
                    Select j.id As J
                    From Jogadores j
                    Where j.Nome ='" & Campeao & "'
                    UNION all
                    Select c.id As J
                    From Clubes c
                    Where c.Nome ='" & NomeTimeC & "')", tblC, cn)
            idJC = tblC.Rows(0)(0)
            idCC = tblC.Rows(1)(0)

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Dim tblV As New DataTable
        Try
            dafill("SELECT J
                    FROM
                    (
                    Select j.id As J
                    From Jogadores j
                    Where j.Nome ='" & Vice & "'
                    UNION all
                    Select c.id As J
                    From Clubes c
                    Where c.Nome ='" & NomeTimeV & "')", tblV, cn)
            idJV = tblV.Rows(0)(0)
            idCV = tblV.Rows(1)(0)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        ExecuteNonQuery("INSERT INTO Torneios (Dt, Campeao, Vice, TimeCampeao, TimeVice) values ('" & Dt & "'," & idJC & "," & idJV & "," & idCC & "," & idCV & ")", cn)
        ExecuteNonQuery("Update Jogadores SET Pontos = Pontos + 3 WHERE id = " & idJC & "", cn)
        ExecuteNonQuery("Update Jogadores SET Pontos = Pontos + 1 WHERE id = " & idJV & "", cn)
        ExecuteNonQuery("Update Jogadores SET Part_ultimo = 'N'", cn)

        For i As Integer = 0 To AListaJ.GetUpperBound(0)
            ExecuteNonQuery("Update Jogadores SET Part_ultimo = 'S', Participacoes = Participacoes + 1 WHERE Nome = '" & AListaJ(i) & "'", cn)
            ExecuteNonQuery("Update Jogadores SET Pontos = Pontos + 1 WHERE Nome = '" & AListaJ(i) & "'", cn)
        Next

        ExecuteNonQuery("Update Jogadores SET PosPart_ultimo = NULL", cn)
        ExecuteNonQuery("Update Clubes SET PosPart_ultimo = NULL", cn)

        tblC.Dispose()
        tblC = Nothing
        tblV.Dispose()
        tblV = Nothing
        cn.Close()
        cn.Dispose()
        cn = Nothing

        Form1.LimparCampos()
        Form1.BtnRegistrar.Enabled = False

        Close()
        My.Computer.Audio.Play(My.Resources.GameStartv2, AudioPlayMode.Background)
        Estatisticas.Show()
    End Sub

    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        Close()
        Form1.Show()
    End Sub

    Private Sub ResultTorneio_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.Alt And e.KeyCode = Keys.F4 Then
            e.Handled = True
        End If
    End Sub
End Class