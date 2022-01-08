Imports System.ComponentModel
Imports System.Text
Imports DevComponents.DotNetBar

Namespace one_stop_clearance_system
    Partial Public Class RegisterControl
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
                backButton.Command = newValue.RegisterCommands.Close
                createButton.Command = newValue.RegisterCommands.Create
            Else
                backButton.Command = Nothing
                createButton.Command = Nothing
            End If
        End Sub

        Private Sub InitializeComponent()
            Me.createButton = New DevComponents.DotNetBar.ButtonX()
            Me.backButton = New DevComponents.DotNetBar.ButtonX()
            Me.LabelX13 = New DevComponents.DotNetBar.LabelX()
            Me.LabelX12 = New DevComponents.DotNetBar.LabelX()
            Me.LabelX11 = New DevComponents.DotNetBar.LabelX()
            Me.LabelX10 = New DevComponents.DotNetBar.LabelX()
            Me.LabelX5 = New DevComponents.DotNetBar.LabelX()
            Me.LabelX9 = New DevComponents.DotNetBar.LabelX()
            Me.account_id = New DevComponents.DotNetBar.Controls.TextBoxX()
            Me.username = New DevComponents.DotNetBar.Controls.TextBoxX()
            Me.password = New DevComponents.DotNetBar.Controls.TextBoxX()
            Me.confirm_password = New DevComponents.DotNetBar.Controls.TextBoxX()
            Me.email = New DevComponents.DotNetBar.Controls.TextBoxX()
            Me.account_name = New DevComponents.DotNetBar.Controls.TextBoxX()
            Me.account_num = New DevComponents.DotNetBar.Controls.TextBoxX()
            Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
            Me.cmb_department = New DevComponents.DotNetBar.Controls.ComboBoxEx()
            Me.ComboItem1 = New DevComponents.Editors.ComboItem()
            Me.ComboItem2 = New DevComponents.Editors.ComboItem()
            Me.ComboItem3 = New DevComponents.Editors.ComboItem()
            Me.ComboItem4 = New DevComponents.Editors.ComboItem()
            Me.ComboItem5 = New DevComponents.Editors.ComboItem()
            Me.SuspendLayout()
            '
            'createButton
            '
            Me.createButton.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
            Me.createButton.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
            Me.createButton.Location = New System.Drawing.Point(153, 258)
            Me.createButton.Name = "createButton"
            Me.createButton.Size = New System.Drawing.Size(75, 23)
            Me.createButton.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
            Me.createButton.TabIndex = 0
            Me.createButton.Text = "Create"
            '
            'backButton
            '
            Me.backButton.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
            Me.backButton.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
            Me.backButton.Location = New System.Drawing.Point(258, 258)
            Me.backButton.Name = "backButton"
            Me.backButton.Size = New System.Drawing.Size(75, 23)
            Me.backButton.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
            Me.backButton.TabIndex = 1
            Me.backButton.Text = "Close"
            '
            'LabelX13
            '
            '
            '
            '
            Me.LabelX13.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.LabelX13.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.LabelX13.Location = New System.Drawing.Point(72, 201)
            Me.LabelX13.Name = "LabelX13"
            Me.LabelX13.Size = New System.Drawing.Size(75, 23)
            Me.LabelX13.TabIndex = 61
            Me.LabelX13.Text = "E-Mail:"
            '
            'LabelX12
            '
            '
            '
            '
            Me.LabelX12.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.LabelX12.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.LabelX12.Location = New System.Drawing.Point(72, 172)
            Me.LabelX12.Name = "LabelX12"
            Me.LabelX12.Size = New System.Drawing.Size(120, 23)
            Me.LabelX12.TabIndex = 60
            Me.LabelX12.Text = "Confirm Password:"
            '
            'LabelX11
            '
            '
            '
            '
            Me.LabelX11.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.LabelX11.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.LabelX11.Location = New System.Drawing.Point(72, 143)
            Me.LabelX11.Name = "LabelX11"
            Me.LabelX11.Size = New System.Drawing.Size(75, 23)
            Me.LabelX11.TabIndex = 59
            Me.LabelX11.Text = "Password:"
            '
            'LabelX10
            '
            '
            '
            '
            Me.LabelX10.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.LabelX10.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.LabelX10.Location = New System.Drawing.Point(72, 114)
            Me.LabelX10.Name = "LabelX10"
            Me.LabelX10.Size = New System.Drawing.Size(75, 23)
            Me.LabelX10.TabIndex = 58
            Me.LabelX10.Text = "Username:"
            '
            'LabelX5
            '
            '
            '
            '
            Me.LabelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.LabelX5.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.LabelX5.Location = New System.Drawing.Point(72, 85)
            Me.LabelX5.Name = "LabelX5"
            Me.LabelX5.Size = New System.Drawing.Size(75, 23)
            Me.LabelX5.TabIndex = 57
            Me.LabelX5.Text = "Account ID:"
            '
            'LabelX9
            '
            '
            '
            '
            Me.LabelX9.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.LabelX9.Font = New System.Drawing.Font("Segoe UI", 15.75!)
            Me.LabelX9.Location = New System.Drawing.Point(39, 26)
            Me.LabelX9.Name = "LabelX9"
            Me.LabelX9.Size = New System.Drawing.Size(294, 32)
            Me.LabelX9.TabIndex = 56
            Me.LabelX9.Text = "Register"
            '
            'account_id
            '
            Me.account_id.BackColor = System.Drawing.Color.White
            '
            '
            '
            Me.account_id.Border.Class = "TextBoxBorder"
            Me.account_id.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.account_id.DisabledBackColor = System.Drawing.Color.White
            Me.account_id.Enabled = False
            Me.account_id.ForeColor = System.Drawing.Color.Black
            Me.account_id.Location = New System.Drawing.Point(391, 17)
            Me.account_id.Name = "account_id"
            Me.account_id.PreventEnterBeep = True
            Me.account_id.Size = New System.Drawing.Size(10, 20)
            Me.account_id.TabIndex = 62
            Me.account_id.Visible = False
            '
            'username
            '
            Me.username.BackColor = System.Drawing.Color.White
            '
            '
            '
            Me.username.Border.Class = "TextBoxBorder"
            Me.username.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.username.DisabledBackColor = System.Drawing.Color.White
            Me.username.ForeColor = System.Drawing.Color.Black
            Me.username.Location = New System.Drawing.Point(153, 115)
            Me.username.Name = "username"
            Me.username.PreventEnterBeep = True
            Me.username.Size = New System.Drawing.Size(180, 20)
            Me.username.TabIndex = 63
            '
            'password
            '
            Me.password.BackColor = System.Drawing.Color.White
            '
            '
            '
            Me.password.Border.Class = "TextBoxBorder"
            Me.password.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.password.DisabledBackColor = System.Drawing.Color.White
            Me.password.ForeColor = System.Drawing.Color.Black
            Me.password.Location = New System.Drawing.Point(153, 143)
            Me.password.Name = "password"
            Me.password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
            Me.password.PreventEnterBeep = True
            Me.password.Size = New System.Drawing.Size(180, 20)
            Me.password.TabIndex = 64
            '
            'confirm_password
            '
            Me.confirm_password.BackColor = System.Drawing.Color.White
            '
            '
            '
            Me.confirm_password.Border.Class = "TextBoxBorder"
            Me.confirm_password.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.confirm_password.DisabledBackColor = System.Drawing.Color.White
            Me.confirm_password.ForeColor = System.Drawing.Color.Black
            Me.confirm_password.Location = New System.Drawing.Point(198, 175)
            Me.confirm_password.Name = "confirm_password"
            Me.confirm_password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
            Me.confirm_password.PreventEnterBeep = True
            Me.confirm_password.Size = New System.Drawing.Size(135, 20)
            Me.confirm_password.TabIndex = 65
            '
            'email
            '
            Me.email.BackColor = System.Drawing.Color.White
            '
            '
            '
            Me.email.Border.Class = "TextBoxBorder"
            Me.email.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.email.DisabledBackColor = System.Drawing.Color.White
            Me.email.ForeColor = System.Drawing.Color.Black
            Me.email.Location = New System.Drawing.Point(153, 205)
            Me.email.Name = "email"
            Me.email.PreventEnterBeep = True
            Me.email.Size = New System.Drawing.Size(180, 20)
            Me.email.TabIndex = 66
            '
            'account_name
            '
            Me.account_name.BackColor = System.Drawing.Color.White
            '
            '
            '
            Me.account_name.Border.Class = "TextBoxBorder"
            Me.account_name.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.account_name.DisabledBackColor = System.Drawing.Color.White
            Me.account_name.Enabled = False
            Me.account_name.ForeColor = System.Drawing.Color.Black
            Me.account_name.Location = New System.Drawing.Point(153, 89)
            Me.account_name.Name = "account_name"
            Me.account_name.PreventEnterBeep = True
            Me.account_name.Size = New System.Drawing.Size(180, 20)
            Me.account_name.TabIndex = 67
            '
            'account_num
            '
            Me.account_num.BackColor = System.Drawing.Color.White
            '
            '
            '
            Me.account_num.Border.Class = "TextBoxBorder"
            Me.account_num.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.account_num.DisabledBackColor = System.Drawing.Color.White
            Me.account_num.Enabled = False
            Me.account_num.ForeColor = System.Drawing.Color.Black
            Me.account_num.Location = New System.Drawing.Point(407, 17)
            Me.account_num.Name = "account_num"
            Me.account_num.PreventEnterBeep = True
            Me.account_num.Size = New System.Drawing.Size(10, 20)
            Me.account_num.TabIndex = 68
            Me.account_num.Visible = False
            '
            'LabelX1
            '
            '
            '
            '
            Me.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.LabelX1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.LabelX1.Location = New System.Drawing.Point(72, 60)
            Me.LabelX1.Name = "LabelX1"
            Me.LabelX1.Size = New System.Drawing.Size(75, 23)
            Me.LabelX1.TabIndex = 69
            Me.LabelX1.Text = "Department:"
            '
            'cmb_department
            '
            Me.cmb_department.DisplayMember = "Text"
            Me.cmb_department.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
            Me.cmb_department.ForeColor = System.Drawing.Color.Black
            Me.cmb_department.FormattingEnabled = True
            Me.cmb_department.ItemHeight = 14
            Me.cmb_department.Items.AddRange(New Object() {Me.ComboItem1, Me.ComboItem2, Me.ComboItem3, Me.ComboItem4, Me.ComboItem5})
            Me.cmb_department.Location = New System.Drawing.Point(153, 64)
            Me.cmb_department.Name = "cmb_department"
            Me.cmb_department.Size = New System.Drawing.Size(180, 20)
            Me.cmb_department.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
            Me.cmb_department.TabIndex = 70
            '
            'ComboItem1
            '
            Me.ComboItem1.Text = "REGISTRAR"
            '
            'ComboItem2
            '
            Me.ComboItem2.Text = "LIBRARY"
            '
            'ComboItem3
            '
            Me.ComboItem3.Text = "GUIDANCE"
            '
            'ComboItem4
            '
            Me.ComboItem4.Text = "BUSINESS"
            '
            'ComboItem5
            '
            Me.ComboItem5.Text = "BOOKSTORE"
            '
            'RegisterControl
            '
            Me.Controls.Add(Me.cmb_department)
            Me.Controls.Add(Me.LabelX1)
            Me.Controls.Add(Me.account_num)
            Me.Controls.Add(Me.account_name)
            Me.Controls.Add(Me.email)
            Me.Controls.Add(Me.confirm_password)
            Me.Controls.Add(Me.password)
            Me.Controls.Add(Me.username)
            Me.Controls.Add(Me.account_id)
            Me.Controls.Add(Me.LabelX13)
            Me.Controls.Add(Me.LabelX12)
            Me.Controls.Add(Me.LabelX11)
            Me.Controls.Add(Me.LabelX10)
            Me.Controls.Add(Me.LabelX5)
            Me.Controls.Add(Me.LabelX9)
            Me.Controls.Add(Me.backButton)
            Me.Controls.Add(Me.createButton)
            Me.Name = "RegisterControl"
            Me.Size = New System.Drawing.Size(437, 315)
            Me.ResumeLayout(False)

        End Sub

        Private Sub RegisterControl_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        End Sub
        Friend WithEvents createButton As DevComponents.DotNetBar.ButtonX
        Friend WithEvents backButton As DevComponents.DotNetBar.ButtonX
        Friend WithEvents LabelX13 As DevComponents.DotNetBar.LabelX
        Friend WithEvents LabelX12 As DevComponents.DotNetBar.LabelX
        Friend WithEvents LabelX11 As DevComponents.DotNetBar.LabelX
        Friend WithEvents LabelX10 As DevComponents.DotNetBar.LabelX
        Friend WithEvents LabelX5 As DevComponents.DotNetBar.LabelX
        Friend WithEvents LabelX9 As DevComponents.DotNetBar.LabelX
        Friend WithEvents account_id As DevComponents.DotNetBar.Controls.TextBoxX
        Friend WithEvents username As DevComponents.DotNetBar.Controls.TextBoxX
        Friend WithEvents password As DevComponents.DotNetBar.Controls.TextBoxX
        Friend WithEvents confirm_password As DevComponents.DotNetBar.Controls.TextBoxX
        Friend WithEvents email As DevComponents.DotNetBar.Controls.TextBoxX
        Friend WithEvents account_name As DevComponents.DotNetBar.Controls.TextBoxX
        Friend WithEvents account_num As DevComponents.DotNetBar.Controls.TextBoxX
        Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
        Friend WithEvents cmb_department As DevComponents.DotNetBar.Controls.ComboBoxEx
        Friend WithEvents ComboItem1 As DevComponents.Editors.ComboItem
        Friend WithEvents ComboItem2 As DevComponents.Editors.ComboItem
        Friend WithEvents ComboItem3 As DevComponents.Editors.ComboItem
        Friend WithEvents ComboItem4 As DevComponents.Editors.ComboItem
        Friend WithEvents ComboItem5 As DevComponents.Editors.ComboItem


    End Class
End Namespace
