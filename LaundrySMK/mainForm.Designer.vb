<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class mainForm
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MainToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Maste4rEmployeeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ManageServiceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ManagePackageToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TransactionDespositToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PrepaidPackageToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewTransactionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MainToolStripMenuItem, Me.Maste4rEmployeeToolStripMenuItem, Me.ManageServiceToolStripMenuItem, Me.ManagePackageToolStripMenuItem, Me.TransactionDespositToolStripMenuItem, Me.PrepaidPackageToolStripMenuItem, Me.ViewTransactionToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 24)
        Me.MenuStrip1.TabIndex = 8
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MainToolStripMenuItem
        '
        Me.MainToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LogoutToolStripMenuItem})
        Me.MainToolStripMenuItem.Name = "MainToolStripMenuItem"
        Me.MainToolStripMenuItem.Size = New System.Drawing.Size(46, 20)
        Me.MainToolStripMenuItem.Text = "Main"
        '
        'LogoutToolStripMenuItem
        '
        Me.LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem"
        Me.LogoutToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.LogoutToolStripMenuItem.Text = "Logout"
        '
        'Maste4rEmployeeToolStripMenuItem
        '
        Me.Maste4rEmployeeToolStripMenuItem.Name = "Maste4rEmployeeToolStripMenuItem"
        Me.Maste4rEmployeeToolStripMenuItem.Size = New System.Drawing.Size(110, 20)
        Me.Maste4rEmployeeToolStripMenuItem.Text = "Master Employee"
        '
        'ManageServiceToolStripMenuItem
        '
        Me.ManageServiceToolStripMenuItem.Name = "ManageServiceToolStripMenuItem"
        Me.ManageServiceToolStripMenuItem.Size = New System.Drawing.Size(102, 20)
        Me.ManageServiceToolStripMenuItem.Text = "Manage Service"
        '
        'ManagePackageToolStripMenuItem
        '
        Me.ManagePackageToolStripMenuItem.Name = "ManagePackageToolStripMenuItem"
        Me.ManagePackageToolStripMenuItem.Size = New System.Drawing.Size(109, 20)
        Me.ManagePackageToolStripMenuItem.Text = "Manage Package"
        '
        'TransactionDespositToolStripMenuItem
        '
        Me.TransactionDespositToolStripMenuItem.Name = "TransactionDespositToolStripMenuItem"
        Me.TransactionDespositToolStripMenuItem.Size = New System.Drawing.Size(127, 20)
        Me.TransactionDespositToolStripMenuItem.Text = "Transaction Desposit"
        '
        'PrepaidPackageToolStripMenuItem
        '
        Me.PrepaidPackageToolStripMenuItem.Name = "PrepaidPackageToolStripMenuItem"
        Me.PrepaidPackageToolStripMenuItem.Size = New System.Drawing.Size(103, 20)
        Me.PrepaidPackageToolStripMenuItem.Text = "PrepaidPackage"
        '
        'ViewTransactionToolStripMenuItem
        '
        Me.ViewTransactionToolStripMenuItem.Name = "ViewTransactionToolStripMenuItem"
        Me.ViewTransactionToolStripMenuItem.Size = New System.Drawing.Size(107, 20)
        Me.ViewTransactionToolStripMenuItem.Text = "View Transaction"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(315, 204)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(128, 25)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "WELCOME"
        '
        'mainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Name = "mainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "mainForm"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents MainToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LogoutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Maste4rEmployeeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ManageServiceToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ManagePackageToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TransactionDespositToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PrepaidPackageToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ViewTransactionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label1 As Label
End Class
