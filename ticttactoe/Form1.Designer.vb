<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.b1 = New System.Windows.Forms.Button()
        Me.b2 = New System.Windows.Forms.Button()
        Me.b3 = New System.Windows.Forms.Button()
        Me.b4 = New System.Windows.Forms.Button()
        Me.b5 = New System.Windows.Forms.Button()
        Me.b6 = New System.Windows.Forms.Button()
        Me.b7 = New System.Windows.Forms.Button()
        Me.b8 = New System.Windows.Forms.Button()
        Me.b9 = New System.Windows.Forms.Button()
        Me.bnewgame = New System.Windows.Forms.Button()
        Me.breset = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'b1
        '
        Me.b1.Location = New System.Drawing.Point(83, 103)
        Me.b1.Name = "b1"
        Me.b1.Size = New System.Drawing.Size(109, 107)
        Me.b1.TabIndex = 0
        Me.b1.UseVisualStyleBackColor = True
        '
        'b2
        '
        Me.b2.Location = New System.Drawing.Point(215, 103)
        Me.b2.Name = "b2"
        Me.b2.Size = New System.Drawing.Size(109, 107)
        Me.b2.TabIndex = 1
        Me.b2.UseVisualStyleBackColor = True
        '
        'b3
        '
        Me.b3.Location = New System.Drawing.Point(347, 103)
        Me.b3.Name = "b3"
        Me.b3.Size = New System.Drawing.Size(109, 107)
        Me.b3.TabIndex = 2
        Me.b3.UseVisualStyleBackColor = True
        '
        'b4
        '
        Me.b4.Location = New System.Drawing.Point(83, 233)
        Me.b4.Name = "b4"
        Me.b4.Size = New System.Drawing.Size(109, 107)
        Me.b4.TabIndex = 3
        Me.b4.UseVisualStyleBackColor = True
        '
        'b5
        '
        Me.b5.Location = New System.Drawing.Point(215, 233)
        Me.b5.Name = "b5"
        Me.b5.Size = New System.Drawing.Size(109, 107)
        Me.b5.TabIndex = 4
        Me.b5.UseVisualStyleBackColor = True
        '
        'b6
        '
        Me.b6.Location = New System.Drawing.Point(347, 233)
        Me.b6.Name = "b6"
        Me.b6.Size = New System.Drawing.Size(109, 107)
        Me.b6.TabIndex = 5
        Me.b6.UseVisualStyleBackColor = True
        '
        'b7
        '
        Me.b7.Location = New System.Drawing.Point(83, 368)
        Me.b7.Name = "b7"
        Me.b7.Size = New System.Drawing.Size(109, 107)
        Me.b7.TabIndex = 6
        Me.b7.UseVisualStyleBackColor = True
        '
        'b8
        '
        Me.b8.Location = New System.Drawing.Point(215, 368)
        Me.b8.Name = "b8"
        Me.b8.Size = New System.Drawing.Size(109, 107)
        Me.b8.TabIndex = 7
        Me.b8.UseVisualStyleBackColor = True
        '
        'b9
        '
        Me.b9.Location = New System.Drawing.Point(347, 368)
        Me.b9.Name = "b9"
        Me.b9.Size = New System.Drawing.Size(109, 107)
        Me.b9.TabIndex = 8
        Me.b9.UseVisualStyleBackColor = True
        '
        'bnewgame
        '
        Me.bnewgame.Location = New System.Drawing.Point(83, 522)
        Me.bnewgame.Name = "bnewgame"
        Me.bnewgame.Size = New System.Drawing.Size(181, 107)
        Me.bnewgame.TabIndex = 9
        Me.bnewgame.Text = "new game"
        Me.bnewgame.UseVisualStyleBackColor = True
        '
        'breset
        '
        Me.breset.Location = New System.Drawing.Point(303, 522)
        Me.breset.Name = "breset"
        Me.breset.Size = New System.Drawing.Size(181, 107)
        Me.breset.TabIndex = 10
        Me.breset.Text = "reset"
        Me.breset.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1313, 736)
        Me.Controls.Add(Me.breset)
        Me.Controls.Add(Me.bnewgame)
        Me.Controls.Add(Me.b9)
        Me.Controls.Add(Me.b8)
        Me.Controls.Add(Me.b7)
        Me.Controls.Add(Me.b6)
        Me.Controls.Add(Me.b5)
        Me.Controls.Add(Me.b4)
        Me.Controls.Add(Me.b3)
        Me.Controls.Add(Me.b2)
        Me.Controls.Add(Me.b1)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents b1 As Button
    Friend WithEvents b2 As Button
    Friend WithEvents b3 As Button
    Friend WithEvents b4 As Button
    Friend WithEvents b5 As Button
    Friend WithEvents b6 As Button
    Friend WithEvents b7 As Button
    Friend WithEvents b8 As Button
    Friend WithEvents b9 As Button
    Friend WithEvents bnewgame As Button
    Friend WithEvents breset As Button
End Class
