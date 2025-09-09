<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.car2 = New System.Windows.Forms.PictureBox()
        Me.car3 = New System.Windows.Forms.PictureBox()
        Me.car1 = New System.Windows.Forms.PictureBox()
        Me.car = New System.Windows.Forms.PictureBox()
        Me.RoadMover = New System.Windows.Forms.Timer(Me.components)
        Me.RightSlide = New System.Windows.Forms.Timer(Me.components)
        Me.LeftSide = New System.Windows.Forms.Timer(Me.components)
        Me.RacerMover1 = New System.Windows.Forms.Timer(Me.components)
        Me.RacerMover2 = New System.Windows.Forms.Timer(Me.components)
        Me.RacerMover3 = New System.Windows.Forms.Timer(Me.components)
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PictureBox11 = New System.Windows.Forms.PictureBox()
        Me.PictureBox12 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.car2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.car3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.car1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.car, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox12, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.PictureBox1.Location = New System.Drawing.Point(98, -105)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(10, 183)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.PictureBox2.Location = New System.Drawing.Point(219, -105)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(10, 183)
        Me.PictureBox2.TabIndex = 1
        Me.PictureBox2.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.PictureBox3.Location = New System.Drawing.Point(98, 108)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(10, 86)
        Me.PictureBox3.TabIndex = 3
        Me.PictureBox3.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.PictureBox4.Location = New System.Drawing.Point(219, 103)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(10, 91)
        Me.PictureBox4.TabIndex = 2
        Me.PictureBox4.TabStop = False
        '
        'PictureBox5
        '
        Me.PictureBox5.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.PictureBox5.Location = New System.Drawing.Point(98, 227)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(10, 106)
        Me.PictureBox5.TabIndex = 5
        Me.PictureBox5.TabStop = False
        '
        'PictureBox6
        '
        Me.PictureBox6.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.PictureBox6.Location = New System.Drawing.Point(219, 227)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(10, 105)
        Me.PictureBox6.TabIndex = 4
        Me.PictureBox6.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Agency FB", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(5, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 35)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "score 0"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Agency FB", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(235, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 35)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "speed 0"
        '
        'car2
        '
        Me.car2.Image = CType(resources.GetObject("car2.Image"), System.Drawing.Image)
        Me.car2.Location = New System.Drawing.Point(12, 268)
        Me.car2.Name = "car2"
        Me.car2.Size = New System.Drawing.Size(53, 78)
        Me.car2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.car2.TabIndex = 8
        Me.car2.TabStop = False
        '
        'car3
        '
        Me.car3.Image = CType(resources.GetObject("car3.Image"), System.Drawing.Image)
        Me.car3.Location = New System.Drawing.Point(140, 187)
        Me.car3.Name = "car3"
        Me.car3.Size = New System.Drawing.Size(53, 78)
        Me.car3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.car3.TabIndex = 9
        Me.car3.TabStop = False
        '
        'car1
        '
        Me.car1.Image = CType(resources.GetObject("car1.Image"), System.Drawing.Image)
        Me.car1.Location = New System.Drawing.Point(257, 268)
        Me.car1.Name = "car1"
        Me.car1.Size = New System.Drawing.Size(53, 78)
        Me.car1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.car1.TabIndex = 10
        Me.car1.TabStop = False
        '
        'car
        '
        Me.car.Image = CType(resources.GetObject("car.Image"), System.Drawing.Image)
        Me.car.Location = New System.Drawing.Point(140, 351)
        Me.car.Name = "car"
        Me.car.Size = New System.Drawing.Size(53, 78)
        Me.car.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.car.TabIndex = 11
        Me.car.TabStop = False
        '
        'RoadMover
        '
        Me.RoadMover.Enabled = True
        Me.RoadMover.Interval = 10
        '
        'RightSlide
        '
        Me.RightSlide.Interval = 10
        '
        'LeftSide
        '
        Me.LeftSide.Interval = 10
        '
        'RacerMover1
        '
        Me.RacerMover1.Interval = 10
        '
        'RacerMover2
        '
        Me.RacerMover2.Interval = 10
        '
        'RacerMover3
        '
        Me.RacerMover3.Interval = 10
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.SystemColors.Window
        Me.Label3.Font = New System.Drawing.Font("Agency FB", 28.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Firebrick
        Me.Label3.Location = New System.Drawing.Point(82, 63)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(198, 59)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Game Over"
        Me.Label3.Visible = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Salmon
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Button1.Font = New System.Drawing.Font("Agency FB", 22.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(92, 284)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(143, 48)
        Me.Button1.TabIndex = 13
        Me.Button1.Text = "REPLAY"
        Me.Button1.UseVisualStyleBackColor = False
        Me.Button1.Visible = False
        '
        'PictureBox11
        '
        Me.PictureBox11.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.PictureBox11.Location = New System.Drawing.Point(219, 371)
        Me.PictureBox11.Name = "PictureBox11"
        Me.PictureBox11.Size = New System.Drawing.Size(10, 106)
        Me.PictureBox11.TabIndex = 15
        Me.PictureBox11.TabStop = False
        '
        'PictureBox12
        '
        Me.PictureBox12.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.PictureBox12.Location = New System.Drawing.Point(98, 372)
        Me.PictureBox12.Name = "PictureBox12"
        Me.PictureBox12.Size = New System.Drawing.Size(10, 105)
        Me.PictureBox12.TabIndex = 14
        Me.PictureBox12.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ClientSize = New System.Drawing.Size(332, 453)
        Me.Controls.Add(Me.PictureBox11)
        Me.Controls.Add(Me.PictureBox12)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.car)
        Me.Controls.Add(Me.car1)
        Me.Controls.Add(Me.car3)
        Me.Controls.Add(Me.car2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.PictureBox6)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.MaximumSize = New System.Drawing.Size(350, 500)
        Me.MinimumSize = New System.Drawing.Size(350, 500)
        Me.Name = "Form1"
        Me.Text = "Car Racing Game"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.car2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.car3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.car1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.car, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox12, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox5 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox6 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents car2 As System.Windows.Forms.PictureBox
    Friend WithEvents car3 As System.Windows.Forms.PictureBox
    Friend WithEvents car1 As System.Windows.Forms.PictureBox
    Friend WithEvents car As System.Windows.Forms.PictureBox
    Friend WithEvents RoadMover As System.Windows.Forms.Timer
    Friend WithEvents RightSlide As System.Windows.Forms.Timer
    Friend WithEvents LeftSide As System.Windows.Forms.Timer
    Friend WithEvents RacerMover1 As System.Windows.Forms.Timer
    Friend WithEvents RacerMover2 As System.Windows.Forms.Timer
    Friend WithEvents RacerMover3 As System.Windows.Forms.Timer
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents PictureBox11 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox12 As System.Windows.Forms.PictureBox

End Class
