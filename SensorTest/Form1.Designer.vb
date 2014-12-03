<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
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

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.ProgressBar2 = New System.Windows.Forms.ProgressBar()
        Me.ProgressBar3 = New System.Windows.Forms.ProgressBar()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ProgressBar4 = New System.Windows.Forms.ProgressBar()
        Me.ProgressBar5 = New System.Windows.Forms.ProgressBar()
        Me.ProgressBar6 = New System.Windows.Forms.ProgressBar()
        Me.orientation_lbl = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(300, 24)
        Me.ProgressBar1.Maximum = 1005
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(180, 53)
        Me.ProgressBar1.TabIndex = 0
        Me.ProgressBar1.Value = 1
        '
        'ProgressBar2
        '
        Me.ProgressBar2.Location = New System.Drawing.Point(300, 111)
        Me.ProgressBar2.Maximum = 1005
        Me.ProgressBar2.Name = "ProgressBar2"
        Me.ProgressBar2.Size = New System.Drawing.Size(180, 53)
        Me.ProgressBar2.TabIndex = 1
        Me.ProgressBar2.Value = 1
        '
        'ProgressBar3
        '
        Me.ProgressBar3.Location = New System.Drawing.Point(300, 205)
        Me.ProgressBar3.Maximum = 1005
        Me.ProgressBar3.Name = "ProgressBar3"
        Me.ProgressBar3.Size = New System.Drawing.Size(180, 53)
        Me.ProgressBar3.TabIndex = 2
        Me.ProgressBar3.Value = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(20, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(17, 20)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "x"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(20, 129)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(17, 20)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "y"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(20, 224)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(18, 20)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "z"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(486, 224)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(18, 20)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "z"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(486, 129)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(17, 20)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "y"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(486, 42)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(17, 20)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "x"
        '
        'ProgressBar4
        '
        Me.ProgressBar4.Location = New System.Drawing.Point(114, 205)
        Me.ProgressBar4.Maximum = 1005
        Me.ProgressBar4.Name = "ProgressBar4"
        Me.ProgressBar4.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ProgressBar4.RightToLeftLayout = True
        Me.ProgressBar4.Size = New System.Drawing.Size(180, 53)
        Me.ProgressBar4.TabIndex = 11
        Me.ProgressBar4.Value = 1
        '
        'ProgressBar5
        '
        Me.ProgressBar5.Location = New System.Drawing.Point(114, 111)
        Me.ProgressBar5.Maximum = 1005
        Me.ProgressBar5.Name = "ProgressBar5"
        Me.ProgressBar5.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ProgressBar5.RightToLeftLayout = True
        Me.ProgressBar5.Size = New System.Drawing.Size(180, 53)
        Me.ProgressBar5.TabIndex = 10
        Me.ProgressBar5.Value = 1
        '
        'ProgressBar6
        '
        Me.ProgressBar6.Location = New System.Drawing.Point(114, 24)
        Me.ProgressBar6.Maximum = 1005
        Me.ProgressBar6.Name = "ProgressBar6"
        Me.ProgressBar6.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ProgressBar6.RightToLeftLayout = True
        Me.ProgressBar6.Size = New System.Drawing.Size(180, 53)
        Me.ProgressBar6.TabIndex = 9
        Me.ProgressBar6.Value = 1
        '
        'orientation_lbl
        '
        Me.orientation_lbl.AutoSize = True
        Me.orientation_lbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.orientation_lbl.Location = New System.Drawing.Point(205, 312)
        Me.orientation_lbl.Name = "orientation_lbl"
        Me.orientation_lbl.Size = New System.Drawing.Size(70, 24)
        Me.orientation_lbl.TabIndex = 12
        Me.orientation_lbl.Text = "Porträt"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(555, 355)
        Me.Controls.Add(Me.orientation_lbl)
        Me.Controls.Add(Me.ProgressBar4)
        Me.Controls.Add(Me.ProgressBar5)
        Me.Controls.Add(Me.ProgressBar6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ProgressBar3)
        Me.Controls.Add(Me.ProgressBar2)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Name = "Form1"
        Me.Text = "Sensors"
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents ProgressBar2 As System.Windows.Forms.ProgressBar
    Friend WithEvents ProgressBar3 As System.Windows.Forms.ProgressBar
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents ProgressBar4 As System.Windows.Forms.ProgressBar
    Friend WithEvents ProgressBar5 As System.Windows.Forms.ProgressBar
    Friend WithEvents ProgressBar6 As System.Windows.Forms.ProgressBar
    Friend WithEvents orientation_lbl As System.Windows.Forms.Label
End Class
