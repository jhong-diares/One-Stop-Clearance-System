Namespace one_stop_clearance_system
    Partial Public Class SearchControl
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
            Me.panelEx1 = New DevComponents.DotNetBar.PanelEx()
            Me.LabelX7 = New DevComponents.DotNetBar.LabelX()
            Me.stud_idText = New DevComponents.DotNetBar.Controls.TextBoxX()
            Me.cancelButton = New DevComponents.DotNetBar.ButtonX()
            Me.searchButton = New DevComponents.DotNetBar.ButtonX()
            Me.labelX5 = New DevComponents.DotNetBar.LabelX()
            Me.labelX1 = New DevComponents.DotNetBar.LabelX()
            Me.panelEx1.SuspendLayout()
            Me.SuspendLayout()
            '
            'panelEx1
            '
            Me.panelEx1.CanvasColor = System.Drawing.SystemColors.Control
            Me.panelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
            Me.panelEx1.Controls.Add(Me.LabelX7)
            Me.panelEx1.Controls.Add(Me.stud_idText)
            Me.panelEx1.Controls.Add(Me.cancelButton)
            Me.panelEx1.Controls.Add(Me.searchButton)
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
            Me.panelEx1.TabIndex = 0
            '
            'LabelX7
            '
            '
            '
            '
            Me.LabelX7.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.LabelX7.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.LabelX7.Location = New System.Drawing.Point(97, 89)
            Me.LabelX7.Name = "LabelX7"
            Me.LabelX7.Size = New System.Drawing.Size(213, 20)
            Me.LabelX7.TabIndex = 39
            Me.LabelX7.Text = "(ex: 12-3456789)"
            Me.LabelX7.TextAlignment = System.Drawing.StringAlignment.Center
            '
            'stud_idText
            '
            Me.stud_idText.BackColor = System.Drawing.Color.White
            '
            '
            '
            Me.stud_idText.Border.Class = "TextBoxBorder"
            Me.stud_idText.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.stud_idText.DisabledBackColor = System.Drawing.Color.White
            Me.stud_idText.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.stud_idText.ForeColor = System.Drawing.Color.Black
            Me.stud_idText.Location = New System.Drawing.Point(97, 50)
            Me.stud_idText.MaxLength = 30
            Me.stud_idText.Name = "stud_idText"
            Me.stud_idText.PreventEnterBeep = True
            Me.stud_idText.Size = New System.Drawing.Size(213, 33)
            Me.stud_idText.TabIndex = 38
            Me.stud_idText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
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
            'searchButton
            '
            Me.searchButton.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
            Me.searchButton.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
            Me.searchButton.Location = New System.Drawing.Point(274, 206)
            Me.searchButton.Name = "searchButton"
            Me.searchButton.Size = New System.Drawing.Size(88, 29)
            Me.searchButton.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
            Me.searchButton.TabIndex = 31
            Me.searchButton.Text = "Search"
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
            Me.labelX5.Text = "Search"
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
            Me.labelX1.Text = "Student ID:"
            Me.labelX1.TextAlignment = System.Drawing.StringAlignment.Far
            '
            'SearchControl
            '
            Me.Controls.Add(Me.panelEx1)
            Me.Name = "SearchControl"
            Me.Size = New System.Drawing.Size(482, 284)
            Me.panelEx1.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub

#End Region

        Private panelEx1 As DevComponents.DotNetBar.PanelEx
        Private cancelButton As DevComponents.DotNetBar.ButtonX
        Private searchButton As DevComponents.DotNetBar.ButtonX
        Private labelX5 As DevComponents.DotNetBar.LabelX
        Private labelX1 As DevComponents.DotNetBar.LabelX
        Friend WithEvents stud_idText As DevComponents.DotNetBar.Controls.TextBoxX
        Private WithEvents LabelX7 As DevComponents.DotNetBar.LabelX
    End Class
End Namespace
