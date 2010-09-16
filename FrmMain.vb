Public Class FrmMain

    Private Sub btnRates_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRates.Click
        Dim intNum As Integer

        Dim fmtStr As String = "{0,-22}{1,-15}{2,-10}"
        lstPrice.Items.Add(String.Format(fmtStr, "Price of Equipment", "Half-day", "Full-day"))
        lstPrice.Items.Add(String.Format(fmtStr, "1. Rug cleaner", "$16.00", "$24.00"))
        lstPrice.Items.Add(String.Format(fmtStr, "2. Lawn mower", "$12.00", "$18.00"))
        lstPrice.Items.Add(String.Format(fmtStr, "3. Paint sprayer", "$20.00", "$30.00"))
    End Sub
End Class
