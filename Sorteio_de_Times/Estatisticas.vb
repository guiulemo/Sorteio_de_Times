Imports System.Data.SQLite

Public Class Estatisticas
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

    Private Sub Estatisticas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim cn As New SQLiteConnection(constr)
        Dim Esc As Object

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
            ExecuteNonQuery("CREATE TEMP TABLE tmp_ranking AS SELECT NOME As J, sum(PO) As PO, sum(CAMP) As C, sum(VICE) As V, sum(PART) As P
                    FROM
                    (
                    SELECT j.Nome As 'NOME', j.Pontos As 'PO', Count(t.Campeao) As 'CAMP', 0 As 'VICE', j.Participacoes As 'PART'
                    FROM Jogadores j
                    LEFT JOIN Torneios t ON j.id = t.Campeao
                    GROUP BY 1
                    UNION all
                    SELECT j.Nome As 'NOME', 0 As 'PO', 0 As 'CAMP', count(t.Vice) As 'VICE', 0 As 'PART'
                    FROM Jogadores j
                    LEFT JOIN Torneios t ON j.id = t.Vice
                    GROUP BY 1
                    )
                    GROUP BY 1
                    ORDER BY 2 DESC, 3 DESC, 4 DESC, 5 ASC", cn)

            dafill("SELECT rowid As '#', J As 'Jogador', PO As 'Pontos', C As 'Campeão', V As 'Vice', P As 'Presença' FROM tmp_ranking", dt, cn)
            DataGridView1.DataSource = Nothing
            DataGridView1.DataSource = dt
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        If DataGridView1.Item(3, 0).Value <> 0 Then
            Dim dtc As New DataTable
            Try
                dafill("SELECT j.Nome, c.Nome As 'NOME'
                    FROM Torneios t
                    INNER JOIN Jogadores j ON j.id = t.Campeao
                    INNER JOIN Clubes c ON c.id = t.TimeCampeao
                    ORDER BY t.id DESC
                    LIMIT 1", dtc, cn)
                LblJogador.Text = UCase(dtc.Rows(0)(0))
                LblTime.Text = UCase(dtc.Rows(0)(1))

                Esc = AdequaNome(LblTime.Text)
                If My.Resources.ResourceManager.GetObject(Esc) Is Nothing Then
                    Escudo.Image = My.Resources.generic_logo
                Else
                    Escudo.Image = My.Resources.ResourceManager.GetObject(Esc)
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            dtc.Dispose()
            dtc = Nothing
        Else
            Escudo.Image = My.Resources.generic_logo
        End If

        DataGridView1.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridView1.Columns(2).DefaultCellStyle.BackColor = Color.LightGray
        DataGridView1.Columns(2).DefaultCellStyle.SelectionBackColor = Color.FromArgb(75, 233, 237)

        DataGridView1.Columns(0).Width = 45
        For i As Integer = 2 To 5
            DataGridView1.Columns(i).Width = 90
        Next

        For Each col In DataGridView1.Columns
            col.SortMode = DataGridViewColumnSortMode.NotSortable
        Next

        dt.Dispose()
        dt = Nothing
        cn.Close()
        cn.Dispose()
        cn = Nothing
    End Sub
End Class