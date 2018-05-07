Imports System
Imports System.Collections
Imports System.Linq
Imports System.Windows.Forms

Public Class settings
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        TextBox1.Text = My.Settings.Name
        TextBox2.Text = My.Settings.Email
        MaskedTextBox1.Text = My.Settings.Tel
        TextBox3.Text = My.Settings.Address1
        TextBox8.Text = My.Settings.Address2
        TextBox7.Text = My.Settings.Address3
        TextBox6.Text = My.Settings.City
        MaskedTextBox4.Text = My.Settings.Postcode
        ComboBox1.Text = My.Settings.Country

        ComboBox2.Text = My.Settings.Type
        MaskedTextBox2.Text = My.Settings.Number
        ComboBox3.Text = My.Settings.Month
        ComboBox4.Text = My.Settings.Year
        MaskedTextBox3.Text = My.Settings.CVV

        For Each Item As Hashtable In Form1.ItemsArray
            Dim ItemTabPage As New TabPage
            Dim ItemTab As New ItemTab

            ItemTab.Dock = DockStyle.Fill
            ItemTab.TopLevel = False
            ItemTabPage.Controls.Add(ItemTab)
            ItemsTab.TabPages.Add(ItemTabPage)

            ItemTab.CategoryInput.Text = Item.Item("Category")
            ItemTab.SizeInput.Text = Item.Item("Size")
            ItemTab.KeywordInput.Text = Item.Item("Keyword")
            ItemTab.IfItemNoSizeInput.Text = Item.Item("IfItemNoSize")
            ItemTab.IfItemNoStyleInput.Text = Item.Item("IfItemNoStyle")
            ItemTab.ItemTab = ItemTabPage

            Dim isfirst As Boolean = True
            For Each color As String In Item.Item("Colors")
                If isfirst = True Then
                    ItemTab.StyleInput.Text = color
                    isfirst = False
                Else
                    ItemTab.AddColor(color)
                End If
            Next
            ItemTab.Show()
        Next
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        My.Settings.Name = TextBox1.Text
        My.Settings.Email = TextBox2.Text
        My.Settings.Tel = MaskedTextBox1.Text
        My.Settings.Address1 = TextBox3.Text
        My.Settings.Address2 = TextBox8.Text
        My.Settings.Address3 = TextBox7.Text
        My.Settings.City = TextBox6.Text
        My.Settings.Postcode = MaskedTextBox4.Text
        My.Settings.Country = ComboBox1.Text

        My.Settings.Type = ComboBox2.Text
        My.Settings.Number = MaskedTextBox2.Text
        My.Settings.Month = ComboBox3.Text
        My.Settings.Year = ComboBox4.Text
        My.Settings.CVV = MaskedTextBox3.Text

        My.Settings.Save()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        MaskedTextBox1.Text = ""
        TextBox3.Text = ""
        TextBox8.Text = ""
        TextBox7.Text = ""
        TextBox6.Text = ""
        MaskedTextBox4.Text = ""
        ComboBox1.Text = ""

        ComboBox2.Text = ""
        MaskedTextBox2.Text = ""
        ComboBox3.Text = ""
        ComboBox4.Text = ""
        MaskedTextBox3.Text = ""
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim ItemTabPage As New TabPage
        Dim ItemTab As New ItemTab

        ItemTab.Dock = DockStyle.Fill
        ItemTab.TopLevel = False
        ItemTabPage.Controls.Add(ItemTab)
        ItemsTab.TabPages.Add(ItemTabPage)
        ItemTab.Show()

        ItemTab.ItemTab = ItemTabPage
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Form1.ItemsArray = {}
        For Each ItemTabPage As TabPage In ItemsTab.TabPages
            Dim ItemArray As Hashtable = New Hashtable()

            Dim Category As String = ItemTabPage.Controls.OfType(Of ItemTab)().Last.CategoryInput.Text
            Dim Size As String = ItemTabPage.Controls.OfType(Of ItemTab)().Last.SizeInput.Text
            Dim Keyword As String = ItemTabPage.Controls.OfType(Of ItemTab)().Last.KeywordInput.Text
            Dim IfItemNoSize As String = ItemTabPage.Controls.OfType(Of ItemTab)().Last.IfItemNoSizeInput.Text
            Dim IfItemNoStyle As String = ItemTabPage.Controls.OfType(Of ItemTab)().Last.IfItemNoStyleInput.Text

            If Category <> "" And Size <> "" And Keyword <> "" And IfItemNoSize <> "" And IfItemNoStyle <> "" Then
                ItemArray.Add("Category", Category)
                ItemArray.Add("Size", Size)
                ItemArray.Add("Keyword", Keyword)
                ItemArray.Add("IfItemNoSize", IfItemNoSize)
                ItemArray.Add("IfItemNoStyle", IfItemNoStyle)

                Dim ColorsArray As String() = {}

                For Each ColorPanel As Panel In ItemTabPage.Controls.OfType(Of ItemTab)().Last.ColorsPanel.Controls
                    Array.Resize(ColorsArray, ColorsArray.Length + 1)
                    ColorsArray(ColorsArray.Length - 1) = ColorPanel.Controls.OfType(Of TextBox)().Last.Text
                Next

                ItemArray.Add("Colors", ColorsArray)

                Array.Resize(Form1.ItemsArray, Form1.ItemsArray.Length + 1)
                Form1.ItemsArray(Form1.ItemsArray.Length - 1) = ItemArray
            Else
                MessageBox.Show("Select Category, Size, IfItemNoSize, IfItemNoStyle, and write keyword on " + (ItemsTab.TabPages.IndexOf(ItemTabPage) + 1).ToString + " item", "Error")
            End If
        Next
        Form1.UpdateQueue()
    End Sub


    Public Sub Add(Of T)(ByRef arr As T(), item As T)
        Array.Resize(arr, arr.Length + 1)
        arr(arr.Length - 1) = item
    End Sub
End Class