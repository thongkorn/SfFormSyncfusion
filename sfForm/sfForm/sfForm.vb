#Region "About"
' / --------------------------------------------------------------------------------
' / Developer : Mr.Surapon Yodsanga (Thongkorn Tubtimkrob)
' / eMail : thongkorn@hotmail.com
' / URL: http://www.g2gnet.com (Khon Kaen - Thailand)
' / Facebook: https://www.facebook.com/g2gnet (For Thailand)
' / Facebook: https://www.facebook.com/commonindy (Worldwide)
' / More Info: http://www.g2gsoft.com/
' /
' / Purpose: SfForm with Syncfusion Community License Free.
' / Microsoft Visual Basic .NET (2017)
' /
' / This is open source code under @CopyLeft by Thongkorn Tubtimkrob.
' / You can modify and/or distribute without to inform the developer.
' / --------------------------------------------------------------------------------
#End Region

Imports Syncfusion.Windows.Forms.Tools

Public Class sfForm

    Inherits Syncfusion.WinForms.Controls.SfForm

    Dim c As New Color

    Private Sub sfForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "SfForm Syncfusion VB.NET 2017"
        With Me.TrackBarEx1
            .Maximum = 10
            .Minimum = 1
            .Value = 5
        End With
        With Me.TrackBarEx2
            .Maximum = 80
            .Minimum = 20
            .Value = 45
            .ShowButtons = True
        End With
        '// Select Standard Colors.
        Me.ColorUIControl1.SelectedColorGroup = Syncfusion.Windows.Forms.ColorUISelectedGroup.StandardColors
        '// Setup Form.
        Call SetupForm()

        '// Get TitleBar BackColor.
        Me.ColorPickerUIAdv1.SelectedColor = Me.Style.TitleBar.BackColor
        '// Get Form BackColor.
        Me.ColorPickerUIAdv2.SelectedColor = Me.BackColor
        '// Get Border Color.
        Me.ColorUIControl1.SelectedColor = Me.Style.Border.Color
    End Sub

    Sub SetupForm()
        With Me.Style
            .TitleBar.Height = TrackBarEx2.Value
            '// Customize the shadow for active state
            .ShadowOpacity = 255
            '// Customize the shadow for inactive state
            .InactiveShadowOpacity = 100
            .Border = New Pen(Color.Black, 5)
            .InactiveBorder = New Pen(Color.Black, 5)
        End With
        '// Windows 11
        Me.AllowRoundedCorners = True
        '//
        '// Sets the back color and fore color of the title bar.
        Me.Style.TitleBar.BackColor = Color.Black
        Me.Style.TitleBar.ForeColor = Color.White

        '// Sets the fore color of the title bar buttons
        Me.Style.TitleBar.CloseButtonForeColor = Color.White
        Me.Style.TitleBar.MinimizeButtonForeColor = Color.White
        Me.Style.TitleBar.MaximizeButtonForeColor = Color.White

        '// Sets the hover state back color of the title bar buttons
        Me.Style.TitleBar.CloseButtonHoverBackColor = Color.DarkGray
        Me.Style.TitleBar.MinimizeButtonHoverBackColor = Color.DarkGray
        Me.Style.TitleBar.MaximizeButtonHoverBackColor = Color.DarkGray

        '// Sets the pressed state back color of the title bar buttons
        Me.Style.TitleBar.CloseButtonPressedBackColor = Color.Gray
        Me.Style.TitleBar.MaximizeButtonPressedBackColor = Color.Gray
        Me.Style.TitleBar.MinimizeButtonPressedBackColor = Color.Gray
        '//
    End Sub

    '// TitleBar BackColor
    Private Sub ColorPickerUIAdv1_Picked(sender As Object, args As Syncfusion.Windows.Forms.Tools.ColorPickerUIAdv.ColorPickedEventArgs) Handles ColorPickerUIAdv1.Picked
        Me.Style.TitleBar.BackColor = Me.ColorPickerUIAdv1.SelectedColor
    End Sub

    '// Change Border Color.
    Private Sub ColorUIControl1_ColorSelected(sender As Object, e As System.EventArgs) Handles ColorUIControl1.ColorSelected
        c = Me.ColorUIControl1.SelectedColor
        Me.Style.Border = New Pen(c, Me.TrackBarEx1.Value)
    End Sub

    '// Change Border Thickness.
    Private Sub TrackBarEx1_ValueChanged(sender As Object, e As System.EventArgs) Handles TrackBarEx1.ValueChanged
        Me.Style.Border = New Pen(c, Me.TrackBarEx1.Value)
        Me.Style.Border.Color = c
    End Sub

    '// Change TitleBar Height.
    Private Sub TrackBarEx2_ValueChanged(sender As Object, e As System.EventArgs) Handles TrackBarEx2.ValueChanged
        Me.Style.TitleBar.Height = TrackBarEx2.Value
    End Sub

    '// Change Form BackColor.
    Private Sub ColorPickerUIAdv2_Picked(sender As Object, args As ColorPickerUIAdv.ColorPickedEventArgs) Handles ColorPickerUIAdv2.Picked
        Me.BackColor = Me.ColorPickerUIAdv2.SelectedColor
    End Sub
End Class
