<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        Me.lbNameList = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'lbNameList
        '
        Me.lbNameList.FormattingEnabled = True
        Me.lbNameList.Location = New System.Drawing.Point(97, 101)
        Me.lbNameList.Name = "lbNameList"
        Me.lbNameList.Size = New System.Drawing.Size(201, 186)
        Me.lbNameList.TabIndex = 0
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(431, 466)
        Me.Controls.Add(Me.lbNameList)
        Me.Name = "MainForm"
        Me.Text = "Name List"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lbNameList As System.Windows.Forms.ListBox

End Class
