Public Class frmMain
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtNumberTickets.Text = ""
        lblCost.Text = ""
        radZone1Thru3.Checked = True
        radZones1Thru5.Checked = False
        radZones1Thru6.Checked = False
    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        ' Validate number of tickets
        If (String.IsNullOrEmpty(txtNumberTickets.Text) Or Not IsNumeric(txtNumberTickets.Text)) Then
            MsgBox("Invalid number of tickets. Try again.")
        ElseIf (txtNumberTickets.Text < 1) Then
            MsgBox("Number of tickets must be a positive number. Try again.")
        Else
            ' Exchange rate - Dollars per British Pound
            Dim decExchangeRate As Decimal = 1.18435

            Dim intNumTickets As Integer = txtNumberTickets.Text
            Dim decCostPerTicket As Decimal = 0.0
            Dim decTotalCost As Decimal = 0.0

            ' Determine zone
            If (radZone1Thru3.Checked = True) Then
                decCostPerTicket = 4.9 * decExchangeRate
            ElseIf (radZones1Thru5.Checked = True) Then
                decCostPerTicket = 5.9 * decExchangeRate
            ElseIf (radZones1Thru6.Checked = True) Then
                decCostPerTicket = 6.0 * decExchangeRate
            End If

            ' Calculate total cost
            decTotalCost = decCostPerTicket * intNumTickets
            lblCost.Text = decTotalCost.ToString("C2")
        End If
    End Sub
End Class
