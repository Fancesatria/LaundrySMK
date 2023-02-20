<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class transactionDeposit
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.ViewTransactionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PrepaidPackageToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TransactionDespositToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ManagePackageToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ManageServiceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MainToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.Maste4rEmployeeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(520, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Search"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DataGridView1)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 54)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(775, 229)
        Me.GroupBox1.TabIndex = 14
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Header Deposit"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(22, 45)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(735, 163)
        Me.DataGridView1.TabIndex = 10
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(575, 19)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(182, 20)
        Me.TextBox1.TabIndex = 9
        '
        'ViewTransactionToolStripMenuItem
        '
        Me.ViewTransactionToolStripMenuItem.Name = "ViewTransactionToolStripMenuItem"
        Me.ViewTransactionToolStripMenuItem.Size = New System.Drawing.Size(107, 20)
        Me.ViewTransactionToolStripMenuItem.Text = "View Transaction"
        '
        'PrepaidPackageToolStripMenuItem
        '
        Me.PrepaidPackageToolStripMenuItem.Name = "PrepaidPackageToolStripMenuItem"
        Me.PrepaidPackageToolStripMenuItem.Size = New System.Drawing.Size(103, 20)
        Me.PrepaidPackageToolStripMenuItem.Text = "PrepaidPackage"
        '
        'TransactionDespositToolStripMenuItem
        '
        Me.TransactionDespositToolStripMenuItem.Name = "TransactionDespositToolStripMenuItem"
        Me.TransactionDespositToolStripMenuItem.Size = New System.Drawing.Size(127, 20)
        Me.TransactionDespositToolStripMenuItem.Text = "Transaction Desposit"
        '
        'ManagePackageToolStripMenuItem
        '
        Me.ManagePackageToolStripMenuItem.Name = "ManagePackageToolStripMenuItem"
        Me.ManagePackageToolStripMenuItem.Size = New System.Drawing.Size(109, 20)
        Me.ManagePackageToolStripMenuItem.Text = "Manage Package"
        '
        'ManageServiceToolStripMenuItem
        '
        Me.ManageServiceToolStripMenuItem.Name = "ManageServiceToolStripMenuItem"
        Me.ManageServiceToolStripMenuItem.Size = New System.Drawing.Size(102, 20)
        Me.ManageServiceToolStripMenuItem.Text = "Manage Service"
        '
        'LogoutToolStripMenuItem
        '
        Me.LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem"
        Me.LogoutToolStripMenuItem.Size = New System.Drawing.Size(112, 22)
        Me.LogoutToolStripMenuItem.Text = "Logout"
        '
        'MainToolStripMenuItem
        '
        Me.MainToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LogoutToolStripMenuItem})
        Me.MainToolStripMenuItem.Name = "MainToolStripMenuItem"
        Me.MainToolStripMenuItem.Size = New System.Drawing.Size(46, 20)
        Me.MainToolStripMenuItem.Text = "Main"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MainToolStripMenuItem, Me.Maste4rEmployeeToolStripMenuItem, Me.ManageServiceToolStripMenuItem, Me.ManagePackageToolStripMenuItem, Me.TransactionDespositToolStripMenuItem, Me.PrepaidPackageToolStripMenuItem, Me.ViewTransactionToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 24)
        Me.MenuStrip1.TabIndex = 13
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'Maste4rEmployeeToolStripMenuItem
        '
        Me.Maste4rEmployeeToolStripMenuItem.Name = "Maste4rEmployeeToolStripMenuItem"
        Me.Maste4rEmployeeToolStripMenuItem.Size = New System.Drawing.Size(110, 20)
        Me.Maste4rEmployeeToolStripMenuItem.Text = "Master Employee"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Button1)
        Me.GroupBox2.Controls.Add(Me.DataGridView2)
        Me.GroupBox2.Location = New System.Drawing.Point(25, 289)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(775, 271)
        Me.GroupBox2.TabIndex = 14
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Detail"
        '
        'DataGridView2
        '
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Location = New System.Drawing.Point(22, 19)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.Size = New System.Drawing.Size(735, 189)
        Me.DataGridView2.TabIndex = 10
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(682, 214)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 11
        Me.Button1.Text = "Complete"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'transactionDeposit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 572)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Name = "transactionDeposit"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "transactionDeposit"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents ViewTransactionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PrepaidPackageToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TransactionDespositToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ManagePackageToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ManageServiceToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LogoutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MainToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents Maste4rEmployeeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents Button1 As Button
End Class
