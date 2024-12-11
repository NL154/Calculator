Imports System.Net.Security
Imports System.Math


Public Class Form1
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click, Button2.Click, Button3.Click, Button4.Click, Button5.Click, Button6.Click, Button8.Click, Button9.Click, Button0.Click, btnx.Click, div.Click
        Dim value = 0
        Dim btn = CType(sender, Button)
        TextBox1.Text = TextBox1.Text + btn.Text
    End Sub
    Dim Operation As String
    Dim Currentvalue As String



    Private Sub total(sender As Object, e As EventArgs) Handles btntotal.Click
        Try
            Select Case Operation
                Case "-"
                    Dim re As String = TextBox1.Text
                    Dim result As String
                    result = (Currentvalue) - (re)
                    TextBox1.Text = result
                Case "+"
                    Dim news As String = TextBox1.Text
                    Dim result As String
                    result = Val(news) + Val(Currentvalue)
                    TextBox1.Text = result
                Case "x"
                    Dim rt As String = TextBox1.Text
                    Dim result As String
                    result = Currentvalue * rt
                    TextBox1.Text = result
                Case "/"
                    Dim di As String = TextBox1.Text
                    Dim result As String
                    result = Currentvalue / di
                    TextBox1.Text = result
            End Select
        Catch ex As Exception
            MessageBox.Show("Invalid input.")
            TextBox1.Clear()
        End Try

    End Sub
    Private Sub btnsqrt_Click(sender As Object, e As EventArgs) Handles btnsqrt.Click
        Try
            Dim upt As String = TextBox1.Text
            Dim result As Double = Math.Sqrt(upt)
            TextBox1.Text = result
        Catch ex As Exception
            MessageBox.Show("Invalid")
            TextBox1.Clear()
        End Try
    End Sub
    Private Sub clear_Click(sender As Object, e As EventArgs) Handles btnclear.Click
        TextBox1.Clear()
    End Sub
    Private Sub p(sender As Object, e As EventArgs) Handles btnp.Click
        Operation = "+"
        Currentvalue = TextBox1.Text
        TextBox1.Clear()
    End Sub

    Private Sub subtr_Click(sender As Object, e As EventArgs) Handles subtr.Click
        Operation = "-"
        Currentvalue = TextBox1.Text
        TextBox1.Clear()
    End Sub

    Private Sub btnx_Click(sender As Object, e As EventArgs) Handles btnx.Click
        Operation = "x"
        Currentvalue = TextBox1.Text
        TextBox1.Clear()
    End Sub

    Private Sub div_Click(sender As Object, e As EventArgs) Handles div.Click
        Operation = "/"
        Currentvalue = TextBox1.Text
        TextBox1.Clear()
    End Sub
End Class