<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ItemTab
    Inherits System.Windows.Forms.Form

    'Форма переопределяет dispose для очистки списка компонентов.
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

    'Является обязательной для конструктора форм Windows Forms
    Private components As System.ComponentModel.IContainer

    'Примечание: следующая процедура является обязательной для конструктора форм Windows Forms
    'Для ее изменения используйте конструктор форм Windows Form.  
    'Не изменяйте ее в редакторе исходного кода.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CategoryInput = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SizeInput = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.KeywordInput = New System.Windows.Forms.TextBox()
        Me.StyleInput = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.AddButton = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.IfItemNoSizeInput = New System.Windows.Forms.ComboBox()
        Me.IfItemNoStyleInput = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ColorsPanel = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.ItemDelete_Button = New System.Windows.Forms.Button()
        Me.ColorsPanel.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(10, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Category"
        '
        'CategoryInput
        '
        Me.CategoryInput.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CategoryInput.FormattingEnabled = True
        Me.CategoryInput.Items.AddRange(New Object() {"jackets", "shirts", "tops/sweaters", "sweatshirts", "pants", "shorts", "t-shirts", "hats", "bags", "accessories", "shoes", "skate"})
        Me.CategoryInput.Location = New System.Drawing.Point(91, 8)
        Me.CategoryInput.Name = "CategoryInput"
        Me.CategoryInput.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.CategoryInput.Size = New System.Drawing.Size(121, 21)
        Me.CategoryInput.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(10, 38)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(27, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Size"
        '
        'SizeInput
        '
        Me.SizeInput.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.SizeInput.FormattingEnabled = True
        Me.SizeInput.Items.AddRange(New Object() {"any", "Small", "Medium", "Large", "XLarge", "30", "32", "34", "36", "US 8", "US 8.5", "US 9", "US 9.5", "US 10", "US 10.5 (shoes)", "US 11 (shoes)", "US 11.5 (shoes)", "US 12 (shoes)", "US 12.5 (shoes)", "US 13 (shoes)"})
        Me.SizeInput.Location = New System.Drawing.Point(91, 35)
        Me.SizeInput.Name = "SizeInput"
        Me.SizeInput.Size = New System.Drawing.Size(121, 21)
        Me.SizeInput.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(10, 65)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Keyword"
        '
        'KeywordInput
        '
        Me.KeywordInput.Location = New System.Drawing.Point(91, 62)
        Me.KeywordInput.Name = "KeywordInput"
        Me.KeywordInput.Size = New System.Drawing.Size(121, 20)
        Me.KeywordInput.TabIndex = 3
        '
        'StyleInput
        '
        Me.StyleInput.Location = New System.Drawing.Point(0, 0)
        Me.StyleInput.Name = "StyleInput"
        Me.StyleInput.Size = New System.Drawing.Size(121, 20)
        Me.StyleInput.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(130, 149)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(30, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Style"
        '
        'AddButton
        '
        Me.AddButton.Location = New System.Drawing.Point(135, 194)
        Me.AddButton.Name = "AddButton"
        Me.AddButton.Size = New System.Drawing.Size(21, 20)
        Me.AddButton.TabIndex = 7
        Me.AddButton.Text = "+"
        Me.AddButton.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(10, 91)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(76, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "If Item No Size"
        '
        'IfItemNoSizeInput
        '
        Me.IfItemNoSizeInput.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.IfItemNoSizeInput.FormattingEnabled = True
        Me.IfItemNoSizeInput.Items.AddRange(New Object() {"any", "skip"})
        Me.IfItemNoSizeInput.Location = New System.Drawing.Point(91, 88)
        Me.IfItemNoSizeInput.Name = "IfItemNoSizeInput"
        Me.IfItemNoSizeInput.Size = New System.Drawing.Size(121, 21)
        Me.IfItemNoSizeInput.TabIndex = 4
        '
        'IfItemNoStyleInput
        '
        Me.IfItemNoStyleInput.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.IfItemNoStyleInput.FormattingEnabled = True
        Me.IfItemNoStyleInput.Items.AddRange(New Object() {"next", "skip", "wait"})
        Me.IfItemNoStyleInput.Location = New System.Drawing.Point(91, 115)
        Me.IfItemNoStyleInput.Name = "IfItemNoStyleInput"
        Me.IfItemNoStyleInput.Size = New System.Drawing.Size(121, 21)
        Me.IfItemNoStyleInput.TabIndex = 5
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(10, 118)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(79, 13)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "If Item No Style"
        '
        'ColorsPanel
        '
        Me.ColorsPanel.Controls.Add(Me.Panel2)
        Me.ColorsPanel.Location = New System.Drawing.Point(91, 165)
        Me.ColorsPanel.Name = "ColorsPanel"
        Me.ColorsPanel.Size = New System.Drawing.Size(149, 26)
        Me.ColorsPanel.TabIndex = 14
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.StyleInput)
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(149, 20)
        Me.Panel2.TabIndex = 9
        '
        'ItemDelete_Button
        '
        Me.ItemDelete_Button.Location = New System.Drawing.Point(311, 12)
        Me.ItemDelete_Button.Name = "ItemDelete_Button"
        Me.ItemDelete_Button.Size = New System.Drawing.Size(24, 23)
        Me.ItemDelete_Button.TabIndex = 0
        Me.ItemDelete_Button.Text = "X"
        Me.ItemDelete_Button.UseVisualStyleBackColor = True
        '
        'ItemTab
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(347, 284)
        Me.ControlBox = False
        Me.Controls.Add(Me.ItemDelete_Button)
        Me.Controls.Add(Me.ColorsPanel)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.IfItemNoStyleInput)
        Me.Controls.Add(Me.AddButton)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.IfItemNoSizeInput)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.KeywordInput)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.SizeInput)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.CategoryInput)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ItemTab"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = "itemTab"
        Me.ColorsPanel.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CategoryInput As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents SizeInput As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents KeywordInput As System.Windows.Forms.TextBox
    Friend WithEvents StyleInput As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents AddButton As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents IfItemNoSizeInput As System.Windows.Forms.ComboBox
    Friend WithEvents IfItemNoStyleInput As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents ColorsPanel As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents ItemDelete_Button As System.Windows.Forms.Button
End Class
