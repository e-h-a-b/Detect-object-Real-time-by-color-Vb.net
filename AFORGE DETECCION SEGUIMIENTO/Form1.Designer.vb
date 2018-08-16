<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.PictureBoxORIGINAL = New System.Windows.Forms.PictureBox()
        Me.PictureBoxFILTRADO = New System.Windows.Forms.PictureBox()
        Me.TrackBarMINR = New System.Windows.Forms.TrackBar()
        Me.TrackBarMAXR = New System.Windows.Forms.TrackBar()
        Me.TrackBarMAXG = New System.Windows.Forms.TrackBar()
        Me.TrackBarMING = New System.Windows.Forms.TrackBar()
        Me.TrackBarMAXB = New System.Windows.Forms.TrackBar()
        Me.TrackBarMINB = New System.Windows.Forms.TrackBar()
        Me.LabelMINR = New System.Windows.Forms.Label()
        Me.LabelMAXR = New System.Windows.Forms.Label()
        Me.LabelMAXG = New System.Windows.Forms.Label()
        Me.LabelMING = New System.Windows.Forms.Label()
        Me.LabelMAXB = New System.Windows.Forms.Label()
        Me.LabelMINB = New System.Windows.Forms.Label()
        CType(Me.PictureBoxORIGINAL, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxFILTRADO, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TrackBarMINR, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TrackBarMAXR, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TrackBarMAXG, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TrackBarMING, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TrackBarMAXB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TrackBarMINB, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ComboBox1
        '
        Me.ComboBox1.BackColor = System.Drawing.Color.Black
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.ForeColor = System.Drawing.Color.Cyan
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(12, 389)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(480, 24)
        Me.ComboBox1.TabIndex = 15
        '
        'PictureBoxORIGINAL
        '
        Me.PictureBoxORIGINAL.Location = New System.Drawing.Point(12, 12)
        Me.PictureBoxORIGINAL.Name = "PictureBoxORIGINAL"
        Me.PictureBoxORIGINAL.Size = New System.Drawing.Size(480, 360)
        Me.PictureBoxORIGINAL.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBoxORIGINAL.TabIndex = 14
        Me.PictureBoxORIGINAL.TabStop = False
        '
        'PictureBoxFILTRADO
        '
        Me.PictureBoxFILTRADO.Location = New System.Drawing.Point(509, 12)
        Me.PictureBoxFILTRADO.Name = "PictureBoxFILTRADO"
        Me.PictureBoxFILTRADO.Size = New System.Drawing.Size(480, 360)
        Me.PictureBoxFILTRADO.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBoxFILTRADO.TabIndex = 22
        Me.PictureBoxFILTRADO.TabStop = False
        '
        'TrackBarMINR
        '
        Me.TrackBarMINR.Location = New System.Drawing.Point(12, 435)
        Me.TrackBarMINR.Maximum = 255
        Me.TrackBarMINR.Name = "TrackBarMINR"
        Me.TrackBarMINR.Size = New System.Drawing.Size(209, 45)
        Me.TrackBarMINR.TabIndex = 23
        '
        'TrackBarMAXR
        '
        Me.TrackBarMAXR.Location = New System.Drawing.Point(283, 435)
        Me.TrackBarMAXR.Maximum = 255
        Me.TrackBarMAXR.Name = "TrackBarMAXR"
        Me.TrackBarMAXR.Size = New System.Drawing.Size(209, 45)
        Me.TrackBarMAXR.TabIndex = 24
        Me.TrackBarMAXR.Value = 255
        '
        'TrackBarMAXG
        '
        Me.TrackBarMAXG.Location = New System.Drawing.Point(283, 486)
        Me.TrackBarMAXG.Maximum = 255
        Me.TrackBarMAXG.Name = "TrackBarMAXG"
        Me.TrackBarMAXG.Size = New System.Drawing.Size(209, 45)
        Me.TrackBarMAXG.TabIndex = 26
        Me.TrackBarMAXG.Value = 255
        '
        'TrackBarMING
        '
        Me.TrackBarMING.Location = New System.Drawing.Point(12, 486)
        Me.TrackBarMING.Maximum = 255
        Me.TrackBarMING.Name = "TrackBarMING"
        Me.TrackBarMING.Size = New System.Drawing.Size(209, 45)
        Me.TrackBarMING.TabIndex = 25
        '
        'TrackBarMAXB
        '
        Me.TrackBarMAXB.Location = New System.Drawing.Point(283, 537)
        Me.TrackBarMAXB.Maximum = 255
        Me.TrackBarMAXB.Name = "TrackBarMAXB"
        Me.TrackBarMAXB.Size = New System.Drawing.Size(209, 45)
        Me.TrackBarMAXB.TabIndex = 28
        Me.TrackBarMAXB.Value = 255
        '
        'TrackBarMINB
        '
        Me.TrackBarMINB.Location = New System.Drawing.Point(12, 537)
        Me.TrackBarMINB.Maximum = 255
        Me.TrackBarMINB.Name = "TrackBarMINB"
        Me.TrackBarMINB.Size = New System.Drawing.Size(209, 45)
        Me.TrackBarMINB.TabIndex = 27
        '
        'LabelMINR
        '
        Me.LabelMINR.AutoSize = True
        Me.LabelMINR.ForeColor = System.Drawing.Color.Teal
        Me.LabelMINR.Location = New System.Drawing.Point(93, 464)
        Me.LabelMINR.Name = "LabelMINR"
        Me.LabelMINR.Size = New System.Drawing.Size(62, 16)
        Me.LabelMINR.TabIndex = 29
        Me.LabelMINR.Text = "MINR: 0"
        '
        'LabelMAXR
        '
        Me.LabelMAXR.AutoSize = True
        Me.LabelMAXR.ForeColor = System.Drawing.Color.Teal
        Me.LabelMAXR.Location = New System.Drawing.Point(363, 464)
        Me.LabelMAXR.Name = "LabelMAXR"
        Me.LabelMAXR.Size = New System.Drawing.Size(82, 16)
        Me.LabelMAXR.TabIndex = 30
        Me.LabelMAXR.Text = "MAXR: 255"
        '
        'LabelMAXG
        '
        Me.LabelMAXG.AutoSize = True
        Me.LabelMAXG.ForeColor = System.Drawing.Color.Teal
        Me.LabelMAXG.Location = New System.Drawing.Point(363, 515)
        Me.LabelMAXG.Name = "LabelMAXG"
        Me.LabelMAXG.Size = New System.Drawing.Size(82, 16)
        Me.LabelMAXG.TabIndex = 32
        Me.LabelMAXG.Text = "MAXG: 255"
        '
        'LabelMING
        '
        Me.LabelMING.AutoSize = True
        Me.LabelMING.ForeColor = System.Drawing.Color.Teal
        Me.LabelMING.Location = New System.Drawing.Point(94, 518)
        Me.LabelMING.Name = "LabelMING"
        Me.LabelMING.Size = New System.Drawing.Size(62, 16)
        Me.LabelMING.TabIndex = 31
        Me.LabelMING.Text = "MING: 0"
        '
        'LabelMAXB
        '
        Me.LabelMAXB.AutoSize = True
        Me.LabelMAXB.ForeColor = System.Drawing.Color.Teal
        Me.LabelMAXB.Location = New System.Drawing.Point(364, 566)
        Me.LabelMAXB.Name = "LabelMAXB"
        Me.LabelMAXB.Size = New System.Drawing.Size(81, 16)
        Me.LabelMAXB.TabIndex = 34
        Me.LabelMAXB.Text = "MAXB: 255"
        '
        'LabelMINB
        '
        Me.LabelMINB.AutoSize = True
        Me.LabelMINB.ForeColor = System.Drawing.Color.Teal
        Me.LabelMINB.Location = New System.Drawing.Point(94, 566)
        Me.LabelMINB.Name = "LabelMINB"
        Me.LabelMINB.Size = New System.Drawing.Size(61, 16)
        Me.LabelMINB.TabIndex = 33
        Me.LabelMINB.Text = "MINB: 0"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(1006, 597)
        Me.Controls.Add(Me.LabelMAXB)
        Me.Controls.Add(Me.LabelMINB)
        Me.Controls.Add(Me.LabelMAXG)
        Me.Controls.Add(Me.LabelMING)
        Me.Controls.Add(Me.LabelMAXR)
        Me.Controls.Add(Me.LabelMINR)
        Me.Controls.Add(Me.TrackBarMAXB)
        Me.Controls.Add(Me.TrackBarMINB)
        Me.Controls.Add(Me.TrackBarMAXG)
        Me.Controls.Add(Me.TrackBarMING)
        Me.Controls.Add(Me.TrackBarMAXR)
        Me.Controls.Add(Me.TrackBarMINR)
        Me.Controls.Add(Me.PictureBoxFILTRADO)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.PictureBoxORIGINAL)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Cyan
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DETECCION Y SEGUIMIENTO"
        CType(Me.PictureBoxORIGINAL, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxFILTRADO, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TrackBarMINR, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TrackBarMAXR, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TrackBarMAXG, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TrackBarMING, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TrackBarMAXB, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TrackBarMINB, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents PictureBoxORIGINAL As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBoxFILTRADO As System.Windows.Forms.PictureBox
    Friend WithEvents TrackBarMINR As System.Windows.Forms.TrackBar
    Friend WithEvents TrackBarMAXR As System.Windows.Forms.TrackBar
    Friend WithEvents TrackBarMAXG As System.Windows.Forms.TrackBar
    Friend WithEvents TrackBarMING As System.Windows.Forms.TrackBar
    Friend WithEvents TrackBarMAXB As System.Windows.Forms.TrackBar
    Friend WithEvents TrackBarMINB As System.Windows.Forms.TrackBar
    Friend WithEvents LabelMINR As System.Windows.Forms.Label
    Friend WithEvents LabelMAXR As System.Windows.Forms.Label
    Friend WithEvents LabelMAXG As System.Windows.Forms.Label
    Friend WithEvents LabelMING As System.Windows.Forms.Label
    Friend WithEvents LabelMAXB As System.Windows.Forms.Label
    Friend WithEvents LabelMINB As System.Windows.Forms.Label

End Class
