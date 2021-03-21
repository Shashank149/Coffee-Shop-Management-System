Imports System.Data.OleDb
Public Class NewProduct
    Dim con As New OleDb.OleDbConnection(" Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\Coffe Shop\Coffe Shop.accdb")
    Dim cmd As OleDbCommand
    Dim qry As String
    Dim dr As OleDbDataReader
    Dim fda As OleDbDataAdapter
    Dim fds As DataSet
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or TextBox4.Text = "" Or ComboBox1.Text = "" Then
            MsgBox("null values are not allowed", MsgBoxStyle.Critical + MsgBoxStyle.OkCancel)


        Else : cmd = New OleDbCommand(qry, con)
        End If
        qry = "insert into Product values(" + TextBox1.Text + ",'" + TextBox2.Text + "','" + ComboBox1.Text + "','" + TextBox3.Text + "','" + TextBox4.Text + "')"

        cmd = New OleDbCommand(qry, con)
        Try
            cmd.ExecuteNonQuery()
            MsgBox("Product registered successfully", MsgBoxStyle.Information)
            clear()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try


    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        qry = "select max(p_id) from Product"
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

    Private Sub NewProduct_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        con.Open()
        qry = "select * from product"
        fda = New OleDbDataAdapter(qry, con)
        fds = New DataSet
        fda.Fill(fds)

        ComboBox1.Items.Add("Cappuccino")
        ComboBox1.Items.Add("Americano")
        ComboBox1.Items.Add("Espresso")
        ComboBox1.Items.Add("Mocha")
        ComboBox1.Items.Add("Macchiato")
    End Sub
    Private Sub clear()
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        ComboBox1.Text = "---SELECT---"


    End Sub
    Private Sub TextBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        If e.KeyChar >= "0" And e.KeyChar <= "9" Or e.KeyChar = Chr(Keys.Enter) Or e.KeyChar = vbBack Then
            e.Handled = False
        Else
            e.Handled = True
            MsgBox("Please Enter Numbers Only")
        End If
    End Sub

    Private Sub TextBox3_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox3.KeyPress
        If e.KeyChar >= "0" And e.KeyChar <= "9" Or e.KeyChar = Chr(Keys.Enter) Or e.KeyChar = vbBack Then
            e.Handled = False
        Else
            e.Handled = True
            MsgBox("Please Enter Numbers Only")
        End If
    End Sub

    Private Sub TextBox4_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox4.KeyPress
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
End Class