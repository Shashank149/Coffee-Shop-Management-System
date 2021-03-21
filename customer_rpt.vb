Imports CrystalDecisions.CrystalReports.Engine
Public Class customer_rpt

    Private Sub customer_rpt_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim rpt As New ReportDocument

        rpt.Load("D:\Coffe Shop\CoffeShop\customer.rpt")

        CrystalReportViewer1.ReportSource = rpt
        CrystalReportViewer1.Refresh()


    End Sub

    Private Sub CrystalReportViewer6_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CrystalReportViewer6.Load

    End Sub
End Class