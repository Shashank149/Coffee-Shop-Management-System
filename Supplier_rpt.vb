Imports CrystalDecisions.CrystalReports.Engine

Public Class Supplier_rpt

    Private Sub Supplier_rpt_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim rpt As New ReportDocument

        rpt.Load("D:\Coffe Shop\CoffeShop\SupplierReport.rpt")

        CrystalReportViewer1.ReportSource = rpt
        CrystalReportViewer1.Refresh()
    End Sub
End Class