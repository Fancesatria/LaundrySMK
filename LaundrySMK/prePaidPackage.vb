Public Class prePaidPackage
    Private Sub Maste4rEmployeeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Maste4rEmployeeToolStripMenuItem.Click
        masterEmployee.Show()
        Me.Hide()

    End Sub

    Private Sub MainToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MainToolStripMenuItem.Click
        Me.Show()

    End Sub

    Private Sub ManageServiceToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ManageServiceToolStripMenuItem.Click
        masterService.Show()
        Me.Hide()

    End Sub

    Private Sub ManagePackageToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ManagePackageToolStripMenuItem.Click
        masterPackage.Show()
        Me.Hide()


    End Sub

    Private Sub TransactionDespositToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TransactionDespositToolStripMenuItem.Click
        transactionDeposit.Show()
        Me.Hide()

    End Sub

    Private Sub PrepaidPackageToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PrepaidPackageToolStripMenuItem.Click
        Me.Show()

    End Sub

    Private Sub ViewTransactionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewTransactionToolStripMenuItem.Click
        viewTransaction.Show()
        Me.Hide()

    End Sub
End Class