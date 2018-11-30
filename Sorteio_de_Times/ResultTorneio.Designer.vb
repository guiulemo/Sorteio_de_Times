<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ResultTorneio
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle77 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle78 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle79 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle80 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.DgvCamp = New System.Windows.Forms.DataGridView()
        Me.Nome = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PnlCamp = New System.Windows.Forms.Panel()
        Me.PnlEscCamp = New System.Windows.Forms.Panel()
        Me.EscudoC = New System.Windows.Forms.PictureBox()
        Me.LblCamp = New System.Windows.Forms.Label()
        Me.PnlBotoes = New System.Windows.Forms.Panel()
        Me.BtnCancel = New System.Windows.Forms.Button()
        Me.BtnSalvar = New System.Windows.Forms.Button()
        Me.PnlVice = New System.Windows.Forms.Panel()
        Me.PnlEscVice = New System.Windows.Forms.Panel()
        Me.EscudoV = New System.Windows.Forms.PictureBox()
        Me.LblVice = New System.Windows.Forms.Label()
        Me.DgvVice = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DgvCamp, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PnlCamp.SuspendLayout()
        Me.PnlEscCamp.SuspendLayout()
        CType(Me.EscudoC, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PnlBotoes.SuspendLayout()
        Me.PnlVice.SuspendLayout()
        Me.PnlEscVice.SuspendLayout()
        CType(Me.EscudoV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DgvVice, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DgvCamp
        '
        Me.DgvCamp.AllowUserToAddRows = False
        Me.DgvCamp.AllowUserToDeleteRows = False
        Me.DgvCamp.AllowUserToResizeColumns = False
        Me.DgvCamp.AllowUserToResizeRows = False
        DataGridViewCellStyle77.BackColor = System.Drawing.Color.Gainsboro
        Me.DgvCamp.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle77
        Me.DgvCamp.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.DgvCamp.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgvCamp.BackgroundColor = System.Drawing.Color.LightGray
        Me.DgvCamp.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DgvCamp.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable
        Me.DgvCamp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DgvCamp.ColumnHeadersVisible = False
        Me.DgvCamp.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Nome})
        DataGridViewCellStyle78.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle78.BackColor = System.Drawing.Color.LightGray
        DataGridViewCellStyle78.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle78.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle78.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle78.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle78.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DgvCamp.DefaultCellStyle = DataGridViewCellStyle78
        Me.DgvCamp.GridColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(222, Byte), Integer))
        Me.DgvCamp.Location = New System.Drawing.Point(0, 0)
        Me.DgvCamp.MultiSelect = False
        Me.DgvCamp.Name = "DgvCamp"
        Me.DgvCamp.ReadOnly = True
        Me.DgvCamp.RowHeadersVisible = False
        Me.DgvCamp.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.DgvCamp.RowTemplate.Height = 31
        Me.DgvCamp.RowTemplate.ReadOnly = True
        Me.DgvCamp.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvCamp.ShowCellToolTips = False
        Me.DgvCamp.Size = New System.Drawing.Size(226, 250)
        Me.DgvCamp.TabIndex = 1
        '
        'Nome
        '
        Me.Nome.HeaderText = "Nome"
        Me.Nome.Name = "Nome"
        Me.Nome.ReadOnly = True
        '
        'PnlCamp
        '
        Me.PnlCamp.Controls.Add(Me.PnlEscCamp)
        Me.PnlCamp.Controls.Add(Me.DgvCamp)
        Me.PnlCamp.Location = New System.Drawing.Point(18, 75)
        Me.PnlCamp.Name = "PnlCamp"
        Me.PnlCamp.Size = New System.Drawing.Size(480, 250)
        Me.PnlCamp.TabIndex = 2
        '
        'PnlEscCamp
        '
        Me.PnlEscCamp.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.PnlEscCamp.BackColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(222, Byte), Integer))
        Me.PnlEscCamp.Controls.Add(Me.EscudoC)
        Me.PnlEscCamp.Location = New System.Drawing.Point(225, 0)
        Me.PnlEscCamp.Name = "PnlEscCamp"
        Me.PnlEscCamp.Size = New System.Drawing.Size(255, 250)
        Me.PnlEscCamp.TabIndex = 4
        '
        'EscudoC
        '
        Me.EscudoC.BackColor = System.Drawing.Color.Transparent
        Me.EscudoC.Image = Global.Sorteio_de_Times.My.Resources.Resources.generic_logo
        Me.EscudoC.Location = New System.Drawing.Point(27, 23)
        Me.EscudoC.Name = "EscudoC"
        Me.EscudoC.Size = New System.Drawing.Size(200, 200)
        Me.EscudoC.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.EscudoC.TabIndex = 2
        Me.EscudoC.TabStop = False
        '
        'LblCamp
        '
        Me.LblCamp.BackColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.LblCamp.Font = New System.Drawing.Font("Verdana", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCamp.ForeColor = System.Drawing.Color.White
        Me.LblCamp.Location = New System.Drawing.Point(18, 18)
        Me.LblCamp.Name = "LblCamp"
        Me.LblCamp.Size = New System.Drawing.Size(480, 47)
        Me.LblCamp.TabIndex = 3
        Me.LblCamp.Text = "Campeão"
        '
        'PnlBotoes
        '
        Me.PnlBotoes.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.PnlBotoes.Controls.Add(Me.BtnCancel)
        Me.PnlBotoes.Controls.Add(Me.BtnSalvar)
        Me.PnlBotoes.Location = New System.Drawing.Point(18, 341)
        Me.PnlBotoes.Name = "PnlBotoes"
        Me.PnlBotoes.Size = New System.Drawing.Size(981, 66)
        Me.PnlBotoes.TabIndex = 4
        '
        'BtnCancel
        '
        Me.BtnCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.BtnCancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.BtnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BtnCancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.BtnCancel.FlatAppearance.BorderSize = 0
        Me.BtnCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.BtnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray
        Me.BtnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCancel.ForeColor = System.Drawing.Color.White
        Me.BtnCancel.Location = New System.Drawing.Point(842, 14)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(124, 39)
        Me.BtnCancel.TabIndex = 6
        Me.BtnCancel.Text = "Cancelar"
        Me.BtnCancel.UseVisualStyleBackColor = False
        '
        'BtnSalvar
        '
        Me.BtnSalvar.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.BtnSalvar.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.BtnSalvar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.BtnSalvar.FlatAppearance.BorderSize = 0
        Me.BtnSalvar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.BtnSalvar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray
        Me.BtnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSalvar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSalvar.ForeColor = System.Drawing.Color.White
        Me.BtnSalvar.Location = New System.Drawing.Point(707, 14)
        Me.BtnSalvar.Name = "BtnSalvar"
        Me.BtnSalvar.Size = New System.Drawing.Size(124, 39)
        Me.BtnSalvar.TabIndex = 5
        Me.BtnSalvar.Text = "Salvar"
        Me.BtnSalvar.UseVisualStyleBackColor = False
        '
        'PnlVice
        '
        Me.PnlVice.Controls.Add(Me.PnlEscVice)
        Me.PnlVice.Controls.Add(Me.DgvVice)
        Me.PnlVice.Location = New System.Drawing.Point(519, 75)
        Me.PnlVice.Name = "PnlVice"
        Me.PnlVice.Size = New System.Drawing.Size(480, 250)
        Me.PnlVice.TabIndex = 5
        '
        'PnlEscVice
        '
        Me.PnlEscVice.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.PnlEscVice.BackColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(222, Byte), Integer))
        Me.PnlEscVice.Controls.Add(Me.EscudoV)
        Me.PnlEscVice.Location = New System.Drawing.Point(225, 0)
        Me.PnlEscVice.Name = "PnlEscVice"
        Me.PnlEscVice.Size = New System.Drawing.Size(255, 250)
        Me.PnlEscVice.TabIndex = 4
        '
        'EscudoV
        '
        Me.EscudoV.BackColor = System.Drawing.Color.Transparent
        Me.EscudoV.Image = Global.Sorteio_de_Times.My.Resources.Resources.generic_logo
        Me.EscudoV.Location = New System.Drawing.Point(27, 23)
        Me.EscudoV.Name = "EscudoV"
        Me.EscudoV.Size = New System.Drawing.Size(200, 200)
        Me.EscudoV.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.EscudoV.TabIndex = 2
        Me.EscudoV.TabStop = False
        '
        'LblVice
        '
        Me.LblVice.BackColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.LblVice.Font = New System.Drawing.Font("Verdana", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblVice.ForeColor = System.Drawing.Color.White
        Me.LblVice.Location = New System.Drawing.Point(519, 18)
        Me.LblVice.Name = "LblVice"
        Me.LblVice.Size = New System.Drawing.Size(480, 47)
        Me.LblVice.TabIndex = 3
        Me.LblVice.Text = "Vice"
        '
        'DgvVice
        '
        Me.DgvVice.AllowUserToAddRows = False
        Me.DgvVice.AllowUserToDeleteRows = False
        Me.DgvVice.AllowUserToResizeColumns = False
        Me.DgvVice.AllowUserToResizeRows = False
        DataGridViewCellStyle79.BackColor = System.Drawing.Color.Gainsboro
        Me.DgvVice.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle79
        Me.DgvVice.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.DgvVice.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgvVice.BackgroundColor = System.Drawing.Color.LightGray
        Me.DgvVice.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DgvVice.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable
        Me.DgvVice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DgvVice.ColumnHeadersVisible = False
        Me.DgvVice.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1})
        DataGridViewCellStyle80.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle80.BackColor = System.Drawing.Color.LightGray
        DataGridViewCellStyle80.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle80.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle80.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle80.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle80.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DgvVice.DefaultCellStyle = DataGridViewCellStyle80
        Me.DgvVice.GridColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(222, Byte), Integer))
        Me.DgvVice.Location = New System.Drawing.Point(0, 0)
        Me.DgvVice.MultiSelect = False
        Me.DgvVice.Name = "DgvVice"
        Me.DgvVice.ReadOnly = True
        Me.DgvVice.RowHeadersVisible = False
        Me.DgvVice.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.DgvVice.RowTemplate.Height = 31
        Me.DgvVice.RowTemplate.ReadOnly = True
        Me.DgvVice.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvVice.ShowCellToolTips = False
        Me.DgvVice.Size = New System.Drawing.Size(226, 250)
        Me.DgvVice.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "Nome"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'ResultTorneio
        '
        Me.AcceptButton = Me.BtnSalvar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(145, Byte), Integer), CType(CType(145, Byte), Integer), CType(CType(145, Byte), Integer))
        Me.BackgroundImage = Global.Sorteio_de_Times.My.Resources.Resources.Background
        Me.CancelButton = Me.BtnCancel
        Me.ClientSize = New System.Drawing.Size(1017, 426)
        Me.ControlBox = False
        Me.Controls.Add(Me.LblCamp)
        Me.Controls.Add(Me.LblVice)
        Me.Controls.Add(Me.PnlVice)
        Me.Controls.Add(Me.PnlCamp)
        Me.Controls.Add(Me.PnlBotoes)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Name = "ResultTorneio"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Resultado do Torneio"
        CType(Me.DgvCamp, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PnlCamp.ResumeLayout(False)
        Me.PnlEscCamp.ResumeLayout(False)
        CType(Me.EscudoC, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PnlBotoes.ResumeLayout(False)
        Me.PnlVice.ResumeLayout(False)
        Me.PnlEscVice.ResumeLayout(False)
        CType(Me.EscudoV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DgvVice, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DgvCamp As DataGridView
    Friend WithEvents PnlCamp As Panel
    Friend WithEvents LblCamp As Label
    Friend WithEvents EscudoC As PictureBox
    Friend WithEvents Nome As DataGridViewTextBoxColumn
    Friend WithEvents PnlEscCamp As Panel
    Friend WithEvents PnlBotoes As Panel
    Friend WithEvents BtnSalvar As Button
    Friend WithEvents BtnCancel As Button
    Friend WithEvents PnlVice As Panel
    Friend WithEvents PnlEscVice As Panel
    Friend WithEvents EscudoV As PictureBox
    Friend WithEvents LblVice As Label
    Friend WithEvents DgvVice As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
End Class
