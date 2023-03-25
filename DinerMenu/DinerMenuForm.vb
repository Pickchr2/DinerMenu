﻿'Christopher Pickens
'RCET0265
'Spring 2023
'Diner Menu
'https://github.com/Pickchr2/DinerMenu.git

Option Explicit On
Option Strict On

Public Class DinerMenuForm
    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub

    Private Sub SoupButton_Click(sender As Object, e As EventArgs) Handles SoupButton.Click
        DisplaySpecialLabel.Text = "~Grandma's Giambotta~" _
        & vbCrLf & vbCrLf _
        & "A wonderful, Italian vegetable stew, preparred with stewed tomatoes, green beans, diced potatoes, sliced mushrooms, ground hot Italian sausage, and a spledid blend of Italian herbs and spices!" _
        & vbCrLf & vbCrLf _
        & "Served with a slice of buttery garlic ciabatta bread!"
    End Sub
End Class
