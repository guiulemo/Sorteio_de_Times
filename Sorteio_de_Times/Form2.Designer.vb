<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form2
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.ModDrTxtJ = New System.Windows.Forms.Label()
        Me.ContRegr = New System.Windows.Forms.Label()
        Me.ContAuxJog = New System.Windows.Forms.Label()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Timer3 = New System.Windows.Forms.Timer(Me.components)
        Me.Escudo = New System.Windows.Forms.PictureBox()
        Me.BlocoDr = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.JColor = New System.Windows.Forms.Panel()
        Me.ModDrTxtC = New System.Windows.Forms.Label()
        Me.Panel7.SuspendLayout()
        CType(Me.Escudo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BlocoDr.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.SuspendLayout()
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(0, 0)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(100, 23)
        Me.ProgressBar1.TabIndex = 32
        Me.ProgressBar1.Value = 3
        Me.ProgressBar1.Visible = False
        '
        'ModDrTxtJ
        '
        Me.ModDrTxtJ.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.ModDrTxtJ.AutoSize = True
        Me.ModDrTxtJ.BackColor = System.Drawing.Color.Transparent
        Me.ModDrTxtJ.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ModDrTxtJ.Font = New System.Drawing.Font("Unispace", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ModDrTxtJ.ForeColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.ModDrTxtJ.Location = New System.Drawing.Point(34, 20)
        Me.ModDrTxtJ.Name = "ModDrTxtJ"
        Me.ModDrTxtJ.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ModDrTxtJ.Size = New System.Drawing.Size(0, 48)
        Me.ModDrTxtJ.TabIndex = 6
        Me.ModDrTxtJ.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ContRegr
        '
        Me.ContRegr.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ContRegr.AutoSize = True
        Me.ContRegr.BackColor = System.Drawing.Color.Transparent
        Me.ContRegr.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ContRegr.Font = New System.Drawing.Font("Unispace", 200.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ContRegr.ForeColor = System.Drawing.Color.White
        Me.ContRegr.Location = New System.Drawing.Point(764, 348)
        Me.ContRegr.Name = "ContRegr"
        Me.ContRegr.Size = New System.Drawing.Size(0, 321)
        Me.ContRegr.TabIndex = 4
        Me.ContRegr.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ContAuxJog
        '
        Me.ContAuxJog.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.ContAuxJog.AutoSize = True
        Me.ContAuxJog.BackColor = System.Drawing.Color.Transparent
        Me.ContAuxJog.Font = New System.Drawing.Font("Unispace", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ContAuxJog.ForeColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.ContAuxJog.Location = New System.Drawing.Point(509, 20)
        Me.ContAuxJog.Name = "ContAuxJog"
        Me.ContAuxJog.Size = New System.Drawing.Size(92, 48)
        Me.ContAuxJog.TabIndex = 2
        Me.ContAuxJog.Text = "0/0"
        Me.ContAuxJog.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(222, Byte), Integer))
        Me.Panel7.Controls.Add(Me.ModDrTxtC)
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel7.Location = New System.Drawing.Point(0, 561)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(616, 89)
        Me.Panel7.TabIndex = 5
        '
        'Timer3
        '
        Me.Timer3.Interval = 1000
        '
        'Escudo
        '
        Me.Escudo.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Escudo.BackColor = System.Drawing.Color.Transparent
        Me.Escudo.Location = New System.Drawing.Point(118, 135)
        Me.Escudo.Name = "Escudo"
        Me.Escudo.Size = New System.Drawing.Size(380, 380)
        Me.Escudo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Escudo.TabIndex = 4
        Me.Escudo.TabStop = False
        '
        'BlocoDr
        '
        Me.BlocoDr.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BlocoDr.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BlocoDr.Controls.Add(Me.Escudo)
        Me.BlocoDr.Controls.Add(Me.Panel6)
        Me.BlocoDr.Controls.Add(Me.Panel7)
        Me.BlocoDr.Location = New System.Drawing.Point(596, 183)
        Me.BlocoDr.Name = "BlocoDr"
        Me.BlocoDr.Size = New System.Drawing.Size(616, 650)
        Me.BlocoDr.TabIndex = 33
        Me.BlocoDr.Visible = False
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(222, Byte), Integer))
        Me.Panel6.Controls.Add(Me.JColor)
        Me.Panel6.Controls.Add(Me.ModDrTxtJ)
        Me.Panel6.Controls.Add(Me.ContAuxJog)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel6.Location = New System.Drawing.Point(0, 0)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(616, 89)
        Me.Panel6.TabIndex = 6
        '
        'JColor
        '
        Me.JColor.BackColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.JColor.Location = New System.Drawing.Point(14, 15)
        Me.JColor.Name = "JColor"
        Me.JColor.Size = New System.Drawing.Size(14, 58)
        Me.JColor.TabIndex = 34
        '
        'ModDrTxtC
        '
        Me.ModDrTxtC.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ModDrTxtC.BackColor = System.Drawing.Color.Transparent
        Me.ModDrTxtC.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ModDrTxtC.Font = New System.Drawing.Font("Unispace", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ModDrTxtC.ForeColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.ModDrTxtC.Location = New System.Drawing.Point(0, 20)
        Me.ModDrTxtC.Name = "ModDrTxtC"
        Me.ModDrTxtC.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ModDrTxtC.Size = New System.Drawing.Size(616, 48)
        Me.ModDrTxtC.TabIndex = 7
        Me.ModDrTxtC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gray
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(1809, 1017)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.ContRegr)
        Me.Controls.Add(Me.BlocoDr)
        Me.DoubleBuffered = True
        Me.KeyPreview = True
        Me.Name = "Form2"
        Me.ShowIcon = False
        Me.Text = "Form2"
        Me.TopMost = True
        Me.Panel7.ResumeLayout(False)
        CType(Me.Escudo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BlocoDr.ResumeLayout(False)
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ModDrTxtJ As Label
    Friend WithEvents ContRegr As Label
    Friend WithEvents ContAuxJog As Label
    Friend WithEvents Escudo As PictureBox
    Friend WithEvents Panel7 As Panel
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents Timer3 As Timer
    Friend WithEvents BlocoDr As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents JColor As Panel
    Friend WithEvents ModDrTxtC As Label
End Class
