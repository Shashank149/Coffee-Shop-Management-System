Imports System.Data.OleDb

Public Class Customer
    Dim con As New OleDb.OleDbConnection(" Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\Coffe Shop\Coffe Shop.accdb")
    Dim cmd As OleDbCommand
    Dim qry As String
    Dim dr As OleDbDataReader
    Dim opt As String


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or TextBox4.Text = "" Or RadioButton1.Text = "" Or RadioButton2.Text = "" Then
            MsgBox("null values are not allowed", MsgBoxStyle.Critical + MsgBoxStyle.OkCancel)

        ElseIf RadioButton1.Checked = True Then
            opt = RadioButton1.Text
        Else
            opt = RadioButton2.Text

        End If

        qry = "insert into customer values(" + TextBox1.Text + ",'" + TextBox2.Text + "','" + opt + "','" + TextBox3.Text + "','" + TextBox4.Text + "','" + TextBox5.Text + "')"

        cmd = New OleDbCommand(qry, con)
        Try
            cmd.ExecuteNonQuery()
            MsgBox("CUSTOMER INFORMATION REGISTER", MsgBoxStyle.Information)
            clear()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub Customer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        con.Open()
    End Sub
    Private Sub clear()
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox5.Clear()
        RadioButton1.Checked = False
        RadioButton2.Checked = False
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        qry = "select max(c_id) from customer"
        Dim auto As Integer
        cmd = New OleDbCommand(qry, con)
        Try
            dr = cmd.ExecuteReader()
            If dr.Read Then
                auto = dr.Item(0)
                TextBox1.Text = auto + 1

            End If
            dr.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        clear()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        MDI.Show()
        Me.Hide()

    End Sub

    Private Sub TextBox3_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox3.KeyPress
        If e.KeyChar >= "0" And e.KeyChar <= "9" Or e.KeyChar = Chr(Keys.Enter) Or e.KeyChar = vbBack Then
            e.Handled = False
        Else
            e.Handled = True
            MsgBox("Please Enter Numbers Only")
        End If
       
    End Sub

    Private Sub TextBox2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox2.KeyPress
        If e.KeyChar >= "0" And e.KeyChar <= "9" Then
            e.Handled = True
            MsgBox("Numbers not allowed")
        Else
            e.Handled = False

        End If
    End Sub



    Private Sub TextBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        If e.KeyChar >= "0" And e.KeyChar <= "9" Or e.KeyChar = Chr(Keys.Enter) Or e.KeyChar = vbBack Then
            e.Handled = False
        Else
            e.Handled = True
            MsgBox("Please Enter Numbers Only")
        End If
    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub


    
    Private Sub TextBox4_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox4.TextChanged
      
    End Sub

    Private Sub TextBox4_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox4.Validated
        Dim regex As System.Text.RegularExpressions.Regex = New System.Text.RegularExpressions.Regex("^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$")
        Dim isValid As Boolean = regex.IsMatch(TextBox4.Text.Trim)
        If Not isValid Then
            MessageBox.Show("Invalid Email.")
        End If
    End Sub

    Private Sub TextBox3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox3.TextChanged
        
    End Sub

    Private Sub TextBox3_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox3.Validated
        If Len(TextBox3.Text) < 10 Then
            MsgBox("Contact Should Be Of 10 Digits")
        End If
    End Sub

    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class