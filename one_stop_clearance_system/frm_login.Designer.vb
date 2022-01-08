Namespace one_stop_clearance_system
    Partial Public Class LoginControl
        ''' <summary> 
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary> 
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

#Region "Component Designer generated code"

        ''' <summary> 
        ''' Required method for Designer support - do not modify 
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.GroupPanel1 = New DevComponents.DotNetBar.Controls.GroupPanel()
            Me.passwordTxt = New DevComponents.DotNetBar.Controls.TextBoxX()
            Me.usernameTxt = New DevComponents.DotNetBar.Controls.TextBoxX()
            Me.exitButton = New DevComponents.DotNetBar.ButtonX()
            Me.enterButton = New DevComponents.DotNetBar.ButtonX()
            Me.labelX1 = New DevComponents.DotNetBar.LabelX()
            Me.labelX2 = New DevComponents.DotNetBar.LabelX()
            Me.regButton = New DevComponents.DotNetBar.ButtonX()
            Me.GroupPanel1.SuspendLayout()
            Me.SuspendLayout()
            '
            'GroupPanel1
            '
            Me.GroupPanel1.BackColor = System.Drawing.Color.Transparent
            Me.GroupPanel1.CanvasColor = System.Drawing.SystemColors.Control
            Me.GroupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
            Me.GroupPanel1.Controls.Add(Me.regButton)
            Me.GroupPanel1.Controls.Add(Me.passwordTxt)
            Me.GroupPanel1.Controls.Add(Me.usernameTxt)
            Me.GroupPanel1.Controls.Add(Me.exitButton)
            Me.GroupPanel1.Controls.Add(Me.enterButton)
            Me.GroupPanel1.Controls.Add(Me.labelX1)
            Me.GroupPanel1.Controls.Add(Me.labelX2)
            Me.GroupPanel1.DisabledBackColor = System.Drawing.Color.Empty
            Me.GroupPanel1.Location = New System.Drawing.Point(3, 33)
            Me.GroupPanel1.Name = "GroupPanel1"
            Me.GroupPanel1.Size = New System.Drawing.Size(335, 228)
            '
            '
            '
            Me.GroupPanel1.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
            Me.GroupPanel1.Style.BackColorGradientAngle = 90
            Me.GroupPanel1.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
            Me.GroupPanel1.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
            Me.GroupPanel1.Style.BorderBottomWidth = 1
            Me.GroupPanel1.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
            Me.GroupPanel1.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
            Me.GroupPanel1.Style.BorderLeftWidth = 1
            Me.GroupPanel1.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
            Me.GroupPanel1.Style.BorderRightWidth = 1
            Me.GroupPanel1.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
            Me.GroupPanel1.Style.BorderTopWidth = 1
            Me.GroupPanel1.Style.CornerDiameter = 4
            Me.GroupPanel1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
            Me.GroupPanel1.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
            Me.GroupPanel1.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
            Me.GroupPanel1.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
            '
            '
            '
            Me.GroupPanel1.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
            '
            '
            '
            Me.GroupPanel1.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.GroupPanel1.TabIndex = 22
            Me.GroupPanel1.Text = "One-Stop Clearance System"
            '
            'passwordTxt
            '
            Me.passwordTxt.BackColor = System.Drawing.Color.White
            '
            '
            '
            Me.passwordTxt.Border.Class = "TextBoxBorder"
            Me.passwordTxt.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.passwordTxt.DisabledBackColor = System.Drawing.Color.White
            Me.passwordTxt.ForeColor = System.Drawing.Color.Black
            Me.passwordTxt.Location = New System.Drawing.Point(72, 103)
            Me.passwordTxt.Name = "passwordTxt"
            Me.passwordTxt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
            Me.passwordTxt.PreventEnterBeep = True
            Me.passwordTxt.Size = New System.Drawing.Size(182, 22)
            Me.passwordTxt.TabIndex = 2
            '
            'usernameTxt
            '
            Me.usernameTxt.BackColor = System.Drawing.Color.White
            '
            '
            '
            Me.usernameTxt.Border.Class = "TextBoxBorder"
            Me.usernameTxt.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.usernameTxt.DisabledBackColor = System.Drawing.Color.White
            Me.usernameTxt.ForeColor = System.Drawing.Color.Black
            Me.usernameTxt.Location = New System.Drawing.Point(72, 49)
            Me.usernameTxt.Name = "usernameTxt"
            Me.usernameTxt.PreventEnterBeep = True
            Me.usernameTxt.Size = New System.Drawing.Size(182, 22)
            Me.usernameTxt.TabIndex = 1
            '
            'exitButton
            '
            Me.exitButton.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
            Me.exitButton.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
            Me.exitButton.Enabled = False
            Me.exitButton.Location = New System.Drawing.Point(281, 157)
            Me.exitButton.Name = "exitButton"
            Me.exitButton.Size = New System.Drawing.Size(24, 27)
            Me.exitButton.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
            Me.exitButton.TabIndex = 4
            Me.exitButton.Text = "Exit"
            Me.exitButton.Visible = False
            '
            'enterButton
            '
            Me.enterButton.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
            Me.enterButton.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
            Me.enterButton.Location = New System.Drawing.Point(72, 131)
            Me.enterButton.Name = "enterButton"
            Me.enterButton.Size = New System.Drawing.Size(88, 29)
            Me.enterButton.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
            Me.enterButton.TabIndex = 3
            Me.enterButton.Text = "Login"
            '
            'labelX1
            '
            Me.labelX1.BackColor = System.Drawing.Color.Transparent
            '
            '
            '
            Me.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.labelX1.Location = New System.Drawing.Point(72, 24)
            Me.labelX1.Name = "labelX1"
            Me.labelX1.Size = New System.Drawing.Size(75, 20)
            Me.labelX1.TabIndex = 12
            Me.labelX1.Text = "Username:"
            '
            'labelX2
            '
            Me.labelX2.BackColor = System.Drawing.Color.Transparent
            '
            '
            '
            Me.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.labelX2.Location = New System.Drawing.Point(72, 77)
            Me.labelX2.Name = "labelX2"
            Me.labelX2.Size = New System.Drawing.Size(75, 20)
            Me.labelX2.TabIndex = 14
            Me.labelX2.Text = "Password:"
            '
            'regButton
            '
            Me.regButton.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
            Me.regButton.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
            Me.regButton.Location = New System.Drawing.Point(166, 131)
            Me.regButton.Name = "regButton"
            Me.regButton.Size = New System.Drawing.Size(88, 29)
            Me.regButton.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
            Me.regButton.TabIndex = 16
            Me.regButton.Text = "Register"
            '
            'LoginControl
            '
            Me.Controls.Add(Me.GroupPanel1)
            Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Name = "LoginControl"
            Me.Size = New System.Drawing.Size(357, 283)
            Me.GroupPanel1.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents GroupPanel1 As DevComponents.DotNetBar.Controls.GroupPanel
        Private WithEvents exitButton As DevComponents.DotNetBar.ButtonX
        Private WithEvents enterButton As DevComponents.DotNetBar.ButtonX
        Private WithEvents labelX1 As DevComponents.DotNetBar.LabelX
        Private WithEvents labelX2 As DevComponents.DotNetBar.LabelX
        Friend WithEvents passwordTxt As DevComponents.DotNetBar.Controls.TextBoxX
        Friend WithEvents usernameTxt As DevComponents.DotNetBar.Controls.TextBoxX
        Private WithEvents regButton As DevComponents.DotNetBar.ButtonX

#End Region


    End Class
End Namespace
