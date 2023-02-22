<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAirBnBRes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAirBnBRes))
        Me.picAirBnB = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblNumNights = New System.Windows.Forms.Label()
        Me.lblCost = New System.Windows.Forms.Label()
        Me.txtNights = New System.Windows.Forms.TextBox()
        Me.btnDisplayCost = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblCostofStay = New System.Windows.Forms.Label()
        CType(Me.picAirBnB, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picAirBnB
        '
        Me.picAirBnB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.picAirBnB.Image = CType(resources.GetObject("picAirBnB.Image"), System.Drawing.Image)
        Me.picAirBnB.Location = New System.Drawing.Point(12, 42)
        Me.picAirBnB.Name = "picAirBnB"
        Me.picAirBnB.Size = New System.Drawing.Size(539, 678)
        Me.picAirBnB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picAirBnB.TabIndex = 0
        Me.picAirBnB.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Comic Sans MS", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(672, 67)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(518, 90)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Orlando AirBnB"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(752, 167)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(374, 45)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Only $79.00 per night"
        '
        'lblNumNights
        '
        Me.lblNumNights.AutoSize = True
        Me.lblNumNights.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumNights.Location = New System.Drawing.Point(680, 328)
        Me.lblNumNights.Name = "lblNumNights"
        Me.lblNumNights.Size = New System.Drawing.Size(278, 37)
        Me.lblNumNights.TabIndex = 3
        Me.lblNumNights.Text = "Number of Nights:"
        '
        'lblCost
        '
        Me.lblCost.AutoSize = True
        Me.lblCost.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCost.Location = New System.Drawing.Point(680, 434)
        Me.lblCost.Name = "lblCost"
        Me.lblCost.Size = New System.Drawing.Size(200, 37)
        Me.lblCost.TabIndex = 4
        Me.lblCost.Text = "Cost of Stay:"
        '
        'txtNights
        '
        Me.txtNights.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.875!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNights.Location = New System.Drawing.Point(1005, 314)
        Me.txtNights.Multiline = True
        Me.txtNights.Name = "txtNights"
        Me.txtNights.Size = New System.Drawing.Size(100, 51)
        Me.txtNights.TabIndex = 5
        '
        'btnDisplayCost
        '
        Me.btnDisplayCost.Location = New System.Drawing.Point(666, 622)
        Me.btnDisplayCost.Name = "btnDisplayCost"
        Me.btnDisplayCost.Size = New System.Drawing.Size(149, 47)
        Me.btnDisplayCost.TabIndex = 7
        Me.btnDisplayCost.Text = "Display Cost"
        Me.btnDisplayCost.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(869, 622)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(136, 47)
        Me.btnClear.TabIndex = 8
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(1062, 622)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(128, 47)
        Me.btnExit.TabIndex = 9
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblCostofStay
        '
        Me.lblCostofStay.AutoSize = True
        Me.lblCostofStay.Font = New System.Drawing.Font("Arial", 13.875!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCostofStay.Location = New System.Drawing.Point(1005, 434)
        Me.lblCostofStay.Name = "lblCostofStay"
        Me.lblCostofStay.Size = New System.Drawing.Size(0, 45)
        Me.lblCostofStay.TabIndex = 10
        Me.lblCostofStay.UseCompatibleTextRendering = True
        '
        'frmAirBnBRes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1310, 775)
        Me.Controls.Add(Me.lblCostofStay)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnDisplayCost)
        Me.Controls.Add(Me.txtNights)
        Me.Controls.Add(Me.lblCost)
        Me.Controls.Add(Me.lblNumNights)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.picAirBnB)
        Me.Name = "frmAirBnBRes"
        Me.Text = "AirBnB Reservations"
        CType(Me.picAirBnB, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents picAirBnB As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblNumNights As Label
    Friend WithEvents lblCost As Label
    Friend WithEvents txtNights As TextBox
    Friend WithEvents btnDisplayCost As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents lblCostofStay As Label
End Class
