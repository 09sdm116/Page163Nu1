<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMain
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
        Me.btnRates = New System.Windows.Forms.Button()
        Me.btnBill = New System.Windows.Forms.Button()
        Me.lblItem = New System.Windows.Forms.Label()
        Me.lblDuration = New System.Windows.Forms.Label()
        Me.txtItem = New System.Windows.Forms.TextBox()
        Me.txtDuration = New System.Windows.Forms.TextBox()
        Me.lstPrice = New System.Windows.Forms.ListBox()
        Me.lstReceipt = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'btnRates
        '
        Me.btnRates.Location = New System.Drawing.Point(66, 12)
        Me.btnRates.Name = "btnRates"
        Me.btnRates.Size = New System.Drawing.Size(155, 39)
        Me.btnRates.TabIndex = 0
        Me.btnRates.Text = "Display Rental Rates"
        Me.btnRates.UseVisualStyleBackColor = True
        '
        'btnBill
        '
        Me.btnBill.Location = New System.Drawing.Point(80, 194)
        Me.btnBill.Name = "btnBill"
        Me.btnBill.Size = New System.Drawing.Size(138, 35)
        Me.btnBill.TabIndex = 1
        Me.btnBill.Text = "Display Customer Bill"
        Me.btnBill.UseVisualStyleBackColor = True
        '
        'lblItem
        '
        Me.lblItem.AutoSize = True
        Me.lblItem.Location = New System.Drawing.Point(80, 70)
        Me.lblItem.Name = "lblItem"
        Me.lblItem.Size = New System.Drawing.Size(129, 13)
        Me.lblItem.TabIndex = 2
        Me.lblItem.Text = "Select an Item (1, 2, or 3):"
        '
        'lblDuration
        '
        Me.lblDuration.AutoSize = True
        Me.lblDuration.Location = New System.Drawing.Point(80, 115)
        Me.lblDuration.Name = "lblDuration"
        Me.lblDuration.Size = New System.Drawing.Size(125, 13)
        Me.lblDuration.TabIndex = 3
        Me.lblDuration.Text = "Select a duration (H or F)"
        '
        'txtItem
        '
        Me.txtItem.Location = New System.Drawing.Point(215, 66)
        Me.txtItem.Name = "txtItem"
        Me.txtItem.Size = New System.Drawing.Size(27, 20)
        Me.txtItem.TabIndex = 4
        '
        'txtDuration
        '
        Me.txtDuration.Location = New System.Drawing.Point(215, 111)
        Me.txtDuration.Name = "txtDuration"
        Me.txtDuration.Size = New System.Drawing.Size(27, 20)
        Me.txtDuration.TabIndex = 5
        '
        'lstPrice
        '
        Me.lstPrice.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstPrice.FormattingEnabled = True
        Me.lstPrice.ItemHeight = 14
        Me.lstPrice.Location = New System.Drawing.Point(286, 13)
        Me.lstPrice.Name = "lstPrice"
        Me.lstPrice.Size = New System.Drawing.Size(357, 74)
        Me.lstPrice.TabIndex = 6
        '
        'lstReceipt
        '
        Me.lstReceipt.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstReceipt.FormattingEnabled = True
        Me.lstReceipt.ItemHeight = 14
        Me.lstReceipt.Location = New System.Drawing.Point(286, 129)
        Me.lstReceipt.Name = "lstReceipt"
        Me.lstReceipt.Size = New System.Drawing.Size(357, 102)
        Me.lstReceipt.TabIndex = 7
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(684, 262)
        Me.Controls.Add(Me.lstReceipt)
        Me.Controls.Add(Me.lstPrice)
        Me.Controls.Add(Me.txtDuration)
        Me.Controls.Add(Me.txtItem)
        Me.Controls.Add(Me.lblDuration)
        Me.Controls.Add(Me.lblItem)
        Me.Controls.Add(Me.btnBill)
        Me.Controls.Add(Me.btnRates)
        Me.Name = "Form1"
        Me.Text = "Welcome to Eddie's Equipment Rental"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnRates As System.Windows.Forms.Button
    Friend WithEvents btnBill As System.Windows.Forms.Button
    Friend WithEvents lblItem As System.Windows.Forms.Label
    Friend WithEvents lblDuration As System.Windows.Forms.Label
    Friend WithEvents txtItem As System.Windows.Forms.TextBox
    Friend WithEvents txtDuration As System.Windows.Forms.TextBox
    Friend WithEvents lstPrice As System.Windows.Forms.ListBox
    Friend WithEvents lstReceipt As System.Windows.Forms.ListBox

End Class
