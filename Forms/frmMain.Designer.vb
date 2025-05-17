<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
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

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。  
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.MainMenuStrip = New System.Windows.Forms.MenuStrip()
        Me.文件FToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.新建NToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.打开OToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MainTabControl = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.账户AToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MainMenuStrip.SuspendLayout()
        Me.MainTabControl.SuspendLayout()
        Me.SuspendLayout()
        '
        'MainMenuStrip
        '
        Me.MainMenuStrip.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MainMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.文件FToolStripMenuItem, Me.账户AToolStripMenuItem})
        Me.MainMenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MainMenuStrip.Name = "MainMenuStrip"
        Me.MainMenuStrip.Size = New System.Drawing.Size(782, 28)
        Me.MainMenuStrip.TabIndex = 0
        Me.MainMenuStrip.Text = "MenuStrip1"
        '
        '文件FToolStripMenuItem
        '
        Me.文件FToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.新建NToolStripMenuItem, Me.打开OToolStripMenuItem})
        Me.文件FToolStripMenuItem.Name = "文件FToolStripMenuItem"
        Me.文件FToolStripMenuItem.Size = New System.Drawing.Size(71, 24)
        Me.文件FToolStripMenuItem.Text = "文件(&F)"
        '
        '新建NToolStripMenuItem
        '
        Me.新建NToolStripMenuItem.Name = "新建NToolStripMenuItem"
        Me.新建NToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.新建NToolStripMenuItem.Text = "新建(&N)..."
        '
        '打开OToolStripMenuItem
        '
        Me.打开OToolStripMenuItem.Name = "打开OToolStripMenuItem"
        Me.打开OToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.打开OToolStripMenuItem.Text = "打开(&O)..."
        '
        'MainTabControl
        '
        Me.MainTabControl.Controls.Add(Me.TabPage1)
        Me.MainTabControl.Controls.Add(Me.TabPage2)
        Me.MainTabControl.Controls.Add(Me.TabPage3)
        Me.MainTabControl.Location = New System.Drawing.Point(0, 33)
        Me.MainTabControl.Name = "MainTabControl"
        Me.MainTabControl.SelectedIndex = 0
        Me.MainTabControl.Size = New System.Drawing.Size(782, 420)
        Me.MainTabControl.TabIndex = 1
        '
        'TabPage1
        '
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(774, 391)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "启动"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Location = New System.Drawing.Point(4, 25)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(774, 391)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "下载"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'TabPage3
        '
        Me.TabPage3.Location = New System.Drawing.Point(4, 25)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(774, 391)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "设置"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        '账户AToolStripMenuItem
        '
        Me.账户AToolStripMenuItem.Name = "账户AToolStripMenuItem"
        Me.账户AToolStripMenuItem.Size = New System.Drawing.Size(74, 24)
        Me.账户AToolStripMenuItem.Text = "账户(&A)"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(782, 453)
        Me.Controls.Add(Me.MainTabControl)
        Me.Controls.Add(Me.MainMenuStrip)
        Me.MainMenuStrip = Me.MainMenuStrip
        Me.Name = "frmMain"
        Me.Text = "XL Launcher"
        Me.MainMenuStrip.ResumeLayout(False)
        Me.MainMenuStrip.PerformLayout()
        Me.MainTabControl.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MainMenuStrip As MenuStrip
    Friend WithEvents 文件FToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 新建NToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 打开OToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MainTabControl As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents 账户AToolStripMenuItem As ToolStripMenuItem
End Class
