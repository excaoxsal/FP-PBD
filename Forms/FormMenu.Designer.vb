<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormMenu
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InputSiswaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InputGuruToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InputStaffToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(657, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MenuToolStripMenuItem
        '
        Me.MenuToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InputSiswaToolStripMenuItem, Me.InputGuruToolStripMenuItem, Me.InputStaffToolStripMenuItem})
        Me.MenuToolStripMenuItem.Name = "MenuToolStripMenuItem"
        Me.MenuToolStripMenuItem.Size = New System.Drawing.Size(50, 20)
        Me.MenuToolStripMenuItem.Text = "Menu"
        '
        'InputSiswaToolStripMenuItem
        '
        Me.InputSiswaToolStripMenuItem.Name = "InputSiswaToolStripMenuItem"
        Me.InputSiswaToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.InputSiswaToolStripMenuItem.Text = "Input Siswa"
        '
        'InputGuruToolStripMenuItem
        '
        Me.InputGuruToolStripMenuItem.Name = "InputGuruToolStripMenuItem"
        Me.InputGuruToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.InputGuruToolStripMenuItem.Text = "Input Guru"
        '
        'InputStaffToolStripMenuItem
        '
        Me.InputStaffToolStripMenuItem.Name = "InputStaffToolStripMenuItem"
        Me.InputStaffToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.InputStaffToolStripMenuItem.Text = "Input Staff"
        '
        'FormMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.ClientSize = New System.Drawing.Size(657, 448)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "FormMenu"
        Me.Text = "Menu"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents MenuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents InputSiswaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents InputGuruToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents InputStaffToolStripMenuItem As ToolStripMenuItem
End Class
