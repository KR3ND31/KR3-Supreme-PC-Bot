﻿Imports System.Drawing
Imports System.Linq
Imports System.Windows.Forms

Public Class ItemTab
    Public ItemTab As TabPage
    Private Sub Button1_Click(sender As Object, e As System.EventArgs) Handles AddButton.Click
        AddColor("")
    End Sub

    Sub AddColor(color As String)
        Dim lastColorPanel = ColorsPanel.Controls.OfType(Of Panel)().Last

        Dim lastColorPanelLocation = lastColorPanel.Location
        Dim lastColorPanelSize = lastColorPanel.Size

        ColorsPanel.Height += lastColorPanelSize.Height + 3

        Dim ColorPanel As New Panel() With {.Size = New Size(149, 20), .Location = lastColorPanelLocation + New Point(0, lastColorPanelSize.Height + 3)}
        Dim ColorInput As New TextBox() With {.Size = New Size(121, 20), .Text = color}
        Dim DeleteButton As New Button() With {.Size = New Size(20, 20), .Location = New Point(124, 0), .Text = "-"}


        ColorPanel.Controls.Add(ColorInput)
        ColorPanel.Controls.Add(DeleteButton)
        ColorsPanel.Controls.Add(ColorPanel)

        AddHandler DeleteButton.Click, AddressOf DeleteButtonClick

        AddButton.Location += New Point(0, ColorInput.Size.Height + 3)
    End Sub

    Private Sub DeleteButtonClick(sender As Button, e As System.EventArgs)
        If ColorsPanel.Controls.Contains(sender.Parent) Then
            Dim DelColorPanelIndex As Integer = ColorsPanel.Controls.IndexOf(sender.Parent)

            ColorsPanel.Controls.Remove(sender.Parent)

            For Each ColorControl As Control In ColorsPanel.Controls
                ' При удалении, смещаем все панели которые ниже удаляемой вверх, кроме тех, которые были выше и самой первой(0)
                If ColorsPanel.Controls.IndexOf(ColorControl) >= DelColorPanelIndex And ColorsPanel.Controls.IndexOf(ColorControl) <> 0 Then
                    ColorControl.Location -= New Point(0, 23)
                End If
            Next

            'Отнимает высоту Панели1, равную высоте последней панели + 3(отступ) 
            ColorsPanel.Height -= ColorsPanel.Controls.OfType(Of Panel)().Last.Height + 3

            'Отнимает локацию(высоту) Кнопки добавления(+), равную 23(20-поле ввода, 3-отступ) 
            AddButton.Location -= New Point(0, 23)

        End If
    End Sub

    Private Sub ItemDelete_Button_Click(sender As Object, e As System.EventArgs) Handles ItemDelete_Button.Click
        settings.ItemsTab.TabPages.Remove(ItemTab)
    End Sub
End Class