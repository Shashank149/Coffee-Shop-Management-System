Imports System.Data.OleDb

Public Class ExistingProduct
    Dim con As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\Coffe Shop\Coffe Shop.accdb")
    Dim cmd, idcmd As OleDbCommand
    Dim da As OleDbDataAdapter
    Dim ds As DataSet
    Dim qry As String
    Dim rd As String
    Dim dr As OleDbDataReader
    Private Sub ExistingProduct_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        con.Open()
        Dim qry1 As String
        qry1 = "select * from product"
        da = New OleDbDataAdapter(qry1, con)
        ds = New DataSet
        da.Fill(ds)

        ComboBox1.DataSource = ds.Tables(0)
        ComboBox1.DisplayMember = "p_id"
        ComboBox1.ValueMember = "p_id"


        ComboBox2.Items.Add("Sports")
        ComboBox2.Items.Add("Casual")
        ComboBox2.Items.Add("Canvas")
        ComboBox2.Items.Add("Loafers")
        ComboBox2.Items.Add("Formal")
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        qry = "select * from product"
        da = New OleDbDataAdapter(qry, con)
        ds = New DataSet
        da.Fill(ds)
        For Each row As DataRow In ds.Tables(0).Rows
            If ComboBox1.Text = row(0).ToString Then
                TextBox1.Text = row(1).ToString
                ComboBox2.Text = row(2).ToString
                TextBox2.Text = row(3).ToString
                TextBox3.Text = row(4).ToString



            End If

        Next
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or ComboBox1.Text = "" Or ComboBox2.Text = "" Then
            MsgBox("null values are not allowed", MsgBoxStyle.Critical + MsgBoxStyle.OkCancel)

        Else : qry = "UPDATE product set p_name='" + TextBox1.Text + "',p_type='" + ComboBox2.Text + "',p_price=" + TextBox2.Text + ",p_quantity=" + TextBox3.Text + " where p_id=" + ComboBox1.Text + ""
            cmd = New OleDbCommand(qry, con)

            Try

                cmd.ExecuteNonQuery()
                MessageBox.Show("Updated successfully")
                clear()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        clear()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        MDI.Show()
        Me.Hide()
    End Sub
    Private Sub clear()

        ComboBox1.Text = "---SELECT---"
        ComboBox2.Text = "---SELECT---"
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()

    End Sub
    Private Sub TextBox2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox2.KeyPress
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

    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class