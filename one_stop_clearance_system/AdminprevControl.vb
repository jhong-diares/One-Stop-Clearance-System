Imports System.ComponentModel
Imports System.Text

Namespace one_stop_clearance_system
    Partial Public Class AdminprevControl
        Inherits DevComponents.DotNetBar.Controls.SlidePanel
        Public Sub New()
            InitializeComponent()
        End Sub

        Private _Commands As mod_commands
        Public Property Commands() As mod_commands
            Get
                Return _Commands
            End Get
            Set(ByVal value As mod_commands)
                If value IsNot _Commands Then
                    Dim oldValue As mod_commands = _Commands
                    _Commands = value
                    OnCommandsChanged(oldValue, value)
                End If
            End Set
        End Property
        Protected Overridable Sub OnCommandsChanged(ByVal oldValue As mod_commands, ByVal newValue As mod_commands)
            If newValue IsNot Nothing Then
                enterButton.Command = newValue.AdminCommands.Enter
                cancelButton.Command = newValue.AdminCommands.Close
            Else
                enterButton.Command = Nothing
                cancelButton.Command = Nothing

            End If
        End Sub

        Private Sub InitializeComponent()
            Me.admin_passText = New DevComponents.DotNetBar.Controls.TextBoxX()
            Me.panelEx1 = New DevComponents.DotNetBar.PanelEx()
            Me.cancelButton = New DevComponents.DotNetBar.ButtonX()
            Me.enterButton = New DevComponents.DotNetBar.ButtonX()
            Me.labelX5 = New DevComponents.DotNetBar.LabelX()
            Me.labelX1 = New DevComponents.DotNetBar.LabelX()
            Me.panelEx1.SuspendLayout()
            Me.SuspendLayout()
            '
            'admin_passText
            '
            Me.admin_passText.BackColor = System.Drawing.Color.White
            '
            '
            '
            Me.admin_passText.Border.Class = "TextBoxBorder"
            Me.admin_passText.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.admin_passText.DisabledBackColor = System.Drawing.Color.White
            Me.admin_passText.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.admin_passText.ForeColor = System.Drawing.Color.Black
            Me.admin_passText.Location = New System.Drawing.Point(97, 50)
            Me.admin_passText.MaxLength = 10
            Me.admin_passText.Name = "admin_passText"
            Me.admin_passText.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
            Me.admin_passText.PreventEnterBeep = True
            Me.admin_passText.Size = New System.Drawing.Size(213, 33)
            Me.admin_passText.TabIndex = 38
            Me.admin_passText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            '
            'panelEx1
            '
            Me.panelEx1.CanvasColor = System.Drawing.SystemColors.Control
            Me.panelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
            Me.panelEx1.Controls.Add(Me.admin_passText)
            Me.panelEx1.Controls.Add(Me.cancelButton)
            Me.panelEx1.Controls.Add(Me.enterButton)
            Me.panelEx1.Controls.Add(Me.labelX5)
            Me.panelEx1.Controls.Add(Me.labelX1)
            Me.panelEx1.DisabledBackColor = System.Drawing.Color.Empty
            Me.panelEx1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.panelEx1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.panelEx1.Location = New System.Drawing.Point(0, 0)
            Me.panelEx1.Name = "panelEx1"
            Me.panelEx1.Size = New System.Drawing.Size(482, 284)
            Me.panelEx1.Style.Alignment = System.Drawing.StringAlignment.Center
            Me.panelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
            Me.panelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
            Me.panelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
            Me.panelEx1.Style.GradientAngle = 90
            Me.panelEx1.TabIndex = 4
            '
            'cancelButton
            '
            Me.cancelButton.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
            Me.cancelButton.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
            Me.cancelButton.Location = New System.Drawing.Point(368, 206)
            Me.cancelButton.Name = "cancelButton"
            Me.cancelButton.Size = New System.Drawing.Size(88, 29)
            Me.cancelButton.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
            Me.cancelButton.TabIndex = 32
            Me.cancelButton.Text = "Cancel"
            '
            'enterButton
            '
            Me.enterButton.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
            Me.enterButton.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
            Me.enterButton.Location = New System.Drawing.Point(274, 206)
            Me.enterButton.Name = "enterButton"
            Me.enterButton.Size = New System.Drawing.Size(88, 29)
            Me.enterButton.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
            Me.enterButton.TabIndex = 31
            Me.enterButton.Text = "Enter"
            '
            'labelX5
            '
            '
            '
            '
            Me.labelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.labelX5.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.labelX5.Location = New System.Drawing.Point(16, 11)
            Me.labelX5.Name = "labelX5"
            Me.labelX5.Size = New System.Drawing.Size(294, 32)
            Me.labelX5.TabIndex = 30
            Me.labelX5.Text = "Administrator"
            '
            'labelX1
            '
            '
            '
            '
            Me.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.labelX1.Location = New System.Drawing.Point(16, 58)
            Me.labelX1.Name = "labelX1"
            Me.labelX1.Size = New System.Drawing.Size(75, 20)
            Me.labelX1.TabIndex = 23
            Me.labelX1.Text = "Password:"
            Me.labelX1.TextAlignment = System.Drawing.StringAlignment.Far
            '
            'AdminprevControl
            '
            Me.Controls.Add(Me.panelEx1)
            Me.Name = "AdminprevControl"
            Me.Size = New System.Drawing.Size(482, 284)
            Me.panelEx1.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents admin_passText As DevComponents.DotNetBar.Controls.TextBoxX
        Private WithEvents panelEx1 As DevComponents.DotNetBar.PanelEx
        Private WithEvents cancelButton As DevComponents.DotNetBar.ButtonX
        Private WithEvents enterButton As DevComponents.DotNetBar.ButtonX
        Friend WithEvents labelX5 As DevComponents.DotNetBar.LabelX
        Private WithEvents labelX1 As DevComponents.DotNetBar.LabelX

        Private Sub labelX5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles labelX5.Click

        End Sub
    End Class
End Namespace
