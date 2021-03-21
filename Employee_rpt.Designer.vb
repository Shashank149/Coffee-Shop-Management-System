<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Employee_rpt
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
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.EmployeeReport2 = New CoffeShop.EmployeeReport
        Me.EmployeeReport1 = New CoffeShop.EmployeeReport
        Me.EmployeeReport3 = New CoffeShop.EmployeeReport
        Me.SuspendLayout()
        '
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.ActiveViewIndex = 0
        Me.CrystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.ReportSource = Me.EmployeeReport3
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(973, 706)
        Me.CrystalReportViewer1.TabIndex = 0
        '
        'Employee_rpt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(973, 706)
        Me.Controls.Add(Me.CrystalReportViewer1)
        Me.Name = "Employee_rpt"
        Me.Text = "Employee_rpt"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents EmployeeReport2 As CoffeShop.EmployeeReport
    Friend WithEvents EmployeeReport1 As CoffeShop.EmployeeReport
    Friend WithEvents EmployeeReport3 As CoffeShop.EmployeeReport
End Class
