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
        Me.BtnSqlToLoad.Location = New System.Drawing.Point(739, 112)
        Me.BtnSqlToLoad.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnSqlToLoad.Name = "BtnSqlToLoad"
        Me.BtnSqlToLoad.Size = New System.Drawing.Size(30, 30)
        Me.BtnSqlToLoad.TabIndex = 174
        Me.BtnSqlToLoad.UseVisualStyleBackColor = True
        '
        'tbxSqlToLoad
        '
        Me.tbxSqlToLoad.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbxSqlToLoad.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.tbxSqlToLoad.Location = New System.Drawing.Point(136, 113)
        Me.tbxSqlToLoad.Margin = New System.Windows.Forms.Padding(4)
        Me.tbxSqlToLoad.Name = "tbxSqlToLoad"
        Me.tbxSqlToLoad.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.tbxSqlToLoad.Size = New System.Drawing.Size(595, 25)
        Me.tbxSqlToLoad.TabIndex = 173
        '
        'lblSqlToLoad
        '
        Me.lblSqlToLoad.AutoSize = True
        Me.lblSqlToLoad.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.lblSqlToLoad.Location = New System.Drawing.Point(13, 117)
        Me.lblSqlToLoad.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSqlToLoad.Name = "lblSqlToLoad"
        Me.lblSqlToLoad.Size = New System.Drawing.Size(122, 20)
        Me.lblSqlToLoad.TabIndex = 172
        Me.lblSqlToLoad.Text = "sql to save/load:"
        '
        'BtnImportDatabase
        '
        Me.BtnImportDatabase.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.BtnImportDatabase.Location = New System.Drawing.Point(215, 156)
        Me.BtnImportDatabase.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnImportDatabase.Name = "BtnImportDatabase"
        Me.BtnImportDatabase.Size = New System.Drawing.Size(160, 28)
        Me.BtnImportDatabase.TabIndex = 175
        Me.BtnImportDatabase.Text = "Import Database"
        Me.BtnImportDatabase.UseVisualStyleBackColor = True
        '
        'BtnExportDatabase
        '
        Me.BtnExportDatabase.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.BtnExportDatabase.Location = New System.Drawing.Point(383, 156)
        Me.BtnExportDatabase.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnExportDatabase.Name = "BtnExportDatabase"
        Me.BtnExportDatabase.Size = New System.Drawing.Size(160, 28)
        Me.BtnExportDatabase.TabIndex = 176
        Me.BtnExportDatabase.Text = "Export Database"
        Me.BtnExportDatabase.UseVisualStyleBackColor = True
        '
        'ofdSqlToLoad
        '
        Me.ofdSqlToLoad.Filter = "Sql Files (*.sql)| *.csv|All Files (*.*) | *.*"
        Me.ofdSqlToLoad.RestoreDirectory = True
        Me.ofdSqlToLoad.Title = "Open an index.html file"
        '
        'TbxUserName
        '
        Me.TbxUserName.Location = New System.Drawing.Point(113, 68)
        Me.TbxUserName.Name = "TbxUserName"
        Me.TbxUserName.Size = New System.Drawing.Size(305, 22)
        Me.TbxUserName.TabIndex = 177
        '
        'TbxServer
        '
        Me.TbxServer.Location = New System.Drawing.Point(125, 30)
        Me.TbxServer.Name = "TbxServer"
        Me.TbxServer.Size = New System.Drawing.Size(293, 22)
        Me.TbxServer.TabIndex = 178
        '
        'TbxDatabaseName
        '
        Me.TbxDatabaseName.Location = New System.Drawing.Point(573, 68)
        Me.TbxDatabaseName.Name = "TbxDatabaseName"
        Me.TbxDatabaseName.Size = New System.Drawing.Size(196, 22)
        Me.TbxDatabaseName.TabIndex = 179
        '
        'TbxPassword
        '
        Me.TbxPassword.Location = New System.Drawing.Point(525, 30)
        Me.TbxPassword.Name = "TbxPassword"
        Me.TbxPassword.Size = New System.Drawing.Size(244, 22)
        Me.TbxPassword.TabIndex = 180
        '
        'LblServer
        '
        Me.LblServer.AutoSize = True
        Me.LblServer.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.LblServer.Location = New System.Drawing.Point(13, 30)
        Me.LblServer.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblServer.Name = "LblServer"
        Me.LblServer.Size = New System.Drawing.Size(105, 20)
        Me.LblServer.TabIndex = 181
        Me.LblServer.Text = "Server Name:"
        '
        'LblUserName
        '
        Me.LblUserName.AutoSize = True
        Me.LblUserName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.LblUserName.Location = New System.Drawing.Point(13, 68)
        Me.LblUserName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblUserName.Name = "LblUserName"
        Me.LblUserName.Size = New System.Drawing.Size(93, 20)
        Me.LblUserName.TabIndex = 182
        Me.LblUserName.Text = "User Name:"
        '
        'LblPassword
        '
        Me.LblPassword.AutoSize = True
        Me.LblPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.LblPassword.Location = New System.Drawing.Point(425, 30)
        Me.LblPassword.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblPassword.Name = "LblPassword"
        Me.LblPassword.Size = New System.Drawing.Size(82, 20)
        Me.LblPassword.TabIndex = 183
        Me.LblPassword.Text = "Password:"
        '
        'LblDatabaseName
        '
        Me.LblDatabaseName.AutoSize = True
        Me.LblDatabaseName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.LblDatabaseName.Location = New System.Drawing.Point(425, 68)
        Me.LblDatabaseName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblDatabaseName.Name = "LblDatabaseName"
        Me.LblDatabaseName.Size = New System.Drawing.Size(125, 20)
        Me.LblDatabaseName.TabIndex = 184
        Me.LblDatabaseName.Text = "Database Name"
        '
        'ImportExportSqlDatabaseMaiForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(782, 253)
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
