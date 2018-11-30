<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Estatisticas
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
        Me.PnlE = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.LblClassif = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.LblAtualCamp = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Bloco = New System.Windows.Forms.Panel()
        Me.PnlJogador = New System.Windows.Forms.Panel()
        Me.JColor = New System.Windows.Forms.Panel()
        Me.LblJogador = New System.Windows.Forms.Label()
        Me.PnlTime = New System.Windows.Forms.Panel()
        Me.LblTime = New System.Windows.Forms.Label()
        Me.Escudo = New System.Windows.Forms.PictureBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.PnlE.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Bloco.SuspendLayout()
        Me.PnlJogador.SuspendLayout()
        Me.PnlTime.SuspendLayout()
        CType(Me.Escudo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PnlE
        '
        Me.PnlE.BackColor = System.Drawing.Color.Transparent
        Me.PnlE.Controls.Add(Me.Panel2)
        Me.PnlE.Controls.Add(Me.Panel1)
        Me.PnlE.Controls.Add(Me.DataGridView1)
        Me.PnlE.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PnlE.Location = New System.Drawing.Point(0, 0)
        Me.PnlE.Name = "PnlE"
        Me.PnlE.Size = New System.Drawing.Size(1036, 480)
        Me.PnlE.TabIndex = 35
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Controls.Add(Me.Panel4)
        Me.Panel2.Location = New System.Drawing.Point(12, 11)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1013, 65)
        Me.Panel2.TabIndex = 36
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Panel3.Controls.Add(Me.LblClassif)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(622, 65)
        Me.Panel3.TabIndex = 4
        '
        'LblClassif
        '
        Me.LblClassif.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblClassif.BackColor = System.Drawing.Color.Transparent
        Me.LblClassif.Font = New System.Drawing.Font("Verdana", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblClassif.ForeColor = System.Drawing.Color.White
        Me.LblClassif.Location = New System.Drawing.Point(12, 12)
        Me.LblClassif.Name = "LblClassif"
        Me.LblClassif.Size = New System.Drawing.Size(319, 40)
        Me.LblClassif.TabIndex = 4
        Me.LblClassif.Text = "CLASSIFICAÇÃO"
        Me.LblClassif.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Panel4.Controls.Add(Me.LblAtualCamp)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel4.Location = New System.Drawing.Point(634, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(379, 65)
        Me.Panel4.TabIndex = 5
        '
        'LblAtualCamp
        '
        Me.LblAtualCamp.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblAtualCamp.BackColor = System.Drawing.Color.Transparent
        Me.LblAtualCamp.Font = New System.Drawing.Font("Verdana", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblAtualCamp.ForeColor = System.Drawing.Color.White
        Me.LblAtualCamp.Location = New System.Drawing.Point(25, 12)
        Me.LblAtualCamp.Name = "LblAtualCamp"
        Me.LblAtualCamp.Size = New System.Drawing.Size(328, 40)
        Me.LblAtualCamp.TabIndex = 3
        Me.LblAtualCamp.Text = "ATUAL CAMPEÃO"
        Me.LblAtualCamp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Panel1.Controls.Add(Me.Bloco)
        Me.Panel1.Location = New System.Drawing.Point(646, 85)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(379, 384)
        Me.Panel1.TabIndex = 35
        '
        'Bloco
        '
        Me.Bloco.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Bloco.Controls.Add(Me.PnlJogador)
        Me.Bloco.Controls.Add(Me.PnlTime)
        Me.Bloco.Controls.Add(Me.Escudo)
        Me.Bloco.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Bloco.Location = New System.Drawing.Point(0, 0)
        Me.Bloco.Name = "Bloco"
        Me.Bloco.Size = New System.Drawing.Size(379, 384)
        Me.Bloco.TabIndex = 34
        '
        'PnlJogador
        '
        Me.PnlJogador.BackColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(222, Byte), Integer))
        Me.PnlJogador.Controls.Add(Me.JColor)
        Me.PnlJogador.Controls.Add(Me.LblJogador)
        Me.PnlJogador.Dock = System.Windows.Forms.DockStyle.Top
        Me.PnlJogador.Location = New System.Drawing.Point(0, 0)
        Me.PnlJogador.Name = "PnlJogador"
        Me.PnlJogador.Size = New System.Drawing.Size(379, 55)
        Me.PnlJogador.TabIndex = 6
        '
        'JColor
        '
        Me.JColor.BackColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.JColor.Location = New System.Drawing.Point(8, 5)
        Me.JColor.Name = "JColor"
        Me.JColor.Size = New System.Drawing.Size(10, 45)
        Me.JColor.TabIndex = 34
        '
        'LblJogador
        '
        Me.LblJogador.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.LblJogador.AutoSize = True
        Me.LblJogador.BackColor = System.Drawing.Color.Transparent
        Me.LblJogador.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LblJogador.Font = New System.Drawing.Font("Unispace", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblJogador.ForeColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.LblJogador.Location = New System.Drawing.Point(24, 13)
        Me.LblJogador.Name = "LblJogador"
        Me.LblJogador.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.LblJogador.Size = New System.Drawing.Size(0, 33)
        Me.LblJogador.TabIndex = 6
        Me.LblJogador.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PnlTime
        '
        Me.PnlTime.BackColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(222, Byte), Integer))
        Me.PnlTime.Controls.Add(Me.LblTime)
        Me.PnlTime.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PnlTime.Location = New System.Drawing.Point(0, 329)
        Me.PnlTime.Name = "PnlTime"
        Me.PnlTime.Size = New System.Drawing.Size(379, 55)
        Me.PnlTime.TabIndex = 5
        '
        'LblTime
        '
        Me.LblTime.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblTime.BackColor = System.Drawing.Color.Transparent
        Me.LblTime.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LblTime.Font = New System.Drawing.Font("Unispace", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTime.ForeColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.LblTime.Location = New System.Drawing.Point(0, 0)
        Me.LblTime.Name = "LblTime"
        Me.LblTime.Size = New System.Drawing.Size(379, 55)
        Me.LblTime.TabIndex = 7
        Me.LblTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Escudo
        '
        Me.Escudo.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Escudo.BackColor = System.Drawing.Color.Transparent
        Me.Escudo.Location = New System.Drawing.Point(69, 72)
        Me.Escudo.Name = "Escudo"
        Me.Escudo.Size = New System.Drawing.Size(240, 240)
        Me.Escudo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Escudo.TabIndex = 4
        Me.Escudo.TabStop = False
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToResizeColumns = False
        Me.DataGridView1.AllowUserToResizeRows = False
        Me.DataGridView1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(222, Byte), Integer))
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.DataGridView1.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable
        Me.DataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(74, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Padding = New System.Windows.Forms.Padding(0, 12, 0, 12)
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(74, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(222, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.Padding = New System.Windows.Forms.Padding(0, 2, 0, 2)
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.EnableHeadersVisualStyles = False
        Me.DataGridView1.GridColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.DataGridView1.Location = New System.Drawing.Point(12, 85)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(222, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.NullValue = Nothing
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle4.Format = "N0"
        DataGridViewCellStyle4.NullValue = Nothing
        Me.DataGridView1.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridView1.RowTemplate.Height = 42
        Me.DataGridView1.RowTemplate.ReadOnly = True
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(622, 384)
        Me.DataGridView1.TabIndex = 0
        '
        'Estatisticas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.BackgroundImage = Global.Sorteio_de_Times.My.Resources.Resources.Background
        Me.ClientSize = New System.Drawing.Size(1036, 480)
        Me.Controls.Add(Me.PnlE)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Estatisticas"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Estatisticas"
        Me.PnlE.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Bloco.ResumeLayout(False)
        Me.PnlJogador.ResumeLayout(False)
        Me.PnlJogador.PerformLayout()
        Me.PnlTime.ResumeLayout(False)
        CType(Me.Escudo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents LblAtualCamp As Label
    Friend WithEvents Bloco As Panel
    Friend WithEvents Escudo As PictureBox
    Friend WithEvents PnlJogador As Panel
    Friend WithEvents LblJogador As Label
    Friend WithEvents PnlTime As Panel
    Friend WithEvents LblTime As Label
    Friend WithEvents PnlE As Panel
    Friend WithEvents JColor As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents LblClassif As Label
End Class
