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
            dafill("SELECT NOME, sum(CAMP) As 'CAMPEÃO (Qtde)', sum(VICE) As 'VICE (Qtde)'
                    FROM
                    (
                    SELECT j.Nome As 'NOME', Count(t.Campeao) As 'CAMP', 0 As 'VICE'
                    FROM Jogadores j
                    LEFT JOIN Torneios t ON j.id = t.Campeao
                    GROUP BY 1
                    UNION all
                    SELECT j.Nome As 'NOME', 0 As 'CAMP', count(t.Vice) As 'VICE'
                    FROM Jogadores j
                    LEFT JOIN Torneios t ON j.id = t.Vice
                    GROUP BY 1
                    )
                    GROUP BY 1
                    ORDER BY 2 DESC, 3 DESC, 1", dt, cn)
            DataGridView1.DataSource = Nothing
            DataGridView1.DataSource = dt
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Dim dtc As New DataTable
        Try
            dafill("SELECT j.Nome As 'NOME'
                    FROM Torneios t
                    INNER JOIN Jogadores j ON j.id = t.Campeao
                    ORDER BY t.id DESC
                    LIMIT 1", dtc, cn)
            Label1.Text = dtc.Rows(0)(0)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        dtc.Dispose()
        dtc = Nothing
        dt.Dispose()
        dt = Nothing
        cn.Close()
        cn.Dispose()
        cn = Nothing
    End Sub
End Class