Imports System.Data.OleDb
Public Class SupplierOrder
    Dim con As New OleDb.OleDbConnection(" Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\Coffe Shop\Coffe Shop.accdb")
    Dim cmd As OleDbCommand
    Dim da As OleDbDataAdapter
    Dim ds As DataSet
    Dim qry As String
    Dim rd As String
    Dim dr As OleDbDataReader
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        qry = "select * from Supplier"
        da = New OleDbDataAdapter(qry, con)
        ds = New DataSet
        da.Fill(ds)
        For Each row As DataRow In ds.Tables(0).Rows
            If ComboBox1.Text = row(0).ToString Then

                TextBox2.Text = row(1).ToString

                TextBox4.Text = row(4).ToString
                TextBox6.Text = row(2).ToString
                TextBox5.Text = row(3).ToString


            End If

        Next
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        qry = "select * from product"
        da = New OleDbDataAdapter(qry, con)
        ds = New DataSet
        da.Fill(ds)
        For Each row As DataRow In ds.Tables(0).Rows
            If ComboBox2.Text = row(0).ToString Then

                TextBox7.Text = row(1).ToString
                ComboBox3.Text = row(2).ToString

                TextBox8.Text = row(3).ToString
                'TextBox9.Text = row(4).ToString



            End If

        Next
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click

        If TextBox9.Text = "" Then
            MsgBox("Please Select Quantity", MsgBoxStyle.Critical)
        Else

            ListBox1.Items.Add(ComboBox2.Text)
            ListBox2.Items.Add(TextBox7.Text)
            ListBox3.Items.Add(ComboBox3.Text)
            'ListBox4.Items.Add(TextBox8.Text)
            ListBox5.Items.Add(TextBox9.Text)
            Dim sum2 As Double
            sum2 = TextBox8.Text * TextBox9.Text

            ListBox4.Items.Add(sum2.ToString)




            MsgBox("Product Added successfully", MsgBoxStyle.Information)

            ComboBox2.Text = ""
            TextBox7.Text = ""
            ComboBox3.Text = ""

            TextBox8.Text = ""
            TextBox9.Text = ""



            Dim sum As Double
            For x As Integer = 0 To ListBox4.Items.Count - 1
                sum += Val(ListBox4.Items.Item(x).ToString)
            Next
            TextBox12.Text = sum.ToString

            Dim sum1 As Double
            For n As Integer = 0 To ListBox5.Items.Count - 1
                sum1 += Val(ListBox5.Items.Item(n).ToString)
            Next
            TextBox11.Text = sum1.ToString
        End If


    End Sub

    Private Sub SupplierOrder_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        con.Open()
        Dim qry1 As String
        qry1 = "select * from supplier"
        da = New OleDbDataAdapter(qry1, con)
        ds = New DataSet
        da.Fill(ds)

        ComboBox1.DataSource = ds.Tables(0)
        ComboBox1.DisplayMember = "s_id"
        ComboBox1.ValueMember = "s_id"



        Dim qry2 As String
        qry2 = "select * from product"
        da = New OleDbDataAdapter(qry2, con)
        ds = New DataSet
        da.Fill(ds)

        ComboBox2.DataSource = ds.Tables(0)
        ComboBox2.DisplayMember = "p_id"
        ComboBox2.ValueMember = "p_id"
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        clear()
    End Sub
    Private Sub clear()

        TextBox1.Clear()
        TextBox2.Clear()
        TextBox4.Clear()
        TextBox6.Clear()
        TextBox5.Clear()
        TextBox7.Clear()
        TextBox8.Clear()
        TextBox9.Clear()
        TextBox11.Clear()
        TextBox12.Clear()
        ComboBox1.Text = "---SELECT---"
        ComboBox2.Text = "---SELECT---"
        ComboBox3.Text = "---SELECT---"
        ListBox1.Items.Clear()
        ListBox2.Items.Clear()
        ListBox3.Items.Clear()
        ListBox4.Items.Clear()
        ListBox5.Items.Clear()
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        MDI.Show()
        Me.Hide()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Dim strQuery As String
        Dim con As New OleDb.OleDbConnection(" Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\Coffe Shop\Coffe Shop.accdb")
        con.Open()
        For index As Integer = 0 To ListBox1.Items.Count - 1
            strQuery = "INSERT INTO SupplierOrder(o_no,o_date,s_id,p_id,s_name,s_address,s_contact,s_email,t_qut,total,p_name,p_type,p_quantity,p_price) VALUES(" + TextBox1.Text + ",'" + DateTimePicker1.Text + "'," + ComboBox1.Text + "," + ListBox1.Items(index) + ",'" + TextBox2.Text + "','" + TextBox6.Text + "'," + TextBox5.Text + ",'" + TextBox4.Text + "'," + TextBox11.Text + "," + TextBox12.Text + ",'" + ListBox2.Items(index) + "','" + ListBox3.Items(index) + "'," + ListBox5.Items(index) + "," + ListBox4.Items(index) + ")"
            cmd = New OleDbCommand(strQuery, con)
            cmd.ExecuteNonQuery()
        Next

        MsgBox("SUPPLIER ORDER REGISTER", MsgBoxStyle.Information)
        clear()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        qry = "select max(o_no) from SupplierOrder"
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

End Class