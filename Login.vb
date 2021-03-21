Imports System.Data.OleDb
Public Class Login

    Dim con As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\Coffe Shop\Coffe Shop.accdb")
    Dim cmd As OleDbCommand
    Dim dr As OleDbDataReader
    Dim str As String
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim cnt As Integer
        cnt = 1
        str = "select * from Login where username='" + TextBox1.Text + "' and password='" + TextBox2.Text + "'"
        cmd = New OleDbCommand(str, con)
        Try
            dr = cmd.ExecuteReader
            If dr.HasRows Then
                MsgBox("Login succeesfully", MsgBoxStyle.Information + MsgBoxStyle.OkCancel)
                TextBox1.Text = ""
                TextBox2.Text = ""
                Me.Hide()
                MDI.Show()
                'con.Close()
            Else
                MsgBox("Login Failed", MsgBoxStyle.Critical + MsgBoxStyle.OkCancel)
                Me.Close()
                cnt = cnt + 1

                If cnt = 3 Then
                    MsgBox("sorry", MsgBoxStyle.Critical)
                    Me.Close()
                End If
            End If

        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Critical)
        End Try

        'Me.Hide()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Hide()
    End Sub

    Private Sub Login_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        con.Open()
    End Sub
End Class