﻿Public Class Form6

    Private Sub Form6_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        labelitm.Location = New Point(labelitm.Left - picmumei.Left, labelitm.Top - picmumei.Top)
        labelitm.Parent = picmumei

        Dim total As Integer = 0

        Select Case triggerkeeb
            Case "1"
                labelshow1.Text = "WOB Rainy75"
                total += keebpr1
            Case "2"
                labelshow1.Text = "Kibou Suisei65"
                total += keebpr2
            Case "3"
                labelshow1.Text = "RK R65"
                total += keebpr3
        End Select

        Select Case triggerkit
            Case "1"
                labelshow2.Text = "KBd67 lite"
                total += kitpr
            Case "2"
                labelshow2.Text = "GMK67"
                total += kitpr2
            Case "3"
                labelshow2.Text = "Bakeneko65"
                total += kitpr3
        End Select

        Select Case triggerswitch
            Case "1"
                labelshow3.Text = "Cherry MX Red"
                total += switchpr1
            Case "2"
                labelshow3.Text = "Glorious Holy Pandas"
                total += switchpr2
            Case "3"
                labelshow3.Text = "Akko Lavender Purple V3 Pro"
                total += switchpr3
        End Select

        Select Case triggercap
            Case "1"
                labelshow4.Text = "PBTfans Doppleganger"
                total += cappr1
            Case "2"
                labelshow4.Text = "MATT30 MT3 Susuwatari"
                total += cappr2
            Case "3"
                labelshow4.Text = "KeyKobo Retro Mixed Lights"
                total += cappr3
        End Select

        labeltotal.Text = "₱ " & total.ToString()
    End Sub

    Private Sub btnback_Click(sender As Object, e As EventArgs) Handles btnback.Click
        Form1.Show()
        Me.Close()
    End Sub

End Class