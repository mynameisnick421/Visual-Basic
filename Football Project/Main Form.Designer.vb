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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmOne))
        Me.lbdTds = New System.Windows.Forms.Label()
        Me.lblFgs = New System.Windows.Forms.Label()
        Me.lblOpc = New System.Windows.Forms.Label()
        Me.lblTpc = New System.Windows.Forms.Label()
        Me.btnCalc = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblSafties = New System.Windows.Forms.Label()
        Me.lblFscore = New System.Windows.Forms.Label()
        Me.tbxTds = New System.Windows.Forms.TextBox()
        Me.tbxFgs = New System.Windows.Forms.TextBox()
        Me.tbxOpc = New System.Windows.Forms.TextBox()
        Me.tbxTpc = New System.Windows.Forms.TextBox()
        Me.lblFscoreDis = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.tbxSafties = New System.Windows.Forms.TextBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbdTds
        '
        Me.lbdTds.AutoSize = True
        Me.lbdTds.Location = New System.Drawing.Point(42, 62)
        Me.lbdTds.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.lbdTds.Name = "lbdTds"
        Me.lbdTds.Size = New System.Drawing.Size(72, 13)
        Me.lbdTds.TabIndex = 0
        Me.lbdTds.Text = "&Touchdowns:"
        '
        'lblFgs
        '
        Me.lblFgs.AutoSize = True
        Me.lblFgs.Location = New System.Drawing.Point(42, 99)
        Me.lblFgs.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.lblFgs.Name = "lblFgs"
        Me.lblFgs.Size = New System.Drawing.Size(60, 13)
        Me.lblFgs.TabIndex = 2
        Me.lblFgs.Text = "&Field goals:"
        '
        'lblOpc
        '
        Me.lblOpc.AutoSize = True
        Me.lblOpc.Location = New System.Drawing.Point(168, 62)
        Me.lblOpc.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.lblOpc.Name = "lblOpc"
        Me.lblOpc.Size = New System.Drawing.Size(116, 13)
        Me.lblOpc.TabIndex = 4
        Me.lblOpc.Text = "&One-point conversions:"
        '
        'lblTpc
        '
        Me.lblTpc.AutoSize = True
        Me.lblTpc.Location = New System.Drawing.Point(168, 99)
        Me.lblTpc.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.lblTpc.Name = "lblTpc"
        Me.lblTpc.Size = New System.Drawing.Size(117, 13)
        Me.lblTpc.TabIndex = 6
        Me.lblTpc.Text = "T&wo-point conversions:"
        '
        'btnCalc
        '
        Me.btnCalc.Location = New System.Drawing.Point(372, 62)
        Me.btnCalc.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.btnCalc.Name = "btnCalc"
        Me.btnCalc.Size = New System.Drawing.Size(71, 35)
        Me.btnCalc.TabIndex = 10
        Me.btnCalc.Text = "&Calculate"
        Me.btnCalc.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(371, 99)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(71, 32)
        Me.btnExit.TabIndex = 11
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblSafties
        '
        Me.lblSafties.AutoSize = True
        Me.lblSafties.Location = New System.Drawing.Point(168, 147)
        Me.lblSafties.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.lblSafties.Name = "lblSafties"
        Me.lblSafties.Size = New System.Drawing.Size(42, 13)
        Me.lblSafties.TabIndex = 8
        Me.lblSafties.Text = "&Safties:"
        '
        'lblFscore
        '
        Me.lblFscore.AutoSize = True
        Me.lblFscore.Location = New System.Drawing.Point(168, 224)
        Me.lblFscore.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.lblFscore.Name = "lblFscore"
        Me.lblFscore.Size = New System.Drawing.Size(63, 13)
        Me.lblFscore.TabIndex = 7
        Me.lblFscore.Text = "Final Score:"
        '
        'tbxTds
        '
        Me.tbxTds.Location = New System.Drawing.Point(114, 62)
        Me.tbxTds.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.tbxTds.Name = "tbxTds"
        Me.tbxTds.Size = New System.Drawing.Size(40, 20)
        Me.tbxTds.TabIndex = 1
        '
        'tbxFgs
        '
        Me.tbxFgs.Location = New System.Drawing.Point(114, 96)
        Me.tbxFgs.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.tbxFgs.Name = "tbxFgs"
        Me.tbxFgs.Size = New System.Drawing.Size(40, 20)
        Me.tbxFgs.TabIndex = 3
        '
        'tbxOpc
        '
        Me.tbxOpc.Location = New System.Drawing.Point(290, 62)
        Me.tbxOpc.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.tbxOpc.Name = "tbxOpc"
        Me.tbxOpc.Size = New System.Drawing.Size(40, 20)
        Me.tbxOpc.TabIndex = 5
        '
        'tbxTpc
        '
        Me.tbxTpc.Location = New System.Drawing.Point(290, 99)
        Me.tbxTpc.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.tbxTpc.Name = "tbxTpc"
        Me.tbxTpc.Size = New System.Drawing.Size(40, 20)
        Me.tbxTpc.TabIndex = 7
        '
        'lblFscoreDis
        '
        Me.lblFscoreDis.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblFscoreDis.Location = New System.Drawing.Point(240, 207)
        Me.lblFscoreDis.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.lblFscoreDis.Name = "lblFscoreDis"
        Me.lblFscoreDis.Size = New System.Drawing.Size(138, 47)
        Me.lblFscoreDis.TabIndex = 12
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(45, 169)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(121, 83)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 13
        Me.PictureBox1.TabStop = False
        '
        'tbxSafties
        '
        Me.tbxSafties.Location = New System.Drawing.Point(225, 147)
        Me.tbxSafties.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.tbxSafties.Name = "tbxSafties"
        Me.tbxSafties.Size = New System.Drawing.Size(40, 20)
        Me.tbxSafties.TabIndex = 9
        '
        'frmOne
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(515, 348)
        Me.Controls.Add(Me.tbxSafties)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lblFscoreDis)
        Me.Controls.Add(Me.tbxTpc)
        Me.Controls.Add(Me.tbxOpc)
        Me.Controls.Add(Me.tbxFgs)
        Me.Controls.Add(Me.tbxTds)
        Me.Controls.Add(Me.lblFscore)
        Me.Controls.Add(Me.lblSafties)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnCalc)
        Me.Controls.Add(Me.lblTpc)
        Me.Controls.Add(Me.lblOpc)
        Me.Controls.Add(Me.lblFgs)
        Me.Controls.Add(Me.lbdTds)
        Me.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.Name = "frmOne"
        Me.Text = "Football Score"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbdTds As Label
    Friend WithEvents lblFgs As Label
    Friend WithEvents lblOpc As Label
    Friend WithEvents lblTpc As Label
    Friend WithEvents btnCalc As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents lblSafties As Label
    Friend WithEvents lblFscore As Label
    Friend WithEvents tbxTds As TextBox
    Friend WithEvents tbxFgs As TextBox
    Friend WithEvents tbxOpc As TextBox
    Friend WithEvents tbxTpc As TextBox
    Friend WithEvents lblFscoreDis As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents tbxSafties As TextBox
End Class
