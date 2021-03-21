Imports CrystalDecisions.CrystalReports.Engine
Imports System.Data.OleDb

Public Class Bill

    Private Sub CrystalReportViewer1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CrystalReportViewer1.Load
        Dim rpt As New ReportDocument
        Dim con As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\Coffe Shop\Coffe Shop.accdb")


        Try
            Dim a As New CustomerBill

            Dim str As String = "select * from CustomerOrder where o_no=" & Order.TextBox1.Text & ""
            Dim adb As New OleDbDataAdapter(str, con)

            Dim ds As New DataSet
            adb.Fill(ds, "CustomerOrder")

            a.SetDataSource(ds.Tables(0))
            CrystalReportViewer1.ReportSource = a
            CrystalReportViewer1.Show()

        Catch ex As Exception
            MessageBox.Show(ex.ToString)

        End Try
    End Sub
End Class