<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BancoDeDados
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TabBD = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.DgvTorneios = New System.Windows.Forms.DataGridView()
        Me.BtnDelTor = New System.Windows.Forms.Button()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.DgvJogadores = New System.Windows.Forms.DataGridView()
        Me.BtnDelJog = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.TabBD.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.DgvTorneios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.DgvJogadores, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.TabBD)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(951, 461)
        Me.Panel1.TabIndex = 1
        '
        'TabBD
        '
        Me.TabBD.Controls.Add(Me.TabPage1)
        Me.TabBD.Controls.Add(Me.TabPage2)
        Me.TabBD.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabBD.Location = New System.Drawing.Point(0, 0)
        Me.TabBD.Name = "TabBD"
        Me.TabBD.SelectedIndex = 0
        Me.TabBD.Size = New System.Drawing.Size(951, 461)
        Me.TabBD.TabIndex = 2
        '
        'TabPage1
        '
        Me.TabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.TabPage1.Controls.Add(Me.DgvTorneios)
        Me.TabPage1.Controls.Add(Me.BtnDelTor)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(943, 435)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Torneios"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'DgvTorneios
        '
        Me.DgvTorneios.AllowUserToAddRows = False
        Me.DgvTorneios.AllowUserToDeleteRows = False
        Me.DgvTorneios.AllowUserToOrderColumns = True
        Me.DgvTorneios.AllowUserToResizeColumns = False
        Me.DgvTorneios.AllowUserToResizeRows = False
        Me.DgvTorneios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgvTorneios.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgvTorneios.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DgvTorneios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DgvTorneios.DefaultCellStyle = DataGridViewCellStyle2
        Me.DgvTorneios.Dock = System.Windows.Forms.DockStyle.Top
        Me.DgvTorneios.EnableHeadersVisualStyles = False
        Me.DgvTorneios.Location = New System.Drawing.Point(3, 3)
        Me.DgvTorneios.MultiSelect = False
        Me.DgvTorneios.Name = "DgvTorneios"
        Me.DgvTorneios.ReadOnly = True
        Me.DgvTorneios.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.DgvTorneios.RowHeadersVisible = False
        Me.DgvTorneios.RowTemplate.ReadOnly = True
        Me.DgvTorneios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvTorneios.Size = New System.Drawing.Size(937, 372)
        Me.DgvTorneios.TabIndex = 2
        '
        'BtnDelTor
        '
        Me.BtnDelTor.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnDelTor.Enabled = False
        Me.BtnDelTor.Font = New System.Drawing.Font("Segoe UI Semibold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnDelTor.Location = New System.Drawing.Point(3, 381)
        Me.BtnDelTor.Name = "BtnDelTor"
        Me.BtnDelTor.Size = New System.Drawing.Size(937, 48)
        Me.BtnDelTor.TabIndex = 0
        Me.BtnDelTor.Text = "APAGAR TODOS OS REGISTROS"
        Me.BtnDelTor.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.DgvJogadores)
        Me.TabPage2.Controls.Add(Me.BtnDelJog)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(943, 435)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Jogadores"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'DgvJogadores
        '
        Me.DgvJogadores.AllowUserToAddRows = False
        Me.DgvJogadores.AllowUserToDeleteRows = False
        Me.DgvJogadores.AllowUserToOrderColumns = True
        Me.DgvJogadores.AllowUserToResizeColumns = False
        Me.DgvJogadores.AllowUserToResizeRows = False
        Me.DgvJogadores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgvJogadores.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgvJogadores.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DgvJogadores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DgvJogadores.DefaultCellStyle = DataGridViewCellStyle4
        Me.DgvJogadores.Dock = System.Windows.Forms.DockStyle.Top
        Me.DgvJogadores.EnableHeadersVisualStyles = False
        Me.DgvJogadores.Location = New System.Drawing.Point(3, 3)
        Me.DgvJogadores.MultiSelect = False
        Me.DgvJogadores.Name = "DgvJogadores"
        Me.DgvJogadores.ReadOnly = True
        Me.DgvJogadores.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.DgvJogadores.RowHeadersVisible = False
        Me.DgvJogadores.RowTemplate.ReadOnly = True
        Me.DgvJogadores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvJogadores.Size = New System.Drawing.Size(937, 372)
        Me.DgvJogadores.TabIndex = 3
        '
        'BtnDelJog
        '
        Me.BtnDelJog.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnDelJog.Enabled = False
        Me.BtnDelJog.Font = New System.Drawing.Font("Segoe UI Semibold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnDelJog.Location = New System.Drawing.Point(3, 381)
        Me.BtnDelJog.Name = "BtnDelJog"
        Me.BtnDelJog.Size = New System.Drawing.Size(937, 48)
        Me.BtnDelJog.TabIndex = 2
        Me.BtnDelJog.Text = "APAGAR TODOS OS REGISTROS"
        Me.BtnDelJog.UseVisualStyleBackColor = True
        '
        'BancoDeDados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(951, 461)
        Me.Controls.Add(Me.Panel1)
        Me.KeyPreview = True
        Me.Name = "BancoDeDados"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Gerenciar Banco de Dados"
        Me.Panel1.ResumeLayout(False)
        Me.TabBD.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.DgvTorneios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        CType(Me.DgvJogadores, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents BtnDelTor As Button
    Friend WithEvents TabBD As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents BtnDelJog As Button
    Friend WithEvents DgvTorneios As DataGridView
    Friend WithEvents DgvJogadores As DataGridView
End Class
