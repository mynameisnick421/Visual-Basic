<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmOne
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.btnBirthday = New System.Windows.Forms.Button()
        Me.btnWedding = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.picWedding = New System.Windows.Forms.PictureBox()
        Me.picBirthday = New System.Windows.Forms.PictureBox()
        Me.picSelection = New System.Windows.Forms.PictureBox()
        CType(Me.picWedding, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBirthday, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picSelection, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTitle.Location = New System.Drawing.Point(221, 7)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(159, 23)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnBirthday
        '
        Me.btnBirthday.Location = New System.Drawing.Point(165, 309)
        Me.btnBirthday.Name = "btnBirthday"
        Me.btnBirthday.Size = New System.Drawing.Size(75, 23)
        Me.btnBirthday.TabIndex = 2
        Me.btnBirthday.Text = "Birthday"
        Me.btnBirthday.UseVisualStyleBackColor = True
        '
        'btnWedding
        '
        Me.btnWedding.Location = New System.Drawing.Point(262, 309)
        Me.btnWedding.Name = "btnWedding"
        Me.btnWedding.Size = New System.Drawing.Size(75, 23)
        Me.btnWedding.TabIndex = 3
        Me.btnWedding.Text = "Wedding"
        Me.btnWedding.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(357, 309)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 4
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'picWedding
        '
        Me.picWedding.Image = Global.cakes.My.Resources.Resources.Wedding
        Me.picWedding.Location = New System.Drawing.Point(221, 367)
        Me.picWedding.Name = "picWedding"
        Me.picWedding.Size = New System.Drawing.Size(146, 133)
        Me.picWedding.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picWedding.TabIndex = 6
        Me.picWedding.TabStop = False
        Me.picWedding.Visible = False
        '
        'picBirthday
        '
        Me.picBirthday.Image = Global.cakes.My.Resources.Resources.Bday
        Me.picBirthday.Location = New System.Drawing.Point(21, 367)
        Me.picBirthday.Name = "picBirthday"
        Me.picBirthday.Size = New System.Drawing.Size(146, 133)
        Me.picBirthday.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picBirthday.TabIndex = 5
        Me.picBirthday.TabStop = False
        Me.picBirthday.Visible = False
        '
        'picSelection
        '
        Me.picSelection.Location = New System.Drawing.Point(165, 49)
        Me.picSelection.Name = "picSelection"
        Me.picSelection.Size = New System.Drawing.Size(267, 245)
        Me.picSelection.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picSelection.TabIndex = 1
        Me.picSelection.TabStop = False
        '
        'frmOne
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(592, 362)
        Me.Controls.Add(Me.picWedding)
        Me.Controls.Add(Me.picBirthday)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnWedding)
        Me.Controls.Add(Me.btnBirthday)
        Me.Controls.Add(Me.picSelection)
        Me.Controls.Add(Me.lblTitle)
        Me.Margin = New System.Windows.Forms.Padding(1)
        Me.Name = "frmOne"
        Me.Text = "Cake Shoppe"
        CType(Me.picWedding, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBirthday, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picSelection, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents picSelection As PictureBox
    Friend WithEvents btnBirthday As Button
    Friend WithEvents btnWedding As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents picBirthday As PictureBox
    Friend WithEvents picWedding As PictureBox
End Class
