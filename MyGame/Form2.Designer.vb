<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.LOOSE = New System.Windows.Forms.PictureBox()
        CType(Me.LOOSE, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(311, 98)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePicker1.TabIndex = 1
        '
        'LOOSE
        '
        Me.LOOSE.Image = Global.MyGame.My.Resources.Resources.mariomario__
        Me.LOOSE.Location = New System.Drawing.Point(-7, -6)
        Me.LOOSE.Name = "LOOSE"
        Me.LOOSE.Size = New System.Drawing.Size(773, 449)
        Me.LOOSE.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.LOOSE.TabIndex = 0
        Me.LOOSE.TabStop = False
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(749, 415)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.LOOSE)
        Me.Name = "Form2"
        Me.Text = "Form2"
        CType(Me.LOOSE, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents LOOSE As PictureBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
End Class
