<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DinerMenuForm
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
        Me.DinerNameLabel = New System.Windows.Forms.Label()
        Me.SoupButton = New System.Windows.Forms.Button()
        Me.SaladButton = New System.Windows.Forms.Button()
        Me.FishButton = New System.Windows.Forms.Button()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.DisplaySpecialLabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'DinerNameLabel
        '
        Me.DinerNameLabel.AutoSize = True
        Me.DinerNameLabel.Font = New System.Drawing.Font("Segoe UI", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.DinerNameLabel.Location = New System.Drawing.Point(76, 9)
        Me.DinerNameLabel.Name = "DinerNameLabel"
        Me.DinerNameLabel.Size = New System.Drawing.Size(606, 47)
        Me.DinerNameLabel.TabIndex = 0
        Me.DinerNameLabel.Text = "Christopher's Hole-in-the-Wall Cafe"
        '
        'SoupButton
        '
        Me.SoupButton.Location = New System.Drawing.Point(12, 306)
        Me.SoupButton.Name = "SoupButton"
        Me.SoupButton.Size = New System.Drawing.Size(136, 44)
        Me.SoupButton.TabIndex = 1
        Me.SoupButton.Text = "Daily Soup"
        Me.SoupButton.UseVisualStyleBackColor = True
        '
        'SaladButton
        '
        Me.SaladButton.Location = New System.Drawing.Point(213, 306)
        Me.SaladButton.Name = "SaladButton"
        Me.SaladButton.Size = New System.Drawing.Size(136, 44)
        Me.SaladButton.TabIndex = 2
        Me.SaladButton.Text = "Daily Salad"
        Me.SaladButton.UseVisualStyleBackColor = True
        '
        'FishButton
        '
        Me.FishButton.Location = New System.Drawing.Point(415, 306)
        Me.FishButton.Name = "FishButton"
        Me.FishButton.Size = New System.Drawing.Size(136, 44)
        Me.FishButton.TabIndex = 3
        Me.FishButton.Text = "Daily Fish"
        Me.FishButton.UseVisualStyleBackColor = True
        '
        'ExitButton
        '
        Me.ExitButton.Location = New System.Drawing.Point(610, 306)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(136, 44)
        Me.ExitButton.TabIndex = 4
        Me.ExitButton.Text = "Exit"
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'DisplaySpecialLabel
        '
        Me.DisplaySpecialLabel.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.DisplaySpecialLabel.Location = New System.Drawing.Point(76, 84)
        Me.DisplaySpecialLabel.Name = "DisplaySpecialLabel"
        Me.DisplaySpecialLabel.Size = New System.Drawing.Size(606, 173)
        Me.DisplaySpecialLabel.TabIndex = 5
        Me.DisplaySpecialLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DinerMenuForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(761, 373)
        Me.Controls.Add(Me.DisplaySpecialLabel)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.FishButton)
        Me.Controls.Add(Me.SaladButton)
        Me.Controls.Add(Me.SoupButton)
        Me.Controls.Add(Me.DinerNameLabel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "DinerMenuForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Speciality Menu"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DinerNameLabel As Label
    Friend WithEvents SoupButton As Button
    Friend WithEvents SaladButton As Button
    Friend WithEvents FishButton As Button
    Friend WithEvents ExitButton As Button
    Friend WithEvents DisplaySpecialLabel As Label
End Class
