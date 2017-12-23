<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ImportExportSqlDatabaseMaiForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ImportExportSqlDatabaseMaiForm))
        Me.BtnSqlToLoad = New System.Windows.Forms.Button()
        Me.tbxSqlToLoad = New System.Windows.Forms.TextBox()
        Me.lblSqlToLoad = New System.Windows.Forms.Label()
        Me.BtnImportDatabase = New System.Windows.Forms.Button()
        Me.BtnExportDatabase = New System.Windows.Forms.Button()
        Me.ofdSqlToLoad = New System.Windows.Forms.OpenFileDialog()
        Me.TbxUserName = New System.Windows.Forms.TextBox()
        Me.TbxServer = New System.Windows.Forms.TextBox()
        Me.TbxDatabaseName = New System.Windows.Forms.TextBox()
        Me.TbxPassword = New System.Windows.Forms.TextBox()
        Me.LblServer = New System.Windows.Forms.Label()
        Me.LblUserName = New System.Windows.Forms.Label()
        Me.LblPassword = New System.Windows.Forms.Label()
        Me.LblDatabaseName = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'BtnSqlToLoad
        '
        Me.BtnSqlToLoad.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnSqlToLoad.Image = CType(resources.GetObject("BtnSqlToLoad.Image"), System.Drawing.Image)
        Me.BtnSqlToLoad.Location = New System.Drawing.Point(554, 91)
        Me.BtnSqlToLoad.Name = "BtnSqlToLoad"
        Me.BtnSqlToLoad.Size = New System.Drawing.Size(22, 24)
        Me.BtnSqlToLoad.TabIndex = 5
        Me.BtnSqlToLoad.UseVisualStyleBackColor = True
        '
        'tbxSqlToLoad
        '
        Me.tbxSqlToLoad.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbxSqlToLoad.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.tbxSqlToLoad.Location = New System.Drawing.Point(123, 92)
        Me.tbxSqlToLoad.Name = "tbxSqlToLoad"
        Me.tbxSqlToLoad.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.tbxSqlToLoad.Size = New System.Drawing.Size(426, 22)
        Me.tbxSqlToLoad.TabIndex = 6
        Me.tbxSqlToLoad.TabStop = False
        '
        'lblSqlToLoad
        '
        Me.lblSqlToLoad.AutoSize = True
        Me.lblSqlToLoad.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.lblSqlToLoad.Location = New System.Drawing.Point(10, 95)
        Me.lblSqlToLoad.Name = "lblSqlToLoad"
        Me.lblSqlToLoad.Size = New System.Drawing.Size(107, 16)
        Me.lblSqlToLoad.TabIndex = 172
        Me.lblSqlToLoad.Text = "sql to save/load:"
        '
        'BtnImportDatabase
        '
        Me.BtnImportDatabase.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.BtnImportDatabase.Location = New System.Drawing.Point(161, 127)
        Me.BtnImportDatabase.Name = "BtnImportDatabase"
        Me.BtnImportDatabase.Size = New System.Drawing.Size(120, 23)
        Me.BtnImportDatabase.TabIndex = 7
        Me.BtnImportDatabase.Text = "Import Database"
        Me.BtnImportDatabase.UseVisualStyleBackColor = True
        '
        'BtnExportDatabase
        '
        Me.BtnExportDatabase.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.BtnExportDatabase.Location = New System.Drawing.Point(287, 127)
        Me.BtnExportDatabase.Name = "BtnExportDatabase"
        Me.BtnExportDatabase.Size = New System.Drawing.Size(120, 23)
        Me.BtnExportDatabase.TabIndex = 8
        Me.BtnExportDatabase.Text = "Export Database"
        Me.BtnExportDatabase.UseVisualStyleBackColor = True
        '
        'ofdSqlToLoad
        '
        Me.ofdSqlToLoad.Filter = "Sql Files (*.sql)| *.sql|All Files (*.*) | *.*"
        Me.ofdSqlToLoad.RestoreDirectory = True
        Me.ofdSqlToLoad.Title = "Open an index.html file"
        '
        'TbxUserName
        '
        Me.TbxUserName.Location = New System.Drawing.Point(95, 55)
        Me.TbxUserName.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TbxUserName.Name = "TbxUserName"
        Me.TbxUserName.Size = New System.Drawing.Size(220, 20)
        Me.TbxUserName.TabIndex = 2
        '
        'TbxServer
        '
        Me.TbxServer.Location = New System.Drawing.Point(106, 24)
        Me.TbxServer.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TbxServer.Name = "TbxServer"
        Me.TbxServer.Size = New System.Drawing.Size(209, 20)
        Me.TbxServer.TabIndex = 1
        '
        'TbxDatabaseName
        '
        Me.TbxDatabaseName.Location = New System.Drawing.Point(430, 55)
        Me.TbxDatabaseName.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TbxDatabaseName.Name = "TbxDatabaseName"
        Me.TbxDatabaseName.Size = New System.Drawing.Size(148, 20)
        Me.TbxDatabaseName.TabIndex = 4
        '
        'TbxPassword
        '
        Me.TbxPassword.Location = New System.Drawing.Point(394, 24)
        Me.TbxPassword.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TbxPassword.Name = "TbxPassword"
        Me.TbxPassword.Size = New System.Drawing.Size(184, 20)
        Me.TbxPassword.TabIndex = 3
        '
        'LblServer
        '
        Me.LblServer.AutoSize = True
        Me.LblServer.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.LblServer.Location = New System.Drawing.Point(10, 24)
        Me.LblServer.Name = "LblServer"
        Me.LblServer.Size = New System.Drawing.Size(91, 16)
        Me.LblServer.TabIndex = 181
        Me.LblServer.Text = "Server Name:"
        '
        'LblUserName
        '
        Me.LblUserName.AutoSize = True
        Me.LblUserName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.LblUserName.Location = New System.Drawing.Point(10, 55)
        Me.LblUserName.Name = "LblUserName"
        Me.LblUserName.Size = New System.Drawing.Size(80, 16)
        Me.LblUserName.TabIndex = 182
        Me.LblUserName.Text = "User Name:"
        '
        'LblPassword
        '
        Me.LblPassword.AutoSize = True
        Me.LblPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.LblPassword.Location = New System.Drawing.Point(319, 24)
        Me.LblPassword.Name = "LblPassword"
        Me.LblPassword.Size = New System.Drawing.Size(71, 16)
        Me.LblPassword.TabIndex = 183
        Me.LblPassword.Text = "Password:"
        '
        'LblDatabaseName
        '
        Me.LblDatabaseName.AutoSize = True
        Me.LblDatabaseName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.LblDatabaseName.Location = New System.Drawing.Point(319, 55)
        Me.LblDatabaseName.Name = "LblDatabaseName"
        Me.LblDatabaseName.Size = New System.Drawing.Size(108, 16)
        Me.LblDatabaseName.TabIndex = 184
        Me.LblDatabaseName.Text = "Database Name"
        '
        'ImportExportSqlDatabaseMaiForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(586, 206)
        Me.Controls.Add(Me.LblDatabaseName)
        Me.Controls.Add(Me.LblPassword)
        Me.Controls.Add(Me.LblUserName)
        Me.Controls.Add(Me.LblServer)
        Me.Controls.Add(Me.TbxPassword)
        Me.Controls.Add(Me.TbxDatabaseName)
        Me.Controls.Add(Me.TbxServer)
        Me.Controls.Add(Me.TbxUserName)
        Me.Controls.Add(Me.BtnExportDatabase)
        Me.Controls.Add(Me.BtnImportDatabase)
        Me.Controls.Add(Me.BtnSqlToLoad)
        Me.Controls.Add(Me.tbxSqlToLoad)
        Me.Controls.Add(Me.lblSqlToLoad)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "ImportExportSqlDatabaseMaiForm"
        Me.Text = "Import and Export SQL databases "
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnSqlToLoad As Button
    Friend WithEvents tbxSqlToLoad As TextBox
    Friend WithEvents lblSqlToLoad As Label
    Friend WithEvents BtnImportDatabase As Button
    Friend WithEvents BtnExportDatabase As Button
    Friend WithEvents ofdSqlToLoad As OpenFileDialog
    Friend WithEvents TbxUserName As TextBox
    Friend WithEvents TbxServer As TextBox
    Friend WithEvents TbxDatabaseName As TextBox
    Friend WithEvents TbxPassword As TextBox
    Friend WithEvents LblServer As Label
    Friend WithEvents LblUserName As Label
    Friend WithEvents LblPassword As Label
    Friend WithEvents LblDatabaseName As Label
End Class
