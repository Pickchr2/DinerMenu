﻿'Christopher Pickens
'RCET0265
'Spring 2023
'Diner Menu
'https://github.com/Pickchr2/DinerMenu.git

Option Explicit On
Option Strict On

Public Class DinerMenuForm
    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click, ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub SoupButton_Click(sender As Object, e As EventArgs) Handles SoupButton.Click, SoupToolStripMenuItem.Click
        DisplaySpecialLabel.Text = "~Grandma's Garden-Fresh Giambotta~" _
        & vbCrLf & vbCrLf _
        & "A wonderful, Italian vegetable stew, preparred with stewed tomatoes, green beans, diced potatoes, sliced mushrooms, ground hot Italian sausage, and a spledid blend of Italian herbs and spices!" _
        & vbCrLf & vbCrLf _
        & "Served with a slice of buttery garlic ciabatta bread!"
    End Sub

    Private Sub SaladButton_Click(sender As Object, e As EventArgs) Handles SaladButton.Click, SaladToolStripMenuItem.Click
        DisplaySpecialLabel.Text = "~Mom's Simple Caesar Salad~" _
        & vbCrLf & vbCrLf _
        & "This really is the best homemade Caesar salad! With crunchy romaine lettuce, finely shredded parmesan cheese, and a robust, creamy homemade caesar salad dressing." _
        & vbCrLf & vbCrLf _
        & "Served with a hardy handful of garlic herb croutons!"
    End Sub

    Private Sub FishButton_Click(sender As Object, e As EventArgs) Handles FishButton.Click, FishToolStripMenuItem.Click
        DisplaySpecialLabel.Text = "~Dad's Secret Smoked Salmon~" _
        & vbCrLf & vbCrLf _
        & "This smoked salmon has an unmatched depth of flavor. It is smoky, for sure, but also has a very delicate, fresh taste, topped with a tangy citrus drizzle." _
        & vbCrLf & vbCrLf _
        & "Served with a side of herb roasted red potatoes and your choice of broccoli, brussel sprouts, or asparagus!"
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        MessageBox.Show("Christopher's Hole in the Wall cafe is the homade dining experience you've been waiting for! Press a button below to see our daily specials!")
    End Sub
End Class
