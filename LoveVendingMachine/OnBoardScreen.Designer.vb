<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OnBoardScreen
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
        Me.CancelButton = New System.Windows.Forms.Button()
        Me.AddMoneyButton = New System.Windows.Forms.Button()
        Me.AddAmountTextBox = New System.Windows.Forms.TextBox()
        Me.AddAmountLabel = New System.Windows.Forms.Label()
        Me.btnDollar = New System.Windows.Forms.Button()
        Me.btnQuarter = New System.Windows.Forms.Button()
        Me.btnDime = New System.Windows.Forms.Button()
        Me.btnNickel = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'CancelButton
        '
        Me.CancelButton.BackColor = System.Drawing.Color.DimGray
        Me.CancelButton.Location = New System.Drawing.Point(272, 184)
        Me.CancelButton.Margin = New System.Windows.Forms.Padding(2)
        Me.CancelButton.Name = "CancelButton"
        Me.CancelButton.Size = New System.Drawing.Size(109, 33)
        Me.CancelButton.TabIndex = 16
        Me.CancelButton.Text = "&Cancel"
        Me.CancelButton.UseVisualStyleBackColor = False
        '
        'AddMoneyButton
        '
        Me.AddMoneyButton.BackColor = System.Drawing.Color.DimGray
        Me.AddMoneyButton.Location = New System.Drawing.Point(272, 125)
        Me.AddMoneyButton.Margin = New System.Windows.Forms.Padding(2)
        Me.AddMoneyButton.Name = "AddMoneyButton"
        Me.AddMoneyButton.Size = New System.Drawing.Size(109, 33)
        Me.AddMoneyButton.TabIndex = 15
        Me.AddMoneyButton.Text = "Add Money"
        Me.AddMoneyButton.UseVisualStyleBackColor = False
        '
        'AddAmountTextBox
        '
        Me.AddAmountTextBox.Location = New System.Drawing.Point(263, 47)
        Me.AddAmountTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.AddAmountTextBox.Name = "AddAmountTextBox"
        Me.AddAmountTextBox.ReadOnly = True
        Me.AddAmountTextBox.Size = New System.Drawing.Size(126, 20)
        Me.AddAmountTextBox.TabIndex = 14
        '
        'AddAmountLabel
        '
        Me.AddAmountLabel.AutoSize = True
        Me.AddAmountLabel.BackColor = System.Drawing.Color.Black
        Me.AddAmountLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.AddAmountLabel.ForeColor = System.Drawing.Color.Lime
        Me.AddAmountLabel.Location = New System.Drawing.Point(275, 19)
        Me.AddAmountLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.AddAmountLabel.Name = "AddAmountLabel"
        Me.AddAmountLabel.Size = New System.Drawing.Size(101, 17)
        Me.AddAmountLabel.TabIndex = 13
        Me.AddAmountLabel.Text = "Amount to Add"
        '
        'btnDollar
        '
        Me.btnDollar.BackColor = System.Drawing.Color.DimGray
        Me.btnDollar.Location = New System.Drawing.Point(14, 176)
        Me.btnDollar.Margin = New System.Windows.Forms.Padding(2)
        Me.btnDollar.Name = "btnDollar"
        Me.btnDollar.Size = New System.Drawing.Size(117, 48)
        Me.btnDollar.TabIndex = 12
        Me.btnDollar.Text = "Dollar"
        Me.btnDollar.UseVisualStyleBackColor = False
        '
        'btnQuarter
        '
        Me.btnQuarter.BackColor = System.Drawing.Color.DimGray
        Me.btnQuarter.Location = New System.Drawing.Point(14, 125)
        Me.btnQuarter.Margin = New System.Windows.Forms.Padding(2)
        Me.btnQuarter.Name = "btnQuarter"
        Me.btnQuarter.Size = New System.Drawing.Size(117, 48)
        Me.btnQuarter.TabIndex = 11
        Me.btnQuarter.Text = "Quarter"
        Me.btnQuarter.UseVisualStyleBackColor = False
        '
        'btnDime
        '
        Me.btnDime.BackColor = System.Drawing.Color.DimGray
        Me.btnDime.Location = New System.Drawing.Point(14, 71)
        Me.btnDime.Margin = New System.Windows.Forms.Padding(2)
        Me.btnDime.Name = "btnDime"
        Me.btnDime.Size = New System.Drawing.Size(117, 48)
        Me.btnDime.TabIndex = 10
        Me.btnDime.Text = "Dime"
        Me.btnDime.UseVisualStyleBackColor = False
        '
        'btnNickel
        '
        Me.btnNickel.BackColor = System.Drawing.Color.DimGray
        Me.btnNickel.Location = New System.Drawing.Point(14, 19)
        Me.btnNickel.Margin = New System.Windows.Forms.Padding(2)
        Me.btnNickel.Name = "btnNickel"
        Me.btnNickel.Size = New System.Drawing.Size(117, 48)
        Me.btnNickel.TabIndex = 9
        Me.btnNickel.Text = "Nickel"
        Me.btnNickel.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Black
        Me.GroupBox1.Controls.Add(Me.AddAmountLabel)
        Me.GroupBox1.Controls.Add(Me.CancelButton)
        Me.GroupBox1.Controls.Add(Me.btnNickel)
        Me.GroupBox1.Controls.Add(Me.AddMoneyButton)
        Me.GroupBox1.Controls.Add(Me.btnDime)
        Me.GroupBox1.Controls.Add(Me.AddAmountTextBox)
        Me.GroupBox1.Controls.Add(Me.btnQuarter)
        Me.GroupBox1.Controls.Add(Me.btnDollar)
        Me.GroupBox1.ForeColor = System.Drawing.Color.Lime
        Me.GroupBox1.Location = New System.Drawing.Point(69, 59)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(653, 252)
        Me.GroupBox1.TabIndex = 17
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Money Screen"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Maroon
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form2"
        Me.Text = "On Board Screen"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents CancelButton As Button
    Friend WithEvents AddMoneyButton As Button
    Friend WithEvents AddAmountTextBox As TextBox
    Friend WithEvents AddAmountLabel As Label
    Friend WithEvents btnDollar As Button
    Friend WithEvents btnQuarter As Button
    Friend WithEvents btnDime As Button
    Friend WithEvents btnNickel As Button
    Friend WithEvents GroupBox1 As GroupBox
End Class
