<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MDI
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MDI))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.EMPLOYEEToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.EmployeeRegistrationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ExistingEmployeeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CUSTOMERToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CustomerRegistrationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ExistingCustomerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SUPPLIERToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SupplierToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.ExistingSupplierToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.PRODUCTToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ProductRegistrationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ExistingProductToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.OrderToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CustomerOrderToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SupplierOrderToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.REPORTToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.EXITToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.EmployeeReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CustomerReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SupplierReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ProductReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EMPLOYEEToolStripMenuItem, Me.CUSTOMERToolStripMenuItem, Me.SUPPLIERToolStripMenuItem, Me.PRODUCTToolStripMenuItem, Me.OrderToolStripMenuItem, Me.REPORTToolStripMenuItem, Me.EXITToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(985, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'EMPLOYEEToolStripMenuItem
        '
        Me.EMPLOYEEToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EmployeeRegistrationToolStripMenuItem, Me.ExistingEmployeeToolStripMenuItem})
        Me.EMPLOYEEToolStripMenuItem.Name = "EMPLOYEEToolStripMenuItem"
        Me.EMPLOYEEToolStripMenuItem.Size = New System.Drawing.Size(77, 20)
        Me.EMPLOYEEToolStripMenuItem.Text = "EMPLOYEE"
        '
        'EmployeeRegistrationToolStripMenuItem
        '
        Me.EmployeeRegistrationToolStripMenuItem.Name = "EmployeeRegistrationToolStripMenuItem"
        Me.EmployeeRegistrationToolStripMenuItem.Size = New System.Drawing.Size(192, 22)
        Me.EmployeeRegistrationToolStripMenuItem.Text = "Employee Registration"
        '
        'ExistingEmployeeToolStripMenuItem
        '
        Me.ExistingEmployeeToolStripMenuItem.Name = "ExistingEmployeeToolStripMenuItem"
        Me.ExistingEmployeeToolStripMenuItem.Size = New System.Drawing.Size(192, 22)
        Me.ExistingEmployeeToolStripMenuItem.Text = "Existing Employee"
        '
        'CUSTOMERToolStripMenuItem
        '
        Me.CUSTOMERToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CustomerRegistrationToolStripMenuItem, Me.ExistingCustomerToolStripMenuItem})
        Me.CUSTOMERToolStripMenuItem.Name = "CUSTOMERToolStripMenuItem"
        Me.CUSTOMERToolStripMenuItem.Size = New System.Drawing.Size(81, 20)
        Me.CUSTOMERToolStripMenuItem.Text = "CUSTOMER"
        '
        'CustomerRegistrationToolStripMenuItem
        '
        Me.CustomerRegistrationToolStripMenuItem.Name = "CustomerRegistrationToolStripMenuItem"
        Me.CustomerRegistrationToolStripMenuItem.Size = New System.Drawing.Size(192, 22)
        Me.CustomerRegistrationToolStripMenuItem.Text = "Customer Registration"
        '
        'ExistingCustomerToolStripMenuItem
        '
        Me.ExistingCustomerToolStripMenuItem.Name = "ExistingCustomerToolStripMenuItem"
        Me.ExistingCustomerToolStripMenuItem.Size = New System.Drawing.Size(192, 22)
        Me.ExistingCustomerToolStripMenuItem.Text = "Existing Customer"
        '
        'SUPPLIERToolStripMenuItem
        '
        Me.SUPPLIERToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SupplierToolStripMenuItem1, Me.ExistingSupplierToolStripMenuItem})
        Me.SUPPLIERToolStripMenuItem.Name = "SUPPLIERToolStripMenuItem"
        Me.SUPPLIERToolStripMenuItem.Size = New System.Drawing.Size(72, 20)
        Me.SUPPLIERToolStripMenuItem.Text = " SUPPLIER"
        '
        'SupplierToolStripMenuItem1
        '
        Me.SupplierToolStripMenuItem1.Name = "SupplierToolStripMenuItem1"
        Me.SupplierToolStripMenuItem1.Size = New System.Drawing.Size(183, 22)
        Me.SupplierToolStripMenuItem1.Text = "Supplier Registration"
        '
        'ExistingSupplierToolStripMenuItem
        '
        Me.ExistingSupplierToolStripMenuItem.Name = "ExistingSupplierToolStripMenuItem"
        Me.ExistingSupplierToolStripMenuItem.Size = New System.Drawing.Size(183, 22)
        Me.ExistingSupplierToolStripMenuItem.Text = "Existing Supplier"
        '
        'PRODUCTToolStripMenuItem
        '
        Me.PRODUCTToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProductRegistrationToolStripMenuItem, Me.ExistingProductToolStripMenuItem})
        Me.PRODUCTToolStripMenuItem.Name = "PRODUCTToolStripMenuItem"
        Me.PRODUCTToolStripMenuItem.Size = New System.Drawing.Size(73, 20)
        Me.PRODUCTToolStripMenuItem.Text = "PRODUCT"
        '
        'ProductRegistrationToolStripMenuItem
        '
        Me.ProductRegistrationToolStripMenuItem.Name = "ProductRegistrationToolStripMenuItem"
        Me.ProductRegistrationToolStripMenuItem.Size = New System.Drawing.Size(182, 22)
        Me.ProductRegistrationToolStripMenuItem.Text = "Product Registration"
        '
        'ExistingProductToolStripMenuItem
        '
        Me.ExistingProductToolStripMenuItem.Name = "ExistingProductToolStripMenuItem"
        Me.ExistingProductToolStripMenuItem.Size = New System.Drawing.Size(182, 22)
        Me.ExistingProductToolStripMenuItem.Text = "Existing Product"
        '
        'OrderToolStripMenuItem
        '
        Me.OrderToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CustomerOrderToolStripMenuItem, Me.SupplierOrderToolStripMenuItem})
        Me.OrderToolStripMenuItem.Name = "OrderToolStripMenuItem"
        Me.OrderToolStripMenuItem.Size = New System.Drawing.Size(56, 20)
        Me.OrderToolStripMenuItem.Text = "ORDER"
        '
        'CustomerOrderToolStripMenuItem
        '
        Me.CustomerOrderToolStripMenuItem.Name = "CustomerOrderToolStripMenuItem"
        Me.CustomerOrderToolStripMenuItem.Size = New System.Drawing.Size(159, 22)
        Me.CustomerOrderToolStripMenuItem.Text = "Customer Order"
        '
        'SupplierOrderToolStripMenuItem
        '
        Me.SupplierOrderToolStripMenuItem.Name = "SupplierOrderToolStripMenuItem"
        Me.SupplierOrderToolStripMenuItem.Size = New System.Drawing.Size(159, 22)
        Me.SupplierOrderToolStripMenuItem.Text = "Supplier Order"
        '
        'REPORTToolStripMenuItem
        '
        Me.REPORTToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EmployeeReportToolStripMenuItem, Me.CustomerReportToolStripMenuItem, Me.SupplierReportToolStripMenuItem, Me.ProductReportToolStripMenuItem})
        Me.REPORTToolStripMenuItem.Name = "REPORTToolStripMenuItem"
        Me.REPORTToolStripMenuItem.Size = New System.Drawing.Size(62, 20)
        Me.REPORTToolStripMenuItem.Text = "REPORT"
        '
        'EXITToolStripMenuItem
        '
        Me.EXITToolStripMenuItem.Name = "EXITToolStripMenuItem"
        Me.EXITToolStripMenuItem.Size = New System.Drawing.Size(69, 20)
        Me.EXITToolStripMenuItem.Text = "LOG OUT"
        '
        'EmployeeReportToolStripMenuItem
        '
        Me.EmployeeReportToolStripMenuItem.Name = "EmployeeReportToolStripMenuItem"
        Me.EmployeeReportToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.EmployeeReportToolStripMenuItem.Text = "Employee Report"
        '
        'CustomerReportToolStripMenuItem
        '
        Me.CustomerReportToolStripMenuItem.Name = "CustomerReportToolStripMenuItem"
        Me.CustomerReportToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.CustomerReportToolStripMenuItem.Text = "Customer report"
        '
        'SupplierReportToolStripMenuItem
        '
        Me.SupplierReportToolStripMenuItem.Name = "SupplierReportToolStripMenuItem"
        Me.SupplierReportToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.SupplierReportToolStripMenuItem.Text = "Supplier Report"
        '
        'ProductReportToolStripMenuItem
        '
        Me.ProductReportToolStripMenuItem.Name = "ProductReportToolStripMenuItem"
        Me.ProductReportToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.ProductReportToolStripMenuItem.Text = "Product Report"
        '
        'MDI
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(985, 712)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "MDI"
        Me.Text = "MDI"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents EMPLOYEEToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EmployeeRegistrationToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExistingEmployeeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CUSTOMERToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CustomerRegistrationToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExistingCustomerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SUPPLIERToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SupplierToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExistingSupplierToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PRODUCTToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProductRegistrationToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExistingProductToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OrderToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents REPORTToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EXITToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CustomerOrderToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SupplierOrderToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EmployeeReportToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CustomerReportToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SupplierReportToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProductReportToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
