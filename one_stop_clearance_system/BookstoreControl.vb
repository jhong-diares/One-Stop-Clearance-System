Imports System.ComponentModel
Imports System.Text

Namespace one_stop_clearance_system
    Partial Public Class BookstoreControl
        Inherits UserControl
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
                cancelButton.Command = newValue.BookstoreCommands.Cancel
            Else
                cancelButton.Command = Nothing
            End If
        End Sub
        Friend WithEvents LabelX13 As DevComponents.DotNetBar.LabelX
        Private WithEvents panelEx1 As DevComponents.DotNetBar.PanelEx
        Friend WithEvents LabelX12 As DevComponents.DotNetBar.LabelX
        Friend WithEvents LabelX11 As DevComponents.DotNetBar.LabelX
        Friend WithEvents LabelX10 As DevComponents.DotNetBar.LabelX
        Friend WithEvents LabelX5 As DevComponents.DotNetBar.LabelX
        Friend WithEvents LabelX9 As DevComponents.DotNetBar.LabelX
        Friend WithEvents cancelButton As DevComponents.DotNetBar.ButtonX
        Friend WithEvents ListViewEx1 As DevComponents.DotNetBar.Controls.ListViewEx
        Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
        Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader

        Private Sub InitializeComponent()
            Me.LabelX13 = New DevComponents.DotNetBar.LabelX()
            Me.panelEx1 = New DevComponents.DotNetBar.PanelEx()
            Me.LabelX12 = New DevComponents.DotNetBar.LabelX()
            Me.LabelX11 = New DevComponents.DotNetBar.LabelX()
            Me.LabelX10 = New DevComponents.DotNetBar.LabelX()
            Me.LabelX5 = New DevComponents.DotNetBar.LabelX()
            Me.LabelX9 = New DevComponents.DotNetBar.LabelX()
            Me.cancelButton = New DevComponents.DotNetBar.ButtonX()
            Me.ListViewEx1 = New DevComponents.DotNetBar.Controls.ListViewEx()
            Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.panelEx1.SuspendLayout()
            Me.SuspendLayout()
            '
            'LabelX13
            '
            '
            '
            '
            Me.LabelX13.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.LabelX13.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.LabelX13.Location = New System.Drawing.Point(36, 174)
            Me.LabelX13.Name = "LabelX13"
            Me.LabelX13.Size = New System.Drawing.Size(75, 23)
            Me.LabelX13.TabIndex = 55
            Me.LabelX13.Text = "school_yr"
            '
            'panelEx1
            '
            Me.panelEx1.CanvasColor = System.Drawing.SystemColors.Control
            Me.panelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
            Me.panelEx1.Controls.Add(Me.LabelX13)
            Me.panelEx1.Controls.Add(Me.LabelX12)
            Me.panelEx1.Controls.Add(Me.LabelX11)
            Me.panelEx1.Controls.Add(Me.LabelX10)
            Me.panelEx1.Controls.Add(Me.LabelX5)
            Me.panelEx1.Controls.Add(Me.LabelX9)
            Me.panelEx1.Controls.Add(Me.cancelButton)
            Me.panelEx1.Controls.Add(Me.ListViewEx1)
            Me.panelEx1.DisabledBackColor = System.Drawing.Color.Empty
            Me.panelEx1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.panelEx1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.panelEx1.Location = New System.Drawing.Point(0, 0)
            Me.panelEx1.Name = "panelEx1"
            Me.panelEx1.Size = New System.Drawing.Size(595, 445)
            Me.panelEx1.Style.Alignment = System.Drawing.StringAlignment.Center
            Me.panelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
            Me.panelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
            Me.panelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
            Me.panelEx1.Style.GradientAngle = 90
            Me.panelEx1.TabIndex = 12
            '
            'LabelX12
            '
            '
            '
            '
            Me.LabelX12.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.LabelX12.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.LabelX12.Location = New System.Drawing.Point(36, 145)
            Me.LabelX12.Name = "LabelX12"
            Me.LabelX12.Size = New System.Drawing.Size(120, 23)
            Me.LabelX12.TabIndex = 54
            Me.LabelX12.Text = "semester"
            '
            'LabelX11
            '
            '
            '
            '
            Me.LabelX11.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.LabelX11.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.LabelX11.Location = New System.Drawing.Point(36, 116)
            Me.LabelX11.Name = "LabelX11"
            Me.LabelX11.Size = New System.Drawing.Size(75, 23)
            Me.LabelX11.TabIndex = 53
            Me.LabelX11.Text = "year_lvl"
            '
            'LabelX10
            '
            '
            '
            '
            Me.LabelX10.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.LabelX10.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.LabelX10.Location = New System.Drawing.Point(36, 87)
            Me.LabelX10.Name = "LabelX10"
            Me.LabelX10.Size = New System.Drawing.Size(75, 23)
            Me.LabelX10.TabIndex = 52
            Me.LabelX10.Text = "current_course"
            '
            'LabelX5
            '
            '
            '
            '
            Me.LabelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.LabelX5.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.LabelX5.Location = New System.Drawing.Point(36, 58)
            Me.LabelX5.Name = "LabelX5"
            Me.LabelX5.Size = New System.Drawing.Size(75, 23)
            Me.LabelX5.TabIndex = 51
            Me.LabelX5.Text = "stud_id"
            '
            'LabelX9
            '
            '
            '
            '
            Me.LabelX9.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.LabelX9.Font = New System.Drawing.Font("Segoe UI", 15.75!)
            Me.LabelX9.Location = New System.Drawing.Point(3, 20)
            Me.LabelX9.Name = "LabelX9"
            Me.LabelX9.Size = New System.Drawing.Size(294, 32)
            Me.LabelX9.TabIndex = 50
            Me.LabelX9.Text = "LabelX9"
            '
            'cancelButton
            '
            Me.cancelButton.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
            Me.cancelButton.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
            Me.cancelButton.Location = New System.Drawing.Point(513, 397)
            Me.cancelButton.Name = "cancelButton"
            Me.cancelButton.Size = New System.Drawing.Size(75, 23)
            Me.cancelButton.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
            Me.cancelButton.TabIndex = 48
            Me.cancelButton.Text = "Cancel"
            '
            'ListViewEx1
            '
            Me.ListViewEx1.BackColor = System.Drawing.Color.White
            '
            '
            '
            Me.ListViewEx1.Border.Class = "ListViewBorder"
            Me.ListViewEx1.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.ListViewEx1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader3, Me.ColumnHeader4})
            Me.ListViewEx1.DisabledBackColor = System.Drawing.Color.Empty
            Me.ListViewEx1.ForeColor = System.Drawing.Color.Black
            Me.ListViewEx1.GridLines = True
            Me.ListViewEx1.Location = New System.Drawing.Point(90, 214)
            Me.ListViewEx1.Name = "ListViewEx1"
            Me.ListViewEx1.Size = New System.Drawing.Size(459, 134)
            Me.ListViewEx1.TabIndex = 45
            Me.ListViewEx1.UseCompatibleStateImageBehavior = False
            Me.ListViewEx1.View = System.Windows.Forms.View.Details
            '
            'ColumnHeader3
            '
            Me.ColumnHeader3.Text = "#"
            Me.ColumnHeader3.Width = 29
            '
            'ColumnHeader4
            '
            Me.ColumnHeader4.Text = "Description"
            Me.ColumnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            Me.ColumnHeader4.Width = 420
            '
            'BookstoreControl
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.panelEx1)
            Me.Name = "BookstoreControl"
            Me.Size = New System.Drawing.Size(595, 445)
            Me.panelEx1.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub

        Private Sub panelEx1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles panelEx1.Click

        End Sub
    End Class
End Namespace

