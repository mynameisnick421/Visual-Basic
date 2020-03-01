<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOne
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
        Me.btnElect = New System.Windows.Forms.Button()
        Me.btnPlumb = New System.Windows.Forms.Button()
        Me.btnDoc = New System.Windows.Forms.Button()
        Me.btnHosp = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblPhone = New System.Windows.Forms.Label()
        Me.lblNameDis = New System.Windows.Forms.Label()
        Me.lblPhoneDis = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnElect
        '
        Me.btnElect.Location = New System.Drawing.Point(764, 56)
        Me.btnElect.Name = "btnElect"
        Me.btnElect.Size = New System.Drawing.Size(179, 95)
        Me.btnElect.TabIndex = 0
        Me.btnElect.Text = "Electrician"
        Me.btnElect.UseVisualStyleBackColor = True
        '
        'btnPlumb
        '
        Me.btnPlumb.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnPlumb.Location = New System.Drawing.Point(764, 175)
        Me.btnPlumb.Name = "btnPlumb"
        Me.btnPlumb.Size = New System.Drawing.Size(179, 95)
        Me.btnPlumb.TabIndex = 1
        Me.btnPlumb.Text = "Plumber"
        Me.btnPlumb.UseVisualStyleBackColor = True
        '
        'btnDoc
        '
        Me.btnDoc.Location = New System.Drawing.Point(764, 294)
        Me.btnDoc.Name = "btnDoc"
        Me.btnDoc.Size = New System.Drawing.Size(179, 95)
        Me.btnDoc.TabIndex = 2
        Me.btnDoc.Text = "Doctor"
        Me.btnDoc.UseVisualStyleBackColor = True
        '
        'btnHosp
        '
        Me.btnHosp.Location = New System.Drawing.Point(764, 411)
        Me.btnHosp.Name = "btnHosp"
        Me.btnHosp.Size = New System.Drawing.Size(179, 95)
        Me.btnHosp.TabIndex = 3
        Me.btnHosp.Text = "Hospital"
        Me.btnHosp.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(764, 529)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(179, 95)
        Me.btnExit.TabIndex = 4
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(203, 183)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(98, 32)
        Me.lblName.TabIndex = 5
        Me.lblName.Text = "Name:"
        '
        'lblPhone
        '
        Me.lblPhone.AutoSize = True
        Me.lblPhone.Location = New System.Drawing.Point(203, 294)
        Me.lblPhone.Name = "lblPhone"
        Me.lblPhone.Size = New System.Drawing.Size(106, 32)
        Me.lblPhone.TabIndex = 6
        Me.lblPhone.Text = "Phone:"
        '
        'lblNameDis
        '
        Me.lblNameDis.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblNameDis.Location = New System.Drawing.Point(209, 232)
        Me.lblNameDis.Name = "lblNameDis"
        Me.lblNameDis.Size = New System.Drawing.Size(289, 38)
        Me.lblNameDis.TabIndex = 9
        Me.lblNameDis.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblPhoneDis
        '
        Me.lblPhoneDis.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblPhoneDis.Location = New System.Drawing.Point(209, 351)
        Me.lblPhoneDis.Name = "lblPhoneDis"
        Me.lblPhoneDis.Size = New System.Drawing.Size(289, 38)
        Me.lblPhoneDis.TabIndex = 10
        Me.lblPhoneDis.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmOne
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(16.0!, 31.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1034, 676)
        Me.Controls.Add(Me.lblPhoneDis)
        Me.Controls.Add(Me.lblNameDis)
        Me.Controls.Add(Me.lblPhone)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnHosp)
        Me.Controls.Add(Me.btnDoc)
        Me.Controls.Add(Me.btnPlumb)
        Me.Controls.Add(Me.btnElect)
        Me.Name = "frmOne"
        Me.Text = "Important Information"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnElect As Button
    Friend WithEvents btnPlumb As Button
    Friend WithEvents btnDoc As Button
    Friend WithEvents btnHosp As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents lblName As Label
    Friend WithEvents lblPhone As Label
    Friend WithEvents lblNameDis As Label
    Friend WithEvents lblPhoneDis As Label
End Class
