<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class TicTacToe
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TicTacToe))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.user1 = New System.Windows.Forms.Label()
        Me.user2 = New System.Windows.Forms.Label()
        Me.VS = New System.Windows.Forms.Label()
        Me.reset = New System.Windows.Forms.Button()
        Me.start = New System.Windows.Forms.Button()
        Me.close = New System.Windows.Forms.Button()
        Me.help = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Location = New System.Drawing.Point(134, 75)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(780, 555)
        Me.Panel1.TabIndex = 0
        '
        'user1
        '
        Me.user1.AutoSize = True
        Me.user1.Location = New System.Drawing.Point(50, 31)
        Me.user1.Name = "user1"
        Me.user1.Size = New System.Drawing.Size(63, 25)
        Me.user1.TabIndex = 1
        Me.user1.Text = "Label1"
        '
        'user2
        '
        Me.user2.AutoSize = True
        Me.user2.Location = New System.Drawing.Point(937, 31)
        Me.user2.Name = "user2"
        Me.user2.Size = New System.Drawing.Size(63, 25)
        Me.user2.TabIndex = 2
        Me.user2.Text = "Label2"
        '
        'VS
        '
        Me.VS.AutoSize = True
        Me.VS.Location = New System.Drawing.Point(493, 31)
        Me.VS.Name = "VS"
        Me.VS.Size = New System.Drawing.Size(33, 25)
        Me.VS.TabIndex = 3
        Me.VS.Text = "VS"
        '
        'reset
        '
        Me.reset.Location = New System.Drawing.Point(13, 637)
        Me.reset.Name = "reset"
        Me.reset.Size = New System.Drawing.Size(348, 55)
        Me.reset.TabIndex = 4
        Me.reset.Text = "Reset"
        Me.reset.UseVisualStyleBackColor = True
        '
        'start
        '
        Me.start.Location = New System.Drawing.Point(367, 636)
        Me.start.Name = "start"
        Me.start.Size = New System.Drawing.Size(367, 55)
        Me.start.TabIndex = 5
        Me.start.Text = "Start"
        Me.start.UseVisualStyleBackColor = True
        '
        'close
        '
        Me.close.Location = New System.Drawing.Point(740, 637)
        Me.close.Name = "close"
        Me.close.Size = New System.Drawing.Size(296, 55)
        Me.close.TabIndex = 6
        Me.close.Text = "Exit"
        Me.close.UseVisualStyleBackColor = True
        '
        'help
        '
        Me.help.Image = CType(resources.GetObject("help.Image"), System.Drawing.Image)
        Me.help.Location = New System.Drawing.Point(991, 647)
        Me.help.Name = "help"
        Me.help.Size = New System.Drawing.Size(34, 34)
        Me.help.TabIndex = 7
        Me.help.UseVisualStyleBackColor = True
        '
        'TicTacToe
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1048, 704)
        Me.Controls.Add(Me.help)
        Me.Controls.Add(Me.close)
        Me.Controls.Add(Me.start)
        Me.Controls.Add(Me.reset)
        Me.Controls.Add(Me.VS)
        Me.Controls.Add(Me.user2)
        Me.Controls.Add(Me.user1)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "TicTacToe"
        Me.Text = "Tic Tac Toe"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents user1 As Label
    Friend WithEvents user2 As Label
    Friend WithEvents VS As Label
    Friend WithEvents reset As Button
    Friend WithEvents start As Button
    Friend WithEvents close As Button
    Friend WithEvents help As Button
End Class
