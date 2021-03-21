Public Class MDI

    Private Sub EmployeeRegistrationToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EmployeeRegistrationToolStripMenuItem.Click
        NewEmployee.Show()
        Me.Hide()
    End Sub

    Private Sub ExistingEmployeeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExistingEmployeeToolStripMenuItem.Click
        ExistingEmployee.Show()
        Me.Hide()
    End Sub

    Private Sub CustomerRegistrationToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CustomerRegistrationToolStripMenuItem.Click
        Customer.Show()
        Me.Hide()
    End Sub

    Private Sub ExistingCustomerToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExistingCustomerToolStripMenuItem.Click
        ExistingCustomer.Show()
        Me.Hide()
    End Sub

    Private Sub SupplierToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SupplierToolStripMenuItem1.Click
        NewSupplier.Show()
        Me.Hide()
    End Sub

    Private Sub ExistingSupplierToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExistingSupplierToolStripMenuItem.Click
        ExistingSupplier.Show()
        Me.Hide()

    End Sub

    Private Sub ProductRegistrationToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProductRegistrationToolStripMenuItem.Click
        NewProduct.Show()
        Me.Hide()
    End Sub

    Private Sub ExistingProductToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExistingProductToolStripMenuItem.Click
        ExistingProduct.Show()
        Me.Hide()
    End Sub

    Private Sub CustomerOrderToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CustomerOrderToolStripMenuItem.Click
        Order.Show()
        Me.Hide()
    End Sub

    Private Sub SupplierOrderToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SupplierOrderToolStripMenuItem.Click
        SupplierOrder.Show()
        Me.Hide()
    End Sub

    Private Sub EXITToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EXITToolStripMenuItem.Click
        Login.Show()
        Me.Hide()
    End Sub

    Private Sub EmployeeReportToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EmployeeReportToolStripMenuItem.Click
        Employee_rpt.Show()
    End Sub

    Private Sub CustomerReportToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CustomerReportToolStripMenuItem.Click
        customer_rpt.Show()
    End Sub

    Private Sub SupplierReportToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SupplierReportToolStripMenuItem.Click
        Supplier_rpt.Show()
    End Sub

    Private Sub ProductReportToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProductReportToolStripMenuItem.Click
        Product_rpt.Show()
    End Sub
End Class