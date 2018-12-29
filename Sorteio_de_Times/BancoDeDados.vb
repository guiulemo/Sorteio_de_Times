Imports System.Data.SQLite

Public Class BancoDeDados
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

    Public Sub PovTorneios()
        Dim cn As New SQLiteConnection(constr)
        Try
            cn.Open()
        Catch ex As Exception
            cn.Dispose()
            cn = Nothing
            MsgBox(ex.Message)
            Exit Sub
        End Try

        Dim dtTorneio As New DataTable
        Try
            dafill("SELECT t.id as 'ID', t.Dt as 'Data', j.Nome as 'Campeão', j2.Nome as 'Vice', c.Nome as 'Time Campeão', c2.Nome as 'Time Vice'
                    FROM Torneios t
                    INNER JOIN jogadores j ON j.id = t.Campeao
                    INNER JOIN jogadores j2 ON j2.id = t.Vice
                    INNER JOIN clubes c ON c.id = t.TimeCampeao
                    INNER JOIN clubes c2 ON c2.id = t.TimeVice
                    ORDER BY 1", dtTorneio, cn)
            DgvTorneios.DataSource = Nothing
            DgvTorneios.DataSource = dtTorneio
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        DgvTorneios.Columns(0).Width = 60
        DgvTorneios.Columns(1).Width = 140
        DgvTorneios.Columns(2).Width = 150
        DgvTorneios.Columns(3).Width = 150
        DgvTorneios.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DgvTorneios.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

        dtTorneio.Dispose()
        dtTorneio = Nothing
        cn.Close()
        cn.Dispose()
        cn = Nothing

        BtnDelTor.Enabled = False
    End Sub
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

        Dim dtJogadores As New DataTable
        Try
            dafill("SELECT * FROM Jogadores", dtJogadores, cn)
            DgvJogadores.DataSource = Nothing
            DgvJogadores.DataSource = dtJogadores
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        DgvJogadores.Columns(0).Width = 60
        DgvJogadores.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft

        dtJogadores.Dispose()
        dtJogadores = Nothing
        cn.Close()
        cn.Dispose()
        cn = Nothing
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BtnDelTor.Click
        Dim Result As MsgBoxResult

        Result = MsgBox("Você tem certeza que deseja apagar toda a base de torneios?" & vbCrLf & "ESTA AÇÃO NÃO PODERÁ SER DEFEITA.", MsgBoxStyle.YesNo + MsgBoxStyle.Exclamation, "ATENÇÃO!")
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

        ExecuteNonQuery("DELETE FROM Torneios", cn)
        ExecuteNonQuery("Update Jogadores SET Pontos = 0, Participacoes = 0", cn)
        ExecuteNonQuery("Update sqlite_sequence SET seq = 0 Where name = 'Torneios'", cn)

        cn.Close()
        cn.Dispose()
        cn = Nothing

        PovTorneios()
    End Sub

    Private Sub BancoDeDados_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.Control And e.KeyCode = Keys.U Then
            If TabBD.SelectedTab Is TabPage1 Then
                If DgvTorneios.Rows.Count > 0 Then
                    BtnDelTor.Enabled = True
                End If
            End If
        End If

        If e.KeyCode = Keys.Delete Then
            If TabBD.SelectedTab Is TabPage2 Then

                Dim id As String = DgvJogadores.SelectedCells.Item(0).Value

                Dim cn As New SQLiteConnection(constr)
                Try
                    cn.Open()
                Catch ex As Exception
                    cn.Dispose()
                    cn = Nothing
                    MsgBox(ex.Message)
                    Exit Sub
                End Try

                ExecuteNonQuery("DELETE FROM Jogadores WHERE id = " & id, cn)

                cn.Close()
                cn.Dispose()
                cn = Nothing

                PovJogadores()
            End If
        End If
    End Sub

    Private Sub TabBD_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TabBD.SelectedIndexChanged
        If TabBD.SelectedTab Is TabPage2 Then
            PovJogadores()
        End If
    End Sub

    Private Sub BancoDeDados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PovTorneios()
    End Sub
End Class