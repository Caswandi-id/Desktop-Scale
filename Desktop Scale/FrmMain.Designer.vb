<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMain))
        Me.PanelDesktop = New System.Windows.Forms.Panel()
        Me.PicObject = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextLocY = New System.Windows.Forms.Label()
        Me.TextLocX = New System.Windows.Forms.Label()
        Me.BarW = New System.Windows.Forms.TrackBar()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.BarH = New System.Windows.Forms.TrackBar()
        Me.BarWText = New System.Windows.Forms.Label()
        Me.BarHText = New System.Windows.Forms.Label()
        Me.CmdShow = New System.Windows.Forms.Button()
        Me.PanelDesktop.SuspendLayout()
        CType(Me.PicObject, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarW, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarH, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelDesktop
        '
        Me.PanelDesktop.BackColor = System.Drawing.Color.DimGray
        Me.PanelDesktop.Controls.Add(Me.PicObject)
        Me.PanelDesktop.Location = New System.Drawing.Point(12, 12)
        Me.PanelDesktop.Name = "PanelDesktop"
        Me.PanelDesktop.Size = New System.Drawing.Size(400, 300)
        Me.PanelDesktop.TabIndex = 0
        '
        'PicObject
        '
        Me.PicObject.BackColor = System.Drawing.Color.DimGray
        Me.PicObject.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PicObject.Cursor = System.Windows.Forms.Cursors.SizeAll
        Me.PicObject.Image = CType(resources.GetObject("PicObject.Image"), System.Drawing.Image)
        Me.PicObject.Location = New System.Drawing.Point(14, 16)
        Me.PicObject.Name = "PicObject"
        Me.PicObject.Size = New System.Drawing.Size(51, 34)
        Me.PicObject.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicObject.TabIndex = 1
        Me.PicObject.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(429, 160)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(20, 15)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "X :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(429, 184)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(20, 15)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Y :"
        '
        'TextLocY
        '
        Me.TextLocY.AutoSize = True
        Me.TextLocY.Location = New System.Drawing.Point(446, 184)
        Me.TextLocY.Name = "TextLocY"
        Me.TextLocY.Size = New System.Drawing.Size(12, 15)
        Me.TextLocY.TabIndex = 4
        Me.TextLocY.Text = "-"
        '
        'TextLocX
        '
        Me.TextLocX.AutoSize = True
        Me.TextLocX.Location = New System.Drawing.Point(446, 160)
        Me.TextLocX.Name = "TextLocX"
        Me.TextLocX.Size = New System.Drawing.Size(12, 15)
        Me.TextLocX.TabIndex = 3
        Me.TextLocX.Text = "-"
        '
        'BarW
        '
        Me.BarW.Location = New System.Drawing.Point(427, 30)
        Me.BarW.Maximum = 200
        Me.BarW.Minimum = 1
        Me.BarW.Name = "BarW"
        Me.BarW.Size = New System.Drawing.Size(144, 45)
        Me.BarW.TabIndex = 5
        Me.BarW.TickStyle = System.Windows.Forms.TickStyle.None
        Me.BarW.Value = 51
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(429, 12)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(41, 15)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Size W"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(431, 63)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 15)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Size H"
        '
        'BarH
        '
        Me.BarH.Location = New System.Drawing.Point(429, 81)
        Me.BarH.Maximum = 200
        Me.BarH.Minimum = 1
        Me.BarH.Name = "BarH"
        Me.BarH.Size = New System.Drawing.Size(144, 45)
        Me.BarH.TabIndex = 7
        Me.BarH.TickStyle = System.Windows.Forms.TickStyle.None
        Me.BarH.Value = 34
        '
        'BarWText
        '
        Me.BarWText.AutoSize = True
        Me.BarWText.Location = New System.Drawing.Point(577, 30)
        Me.BarWText.Name = "BarWText"
        Me.BarWText.Size = New System.Drawing.Size(26, 15)
        Me.BarWText.TabIndex = 9
        Me.BarWText.Text = "0 %"
        '
        'BarHText
        '
        Me.BarHText.AutoSize = True
        Me.BarHText.Location = New System.Drawing.Point(577, 81)
        Me.BarHText.Name = "BarHText"
        Me.BarHText.Size = New System.Drawing.Size(26, 15)
        Me.BarHText.TabIndex = 10
        Me.BarHText.Text = "0 %"
        '
        'CmdShow
        '
        Me.CmdShow.Location = New System.Drawing.Point(427, 254)
        Me.CmdShow.Name = "CmdShow"
        Me.CmdShow.Size = New System.Drawing.Size(187, 55)
        Me.CmdShow.TabIndex = 11
        Me.CmdShow.Text = "Tampilkan"
        Me.CmdShow.UseVisualStyleBackColor = True
        '
        'FrmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(626, 321)
        Me.Controls.Add(Me.CmdShow)
        Me.Controls.Add(Me.BarHText)
        Me.Controls.Add(Me.BarWText)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.BarH)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.BarW)
        Me.Controls.Add(Me.TextLocY)
        Me.Controls.Add(Me.TextLocX)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PanelDesktop)
        Me.Name = "FrmMain"
        Me.Text = "DesktopScale"
        Me.PanelDesktop.ResumeLayout(False)
        CType(Me.PicObject, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarW, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarH, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PanelDesktop As Panel
    Friend WithEvents PicObject As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextLocY As Label
    Friend WithEvents TextLocX As Label
    Friend WithEvents BarW As TrackBar
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents BarH As TrackBar
    Friend WithEvents BarWText As Label
    Friend WithEvents BarHText As Label
    Friend WithEvents CmdShow As Button
End Class
