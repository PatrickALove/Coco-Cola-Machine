Public Class OnBoardScreen
    Friend moneyAdded As Decimal
    Private moneyToAdd As Decimal

    Public Property MoneyToAdd1 As Decimal
        Get
            Return moneyToAdd
        End Get
        Set(value As Decimal)
            moneyToAdd = value
        End Set
    End Property

    Private Sub btnNickel_Click(sender As Object, e As EventArgs) Handles btnNickel.Click
        'Add a nickel to the total
        VendingMachine.nickels += 1
        MoneyToAdd1 += 0.05
        'Display the amount to add in the text box
        AddAmountTextBox.Text = MoneyToAdd1.ToString("C")
    End Sub

    Private Sub BtnDime_Click(sender As Object, e As EventArgs) Handles btnDime.Click
        'Add a dime to the total
        VendingMachine.dimes += 1
        MoneyToAdd1 += 0.1
        'Display the amount to add in the text box
        AddAmountTextBox.Text = MoneyToAdd1.ToString("C")
    End Sub

    Private Sub BtnQuarter_Click(sender As Object, e As EventArgs) Handles btnQuarter.Click
        'add a quarter to the total
        VendingMachine.quarters += 1
        MoneyToAdd1 += 0.25
        'Display the amount to add in the text box
        AddAmountTextBox.Text = MoneyToAdd1.ToString("C")
    End Sub

    Private Sub BtnDollar_Click(sender As Object, e As EventArgs) Handles btnDollar.Click
        'add a dollar to the total
        VendingMachine.dollarBills += 1
        MoneyToAdd1 += 1.0
        'Display the amount to add in the text box
        AddAmountTextBox.Text = MoneyToAdd1.ToString("C")
    End Sub

    Private Sub AddMoneyButton_Click(sender As Object, e As EventArgs) Handles AddMoneyButton.Click
        'add the money to the be used in the purchase
        Dim result As DialogResult
        If MoneyToAdd1 <= 10.0 Then
            result = MessageBox.Show("Do you want to add " & MoneyToAdd1.ToString("C") & " to the vending Machine?",
                                         "Add Money", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If result = Windows.Forms.DialogResult.Yes Then
                VendingMachine.AddMoney(MoneyToAdd1)
                AddAmountTextBox.Clear()
                Me.Hide()
            End If
            'reset the money to add
            MoneyToAdd1 = 0
        Else
            MessageBox.Show("This machine only accepts up to $10", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            CancelButton.PerformClick()

        End If

    End Sub

    Private Sub CancelButton_Click(sender As Object, e As EventArgs) Handles CancelButton.Click
        'cancels the input of money
        Dim result As DialogResult

        result = MessageBox.Show(MoneyToAdd1.ToString("C") & " will be refunded" & Environment.NewLine &
                                 "Do you want to cancel adding money?", "Cancel Add Money", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = Windows.Forms.DialogResult.Yes Then
            VendingMachine.CalChg(MoneyToAdd1)
            MoneyToAdd1 = 0
            AddAmountTextBox.Clear()
            Me.Hide()
        End If

    End Sub


End Class