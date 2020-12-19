<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.radZone1Thru3 = New System.Windows.Forms.RadioButton()
        Me.radZones1Thru5 = New System.Windows.Forms.RadioButton()
        Me.radZones1Thru6 = New System.Windows.Forms.RadioButton()
        Me.lblNumberTickets = New System.Windows.Forms.Label()
        Me.txtNumberTickets = New System.Windows.Forms.TextBox()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.lblTotalCost = New System.Windows.Forms.Label()
        Me.lblCost = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Bookman Old Style", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(98, 9)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(311, 32)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "London Tube Tickets"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel1.Controls.Add(Me.radZones1Thru6)
        Me.Panel1.Controls.Add(Me.radZones1Thru5)
        Me.Panel1.Controls.Add(Me.radZone1Thru3)
        Me.Panel1.Location = New System.Drawing.Point(195, 146)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(100, 82)
        Me.Panel1.TabIndex = 1
        '
        'radZone1Thru3
        '
        Me.radZone1Thru3.AutoSize = True
        Me.radZone1Thru3.Checked = True
        Me.radZone1Thru3.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radZone1Thru3.Location = New System.Drawing.Point(4, 4)
        Me.radZone1Thru3.Name = "radZone1Thru3"
        Me.radZone1Thru3.Size = New System.Drawing.Size(92, 20)
        Me.radZone1Thru3.TabIndex = 0
        Me.radZone1Thru3.Text = "Zones 1-3"
        Me.radZone1Thru3.UseVisualStyleBackColor = True
        '
        'radZones1Thru5
        '
        Me.radZones1Thru5.AutoSize = True
        Me.radZones1Thru5.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radZones1Thru5.Location = New System.Drawing.Point(4, 30)
        Me.radZones1Thru5.Name = "radZones1Thru5"
        Me.radZones1Thru5.Size = New System.Drawing.Size(91, 20)
        Me.radZones1Thru5.TabIndex = 1
        Me.radZones1Thru5.Text = "Zones 1-5"
        Me.radZones1Thru5.UseVisualStyleBackColor = True
        '
        'radZones1Thru6
        '
        Me.radZones1Thru6.AutoSize = True
        Me.radZones1Thru6.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radZones1Thru6.Location = New System.Drawing.Point(4, 56)
        Me.radZones1Thru6.Name = "radZones1Thru6"
        Me.radZones1Thru6.Size = New System.Drawing.Size(91, 20)
        Me.radZones1Thru6.TabIndex = 2
        Me.radZones1Thru6.Text = "Zones 1-6"
        Me.radZones1Thru6.UseVisualStyleBackColor = True
        '
        'lblNumberTickets
        '
        Me.lblNumberTickets.AutoSize = True
        Me.lblNumberTickets.Font = New System.Drawing.Font("Bookman Old Style", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumberTickets.Location = New System.Drawing.Point(120, 98)
        Me.lblNumberTickets.Name = "lblNumberTickets"
        Me.lblNumberTickets.Size = New System.Drawing.Size(219, 24)
        Me.lblNumberTickets.TabIndex = 2
        Me.lblNumberTickets.Text = "Number of Tickets:"
        '
        'txtNumberTickets
        '
        Me.txtNumberTickets.Font = New System.Drawing.Font("Bookman Old Style", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumberTickets.Location = New System.Drawing.Point(345, 97)
        Me.txtNumberTickets.Name = "txtNumberTickets"
        Me.txtNumberTickets.Size = New System.Drawing.Size(42, 26)
        Me.txtNumberTickets.TabIndex = 3
        '
        'btnCalculate
        '
        Me.btnCalculate.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCalculate.Font = New System.Drawing.Font("Bookman Old Style", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalculate.Location = New System.Drawing.Point(59, 326)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(154, 62)
        Me.btnCalculate.TabIndex = 4
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnClear.Font = New System.Drawing.Font("Bookman Old Style", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(294, 326)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(154, 62)
        Me.btnClear.TabIndex = 5
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'lblTotalCost
        '
        Me.lblTotalCost.AutoSize = True
        Me.lblTotalCost.Font = New System.Drawing.Font("Bookman Old Style", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalCost.Location = New System.Drawing.Point(138, 268)
        Me.lblTotalCost.Name = "lblTotalCost"
        Me.lblTotalCost.Size = New System.Drawing.Size(67, 24)
        Me.lblTotalCost.TabIndex = 6
        Me.lblTotalCost.Text = "Cost:"
        '
        'lblCost
        '
        Me.lblCost.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.lblCost.Font = New System.Drawing.Font("Bookman Old Style", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCost.Location = New System.Drawing.Point(250, 268)
        Me.lblCost.Name = "lblCost"
        Me.lblCost.Size = New System.Drawing.Size(119, 24)
        Me.lblCost.TabIndex = 7
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(506, 450)
        Me.Controls.Add(Me.lblCost)
        Me.Controls.Add(Me.lblTotalCost)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.txtNumberTickets)
        Me.Controls.Add(Me.lblNumberTickets)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.lblTitle)
        Me.Name = "frmMain"
        Me.Text = "London Tube Tickets"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents radZones1Thru6 As RadioButton
    Friend WithEvents radZones1Thru5 As RadioButton
    Friend WithEvents radZone1Thru3 As RadioButton
    Friend WithEvents lblNumberTickets As Label
    Friend WithEvents txtNumberTickets As TextBox
    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents lblTotalCost As Label
    Friend WithEvents lblCost As Label
End Class
