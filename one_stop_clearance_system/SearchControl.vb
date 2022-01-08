Imports System.ComponentModel
Imports System.Text

Namespace one_stop_clearance_system
    Partial Public Class SearchControl
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
                searchButton.Command = newValue.SearchCommands.Search
                cancelButton.Command = newValue.SearchCommands.Cancel
            Else
                searchButton.Command = Nothing
                cancelButton.Command = Nothing

            End If
        End Sub


      
        Private Sub stud_idText_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles stud_idText.TextChanged

        End Sub
    End Class
End Namespace
