Imports System.Text
Imports DevComponents.DotNetBar

Namespace one_stop_clearance_system
    Public Class mod_commands
        Private _LoginCommands As New DocumentCommands()
        Public Property LoginCommands() As DocumentCommands
            Get
                Return _LoginCommands
            End Get
            Set(ByVal value As DocumentCommands)
                _LoginCommands = value
            End Set
        End Property

        Private _AdminCommands As New DocumentCommands()
        Public Property AdminCommands() As DocumentCommands
            Get
                Return _AdminCommands
            End Get
            Set(ByVal value As DocumentCommands)
                _AdminCommands = value
            End Set
        End Property

        Private _GradesCommands As New DocumentCommands()
        Public Property GradesCommands() As DocumentCommands
            Get
                Return _GradesCommands
            End Get
            Set(ByVal value As DocumentCommands)
                _GradesCommands = value
            End Set
        End Property


        Private _BookstoreCommands As New DocumentCommands()
        Public Property BookstoreCommands() As DocumentCommands
            Get
                Return _BookstoreCommands
            End Get
            Set(ByVal value As DocumentCommands)
                _BookstoreCommands = value
            End Set
        End Property

        Private _AdminprevCommands As New DocumentCommands()
        Public Property AdminprevCommands() As DocumentCommands
            Get
                Return _AdminprevCommands
            End Get
            Set(ByVal value As DocumentCommands)
                _AdminprevCommands = value
            End Set
        End Property

        Private _RegisterCommands As New DocumentCommands()
        Public Property RegisterCommands() As DocumentCommands
            Get
                Return _RegisterCommands
            End Get
            Set(ByVal value As DocumentCommands)
                _RegisterCommands = value
            End Set
        End Property

        Private _RegistrarCommands As New DocumentCommands()
        Public Property RegistrarCommands() As DocumentCommands
            Get
                Return _RegistrarCommands
            End Get
            Set(ByVal value As DocumentCommands)
                _RegistrarCommands = value
            End Set
        End Property


        Private _LogoutCommands As New DocumentCommands()
        Public Property LogoutCommands() As DocumentCommands
            Get
                Return _LogoutCommands
            End Get
            Set(ByVal value As DocumentCommands)
                _LogoutCommands = value
            End Set
        End Property

        Private _SearchCommands As New DocumentCommands()
        Public Property SearchCommands() As DocumentCommands
            Get
                Return _SearchCommands
            End Get
            Set(ByVal value As DocumentCommands)
                _SearchCommands = value
            End Set
        End Property


        Private _BusinessCommands As New DocumentCommands()
        Public Property BusinessCommands() As DocumentCommands
            Get
                Return _BusinessCommands
            End Get
            Set(ByVal value As DocumentCommands)
                _BusinessCommands = value
            End Set
        End Property


        Private _GuidanceCommands As New DocumentCommands()
        Public Property GuidanceCommands() As DocumentCommands
            Get
                Return _GuidanceCommands
            End Get
            Set(ByVal value As DocumentCommands)
                _GuidanceCommands = value
            End Set
        End Property

        Private _LibraryCommands As New DocumentCommands()
        Public Property LibraryCommands() As DocumentCommands
            Get
                Return _LibraryCommands
            End Get
            Set(ByVal value As DocumentCommands)
                _LibraryCommands = value
            End Set
        End Property

        Private _InstructorCommands As New DocumentCommands()
        Public Property InstructorCommands() As DocumentCommands
            Get
                Return _InstructorCommands
            End Get
            Set(ByVal value As DocumentCommands)
                _InstructorCommands = value
            End Set
        End Property

        Private _SlideStartControl As Command
        Public Property ToggleStartControl() As Command
            Get
                Return _SlideStartControl
            End Get
            Set(ByVal value As Command)
                _SlideStartControl = value
            End Set
        End Property

        Private _ChangeMetroTheme As Command
        Public Property ChangeMetroTheme() As Command
            Get
                Return _ChangeMetroTheme
            End Get
            Set(ByVal value As Command)
                _ChangeMetroTheme = value
            End Set
        End Property

        Private _GettingStartedCommand As Command
        Public Property GettingStartedCommand() As Command
            Get
                Return _GettingStartedCommand
            End Get
            Set(ByVal value As Command)
                _GettingStartedCommand = value
            End Set
        End Property

        Private _NotImplemented As Command
        Public Property NotImplemented() As Command
            Get
                Return _NotImplemented
            End Get
            Set(ByVal value As Command)
                _NotImplemented = value
            End Set
        End Property

        Private _DevComponents As Command
        Public Property DevComponents() As Command
            Get
                Return _DevComponents
            End Get
            Set(ByVal value As Command)
                _DevComponents = value
            End Set
        End Property
    End Class

    Public Class DocumentCommands
        Private _New As Command
        Public Property [New]() As Command
            Get
                Return _New
            End Get
            Set(ByVal value As Command)
                _New = value
            End Set
        End Property

        Private _Find As Command
        Public Property Find() As Command
            Get
                Return _Find
            End Get
            Set(ByVal value As Command)
                _Find = value
            End Set
        End Property

        Private _Display As Command
        Public Property Display() As Command
            Get
                Return _Display
            End Get
            Set(ByVal value As Command)
                _Display = value
            End Set
        End Property

        Private _Search As Command
        Public Property Search() As Command
            Get
                Return _Search
            End Get
            Set(ByVal value As Command)
                _Search = value
            End Set
        End Property

        Private _Cancel As Command
        Public Property Cancel() As Command
            Get
                Return _Cancel
            End Get
            Set(ByVal value As Command)
                _Cancel = value
            End Set
        End Property

        Private _Enter As Command
        Public Property Enter() As Command
            Get
                Return _Enter
            End Get
            Set(ByVal value As Command)
                _Enter = value
            End Set
        End Property

        Private _Close As Command
        Public Property Close() As Command
            Get
                Return _Close
            End Get
            Set(ByVal value As Command)
                _Close = value
            End Set
        End Property

        Private _Logout As Command
        Public Property Logout() As Command
            Get
                Return _Logout
            End Get
            Set(ByVal value As Command)
                _Logout = value
            End Set
        End Property

        Private _Create As Command
        Public Property Create() As Command
            Get
                Return _Create
            End Get
            Set(ByVal value As Command)
                _Create = value
            End Set
        End Property



        Private _Regs As Command
        Public Property Regs() As Command
            Get
                Return _Regs
            End Get
            Set(ByVal value As Command)
                _Regs = value
            End Set
        End Property
        Private _Del As Command
        Public Property Del() As Command
            Get
                Return _Del
            End Get
            Set(ByVal value As Command)
                _Del = value
            End Set
        End Property

        Private _Add As Command
        Public Property Add() As Command
            Get
                Return _Add
            End Get
            Set(ByVal value As Command)
                _Add = value
            End Set
        End Property


        Private _Update As Command
        Public Property Update() As Command
            Get
                Return _Update
            End Get
            Set(ByVal value As Command)
                _Update = value
            End Set
        End Property
    End Class

End Namespace
