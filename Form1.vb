Public Class frmAirBnBRes

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnDisplayCost.Click
        Dim strNumNights As String
        strNumNights = txtNights.Text

        Dim intNumNights As Integer
        intNumNights = Convert.ToInt32(strNumNights)

        Dim decTotalCost As Decimal

        Dim cdecCostPerNight As Decimal
        cdecCostPerNight = 79D

        decTotalCost = intNumNights _
                        * cdecCostPerNight

        lblCostofStay.Text = decTotalCost.ToString("C")
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Close()
    End Sub

    Private Sub txtNights_TextChanged(sender As Object, e As EventArgs) Handles txtNights.TextChanged

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtNights.Clear()
        lblCostofStay.Text = ""
        txtNights.Focus()
    End Sub
End Class
