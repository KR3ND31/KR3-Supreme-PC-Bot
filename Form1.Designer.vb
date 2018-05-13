Imports System.Windows.Forms

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Форма переопределяет dispose для очистки списка компонентов.
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

    'Является обязательной для конструктора форм Windows Forms
    Private components As System.ComponentModel.IContainer

    'Примечание: следующая процедура является обязательной для конструктора форм Windows Forms
    'Для ее изменения используйте конструктор форм Windows Form.  
    'Не изменяйте ее в редакторе исходного кода.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.B_options = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.CaptchaToken_TextBox = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.HScrollBar_CheckOutDelay = New System.Windows.Forms.HScrollBar()
        Me.CheckOutDelay_Label = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.HScrollBar_SearchInterval = New System.Windows.Forms.HScrollBar()
        Me.SearchInterval_Label = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.AutoProcessPayment_CheckBox = New System.Windows.Forms.CheckBox()
        Me.GoToCheckOutDelayValue_Label = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.HScrollBar_GoToCheckOutDelay = New System.Windows.Forms.HScrollBar()
        Me.GB_Queue = New System.Windows.Forms.GroupBox()
        Me.Panel_Queue = New System.Windows.Forms.Panel()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.StopButton = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.log_label = New System.Windows.Forms.Label()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.GroupBox1.SuspendLayout()
        Me.GB_Queue.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'B_options
        '
        Me.B_options.Location = New System.Drawing.Point(12, 327)
        Me.B_options.Name = "B_options"
        Me.B_options.Size = New System.Drawing.Size(88, 23)
        Me.B_options.TabIndex = 0
        Me.B_options.Text = "Options"
        Me.B_options.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Enabled = False
        Me.Button3.Location = New System.Drawing.Point(6, 106)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(89, 23)
        Me.Button3.TabIndex = 6
        Me.Button3.Text = "Fill(Delay)"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(12, 12)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(88, 23)
        Me.Button2.TabIndex = 5
        Me.Button2.Text = "Start Browser"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Enabled = False
        Me.Button1.Location = New System.Drawing.Point(6, 77)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(89, 23)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Fill"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.CaptchaToken_TextBox)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.HScrollBar_CheckOutDelay)
        Me.GroupBox1.Controls.Add(Me.CheckOutDelay_Label)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.HScrollBar_SearchInterval)
        Me.GroupBox1.Controls.Add(Me.SearchInterval_Label)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.AutoProcessPayment_CheckBox)
        Me.GroupBox1.Controls.Add(Me.GoToCheckOutDelayValue_Label)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.HScrollBar_GoToCheckOutDelay)
        Me.GroupBox1.Location = New System.Drawing.Point(213, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(150, 338)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Options"
        '
        'CaptchaToken_TextBox
        '
        Me.CaptchaToken_TextBox.Location = New System.Drawing.Point(6, 311)
        Me.CaptchaToken_TextBox.Name = "CaptchaToken_TextBox"
        Me.CaptchaToken_TextBox.Size = New System.Drawing.Size(137, 20)
        Me.CaptchaToken_TextBox.TabIndex = 11
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(34, 295)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(81, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Captcha Token"
        '
        'HScrollBar_CheckOutDelay
        '
        Me.HScrollBar_CheckOutDelay.LargeChange = 100
        Me.HScrollBar_CheckOutDelay.Location = New System.Drawing.Point(6, 260)
        Me.HScrollBar_CheckOutDelay.Maximum = 10099
        Me.HScrollBar_CheckOutDelay.Minimum = 100
        Me.HScrollBar_CheckOutDelay.Name = "HScrollBar_CheckOutDelay"
        Me.HScrollBar_CheckOutDelay.Size = New System.Drawing.Size(137, 14)
        Me.HScrollBar_CheckOutDelay.SmallChange = 100
        Me.HScrollBar_CheckOutDelay.TabIndex = 9
        Me.HScrollBar_CheckOutDelay.Value = 100
        '
        'CheckOutDelay_Label
        '
        Me.CheckOutDelay_Label.AutoSize = True
        Me.CheckOutDelay_Label.Location = New System.Drawing.Point(57, 237)
        Me.CheckOutDelay_Label.Name = "CheckOutDelay_Label"
        Me.CheckOutDelay_Label.Size = New System.Drawing.Size(34, 13)
        Me.CheckOutDelay_Label.TabIndex = 8
        Me.CheckOutDelay_Label.Text = "Value"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(34, 217)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(85, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "CheckOut Delay"
        '
        'HScrollBar_SearchInterval
        '
        Me.HScrollBar_SearchInterval.LargeChange = 100
        Me.HScrollBar_SearchInterval.Location = New System.Drawing.Point(6, 178)
        Me.HScrollBar_SearchInterval.Maximum = 10099
        Me.HScrollBar_SearchInterval.Minimum = 100
        Me.HScrollBar_SearchInterval.Name = "HScrollBar_SearchInterval"
        Me.HScrollBar_SearchInterval.Size = New System.Drawing.Size(137, 14)
        Me.HScrollBar_SearchInterval.SmallChange = 100
        Me.HScrollBar_SearchInterval.TabIndex = 6
        Me.HScrollBar_SearchInterval.Value = 100
        '
        'SearchInterval_Label
        '
        Me.SearchInterval_Label.AutoSize = True
        Me.SearchInterval_Label.Location = New System.Drawing.Point(57, 155)
        Me.SearchInterval_Label.Name = "SearchInterval_Label"
        Me.SearchInterval_Label.Size = New System.Drawing.Size(34, 13)
        Me.SearchInterval_Label.TabIndex = 5
        Me.SearchInterval_Label.Text = "Value"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(34, 135)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Search Interval"
        '
        'AutoProcessPayment_CheckBox
        '
        Me.AutoProcessPayment_CheckBox.AutoSize = True
        Me.AutoProcessPayment_CheckBox.Location = New System.Drawing.Point(10, 98)
        Me.AutoProcessPayment_CheckBox.Name = "AutoProcessPayment_CheckBox"
        Me.AutoProcessPayment_CheckBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.AutoProcessPayment_CheckBox.Size = New System.Drawing.Size(133, 17)
        Me.AutoProcessPayment_CheckBox.TabIndex = 3
        Me.AutoProcessPayment_CheckBox.Text = "Auto Process Payment"
        Me.AutoProcessPayment_CheckBox.UseVisualStyleBackColor = True
        '
        'GoToCheckOutDelayValue_Label
        '
        Me.GoToCheckOutDelayValue_Label.AutoSize = True
        Me.GoToCheckOutDelayValue_Label.Location = New System.Drawing.Point(57, 40)
        Me.GoToCheckOutDelayValue_Label.Name = "GoToCheckOutDelayValue_Label"
        Me.GoToCheckOutDelayValue_Label.Size = New System.Drawing.Size(34, 13)
        Me.GoToCheckOutDelayValue_Label.TabIndex = 2
        Me.GoToCheckOutDelayValue_Label.Text = "Value"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(137, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Go To CheckOut Delay(ms)"
        '
        'HScrollBar_GoToCheckOutDelay
        '
        Me.HScrollBar_GoToCheckOutDelay.LargeChange = 100
        Me.HScrollBar_GoToCheckOutDelay.Location = New System.Drawing.Point(6, 63)
        Me.HScrollBar_GoToCheckOutDelay.Maximum = 10099
        Me.HScrollBar_GoToCheckOutDelay.Minimum = 100
        Me.HScrollBar_GoToCheckOutDelay.Name = "HScrollBar_GoToCheckOutDelay"
        Me.HScrollBar_GoToCheckOutDelay.Size = New System.Drawing.Size(137, 14)
        Me.HScrollBar_GoToCheckOutDelay.SmallChange = 100
        Me.HScrollBar_GoToCheckOutDelay.TabIndex = 0
        Me.HScrollBar_GoToCheckOutDelay.Value = 100
        '
        'GB_Queue
        '
        Me.GB_Queue.Controls.Add(Me.Panel_Queue)
        Me.GB_Queue.Location = New System.Drawing.Point(369, 12)
        Me.GB_Queue.Name = "GB_Queue"
        Me.GB_Queue.Size = New System.Drawing.Size(207, 338)
        Me.GB_Queue.TabIndex = 10
        Me.GB_Queue.TabStop = False
        Me.GB_Queue.Text = "Queue"
        '
        'Panel_Queue
        '
        Me.Panel_Queue.AutoScroll = True
        Me.Panel_Queue.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel_Queue.Location = New System.Drawing.Point(3, 16)
        Me.Panel_Queue.Name = "Panel_Queue"
        Me.Panel_Queue.Size = New System.Drawing.Size(201, 319)
        Me.Panel_Queue.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.LinkLabel1)
        Me.GroupBox2.Controls.Add(Me.Button8)
        Me.GroupBox2.Controls.Add(Me.Button7)
        Me.GroupBox2.Controls.Add(Me.Button3)
        Me.GroupBox2.Controls.Add(Me.Button1)
        Me.GroupBox2.Location = New System.Drawing.Point(106, 191)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(101, 159)
        Me.GroupBox2.TabIndex = 11
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Manually"
        '
        'Button8
        '
        Me.Button8.Enabled = False
        Me.Button8.Location = New System.Drawing.Point(6, 19)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(89, 23)
        Me.Button8.TabIndex = 17
        Me.Button8.Text = "Find + 2"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Enabled = False
        Me.Button7.Location = New System.Drawing.Point(6, 48)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(89, 23)
        Me.Button7.TabIndex = 16
        Me.Button7.Text = "ATC + 1"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.RadioButton2)
        Me.GroupBox3.Controls.Add(Me.RadioButton1)
        Me.GroupBox3.Controls.Add(Me.StopButton)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.TimePicker)
        Me.GroupBox3.Controls.Add(Me.Button5)
        Me.GroupBox3.Location = New System.Drawing.Point(106, 12)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(101, 173)
        Me.GroupBox3.TabIndex = 12
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Auto"
        '
        'StopButton
        '
        Me.StopButton.Enabled = False
        Me.StopButton.Location = New System.Drawing.Point(6, 48)
        Me.StopButton.Name = "StopButton"
        Me.StopButton.Size = New System.Drawing.Size(89, 23)
        Me.StopButton.TabIndex = 19
        Me.StopButton.Text = "Stop"
        Me.StopButton.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(32, 100)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(30, 13)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "Time"
        '
        'TimePicker
        '
        Me.TimePicker.Enabled = False
        Me.TimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.TimePicker.Location = New System.Drawing.Point(6, 77)
        Me.TimePicker.Name = "TimePicker"
        Me.TimePicker.ShowCheckBox = True
        Me.TimePicker.ShowUpDown = True
        Me.TimePicker.Size = New System.Drawing.Size(89, 20)
        Me.TimePicker.TabIndex = 17
        '
        'Button5
        '
        Me.Button5.Enabled = False
        Me.Button5.Location = New System.Drawing.Point(6, 19)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(89, 23)
        Me.Button5.TabIndex = 14
        Me.Button5.Text = "Start"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Enabled = False
        Me.Button4.Location = New System.Drawing.Point(12, 70)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(88, 23)
        Me.Button4.TabIndex = 13
        Me.Button4.Text = "Google Auth"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Enabled = False
        Me.Button6.Location = New System.Drawing.Point(12, 41)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(88, 23)
        Me.Button6.TabIndex = 15
        Me.Button6.Text = "Open Supreme"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Panel1)
        Me.GroupBox4.Location = New System.Drawing.Point(582, 12)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(239, 338)
        Me.GroupBox4.TabIndex = 16
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Log"
        '
        'Panel1
        '
        Me.Panel1.AutoScroll = True
        Me.Panel1.Controls.Add(Me.log_label)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(3, 16)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(233, 319)
        Me.Panel1.TabIndex = 0
        '
        'log_label
        '
        Me.log_label.AutoSize = True
        Me.log_label.Location = New System.Drawing.Point(4, 4)
        Me.log_label.Name = "log_label"
        Me.log_label.Size = New System.Drawing.Size(0, 13)
        Me.log_label.TabIndex = 0
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.LinkLabel1.Location = New System.Drawing.Point(6, 142)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(89, 12)
        Me.LinkLabel1.TabIndex = 17
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "VK.COM/KR3ND31"
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Checked = True
        Me.RadioButton1.Enabled = False
        Me.RadioButton1.Location = New System.Drawing.Point(6, 126)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(60, 17)
        Me.RadioButton1.TabIndex = 20
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Fast Fill"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Enabled = False
        Me.RadioButton2.Location = New System.Drawing.Point(6, 147)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(63, 17)
        Me.RadioButton2.TabIndex = 21
        Me.RadioButton2.Text = "Slow Fill"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(833, 360)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GB_Queue)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.B_options)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Text = "KR3 Supreme Bot"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GB_Queue.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents B_options As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents CaptchaToken_TextBox As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents HScrollBar_CheckOutDelay As HScrollBar
    Friend WithEvents CheckOutDelay_Label As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents HScrollBar_SearchInterval As HScrollBar
    Friend WithEvents SearchInterval_Label As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents AutoProcessPayment_CheckBox As CheckBox
    Friend WithEvents GoToCheckOutDelayValue_Label As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents HScrollBar_GoToCheckOutDelay As HScrollBar
    Friend WithEvents GB_Queue As GroupBox
    Friend WithEvents Panel_Queue As Panel
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents log_label As Label
    Friend WithEvents TimePicker As DateTimePicker
    Friend WithEvents Label5 As Label
    Friend WithEvents StopButton As Button
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton1 As RadioButton
End Class
