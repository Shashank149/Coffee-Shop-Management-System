Imports CrystalDecisions.CrystalReports.Engine

Public Class Product_rpt

    Private Sub Product_rpt_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim rpt As New ReportDocument

        rpt.Load("D:\Coffe Shop\CoffeShop\ProductReport.rpt")

        CrystalReportViewer1.ReportSource = rpt
        CrystalReportViewer1.Refresh()

    End Sub
End Class