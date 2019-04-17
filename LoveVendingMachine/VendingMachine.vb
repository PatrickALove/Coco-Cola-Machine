'Author:                      Patrick Love
'Date Created:                4/16/2019
'Program:                     Drink Vending Machine

'Description:                 From a window on the screen, the user will click buttons
'                             to simulate money being entered into the machine.  When 
'                             enough money has been accepted by the machine Then the user
'                             make his/her drink selection.

Public Class VendingMachine
    Structure Purchase
        Dim ttlDue As Decimal
        Dim amtPaid As Decimal
        Dim difference As Decimal
        Dim numOfItems As Integer
    End Structure
    Structure Drink
        Dim item As String
        Dim price As Decimal
        Dim amount As Integer
    End Structure
    'Declare constants
    Const SODA_PRICE As Decimal = 1.25
    Private Const V As String = "Vended Drinks"

    'Declare variables
    'Pre load the vending machine with $20 in each USD type
    Friend nickels As Integer = 400
    Friend dimes As Integer = 200
    '$40 for quarters
    Friend quarters As Integer = 240
    '$60 for dollar bills
    Friend dollarBills As Integer = 60
    'Keep track of the number of orders
    Friend orderCount As Integer               'keeps track of the number of orders
    Private drinkCount As Integer               'keeps track of the number of items in an order
    Private moneyTracker As Decimal            'keeps track of the amount of money put in for refunds
    Friend moneyInserted As Decimal            'keeps track of the amount of money put into the machine
    Friend totalMoney As Decimal               'Keeps track of the total amount of money in the machine
    Private priceArray(4) As Decimal           'an array containing the prices for the items
    Friend vendingArray(4, 4) As Drink         'an array containing the inventory of the vending machine
    Friend itemArray(5) As Drink               'an array that holds each item in an order (max 5)
    Friend orderArray(20) As Purchase          'an array containing up to 20 orders

    Public Shared ReadOnly Property V1 As String
        Get
            Return V
        End Get
    End Property

    'test
    Private Sub VendingForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' Change the color of the menu strip items upon loading
        mnuStrip.BackColor = Color.DimGray
        FileToolStripMenuItem.BackColor = Color.DimGray
        ExitToolStripMenuItem.BackColor = Color.DimGray
        'load the capital
        moneyTracker = (nickels * 0.05) + (dimes * 0.1) + (quarters * 0.25) + dollarBills
        totalMoney = moneyTracker
        'load the inventory with a base of 10 items each
        loadVendingMachine(10)
    End Sub

    Private Sub loadVendingMachine(ByVal numOfItems As Integer)
        'loads the vendingArray with the items

        'initialize all drinks
        Dim coke As New Drink With {
            .item = "Coke",
            .price = SODA_PRICE,
            .amount = numOfItems
        }
        Dim dietCoke As New Drink With {
            .item = "Diet Coke",
            .price = SODA_PRICE,
            .amount = numOfItems
        }
        Dim cokezero As New Drink With {
            .item = "Coke Zero",
            .price = SODA_PRICE,
            .amount = numOfItems
        }
        Dim sprite As New Drink With {
            .item = "Sprite",
            .price = SODA_PRICE,
            .amount = numOfItems
        }
        Dim fanta As New Drink With {
            .item = "Fanta",
            .price = SODA_PRICE,
            .amount = numOfItems
        }
        Dim Dasani As New Drink With {
            .item = "Dasani",
            .price = SODA_PRICE,
            .amount = numOfItems
        }
        Dim monster As New Drink With {
            .item = "Monster",
            .price = SODA_PRICE,
            .amount = numOfItems
        }
        Dim rootbeer As New Drink With {
            .item = "Root Beer",
            .price = SODA_PRICE,
            .amount = numOfItems
        }
        Dim orangevanilla As New Drink With {
            .item = "Orange Vanilla Coke",
            .price = SODA_PRICE,
            .amount = numOfItems
        }
        Dim cherrycoke As New Drink With {
            .item = "Cherry Coke",
            .price = SODA_PRICE,
            .amount = numOfItems
        }
        Dim cfcoke As New Drink With {
            .item = "Caffeine Free Coke",
            .price = SODA_PRICE,
            .amount = numOfItems
        }
        Dim cremesoda As New Drink With {
            .item = "Creme Soda",
            .price = SODA_PRICE,
            .amount = numOfItems
        }
        Dim placeHolder As New Drink With {
            .item = "Place Holder Item",
            .price = SODA_PRICE,
            .amount = numOfItems
        }

        'fill the vendingArray
        vendingArray = {{coke, dietCoke, cokezero, sprite}, {fanta, Dasani, monster, rootbeer},
                         {cherrycoke, orangevanilla, cfcoke, cremesoda}, {placeHolder, placeHolder, placeHolder, placeHolder}}
    End Sub

    Private Sub AddItem(ByRef item As Drink)
        'add the item to the order array
        Dim itemString As String = item.item
        If drinkCount < 5 Then
            For i As Integer = 0 To 3
                For j As Integer = 0 To 3
                    If vendingArray(i, j).item = itemString Then
                        If vendingArray(i, j).amount > 0 Then
                            orderArray(orderCount).ttlDue += item.price
                            orderArray(orderCount).numOfItems += 1
                            itemArray(drinkCount) = item
                            drinkCount += 1
                        Else
                            MessageBox.Show(vendingArray(i, j).item & " is Sold Out" & Environment.NewLine &
                                            "Please select another drink", " That Drink Is Sold Out", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        End If
                    End If

                Next j
            Next i
        Else
            MessageBox.Show("Orders are limited to 5 items per order", "Order Full", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        'display the running total
        PurchaseAmountTextBox.Text = orderArray(orderCount).ttlDue.ToString("C")
    End Sub
    Private Sub BtnCoke_Click(sender As Object, e As EventArgs) Handles btnCoke.Click
        'add a coke to the order
        AddItem(vendingArray(0, 0))

    End Sub
    Private Sub BtnDietCoke_Click(sender As Object, e As EventArgs) Handles btnDietCoke.Click
        'add a diet coke to the order array
        AddItem(vendingArray(0, 1))
    End Sub

    Private Sub BtnCokeZero_Click(sender As Object, e As EventArgs) Handles btnCokeZero.Click
        'add a Coke Zero to the order array
        AddItem(vendingArray(0, 2))
    End Sub

    Private Sub BtnSprite_Click(sender As Object, e As EventArgs) Handles btnSprite.Click
        'add a Sprite to the order array
        AddItem(vendingArray(0, 3))
    End Sub

    Private Sub BtnFanta_Click(sender As Object, e As EventArgs) Handles btnFanta.Click
        'add a Fanta to the order array
        AddItem(vendingArray(1, 0))
    End Sub

    Private Sub BtnDasani_Click(sender As Object, e As EventArgs) Handles btnDasani.Click
        'add a Dasani water to the order array
        AddItem(vendingArray(1, 1))
    End Sub

    Private Sub BtnMonster_Click(sender As Object, e As EventArgs) Handles btnMonster.Click
        'add a Monster energy drink to the order array
        AddItem(vendingArray(1, 2))
    End Sub

    Private Sub BtnRootBeer_Click(sender As Object, e As EventArgs) Handles btnRootBeer.Click
        'add a Root Beer to the order array
        AddItem(vendingArray(1, 3))
    End Sub

    Private Sub BtnCherryCoke_Click(sender As Object, e As EventArgs) Handles btnCherryCoke.Click
        'add a Cherry Coke to the order array
        AddItem(vendingArray(2, 0))
    End Sub

    Private Sub BtnOrangeVanillaCoke_Click(sender As Object, e As EventArgs) Handles btnOrangeVanillaCoke.Click
        'add a new Orange Vanilla Coke to the order array
        AddItem(vendingArray(2, 1))
    End Sub

    Private Sub BtnCFCoke_Click(sender As Object, e As EventArgs) Handles btnCFCoke.Click
        'add a Caffiene FREE Coke to the order array
        AddItem(vendingArray(2, 2))
    End Sub

    Private Sub BtnCremeSoda_Click(sender As Object, e As EventArgs) Handles btnCremeSoda.Click
        'add a Creme Soda to the order array
        AddItem(vendingArray(2, 3))
    End Sub

    Private Sub BtnAddMoney_Click(sender As Object, e As EventArgs) Handles btnAddMoney.Click, mnuAddMoney.Click
        'Display the add money form upon clicking the AddMoneyButton
        OnBoardScreen.Show()
    End Sub

    Public Sub AddMoney(ByVal moneyToAdd As Decimal)
        'add the users money to the vending machine
        ' this allows the text boxes to update
        AmtEnteredTextBox.Text = moneyToAdd.ToString("C")
        orderArray(orderCount).amtPaid += moneyToAdd
        CalDif()

    End Sub

    Private Sub CalDif()
        'calculate the difference and display it in the text box
        orderArray(orderCount).difference = orderArray(orderCount).ttlDue - orderArray(orderCount).amtPaid
        AmountDueTextBox.Text = orderArray(orderCount).difference.ToString("C")
    End Sub
    Private Sub CancelButton_Click(sender As Object, e As EventArgs) Handles CancelButton.Click, CancelToolStripMenuItem.Click
        'cancels the order
        Dim message As String
        Dim result As DialogResult

        result = MessageBox.Show("Cancel the Order?", "Cancel", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = Windows.Forms.DialogResult.Yes Then
            message = orderArray(orderCount).amtPaid.ToString("C") & " will be refunded"
            MessageBox.Show(message, "Order Cancelled", MessageBoxButtons.OK, MessageBoxIcon.Information)
            With orderArray(orderCount)
                CalChg(.amtPaid)
                .amtPaid = 0
                .ttlDue = 0
                .difference = 0
            End With

            'clear the form
            ClearForm()


        End If

    End Sub

    Private Sub CompletePurchaseButton_Click(sender As Object, e As EventArgs) Handles CompletePurchaseButton.Click, CompletePurchaseToolStripMenuItem.Click
        'Complete the purchase, adjust inventory and issue a refund if there is any
        'Make sure there is at least one item in the order
        If orderArray(orderCount).ttlDue <> 0 Or orderArray(orderCount).amtPaid <> 0 Then
            'Call calcDifference to account for if they didn't add any money
            CalDif()
            'Make sure the customer put in enough money to pay
            If orderArray(orderCount).difference <= 0 Then
                CalChg(orderArray(orderCount).difference * -1)
                'Remove the items from the inventory
                For i As Integer = 0 To 3
                    For j As Integer = 0 To 3
                        For k As Integer = 0 To drinkCount - 1

                            If vendingArray(i, j).item = itemArray(k).item Then

                                vendingArray(i, j).amount -= 1

                            End If
                        Next k
                    Next j
                Next i

                'Vend the drinks
                VendDrinks()
                'Add the money to the total
                totalMoney += orderArray(orderCount).amtPaid - (orderArray(orderCount).difference * -1)
                moneyInserted = totalMoney - moneyTracker

                'Increase the count to start a new order and clear the form
                orderCount += 1
                ClearForm()
                'clear the order's drink array for the next order
                System.Array.Clear(itemArray, 0, 5)


            Else
                MessageBox.Show("Please insert " & orderArray(orderCount).difference.ToString("C") & " to complete your purchase",
                                "Insufficient Funds", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            End If

        Else
            MessageBox.Show("Please select an drink or enter money to continue", "No Order", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If


    End Sub

    Private Sub VendDrinks()
        'Show the user what drinks they bought
        Dim Message As String
        Message = V1 & Environment.NewLine
        For i As Integer = 0 To drinkCount - 1
            If itemArray(i).item <> "" Then
                Message += itemArray(i).item & Environment.NewLine
            End If
        Next i

        MessageBox.Show(Message, "Vending Drinks", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub ClearForm()
        'clear the text boxes
        AmtEnteredTextBox.Clear()
        PurchaseAmountTextBox.Clear()
        AmountDueTextBox.Clear()
        'reset the drink count
        drinkCount = 0
    End Sub
    Public Sub CalChg(ByVal money As Decimal)
        'calculate the amounts to return for the change
        Dim refundNickels, refundDimes, refundQuarters, refundDollars As Integer
        Dim moneyCalc As Integer
        Dim origMoney As Decimal = money
        'multiply money by 100 to make it easier to calculate
        moneyCalc = money * 100

        If moneyCalc \ 100 > 0 Then
            refundDollars = moneyCalc \ 100
            dollarBills -= refundDollars
            moneyCalc -= 100 * refundDollars
            money -= refundDollars
        End If

        If moneyCalc \ 25 > 0 Then
            refundQuarters = moneyCalc \ 25
            quarters -= refundQuarters
            moneyCalc -= 25 * refundQuarters
            money -= 0.25 * refundQuarters
        End If
        If moneyCalc \ 10 > 0 Then
            refundDimes = moneyCalc \ 10
            dimes -= refundDimes
            moneyCalc -= 10 * refundDimes
            money -= 0.1 * refundDimes
        End If
        If moneyCalc \ 5 > 0 Then
            refundNickels = moneyCalc \ 5
            nickels -= refundNickels
            moneyCalc -= 5 * refundNickels
            money -= 0.05 * refundNickels
        End If
        Dim message As String
        message = "You are getting back: " & origMoney.ToString("C") & Environment.NewLine _
                  & refundNickels.ToString & " Nickels" & Environment.NewLine & refundDimes.ToString & " Dimes" _
                  & Environment.NewLine & refundQuarters.ToString & " Quarters" & Environment.NewLine _
                  & refundDollars.ToString & " Dollar Bills"
        MessageBox.Show(message, "Change", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        'Exits the program
        Me.Close()
    End Sub

    Private Sub AddMoneyButton_Click(sender As Object, e As EventArgs)

    End Sub
End Class
