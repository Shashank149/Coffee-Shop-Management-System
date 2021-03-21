Imports System.Data.OleDb
Public Class ExistingCustomer
    Dim con As New OleDb.OleDbConnection(" Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\Coffe Shop\Coffe Shop.accdb")
    Dim cmd, idcmd As OleDbCommand
    Dim da As OleDbDataAdapter
    Dim ds As DataSet
    Dim qry As String
    Dim rd As String
    Dim dr As OleDbDataReader
    Private Sub ExistingCustomer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        con.Open()
        Dim qry1 As String
        qry1 = "select * from customer"
        da = New OleDbDataAdapter(qry1, con)
        ds = New DataSet
        da.Fill(ds)

        ComboBox1.DataSource = ds.Tables(0)
        ComboBox1.DisplayMember = "c_id"
        ComboBox1.ValueMember = "c_id"

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim opt As String
        If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or TextBox4.Text = "" Or RadioButton1.Text = "" Or RadioButton2.Text = "" Or ComboBox1.Text = "" Then
            MsgBox("null values are not allowed", MsgBoxStyle.Critical + MsgBoxStyle.OkCancel)
        Else
            If RadioButton1.Checked = True Then
                opt = RadioButton1.Text
            Else
                opt = RadioButton2.Text
            End If
            qry = "UPDATE customer set c_name='" + TextBox1.Text + "',c_gender='" + opt + "',c_contact=" + TextBox2.Text + ",c_email='" + TextBox3.Text + "',c_address='" + TextBox4.Text + "' where c_id=" + ComboBox1.Text + ""
            cmd = New OleDbCommand(qry, con)
            If RadioButton1.Checked = True Then
                rd = RadioButton1.Text
            Else
                rd = RadioButton2.Text
            End If
            Try

                cmd.ExecuteNonQuery()
                MessageBox.Show("updated successfully")
                clear()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        MDI.Show()
        Me.Hide()
    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        clear()
    End Sub

    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        qry = "select * from customer"
        da = New OleDbDataAdapter(qry, con)
        ds = New DataSet
        da.Fill(ds)
        For Each row As DataRow In ds.Tables(0).Rows
            If ComboBox1.Text = row(0).ToString Then
                TextBox1.Text = row(1).ToString
                TextBox2.Text = row(3).ToString
                TextBox3.Text = row(4).ToString
                TextBox4.Text = row(5).ToString


                If row(2).ToString = "Male" Then
                    RadioButton1.Checked = True
                Else
                    RadioButton2.Checked = True

                End If

            End If

        Next
    End Sub
    Private Sub clear()

        ComboBox1.Text = "---SELECT---"
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        RadioButton1.Checked = False
        RadioButton2.Checked = False
    End Sub

    Private Sub TextBox2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox2.KeyPress
        If e.KeyChar >= "0" And e.KeyChar <= "9" Or e.KeyChar = Chr(Keys.Enter) Or e.KeyChar = vbBack Then
            e.Handled = False
        Else
            e.Handled = True
            MsgBox("Please Enter Numbers Only")
        End If
    End Sub

    Private Sub TextBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        If e.KeyChar >= "0" And e.KeyChar <= "9" Then
            e.Handled = True
            MsgBox("Numbers not allowed")
        Else
            e.Handled = False

        End If
    End Sub

    Private Sub TextBox3_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox3.KeyPress
      
    End Sub

    Private Sub TextBox3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox3.TextChanged

    End Sub

    Private Sub TextBox3_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox3.Validated
        Dim regex As System.Text.RegularExpressions.Regex = New System.Text.RegularExpressions.Regex("^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$")
        Dim isValid As Boolean = regex.IsMatch(TextBox4.Text.Trim)
        If Not isValid Then
            MessageBox.Show("Invalid Email.")
        End If
    End Sub

    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub TextBox2_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox2.Validated
        If Len(TextBox2.Text) < 10 Then
            MsgBox("Contact Should Be Of 10 Digits")
        End If
    End Sub
End Class