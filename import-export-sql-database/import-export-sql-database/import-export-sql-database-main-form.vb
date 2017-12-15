Imports System.IO
Imports MySql.Data.MySqlClient

Public Class ImportExportSqlDatabaseMaiForm
    Dim blnExit As Boolean
    Dim conn As New MySqlConnection

    Private Sub BtnSqlToLoad_Click(sender As Object, e As EventArgs) Handles BtnSqlToLoad.Click
        'Show the open file dialog box.
        If ofdSqlToLoad.ShowDialog = DialogResult.OK Then
            'Load the name of the file to the textbox
            tbxSqlToLoad.Text = ofdSqlToLoad.FileName
        End If
    End Sub

    Private Sub BtnImportDatabase_Click(sender As Object, e As EventArgs) Handles BtnImportDatabase.Click
        Cursor = Cursors.WaitCursor
        Dim constring As String = "server=" & TbxServer.Text & ";user=" & TbxUserName.Text & ";pwd=" & TbxPassword.Text & ";database=" & TbxDatabaseName.Text & ";default command timeout=8000;charset=utf8;"
        Dim backupfile As String = ofdSqlToLoad.FileName 'εδώ να κοιτάξω αν μπορώ να το πάρω από ότι γράφει το textbox, έτσι ώστε να μπόρώ εναλλακτικά να γράφω στο textbox αντί να το διαλέξω από το OpenFileDialog
        Dim conn As MySqlConnection = New MySqlConnection(constring)
        Dim cmd As MySqlCommand = New MySqlCommand()
        Dim mb As MySqlBackup = New MySqlBackup(cmd)
        cmd.Connection = conn
        conn.Open()
        mb.ImportFromFile(backupfile)
        conn.Close()
        MsgBox("Restore Done")
        Cursor = Cursors.Default
    End Sub

    Private Sub BtnExportDatabase_Click(sender As Object, e As EventArgs) Handles BtnExportDatabase.Click
        Cursor = Cursors.WaitCursor
        Dim constring As String = "server=" & TbxServer.Text & ";user=" & TbxUserName.Text & ";pwd=" & TbxPassword.Text & ";database=" & TbxDatabaseName.Text & ";default command timeout=8000;charset=utf8;"
        Dim backupfile As String = ofdSqlToLoad.FileName
        Dim conn As MySqlConnection = New MySqlConnection(constring)
        Dim cmd As MySqlCommand = New MySqlCommand()
        Dim mb As MySqlBackup = New MySqlBackup(cmd)
        cmd.Connection = conn
        conn.Open()
        mb.ExportToFile(backupfile)
        conn.Close()
        MsgBox("BackUp Done")
        Cursor = Cursors.Default
    End Sub
End Class
