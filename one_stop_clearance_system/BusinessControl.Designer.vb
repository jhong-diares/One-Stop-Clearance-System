<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BusinessControl
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.panelEx1 = New DevComponents.DotNetBar.PanelEx()
        Me.LabelX3 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX()
        Me.cancelButton = New DevComponents.DotNetBar.ButtonX()
        Me.labelX5 = New DevComponents.DotNetBar.LabelX()
        Me.labelX1 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX4 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX6 = New DevComponents.DotNetBar.LabelX()
        Me.ListViewEx1 = New DevComponents.DotNetBar.Controls.ListViewEx()
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.LabelX7 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX8 = New DevComponents.DotNetBar.LabelX()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.panelEx1.SuspendLayout()
        Me.SuspendLayout()
        '
        'panelEx1
        '
        Me.panelEx1.CanvasColor = System.Drawing.SystemColors.Control
        Me.panelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.panelEx1.Controls.Add(Me.LabelX8)
        Me.panelEx1.Controls.Add(Me.LabelX7)
        Me.panelEx1.Controls.Add(Me.ListViewEx1)
        Me.panelEx1.Controls.Add(Me.LabelX6)
        Me.panelEx1.Controls.Add(Me.LabelX4)
        Me.panelEx1.Controls.Add(Me.LabelX3)
        Me.panelEx1.Controls.Add(Me.LabelX2)
        Me.panelEx1.Controls.Add(Me.cancelButton)
        Me.panelEx1.Controls.Add(Me.labelX5)
        Me.panelEx1.Controls.Add(Me.labelX1)
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
        Me.panelEx1.TabIndex = 4
        '
        'LabelX3
        '
        '
        '
        '
        Me.LabelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX3.Location = New System.Drawing.Point(16, 110)
        Me.LabelX3.Name = "LabelX3"
        Me.LabelX3.Size = New System.Drawing.Size(75, 20)
        Me.LabelX3.TabIndex = 41
        Me.LabelX3.Text = "year_lvl"
        Me.LabelX3.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'LabelX2
        '
        '
        '
        '
        Me.LabelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX2.Location = New System.Drawing.Point(16, 84)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(75, 20)
        Me.LabelX2.TabIndex = 40
        Me.LabelX2.Text = "current_course"
        Me.LabelX2.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'cancelButton
        '
        Me.cancelButton.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.cancelButton.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.cancelButton.Location = New System.Drawing.Point(494, 391)
        Me.cancelButton.Name = "cancelButton"
        Me.cancelButton.Size = New System.Drawing.Size(88, 29)
        Me.cancelButton.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.cancelButton.TabIndex = 32
        Me.cancelButton.Text = "Cancel"
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
        Me.labelX5.Text = "name"
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
        Me.labelX1.Text = "stud_id"
        Me.labelX1.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'LabelX4
        '
        '
        '
        '
        Me.LabelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX4.Location = New System.Drawing.Point(16, 136)
        Me.LabelX4.Name = "LabelX4"
        Me.LabelX4.Size = New System.Drawing.Size(75, 20)
        Me.LabelX4.TabIndex = 42
        Me.LabelX4.Text = "semester"
        Me.LabelX4.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'LabelX6
        '
        '
        '
        '
        Me.LabelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX6.Location = New System.Drawing.Point(16, 162)
        Me.LabelX6.Name = "LabelX6"
        Me.LabelX6.Size = New System.Drawing.Size(75, 20)
        Me.LabelX6.TabIndex = 43
        Me.LabelX6.Text = "school_yr"
        Me.LabelX6.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'ListViewEx1
        '
        '
        '
        '
        Me.ListViewEx1.Border.Class = "ListViewBorder"
        Me.ListViewEx1.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ListViewEx1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader1})
        Me.ListViewEx1.DisabledBackColor = System.Drawing.Color.Empty
        Me.ListViewEx1.GridLines = True
        Me.ListViewEx1.Location = New System.Drawing.Point(107, 188)
        Me.ListViewEx1.Name = "ListViewEx1"
        Me.ListViewEx1.Size = New System.Drawing.Size(449, 134)
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
        Me.ColumnHeader4.Width = 290
        '
        'LabelX7
        '
        '
        '
        '
        Me.LabelX7.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX7.Location = New System.Drawing.Point(346, 328)
        Me.LabelX7.Name = "LabelX7"
        Me.LabelX7.Size = New System.Drawing.Size(75, 20)
        Me.LabelX7.TabIndex = 46
        Me.LabelX7.Text = "TOTAL:"
        Me.LabelX7.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'LabelX8
        '
        '
        '
        '
        Me.LabelX8.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX8.Location = New System.Drawing.Point(481, 328)
        Me.LabelX8.Name = "LabelX8"
        Me.LabelX8.Size = New System.Drawing.Size(75, 20)
        Me.LabelX8.TabIndex = 47
        Me.LabelX8.Text = "00.00"
        Me.LabelX8.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Amount"
        Me.ColumnHeader1.Width = 130
        '
        'BusinessControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.panelEx1)
        Me.Name = "BusinessControl"
        Me.Size = New System.Drawing.Size(595, 445)
        Me.panelEx1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents panelEx1 As DevComponents.DotNetBar.PanelEx
    Private WithEvents cancelButton As DevComponents.DotNetBar.ButtonX
    Private WithEvents labelX5 As DevComponents.DotNetBar.LabelX
    Private WithEvents labelX1 As DevComponents.DotNetBar.LabelX
    Private WithEvents LabelX3 As DevComponents.DotNetBar.LabelX
    Private WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Private WithEvents LabelX6 As DevComponents.DotNetBar.LabelX
    Private WithEvents LabelX4 As DevComponents.DotNetBar.LabelX
    Private WithEvents LabelX8 As DevComponents.DotNetBar.LabelX
    Private WithEvents LabelX7 As DevComponents.DotNetBar.LabelX
    Friend WithEvents ListViewEx1 As DevComponents.DotNetBar.Controls.ListViewEx
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader

End Class
