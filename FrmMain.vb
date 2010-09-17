Public Class FrmMain

    Private Sub btnRates_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRates.Click
        
        Dim fmtStr As String = "{0,-22}{1,-15}{2,-10}"

        'Displays rental rates
        lstPrice.Items.Add(String.Format(fmtStr, "Price of Equipment", "Half-day", "Full-day"))
        lstPrice.Items.Add(String.Format(fmtStr, "1. Rug cleaner", "$16.00", "$24.00"))
        lstPrice.Items.Add(String.Format(fmtStr, "2. Lawn mower", "$12.00", "$18.00"))
        lstPrice.Items.Add(String.Format(fmtStr, "3. Paint sprayer", "$20.00", "$30.00"))

    End Sub

    Private Sub btnBill_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBill.Click

        Dim strLetter As String = txtDuration.Text.ToUpper
        Dim intNum As Integer = CInt(txtItem.Text)
        Dim fmtStr As String = "{0,-14}{1,10}{2,20}"
        Dim fmtDps As String = "{0,-14}{1,10}"

        'Resets list box and adds title to list box
        lstReceipt.Items.Clear()
        lstReceipt.Items.Add("Receipt from Eddie's Equipment Rental")
        lstReceipt.Items.Add("")


        'Diplays receipt from txtItem and txtDuration inputs
        Try
            If intNum = 1 And strLetter = "H" Then
                lstReceipt.Items.Add(String.Format(fmtStr, "Rug cleaner", "$16.00", "(Half day rental)"))
                lstReceipt.Items.Add(String.Format(fmtDps, "Deposit", "$30.00"))
                lstReceipt.Items.Add("")
                lstReceipt.Items.Add(String.Format(fmtDps, "Total", FormatCurrency(30 + 16)))
            Else
                If intNum = 1 And strLetter = "F" Then
                    lstReceipt.Items.Add(String.Format(fmtStr, "Rug cleaner", "$24.00", "(Full day rental)"))
                    lstReceipt.Items.Add(String.Format(fmtDps, "Deposit", "$30.00"))
                    lstReceipt.Items.Add("")
                    lstReceipt.Items.Add(String.Format(fmtDps, "Total", FormatCurrency(30 + 24)))
                Else
                    If intNum = 2 And strLetter = "H" Then
                        lstReceipt.Items.Add(String.Format(fmtStr, "Lawn mower", "$12.00", "(Half day rental)"))
                        lstReceipt.Items.Add(String.Format(fmtDps, "Deposit", "$30.00"))
                        lstReceipt.Items.Add("")
                        lstReceipt.Items.Add(String.Format(fmtDps, "Total", FormatCurrency(30 + 12)))
                    Else
                        If intNum = 2 And strLetter = "F" Then
                            lstReceipt.Items.Add(String.Format(fmtStr, "Lawn mower", "$18.00", "(Full day rental)"))
                            lstReceipt.Items.Add(String.Format(fmtDps, "Deposit", "$30.00"))
                            lstReceipt.Items.Add("")
                            lstReceipt.Items.Add(String.Format(fmtDps, "Total", FormatCurrency(30 + 18)))
                        Else
                            If intNum = 3 And strLetter = "H" Then
                                lstReceipt.Items.Add(String.Format(fmtStr, "Paint sprayer", "$20.00", "(Half day rental)"))
                                lstReceipt.Items.Add(String.Format(fmtDps, "Deposit", "$30.00"))
                                lstReceipt.Items.Add("")
                                lstReceipt.Items.Add(String.Format(fmtDps, "Total", FormatCurrency(30 + 20)))
                            Else
                                If intNum = 3 And strLetter = "F" Then
                                    lstReceipt.Items.Add(String.Format(fmtStr, "Paint sprayer", "$30.00", "(Full day rental)"))
                                    lstReceipt.Items.Add(String.Format(fmtDps, "Deposit", "$30.00"))
                                    lstReceipt.Items.Add("")
                                    lstReceipt.Items.Add(String.Format(fmtDps, "Total", FormatCurrency(30 + 30)))
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        Catch ex As InvalidCastException
            MessageBox.Show("Invalid Data")
        Catch ex As Exception
            MessageBox.Show("Error occurred")
        End Try

    End Sub
End Class
