Imports System.Data.SQLite
Public Class Form3
    Dim constr As String = "Data Source=SorteioPES.db"
    Private Sub Form3_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
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
            dafill("Select Nome From Clubes Where Principal = 'S'", dt, cn)
            DataGridView1.DataSource = Nothing
            DataGridView1.DataSource = dt
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        dt.Dispose()
        dt = Nothing
        cn.Close()
        cn.Dispose()
        cn = Nothing

    End Sub

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

    Private Sub BtnAddJogador_Click(sender As Object, e As EventArgs) Handles BtnAddJogador.Click
        Dim cn As New SQLiteConnection(constr)
        Try
            cn.Open()
        Catch ex As Exception
            cn.Dispose()
            cn = Nothing
            MsgBox(ex.Message)
            Exit Sub
        End Try

        ExecuteNonQuery("Insert INTO Jogadores (Nome) values('" & TextBox1.Text & "')", cn)

        Dim tbl As New DataTable
        Try
            dafill("Select Nome From Jogadores", tbl, cn)
            DataGridView1.DataSource = Nothing
            DataGridView1.DataSource = tbl

            MsgBox("Insert successfully")
        Catch ex As Exception
            MsgBox("Refresh data error : " & ex.Message)
        End Try
        tbl.Dispose()
        tbl = Nothing

        cn.Close()
        cn.Dispose()
        cn = Nothing
    End Sub

    Private Sub BtnCopia_Click(sender As Object, e As EventArgs) Handles BtnCopia.Click
        'Dim ListadeJog As String() = DataGridView1.SelectedCells(0).Value
        'DataGridView2.Rows.Add("Testeeeeee")
        'RichTextBox1.Text = ListadeJog(0)

        Estatisticas.Show()

    End Sub

    Private Sub BtnTransString_Click(sender As Object, e As EventArgs) Handles BtnTransString.Click
        Dim Position As Integer = DataGridView1.CurrentCell.RowIndex

        '        DataGridView1.CurrentRow.Selected = False
        'DataGridView1.CurrentCell.Selected = False
        'DataGridView1.Rows(Position + 1).Selected = True

        'DataGridView1.CurrentCell = DataGridView1.Rows(Position + 2).Cells(0)

    End Sub
End Class