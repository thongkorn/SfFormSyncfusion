<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class sfForm

    Inherits Syncfusion.WinForms.Controls.SfForm

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
        Dim MetroColorTable1 As Syncfusion.Windows.Forms.MetroColorTable = New Syncfusion.Windows.Forms.MetroColorTable()
        Me.ColorPickerUIAdv1 = New Syncfusion.Windows.Forms.Tools.ColorPickerUIAdv()
        Me.ColorUIControl1 = New Syncfusion.Windows.Forms.ColorUIControl()
        Me.TrackBarEx1 = New Syncfusion.Windows.Forms.Tools.TrackBarEx(0, 10)
        Me.ColorPickerUIAdv2 = New Syncfusion.Windows.Forms.Tools.ColorPickerUIAdv()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TrackBarEx2 = New Syncfusion.Windows.Forms.Tools.TrackBarEx(0, 10)
        Me.Label5 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ColorPickerUIAdv1.RecentGroup
        '
        Me.ColorPickerUIAdv1.RecentGroup.Name = "Recent Colors"
        Me.ColorPickerUIAdv1.RecentGroup.Visible = False
        '
        'ColorPickerUIAdv1.StandardGroup
        '
        Me.ColorPickerUIAdv1.StandardGroup.Name = "Standard Colors"
        '
        'ColorPickerUIAdv1.ThemeGroup
        '
        Me.ColorPickerUIAdv1.ThemeGroup.IsSubItemsVisible = True
        Me.ColorPickerUIAdv1.ThemeGroup.Name = "Theme Colors"
        '
        'ColorPickerUIAdv1
        '
        Me.ColorPickerUIAdv1.ColorItemSize = New System.Drawing.Size(14, 13)
        Me.ColorPickerUIAdv1.Location = New System.Drawing.Point(273, 97)
        Me.ColorPickerUIAdv1.Name = "ColorPickerUIAdv1"
        Me.ColorPickerUIAdv1.Size = New System.Drawing.Size(182, 211)
        Me.ColorPickerUIAdv1.TabIndex = 0
        Me.ColorPickerUIAdv1.Text = "ColorPickerUIAdv1"
        '
        'ColorUIControl1
        '
        Me.ColorUIControl1.BeforeTouchSize = New System.Drawing.Size(207, 211)
        Me.ColorUIControl1.Location = New System.Drawing.Point(45, 97)
        Me.ColorUIControl1.Name = "ColorUIControl1"
        Me.ColorUIControl1.ScrollMetroColorTable = MetroColorTable1
        Me.ColorUIControl1.Size = New System.Drawing.Size(207, 211)
        Me.ColorUIControl1.TabIndex = 1
        Me.ColorUIControl1.Text = "ColorUIControl1"
        '
        'TrackBarEx1
        '
        Me.TrackBarEx1.BackColor = System.Drawing.Color.White
        Me.TrackBarEx1.BeforeTouchSize = New System.Drawing.Size(207, 20)
        Me.TrackBarEx1.Location = New System.Drawing.Point(45, 39)
        Me.TrackBarEx1.Name = "TrackBarEx1"
        Me.TrackBarEx1.Size = New System.Drawing.Size(207, 20)
        Me.TrackBarEx1.TabIndex = 2
        Me.TrackBarEx1.Text = "TrackBarEx1"
        Me.TrackBarEx1.ThemeName = "Default"
        Me.TrackBarEx1.TimerInterval = 100
        Me.TrackBarEx1.Value = 5
        '
        'ColorPickerUIAdv2.RecentGroup
        '
        '
        'ColorPickerUIAdv2.StandardGroup
        '
        '
        'ColorPickerUIAdv2.ThemeGroup
        '
        '
        'ColorPickerUIAdv2
        '
        Me.ColorPickerUIAdv2.ColorItemSize = New System.Drawing.Size(14, 13)
        Me.ColorPickerUIAdv2.Location = New System.Drawing.Point(482, 97)
        Me.ColorPickerUIAdv2.MinimumSize = New System.Drawing.Size(136, 163)
        Me.ColorPickerUIAdv2.Name = "ColorPickerUIAdv2"
        Me.ColorPickerUIAdv2.Size = New System.Drawing.Size(182, 163)
        Me.ColorPickerUIAdv2.TabIndex = 3
        Me.ColorPickerUIAdv2.Text = "ColorPickerUIAdv2"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(42, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(120, 18)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Border Thickness"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(42, 76)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 18)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Border Color"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(270, 76)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(130, 18)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "TitleBar Back Color"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(479, 76)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(115, 18)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Form Back Color"
        '
        'TrackBarEx2
        '
        Me.TrackBarEx2.BackColor = System.Drawing.Color.White
        Me.TrackBarEx2.BeforeTouchSize = New System.Drawing.Size(182, 20)
        Me.TrackBarEx2.Location = New System.Drawing.Point(273, 39)
        Me.TrackBarEx2.Name = "TrackBarEx2"
        Me.TrackBarEx2.Size = New System.Drawing.Size(182, 20)
        Me.TrackBarEx2.TabIndex = 8
        Me.TrackBarEx2.Text = "TrackBarEx2"
        Me.TrackBarEx2.ThemeName = "Default"
        Me.TrackBarEx2.TimerInterval = 100
        Me.TrackBarEx2.Value = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(270, 18)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(108, 18)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Title Bar Height"
        '
        'sfForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(705, 406)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TrackBarEx2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ColorPickerUIAdv2)
        Me.Controls.Add(Me.TrackBarEx1)
        Me.Controls.Add(Me.ColorUIControl1)
        Me.Controls.Add(Me.ColorPickerUIAdv1)
        Me.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "sfForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Style.MdiChild.IconHorizontalAlignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.Style.MdiChild.IconVerticalAlignment = System.Windows.Forms.VisualStyles.VerticalAlignment.Center
        Me.Text = "sfForm Syncfusion"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ColorPickerUIAdv1 As Syncfusion.Windows.Forms.Tools.ColorPickerUIAdv
    Friend WithEvents ColorUIControl1 As Syncfusion.Windows.Forms.ColorUIControl
    Friend WithEvents TrackBarEx1 As Syncfusion.Windows.Forms.Tools.TrackBarEx
    Friend WithEvents ColorPickerUIAdv2 As Syncfusion.Windows.Forms.Tools.ColorPickerUIAdv
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TrackBarEx2 As Syncfusion.Windows.Forms.Tools.TrackBarEx
    Friend WithEvents Label5 As Label
End Class
