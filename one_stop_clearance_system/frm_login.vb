Imports System.ComponentModel
Imports System.Text
Imports DevComponents.DotNetBar.Controls
Imports DevComponents.DotNetBar.Metro
Imports DevComponents.DotNetBar

Namespace one_stop_clearance_system
    Partial Public Class LoginControl
        Inherits DevComponents.DotNetBar.Controls.SlidePanel
        'Inherits UserControl

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
                enterButton.Command = newValue.LoginCommands.Enter
                exitButton.Command = newValue.LoginCommands.Close
                regButton.Command = newValue.AdminCommands.[New]
            Else
                enterButton.Command = Nothing
                exitButton.Command = Nothing
                regButton.Command = Nothing
            End If
        End Sub

        Protected Overrides Sub OnResize(ByVal e As EventArgs)
            ' Center the panel
            GroupPanel1.Location = New Point((Me.Width - GroupPanel1.Width) / 2 + 16, ((Me.Height - LabelX1.Height - 16) - GroupPanel1.Height) / 2 + LabelX1.Height + 16)
            MyBase.OnResize(e)
        End Sub

    End Class
End Namespace
