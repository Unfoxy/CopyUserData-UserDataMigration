<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.lbNewPcName = New System.Windows.Forms.Label()
        Me.lbOldPcName = New System.Windows.Forms.Label()
        Me.lbCustomerNTID = New System.Windows.Forms.Label()
        Me.stNewPcName = New System.Windows.Forms.TextBox()
        Me.stOldPcName = New System.Windows.Forms.TextBox()
        Me.stCustomerNTID = New System.Windows.Forms.TextBox()
        Me.buGetNewStatus = New System.Windows.Forms.Button()
        Me.buGetOldStatus = New System.Windows.Forms.Button()
        Me.buGetName = New System.Windows.Forms.Button()
        Me.buOutlookSignatures = New System.Windows.Forms.Button()
        Me.buChromeBookmarks = New System.Windows.Forms.Button()
        Me.buFileExplorerQuickAccess = New System.Windows.Forms.Button()
        Me.buEdgBookmarks = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lbNewPcName
        '
        Me.lbNewPcName.AutoSize = True
        Me.lbNewPcName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbNewPcName.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbNewPcName.Location = New System.Drawing.Point(30, 18)
        Me.lbNewPcName.Name = "lbNewPcName"
        Me.lbNewPcName.Size = New System.Drawing.Size(121, 25)
        Me.lbNewPcName.TabIndex = 0
        Me.lbNewPcName.Text = "New PC Name:"
        '
        'lbOldPcName
        '
        Me.lbOldPcName.AutoSize = True
        Me.lbOldPcName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbOldPcName.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbOldPcName.Location = New System.Drawing.Point(30, 51)
        Me.lbOldPcName.Name = "lbOldPcName"
        Me.lbOldPcName.Size = New System.Drawing.Size(115, 25)
        Me.lbOldPcName.TabIndex = 1
        Me.lbOldPcName.Text = "Old PC Name:"
        '
        'lbCustomerNTID
        '
        Me.lbCustomerNTID.AutoSize = True
        Me.lbCustomerNTID.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbCustomerNTID.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbCustomerNTID.Location = New System.Drawing.Point(30, 84)
        Me.lbCustomerNTID.Name = "lbCustomerNTID"
        Me.lbCustomerNTID.Size = New System.Drawing.Size(131, 25)
        Me.lbCustomerNTID.TabIndex = 2
        Me.lbCustomerNTID.Text = "Customer NTID:"
        '
        'stNewPcName
        '
        Me.stNewPcName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.stNewPcName.Location = New System.Drawing.Point(168, 20)
        Me.stNewPcName.Name = "stNewPcName"
        Me.stNewPcName.Size = New System.Drawing.Size(156, 22)
        Me.stNewPcName.TabIndex = 3
        '
        'stOldPcName
        '
        Me.stOldPcName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.stOldPcName.Location = New System.Drawing.Point(168, 53)
        Me.stOldPcName.Name = "stOldPcName"
        Me.stOldPcName.Size = New System.Drawing.Size(156, 22)
        Me.stOldPcName.TabIndex = 4
        '
        'stCustomerNTID
        '
        Me.stCustomerNTID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.stCustomerNTID.Location = New System.Drawing.Point(168, 86)
        Me.stCustomerNTID.Name = "stCustomerNTID"
        Me.stCustomerNTID.Size = New System.Drawing.Size(156, 22)
        Me.stCustomerNTID.TabIndex = 5
        '
        'buGetNewStatus
        '
        Me.buGetNewStatus.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.buGetNewStatus.Location = New System.Drawing.Point(337, 16)
        Me.buGetNewStatus.Name = "buGetNewStatus"
        Me.buGetNewStatus.Size = New System.Drawing.Size(210, 30)
        Me.buGetNewStatus.TabIndex = 6
        Me.buGetNewStatus.Text = "New PC Online Status"
        Me.buGetNewStatus.UseVisualStyleBackColor = True
        '
        'buGetOldStatus
        '
        Me.buGetOldStatus.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.buGetOldStatus.Location = New System.Drawing.Point(337, 49)
        Me.buGetOldStatus.Name = "buGetOldStatus"
        Me.buGetOldStatus.Size = New System.Drawing.Size(210, 30)
        Me.buGetOldStatus.TabIndex = 7
        Me.buGetOldStatus.Text = "Old PC Online Status"
        Me.buGetOldStatus.UseVisualStyleBackColor = True
        '
        'buGetName
        '
        Me.buGetName.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.buGetName.Location = New System.Drawing.Point(337, 82)
        Me.buGetName.Name = "buGetName"
        Me.buGetName.Size = New System.Drawing.Size(210, 30)
        Me.buGetName.TabIndex = 8
        Me.buGetName.Text = "Customer Name"
        Me.buGetName.UseVisualStyleBackColor = True
        '
        'buOutlookSignatures
        '
        Me.buOutlookSignatures.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.buOutlookSignatures.Location = New System.Drawing.Point(297, 141)
        Me.buOutlookSignatures.Name = "buOutlookSignatures"
        Me.buOutlookSignatures.Size = New System.Drawing.Size(250, 35)
        Me.buOutlookSignatures.TabIndex = 10
        Me.buOutlookSignatures.Text = "Outlook Signatures"
        Me.buOutlookSignatures.UseVisualStyleBackColor = True
        '
        'buChromeBookmarks
        '
        Me.buChromeBookmarks.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.buChromeBookmarks.Location = New System.Drawing.Point(30, 198)
        Me.buChromeBookmarks.Name = "buChromeBookmarks"
        Me.buChromeBookmarks.Size = New System.Drawing.Size(250, 35)
        Me.buChromeBookmarks.TabIndex = 11
        Me.buChromeBookmarks.Text = "Chrome Bookmarks"
        Me.buChromeBookmarks.UseVisualStyleBackColor = True
        '
        'buFileExplorerQuickAccess
        '
        Me.buFileExplorerQuickAccess.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.buFileExplorerQuickAccess.Location = New System.Drawing.Point(297, 198)
        Me.buFileExplorerQuickAccess.Name = "buFileExplorerQuickAccess"
        Me.buFileExplorerQuickAccess.Size = New System.Drawing.Size(250, 35)
        Me.buFileExplorerQuickAccess.TabIndex = 12
        Me.buFileExplorerQuickAccess.Text = "File Explorer Quick Access"
        Me.buFileExplorerQuickAccess.UseVisualStyleBackColor = True
        '
        'buEdgBookmarks
        '
        Me.buEdgBookmarks.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.buEdgBookmarks.Location = New System.Drawing.Point(30, 141)
        Me.buEdgBookmarks.Name = "buEdgBookmarks"
        Me.buEdgBookmarks.Size = New System.Drawing.Size(250, 35)
        Me.buEdgBookmarks.TabIndex = 13
        Me.buEdgBookmarks.Text = "Edge Bookmarks"
        Me.buEdgBookmarks.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(568, 266)
        Me.Controls.Add(Me.buEdgBookmarks)
        Me.Controls.Add(Me.buFileExplorerQuickAccess)
        Me.Controls.Add(Me.buChromeBookmarks)
        Me.Controls.Add(Me.buOutlookSignatures)
        Me.Controls.Add(Me.buGetName)
        Me.Controls.Add(Me.buGetOldStatus)
        Me.Controls.Add(Me.buGetNewStatus)
        Me.Controls.Add(Me.stCustomerNTID)
        Me.Controls.Add(Me.stOldPcName)
        Me.Controls.Add(Me.stNewPcName)
        Me.Controls.Add(Me.lbCustomerNTID)
        Me.Controls.Add(Me.lbOldPcName)
        Me.Controls.Add(Me.lbNewPcName)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "Copy User Data v1.00"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbNewPcName As Label
    Friend WithEvents lbOldPcName As Label
    Friend WithEvents lbCustomerNTID As Label
    Friend WithEvents stNewPcName As TextBox
    Friend WithEvents stOldPcName As TextBox
    Friend WithEvents stCustomerNTID As TextBox
    Friend WithEvents buGetNewStatus As Button
    Friend WithEvents buGetOldStatus As Button
    Friend WithEvents buGetName As Button
    Friend WithEvents buOutlookSignatures As Button
    Friend WithEvents buChromeBookmarks As Button
    Friend WithEvents buFileExplorerQuickAccess As Button
    Friend WithEvents buEdgBookmarks As Button
End Class
