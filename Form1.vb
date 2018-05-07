Imports System
Imports System.Collections
Imports System.Drawing
Imports System.Windows.Forms
Imports System.Text.RegularExpressions

Imports HtmlAgilityPack

Imports OpenQA.Selenium
Imports OpenQA.Selenium.Firefox
Imports OpenQA.Selenium.Support.UI
Imports System.Linq
Imports System.Runtime.CompilerServices
Imports System.ComponentModel

Public Class Form1
    Public ItemsArray As Hashtable() = {}
    Public GoToCheckOutDelay As Integer = 100
    Public AutoProcessPayment As Boolean
    Public SearchInterval As Integer = 100
    Public CheckOutDelay As Integer = 100
    Public CaptchaToken As String
    Dim searching = False
    Private WithEvents SearchTimer As New Timer
    Private WithEvents StartTimer As New Timer With {.Interval = 1000}
    Private timeLeft As Integer

    Dim driver As IWebDriver

    Private WithEvents StartBrowserThread As BackgroundWorker = New BackgroundWorker()
    Private WithEvents GoToUrlThread As BackgroundWorker = New BackgroundWorker()
    Private WithEvents SearchThread As BackgroundWorker = New BackgroundWorker()
    Private WithEvents FillThread As BackgroundWorker = New BackgroundWorker()
    Private WithEvents FillWithDelayThread As BackgroundWorker = New BackgroundWorker()
    Private WithEvents DequeueAndCheckThread As BackgroundWorker = New BackgroundWorker()
    Private WithEvents ATCThread As BackgroundWorker = New BackgroundWorker()
    Private Sub B_options_Click(sender As Object, e As EventArgs) Handles B_options.Click
        settings.Show()
    End Sub
    Private Sub ATCThread_DoWork(ByVal sender As System.Object, ByVal e As DoWorkEventArgs) Handles ATCThread.DoWork
        WriteLog("--------------ATC--------------")
        If driver.FindElementSafe(By.XPath("//b[@class='button sold-out']")) Is Nothing Then
            Dim addButton = driver.FindElement(By.XPath("//input[@name='commit']"))
            'no size options or "any"
            If driver.FindElementSafe(By.XPath("//select")) Is Nothing Or ItemsArray(0).Item("Size").ToString = "any" Then
                addButton.Click()
                WriteLog("ANY SIZE TAKED")
                DequeueAndCheckThread.RunWorkerAsync()
            Else 'finding size
                Dim sizeFound As Boolean = False

                For Each optionElem As IWebElement In driver.FindElements(By.XPath("//select[@name='size']/option"))
                    If optionElem.Text.IndexOf(ItemsArray(0).Item("Size").ToString) > -1 Then

                        'if size founded
                        sizeFound = True
                        WriteLog("SIZE FOUNDED")

                        WriteLog("Select size")
                        optionElem.Click() 'выбираем сайз

                        WriteLog("Add item")
                        addButton.Click() ' добавляем в корзину

                        WriteLog(ItemsArray(0).Item("Size").ToString + "TAKED")
                        DequeueAndCheckThread.RunWorkerAsync()
                        Exit For
                    End If
                Next

                If sizeFound = False Then
                    If ItemsArray(0).Item("IfItemNoSize").ToString = "any" Then
                        addButton.Click() ' добавляем в корзину
                        WriteLog("ANY SIZE TAKED")
                        DequeueAndCheckThread.RunWorkerAsync()
                    ElseIf ItemsArray(0).Item("IfItemNoSize").ToString = "skip" Then
                        WriteLog("NO ADD, SKIP")
                        DequeueAndCheckThread.RunWorkerAsync()
                    End If
                End If
            End If
        Else
            WriteLog("NO ADD, Item sold out")
            DequeueAndCheckThread.RunWorkerAsync()
        End If
    End Sub
    Private Sub SearchThread_DoWork(ByVal sender As System.Object, ByVal e As DoWorkEventArgs) Handles SearchThread.DoWork
        WriteLog("--------------Search--------------")
        searching = True
        If ItemsArray.Length > 0 Then
            WriteLog("Searching started")
            Dim url As String

            Dim ItemCategory As String = ItemsArray(0).Item("Category")

            Select Case ItemCategory
                Case "jackets"
                    url = "http://www.supremenewyork.com/shop/all/jackets"
                Case "shirts"
                    url = "http://www.supremenewyork.com/shop/all/shirts"
                Case "tops/sweaters"
                    url = "http://www.supremenewyork.com/shop/all/tops_sweaters"
                Case "sweatshirts"
                    url = "http://www.supremenewyork.com/shop/all/sweatshirts"
                Case "pants"
                    url = "http://www.supremenewyork.com/shop/all/pants"
                Case "shorts"
                    url = "http://www.supremenewyork.com/shop/all/shorts"
                Case "hats"
                    url = "http://www.supremenewyork.com/shop/all/hats"
                Case "accessories"
                    url = "http://www.supremenewyork.com/shop/all/accessories"
                Case "skate"
                    url = "http://www.supremenewyork.com/shop/all/skate"
                Case "t-shirts"
                    url = "http://www.supremenewyork.com/shop/all/t-shirts"
                Case "shoes"
                    url = "http://www.supremenewyork.com/shop/all/shoes"
                Case "bags"
                    url = "http://www.supremenewyork.com/shop/all/bags"
                Case Else
                    url = "http://www.supremenewyork.com/shop/all/"
            End Select

            Dim RegExKeyword = New Regex(Create_RegExp(ItemsArray(0).Item("Keyword").ToString.ToLower))  'создаем шаблон из кейворда (test tee - > t.*?e.*?s.*?t.*?.*?t.*?e.*?e.*?/)

            WriteLog("Get supreme items")
            Dim Web = New HtmlWeb()
            Dim doc = Web.Load(url)
            WriteLog("Supreme items getted success")

            Dim LastSameNameItemHref As String = ""

            Dim items = doc.DocumentNode.SelectNodes("//article")

            Dim findColors As Array = ItemsArray(0).Item("Colors")
            WriteLog("Start finding """ + ItemsArray(0).Item("Keyword").ToString + """")
            For Each findColor As String In findColors
                If searching Then
                    For Each item As HtmlNode In items
                        If searching Then
                            Dim name As String = item.ChildNodes(0).ChildNodes(1).ChildNodes(0).InnerText
                            Dim color As String = item.ChildNodes(0).ChildNodes(2).ChildNodes(0).InnerText

                            If Not item.ChildNodes(0).ChildNodes(0).ChildNodes.Count > 1 Then
                                If RegExKeyword.IsMatch(name.ToLower) Then

                                    Dim RegExColor = New Regex(Create_RegExp(findColor.ToLower)) 'создаем шаблон из цвета (white - > w.*?h.*?i.*?t.*?e.*?/)

                                    If RegExColor.IsMatch(color.ToLower) Then
                                        searching = False
                                        SearchTimer.Stop()
                                        WriteLog("Item with SEARCHING color found")
                                        Dim href As String = item.ChildNodes(0).ChildNodes(0).Attributes("href").Value

                                        ' go to item
                                        driver.Navigate.GoToUrl("http://www.supremenewyork.com" + href)
                                        ATCThread.RunWorkerAsync()
                                        Exit Sub
                                    End If

                                    LastSameNameItemHref = item.ChildNodes(0).ChildNodes(0).Attributes("href").Value

                                End If
                            End If
                        End If
                    Next
                End If
            Next

            If (LastSameNameItemHref.Trim.Length > 0) And searching Then
                If ItemsArray(0).Item("IfItemNoStyle").ToString.ToLower = "next" Then
                    searching = False
                    SearchTimer.Stop()
                    WriteLog("Item with ANY color found")
                    driver.Navigate.GoToUrl("http://www.supremenewyork.com" + +LastSameNameItemHref)
                    ATCThread.RunWorkerAsync()
                    Exit Sub
                ElseIf ItemsArray(0).Item("IfItemNoStyle").ToString.ToLower = "skip" Then
                    searching = False
                    SearchTimer.Stop()
                    WriteLog("Item SKIPPED")

                    ItemsArray = ItemsArray.Skip(1).ToArray
                    WriteLog(ItemsArray.Length.ToString + " items left")

                    If ItemsArray.Length > 0 Then
                        WriteLog("Searching for next item")
                        SearchThread.RunWorkerAsync()
                    Else
                        WriteLog("No more items, redirecting to checkout page")
                        ' go to check out page
                        driver.Navigate.GoToUrl("http://www.supremenewyork.com/checkout")
                        Threading.Thread.Sleep(HScrollBar_GoToCheckOutDelay.Value)
                        FillWithDelayThread.RunWorkerAsync()
                    End If
                Else
                    WriteLog("Next search (High risk of getting a ban)")
                    SearchThread.RunWorkerAsync()
                End If
            Else
                WriteLog("No one item not found")
            End If
        Else
            MessageBox.Show("Добавте вещи в очередь", "Ошибка")
        End If
    End Sub
    Private Sub DequeueAndCheckThread_DoWork(ByVal sender As System.Object, ByVal e As DoWorkEventArgs) Handles DequeueAndCheckThread.DoWork
        'Функция удаляет 1ую вещь из очереди и чекает есть ли еще вещи, если есть, ищет дальше, если нет ОПЛАТА
        WriteLog("--------------dequeueAndCheck--------------")

        ItemsArray = ItemsArray.Skip(1).ToArray
        WriteLog(ItemsArray.Length.ToString + " items left")
        If (ItemsArray.Length > 0) Then
            WriteLog("searching for next item")
            SearchThread.RunWorkerAsync()
        Else
            WriteLog("no more items, redirecting to checkout page")
            Threading.Thread.Sleep(HScrollBar_GoToCheckOutDelay.Value)
            driver.Navigate.GoToUrl("http://www.supremenewyork.com/checkout")
            FillWithDelayThread.RunWorkerAsync()
        End If
    End Sub
    Private Sub GoToUrlThread_DoWork(ByVal sender As System.Object, ByVal e As DoWorkEventArgs) Handles GoToUrlThread.DoWork
        WriteLog("Go to " + e.Argument.ToString)
        driver.Navigate.GoToUrl(e.Argument.ToString)
    End Sub
    Private Sub FillWithDelayThread_DoWork(ByVal sender As System.Object, ByVal e As DoWorkEventArgs) Handles FillWithDelayThread.DoWork
        WriteLog("---------AUTO FILL WITH DELAY---------")
        Dim Name = My.Settings.Name
        Dim Email = My.Settings.Email
        Dim Tel = My.Settings.Tel
        Dim Address1 = My.Settings.Address1
        Dim Address2 = My.Settings.Address2
        Dim Address3 = My.Settings.Address3
        Dim City = My.Settings.City
        Dim Postcode = My.Settings.Postcode
        Dim Country = My.Settings.Country
        Dim Type = My.Settings.Type
        Dim Number = My.Settings.Number
        Dim Month = My.Settings.Month
        Dim Year = My.Settings.Year
        Dim CVV = My.Settings.CVV

        If Name.Trim.Length <> 0 And Email.Trim.Length <> 0 And Tel.Trim.Length <> 0 And Address1.Trim.Length <> 0 And City.Trim.Length <> 0 And Postcode.Trim.Length <> 0 And Country.Trim.Length <> 0 And Type.Trim.Length <> 0 And Number.Trim.Length <> 0 And Month.Trim.Length <> 0 And Year.Trim.Length <> 0 And CVV.Trim.Length <> 0 Then
            SendString(By.XPath("//*[@id='order_billing_name']"), Name, True)
            SendString(By.XPath("//*[@id='order_email']"), Email, True)
            SendString(By.XPath("//*[@id='order_tel']"), Tel, True)
            SendString(By.XPath("//*[@id='bo']"), Address1, True)
            SendString(By.XPath("//*[@id='oba3']"), Address2, True)
            SendString(By.XPath("//*[@id='order_billing_address_3']"), Address3, True)
            SendString(By.XPath("//*[@id='order_billing_city']"), City, True)
            SendString(By.XPath("//*[@id='order_billing_zip']"), Postcode, True)


            Dim dropdown = New SelectElement(driver.FindElement(By.XPath("//*[@id='order_billing_country']")))
            dropdown.SelectByText(Country)


            Dim dropdown1 = New SelectElement(driver.FindElement(By.XPath("//*[@id='credit_card_type']")))
            dropdown1.SelectByText(Type)

            SendString(By.XPath("//*[@id='cnb']"), Number, True)

            Dim dropdown2 = New SelectElement(driver.FindElement(By.XPath("//*[@id='credit_card_month']")))
            dropdown2.SelectByText(Month)

            Dim dropdown3 = New SelectElement(driver.FindElement(By.XPath("//*[@id='credit_card_year']")))
            dropdown3.SelectByText(Year)

            SendString(By.XPath("//*[@id='vval']"), CVV, True)

            driver.FindElements(By.XPath("//*[@class='iCheck-helper']")).Item(1).Click()
        Else
            MessageBox.Show("Заполните настройки AutoFill'a", "Ошибка", MessageBoxButtons.OK)
        End If
    End Sub
    Private Sub FillThread_DoWork(ByVal sender As System.Object, ByVal e As DoWorkEventArgs) Handles FillThread.DoWork
        WriteLog("--------------AUTO FILL--------------")
        Dim Name = My.Settings.Name
        Dim Email = My.Settings.Email
        Dim Tel = My.Settings.Tel
        Dim Address1 = My.Settings.Address1
        Dim Address2 = My.Settings.Address2
        Dim Address3 = My.Settings.Address3
        Dim City = My.Settings.City
        Dim Postcode = My.Settings.Postcode
        Dim Country = My.Settings.Country
        Dim Type = My.Settings.Type
        Dim Number = My.Settings.Number
        Dim Month = My.Settings.Month
        Dim Year = My.Settings.Year
        Dim CVV = My.Settings.CVV

        If Name.Trim.Length <> 0 And Email.Trim.Length <> 0 And Tel.Trim.Length <> 0 And Address1.Trim.Length <> 0 And City.Trim.Length <> 0 And Postcode.Trim.Length <> 0 And Country.Trim.Length <> 0 And Type.Trim.Length <> 0 And Number.Trim.Length <> 0 And Month.Trim.Length <> 0 And Year.Trim.Length <> 0 And CVV.Trim.Length <> 0 Then
            WriteLog("Fill name")
            SendString(By.XPath("//*[@id='order_billing_name']"), Name, False)
            WriteLog("Fill email")
            SendString(By.XPath("//*[@id='order_email']"), Email, False)
            WriteLog("Fill tel")
            SendString(By.XPath("//*[@id='order_tel']"), Tel, False)
            WriteLog("Fill address1")
            SendString(By.XPath("//*[@id='bo']"), Address1, False)
            WriteLog("Fill address2")
            SendString(By.XPath("//*[@id='oba3']"), Address2, False)
            WriteLog("Fill address3")
            SendString(By.XPath("//*[@id='order_billing_address_3']"), Address3, False)
            WriteLog("Fill city")
            SendString(By.XPath("//*[@id='order_billing_city']"), City, False)
            WriteLog("Fill postcode")
            SendString(By.XPath("//*[@id='order_billing_zip']"), Postcode, False)

            WriteLog("Select country")
            Dim dropdown = New SelectElement(driver.FindElement(By.XPath("//*[@id='order_billing_country']")))
            dropdown.SelectByText(Country)

            WriteLog("Select card type")
            Dim dropdown1 = New SelectElement(driver.FindElement(By.XPath("//*[@id='credit_card_type']")))
            dropdown1.SelectByText(Type)

            WriteLog("Fill car number")
            SendString(By.XPath("//*[@id='cnb']"), Number, False)

            WriteLog("Select card month")
            Dim dropdown2 = New SelectElement(driver.FindElement(By.XPath("//*[@id='credit_card_month']")))
            dropdown2.SelectByText(Month)

            WriteLog("Select card year")
            Dim dropdown3 = New SelectElement(driver.FindElement(By.XPath("//*[@id='credit_card_year']")))
            dropdown3.SelectByText(Year)

            WriteLog("Fill CVV")
            SendString(By.XPath("//*[@id='vval']"), CVV, False)

            WriteLog("Accept terms")
            driver.FindElements(By.XPath("//*[@class='iCheck-helper']")).Item(1).Click()

            WriteLog("Wait checkOut. " + HScrollBar_CheckOutDelay.Value.ToString + "ms.")
            Threading.Thread.Sleep(HScrollBar_CheckOutDelay.Value)
            If AutoProcessPayment_CheckBox.Checked Then
                WriteLog("Submit")
                driver.FindElement(By.XPath("//input[@name='commit']")).Click()
            End If
        Else
            MessageBox.Show("Заполните настройки AutoFill'a", "Ошибка")
        End If
    End Sub
    Private Sub StartBrowserThread_DoWork(ByVal sender As System.Object, ByVal e As DoWorkEventArgs) Handles StartBrowserThread.DoWork
        WriteLog("Try to starting browser")

        Dim DriverService = FirefoxDriverService.CreateDefaultService()
        DriverService.HideCommandPromptWindow = True

        driver = New FirefoxDriver(DriverService)

        WriteLog("Browser running success")
        Invoke(Sub()
                   Button1.Enabled = True
                   Button3.Enabled = True
                   Button4.Enabled = True
                   Button5.Enabled = True
                   Button6.Enabled = True
                   Button7.Enabled = True
                   Button8.Enabled = True
                   TimePicker.Enabled = True
               End Sub)
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If Not StartBrowserThread.IsBusy Then
            StartBrowserThread.RunWorkerAsync()
        Else
            WriteLog("StartBrowserThread is busy")
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If Not FillWithDelayThread.IsBusy Then
            FillWithDelayThread.RunWorkerAsync()
        Else
            WriteLog("FillWithDelayThread is busy")
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Not FillThread.IsBusy Then
            FillThread.RunWorkerAsync()
        Else
            WriteLog("FillThread is busy")
        End If
    End Sub

    Sub SendString(FieldBy As By, Str As String, OneChar As Boolean)
        If (Str.Length > 0) Then

            Dim DriverWait As WebDriverWait = New WebDriverWait(driver, TimeSpan.FromSeconds(5))
            DriverWait.Until(ExpectedConditions.ElementIsVisible(FieldBy))

            Dim FieldElement = driver.FindElement(FieldBy)
            If OneChar Then
                For Each Symbol In Str
                    FieldElement.SendKeys(Symbol)
                Next
            Else
                FieldElement.SendKeys(Str)
            End If
        End If
    End Sub

    Sub UpdateQueue()
        WriteLog("Update Queue")
        Panel_Queue.Controls.Clear()
        Dim T As Integer = 10
        Dim i As Integer = 1
        For Each ItemArray As Hashtable In ItemsArray
            Dim colors As String = ""
            For Each color As String In ItemArray.Item("Colors")
                colors = colors + color + ", "
            Next

            Dim ItemLabel As New Label() With {.Location = New Point(10, T), .MaximumSize = New Point(GB_Queue.Size.Width - 10, 0), .AutoSize = True, .Text = i.ToString + ". " + ItemArray.Item("Category") + " | " + ItemArray.Item("Size") + " | " + ItemArray.Item("Keyword") + " | " + ItemArray.Item("IfItemNoSize") + " | " + ItemArray.Item("IfItemNoStyle") + " | " + colors}
            Panel_Queue.Controls.Add(ItemLabel)
            T += ItemLabel.Height + 5
            i += 1
        Next
        WriteLog("Queue updated")
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GoToCheckOutDelayValue_Label.Text = HScrollBar_GoToCheckOutDelay.Value
        SearchInterval_Label.Text = HScrollBar_SearchInterval.Value
        CheckOutDelay_Label.Text = HScrollBar_CheckOutDelay.Value
    End Sub

    Private Sub HScrollBar_GoToCheckOutDelay_ValueChanged(sender As Object, e As EventArgs) Handles HScrollBar_GoToCheckOutDelay.ValueChanged
        GoToCheckOutDelay = HScrollBar_GoToCheckOutDelay.Value
        GoToCheckOutDelayValue_Label.Text = HScrollBar_GoToCheckOutDelay.Value
    End Sub

    Private Sub HScrollBar_SearchInterval_ValueChanged(sender As Object, e As EventArgs) Handles HScrollBar_SearchInterval.ValueChanged
        SearchInterval = HScrollBar_SearchInterval.Value
        SearchInterval_Label.Text = HScrollBar_SearchInterval.Value
    End Sub

    Private Sub HScrollBar_CheckOutDelay_ValueChanged(sender As Object, e As EventArgs) Handles HScrollBar_CheckOutDelay.ValueChanged
        CheckOutDelay = HScrollBar_CheckOutDelay.Value
        CheckOutDelay_Label.Text = HScrollBar_CheckOutDelay.Value
    End Sub

    Private Sub AutoProcessPayment_CheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles AutoProcessPayment_CheckBox.CheckedChanged
        AutoProcessPayment = AutoProcessPayment_CheckBox.Checked
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles CaptchaToken_TextBox.TextChanged
        CaptchaToken = CaptchaToken_TextBox.Text
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If Not GoToUrlThread.IsBusy Then
            GoToUrlThread.RunWorkerAsync("https://accounts.google.com/signin")
        Else
            WriteLog("GoToUrlThread is busy")
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If ItemsArray.Length = 0 Then
            MessageBox.Show("Добавте вещи в очередь", "Ошибка")
        Else
            If TimePicker.Checked Then
                StartTimer.Start()
            Else
                SearchingTimerStart()
            End If
            TimePicker.Enabled = False
            Button5.Enabled = False
            StopButton.Enabled = True
        End If
    End Sub
    Private Sub StartTimerTick(sender As Object, e As EventArgs) Handles StartTimer.Tick
        timeLeft = (TimePicker.Value.TimeOfDay - DateTime.Now.TimeOfDay).TotalSeconds
        If timeLeft > 0 Then
            timeLeft -= 1
            Label5.Text = timeLeft & " seconds"
        Else
            StartTimer.Stop()
            Label5.Text = "Starting!"
            SearchingTimerStart()
        End If
    End Sub
    Private Sub SearchTimerTick(sender As Object, e As EventArgs) Handles SearchTimer.Tick
        If Not SearchThread.IsBusy Then
            SearchThread.RunWorkerAsync()
        End If
    End Sub

    Sub SearchingTimerStart()
        If searching Then
            searching = False
            SearchTimer.Stop()
            SearchTimer.Interval = HScrollBar_SearchInterval.Value
            SearchTimer.Start()
        Else
            SearchTimer.Interval = HScrollBar_SearchInterval.Value
            SearchTimer.Start()
        End If
    End Sub
    Function Create_RegExp(Keyword As String) As String
        Dim Reg As String = ".*?"
        'перебор строки
        For Each Character As Char In Keyword
            Reg = Reg + Character.ToString + ".*?"
        Next
        Return Reg
    End Function
    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        If Not SearchThread.IsBusy Then
            SearchThread.RunWorkerAsync()
        Else
            WriteLog("SearchThread is busy")
        End If
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        If Not ATCThread.IsBusy Then
            ATCThread.RunWorkerAsync()
        Else
            WriteLog("ATCThread is busy")
        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        If Not GoToUrlThread.IsBusy Then
            GoToUrlThread.RunWorkerAsync("https://www.supremenewyork.com/")
        Else
            WriteLog("GoToUrlThread is busy")
        End If
    End Sub

    Public Sub WriteLog(str As String)
        Invoke(Sub()
                   log_label.Text = log_label.Text + Environment.NewLine + "[" + DateTime.Now.ToLongTimeString + "] " + str
               End Sub)
    End Sub

    Private Sub StopButton_Click(sender As Object, e As EventArgs) Handles StopButton.Click
        StartTimer.Stop()
        SearchTimer.Stop()
        StopButton.Enabled = False
        TimePicker.Enabled = True
        Button5.Enabled = True
        Label5.Text = "Time"
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Diagnostics.Process.Start("http://www.kr3nd31.ru")
        Diagnostics.Process.Start("http://vk.com/kr3nd31")
        Diagnostics.Process.Start("http://vk.com/kr3sb")
    End Sub
End Class

Module texs
    <Extension()>
    Public Function FindElementSafe(ByVal driver As IWebDriver, ByVal by As By) As IWebElement
        Try
            Return driver.FindElement(by)
        Catch NoSuch As NoSuchElementException
            Return Nothing
        End Try
    End Function
End Module