<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VendingMachine
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(VendingMachine))
        Me.grpSelections = New System.Windows.Forms.GroupBox()
        Me.picLogo = New System.Windows.Forms.PictureBox()
        Me.mnuStrip = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuAddMoney = New System.Windows.Forms.ToolStripMenuItem()
        Me.CompletePurchaseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CancelToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PaymentGroupBox = New System.Windows.Forms.GroupBox()
        Me.CancelButton = New System.Windows.Forms.Button()
        Me.CompletePurchaseButton = New System.Windows.Forms.Button()
        Me.btnAddMoney = New System.Windows.Forms.Button()
        Me.AmountDueTextBox = New System.Windows.Forms.TextBox()
        Me.AmountDueLabel = New System.Windows.Forms.Label()
        Me.PurchaseAmountTextBox = New System.Windows.Forms.TextBox()
        Me.PurchaseAmountLabel = New System.Windows.Forms.Label()
        Me.AmtEnteredTextBox = New System.Windows.Forms.TextBox()
        Me.AmtEnteredLabel = New System.Windows.Forms.Label()
        Me.MilkyWayLabel = New System.Windows.Forms.Label()
        Me.TwixLabel = New System.Windows.Forms.Label()
        Me.ReesesLabel = New System.Windows.Forms.Label()
        Me.SnickersLabel = New System.Windows.Forms.Label()
        Me.PopcornLabel = New System.Windows.Forms.Label()
        Me.CoolerRanchLabel = New System.Windows.Forms.Label()
        Me.NachoCheeseLabel = New System.Windows.Forms.Label()
        Me.SunChipsLabel = New System.Windows.Forms.Label()
        Me.MtnDewLabel = New System.Windows.Forms.Label()
        Me.DrPepperLabel = New System.Windows.Forms.Label()
        Me.DietCokeLabel = New System.Windows.Forms.Label()
        Me.CokeLabel = New System.Windows.Forms.Label()
        Me.btnDietCoke = New System.Windows.Forms.Button()
        Me.btnCoke = New System.Windows.Forms.Button()
        Me.btnCokeZero = New System.Windows.Forms.Button()
        Me.btnSprite = New System.Windows.Forms.Button()
        Me.btnFanta = New System.Windows.Forms.Button()
        Me.btnCremeSoda = New System.Windows.Forms.Button()
        Me.btnDasani = New System.Windows.Forms.Button()
        Me.btnCFCoke = New System.Windows.Forms.Button()
        Me.btnMonster = New System.Windows.Forms.Button()
        Me.btnOrangeVanillaCoke = New System.Windows.Forms.Button()
        Me.btnRootBeer = New System.Windows.Forms.Button()
        Me.btnCherryCoke = New System.Windows.Forms.Button()
        Me.grpPlaceHolderAesthetic = New System.Windows.Forms.GroupBox()
        Me.btnPlaceHolder1 = New System.Windows.Forms.Button()
        Me.btnPlaceHolder2 = New System.Windows.Forms.Button()
        Me.btnPlaceHolder3 = New System.Windows.Forms.Button()
        Me.btnPlaceHolder4 = New System.Windows.Forms.Button()
        Me.btnPlaceHolder6 = New System.Windows.Forms.Button()
        Me.btnPlaceHolder5 = New System.Windows.Forms.Button()
        Me.txtPlaceholder = New System.Windows.Forms.TextBox()
        Me.lblPlaceHolder = New System.Windows.Forms.Label()
        Me.grpSelections.SuspendLayout()
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.mnuStrip.SuspendLayout()
        Me.PaymentGroupBox.SuspendLayout()
        Me.grpPlaceHolderAesthetic.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpSelections
        '
        Me.grpSelections.BackColor = System.Drawing.Color.Maroon
        Me.grpSelections.Controls.Add(Me.picLogo)
        Me.grpSelections.Controls.Add(Me.mnuStrip)
        Me.grpSelections.Controls.Add(Me.PaymentGroupBox)
        Me.grpSelections.Controls.Add(Me.MilkyWayLabel)
        Me.grpSelections.Controls.Add(Me.TwixLabel)
        Me.grpSelections.Controls.Add(Me.ReesesLabel)
        Me.grpSelections.Controls.Add(Me.SnickersLabel)
        Me.grpSelections.Controls.Add(Me.PopcornLabel)
        Me.grpSelections.Controls.Add(Me.CoolerRanchLabel)
        Me.grpSelections.Controls.Add(Me.NachoCheeseLabel)
        Me.grpSelections.Controls.Add(Me.SunChipsLabel)
        Me.grpSelections.Controls.Add(Me.MtnDewLabel)
        Me.grpSelections.Controls.Add(Me.DrPepperLabel)
        Me.grpSelections.Controls.Add(Me.DietCokeLabel)
        Me.grpSelections.Controls.Add(Me.CokeLabel)
        Me.grpSelections.Controls.Add(Me.btnDietCoke)
        Me.grpSelections.Controls.Add(Me.btnCoke)
        Me.grpSelections.Controls.Add(Me.btnCokeZero)
        Me.grpSelections.Controls.Add(Me.btnSprite)
        Me.grpSelections.Controls.Add(Me.btnFanta)
        Me.grpSelections.Controls.Add(Me.btnCremeSoda)
        Me.grpSelections.Controls.Add(Me.btnDasani)
        Me.grpSelections.Controls.Add(Me.btnCFCoke)
        Me.grpSelections.Controls.Add(Me.btnMonster)
        Me.grpSelections.Controls.Add(Me.btnOrangeVanillaCoke)
        Me.grpSelections.Controls.Add(Me.btnRootBeer)
        Me.grpSelections.Controls.Add(Me.btnCherryCoke)
        Me.grpSelections.Location = New System.Drawing.Point(11, 1)
        Me.grpSelections.Margin = New System.Windows.Forms.Padding(2)
        Me.grpSelections.Name = "grpSelections"
        Me.grpSelections.Padding = New System.Windows.Forms.Padding(2)
        Me.grpSelections.Size = New System.Drawing.Size(1017, 521)
        Me.grpSelections.TabIndex = 17
        Me.grpSelections.TabStop = False
        Me.grpSelections.Text = "Drink Selections"
        '
        'picLogo
        '
        Me.picLogo.BackColor = System.Drawing.Color.Transparent
        Me.picLogo.BackgroundImage = CType(resources.GetObject("picLogo.BackgroundImage"), System.Drawing.Image)
        Me.picLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.picLogo.Location = New System.Drawing.Point(21, 53)
        Me.picLogo.Name = "picLogo"
        Me.picLogo.Size = New System.Drawing.Size(372, 83)
        Me.picLogo.TabIndex = 30
        Me.picLogo.TabStop = False
        '
        'mnuStrip
        '
        Me.mnuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.EditToolStripMenuItem})
        Me.mnuStrip.Location = New System.Drawing.Point(2, 15)
        Me.mnuStrip.Name = "mnuStrip"
        Me.mnuStrip.Padding = New System.Windows.Forms.Padding(3, 1, 0, 1)
        Me.mnuStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.mnuStrip.Size = New System.Drawing.Size(1013, 24)
        Me.mnuStrip.TabIndex = 29
        Me.mnuStrip.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.BackColor = System.Drawing.Color.DimGray
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator1, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 22)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(177, 6)
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.BackColor = System.Drawing.Color.DimGray
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.BackColor = System.Drawing.Color.DimGray
        Me.EditToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuAddMoney, Me.CompletePurchaseToolStripMenuItem, Me.CancelToolStripMenuItem})
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(39, 22)
        Me.EditToolStripMenuItem.Text = "Edit"
        '
        'mnuAddMoney
        '
        Me.mnuAddMoney.BackColor = System.Drawing.Color.DimGray
        Me.mnuAddMoney.Name = "mnuAddMoney"
        Me.mnuAddMoney.Size = New System.Drawing.Size(180, 22)
        Me.mnuAddMoney.Text = "Add Money"
        '
        'CompletePurchaseToolStripMenuItem
        '
        Me.CompletePurchaseToolStripMenuItem.BackColor = System.Drawing.Color.DimGray
        Me.CompletePurchaseToolStripMenuItem.Name = "CompletePurchaseToolStripMenuItem"
        Me.CompletePurchaseToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.CompletePurchaseToolStripMenuItem.Text = "Complete Purchase"
        '
        'CancelToolStripMenuItem
        '
        Me.CancelToolStripMenuItem.BackColor = System.Drawing.Color.DimGray
        Me.CancelToolStripMenuItem.Name = "CancelToolStripMenuItem"
        Me.CancelToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.CancelToolStripMenuItem.Text = "Cancel Order"
        '
        'PaymentGroupBox
        '
        Me.PaymentGroupBox.BackColor = System.Drawing.Color.DimGray
        Me.PaymentGroupBox.Controls.Add(Me.grpPlaceHolderAesthetic)
        Me.PaymentGroupBox.Controls.Add(Me.CancelButton)
        Me.PaymentGroupBox.Controls.Add(Me.CompletePurchaseButton)
        Me.PaymentGroupBox.Controls.Add(Me.btnAddMoney)
        Me.PaymentGroupBox.Controls.Add(Me.AmountDueTextBox)
        Me.PaymentGroupBox.Controls.Add(Me.AmountDueLabel)
        Me.PaymentGroupBox.Controls.Add(Me.PurchaseAmountTextBox)
        Me.PaymentGroupBox.Controls.Add(Me.PurchaseAmountLabel)
        Me.PaymentGroupBox.Controls.Add(Me.AmtEnteredTextBox)
        Me.PaymentGroupBox.Controls.Add(Me.AmtEnteredLabel)
        Me.PaymentGroupBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PaymentGroupBox.ForeColor = System.Drawing.Color.Black
        Me.PaymentGroupBox.Location = New System.Drawing.Point(397, 41)
        Me.PaymentGroupBox.Margin = New System.Windows.Forms.Padding(2)
        Me.PaymentGroupBox.Name = "PaymentGroupBox"
        Me.PaymentGroupBox.Padding = New System.Windows.Forms.Padding(2)
        Me.PaymentGroupBox.Size = New System.Drawing.Size(218, 476)
        Me.PaymentGroupBox.TabIndex = 28
        Me.PaymentGroupBox.TabStop = False
        Me.PaymentGroupBox.Text = "Payment"
        '
        'CancelButton
        '
        Me.CancelButton.BackColor = System.Drawing.Color.DimGray
        Me.CancelButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CancelButton.ForeColor = System.Drawing.Color.Black
        Me.CancelButton.Location = New System.Drawing.Point(65, 323)
        Me.CancelButton.Margin = New System.Windows.Forms.Padding(2)
        Me.CancelButton.Name = "CancelButton"
        Me.CancelButton.Size = New System.Drawing.Size(85, 30)
        Me.CancelButton.TabIndex = 8
        Me.CancelButton.Text = "&Cancel"
        Me.CancelButton.UseVisualStyleBackColor = False
        '
        'CompletePurchaseButton
        '
        Me.CompletePurchaseButton.BackColor = System.Drawing.Color.DimGray
        Me.CompletePurchaseButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CompletePurchaseButton.ForeColor = System.Drawing.Color.Black
        Me.CompletePurchaseButton.Location = New System.Drawing.Point(65, 277)
        Me.CompletePurchaseButton.Margin = New System.Windows.Forms.Padding(2)
        Me.CompletePurchaseButton.Name = "CompletePurchaseButton"
        Me.CompletePurchaseButton.Size = New System.Drawing.Size(85, 34)
        Me.CompletePurchaseButton.TabIndex = 7
        Me.CompletePurchaseButton.Text = "Complete &Purchase"
        Me.CompletePurchaseButton.UseVisualStyleBackColor = False
        '
        'btnAddMoney
        '
        Me.btnAddMoney.BackColor = System.Drawing.Color.DimGray
        Me.btnAddMoney.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddMoney.ForeColor = System.Drawing.Color.Black
        Me.btnAddMoney.Location = New System.Drawing.Point(65, 235)
        Me.btnAddMoney.Margin = New System.Windows.Forms.Padding(2)
        Me.btnAddMoney.Name = "btnAddMoney"
        Me.btnAddMoney.Size = New System.Drawing.Size(85, 30)
        Me.btnAddMoney.TabIndex = 6
        Me.btnAddMoney.Text = "&Add Money"
        Me.btnAddMoney.UseVisualStyleBackColor = False
        '
        'AmountDueTextBox
        '
        Me.AmountDueTextBox.BackColor = System.Drawing.Color.Black
        Me.AmountDueTextBox.Enabled = False
        Me.AmountDueTextBox.ForeColor = System.Drawing.Color.SpringGreen
        Me.AmountDueTextBox.Location = New System.Drawing.Point(120, 107)
        Me.AmountDueTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.AmountDueTextBox.Name = "AmountDueTextBox"
        Me.AmountDueTextBox.ReadOnly = True
        Me.AmountDueTextBox.Size = New System.Drawing.Size(60, 20)
        Me.AmountDueTextBox.TabIndex = 5
        Me.AmountDueTextBox.TabStop = False
        '
        'AmountDueLabel
        '
        Me.AmountDueLabel.AutoSize = True
        Me.AmountDueLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AmountDueLabel.Location = New System.Drawing.Point(14, 110)
        Me.AmountDueLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.AmountDueLabel.Name = "AmountDueLabel"
        Me.AmountDueLabel.Size = New System.Drawing.Size(84, 13)
        Me.AmountDueLabel.TabIndex = 4
        Me.AmountDueLabel.Text = "Amount Due: "
        '
        'PurchaseAmountTextBox
        '
        Me.PurchaseAmountTextBox.BackColor = System.Drawing.Color.Black
        Me.PurchaseAmountTextBox.Enabled = False
        Me.PurchaseAmountTextBox.ForeColor = System.Drawing.Color.SpringGreen
        Me.PurchaseAmountTextBox.Location = New System.Drawing.Point(120, 70)
        Me.PurchaseAmountTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.PurchaseAmountTextBox.Name = "PurchaseAmountTextBox"
        Me.PurchaseAmountTextBox.ReadOnly = True
        Me.PurchaseAmountTextBox.Size = New System.Drawing.Size(60, 20)
        Me.PurchaseAmountTextBox.TabIndex = 3
        Me.PurchaseAmountTextBox.TabStop = False
        '
        'PurchaseAmountLabel
        '
        Me.PurchaseAmountLabel.AutoSize = True
        Me.PurchaseAmountLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PurchaseAmountLabel.Location = New System.Drawing.Point(12, 73)
        Me.PurchaseAmountLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.PurchaseAmountLabel.Name = "PurchaseAmountLabel"
        Me.PurchaseAmountLabel.Size = New System.Drawing.Size(114, 13)
        Me.PurchaseAmountLabel.TabIndex = 2
        Me.PurchaseAmountLabel.Text = "Purchase Amount: "
        '
        'AmtEnteredTextBox
        '
        Me.AmtEnteredTextBox.BackColor = System.Drawing.Color.Black
        Me.AmtEnteredTextBox.Enabled = False
        Me.AmtEnteredTextBox.ForeColor = System.Drawing.Color.SpringGreen
        Me.AmtEnteredTextBox.Location = New System.Drawing.Point(120, 32)
        Me.AmtEnteredTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.AmtEnteredTextBox.Name = "AmtEnteredTextBox"
        Me.AmtEnteredTextBox.ReadOnly = True
        Me.AmtEnteredTextBox.Size = New System.Drawing.Size(60, 20)
        Me.AmtEnteredTextBox.TabIndex = 1
        Me.AmtEnteredTextBox.TabStop = False
        '
        'AmtEnteredLabel
        '
        Me.AmtEnteredLabel.AutoSize = True
        Me.AmtEnteredLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AmtEnteredLabel.Location = New System.Drawing.Point(12, 36)
        Me.AmtEnteredLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.AmtEnteredLabel.Name = "AmtEnteredLabel"
        Me.AmtEnteredLabel.Size = New System.Drawing.Size(105, 13)
        Me.AmtEnteredLabel.TabIndex = 0
        Me.AmtEnteredLabel.Text = "Amount Entered: "
        '
        'MilkyWayLabel
        '
        Me.MilkyWayLabel.AutoSize = True
        Me.MilkyWayLabel.Location = New System.Drawing.Point(784, 461)
        Me.MilkyWayLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.MilkyWayLabel.Name = "MilkyWayLabel"
        Me.MilkyWayLabel.Size = New System.Drawing.Size(34, 13)
        Me.MilkyWayLabel.TabIndex = 27
        Me.MilkyWayLabel.Text = "$1.25"
        '
        'TwixLabel
        '
        Me.TwixLabel.AutoSize = True
        Me.TwixLabel.Location = New System.Drawing.Point(643, 461)
        Me.TwixLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.TwixLabel.Name = "TwixLabel"
        Me.TwixLabel.Size = New System.Drawing.Size(34, 13)
        Me.TwixLabel.TabIndex = 26
        Me.TwixLabel.Text = "$1.25"
        '
        'ReesesLabel
        '
        Me.ReesesLabel.AutoSize = True
        Me.ReesesLabel.Location = New System.Drawing.Point(338, 461)
        Me.ReesesLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.ReesesLabel.Name = "ReesesLabel"
        Me.ReesesLabel.Size = New System.Drawing.Size(34, 13)
        Me.ReesesLabel.TabIndex = 25
        Me.ReesesLabel.Text = "$1.25"
        '
        'SnickersLabel
        '
        Me.SnickersLabel.AutoSize = True
        Me.SnickersLabel.Location = New System.Drawing.Point(183, 461)
        Me.SnickersLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.SnickersLabel.Name = "SnickersLabel"
        Me.SnickersLabel.Size = New System.Drawing.Size(34, 13)
        Me.SnickersLabel.TabIndex = 24
        Me.SnickersLabel.Text = "$1.25"
        '
        'PopcornLabel
        '
        Me.PopcornLabel.AutoSize = True
        Me.PopcornLabel.Location = New System.Drawing.Point(784, 362)
        Me.PopcornLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.PopcornLabel.Name = "PopcornLabel"
        Me.PopcornLabel.Size = New System.Drawing.Size(34, 13)
        Me.PopcornLabel.TabIndex = 23
        Me.PopcornLabel.Text = "$1.25"
        '
        'CoolerRanchLabel
        '
        Me.CoolerRanchLabel.AutoSize = True
        Me.CoolerRanchLabel.Location = New System.Drawing.Point(643, 362)
        Me.CoolerRanchLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.CoolerRanchLabel.Name = "CoolerRanchLabel"
        Me.CoolerRanchLabel.Size = New System.Drawing.Size(34, 13)
        Me.CoolerRanchLabel.TabIndex = 22
        Me.CoolerRanchLabel.Text = "$1.25"
        '
        'NachoCheeseLabel
        '
        Me.NachoCheeseLabel.AutoSize = True
        Me.NachoCheeseLabel.Location = New System.Drawing.Point(338, 362)
        Me.NachoCheeseLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.NachoCheeseLabel.Name = "NachoCheeseLabel"
        Me.NachoCheeseLabel.Size = New System.Drawing.Size(34, 13)
        Me.NachoCheeseLabel.TabIndex = 21
        Me.NachoCheeseLabel.Text = "$1.25"
        '
        'SunChipsLabel
        '
        Me.SunChipsLabel.AutoSize = True
        Me.SunChipsLabel.Location = New System.Drawing.Point(183, 362)
        Me.SunChipsLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.SunChipsLabel.Name = "SunChipsLabel"
        Me.SunChipsLabel.Size = New System.Drawing.Size(34, 13)
        Me.SunChipsLabel.TabIndex = 20
        Me.SunChipsLabel.Text = "$1.25"
        '
        'MtnDewLabel
        '
        Me.MtnDewLabel.AutoSize = True
        Me.MtnDewLabel.Location = New System.Drawing.Point(784, 234)
        Me.MtnDewLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.MtnDewLabel.Name = "MtnDewLabel"
        Me.MtnDewLabel.Size = New System.Drawing.Size(34, 13)
        Me.MtnDewLabel.TabIndex = 19
        Me.MtnDewLabel.Text = "$1.25"
        '
        'DrPepperLabel
        '
        Me.DrPepperLabel.AutoSize = True
        Me.DrPepperLabel.Location = New System.Drawing.Point(643, 234)
        Me.DrPepperLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.DrPepperLabel.Name = "DrPepperLabel"
        Me.DrPepperLabel.Size = New System.Drawing.Size(34, 13)
        Me.DrPepperLabel.TabIndex = 18
        Me.DrPepperLabel.Text = "$1.25"
        '
        'DietCokeLabel
        '
        Me.DietCokeLabel.AutoSize = True
        Me.DietCokeLabel.Location = New System.Drawing.Point(338, 234)
        Me.DietCokeLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.DietCokeLabel.Name = "DietCokeLabel"
        Me.DietCokeLabel.Size = New System.Drawing.Size(34, 13)
        Me.DietCokeLabel.TabIndex = 17
        Me.DietCokeLabel.Text = "$1.25"
        '
        'CokeLabel
        '
        Me.CokeLabel.AutoSize = True
        Me.CokeLabel.Location = New System.Drawing.Point(183, 234)
        Me.CokeLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.CokeLabel.Name = "CokeLabel"
        Me.CokeLabel.Size = New System.Drawing.Size(34, 13)
        Me.CokeLabel.TabIndex = 16
        Me.CokeLabel.Text = "$1.25"
        '
        'btnDietCoke
        '
        Me.btnDietCoke.BackgroundImage = CType(resources.GetObject("btnDietCoke.BackgroundImage"), System.Drawing.Image)
        Me.btnDietCoke.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnDietCoke.Location = New System.Drawing.Point(317, 141)
        Me.btnDietCoke.Margin = New System.Windows.Forms.Padding(2)
        Me.btnDietCoke.Name = "btnDietCoke"
        Me.btnDietCoke.Size = New System.Drawing.Size(76, 82)
        Me.btnDietCoke.TabIndex = 1
        Me.btnDietCoke.UseVisualStyleBackColor = True
        '
        'btnCoke
        '
        Me.btnCoke.BackgroundImage = CType(resources.GetObject("btnCoke.BackgroundImage"), System.Drawing.Image)
        Me.btnCoke.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnCoke.Location = New System.Drawing.Point(165, 141)
        Me.btnCoke.Margin = New System.Windows.Forms.Padding(2)
        Me.btnCoke.Name = "btnCoke"
        Me.btnCoke.Size = New System.Drawing.Size(76, 82)
        Me.btnCoke.TabIndex = 0
        Me.btnCoke.UseVisualStyleBackColor = True
        '
        'btnCokeZero
        '
        Me.btnCokeZero.BackgroundImage = CType(resources.GetObject("btnCokeZero.BackgroundImage"), System.Drawing.Image)
        Me.btnCokeZero.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnCokeZero.Location = New System.Drawing.Point(622, 141)
        Me.btnCokeZero.Margin = New System.Windows.Forms.Padding(2)
        Me.btnCokeZero.Name = "btnCokeZero"
        Me.btnCokeZero.Size = New System.Drawing.Size(76, 82)
        Me.btnCokeZero.TabIndex = 2
        Me.btnCokeZero.UseVisualStyleBackColor = True
        '
        'btnSprite
        '
        Me.btnSprite.BackgroundImage = CType(resources.GetObject("btnSprite.BackgroundImage"), System.Drawing.Image)
        Me.btnSprite.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnSprite.Location = New System.Drawing.Point(766, 141)
        Me.btnSprite.Margin = New System.Windows.Forms.Padding(2)
        Me.btnSprite.Name = "btnSprite"
        Me.btnSprite.Size = New System.Drawing.Size(76, 82)
        Me.btnSprite.TabIndex = 3
        Me.btnSprite.UseVisualStyleBackColor = True
        '
        'btnFanta
        '
        Me.btnFanta.BackgroundImage = CType(resources.GetObject("btnFanta.BackgroundImage"), System.Drawing.Image)
        Me.btnFanta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnFanta.Location = New System.Drawing.Point(165, 271)
        Me.btnFanta.Margin = New System.Windows.Forms.Padding(2)
        Me.btnFanta.Name = "btnFanta"
        Me.btnFanta.Size = New System.Drawing.Size(76, 82)
        Me.btnFanta.TabIndex = 4
        Me.btnFanta.UseVisualStyleBackColor = True
        '
        'btnCremeSoda
        '
        Me.btnCremeSoda.BackgroundImage = CType(resources.GetObject("btnCremeSoda.BackgroundImage"), System.Drawing.Image)
        Me.btnCremeSoda.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnCremeSoda.Location = New System.Drawing.Point(767, 377)
        Me.btnCremeSoda.Margin = New System.Windows.Forms.Padding(2)
        Me.btnCremeSoda.Name = "btnCremeSoda"
        Me.btnCremeSoda.Size = New System.Drawing.Size(76, 82)
        Me.btnCremeSoda.TabIndex = 11
        Me.btnCremeSoda.UseVisualStyleBackColor = True
        '
        'btnDasani
        '
        Me.btnDasani.BackgroundImage = CType(resources.GetObject("btnDasani.BackgroundImage"), System.Drawing.Image)
        Me.btnDasani.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnDasani.Location = New System.Drawing.Point(317, 269)
        Me.btnDasani.Margin = New System.Windows.Forms.Padding(2)
        Me.btnDasani.Name = "btnDasani"
        Me.btnDasani.Size = New System.Drawing.Size(76, 82)
        Me.btnDasani.TabIndex = 5
        Me.btnDasani.UseVisualStyleBackColor = True
        '
        'btnCFCoke
        '
        Me.btnCFCoke.BackgroundImage = CType(resources.GetObject("btnCFCoke.BackgroundImage"), System.Drawing.Image)
        Me.btnCFCoke.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnCFCoke.Location = New System.Drawing.Point(622, 377)
        Me.btnCFCoke.Margin = New System.Windows.Forms.Padding(2)
        Me.btnCFCoke.Name = "btnCFCoke"
        Me.btnCFCoke.Size = New System.Drawing.Size(76, 82)
        Me.btnCFCoke.TabIndex = 10
        Me.btnCFCoke.UseVisualStyleBackColor = True
        '
        'btnMonster
        '
        Me.btnMonster.BackgroundImage = CType(resources.GetObject("btnMonster.BackgroundImage"), System.Drawing.Image)
        Me.btnMonster.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnMonster.Location = New System.Drawing.Point(622, 271)
        Me.btnMonster.Margin = New System.Windows.Forms.Padding(2)
        Me.btnMonster.Name = "btnMonster"
        Me.btnMonster.Size = New System.Drawing.Size(76, 82)
        Me.btnMonster.TabIndex = 6
        Me.btnMonster.UseVisualStyleBackColor = True
        '
        'btnOrangeVanillaCoke
        '
        Me.btnOrangeVanillaCoke.BackgroundImage = CType(resources.GetObject("btnOrangeVanillaCoke.BackgroundImage"), System.Drawing.Image)
        Me.btnOrangeVanillaCoke.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnOrangeVanillaCoke.Location = New System.Drawing.Point(317, 377)
        Me.btnOrangeVanillaCoke.Margin = New System.Windows.Forms.Padding(2)
        Me.btnOrangeVanillaCoke.Name = "btnOrangeVanillaCoke"
        Me.btnOrangeVanillaCoke.Size = New System.Drawing.Size(76, 82)
        Me.btnOrangeVanillaCoke.TabIndex = 9
        Me.btnOrangeVanillaCoke.UseVisualStyleBackColor = True
        '
        'btnRootBeer
        '
        Me.btnRootBeer.BackgroundImage = CType(resources.GetObject("btnRootBeer.BackgroundImage"), System.Drawing.Image)
        Me.btnRootBeer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnRootBeer.Location = New System.Drawing.Point(765, 269)
        Me.btnRootBeer.Margin = New System.Windows.Forms.Padding(2)
        Me.btnRootBeer.Name = "btnRootBeer"
        Me.btnRootBeer.Size = New System.Drawing.Size(76, 82)
        Me.btnRootBeer.TabIndex = 7
        Me.btnRootBeer.UseVisualStyleBackColor = True
        '
        'btnCherryCoke
        '
        Me.btnCherryCoke.BackgroundImage = CType(resources.GetObject("btnCherryCoke.BackgroundImage"), System.Drawing.Image)
        Me.btnCherryCoke.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnCherryCoke.Location = New System.Drawing.Point(165, 377)
        Me.btnCherryCoke.Margin = New System.Windows.Forms.Padding(2)
        Me.btnCherryCoke.Name = "btnCherryCoke"
        Me.btnCherryCoke.Size = New System.Drawing.Size(76, 82)
        Me.btnCherryCoke.TabIndex = 8
        Me.btnCherryCoke.UseVisualStyleBackColor = True
        '
        'grpPlaceHolderAesthetic
        '
        Me.grpPlaceHolderAesthetic.BackColor = System.Drawing.Color.Black
        Me.grpPlaceHolderAesthetic.Controls.Add(Me.lblPlaceHolder)
        Me.grpPlaceHolderAesthetic.Controls.Add(Me.txtPlaceholder)
        Me.grpPlaceHolderAesthetic.Controls.Add(Me.btnPlaceHolder5)
        Me.grpPlaceHolderAesthetic.Controls.Add(Me.btnPlaceHolder6)
        Me.grpPlaceHolderAesthetic.Controls.Add(Me.btnPlaceHolder4)
        Me.grpPlaceHolderAesthetic.Controls.Add(Me.btnPlaceHolder3)
        Me.grpPlaceHolderAesthetic.Controls.Add(Me.btnPlaceHolder2)
        Me.grpPlaceHolderAesthetic.Controls.Add(Me.btnPlaceHolder1)
        Me.grpPlaceHolderAesthetic.Enabled = False
        Me.grpPlaceHolderAesthetic.ForeColor = System.Drawing.Color.Lime
        Me.grpPlaceHolderAesthetic.Location = New System.Drawing.Point(5, 144)
        Me.grpPlaceHolderAesthetic.Name = "grpPlaceHolderAesthetic"
        Me.grpPlaceHolderAesthetic.Size = New System.Drawing.Size(208, 71)
        Me.grpPlaceHolderAesthetic.TabIndex = 9
        Me.grpPlaceHolderAesthetic.TabStop = False
        Me.grpPlaceHolderAesthetic.Text = "Money Screen"
        '
        'btnPlaceHolder1
        '
        Me.btnPlaceHolder1.BackColor = System.Drawing.Color.DimGray
        Me.btnPlaceHolder1.Enabled = False
        Me.btnPlaceHolder1.Location = New System.Drawing.Point(10, 20)
        Me.btnPlaceHolder1.Name = "btnPlaceHolder1"
        Me.btnPlaceHolder1.Size = New System.Drawing.Size(36, 10)
        Me.btnPlaceHolder1.TabIndex = 0
        Me.btnPlaceHolder1.Text = "Nickel"
        Me.btnPlaceHolder1.UseVisualStyleBackColor = False
        '
        'btnPlaceHolder2
        '
        Me.btnPlaceHolder2.BackColor = System.Drawing.Color.DimGray
        Me.btnPlaceHolder2.Enabled = False
        Me.btnPlaceHolder2.Location = New System.Drawing.Point(10, 30)
        Me.btnPlaceHolder2.Name = "btnPlaceHolder2"
        Me.btnPlaceHolder2.Size = New System.Drawing.Size(36, 10)
        Me.btnPlaceHolder2.TabIndex = 1
        Me.btnPlaceHolder2.Text = "Dime"
        Me.btnPlaceHolder2.UseVisualStyleBackColor = False
        '
        'btnPlaceHolder3
        '
        Me.btnPlaceHolder3.BackColor = System.Drawing.Color.DimGray
        Me.btnPlaceHolder3.Enabled = False
        Me.btnPlaceHolder3.Location = New System.Drawing.Point(10, 40)
        Me.btnPlaceHolder3.Name = "btnPlaceHolder3"
        Me.btnPlaceHolder3.Size = New System.Drawing.Size(36, 10)
        Me.btnPlaceHolder3.TabIndex = 2
        Me.btnPlaceHolder3.Text = "Quarter"
        Me.btnPlaceHolder3.UseVisualStyleBackColor = False
        '
        'btnPlaceHolder4
        '
        Me.btnPlaceHolder4.BackColor = System.Drawing.Color.DimGray
        Me.btnPlaceHolder4.Enabled = False
        Me.btnPlaceHolder4.Location = New System.Drawing.Point(10, 50)
        Me.btnPlaceHolder4.Name = "btnPlaceHolder4"
        Me.btnPlaceHolder4.Size = New System.Drawing.Size(36, 10)
        Me.btnPlaceHolder4.TabIndex = 3
        Me.btnPlaceHolder4.Text = "Dollar"
        Me.btnPlaceHolder4.UseVisualStyleBackColor = False
        '
        'btnPlaceHolder6
        '
        Me.btnPlaceHolder6.BackColor = System.Drawing.Color.DimGray
        Me.btnPlaceHolder6.Enabled = False
        Me.btnPlaceHolder6.Location = New System.Drawing.Point(85, 46)
        Me.btnPlaceHolder6.Name = "btnPlaceHolder6"
        Me.btnPlaceHolder6.Size = New System.Drawing.Size(36, 10)
        Me.btnPlaceHolder6.TabIndex = 4
        Me.btnPlaceHolder6.Text = "Cancel"
        Me.btnPlaceHolder6.UseVisualStyleBackColor = False
        '
        'btnPlaceHolder5
        '
        Me.btnPlaceHolder5.BackColor = System.Drawing.Color.DimGray
        Me.btnPlaceHolder5.Enabled = False
        Me.btnPlaceHolder5.Location = New System.Drawing.Point(85, 36)
        Me.btnPlaceHolder5.Name = "btnPlaceHolder5"
        Me.btnPlaceHolder5.Size = New System.Drawing.Size(36, 10)
        Me.btnPlaceHolder5.TabIndex = 5
        Me.btnPlaceHolder5.Text = "Add Money"
        Me.btnPlaceHolder5.UseVisualStyleBackColor = False
        '
        'txtPlaceholder
        '
        Me.txtPlaceholder.Enabled = False
        Me.txtPlaceholder.Location = New System.Drawing.Point(87, 22)
        Me.txtPlaceholder.Multiline = True
        Me.txtPlaceholder.Name = "txtPlaceholder"
        Me.txtPlaceholder.Size = New System.Drawing.Size(32, 10)
        Me.txtPlaceholder.TabIndex = 6
        '
        'lblPlaceHolder
        '
        Me.lblPlaceHolder.AutoSize = True
        Me.lblPlaceHolder.BackColor = System.Drawing.Color.Transparent
        Me.lblPlaceHolder.Location = New System.Drawing.Point(59, 10)
        Me.lblPlaceHolder.Name = "lblPlaceHolder"
        Me.lblPlaceHolder.Size = New System.Drawing.Size(90, 13)
        Me.lblPlaceHolder.TabIndex = 7
        Me.lblPlaceHolder.Text = "Amount to Add"
        '
        'VendingMachine
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Maroon
        Me.ClientSize = New System.Drawing.Size(1039, 533)
        Me.Controls.Add(Me.grpSelections)
        Me.Name = "VendingMachine"
        Me.Text = "Coco-Cola Vending Machine"
        Me.grpSelections.ResumeLayout(False)
        Me.grpSelections.PerformLayout()
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.mnuStrip.ResumeLayout(False)
        Me.mnuStrip.PerformLayout()
        Me.PaymentGroupBox.ResumeLayout(False)
        Me.PaymentGroupBox.PerformLayout()
        Me.grpPlaceHolderAesthetic.ResumeLayout(False)
        Me.grpPlaceHolderAesthetic.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents grpSelections As GroupBox
    Friend WithEvents MilkyWayLabel As Label
    Friend WithEvents TwixLabel As Label
    Friend WithEvents ReesesLabel As Label
    Friend WithEvents SnickersLabel As Label
    Friend WithEvents PopcornLabel As Label
    Friend WithEvents CoolerRanchLabel As Label
    Friend WithEvents NachoCheeseLabel As Label
    Friend WithEvents SunChipsLabel As Label
    Friend WithEvents MtnDewLabel As Label
    Friend WithEvents DrPepperLabel As Label
    Friend WithEvents DietCokeLabel As Label
    Friend WithEvents CokeLabel As Label
    Friend WithEvents btnDietCoke As Button
    Friend WithEvents btnCoke As Button
    Friend WithEvents btnCokeZero As Button
    Friend WithEvents btnSprite As Button
    Friend WithEvents btnFanta As Button
    Friend WithEvents btnCremeSoda As Button
    Friend WithEvents btnDasani As Button
    Friend WithEvents btnCFCoke As Button
    Friend WithEvents btnMonster As Button
    Friend WithEvents btnOrangeVanillaCoke As Button
    Friend WithEvents btnRootBeer As Button
    Friend WithEvents btnCherryCoke As Button
    Friend WithEvents mnuStrip As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents mnuAddMoney As ToolStripMenuItem
    Friend WithEvents CompletePurchaseToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CancelToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PaymentGroupBox As GroupBox
    Friend WithEvents CancelButton As Button
    Friend WithEvents CompletePurchaseButton As Button
    Friend WithEvents btnAddMoney As Button
    Friend WithEvents AmountDueTextBox As TextBox
    Friend WithEvents AmountDueLabel As Label
    Friend WithEvents PurchaseAmountTextBox As TextBox
    Friend WithEvents PurchaseAmountLabel As Label
    Friend WithEvents AmtEnteredTextBox As TextBox
    Friend WithEvents AmtEnteredLabel As Label
    Friend WithEvents picLogo As PictureBox
    Friend WithEvents grpPlaceHolderAesthetic As GroupBox
    Friend WithEvents btnPlaceHolder1 As Button
    Friend WithEvents btnPlaceHolder4 As Button
    Friend WithEvents btnPlaceHolder3 As Button
    Friend WithEvents btnPlaceHolder2 As Button
    Friend WithEvents btnPlaceHolder5 As Button
    Friend WithEvents btnPlaceHolder6 As Button
    Friend WithEvents txtPlaceholder As TextBox
    Friend WithEvents lblPlaceHolder As Label
End Class
