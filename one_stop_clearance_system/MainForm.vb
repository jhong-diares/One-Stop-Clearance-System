Imports System.ComponentModel
Imports System.Text
Imports DevComponents.DotNetBar.Metro
Imports DevComponents.DotNetBar
Imports DevComponents.AdvTree
Imports DevComponents.DotNetBar.Metro.ColorTables

Namespace one_stop_clearance_system
    Partial Public Class MainForm
        Inherits MetroAppForm
        Private _StartControl As StartControl = Nothing
        Private _LoginControl As LoginControl = Nothing
        Private _Commands As mod_commands = Nothing
        Private _Search As SearchControl = Nothing
        Private _Business As BusinessControl = Nothing
        Private _Guidance As GuidanceControl = Nothing
        Private _Instructor As GuidanceControl = Nothing
        Private _Register As RegisterControl = Nothing
        Private _Adminprev As AdminprevControl = Nothing

        Public Sub New()
            InitializeComponent()

            ' Prepare commands
            _Commands = New mod_commands()

            _Commands.ToggleStartControl = New Command(components)
            AddHandler _Commands.ToggleStartControl.Executed, AddressOf ToggleStartControlExecuted

            'Login close
            _Commands.LoginCommands.Close = New Command(components)
            AddHandler _Commands.LoginCommands.Close.Executed, AddressOf CancelLoginExecuted

            'Login enter
            _Commands.LoginCommands.Enter = New Command(components)
            AddHandler _Commands.LoginCommands.Enter.Executed, AddressOf EnterLoginExecuted

            'Login register
            _Commands.LoginCommands.Regs = New Command(components)
            AddHandler _Commands.LoginCommands.Regs.Executed, AddressOf RegisterLoginExecuted

            'Register close
            _Commands.RegisterCommands.Close = New Command(components)
            AddHandler _Commands.RegisterCommands.Close.Executed, AddressOf BackRegisterExecuted

            'Register create
            _Commands.RegisterCommands.Create = New Command(components)
            AddHandler _Commands.RegisterCommands.Create.Executed, AddressOf RegisterCreateExecuted

            'Admin login
            _Commands.AdminCommands.[New] = New Command(components)
            AddHandler _Commands.AdminCommands.[New].Executed, AddressOf EnterAdminExecuted

            'Admin close
            _Commands.AdminCommands.Close = New Command(components)
            AddHandler _Commands.AdminCommands.Close.Executed, AddressOf CloseAdminprevExecuted

            'Admin enter
            _Commands.AdminCommands.Enter = New Command(components)
            AddHandler _Commands.AdminCommands.Enter.Executed, AddressOf adminLoginExecuted

            'Logout
            _Commands.LogoutCommands.Logout = New Command(components)
            AddHandler _Commands.LogoutCommands.Logout.Executed, AddressOf LogoutExecuted


            ' Search Control
            _Commands.SearchCommands.Find = New Command(components)
            AddHandler _Commands.SearchCommands.Find.Executed, AddressOf SearchStudentExecuted
            _Commands.SearchCommands.Search = New Command(components)
            AddHandler _Commands.SearchCommands.Search.Executed, AddressOf SearchStudentExecuted_button
            _Commands.SearchCommands.Cancel = New Command(components)
            AddHandler _Commands.SearchCommands.Cancel.Executed, AddressOf CancelSearchExecuted


            ' Registrar Command
            _Commands.RegistrarCommands.Find = New Command(components)
            AddHandler _Commands.RegistrarCommands.Find.Executed, AddressOf RegistrarSearchExecuted

            _Commands.RegistrarCommands.Del = New Command(components)
            AddHandler _Commands.RegistrarCommands.Del.Executed, AddressOf RegistrarDeleteExecuted

            _Commands.RegistrarCommands.Add = New Command(components)
            AddHandler _Commands.RegistrarCommands.Add.Executed, AddressOf RegistrarAddExecuted

            _Commands.RegistrarCommands.Update = New Command(components)
            AddHandler _Commands.RegistrarCommands.Update.Executed, AddressOf RegistrarUpdateExecuted

            ' Business Control
            _Commands.BusinessCommands.Display = New Command(components)
            AddHandler _Commands.BusinessCommands.Display.Executed, AddressOf BusinessExecuted

            _Commands.BusinessCommands.Cancel = New Command(components)
            AddHandler _Commands.BusinessCommands.Cancel.Executed, AddressOf CancelBusinessExecuted

            _Commands.BusinessCommands.Del = New Command(components)
            AddHandler _Commands.BusinessCommands.Del.Executed, AddressOf BusinessDeleteExecuted

            _Commands.BusinessCommands.Add = New Command(components)
            AddHandler _Commands.BusinessCommands.Add.Executed, AddressOf BusinessAddExecuted

            _Commands.BusinessCommands.Update = New Command(components)
            AddHandler _Commands.BusinessCommands.Update.Executed, AddressOf BusinessUpdateExecuted

            'Business Command
            _Commands.BusinessCommands.Find = New Command(components)
            AddHandler _Commands.BusinessCommands.Find.Executed, AddressOf BusinessSearchExecuted



            ' Guidance Control
            _Commands.GuidanceCommands.Display = New Command(components)
            AddHandler _Commands.GuidanceCommands.Display.Executed, AddressOf GuidanceExecuted

            _Commands.GuidanceCommands.Del = New Command(components)
            AddHandler _Commands.GuidanceCommands.Del.Executed, AddressOf GuidanceDeleteExecuted

            _Commands.GuidanceCommands.Cancel = New Command(components)
            AddHandler _Commands.GuidanceCommands.Cancel.Executed, AddressOf CancelGuidanceExecuted



            _Commands.GuidanceCommands.Add = New Command(components)
            AddHandler _Commands.GuidanceCommands.Add.Executed, AddressOf GuidanceAddExecuted

            _Commands.GuidanceCommands.Update = New Command(components)
            AddHandler _Commands.GuidanceCommands.Update.Executed, AddressOf GuidanceUpdateExecuted

            'Guidance Command
            _Commands.GuidanceCommands.Find = New Command(components)
            AddHandler _Commands.GuidanceCommands.Find.Executed, AddressOf GuidanceSearchExecuted

            ' Library Control
            _Commands.LibraryCommands.Display = New Command(components)
            AddHandler _Commands.LibraryCommands.Display.Executed, AddressOf LibraryExecuted


            _Commands.LibraryCommands.Del = New Command(components)
            AddHandler _Commands.LibraryCommands.Del.Executed, AddressOf LibraryDeleteExecuted

            _Commands.LibraryCommands.Cancel = New Command(components)
            AddHandler _Commands.LibraryCommands.Cancel.Executed, AddressOf CancelLibraryExecuted

            _Commands.LibraryCommands.Add = New Command(components)
            AddHandler _Commands.LibraryCommands.Add.Executed, AddressOf LibraryAddExecuted

            _Commands.LibraryCommands.Update = New Command(components)
            AddHandler _Commands.LibraryCommands.Update.Executed, AddressOf LibraryUpdateExecuted

            'Library Command
            _Commands.LibraryCommands.Find = New Command(components)
            AddHandler _Commands.LibraryCommands.Find.Executed, AddressOf LibrarySearchExecuted


            ' Intructor Control
            _Commands.InstructorCommands.Display = New Command(components)
            AddHandler _Commands.InstructorCommands.Display.Executed, AddressOf InstructorExecuted

            _Commands.InstructorCommands.Del = New Command(components)
            AddHandler _Commands.InstructorCommands.Del.Executed, AddressOf InstructorDeleteExecuted


            _Commands.InstructorCommands.Cancel = New Command(components)
            AddHandler _Commands.InstructorCommands.Cancel.Executed, AddressOf CancelInstructorExecuted


            _Commands.InstructorCommands.Add = New Command(components)
            AddHandler _Commands.InstructorCommands.Add.Executed, AddressOf InstructorAddExecuted

            _Commands.InstructorCommands.Update = New Command(components)
            AddHandler _Commands.InstructorCommands.Update.Executed, AddressOf InstructorUpdateExecuted

            'Intructor Command
            _Commands.InstructorCommands.Find = New Command(components)
            AddHandler _Commands.InstructorCommands.Find.Executed, AddressOf InstructorSearchExecuted


            'Grades Command
            _Commands.GradesCommands.Find = New Command(components)
            AddHandler _Commands.GradesCommands.Find.Executed, AddressOf GradesSearchExecuted

            _Commands.GradesCommands.Del = New Command(components)
            AddHandler _Commands.GradesCommands.Del.Executed, AddressOf GradesDeleteExecuted

            _Commands.GradesCommands.Add = New Command(components)
            AddHandler _Commands.GradesCommands.Add.Executed, AddressOf GradesAddExecuted

            _Commands.GradesCommands.Update = New Command(components)
            AddHandler _Commands.GradesCommands.Update.Executed, AddressOf GradesUpdateExecuted




            'Bookstore Command

            _Commands.BookstoreCommands.Display = New Command(components)
            AddHandler _Commands.BookstoreCommands.Display.Executed, AddressOf BookstoreExecuted

            _Commands.BookstoreCommands.Cancel = New Command(components)
            AddHandler _Commands.BookstoreCommands.Cancel.Executed, AddressOf CancelBookstoreExecuted

            _Commands.BookstoreCommands.Find = New Command(components)
            AddHandler _Commands.BookstoreCommands.Find.Executed, AddressOf BookstoreSearchExecuted

            _Commands.BookstoreCommands.Del = New Command(components)
            AddHandler _Commands.BookstoreCommands.Del.Executed, AddressOf BookstoreDeleteExecuted

            _Commands.BookstoreCommands.Add = New Command(components)
            AddHandler _Commands.BookstoreCommands.Add.Executed, AddressOf BookstoreAddExecuted

            _Commands.BookstoreCommands.Update = New Command(components)
            AddHandler _Commands.BookstoreCommands.Update.Executed, AddressOf BookstoreUpdateExecuted




            ' General commands
            _Commands.ChangeMetroTheme = New Command(components, New EventHandler(AddressOf ChangeMetroThemeExecuted))
            _Commands.NotImplemented = New Command(components, New EventHandler(AddressOf NotImplementedExecuted))
            _Commands.DevComponents = New Command(components, New EventHandler(AddressOf DevComponentsExecuted))
            _Commands.GettingStartedCommand = New Command(components, New EventHandler(AddressOf GettingStartedExecuted))


            'Login Front
            Me.SuspendLayout()
            _LoginControl = New LoginControl()
            _LoginControl.Commands = _Commands
            Me.Controls.Add(_LoginControl)
            _LoginControl.BringToFront()
            AddHandler _LoginControl.passwordTxt.KeyDown, AddressOf PasswordText_Keydown
            '_LoginControl.SlideSide = DevComponents.DotNetBar.Controls.eSlideSide.Right
            'AddHandler _LoginControl.Click, AddressOf LoginControl_Click
            Me.ResumeLayout(False)


            'Registrar listview command
            searchRegistrarButton.Command = _Commands.RegistrarCommands.Find
            searchBusinessButton.Command = _Commands.BusinessCommands.Find
            searchLibraryButton.Command = _Commands.LibraryCommands.Find
            searchGuidanceButton.Command = _Commands.GuidanceCommands.Find
            searchInstructorButton.Command = _Commands.InstructorCommands.Find
            searchGradessButton.Command = _Commands.GradesCommands.Find
            searchBookstoreButton.Command = _Commands.BookstoreCommands.Find

            deleteRegistrarButton.Command = _Commands.RegistrarCommands.Del
            deleteBusinessButton.Command = _Commands.BusinessCommands.Del
            deleteLibraryButton.Command = _Commands.LibraryCommands.Del
            deleteGuidanceButton.Command = _Commands.GuidanceCommands.Del
            deleteInstructorButton.Command = _Commands.InstructorCommands.Del
            deleteGradesButton.Command = _Commands.GradesCommands.Del
            deleteBookstoreButton.Command = _Commands.BookstoreCommands.Del


            addBookstoreButton.Command = _Commands.BookstoreCommands.Add
            updateBookstoreButton.Command = _Commands.BookstoreCommands.Update

            addRegistrarButton.Command = _Commands.RegistrarCommands.Add
            updateRegistrarButton.Command = _Commands.RegistrarCommands.Update

            addBusinessButton.Command = _Commands.BusinessCommands.Add
            updateBusinessButton.Command = _Commands.BusinessCommands.Update

            addGuidanceButton.Command = _Commands.GuidanceCommands.Add
            updateGuidanceButton.Command = _Commands.GuidanceCommands.Update

            addLibraryButton.Command = _Commands.LibraryCommands.Add
            updateLibraryButton.Command = _Commands.LibraryCommands.Update

            addInstructorButton.Command = _Commands.InstructorCommands.Add
            updateInstructorButton.Command = _Commands.InstructorCommands.Update

            addGradesButton.Command = _Commands.GradesCommands.Add
            updateGradesButton.Command = _Commands.GradesCommands.Update

            'Me.SuspendLayout()
            '_StartControl = New StartControl()
            '_StartControl.Commands = _Commands
            'Me.Controls.Add(_StartControl)
            '_StartControl.BringToFront()
            '_StartControl.SlideSide = DevComponents.DotNetBar.Controls.eSlideSide.Right
            'AddHandler _StartControl.Click, AddressOf StartControl_Click
            'Me.ResumeLayout(False)

            ' Assign commands to toolbar buttons
            ' newInvoiceButton.Command = _Commands.InvoiceCommands.[New]
            'newClientButton.Command = _Commands.ClientCommands.[New]

            ' Add metro color themes
            Dim metroThemes() As MetroColorGeneratorParameters = MetroColorGeneratorParameters.GetAllPredefinedThemes()
            For Each mt As MetroColorGeneratorParameters In metroThemes
                Dim theme As New ButtonItem(mt.ThemeName, mt.ThemeName)
                theme.Command = _Commands.ChangeMetroTheme
                theme.CommandParameter = mt
                colorThemeButton.SubItems.Add(theme)
            Next mt
        End Sub

#Region "Command Execution"

        Private Sub GettingStartedExecuted(ByVal sender As Object, ByVal e As EventArgs)
            Process.Start("http://www.devcomponents.com/kb2/?p=1160")
        End Sub
        Private Sub NotImplementedExecuted(ByVal sender As Object, ByVal e As EventArgs)
            MessageBoxEx.Show(Me, "Placeholder for real action. This command is not implemented.", "Metro Bill", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Sub
        Private Sub DevComponentsExecuted(ByVal sender As Object, ByVal e As EventArgs)
            Process.Start("http://www.devcomponents.com/dotnetbar/")
        End Sub
        Private Sub ChangeMetroThemeExecuted(ByVal sender As Object, ByVal e As EventArgs)
            Dim source As ICommandSource = CType(sender, ICommandSource)
            Dim theme As MetroColorGeneratorParameters = CType(source.CommandParameter, MetroColorGeneratorParameters)
            StyleManager.MetroColorGeneratorParameters = theme
        End Sub
#Region "Adminprev"
        Private _AdminprevControl As AdminprevControl = Nothing
        Private Sub EnterAdminExecuted(ByVal sender As Object, ByVal e As EventArgs)
            Debug.Assert(_AdminprevControl Is Nothing)
            _AdminprevControl = New AdminprevControl()
            _AdminprevControl.Commands = _Commands
            Me.ShowModalPanel(_AdminprevControl, DevComponents.DotNetBar.Controls.eSlideSide.Left)
            If Not _AdminprevControl.Visible Then
                _AdminprevControl.SlideOutButtonVisible = False
            End If
            AddHandler _AdminprevControl.admin_passText.KeyDown, AddressOf adminPassText_Keydown
            _AdminprevControl.admin_passText.Select()
        End Sub


        Private Sub BackAdminprevDialog()
            _LoginControl.passwordTxt.Text = ""
            _LoginControl.usernameTxt.Text = ""
            If Not _AdminprevControl.Visible Then
                _AdminprevControl.SlideOutButtonVisible = True
            End If
            Me.CloseModalPanel(_AdminprevControl, DevComponents.DotNetBar.Controls.eSlideSide.Left)
            _AdminprevControl.Commands = Nothing
            _AdminprevControl.Dispose()
            _AdminprevControl = Nothing

            _LoginControl.usernameTxt.Select()

        End Sub

        Private Sub CloseAdminprevExecuted(ByVal sender As Object, ByVal e As EventArgs)
            Debug.Assert(_AdminprevControl IsNot Nothing)
            BackAdminprevDialog()
        End Sub

        Private Sub adminLoginExecuted(ByVal sender As Object, ByVal e As EventArgs)
            rs = New ADODB.Recordset
            rs.Open("SELECT * FROM `tbl_account` WHERE username='" & _AdminprevControl.labelX5.Text & "' and password='" & _AdminprevControl.admin_passText.Text & "'  ", cn, 1, 2)

            Dim y As Integer
            y = 0
            While Not rs.EOF
                rs.MoveNext()
                y = y + 1
            End While
            If y = 1 Then
                MsgBox("Login Successfully", MsgBoxStyle.Information, "SUCCESS")
                _RegisterControl = New RegisterControl()
                _RegisterControl.Commands = _Commands
                Me.ShowModalPanel(_RegisterControl, DevComponents.DotNetBar.Controls.eSlideSide.Left)
                If Not _RegisterControl.Visible Then
                    _RegisterControl.SlideOutButtonVisible = False
                End If
                _RegisterControl.username.Select()

            ElseIf _AdminprevControl.admin_passText.Text = "" Then
                MsgBox("Please, Enter administrator password...", MsgBoxStyle.Exclamation, "FAILED")
                _AdminprevControl.admin_passText.Select()
            Else
                MsgBox("Invalid Input !", MsgBoxStyle.Exclamation, "FAILED")
                _AdminprevControl.admin_passText.Text = ""
                _AdminprevControl.admin_passText.Select()
            End If


        End Sub

        Private Sub adminPassText_Keydown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
            If e.KeyCode = Keys.Enter Then
                rs = New ADODB.Recordset
                rs.Open("SELECT * FROM `tbl_account` WHERE username='" & _AdminprevControl.labelX5.Text & "' and password='" & _AdminprevControl.admin_passText.Text & "'  ", cn, 1, 2)

                Dim y As Integer
                y = 0
                While Not rs.EOF
                    rs.MoveNext()
                    y = y + 1
                End While
                If y = 1 Then
                    MsgBox("Login Successfully", MsgBoxStyle.Information, "SUCCESS")
                    _RegisterControl = New RegisterControl()
                    _RegisterControl.Commands = _Commands
                    Me.ShowModalPanel(_RegisterControl, DevComponents.DotNetBar.Controls.eSlideSide.Left)
                    If Not _RegisterControl.Visible Then
                        _RegisterControl.SlideOutButtonVisible = False
                    End If
                    _RegisterControl.username.Select()
                    qincrement()
                ElseIf _AdminprevControl.admin_passText.Text = "" Then
                    MsgBox("Please, Enter administrator password...", MsgBoxStyle.Exclamation, "FAILED")
                    _AdminprevControl.admin_passText.Select()
                Else
                    MsgBox("Invalid Input !", MsgBoxStyle.Exclamation, "FAILED")
                    _AdminprevControl.admin_passText.Text = ""
                    _AdminprevControl.admin_passText.Select()
                End If
            End If

        End Sub
#End Region

#Region "Register"
        Private _RegisterControl As RegisterControl = Nothing
        Private Sub RegisterLoginExecuted(ByVal sender As Object, ByVal e As EventArgs)
            Debug.Assert(_RegisterControl Is Nothing)
            _RegisterControl = New RegisterControl()
            _RegisterControl.Commands = _Commands
            Me.ShowModalPanel(_RegisterControl, DevComponents.DotNetBar.Controls.eSlideSide.Left)
            If Not _RegisterControl.Visible Then
                _RegisterControl.SlideOutButtonVisible = False
            End If
            _RegisterControl.username.Select()

        End Sub
        Private Sub RegisterCreateExecuted(ByVal sender As Object, ByVal e As EventArgs)

            With _RegisterControl

                If .cmb_department.Text = "" Or .username.Text = "" Or .password.Text = "" Or .confirm_password.Text = "" Or .email.Text = "" Then
                    MsgBox("Fill out all fields!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Warning")

                ElseIf .confirm_password.Text <> .password.Text Then
                    MsgBox("Password and confirm password doen't match !", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Warning")
                Else
                    rs = New ADODB.Recordset
                    rs.Open("INSERT INTO `tbl_account` (`account_name` ,`username`, `password`, `email`, `department`) VALUES ('" & _RegisterControl.account_name.Text & "','" & _RegisterControl.username.Text & "','" & _RegisterControl.password.Text & "','" & _RegisterControl.email.Text & "', '" & _RegisterControl.cmb_department.Text & "')", cn, 1, 2)
                    MsgBox("New Account Created!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "SUCCESS")
                    .username.Text = ""
                    .password.Text = ""
                    .confirm_password.Text = ""
                    .email.Text = ""
                    .cmb_department.Text = ""
                    BackRegisterDialog()
                End If
            End With
        End Sub


        Sub qincrement()
            rs = New ADODB.Recordset
            rs.Open("SELECT * FROM `tbl_account` ", cn, 1, 2)
            If rs.EOF Then
                _RegisterControl.account_name.Text = "EMP-0000001"
            Else
                rs = New ADODB.Recordset
                rs.Open("SELECT MAX(ID) FROM `tbl_account`", cn, 1, 2)
                Dim mx As Integer = rs.Fields(0).Value
                rs = New ADODB.Recordset
                rs.Open("SELECT * FROM `tbl_account` WHERE ID = " & mx, cn, 1, 2)
                _RegisterControl.account_id.Text = rs.Fields("account_name").Value.ToString.Substring(4, 7) + 1

                If _RegisterControl.account_id.Text <= 9 Then
                    _RegisterControl.account_id.Text = "000000" + _RegisterControl.account_id.Text
                ElseIf _RegisterControl.account_id.Text <= 99 Then
                    _RegisterControl.account_id.Text = "00000" + _RegisterControl.account_id.Text
                ElseIf _RegisterControl.account_id.Text <= 999 Then
                    _RegisterControl.account_id.Text = "0000" + _RegisterControl.account_id.Text
                ElseIf _RegisterControl.account_id.Text <= 9999 Then
                    _RegisterControl.account_id.Text = "000" + _RegisterControl.account_id.Text
                ElseIf _RegisterControl.account_id.Text <= 99999 Then
                    _RegisterControl.account_id.Text = "00" + _RegisterControl.account_id.Text
                ElseIf _RegisterControl.account_id.Text <= 999999 Then
                    _RegisterControl.account_id.Text = "0" + _RegisterControl.account_id.Text
                End If
                _RegisterControl.account_name.Text = "EMP-" + _RegisterControl.account_id.Text
            End If

        End Sub

        Private Sub BackRegisterDialog()
            _AdminprevControl.admin_passText.Text = ""

            If Not _AdminprevControl.Visible Then
                _AdminprevControl.SlideOutButtonVisible = True
            End If

            BackAdminprevDialog()

            Me.CloseModalPanel(_RegisterControl, DevComponents.DotNetBar.Controls.eSlideSide.Left)
            _RegisterControl.Commands = Nothing
            _RegisterControl.Dispose()
            _RegisterControl = Nothing


        End Sub

        Private Sub BackRegisterExecuted(ByVal sender As Object, ByVal e As EventArgs)
            Debug.Assert(_RegisterControl IsNot Nothing)
            BackRegisterDialog()
        End Sub
#End Region

#Region "LOGIN"
        Private Sub ToggleStartControlExecuted(ByVal sender As Object, ByVal e As EventArgs)
            _StartControl.IsOpen = Not _StartControl.IsOpen
        End Sub
        Private Sub CancelLoginExecuted(ByVal sender As Object, ByVal e As EventArgs)
            If MsgBox("Are you sure you want to Exit?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "WARNING") = MsgBoxResult.Yes Then
                Application.Exit()
            End If
        End Sub
        Private Sub PasswordText_Keydown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
            If e.KeyCode = Keys.Enter Then
                rs = New ADODB.Recordset
                rs.Open("SELECT * FROM `tbl_account` WHERE username='" & _LoginControl.usernameTxt.Text & "' AND password='" & _LoginControl.passwordTxt.Text & "'", cn, 1, 2)
                Dim y As Integer
                y = 0
                While Not rs.EOF
                    rs.MoveNext()
                    y = y + 1
                End While
                If y = 1 Then
                    rs = New ADODB.Recordset
                    rs.Open("SELECT * FROM `tbl_account` WHERE username='" & _LoginControl.usernameTxt.Text & "' AND password='" & _LoginControl.passwordTxt.Text & "'", cn, 1, 2)
                    MsgBox("Login Successful!", MsgBoxStyle.Information, "SYSTEM")

                    Me.SuspendLayout()
                    _StartControl = New StartControl()
                    _StartControl.Commands = _Commands
                    Me.Controls.Add(_StartControl)
                    _StartControl.BringToFront()
                    _StartControl.SlideSide = DevComponents.DotNetBar.Controls.eSlideSide.Right
                    AddHandler _StartControl.Click, AddressOf LoginControl_Click

                    Try
                        _StartControl.lbl_path2.Text = rs.Fields("photo_path").Value.ToString
                        If _StartControl.lbl_path2.Text = Nothing Then
                            _StartControl.pic_emp.Image = Nothing
                        Else
                            _StartControl.pic_emp.Image = Image.FromFile(_StartControl.lbl_path2.Text)
                        End If
                    Catch ex As Exception

                    End Try


                    _StartControl.LabelX20.Text = rs.Fields(3).Value.ToString
                    LabelItem3.Text = rs.Fields(6).Value.ToString
                    _LoginControl.Dispose()
                    If LabelItem3.Text = "REGISTRAR" Then
                        registrar_tab.Select()
                        registrar_tab.Focus()
                        registrar_tab.Enabled = True
                        registrar_tab.Visible = True
                        business_tab.Enabled = False
                        library_tab.Enabled = False
                        guidance_tab.Enabled = False
                        instructor_tab.Enabled = True
                        grades_tab.Visible = True
                        grades_tab.Enabled = True
                        bookstore_tab.Visible = False
                        bookstore_tab.Enabled = False


                        business_tab.Visible = False
                        library_tab.Visible = False
                        guidance_tab.Visible = False
                        instructor_tab.Visible = True


                    ElseIf LabelItem3.Text = "BUSINESS" Then
                        business_tab.Enabled = True
                        business_tab.Visible = True
                        business_tab.Select()
                        business_tab.Focus()
                        registrar_tab.Enabled = False
                        library_tab.Enabled = False
                        guidance_tab.Enabled = False
                        instructor_tab.Enabled = False
                        grades_tab.Enabled = False

                        registrar_tab.Visible = False
                        library_tab.Visible = False
                        guidance_tab.Visible = False
                        instructor_tab.Visible = False
                        grades_tab.Visible = False
                        bookstore_tab.Visible = False
                        bookstore_tab.Enabled = False

                    ElseIf LabelItem3.Text = "LIBRARY" Then
                        library_tab.Enabled = True
                        library_tab.Visible = True
                        library_tab.Select()
                        library_tab.Focus()
                        registrar_tab.Enabled = False
                        business_tab.Enabled = False
                        guidance_tab.Enabled = False
                        instructor_tab.Enabled = False
                        grades_tab.Enabled = False

                        registrar_tab.Visible = False
                        business_tab.Visible = False
                        guidance_tab.Visible = False
                        instructor_tab.Visible = False
                        grades_tab.Visible = False
                        bookstore_tab.Visible = False
                        bookstore_tab.Enabled = False

                    ElseIf LabelItem3.Text = "GUIDANCE" Then
                        guidance_tab.Enabled = True
                        guidance_tab.Visible = True
                        guidance_tab.Select()
                        guidance_tab.Focus()

                        registrar_tab.Enabled = False
                        business_tab.Enabled = False
                        library_tab.Enabled = False
                        instructor_tab.Enabled = False
                        grades_tab.Enabled = False

                        registrar_tab.Visible = False
                        business_tab.Visible = False
                        library_tab.Visible = False
                        instructor_tab.Visible = False
                        grades_tab.Visible = False

                        bookstore_tab.Visible = False
                        bookstore_tab.Enabled = False

                    ElseIf LabelItem3.Text = "BOOKSTORE" Then
                        guidance_tab.Enabled = False
                        guidance_tab.Visible = False
                        bookstore_tab.Select()
                        bookstore_tab.Focus()

                        registrar_tab.Enabled = False
                        business_tab.Enabled = False
                        library_tab.Enabled = False
                        instructor_tab.Enabled = False
                        grades_tab.Enabled = False

                        registrar_tab.Visible = False
                        business_tab.Visible = False
                        library_tab.Visible = False
                        instructor_tab.Visible = False
                        grades_tab.Visible = False

                        bookstore_tab.Visible = True
                        bookstore_tab.Enabled = True
                    Else
                        registrar_tab.Enabled = True
                        business_tab.Enabled = True
                        library_tab.Enabled = True
                        guidance_tab.Enabled = True
                        instructor_tab.Enabled = True
                        grades_tab.Enabled = True
                        bookstore_tab.Visible = True
                        bookstore_tab.Enabled = True

                        registrar_tab.Visible = True
                        business_tab.Visible = True
                        library_tab.Visible = True
                        guidance_tab.Visible = True
                        instructor_tab.Visible = True
                        grades_tab.Visible = True
                    End If
                    Me.ResumeLayout(False)
                    UpdateControlsSizeAndLocation()
                    MyBase.OnLoad(e)
                Else
                    MsgBox("Invalid account!", MsgBoxStyle.Exclamation, "FAILED")
                    _LoginControl.passwordTxt.Text = Nothing
                    _LoginControl.usernameTxt.Select()
                End If
            End If
        End Sub
        Private Sub EnterLoginExecuted(ByVal sender As Object, ByVal e As EventArgs)
            rs = New ADODB.Recordset
            rs.Open("SELECT * FROM `tbl_account` WHERE username='" & _LoginControl.usernameTxt.Text & "' AND password='" & _LoginControl.passwordTxt.Text & "'", cn, 1, 2)
            Dim y As Integer
            y = 0
            While Not rs.EOF
                rs.MoveNext()
                y = y + 1
            End While
            If y = 1 Then
                rs = New ADODB.Recordset
                rs.Open("SELECT * FROM `tbl_account` WHERE username='" & _LoginControl.usernameTxt.Text & "' AND password='" & _LoginControl.passwordTxt.Text & "'", cn, 1, 2)
                MsgBox("Login Successful!", MsgBoxStyle.Information, "SYSTEM")

                Me.SuspendLayout()
                _StartControl = New StartControl()
                _StartControl.Commands = _Commands
                Me.Controls.Add(_StartControl)
                _StartControl.BringToFront()
                _StartControl.SlideSide = DevComponents.DotNetBar.Controls.eSlideSide.Right
                AddHandler _StartControl.Click, AddressOf LoginControl_Click

                _StartControl.lbl_path2.Text = rs.Fields("photo_path").Value.ToString
                If _StartControl.lbl_path2.Text = Nothing Then
                    _StartControl.pic_emp.Image = Nothing
                Else
                    _StartControl.pic_emp.Image = Image.FromFile(_StartControl.lbl_path2.Text)
                End If

                _StartControl.LabelX20.Text = rs.Fields(3).Value.ToString
                LabelItem3.Text = rs.Fields(6).Value.ToString
                _LoginControl.Dispose()
                If LabelItem3.Text = "REGISTRAR" Then
                    registrar_tab.Select()
                    registrar_tab.Focus()
                    registrar_tab.Enabled = True
                    registrar_tab.Visible = True
                    business_tab.Enabled = False
                    library_tab.Enabled = False
                    guidance_tab.Enabled = False
                    instructor_tab.Enabled = True
                    grades_tab.Visible = True
                    grades_tab.Enabled = True
                    bookstore_tab.Visible = False
                    bookstore_tab.Enabled = False


                    business_tab.Visible = False
                    library_tab.Visible = False
                    guidance_tab.Visible = False
                    instructor_tab.Visible = True


                ElseIf LabelItem3.Text = "BUSINESS" Then
                    business_tab.Enabled = True
                    business_tab.Visible = True
                    business_tab.Select()
                    business_tab.Focus()
                    registrar_tab.Enabled = False
                    library_tab.Enabled = False
                    guidance_tab.Enabled = False
                    instructor_tab.Enabled = False
                    grades_tab.Enabled = False

                    registrar_tab.Visible = False
                    library_tab.Visible = False
                    guidance_tab.Visible = False
                    instructor_tab.Visible = False
                    grades_tab.Visible = False
                    bookstore_tab.Visible = False
                    bookstore_tab.Enabled = False

                ElseIf LabelItem3.Text = "LIBRARY" Then
                    library_tab.Enabled = True
                    library_tab.Visible = True
                    library_tab.Select()
                    library_tab.Focus()
                    registrar_tab.Enabled = False
                    business_tab.Enabled = False
                    guidance_tab.Enabled = False
                    instructor_tab.Enabled = False
                    grades_tab.Enabled = False

                    registrar_tab.Visible = False
                    business_tab.Visible = False
                    guidance_tab.Visible = False
                    instructor_tab.Visible = False
                    grades_tab.Visible = False
                    bookstore_tab.Visible = False
                    bookstore_tab.Enabled = False

                ElseIf LabelItem3.Text = "GUIDANCE" Then
                    guidance_tab.Enabled = True
                    guidance_tab.Visible = True
                    guidance_tab.Select()
                    guidance_tab.Focus()

                    registrar_tab.Enabled = False
                    business_tab.Enabled = False
                    library_tab.Enabled = False
                    instructor_tab.Enabled = False
                    grades_tab.Enabled = False

                    registrar_tab.Visible = False
                    business_tab.Visible = False
                    library_tab.Visible = False
                    instructor_tab.Visible = False
                    grades_tab.Visible = False

                    bookstore_tab.Visible = False
                    bookstore_tab.Enabled = False

                ElseIf LabelItem3.Text = "BOOKSTORE" Then
                    guidance_tab.Enabled = False
                    guidance_tab.Visible = False
                    bookstore_tab.Select()
                    bookstore_tab.Focus()

                    registrar_tab.Enabled = False
                    business_tab.Enabled = False
                    library_tab.Enabled = False
                    instructor_tab.Enabled = False
                    grades_tab.Enabled = False

                    registrar_tab.Visible = False
                    business_tab.Visible = False
                    library_tab.Visible = False
                    instructor_tab.Visible = False
                    grades_tab.Visible = False

                    bookstore_tab.Visible = True
                    bookstore_tab.Enabled = True
                Else
                    registrar_tab.Enabled = True
                    business_tab.Enabled = True
                    library_tab.Enabled = True
                    guidance_tab.Enabled = True
                    instructor_tab.Enabled = True
                    grades_tab.Enabled = True
                    bookstore_tab.Visible = True
                    bookstore_tab.Enabled = True

                    registrar_tab.Visible = True
                    business_tab.Visible = True
                    library_tab.Visible = True
                    guidance_tab.Visible = True
                    instructor_tab.Visible = True
                    grades_tab.Visible = True
                End If

                Me.ResumeLayout(False)
                UpdateControlsSizeAndLocation()
                MyBase.OnLoad(e)
            Else
                MsgBox("Invalid account!", MsgBoxStyle.Exclamation, "FAILED")
                _LoginControl.passwordTxt.Text = Nothing
                _LoginControl.usernameTxt.Select()
            End If
        End Sub
#End Region

#Region "LOGOUT"
        Private Sub LogoutExecuted(ByVal sender As Object, ByVal e As EventArgs)
            If MsgBox("Are you sure you want to logout?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "WARNING") = MsgBoxResult.Yes Then

                _StartControl.Dispose()
                Me.SuspendLayout()
                _LoginControl = New LoginControl()
                _LoginControl.Commands = _Commands
                Me.Controls.Add(_LoginControl)
                _LoginControl.BringToFront()
                _LoginControl.usernameTxt.Select()
                AddHandler _LoginControl.passwordTxt.KeyDown, AddressOf PasswordText_Keydown
                Me.ResumeLayout(False)
                UpdateControlsSizeAndLocation_Login()
                MyBase.OnLoad(e)
            End If
        End Sub
#End Region
        Private rs As New ADODB.Recordset
#Region "Registrar"
        '// Search Registrar Textbox
        Private Sub searchRegistrarTxt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles searchRegistrarTxt.TextChanged

            rs = New ADODB.Recordset
            rs.Open("SELECT * FROM  `tbl_registrar` WHERE `ID` like '%" & searchRegistrarTxt.Text & "%' or `stud_id` like '%" & searchRegistrarTxt.Text & "%' or `last_name` like '%" & searchRegistrarTxt.Text & "%' or `first_name` like '%" & searchRegistrarTxt.Text & "%' or `middle_name` like '%" & searchRegistrarTxt.Text & "%' or `current_course` like '%" & searchRegistrarTxt.Text & "%' or `year_level` like '%" & searchRegistrarTxt.Text & "%' or `semester` like '%" & searchRegistrarTxt.Text & "%' or `school_yr` like '%" & searchRegistrarTxt.Text & "%' or `contact_num` like '%" & searchRegistrarTxt.Text & "%' ", cn, 1, 2)
            ListViewEx1.Items.Clear()
            Do While Not rs.EOF
                Dim lv As ListViewItem
                lv = ListViewEx1.Items.Add(rs.Fields(0).Value)
                lv.SubItems.Add(rs.Fields(1).Value)
                lv.SubItems.Add(rs.Fields(2).Value)
                lv.SubItems.Add(rs.Fields(3).Value)
                lv.SubItems.Add(rs.Fields(4).Value)
                lv.SubItems.Add(rs.Fields(5).Value)
                lv.SubItems.Add(rs.Fields(6).Value)
                lv.SubItems.Add(rs.Fields(7).Value)
                lv.SubItems.Add(rs.Fields(8).Value)
                lv.SubItems.Add(rs.Fields(9).Value)
                lv.SubItems.Add(rs.Fields(10).Value)
                rs.MoveNext()
            Loop
        End Sub
        Private Sub RegistrarSearchExecuted(ByVal sender As Object, ByVal e As EventArgs)
            searchRegistrarTxt.Focus()
        End Sub
        Private Sub RegistrarDeleteExecuted(ByVal sender As Object, ByVal e As EventArgs)
            If _StartControl.LabelX20.Text <> "ADM-0000001" Then
                MsgBox("You don't have access to this command!", MsgBoxStyle.Critical, "SYSTEM")
            ElseIf si_id_txt.Text = "" Then
                MsgBox("Please, Select from the list", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "WARNING")
            ElseIf MsgBox("Are you sure you want to delete this record?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "WARNING") = MsgBoxResult.Yes Then
                rs = New ADODB.Recordset
                rs.Open("DELETE FROM `tbl_registrar` WHERE `ID` = " & si_id_txt.Text & " ", cn, 1, 2)
                rs = New ADODB.Recordset
                rs.Open("SELECT * FROM `tbl_business` WHERE `stud_id` = '" & prev_idLbl.Text & "' ", cn, 1, 2)
                rs = New ADODB.Recordset
                rs.Open("DELETE FROM `tbl_business` WHERE `stud_id` = '" & prev_idLbl.Text & "' ", cn, 1, 2)
                rs = New ADODB.Recordset
                rs.Open("SELECT * FROM `tbl_library` WHERE `stud_id` = '" & prev_idLbl.Text & "' ", cn, 1, 2)
                rs = New ADODB.Recordset
                rs.Open("DELETE FROM `tbl_library` WHERE `stud_id` = '" & prev_idLbl.Text & "' ", cn, 1, 2)
                rs = New ADODB.Recordset
                rs.Open("SELECT * FROM `tbl_guidance` WHERE `stud_id` = '" & prev_idLbl.Text & "' ", cn, 1, 2)
                rs = New ADODB.Recordset
                rs.Open("DELETE FROM `tbl_guidance` WHERE `stud_id` = '" & prev_idLbl.Text & "' ", cn, 1, 2)
                rs = New ADODB.Recordset
                rs.Open("SELECT * FROM `tbl_grades` WHERE `stud_id` = '" & prev_idLbl.Text & "' ", cn, 1, 2)
                rs = New ADODB.Recordset
                rs.Open("DELETE FROM `tbl_grades` WHERE `stud_id` = '" & prev_idLbl.Text & "' ", cn, 1, 2)
                rs = New ADODB.Recordset
                rs.Open("SELECT * FROM `tbl_bookstore` WHERE `stud_id` = '" & prev_idLbl.Text & "' ", cn, 1, 2)
                rs = New ADODB.Recordset
                rs.Open("DELETE FROM `tbl_bookstore` WHERE `stud_id` = '" & prev_idLbl.Text & "' ", cn, 1, 2)

                loadgradesdata()
                loadguidancedata()
                loadbusinessdata()
                loadlibrarydata()
                loadregistrardata()
                loadbookstoredata()

                MsgBox("Delete Succesfully", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "SUCCESS")
                clear1()
            End If
        End Sub


        Private Sub RegistrarAddExecuted(ByVal sender As Object, ByVal e As EventArgs)
            If si_stud_id_txt.Text = Nothing _
                Or si_Lname_txt.Text = Nothing _
                Or si_Fname_txt.Text = Nothing _
                Or si_Mname_txt.Text = Nothing _
                Or si_course_txt.Text = Nothing _
                Or si_yr_txt.Text = Nothing _
                Or si_semester_txt.Text = Nothing _
                Or si_acadyear_txt.Text = Nothing _
                Or si_contact_txt.Text = Nothing Then
                MsgBox("Fill-out all fields !", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Warning")
            Else

                rs = New ADODB.Recordset
                rs.Open("SELECT * FROM `tbl_registrar` WHERE `stud_id` ='" & si_stud_id_txt.Text & "' ", cn, 1, 2)
                Dim q As Integer
                q = 0
                While Not rs.EOF
                    rs.MoveNext()
                    q = q + 1
                End While
                If q = 1 Then
                    MsgBox("The student number is already taken", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "FAILED")
                    si_stud_id_txt.Select()
                    Exit Sub
                Else

                    rs = New ADODB.Recordset
                    rs.Open("INSERT INTO `tbl_registrar` ( `stud_id`, `last_name`, `first_name`, `middle_name` , `current_course`, `year_level`, `semester`, `school_yr`, `contact_num`, `path_image`) VALUES ( '" & si_stud_id_txt.Text & "', '" & si_Lname_txt.Text & "', '" & si_Fname_txt.Text & "', '" & si_Mname_txt.Text & "', '" & si_course_txt.Text & "', '" & si_yr_txt.Text & "', '" & si_semester_txt.Text & "' , '" & si_acadyear_txt.Text & "', '" & si_contact_txt.Text & "', '" & si_photo_path_txt.Text & "')", cn, 1, 2)
                    rs.Open("INSERT INTO `tbl_library` ( `stud_id`, `last_name`, `first_name`, `middle_name` , `current_course`, `year_level`, `semester`, `school_yr`, `contact_num`, `path_image`,`unreturned_book`, `remaining_penalty`,`status`) VALUES ( '" & si_stud_id_txt.Text & "', '" & si_Lname_txt.Text & "', '" & si_Fname_txt.Text & "', '" & si_Mname_txt.Text & "', '" & si_course_txt.Text & "', '" & si_yr_txt.Text & "', '" & si_semester_txt.Text & "' , '" & si_acadyear_txt.Text & "', '" & si_contact_txt.Text & "', '" & si_photo_path_txt.Text & "','--','00.00','CLEARED')", cn, 1, 2)
                    rs.Open("INSERT INTO `tbl_guidance` ( `stud_id`, `last_name`, `first_name`, `middle_name` , `current_course`, `year_level`, `semester`, `school_yr`, `contact_num`, `path_image`,`uncollected_requirements`, `status`) VALUES ( '" & si_stud_id_txt.Text & "', '" & si_Lname_txt.Text & "', '" & si_Fname_txt.Text & "', '" & si_Mname_txt.Text & "', '" & si_course_txt.Text & "', '" & si_yr_txt.Text & "', '" & si_semester_txt.Text & "' , '" & si_acadyear_txt.Text & "', '" & si_contact_txt.Text & "', '" & si_photo_path_txt.Text & "','--','CLEARED')", cn, 1, 2)
                    rs.Open("INSERT INTO `tbl_business` ( `stud_id`, `last_name`, `first_name`, `middle_name` , `current_course`, `year_level`, `semester`, `school_yr`, `contact_num`, `path_image`,`description`, `remaining_balance`,`status`) VALUES ( '" & si_stud_id_txt.Text & "', '" & si_Lname_txt.Text & "', '" & si_Fname_txt.Text & "', '" & si_Mname_txt.Text & "', '" & si_course_txt.Text & "', '" & si_yr_txt.Text & "', '" & si_semester_txt.Text & "' , '" & si_acadyear_txt.Text & "', '" & si_contact_txt.Text & "', '" & si_photo_path_txt.Text & "','--','00.00','CLEARED')", cn, 1, 2)
                    rs.Open("INSERT INTO `tbl_bookstore` ( `stud_id`, `last_name`, `first_name`, `middle_name` , `current_course`, `year_level`, `semester`, `school_yr`, `contact_num`, `path_image`,`status`) VALUES ( '" & si_stud_id_txt.Text & "', '" & si_Lname_txt.Text & "', '" & si_Fname_txt.Text & "', '" & si_Mname_txt.Text & "', '" & si_course_txt.Text & "', '" & si_yr_txt.Text & "', '" & si_semester_txt.Text & "' , '" & si_acadyear_txt.Text & "', '" & si_contact_txt.Text & "', '" & si_photo_path_txt.Text & "','CLEARED')", cn, 1, 2)
                    rs.Open("INSERT INTO `tbl_grades` (`emp_id`, `last_name`,`first_name`, `middle_name`, `subject_code`,`subject_description`, `units`, `school_yr`, `semester`, `year_level`, `stud_id`, `stud_name`, `grades`, `status`, `current_course`,`path_image`) VALUES ('NO DATA','NO DATA','NO DATA','NO DATA','NO DATA','NO DATA','NO DATA','" & si_acadyear_txt.Text & "','" & si_semester_txt.Text & "', '" & si_yr_txt.Text & "', '" & si_stud_id_txt.Text & "', '" & si_Lname_txt.Text + ", " + si_Fname_txt.Text + " " + si_Mname_txt.Text & "', 'NO DATA', 'NOT CLEARED','" & si_course_txt.Text & "', '" & si_photo_path_txt.Text & "')", cn, 1, 2)
                    MsgBox("New Record Added !", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "SUCCESS")

                    loadregistrardata()
                    loadlibrarydata()
                    loadguidancedata()
                    loadbusinessdata()
                    loadgradesdata()
                    loadbookstoredata()

                    clear1()

                End If
            End If


        End Sub
        Sub clear1()
            si_id_txt.Text = Nothing
            si_stud_id_txt.Text = Nothing
            si_Lname_txt.Text = Nothing
            si_Fname_txt.Text = Nothing
            si_Mname_txt.Text = Nothing
            si_course_txt.Text = Nothing
            si_yr_txt.Text = Nothing
            si_semester_txt.Text = Nothing
            si_acadyear_txt.Text = Nothing
            si_contact_txt.Text = Nothing
            si_photo_path_txt.Text = Nothing
            PictureBox1.Image = Nothing

        End Sub

        Private Sub RegistrarUpdateExecuted(ByVal sender As Object, ByVal e As EventArgs)
      
                If si_id_txt.Text = Nothing _
                  Or si_stud_id_txt.Text = Nothing _
                  Or si_Lname_txt.Text = Nothing _
                  Or si_Fname_txt.Text = Nothing _
                  Or si_Mname_txt.Text = Nothing _
                  Or si_course_txt.Text = Nothing _
                  Or si_yr_txt.Text = Nothing _
                  Or si_semester_txt.Text = Nothing _
                  Or si_acadyear_txt.Text = Nothing _
                  Or si_contact_txt.Text = Nothing _
                  Or si_photo_path_txt.Text = Nothing Then
                    MsgBox("Fill-out all fields !", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Warning")

            Else
                rs = New ADODB.Recordset
                rs.Open("SELECT * FROM `tbl_registrar` WHERE `stud_id` ='" & si_stud_id_txt.Text & "' ", cn, 1, 2)
                Dim q As Integer
                q = 0
                While Not rs.EOF
                    rs.MoveNext()
                    q = q + 1
                End While

                rs = New ADODB.Recordset
                rs.Open("UPDATE `tbl_registrar` SET `stud_id` = '" & si_stud_id_txt.Text & "', `last_name` = '" & si_Lname_txt.Text & "', `first_name`= '" & si_Fname_txt.Text & "', `middle_name` =  '" & si_Mname_txt.Text & "', `current_course` =  '" & si_course_txt.Text & "', `year_level` = '" & si_yr_txt.Text & "', `semester` = '" & si_semester_txt.Text & "', `school_yr`=  '" & si_acadyear_txt.Text & "', `contact_num`='" & si_contact_txt.Text & "' , `path_image`= '" & si_photo_path_txt.Text & "' WHERE `ID` = " & si_id_txt.Text & " ", cn, 1, 2)
                rs = New ADODB.Recordset
                rs.Open("Update  tbl_library SET `stud_id` = '" & si_stud_id_txt.Text & "', `last_name` = '" & si_Lname_txt.Text & "', `first_name`= '" & si_Fname_txt.Text & "', `middle_name` =  '" & si_Mname_txt.Text & "', `current_course` =  '" & si_course_txt.Text & "', `year_level` = '" & si_yr_txt.Text & "', `semester` = '" & si_semester_txt.Text & "', `school_yr`=  '" & si_acadyear_txt.Text & "', `contact_num`='" & si_contact_txt.Text & "' , `path_image`= '" & si_photo_path_txt.Text & "'  WHERE `stud_id` = '" & prev_idLbl.Text & "' ", cn, 1, 2)
                rs = New ADODB.Recordset
                rs.Open("Update  tbl_business SET `stud_id` = '" & si_stud_id_txt.Text & "', `last_name` = '" & si_Lname_txt.Text & "', `first_name`= '" & si_Fname_txt.Text & "', `middle_name` =  '" & si_Mname_txt.Text & "', `current_course` =  '" & si_course_txt.Text & "', `year_level` = '" & si_yr_txt.Text & "', `semester` = '" & si_semester_txt.Text & "', `school_yr`=  '" & si_acadyear_txt.Text & "', `contact_num`='" & si_contact_txt.Text & "' , `path_image`= '" & si_photo_path_txt.Text & "'  WHERE `stud_id` = '" & prev_idLbl.Text & "' ", cn, 1, 2)
                rs = New ADODB.Recordset
                rs.Open("Update  tbl_guidance SET `stud_id` = '" & si_stud_id_txt.Text & "', `last_name` = '" & si_Lname_txt.Text & "', `first_name`= '" & si_Fname_txt.Text & "', `middle_name` =  '" & si_Mname_txt.Text & "', `current_course` =  '" & si_course_txt.Text & "', `year_level` = '" & si_yr_txt.Text & "', `semester` = '" & si_semester_txt.Text & "', `school_yr`=  '" & si_acadyear_txt.Text & "', `contact_num`='" & si_contact_txt.Text & "' , `path_image`= '" & si_photo_path_txt.Text & "'  WHERE `stud_id` = '" & prev_idLbl.Text & "' ", cn, 1, 2)
                rs = New ADODB.Recordset
                rs.Open("Update  tbl_bookstore SET `stud_id` = '" & si_stud_id_txt.Text & "', `last_name` = '" & si_Lname_txt.Text & "', `first_name`= '" & si_Fname_txt.Text & "', `middle_name` =  '" & si_Mname_txt.Text & "', `current_course` =  '" & si_course_txt.Text & "', `year_level` = '" & si_yr_txt.Text & "', `semester` = '" & si_semester_txt.Text & "', `school_yr`=  '" & si_acadyear_txt.Text & "', `contact_num`='" & si_contact_txt.Text & "' , `path_image`= '" & si_photo_path_txt.Text & "'  WHERE `stud_id` = '" & prev_idLbl.Text & "' ", cn, 1, 2)



                lbl_fullname.Text = si_Lname_txt.Text + ", " + si_Fname_txt.Text + " " + si_Mname_txt.Text


                rs = New ADODB.Recordset
                rs.Open("Update  tbl_grades SET  `stud_id` = '" & si_stud_id_txt.Text & "', `stud_name` = '" & lbl_fullname.Text & "', `current_course` =  '" & si_course_txt.Text & "', `year_level` = '" & si_yr_txt.Text & "', `semester` = '" & si_semester_txt.Text & "', `school_yr`=  '" & si_acadyear_txt.Text & "', `path_image`= '" & si_photo_path_txt.Text & "'  WHERE `stud_id` = '" & prev_idLbl.Text & "' ", cn, 1, 2)




                MsgBox("New Record Updated !", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "SUCCESS")
                loadregistrardata()
                loadlibrarydata()
                loadguidancedata()
                loadbusinessdata()
                loadgradesdata()
                loadbookstoredata()


                lbl_fullname.Text = Nothing
                prev_idLbl.Text = Nothing

                clear1()
            End If
            ' End If

        End Sub

#End Region

#Region "Business"
        Private _BusinessControl As BusinessControl = Nothing
        Private Sub BusinessExecuted(ByVal sender As Object, ByVal e As EventArgs)
            Debug.Assert(_BusinessControl Is Nothing)
            _Commands.BusinessCommands.Display.Enabled = False
            _BusinessControl = New BusinessControl()
            _BusinessControl.Commands = _Commands
            Me.ShowModalPanel(_BusinessControl, DevComponents.DotNetBar.Controls.eSlideSide.Left)
            If Not _StartControl.Visible Then
                _StartControl.SlideOutButtonVisible = False
            End If

            Try
                rs = New ADODB.Recordset
                rs.Open("SELECT * FROM tbl_business WHERE stud_id='" & _StartControl.lbl_stud_id.Text & "' AND semester='" & _StartControl.lbl_semester.Text & "' AND school_yr='" & _StartControl.lbl_acad_year.Text & "' ", cn, 1, 2)

                _BusinessControl.LabelX9.Text = rs.Fields("last_name").Value.ToString + ", " + rs.Fields("first_name").Value.ToString + " " + rs.Fields("middle_name").Value.ToString
                _BusinessControl.LabelX5.Text = rs.Fields("stud_id").Value.ToString
                _BusinessControl.LabelX10.Text = rs.Fields("current_course").Value.ToString
                _BusinessControl.LabelX11.Text = rs.Fields("year_level").Value.ToString
                _BusinessControl.LabelX12.Text = rs.Fields("semester").Value.ToString
                _BusinessControl.LabelX13.Text = rs.Fields("school_yr").Value.ToString
                _BusinessControl.ListViewEx1.Items.Clear()
            Catch ex As Exception

            End Try
        



            Do While Not rs.EOF
                Dim lv As ListViewItem
                lv = _BusinessControl.ListViewEx1.Items.Add(rs.Fields(0).Value)
                lv.SubItems.Add(rs.Fields(10).Value)
                lv.SubItems.Add(rs.Fields(11).Value)
                rs.MoveNext()
            Loop
        End Sub
        Private Sub BusinessDeleteExecuted(ByVal sender As Object, ByVal e As EventArgs)
            If _StartControl.LabelX20.Text <> "ADM-0000001" Then
                MsgBox("You don't have access to this command!", MsgBoxStyle.Critical, "SYSTEM")
            ElseIf b_id.Text = "" Then
                MsgBox("Please, Select from the list", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "WARNING")
            ElseIf MsgBox("Are you sure you want to delete this record?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "WARNING") = MsgBoxResult.Yes Then
                rs = New ADODB.Recordset
                rs.Open("DELETE FROM `tbl_business` WHERE `ID` = " & b_id.Text & " ", cn, 1, 2)
                loadbusinessdata()
                MsgBox("Delete Succesfully", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "SUCCESS")
                clear2()

            End If
        End Sub

        Private Sub BusinessSearchExecuted(ByVal sender As Object, ByVal e As EventArgs)
            searchBusinessTxt.Focus()
        End Sub

        '// Search Business Textbox
        Private Sub searchBusinessTxt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles searchBusinessTxt.TextChanged

            rs = New ADODB.Recordset
            rs.Open("SELECT * FROM  `tbl_business` WHERE `ID` like '%" & searchBusinessTxt.Text & "%' or `stud_id` like '%" & searchBusinessTxt.Text & "%' or `last_name` like '%" & searchBusinessTxt.Text & "%' or `first_name` like '%" & searchBusinessTxt.Text & "%' or `middle_name` like '%" & searchBusinessTxt.Text & "%' or `current_course` like '%" & searchBusinessTxt.Text & "%' or `year_level` like '%" & searchBusinessTxt.Text & "%' or `semester` like '%" & searchBusinessTxt.Text & "%' or `school_yr` like '%" & searchBusinessTxt.Text & "%' or `contact_num` like '%" & searchBusinessTxt.Text & "%' ", cn, 1, 2)
            ListViewEx2.Items.Clear()
            Do While Not rs.EOF
                Dim lv As ListViewItem
                lv = ListViewEx2.Items.Add(rs.Fields(0).Value)
                lv.SubItems.Add(rs.Fields(1).Value)
                lv.SubItems.Add(rs.Fields(2).Value)
                lv.SubItems.Add(rs.Fields(3).Value)
                lv.SubItems.Add(rs.Fields(4).Value)
                lv.SubItems.Add(rs.Fields(5).Value)
                lv.SubItems.Add(rs.Fields(6).Value)
                lv.SubItems.Add(rs.Fields(7).Value)
                lv.SubItems.Add(rs.Fields(8).Value)
                lv.SubItems.Add(rs.Fields(9).Value)
                lv.SubItems.Add(rs.Fields(10).Value)
                lv.SubItems.Add(rs.Fields(11).Value)
                lv.SubItems.Add(rs.Fields(12).Value)
                lv.SubItems.Add(rs.Fields(13).Value)
                rs.MoveNext()
            Loop
        End Sub
        Private Sub CancelBusinessExecuted(ByVal sender As Object, ByVal e As EventArgs)
            Debug.Assert(_BusinessControl IsNot Nothing)
            CloseBusinessDialog()
        End Sub
        Private Sub CloseBusinessDialog()
            If Not _StartControl.Visible Then
                _StartControl.SlideOutButtonVisible = True
            End If
            _Commands.BusinessCommands.Display.Enabled = True
            Me.CloseModalPanel(_BusinessControl, DevComponents.DotNetBar.Controls.eSlideSide.Left)
            _BusinessControl.Commands = Nothing
            _BusinessControl.Dispose()
            _BusinessControl = Nothing
        End Sub

        Private Sub BusinessAddExecuted(ByVal sender As Object, ByVal e As EventArgs)
            If b_studid.Text = Nothing _
                Or b_lastname.Text = Nothing _
                Or b_firstname.Text = Nothing _
                Or b_middlename.Text = Nothing _
                Or b_course.Text = Nothing _
                Or b_yearlvl.Text = Nothing _
                Or b_semester.Text = Nothing _
                Or b_acadyear.Text = Nothing _
                Or b_description.Text = Nothing _
                Or b_rembalance.Text = Nothing _
                Or b_status.Text = Nothing _
                Or b_contact.Text = Nothing Then
                MsgBox("Fill-out all fields !", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Warning")
            Else

                rs = New ADODB.Recordset
                rs.Open("SELECT * FROM `tbl_business` WHERE `stud_id` ='" & b_studid.Text & "' ", cn, 1, 2)
                Dim q As Integer
                q = 0
                While Not rs.EOF
                    rs.MoveNext()
                    q = q + 1
                End While
                If q = 1 Then
                    MsgBox("The student number is already taken", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "FAILED")
                    b_studid.Select()
                    Exit Sub
                Else

                    rs = New ADODB.Recordset
                    rs.Open("INSERT INTO `tbl_business` ( `stud_id`, `last_name`, `first_name`, `middle_name` , `current_course`, `year_level`, `semester`, `school_yr`, `contact_num`, `path_image`,`description`, `remaining_balance`,`status`) VALUES ( '" & b_studid.Text & "', '" & b_lastname.Text & "', '" & b_firstname.Text & "', '" & b_middlename.Text & "', '" & b_course.Text & "', '" & b_yearlvl.Text & "', '" & b_semester.Text & "' , '" & b_acadyear.Text & "', '" & b_contact.Text & "', '" & b_directorypath.Text & "','" & b_description.Text & "','" & b_rembalance.Text & "','" & b_status.Text & "')", cn, 1, 2)

                    MsgBox("New Record Added !", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "SUCCESS")

                    loadregistrardata()
                    loadlibrarydata()
                    loadguidancedata()
                    loadbusinessdata()
                    loadgradesdata()

                    clear2()

                End If
            End If


        End Sub
        Sub clear2()
            b_id.Text = Nothing
            b_studid.Text = Nothing
            b_lastname.Text = Nothing
            b_firstname.Text = Nothing
            b_middlename.Text = Nothing
            b_course.Text = Nothing
            b_yearlvl.Text = Nothing
            b_semester.Text = Nothing
            b_acadyear.Text = Nothing
            b_contact.Text = Nothing
            b_directorypath.Text = Nothing
            PictureBox2.Image = Nothing
            b_description.Text = Nothing
            b_rembalance.Text = Nothing
            b_status.Text = Nothing
        End Sub

        Private Sub BusinessUpdateExecuted(ByVal sender As Object, ByVal e As EventArgs)
            If b_id.Text = Nothing _
              Or b_studid.Text = Nothing _
              Or b_lastname.Text = Nothing _
              Or b_firstname.Text = Nothing _
              Or b_middlename.Text = Nothing _
              Or b_course.Text = Nothing _
              Or b_yearlvl.Text = Nothing _
              Or b_semester.Text = Nothing _
              Or b_acadyear.Text = Nothing _
              Or b_contact.Text = Nothing _
              Or b_directorypath.Text = Nothing Then
                MsgBox("Fill-out all fields !", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Warning")
            Else
             
                    rs = New ADODB.Recordset
                    rs.Open("Update  tbl_business SET `stud_id` = '" & b_studid.Text & "', `last_name` = '" & b_lastname.Text & "', `first_name`= '" & b_firstname.Text & "', `middle_name` =  '" & b_middlename.Text & "', `current_course` =  '" & b_course.Text & "', `year_level` = '" & b_yearlvl.Text & "', `semester` = '" & b_semester.Text & "', `school_yr`=  '" & b_acadyear.Text & "', `contact_num`='" & b_contact.Text & "' , `path_image`= '" & b_directorypath.Text & "' , `description`= '" & b_description.Text & "' , `remaining_balance`= '" & b_rembalance.Text & "' , `status`= '" & b_status.Text & "' WHERE `ID` = " & b_id.Text & " ", cn, 1, 2)



                b_fullname.Text = b_lastname.Text + ", " + b_firstname.Text + " " + b_middlename.Text

                rs = New ADODB.Recordset
                rs.Open("Update  tbl_grades SET  `stud_id` = '" & b_studid.Text & "', `stud_name` = '" & b_fullname.Text & "', `current_course` =  '" & b_course.Text & "', `year_level` = '" & b_yearlvl.Text & "', `semester` = '" & b_semester.Text & "', `school_yr`=  '" & b_acadyear.Text & "', `path_image`= '" & b_directorypath.Text & "'  WHERE `stud_id` = '" & business_prev_id.Text & "' ", cn, 1, 2)





                    MsgBox("New Record Updated !", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "SUCCESS")
                    loadregistrardata()
                    loadlibrarydata()
                    loadguidancedata()
                    loadbusinessdata()
                    loadgradesdata()

                    b_fullname.Text = Nothing
                    'prev_idLbl.Text = Nothing

                    clear2()
                End If

        End Sub

#End Region

#Region "Guidance"
        Private _GuidanceControl As GuidanceControl = Nothing
        Private Sub GuidanceExecuted(ByVal sender As Object, ByVal e As EventArgs)
            Debug.Assert(_GuidanceControl Is Nothing)
            _Commands.GuidanceCommands.Display.Enabled = False
            _GuidanceControl = New GuidanceControl()
            _GuidanceControl.Commands = _Commands
            Me.ShowModalPanel(_GuidanceControl, DevComponents.DotNetBar.Controls.eSlideSide.Left)
            If Not _StartControl.Visible Then
                _StartControl.SlideOutButtonVisible = False
            End If

            Try
                rs = New ADODB.Recordset
                rs.Open("SELECT * FROM tbl_guidance WHERE stud_id='" & _StartControl.lbl_stud_id.Text & "' AND semester='" & _StartControl.lbl_semester.Text & "' AND school_yr='" & _StartControl.lbl_acad_year.Text & "' ", cn, 1, 2)

                _GuidanceControl.LabelX9.Text = rs.Fields("last_name").Value.ToString + ", " + rs.Fields("first_name").Value.ToString + " " + rs.Fields("middle_name").Value.ToString
                _GuidanceControl.LabelX5.Text = rs.Fields("stud_id").Value.ToString
                _GuidanceControl.LabelX10.Text = rs.Fields("current_course").Value.ToString
                _GuidanceControl.LabelX11.Text = rs.Fields("year_level").Value.ToString
                _GuidanceControl.LabelX12.Text = rs.Fields("semester").Value.ToString
                _GuidanceControl.LabelX13.Text = rs.Fields("school_yr").Value.ToString
                _GuidanceControl.ListViewEx1.Items.Clear()

            Catch ex As Exception

            End Try

         
            Do While Not rs.EOF
                Dim lv As ListViewItem
                lv = _GuidanceControl.ListViewEx1.Items.Add(rs.Fields(0).Value)
                lv.SubItems.Add(rs.Fields(10).Value)
                rs.MoveNext()
            Loop
        End Sub
        Private Sub GuidanceSearchExecuted(ByVal sender As Object, ByVal e As EventArgs)
            searchGuidanceTxt.Focus()
        End Sub
        Private Sub GuidanceDeleteExecuted(ByVal sender As Object, ByVal e As EventArgs)
            If _StartControl.LabelX20.Text <> "ADM-0000001" Then
                MsgBox("You don't have access to this command!", MsgBoxStyle.Critical, "SYSTEM")
            ElseIf g_id.Text = "" Then
                MsgBox("Please, Select from the list", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "WARNING")
            ElseIf MsgBox("Are you sure you want to delete this record?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "WARNING") = MsgBoxResult.Yes Then
                rs = New ADODB.Recordset
                rs.Open("DELETE FROM `tbl_guidance` WHERE `ID` = " & LabelX4.Text & " ", cn, 1, 2)
                loadguidancedata()
                MsgBox("Delete Succesfully", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "SUCCESS")
                clear3()

            End If
        End Sub

        Private Sub CancelGuidanceExecuted(ByVal sender As Object, ByVal e As EventArgs)
            Debug.Assert(_GuidanceControl IsNot Nothing)
            CloseGuidanceDialog()
        End Sub
        Private Sub CloseGuidanceDialog()
            If Not _StartControl.Visible Then
                _StartControl.SlideOutButtonVisible = True
            End If
            _Commands.GuidanceCommands.Display.Enabled = True
            Me.CloseModalPanel(_GuidanceControl, DevComponents.DotNetBar.Controls.eSlideSide.Left)
            _GuidanceControl.Commands = Nothing
            _GuidanceControl.Dispose()
            _GuidanceControl = Nothing
        End Sub

        Private Sub GuidanceAddExecuted(ByVal sender As Object, ByVal e As EventArgs)
            If g_id.Text = Nothing _
                Or g_studid.Text = Nothing _
                Or g_lastname.Text = Nothing _
                Or g_firstname.Text = Nothing _
                Or g_middlename.Text = Nothing _
                Or g_course.Text = Nothing _
                Or g_yearlevel.Text = Nothing _
                Or g_semester.Text = Nothing _
                Or g_acadyear.Text = Nothing _
                Or g_uncollectedTxt.Text = Nothing _
                Or g_status.Text = Nothing _
                Or g_contact.Text = Nothing Then
                MsgBox("Fill-out all fields !", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Warning")
            Else

                rs = New ADODB.Recordset
                rs.Open("SELECT * FROM `tbl_guidance` WHERE `stud_id` ='" & g_studid.Text & "' ", cn, 1, 2)
                Dim q As Integer
                q = 0
                While Not rs.EOF
                    rs.MoveNext()
                    q = q + 1
                End While
                If q = 1 Then
                    MsgBox("The student number is already taken", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "FAILED")
                    g_studid.Text = ""
                    g_studid.Select()
                    Exit Sub
                Else

                    rs = New ADODB.Recordset
                    rs.Open("INSERT INTO `tbl_guidance` ( `stud_id`, `last_name`, `first_name`, `middle_name` , `current_course`, `year_level`, `semester`, `school_yr`, `contact_num`, `path_image`,`uncollected_requirements`, `status`) VALUES ( '" & g_studid.Text & "', '" & g_lastname.Text & "', '" & g_firstname.Text & "', '" & g_middlename.Text & "', '" & g_course.Text & "', '" & g_yearlevel.Text & "', '" & g_semester.Text & "' , '" & g_acadyear.Text & "', '" & g_contact.Text & "', '" & g_directorypath.Text & "','" & g_uncollectedTxt.Text & "' ,'" & g_status.Text & "')", cn, 1, 2)

                    MsgBox("New Record Added !", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "SUCCESS")

                    loadregistrardata()
                    loadlibrarydata()
                    loadguidancedata()
                    loadbusinessdata()
                    loadgradesdata()

                    clear3()

                End If
            End If


        End Sub
        Sub clear3()
            g_id.Text = Nothing
            g_studid.Text = Nothing
            g_lastname.Text = Nothing
            g_firstname.Text = Nothing
            g_middlename.Text = Nothing
            g_course.Text = Nothing
            g_yearlevel.Text = Nothing
            g_semester.Text = Nothing
            g_acadyear.Text = Nothing
            g_contact.Text = Nothing
            g_directorypath.Text = Nothing
            PictureBox4.Image = Nothing
            g_uncollectedTxt.Text = Nothing
            g_status.Text = Nothing
        End Sub

        Private Sub GuidanceUpdateExecuted(ByVal sender As Object, ByVal e As EventArgs)
            If g_id.Text = Nothing _
              Or g_studid.Text = Nothing _
              Or g_lastname.Text = Nothing _
              Or g_firstname.Text = Nothing _
              Or g_middlename.Text = Nothing _
              Or g_course.Text = Nothing _
              Or g_yearlevel.Text = Nothing _
              Or g_semester.Text = Nothing _
              Or g_acadyear.Text = Nothing _
              Or g_contact.Text = Nothing _
              Or g_uncollectedTxt.Text = Nothing _
              Or g_status.Text = Nothing _
              Or g_directorypath.Text = Nothing Then
                MsgBox("Fill-out all fields !", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Warning")
            Else
                rs = New ADODB.Recordset
                rs.Open("Update  tbl_guidance SET `stud_id` = '" & g_studid.Text & "', `last_name` = '" & g_lastname.Text & "', `first_name`= '" & g_firstname.Text & "', `middle_name` =  '" & g_middlename.Text & "', `current_course` =  '" & g_course.Text & "', `year_level` = '" & g_yearlevel.Text & "', `semester` = '" & g_semester.Text & "', `school_yr`=  '" & g_acadyear.Text & "', `contact_num`='" & g_contact.Text & "' , `path_image`= '" & g_directorypath.Text & "'  , `uncollected_requirements`= '" & g_uncollectedTxt.Text & "' , `status`= '" & g_status.Text & "' WHERE `ID` = " & g_id.Text & " ", cn, 1, 2)

                g_fullname.Text = g_lastname.Text + ", " + g_firstname.Text + " " + g_middlename.Text

                MsgBox("New Record Updated !", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "SUCCESS")
                loadregistrardata()
                loadlibrarydata()
                loadguidancedata()
                loadbusinessdata()
                loadgradesdata()

                g_fullname.Text = Nothing
                'prev_idLbl.Text = Nothing

                clear3()
            End If

        End Sub

        '// Search Guidance Textbox
        Private Sub searchGuidanceTxt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles searchGuidanceTxt.TextChanged

            rs = New ADODB.Recordset
            rs.Open("SELECT * FROM  `tbl_guidance` WHERE `ID` like '%" & searchGuidanceTxt.Text & "%' or `stud_id` like '%" & searchGuidanceTxt.Text & "%' or `last_name` like '%" & searchGuidanceTxt.Text & "%' or `first_name` like '%" & searchGuidanceTxt.Text & "%' or `middle_name` like '%" & searchGuidanceTxt.Text & "%' or `current_course` like '%" & searchGuidanceTxt.Text & "%' or `year_level` like '%" & searchGuidanceTxt.Text & "%' or `semester` like '%" & searchGuidanceTxt.Text & "%' or `school_yr` like '%" & searchGuidanceTxt.Text & "%' or `contact_num` like '%" & searchGuidanceTxt.Text & "%' ", cn, 1, 2)
            ListViewEx3.Items.Clear()
            Do While Not rs.EOF
                Dim lv As ListViewItem
                lv = ListViewEx3.Items.Add(rs.Fields(0).Value)
                lv.SubItems.Add(rs.Fields(1).Value)
                lv.SubItems.Add(rs.Fields(2).Value)
                lv.SubItems.Add(rs.Fields(3).Value)
                lv.SubItems.Add(rs.Fields(4).Value)
                lv.SubItems.Add(rs.Fields(5).Value)
                lv.SubItems.Add(rs.Fields(6).Value)
                lv.SubItems.Add(rs.Fields(7).Value)
                lv.SubItems.Add(rs.Fields(8).Value)
                lv.SubItems.Add(rs.Fields(9).Value)
                lv.SubItems.Add(rs.Fields(10).Value)
                lv.SubItems.Add(rs.Fields(11).Value)
                lv.SubItems.Add(rs.Fields(12).Value)
                rs.MoveNext()
            Loop
        End Sub
#End Region

#Region "Library"
        Private _LibraryControl As LibraryControl = Nothing
        Private Sub LibraryExecuted(ByVal sender As Object, ByVal e As EventArgs)
            Debug.Assert(_LibraryControl Is Nothing)
            _Commands.LibraryCommands.Display.Enabled = False
            _LibraryControl = New LibraryControl()
            _LibraryControl.Commands = _Commands
            Me.ShowModalPanel(_LibraryControl, DevComponents.DotNetBar.Controls.eSlideSide.Left)
            If Not _StartControl.Visible Then
                _StartControl.SlideOutButtonVisible = False
            End If
            Try
                rs = New ADODB.Recordset
                rs.Open("SELECT * FROM tbl_library WHERE stud_id='" & _StartControl.lbl_stud_id.Text & "' AND semester='" & _StartControl.lbl_semester.Text & "' AND school_yr='" & _StartControl.lbl_acad_year.Text & "' ", cn, 1, 2)
                _LibraryControl.LabelX9.Text = rs.Fields("last_name").Value.ToString + ", " + rs.Fields("first_name").Value.ToString + " " + rs.Fields("middle_name").Value.ToString
                _LibraryControl.LabelX5.Text = rs.Fields("stud_id").Value.ToString
                _LibraryControl.LabelX10.Text = rs.Fields("current_course").Value.ToString
                _LibraryControl.LabelX11.Text = rs.Fields("year_level").Value.ToString
                _LibraryControl.LabelX12.Text = rs.Fields("semester").Value.ToString
                _LibraryControl.LabelX13.Text = rs.Fields("school_yr").Value.ToString
                _LibraryControl.ListViewEx1.Items.Clear()
            Catch ex As Exception

            End Try


            Do While Not rs.EOF
                Dim lv As ListViewItem
                lv = _LibraryControl.ListViewEx1.Items.Add(rs.Fields(0).Value)
                lv.SubItems.Add(rs.Fields(10).Value)
                lv.SubItems.Add(rs.Fields(11).Value)
                rs.MoveNext()
            Loop
        End Sub
        Private Sub LibrarySearchExecuted(ByVal sender As Object, ByVal e As EventArgs)
            searchLibraryTxt.Focus()
        End Sub

        Private Sub LibraryDeleteExecuted(ByVal sender As Object, ByVal e As EventArgs)
            If _StartControl.LabelX20.Text <> "ADM-0000001" Then
                MsgBox("You don't have access to this command!", MsgBoxStyle.Critical, "SYSTEM")
            ElseIf l_id.Text = "" Then
                MsgBox("Please, Select from the list", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "WARNING")
            ElseIf MsgBox("Are you sure you want to delete this record?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "WARNING") = MsgBoxResult.Yes Then
                rs = New ADODB.Recordset
                rs.Open("DELETE FROM `tbl_library` WHERE `ID` = " & LabelX3.Text & " ", cn, 1, 2)
                loadlibrarydata()
                MsgBox("Delete Succesfully", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "SUCCESS")
                clear4()

            End If
        End Sub

        Private Sub CancelLibraryExecuted(ByVal sender As Object, ByVal e As EventArgs)
            Debug.Assert(_LibraryControl IsNot Nothing)
            CloseLibraryDialog()
        End Sub
        Private Sub CloseLibraryDialog()
            If Not _StartControl.Visible Then
                _StartControl.SlideOutButtonVisible = True
            End If
            _Commands.LibraryCommands.Display.Enabled = True
            Me.CloseModalPanel(_LibraryControl, DevComponents.DotNetBar.Controls.eSlideSide.Left)
            _LibraryControl.Commands = Nothing
            _LibraryControl.Dispose()
            _LibraryControl = Nothing
        End Sub

        Private Sub LibraryAddExecuted(ByVal sender As Object, ByVal e As EventArgs)
            If l_id.Text = Nothing _
                Or l_studid.Text = Nothing _
                Or l_lastname.Text = Nothing _
                Or l_fistname.Text = Nothing _
                Or l_middlename.Text = Nothing _
                Or l_course.Text = Nothing _
                Or l_yearlevel.Text = Nothing _
                Or l_semester.Text = Nothing _
                Or l_acadyear.Text = Nothing _
                Or l_unretbook.Text = Nothing _
                Or l_remainingBal.Text = Nothing _
                Or l_status.Text = Nothing _
                Or l_contact.Text = Nothing Then
                MsgBox("Fill-out all fields !", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Warning")
            Else

                rs = New ADODB.Recordset
                rs.Open("SELECT * FROM `tbl_library` WHERE `stud_id` ='" & l_studid.Text & "' ", cn, 1, 2)
                Dim q As Integer
                q = 0
                While Not rs.EOF
                    rs.MoveNext()
                    q = q + 1
                End While
                If q = 1 Then
                    MsgBox("The student number is already taken", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "FAILED")
                    l_studid.Select()
                    Exit Sub
                Else

                    rs = New ADODB.Recordset
                    rs.Open("INSERT INTO `tbl_library` ( `stud_id`, `last_name`, `first_name`, `middle_name` , `current_course`, `year_level`, `semester`, `school_yr`, `contact_num`, `path_image`,`unreturned_book`,`remaining_penalty`, `status`) VALUES ( '" & l_studid.Text & "', '" & l_lastname.Text & "', '" & l_fistname.Text & "', '" & l_middlename.Text & "', '" & l_course.Text & "', '" & l_yearlevel.Text & "', '" & l_semester.Text & "' , '" & l_acadyear.Text & "', '" & l_contact.Text & "', '" & l_directorypath.Text & "','" & l_unretbook.Text & "' ,'" & l_remainingBal.Text & "' ,'" & l_status.Text & "')", cn, 1, 2)

                    MsgBox("New Record Added !", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "SUCCESS")

                    loadregistrardata()
                    loadlibrarydata()
                    loadguidancedata()
                    loadbusinessdata()
                    loadgradesdata()

                    clear4()

                End If
            End If


        End Sub
        Sub clear4()
            l_id.Text = Nothing
            l_studid.Text = Nothing
            l_lastname.Text = Nothing
            l_fistname.Text = Nothing
            l_middlename.Text = Nothing
            l_course.Text = Nothing
            l_yearlevel.Text = Nothing
            l_semester.Text = Nothing
            l_acadyear.Text = Nothing
            l_contact.Text = Nothing
            l_directorypath.Text = Nothing
            PictureBox3.Image = Nothing
            l_unretbook.Text = Nothing
            l_remainingBal.Text = Nothing
            l_status.Text = Nothing
        End Sub

        Private Sub LibraryUpdateExecuted(ByVal sender As Object, ByVal e As EventArgs)
            If l_id.Text = Nothing _
              Or l_studid.Text = Nothing _
              Or l_lastname.Text = Nothing _
              Or l_fistname.Text = Nothing _
              Or l_middlename.Text = Nothing _
              Or l_course.Text = Nothing _
              Or l_yearlevel.Text = Nothing _
              Or l_semester.Text = Nothing _
              Or l_acadyear.Text = Nothing _
              Or l_contact.Text = Nothing _
              Or l_unretbook.Text = Nothing _
              Or l_remainingBal.Text = Nothing _
              Or l_status.Text = Nothing _
              Or l_directorypath.Text = Nothing Then
                MsgBox("Fill-out all fields !", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Warning")
            Else
                rs = New ADODB.Recordset
                rs.Open("Update  tbl_library SET `stud_id` = '" & l_studid.Text & "', `last_name` = '" & l_lastname.Text & "', `first_name`= '" & l_fistname.Text & "', `middle_name` =  '" & l_middlename.Text & "', `current_course` =  '" & l_course.Text & "', `year_level` = '" & l_yearlevel.Text & "', `semester` = '" & l_semester.Text & "', `school_yr`=  '" & l_acadyear.Text & "', `contact_num`='" & l_contact.Text & "' , `path_image`= '" & l_directorypath.Text & "' , `unreturned_book`= '" & l_unretbook.Text & "' , `remaining_penalty`= '" & l_remainingBal.Text & "' , `status`= '" & l_status.Text & "'  WHERE `ID` = " & l_id.Text & " ", cn, 1, 2)

                l_fullname.Text = l_lastname.Text + ", " + l_fistname.Text + " " + l_middlename.Text

                MsgBox("New Record Updated !", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "SUCCESS")
                loadregistrardata()
                loadlibrarydata()
                loadguidancedata()
                loadbusinessdata()
                loadgradesdata()

                l_fullname.Text = Nothing
                'prev_idLbl.Text = Nothing

                clear4()
            End If

        End Sub


        '// Search Library Textbox
        Private Sub searchLibraryTxt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles searchLibraryTxt.TextChanged

            rs = New ADODB.Recordset
            rs.Open("SELECT * FROM  `tbl_library` WHERE `ID` like '%" & searchLibraryTxt.Text & "%' or `stud_id` like '%" & searchLibraryTxt.Text & "%' or `last_name` like '%" & searchLibraryTxt.Text & "%' or `first_name` like '%" & searchLibraryTxt.Text & "%' or `middle_name` like '%" & searchLibraryTxt.Text & "%' or `current_course` like '%" & searchLibraryTxt.Text & "%' or `year_level` like '%" & searchLibraryTxt.Text & "%' or `semester` like '%" & searchLibraryTxt.Text & "%' or `school_yr` like '%" & searchLibraryTxt.Text & "%' or `contact_num` like '%" & searchLibraryTxt.Text & "%' ", cn, 1, 2)
            ListViewEx4.Items.Clear()
            Do While Not rs.EOF
                Dim lv As ListViewItem
                lv = ListViewEx4.Items.Add(rs.Fields(0).Value)
                lv.SubItems.Add(rs.Fields(1).Value)
                lv.SubItems.Add(rs.Fields(2).Value)
                lv.SubItems.Add(rs.Fields(3).Value)
                lv.SubItems.Add(rs.Fields(4).Value)
                lv.SubItems.Add(rs.Fields(5).Value)
                lv.SubItems.Add(rs.Fields(6).Value)
                lv.SubItems.Add(rs.Fields(7).Value)
                lv.SubItems.Add(rs.Fields(8).Value)
                lv.SubItems.Add(rs.Fields(9).Value)
                lv.SubItems.Add(rs.Fields(10).Value)
                lv.SubItems.Add(rs.Fields(11).Value)
                lv.SubItems.Add(rs.Fields(12).Value)
                lv.SubItems.Add(rs.Fields(13).Value)
                rs.MoveNext()
            Loop
        End Sub

#End Region

#Region "Instructor"
        Private _InstructorControl As InstructorControl = Nothing
        Private Sub InstructorExecuted(ByVal sender As Object, ByVal e As EventArgs)
            Debug.Assert(_InstructorControl Is Nothing)
            _Commands.InstructorCommands.Display.Enabled = False
            _InstructorControl = New InstructorControl()
            _InstructorControl.Commands = _Commands
            Me.ShowModalPanel(_InstructorControl, DevComponents.DotNetBar.Controls.eSlideSide.Left)
            If Not _StartControl.Visible Then
                _StartControl.SlideOutButtonVisible = False
            End If

            Try
                rs = New ADODB.Recordset
                rs.Open("SELECT * FROM tbl_grades WHERE stud_id='" & _StartControl.lbl_stud_id.Text & "' AND semester='" & _StartControl.lbl_semester.Text & "' AND school_yr='" & _StartControl.lbl_acad_year.Text & "' ", cn, 1, 2)

                _InstructorControl.LabelX9.Text = rs.Fields("stud_name").Value.ToString
                _InstructorControl.LabelX5.Text = rs.Fields("stud_id").Value.ToString
                _InstructorControl.LabelX10.Text = rs.Fields("current_course").Value.ToString
                _InstructorControl.LabelX11.Text = rs.Fields("year_level").Value.ToString
                _InstructorControl.LabelX12.Text = rs.Fields("semester").Value.ToString
                _InstructorControl.LabelX13.Text = rs.Fields("school_yr").Value.ToString
                _InstructorControl.ListViewEx1.Items.Clear()
            Catch ex As Exception

            End Try


            Do While Not rs.EOF
                Dim lv As ListViewItem
                lv = _InstructorControl.ListViewEx1.Items.Add(rs.Fields(0).Value)
                lv.SubItems.Add(rs.Fields(5).Value)
                lv.SubItems.Add(rs.Fields(6).Value)
                lv.SubItems.Add(rs.Fields(13).Value)
                lv.SubItems.Add(rs.Fields(2).Value + ", " + rs.Fields(3).Value + " " + rs.Fields(4).Value)
                lv.SubItems.Add(rs.Fields(14).Value)
                rs.MoveNext()
            Loop
        End Sub
        Private Sub InstructorDeleteExecuted(ByVal sender As Object, ByVal e As EventArgs)
            If _StartControl.LabelX20.Text <> "ADM-0000001" Then
                MsgBox("You don't have access to this command!", MsgBoxStyle.Critical, "SYSTEM")
            ElseIf i_id.Text = "" Then
                MsgBox("Please, Select from the list", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "WARNING")
            ElseIf MsgBox("Are you sure you want to delete this record?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "WARNING") = MsgBoxResult.Yes Then
                rs = New ADODB.Recordset
                rs.Open("DELETE FROM `tbl_instructor` WHERE `ID` = " & i_id.Text & " ", cn, 1, 2)
                loadinstructordata()
                MsgBox("Delete Succesfully", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "SUCCESS")
                clear5()

            End If
        End Sub
        Private Sub InstructorSearchExecuted(ByVal sender As Object, ByVal e As EventArgs)
            searchInstructorTxt.Focus()
        End Sub

        Private Sub CancelInstructorExecuted(ByVal sender As Object, ByVal e As EventArgs)
            Debug.Assert(_InstructorControl IsNot Nothing)
            CloseInstructorDialog()
        End Sub
        Private Sub CloseInstructorDialog()
            If Not _StartControl.Visible Then
                _StartControl.SlideOutButtonVisible = True
            End If
            _Commands.InstructorCommands.Display.Enabled = True
            Me.CloseModalPanel(_InstructorControl, DevComponents.DotNetBar.Controls.eSlideSide.Left)
            _InstructorControl.Commands = Nothing
            _InstructorControl.Dispose()
            _InstructorControl = Nothing
        End Sub

        Private Sub InstructorAddExecuted(ByVal sender As Object, ByVal e As EventArgs)
            If i_id.Text = Nothing _
                Or i_empid.Text = Nothing _
                Or i_lastname.Text = Nothing _
                Or i_firstname.Text = Nothing _
                Or i_middlename.Text = Nothing _
                Or i_subjectcode.Text = Nothing _
                Or i_subjdesc.Text = Nothing _
                Or i_units.Text = Nothing _
                Or i_yearlevel.Text = Nothing _
                Or i_semester.Text = Nothing _
                Or i_acadyear.Text = Nothing Then
                MsgBox("Fill-out all fields !", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Warning")
            Else

                rs = New ADODB.Recordset
                rs.Open("SELECT * FROM `tbl_instructor` WHERE `emp_id` ='" & i_empid.Text & "' ", cn, 1, 2)
                Dim q As Integer
                q = 0
                While Not rs.EOF
                    rs.MoveNext()
                    q = q + 1
                End While
                If q = 1 Then
                    MsgBox("The employee number is already taken", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "FAILED")
                    i_empid.Select()
                    Exit Sub
                Else

                    rs = New ADODB.Recordset
                    rs.Open("INSERT INTO `tbl_instructor` ( `emp_id`, `last_name`, `first_name`, `middle_name` , `subject_code`, `subject_description`,  `units`, `school_yr`, `semester`, `year_level` , `path_image`) VALUES ( '" & i_empid.Text & "', '" & i_lastname.Text & "', '" & i_firstname.Text & "', '" & i_middlename.Text & "', '" & i_subjectcode.Text & "' , '" & i_subjdesc.Text & "',  '" & i_units.Text & "' , '" & i_acadyear.Text & "', '" & i_semester.Text & "' , '" & i_yearlevel.Text & "',  '" & i_directorypath.Text & "')", cn, 1, 2)

                    MsgBox("New Record Added !", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "SUCCESS")

                    loadregistrardata()
                    loadlibrarydata()
                    loadguidancedata()
                    loadbusinessdata()
                    loadgradesdata()
                    loadinstructordata()

                    clear5()

                End If
            End If


        End Sub
        Sub clear5()
            i_id.Text = Nothing
            i_empid.Text = Nothing
            i_lastname.Text = Nothing
            i_firstname.Text = Nothing
            i_middlename.Text = Nothing
            i_subjectcode.Text = Nothing
            i_subjdesc.Text = Nothing
            i_units.Text = Nothing
            i_yearlevel.Text = Nothing
            i_semester.Text = Nothing
            i_acadyear.Text = Nothing
            i_directorypath.Text = Nothing
            PictureBox5.Image = Nothing
        End Sub

        Private Sub InstructorUpdateExecuted(ByVal sender As Object, ByVal e As EventArgs)
            If i_id.Text = Nothing _
              Or i_empid.Text = Nothing _
              Or i_lastname.Text = Nothing _
              Or i_firstname.Text = Nothing _
              Or i_middlename.Text = Nothing _
              Or i_subjdesc.Text = Nothing _
              Or i_subjectcode.Text = Nothing _
              Or i_units.Text = Nothing _
              Or i_yearlevel.Text = Nothing _
              Or i_semester.Text = Nothing _
              Or i_acadyear.Text = Nothing _
              Or i_directorypath.Text = Nothing Then
                MsgBox("Fill-out all fields !", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Warning")
            Else
                rs = New ADODB.Recordset
                rs.Open("Update  tbl_instructor SET `emp_id` = '" & i_empid.Text & "', `last_name` = '" & i_lastname.Text & "', `first_name`= '" & i_firstname.Text & "', `middle_name` =  '" & i_middlename.Text & "', `subject_code` =  '" & i_subjectcode.Text & "', `subject_description` =  '" & i_subjdesc.Text & "', `units` =  '" & i_units.Text & "', `year_level` = '" & i_yearlevel.Text & "', `semester` = '" & i_semester.Text & "', `school_yr`=  '" & i_acadyear.Text & "' , `path_image`= '" & i_directorypath.Text & "' WHERE `ID` = " & i_id.Text & " ", cn, 1, 2)

                i_id.Text = i_lastname.Text + ", " + i_firstname.Text + " " + i_middlename.Text

                MsgBox("New Record Updated !", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "SUCCESS")
                loadregistrardata()
                loadlibrarydata()
                loadguidancedata()
                loadbusinessdata()
                loadgradesdata()
                loadinstructordata()

                i_id.Text = Nothing
                'prev_idLbl.Text = Nothing

                clear5()
            End If

        End Sub



        '// Search Intructor Textbox
        Private Sub searchInstructorTxt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles searchInstructorTxt.TextChanged

            rs = New ADODB.Recordset
            rs.Open("SELECT * FROM  `tbl_instructor` WHERE `ID` like '%" & searchInstructorTxt.Text & "%' or `emp_id` like '%" & searchInstructorTxt.Text & "%' or `last_name` like '%" & searchInstructorTxt.Text & "%' or `first_name` like '%" & searchInstructorTxt.Text & "%' or `middle_name` like '%" & searchInstructorTxt.Text & "%' or `subject_code` like '%" & searchInstructorTxt.Text & "%' or `subject_description` like '%" & searchInstructorTxt.Text & "%' or `units` like '%" & searchInstructorTxt.Text & "%' or `school_yr` like '%" & searchInstructorTxt.Text & "%' or `semester` like '%" & searchInstructorTxt.Text & "%'  or `year_level` like '%" & searchInstructorTxt.Text & "%' ", cn, 1, 2)
            ListViewEx5.Items.Clear()
            Do While Not rs.EOF
                Dim lv As ListViewItem
                lv = ListViewEx5.Items.Add(rs.Fields(0).Value)
                lv.SubItems.Add(rs.Fields(1).Value)
                lv.SubItems.Add(rs.Fields(2).Value)
                lv.SubItems.Add(rs.Fields(3).Value)
                lv.SubItems.Add(rs.Fields(4).Value)
                lv.SubItems.Add(rs.Fields(5).Value)
                lv.SubItems.Add(rs.Fields(6).Value)
                lv.SubItems.Add(rs.Fields(7).Value)
                lv.SubItems.Add(rs.Fields(8).Value)
                lv.SubItems.Add(rs.Fields(9).Value)
                lv.SubItems.Add(rs.Fields(10).Value)
                lv.SubItems.Add(rs.Fields(11).Value.ToString)
                rs.MoveNext()
            Loop
        End Sub

#End Region
#Region "Search"
        Private _SearchControl As SearchControl = Nothing
        Private Sub SearchStudentExecuted(ByVal sender As Object, ByVal e As EventArgs)
            Debug.Assert(_SearchControl Is Nothing)
            _Commands.SearchCommands.Find.Enabled = False
            _SearchControl = New SearchControl()
            _SearchControl.Commands = _Commands
            Me.ShowModalPanel(_SearchControl, DevComponents.DotNetBar.Controls.eSlideSide.Left)
            If Not _StartControl.Visible Then
                _StartControl.SlideOutButtonVisible = False
            End If
            ' _StartControl.BackgroundWorker1.RunWorkerAsync()
            AddHandler _SearchControl.stud_idText.KeyDown, AddressOf studidText_Keydown
            _SearchControl.stud_idText.Select()
        End Sub
        Private Sub CancelSearchExecuted(ByVal sender As Object, ByVal e As EventArgs)
            Debug.Assert(_SearchControl IsNot Nothing)
            CloseSearchDialog()
        End Sub
        Private Sub CloseSearchDialog()
            Try
                If Not _StartControl.Visible Then
                    _StartControl.SlideOutButtonVisible = True
                End If
                _Commands.SearchCommands.Find.Enabled = True
                Me.CloseModalPanel(_SearchControl, DevComponents.DotNetBar.Controls.eSlideSide.Left)
                _SearchControl.Commands = Nothing
                _SearchControl.Dispose()
                _SearchControl = Nothing
            Catch ex As Exception

            End Try

        End Sub
        Sub clear()
            _SearchControl.stud_idText.Text = Nothing
            _SearchControl.stud_idText.Select()
            _StartControl.lbl_stud_id.Text = "NOT AVAILABLE"
            _StartControl.lbl_student_name.Text = "NOT AVAILABLE"
            _StartControl.lbl_course_yr.Text = "NOT AVAILABLE"
            _StartControl.lbl_acad_year.Text = "NOT AVAILABLE"
            _StartControl.lbl_semester.Text = "NOT AVAILABLE"
            _StartControl.registrarSwitch.Value = False
            _StartControl.businessSwitch.Value = False
            _StartControl.guidanceSwitch.Value = False
            _StartControl.librarySwitch.Value = False
            _StartControl.bookstoreSwitch.Value = False
            _StartControl.instructorSwitch.Value = False
            _StartControl.businessButton.Visible = True
            _StartControl.guidanceButton.Visible = True
            _StartControl.libraryButton.Visible = True
            _StartControl.bookstoreButton.Visible = True
            _StartControl.instructorButton.Visible = True
        End Sub
        Private Sub studidText_Keydown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
            Try
                If e.KeyCode = Keys.Enter Then
                    rs = New ADODB.Recordset
                    rs.Open("SELECT * FROM `tbl_registrar` WHERE stud_id='" & _SearchControl.stud_idText.Text & "' ", cn, 1, 2)
                    ' rs = New ADODB.Recordset
                    ' rs.Open("SELECT * FROM `tbl_library` WHERE stud_id='" & _SearchControl.stud_idText.Text & "' ", cn, 1, 2)
                    Dim y As Integer
                    y = 0
                    While Not rs.EOF
                        rs.MoveNext()
                        y = y + 1
                    End While
                    If y = 1 Then
                        rs = New ADODB.Recordset
                        rs.Open("SELECT * FROM `tbl_registrar` WHERE stud_id='" & _SearchControl.stud_idText.Text & "' ", cn, 1, 2)
                        _StartControl.lbl_path.Text = rs.Fields("path_image").Value.ToString
                        If _StartControl.lbl_path.Text = Nothing Then
                            _StartControl.PictureBox2.Image = Nothing
                        Else
                            _StartControl.PictureBox2.Image = Image.FromFile(_StartControl.lbl_path.Text)
                        End If

                        search()
                    ElseIf y > 1 Then
                        search()
                    ElseIf _SearchControl.stud_idText.Text = "" Then
                        MsgBox("Please, Input a student number...", MsgBoxStyle.Exclamation, "FAILED")
                        clear()
                    Else
                        MsgBox("Invalid Input !", MsgBoxStyle.Exclamation, "FAILED")
                        clear()
                    End If
                End If

            Catch ex As Exception

            End Try
          
        End Sub

        Sub search()
            'get max id
            _StartControl.registrarSwitch.Value = False
            _StartControl.businessSwitch.Value = False
            _StartControl.guidanceSwitch.Value = False
            _StartControl.librarySwitch.Value = False
            _StartControl.bookstoreSwitch.Value = False
            _StartControl.instructorSwitch.Value = False
            _StartControl.LabelX11.Text = ""
            _StartControl.LabelX13.Text = ""
            _StartControl.LabelX14.Text = ""
            _StartControl.LabelX15.Text = ""
            _StartControl.LabelX17.Text = ""
            _StartControl.LabelX19.Text = ""
            _StartControl.businessButton.Visible = True
            _StartControl.guidanceButton.Visible = True
            _StartControl.libraryButton.Visible = True
            _StartControl.bookstoreButton.Visible = True
            _StartControl.instructorButton.Visible = True

            rs = New ADODB.Recordset
            rs.Open("SELECT MAX(ID) FROM `tbl_registrar` WHERE stud_id='" & _SearchControl.stud_idText.Text & "' ", cn, 1, 2)


            'REGISTRAR
            Dim mxreg As Integer = rs.Fields(0).Value
            rs = New ADODB.Recordset
            rs.Open("SELECT * FROM `tbl_registrar` WHERE ID = " & mxreg, cn, 1, 2)


            'display details
            _StartControl.lbl_stud_id.Text = rs.Fields("stud_id").Value.ToString
            _StartControl.lbl_student_name.Text = rs.Fields("last_name").Value.ToString + ", " & rs.Fields("first_name").Value.ToString + " " & rs.Fields("middle_name").Value.ToString
            _StartControl.lbl_course_yr.Text = rs.Fields("current_course").Value.ToString + " " & rs.Fields("year_level").Value.ToString
            _StartControl.lbl_acad_year.Text = rs.Fields("school_yr").Value.ToString
            _StartControl.lbl_semester.Text = rs.Fields("semester").Value.ToString


            Try
                'LIBRARY
                rs = New ADODB.Recordset
                rs.Open("SELECT MAX(ID) FROM `tbl_library` WHERE stud_id='" & _SearchControl.stud_idText.Text & "' ", cn, 1, 2)

                Dim mxlib As Integer = rs.Fields(0).Value
                rs = New ADODB.Recordset
                rs.Open("SELECT * FROM `tbl_library` WHERE ID = " & mxlib, cn, 1, 2)
                _StartControl.LabelX15.Text = rs.Fields("status").Value.ToString
            Catch ex As Exception

            End Try

            Try

                'GUIDANCE
                rs = New ADODB.Recordset
                rs.Open("SELECT MAX(ID) FROM `tbl_guidance` WHERE stud_id='" & _SearchControl.stud_idText.Text & "' ", cn, 1, 2)
                Dim mxgui As Integer = rs.Fields(0).Value
                rs = New ADODB.Recordset
                rs.Open("SELECT * FROM `tbl_guidance` WHERE ID = " & mxgui, cn, 1, 2)
                _StartControl.LabelX14.Text = rs.Fields("status").Value.ToString
            Catch ex As Exception

            End Try

            Try
                'BUSINESS
                rs = New ADODB.Recordset
                rs.Open("SELECT MAX(ID) FROM `tbl_business` WHERE stud_id='" & _SearchControl.stud_idText.Text & "' ", cn, 1, 2)
                Dim mxbus As Integer = rs.Fields(0).Value
                rs = New ADODB.Recordset
                rs.Open("SELECT * FROM `tbl_business` WHERE ID = " & mxbus, cn, 1, 2)
                _StartControl.LabelX13.Text = rs.Fields("status").Value.ToString
            Catch ex As Exception

            End Try

            Try
                'BOOKSTORE
                rs = New ADODB.Recordset
                rs.Open("SELECT MAX(ID) FROM `tbl_bookstore` WHERE stud_id='" & _SearchControl.stud_idText.Text & "' ", cn, 1, 2)
                Dim mxbook As Integer = rs.Fields(0).Value
                rs = New ADODB.Recordset
                rs.Open("SELECT * FROM `tbl_bookstore` WHERE ID = " & mxbook, cn, 1, 2)
                _StartControl.LabelX17.Text = rs.Fields("status").Value.ToString
            Catch ex As Exception

            End Try


            Try

                'INSTRUCTOR
                rs = New ADODB.Recordset
                rs.Open("SELECT * ,(SELECT COUNT (subject_code) FROM tbl_grades WHERE stud_id='" & _StartControl.lbl_stud_id.Text & "' AND semester='" & _StartControl.lbl_semester.Text & "' and school_yr='" & _StartControl.lbl_acad_year.Text & "') as total_subjects FROM(tbl_grades)WHERE stud_id='" & _StartControl.lbl_stud_id.Text & "' AND semester='" & _StartControl.lbl_semester.Text & "' and school_yr='" & _StartControl.lbl_acad_year.Text & "' ", cn, 1, 2)
                _StartControl.lbl_count.Text = rs.Fields(0).Value.ToString

                rs = New ADODB.Recordset
                rs.Open("SELECT * ,(SELECT COUNT (status) FROM tbl_grades WHERE stud_id='" & _StartControl.lbl_stud_id.Text & "' AND semester='" & _StartControl.lbl_semester.Text & "' and school_yr='" & _StartControl.lbl_acad_year.Text & "' and status='CLEARED') as total_cleared FROM(tbl_grades)WHERE stud_id='" & _StartControl.lbl_stud_id.Text & "' AND semester='" & _StartControl.lbl_semester.Text & "' and school_yr='" & _StartControl.lbl_acad_year.Text & "' ", cn, 1, 2)
                _StartControl.lbl_count_cleared.Text = rs.Fields(0).Value.ToString

            Catch ex As Exception

            End Try

            If _StartControl.lbl_count_cleared.Text = _StartControl.lbl_count.Text Then
                _StartControl.LabelX19.Text = "CLEARED"
                _StartControl.instructorSwitch.Value = True
                _StartControl.instructorButton.Visible = False
            Else
                _StartControl.instructorSwitch.Value = False
                _StartControl.LabelX19.Text = "NOT CLEARED"
                _StartControl.instructorButton.Visible = True
            End If

            MsgBox("Successful!", MsgBoxStyle.Information, "SUCCESS")
            clear1()
            Debug.Assert(_SearchControl IsNot Nothing)
            CloseSearchDialog()





            If _StartControl.LabelX13.Text = "CLEARED" Then
                _StartControl.businessSwitch.Value = True
                _StartControl.businessButton.Visible = False
            ElseIf _StartControl.LabelX13.Text = "NOT CLEARED" Then
                _StartControl.businessSwitch.Value = False
                _StartControl.businessButton.Visible = True
            End If

            If _StartControl.LabelX14.Text = "CLEARED" Then
                _StartControl.guidanceSwitch.Value = True
                _StartControl.guidanceButton.Visible = False
            ElseIf _StartControl.LabelX14.Text = "NOT CLEARED" Then
                _StartControl.guidanceSwitch.Value = False
                _StartControl.businessButton.Visible = True
            End If

            If _StartControl.LabelX15.Text = "CLEARED" Then
                _StartControl.librarySwitch.Value = True
                _StartControl.libraryButton.Visible = False
            ElseIf _StartControl.LabelX15.Text = "NOT CLEARED" Then
                _StartControl.librarySwitch.Value = False
                _StartControl.libraryButton.Visible = True
            End If

            If _StartControl.LabelX17.Text = "CLEARED" Then
                _StartControl.bookstoreSwitch.Value = True
                _StartControl.bookstoreButton.Visible = False
            ElseIf _StartControl.LabelX17.Text = "NOT CLEARED" Then
                _StartControl.bookstoreSwitch.Value = False
                _StartControl.bookstoreButton.Visible = True
            End If

            If _StartControl.LabelX13.Text = "CLEARED" And _StartControl.LabelX14.Text = "CLEARED" And _StartControl.LabelX15.Text = "CLEARED" And _StartControl.LabelX17.Text = "CLEARED" And _StartControl.LabelX19.Text = "CLEARED" Then
                _StartControl.LabelX11.Text = "CLEARED"
                _StartControl.registrarSwitch.Value = True
            Else
                _StartControl.LabelX11.Text = "NOT CLEARD"
                _StartControl.registrarSwitch.Value = False
            End If

        End Sub
        Private Sub SearchStudentExecuted_button(ByVal sender As Object, ByVal e As EventArgs)
            Try
                rs = New ADODB.Recordset
                rs.Open("SELECT * FROM `tbl_registrar` WHERE stud_id='" & _SearchControl.stud_idText.Text & "' ", cn, 1, 2)
                rs = New ADODB.Recordset
                rs.Open("SELECT * FROM `tbl_library` WHERE stud_id='" & _SearchControl.stud_idText.Text & "' ", cn, 1, 2)
                Dim y As Integer
                y = 0
                While Not rs.EOF
                    rs.MoveNext()
                    y = y + 1
                End While
                If y = 1 Then
                    rs = New ADODB.Recordset
                    rs.Open("SELECT * FROM `tbl_registrar` WHERE stud_id='" & _SearchControl.stud_idText.Text & "' ", cn, 1, 2)
                    _StartControl.lbl_path.Text = rs.Fields("path_image").Value.ToString
                    If _StartControl.lbl_path.Text = Nothing Then
                        _StartControl.PictureBox2.Image = Nothing
                    Else
                        _StartControl.PictureBox2.Image = Image.FromFile(_StartControl.lbl_path.Text)
                    End If

                    search()
                ElseIf y > 1 Then
                    search()
                ElseIf _SearchControl.stud_idText.Text = "" Then
                    MsgBox("Please, Input a student number...", MsgBoxStyle.Exclamation, "FAILED")
                    clear()
                Else
                    MsgBox("Invalid Input !", MsgBoxStyle.Exclamation, "FAILED")
                    clear()
                End If

            Catch ex As Exception

            End Try
        End Sub
        Private Sub StudentInformationExecuted(ByVal sender As Object, ByVal e As EventArgs)
            CloseSearchDialog()
        End Sub
#End Region

#Region "Grades"
        '// Search Grades Textbox
        Private Sub searchGradesTxt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles searchGradesTxt.TextChanged

            rs = New ADODB.Recordset
            rs.Open("SELECT * FROM  `tbl_grades` WHERE `ID` like '%" & searchGradesTxt.Text & "%' or `emp_id` like '%" & searchGradesTxt.Text & "%' or `last_name` like '%" & searchGradesTxt.Text & "%' or `first_name` like '%" & searchGradesTxt.Text & "%' or `middle_name` like '%" & searchGradesTxt.Text & "%' or `subject_code` like '%" & searchGradesTxt.Text & "%' or `subject_description` like '%" & searchGradesTxt.Text & "%' or `units` like '%" & searchGradesTxt.Text & "%' or `school_yr` like '%" & searchGradesTxt.Text & "%' or `semester` like '%" & searchGradesTxt.Text & "%'  or `year_level` like '%" & searchGradesTxt.Text & "%'  or `stud_id` like '%" & searchGradesTxt.Text & "%' or `stud_name` like '%" & searchGradesTxt.Text & "%' or `grades` like '%" & searchGradesTxt.Text & "%' or `status` like '%" & searchGradesTxt.Text & "%' or `current_course` like '%" & searchGradesTxt.Text & "%' ", cn, 1, 2)
            ListViewEx6.Items.Clear()
            Do While Not rs.EOF
                Dim lv As ListViewItem
                lv = ListViewEx6.Items.Add(rs.Fields(0).Value)
                lv.SubItems.Add(rs.Fields(1).Value)
                lv.SubItems.Add(rs.Fields(2).Value)
                lv.SubItems.Add(rs.Fields(3).Value)
                lv.SubItems.Add(rs.Fields(4).Value)
                lv.SubItems.Add(rs.Fields(5).Value)
                lv.SubItems.Add(rs.Fields(6).Value)
                lv.SubItems.Add(rs.Fields(7).Value)
                lv.SubItems.Add(rs.Fields(8).Value)
                lv.SubItems.Add(rs.Fields(9).Value)
                lv.SubItems.Add(rs.Fields(10).Value)
                lv.SubItems.Add(rs.Fields(11).Value)
                lv.SubItems.Add(rs.Fields(12).Value)
                lv.SubItems.Add(rs.Fields(15).Value)
                lv.SubItems.Add(rs.Fields(13).Value)
                lv.SubItems.Add(rs.Fields(14).Value)
                lv.SubItems.Add(rs.Fields(16).Value)
                rs.MoveNext()
            Loop
        End Sub

        Private Sub GradesDeleteExecuted(ByVal sender As Object, ByVal e As EventArgs)
            If _StartControl.LabelX20.Text <> "ADM-0000001" Then
                MsgBox("You don't have access to this command!", MsgBoxStyle.Critical, "SYSTEM")
            ElseIf MsgBox("Are you sure you want to delete this record?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "WARNING") = MsgBoxResult.Yes Then
                rs = New ADODB.Recordset
                rs.Open("DELETE FROM `tbl_grades` WHERE `ID` = " & LabelX6.Text & " ", cn, 1, 2)
                loadgradesdata()
                MsgBox("Delete Succesfully", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "SUCCESS")
            End If
        End Sub

        Private Sub GradesSearchExecuted(ByVal sender As Object, ByVal e As EventArgs)
            searchGradesTxt.Focus()
        End Sub

        Private Sub GradesAddExecuted(ByVal sender As Object, ByVal e As EventArgs)
            If t_id.Text = Nothing _
                Or t_studid.Text = Nothing _
                Or t_lastname.Text = Nothing _
                Or t_firstname.Text = Nothing _
                Or t_middlename.Text = Nothing _
                Or t_subjcode.Text = Nothing _
                Or t_subjdesc.Text = Nothing _
                Or t_units.Text = Nothing _
                Or t_yearlevel.Text = Nothing _
                Or t_semester.Text = Nothing _
                Or t_studid.Text = Nothing _
                Or t_stud_name.Text = Nothing _
                Or t_grades.Text = Nothing _
                Or t_status.Text = Nothing _
                Or t_course.Text = Nothing _
                Or t_acadyear.Text = Nothing Then
                MsgBox("Fill-out all fields !", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Warning")
            Else

                rs = New ADODB.Recordset
                rs.Open("SELECT * FROM `tbl_grades` WHERE `emp_id` ='" & t_empid.Text & "' ", cn, 1, 2)
                Dim q As Integer
                q = 0
                While Not rs.EOF
                    rs.MoveNext()
                    q = q + 1
                End While
                If q = 1 Then
                    ' MsgBox("The employee number is already taken", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "FAILED")
                    ' i_empid.Select()
                    Exit Sub
                Else

                    rs = New ADODB.Recordset
                    rs.Open("INSERT INTO `tbl_grades` ( `emp_id`, `last_name`, `first_name`, `middle_name` , `subject_code`, `subject_description`,  `units`, `school_yr`, `semester`, `year_level` , `path_image`, `stud_id`, `stud_name`,`grades`, `status`,`current_course`) VALUES ( '" & t_empid.Text & "', '" & t_lastname.Text & "', '" & t_firstname.Text & "', '" & t_middlename.Text & "', '" & t_subjcode.Text & "' , '" & t_subjdesc.Text & "',  '" & t_units.Text & "' , '" & t_acadyear.Text & "', '" & t_semester.Text & "' , '" & t_yearlevel.Text & "',  '" & t_directorypath.Text & "' ,  '" & t_studid.Text & "' ,  '" & t_stud_name.Text & "' ,  '" & t_grades.Text & "' ,  '" & t_status.Text & "' ,  '" & t_course.Text & "')", cn, 1, 2)

                    MsgBox("New Record Added !", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "SUCCESS")

                    loadregistrardata()
                    loadlibrarydata()
                    loadguidancedata()
                    loadbusinessdata()
                    loadgradesdata()
                    loadinstructordata()

                    clear6()

                End If
            End If


        End Sub
        Sub clear6()
            t_id.Text = Nothing
            t_empid.Text = Nothing
            t_lastname.Text = Nothing
            t_firstname.Text = Nothing
            t_middlename.Text = Nothing
            t_subjcode.Text = Nothing
            t_subjdesc.Text = Nothing
            t_units.Text = Nothing
            t_yearlevel.Text = Nothing
            t_semester.Text = Nothing
            t_studid.Text = Nothing
            t_stud_name.Text = Nothing
            t_grades.Text = Nothing
            t_status.Text = Nothing
            t_course.Text = Nothing
            t_acadyear.Text = Nothing
            t_directorypath.Text = Nothing
            PictureBox6.Image = Nothing
        End Sub

        Private Sub GradesUpdateExecuted(ByVal sender As Object, ByVal e As EventArgs)
            If t_id.Text = Nothing _
              Or t_lastname.Text = Nothing _
              Or t_firstname.Text = Nothing _
              Or t_middlename.Text = Nothing _
              Or t_subjcode.Text = Nothing _
              Or t_subjdesc.Text = Nothing _
              Or t_units.Text = Nothing _
              Or t_yearlevel.Text = Nothing _
              Or t_semester.Text = Nothing _
              Or t_studid.Text = Nothing _
              Or t_stud_name.Text = Nothing _
              Or t_grades.Text = Nothing _
              Or t_status.Text = Nothing _
              Or t_course.Text = Nothing _
              Or t_acadyear.Text = Nothing Then
                MsgBox("Fill-out all fields !", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Warning")
            Else
                rs = New ADODB.Recordset
                rs.Open("Update  tbl_grades SET `emp_id` = '" & t_empid.Text & "', `last_name` = '" & t_lastname.Text & "', `first_name`= '" & t_firstname.Text & "', `middle_name` =  '" & t_middlename.Text & "', `subject_code` =  '" & t_subjcode.Text & "', `subject_description` =  '" & t_subjdesc.Text & "', `units` =  '" & t_units.Text & "', `year_level` = '" & t_yearlevel.Text & "', `semester` = '" & t_semester.Text & "', `school_yr`=  '" & t_acadyear.Text & "' , `path_image`= '" & t_directorypath.Text & "' , `stud_id`= '" & t_studid.Text & "' , `stud_name`= '" & t_stud_name.Text & "'  , `grades`= '" & t_grades.Text & "' , `status`= '" & t_status.Text & "'  , `current_course`= '" & t_course.Text & "'  WHERE `ID` = " & t_id.Text & " ", cn, 1, 2)

                t_id.Text = t_lastname.Text + ", " + t_firstname.Text + " " + t_middlename.Text

                MsgBox("New Record Updated !", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "SUCCESS")
                loadregistrardata()
                loadlibrarydata()
                loadguidancedata()
                loadbusinessdata()
                loadgradesdata()
                loadinstructordata()

                t_id.Text = Nothing
                'prev_idLbl.Text = Nothing

                clear6()
            End If

        End Sub



#End Region

#Region "Bookstore"
        Private _BookstoreControl As BookstoreControl = Nothing
        Private Sub BookstoreExecuted(ByVal sender As Object, ByVal e As EventArgs)
            Debug.Assert(_BookstoreControl Is Nothing)
            _Commands.BookstoreCommands.Display.Enabled = False
            _BookstoreControl = New BookstoreControl()
            _BookstoreControl.Commands = _Commands
            Me.ShowModalPanel(_BookstoreControl, DevComponents.DotNetBar.Controls.eSlideSide.Left)
            If Not _StartControl.Visible Then
                _StartControl.SlideOutButtonVisible = False
            End If

            Try
                rs = New ADODB.Recordset
                rs.Open("SELECT * FROM tbl_bookstore WHERE stud_id='" & _StartControl.lbl_stud_id.Text & "' AND semester='" & _StartControl.lbl_semester.Text & "' AND school_yr='" & _StartControl.lbl_acad_year.Text & "' ", cn, 1, 2)

                _BookstoreControl.LabelX9.Text = rs.Fields("last_name").Value.ToString + ", " + rs.Fields("first_name").Value.ToString + " " + rs.Fields("middle_name").Value.ToString
                _BookstoreControl.LabelX5.Text = rs.Fields("stud_id").Value.ToString
                _BookstoreControl.LabelX10.Text = rs.Fields("current_course").Value.ToString
                _BookstoreControl.LabelX11.Text = rs.Fields("year_level").Value.ToString
                _BookstoreControl.LabelX12.Text = rs.Fields("semester").Value.ToString
                _BookstoreControl.LabelX13.Text = rs.Fields("school_yr").Value.ToString
                _BookstoreControl.ListViewEx1.Items.Clear()

            Catch ex As Exception

            End Try


            Do While Not rs.EOF
                Dim lv As ListViewItem
                lv = _BookstoreControl.ListViewEx1.Items.Add(rs.Fields(0).Value)
                lv.SubItems.Add(rs.Fields(12).Value)
                rs.MoveNext()
            Loop
        End Sub


        Private Sub CancelBookstoreExecuted(ByVal sender As Object, ByVal e As EventArgs)
            Debug.Assert(_BookstoreControl IsNot Nothing)
            CloseBookstoreDialog()
        End Sub
        Private Sub CloseBookstoreDialog()
            If Not _StartControl.Visible Then
                _StartControl.SlideOutButtonVisible = True
            End If
            _Commands.BookstoreCommands.Display.Enabled = True
            Me.CloseModalPanel(_BookstoreControl, DevComponents.DotNetBar.Controls.eSlideSide.Left)
            _BookstoreControl.Commands = Nothing
            _BookstoreControl.Dispose()
            _BookstoreControl = Nothing
        End Sub

        Private Sub BookstoreSearchExecuted(ByVal sender As Object, ByVal e As EventArgs)
            searchBookstoretxt.Focus()
        End Sub


        Private Sub searchBookstoreTxt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles searchBookstoretxt.TextChanged

            rs = New ADODB.Recordset
            rs.Open("SELECT * FROM  `tbl_bookstore` WHERE `ID` like '%" & searchBookstoretxt.Text & "%' or `stud_id` like '%" & searchBookstoretxt.Text & "%' or `last_name` like '%" & searchBookstoretxt.Text & "%' or `first_name` like '%" & searchBookstoretxt.Text & "%' or `middle_name` like '%" & searchBookstoretxt.Text & "%' or `current_course` like '%" & searchBookstoretxt.Text & "%' or `year_level` like '%" & searchBookstoretxt.Text & "%' or `semester` like '%" & searchBookstoretxt.Text & "%' or `school_yr` like '%" & searchBookstoretxt.Text & "%' or `contact_num` like '%" & searchBookstoretxt.Text & "%'  or `status` like '%" & searchBookstoretxt.Text & "%' or `description` like '%" & searchBookstoretxt.Text & "%'", cn, 1, 2)
            ListViewEx7.Items.Clear()
            Do While Not rs.EOF
                Dim lv As ListViewItem
                lv = ListViewEx7.Items.Add(rs.Fields(0).Value)
                lv.SubItems.Add(rs.Fields(1).Value)
                lv.SubItems.Add(rs.Fields(2).Value)
                lv.SubItems.Add(rs.Fields(3).Value)
                lv.SubItems.Add(rs.Fields(4).Value)
                lv.SubItems.Add(rs.Fields(5).Value)
                lv.SubItems.Add(rs.Fields(6).Value)
                lv.SubItems.Add(rs.Fields(7).Value)
                lv.SubItems.Add(rs.Fields(8).Value)
                lv.SubItems.Add(rs.Fields(9).Value)
                lv.SubItems.Add(rs.Fields(10).Value)
                lv.SubItems.Add(rs.Fields(11).Value)
                lv.SubItems.Add(rs.Fields(12).Value)
                rs.MoveNext()
            Loop
        End Sub

        Private Sub BookstoreDeleteExecuted(ByVal sender As Object, ByVal e As EventArgs)
            If _StartControl.LabelX20.Text <> "ADM-0000001" Then
                MsgBox("You don't have access to this command!", MsgBoxStyle.Critical, "SYSTEM")
            ElseIf bk_id.Text = "" Then
                MsgBox("Please, Select from the list", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "WARNING")
            ElseIf MsgBox("Are you sure you want to delete this record?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "WARNING") = MsgBoxResult.Yes Then
                rs = New ADODB.Recordset
                rs.Open("DELETE FROM `tbl_bookstore` WHERE `ID` = " & bk_idlbl.Text & " ", cn, 1, 2)
                loadbookstoredata()
                loadregistrardata()
                loadbusinessdata()
                loadgradesdata()
                loadguidancedata()
                loadinstructordata()
                loadlibrarydata()

                MsgBox("Delete Succesfully", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "SUCCESS")
                clear9()

            End If
        End Sub


        Sub clear9()
            bk_id.Text = ""
            bk_studid.Text = ""
            bk_lastname.Text = ""
            bk_firstname.Text = ""
            bk_middlename.Text = ""
            bk_course.Text = ""
            bk_year.Text = ""
            bk_sem.Text = ""
            bk_acadyear.Text = ""
            bk_status.Text = ""
            bk_desc.Text = ""
            bk_contact.Text = ""
            bk_photodir.Text = Nothing
        End Sub

        Private Sub BookstoreAddExecuted(ByVal sender As Object, ByVal e As EventArgs)
            If bk_id.Text = Nothing _
                Or bk_studid.Text = Nothing _
                Or bk_lastname.Text = Nothing _
                Or bk_firstname.Text = Nothing _
                Or bk_middlename.Text = Nothing _
                Or bk_course.Text = Nothing _
                Or bk_year.Text = Nothing _
                Or bk_sem.Text = Nothing _
                Or bk_acadyear.Text = Nothing _
                Or bk_status.Text = Nothing _
                Or bk_contact.Text = Nothing Then
                MsgBox("Fill-out all fields !", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Warning")
            Else
                rs = New ADODB.Recordset
                rs.Open("SELECT * FROM `tbl_bookstore` WHERE `stud_id` ='" & bk_studid.Text & "' ", cn, 1, 2)
                Dim q As Integer
                q = 0
                While Not rs.EOF
                    rs.MoveNext()
                    q = q + 1
                End While
                ' If q = 1 Then
                'MsgBox("The student number is already taken", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "FAILED")
                ' bk_studid.Text = ""
                ' bk_studid.Select()
                'Exit Sub
                'Else
                rs = New ADODB.Recordset
                rs.Open("INSERT INTO `tbl_bookstore` ( `stud_id`, `last_name`, `first_name`, `middle_name` , `current_course`, `year_level`, `semester`, `school_yr`, `contact_num`, `path_image`, `status`, `description`) VALUES ( '" & bk_studid.Text & "', '" & bk_lastname.Text & "', '" & bk_firstname.Text & "', '" & bk_middlename.Text & "', '" & bk_course.Text & "', '" & bk_year.Text & "', '" & bk_sem.Text & "' , '" & bk_acadyear.Text & "', '" & bk_contact.Text & "', '" & bk_photodir.Text & "' ,'" & bk_status.Text & "','" & bk_desc.Text & "')", cn, 1, 2)
                MsgBox("New Record Added !", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "SUCCESS")
                loadbookstoredata()
                loadregistrardata()
                loadbusinessdata()
                loadgradesdata()
                loadguidancedata()
                loadinstructordata()
                loadlibrarydata()
                clear9()
            End If
            'End If
        End Sub
        Private Sub BookstoreUpdateExecuted(ByVal sender As Object, ByVal e As EventArgs)
            If bk_id.Text = Nothing _
              Or bk_studid.Text = Nothing _
              Or bk_lastname.Text = Nothing _
              Or bk_firstname.Text = Nothing _
              Or bk_middlename.Text = Nothing _
              Or bk_course.Text = Nothing _
              Or bk_year.Text = Nothing _
              Or bk_sem.Text = Nothing _
              Or bk_acadyear.Text = Nothing _
              Or bk_contact.Text = Nothing _
              Or bk_status.Text = Nothing _
              Or bk_photodir.Text = Nothing Then
                MsgBox("Fill-out all fields !", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Warning")
            Else
                rs = New ADODB.Recordset
                rs.Open("Update  tbl_bookstore SET `stud_id` = '" & bk_studid.Text & "', `last_name` = '" & bk_lastname.Text & "', `first_name`= '" & bk_firstname.Text & "', `middle_name` =  '" & bk_middlename.Text & "', `current_course` =  '" & bk_course.Text & "', `year_level` = '" & bk_year.Text & "', `semester` = '" & bk_sem.Text & "', `school_yr`=  '" & bk_acadyear.Text & "', `contact_num`='" & bk_contact.Text & "' , `path_image`= '" & bk_photodir.Text & "'  ,  `status`= '" & bk_status.Text & "' ,  `description`= '" & bk_desc.Text & "' WHERE `ID` = " & bk_id.Text & " ", cn, 1, 2)

                bk_fullnamelbl.Text = bk_lastname.Text + ", " + bk_firstname.Text + " " + bk_middlename.Text

                MsgBox("New Record Updated !", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "SUCCESS")
                loadregistrardata()
                loadlibrarydata()
                loadguidancedata()
                loadbusinessdata()
                loadgradesdata()
                loadbookstoredata()
                bk_fullnamelbl.Text = Nothing
                clear9()
            End If

        End Sub
#End Region
#End Region


#Region "UI Code"
#Region "listview"


        Sub loadregistrardata()
            Try
                rs = New ADODB.Recordset
                rs.Open("SELECT * FROM `tbl_registrar`", cn, 1, 2)
                ListViewEx1.Items.Clear()
                Do While Not rs.EOF
                    Dim lv As ListViewItem
                    lv = ListViewEx1.Items.Add(rs.Fields(0).Value)
                    lv.SubItems.Add(rs.Fields(1).Value)
                    lv.SubItems.Add(rs.Fields(2).Value)
                    lv.SubItems.Add(rs.Fields(3).Value)
                    lv.SubItems.Add(rs.Fields(4).Value)
                    lv.SubItems.Add(rs.Fields(5).Value)
                    lv.SubItems.Add(rs.Fields(6).Value)
                    lv.SubItems.Add(rs.Fields(7).Value)
                    lv.SubItems.Add(rs.Fields(8).Value)
                    lv.SubItems.Add(rs.Fields(9).Value)
                    lv.SubItems.Add(rs.Fields(10).Value.ToString)
                    rs.MoveNext()
                Loop
            Catch ex As Exception

            End Try

        End Sub

        Sub loadbusinessdata()
            Try
                rs = New ADODB.Recordset
                rs.Open("SELECT * FROM `tbl_business` ", cn, 1, 2)
                ListViewEx2.Items.Clear()
                Do While Not rs.EOF
                    Dim lv As ListViewItem
                    lv = ListViewEx2.Items.Add(rs.Fields(0).Value)
                    lv.SubItems.Add(rs.Fields(1).Value)
                    lv.SubItems.Add(rs.Fields(2).Value)
                    lv.SubItems.Add(rs.Fields(3).Value)
                    lv.SubItems.Add(rs.Fields(4).Value)
                    lv.SubItems.Add(rs.Fields(5).Value)
                    lv.SubItems.Add(rs.Fields(6).Value)
                    lv.SubItems.Add(rs.Fields(7).Value)
                    lv.SubItems.Add(rs.Fields(8).Value)
                    lv.SubItems.Add(rs.Fields(9).Value)
                    lv.SubItems.Add(rs.Fields(10).Value)
                    lv.SubItems.Add(rs.Fields(11).Value)
                    lv.SubItems.Add(rs.Fields(12).Value)
                    lv.SubItems.Add(rs.Fields(13).Value)
                    rs.MoveNext()
                Loop
            Catch ex As Exception

            End Try

        End Sub

        Sub loadguidancedata()
            Try
                rs = New ADODB.Recordset
                rs.Open("SELECT * FROM `tbl_guidance` ", cn, 1, 2)
                ListViewEx3.Items.Clear()
                Do While Not rs.EOF
                    Dim lv As ListViewItem
                    lv = ListViewEx3.Items.Add(rs.Fields(0).Value)
                    lv.SubItems.Add(rs.Fields(1).Value)
                    lv.SubItems.Add(rs.Fields(2).Value)
                    lv.SubItems.Add(rs.Fields(3).Value)
                    lv.SubItems.Add(rs.Fields(4).Value)
                    lv.SubItems.Add(rs.Fields(5).Value)
                    lv.SubItems.Add(rs.Fields(6).Value)
                    lv.SubItems.Add(rs.Fields(7).Value)
                    lv.SubItems.Add(rs.Fields(8).Value)
                    lv.SubItems.Add(rs.Fields(9).Value)
                    lv.SubItems.Add(rs.Fields(10).Value)
                    lv.SubItems.Add(rs.Fields(11).Value)
                    lv.SubItems.Add(rs.Fields(12).Value)
                    rs.MoveNext()
                Loop
            Catch ex As Exception

            End Try

        End Sub



        Sub loadbookstoredata()
            Try
                rs = New ADODB.Recordset
                rs.Open("SELECT * FROM `tbl_bookstore` ", cn, 1, 2)
                ListViewEx7.Items.Clear()
                Do While Not rs.EOF
                    Dim lv As ListViewItem
                    lv = ListViewEx7.Items.Add(rs.Fields(0).Value)
                    lv.SubItems.Add(rs.Fields(1).Value)
                    lv.SubItems.Add(rs.Fields(2).Value)
                    lv.SubItems.Add(rs.Fields(3).Value)
                    lv.SubItems.Add(rs.Fields(4).Value)
                    lv.SubItems.Add(rs.Fields(5).Value)
                    lv.SubItems.Add(rs.Fields(6).Value)
                    lv.SubItems.Add(rs.Fields(7).Value)
                    lv.SubItems.Add(rs.Fields(8).Value)
                    lv.SubItems.Add(rs.Fields(9).Value)
                    lv.SubItems.Add(rs.Fields(10).Value)
                    lv.SubItems.Add(rs.Fields(11).Value)
                    lv.SubItems.Add(rs.Fields(12).Value)
                    rs.MoveNext()
                Loop
            Catch ex As Exception

            End Try

        End Sub

        Sub loadlibrarydata()
            Try
                rs = New ADODB.Recordset
                rs.Open("SELECT * FROM `tbl_library` ", cn, 1, 2)
                ListViewEx4.Items.Clear()
                Do While Not rs.EOF
                    Dim lv As ListViewItem
                    lv = ListViewEx4.Items.Add(rs.Fields(0).Value)
                    lv.SubItems.Add(rs.Fields(1).Value)
                    lv.SubItems.Add(rs.Fields(2).Value)
                    lv.SubItems.Add(rs.Fields(3).Value)
                    lv.SubItems.Add(rs.Fields(4).Value)
                    lv.SubItems.Add(rs.Fields(5).Value)
                    lv.SubItems.Add(rs.Fields(6).Value)
                    lv.SubItems.Add(rs.Fields(7).Value)
                    lv.SubItems.Add(rs.Fields(8).Value)
                    lv.SubItems.Add(rs.Fields(9).Value)
                    lv.SubItems.Add(rs.Fields(10).Value)
                    lv.SubItems.Add(rs.Fields(11).Value)
                    lv.SubItems.Add(rs.Fields(12).Value)
                    lv.SubItems.Add(rs.Fields(13).Value)
                    rs.MoveNext()
                Loop
            Catch ex As Exception

            End Try


        End Sub

        Sub loadinstructordata()
            Try
                rs = New ADODB.Recordset
                rs.Open("SELECT * FROM `tbl_instructor`", cn, 1, 2)
                ListViewEx5.Items.Clear()
                Do While Not rs.EOF
                    Dim lv As ListViewItem
                    lv = ListViewEx5.Items.Add(rs.Fields(0).Value)
                    lv.SubItems.Add(rs.Fields(1).Value)
                    lv.SubItems.Add(rs.Fields(2).Value)
                    lv.SubItems.Add(rs.Fields(3).Value)
                    lv.SubItems.Add(rs.Fields(4).Value)
                    lv.SubItems.Add(rs.Fields(5).Value)
                    lv.SubItems.Add(rs.Fields(6).Value)
                    lv.SubItems.Add(rs.Fields(7).Value)
                    lv.SubItems.Add(rs.Fields(8).Value)
                    lv.SubItems.Add(rs.Fields(9).Value)
                    lv.SubItems.Add(rs.Fields(10).Value)
                    lv.SubItems.Add(rs.Fields(11).Value.ToString)
                    rs.MoveNext()

                Loop
            Catch ex As Exception

            End Try

        End Sub

        Sub loadgradesdata()
            Try
                rs = New ADODB.Recordset
                rs.Open("SELECT * FROM `tbl_grades`", cn, 1, 2)
                ListViewEx6.Items.Clear()
                Do While Not rs.EOF
                    Dim lv As ListViewItem
                    lv = ListViewEx6.Items.Add(rs.Fields(0).Value)
                    lv.SubItems.Add(rs.Fields(1).Value)
                    lv.SubItems.Add(rs.Fields(2).Value)
                    lv.SubItems.Add(rs.Fields(3).Value)
                    lv.SubItems.Add(rs.Fields(4).Value)
                    lv.SubItems.Add(rs.Fields(5).Value)
                    lv.SubItems.Add(rs.Fields(6).Value)
                    lv.SubItems.Add(rs.Fields(7).Value)
                    lv.SubItems.Add(rs.Fields(8).Value)
                    lv.SubItems.Add(rs.Fields(9).Value)
                    lv.SubItems.Add(rs.Fields(10).Value)
                    lv.SubItems.Add(rs.Fields(11).Value)
                    lv.SubItems.Add(rs.Fields(12).Value)
                    lv.SubItems.Add(rs.Fields(15).Value)
                    lv.SubItems.Add(rs.Fields(13).Value)
                    lv.SubItems.Add(rs.Fields(14).Value)
                    lv.SubItems.Add(rs.Fields(16).Value)

                    rs.MoveNext()
                Loop
            Catch ex As Exception

            End Try

        End Sub

#End Region

        Private Sub LoginControl_Click(ByVal sender As Object, ByVal e As EventArgs)
            _StartControl.IsOpen = False
            _LoginControl.IsOpen = False
            Me.ResumeLayout(False)
        End Sub

        Protected Overrides Sub OnLoad(ByVal e As EventArgs)
            UpdateControlsSizeAndLocation()
            UpdateControlsSizeAndLocation_Login()
            MyBase.OnLoad(e)
            connect_database()
            loadregistrardata()
            loadbusinessdata()
            loadguidancedata()
            loadlibrarydata()
            loadinstructordata()
            loadgradesdata()
            loadbookstoredata()

            'BackgroundWorker1.RunWorkerAsync()
            _LoginControl.usernameTxt.Select()
        End Sub

        Private Function GetStartControlBounds() As Rectangle
            Dim captionHeight As Integer = metroShell1.MetroTabStrip.GetCaptionHeight() + 2
            Dim borderThickness As Thickness = Me.GetBorderThickness()
            Return New Rectangle(CInt(Fix(borderThickness.Left)), captionHeight, Me.Width - CInt(Fix(borderThickness.Horizontal)), Me.Height - captionHeight - 1)
        End Function
        Private Sub UpdateControlsSizeAndLocation()
            If _StartControl IsNot Nothing Then
                If Not _StartControl.IsOpen Then
                    _StartControl.OpenBounds = GetStartControlBounds()
                Else
                    _StartControl.Bounds = GetStartControlBounds()
                End If
                If Not IsModalPanelDisplayed Then
                    _StartControl.BringToFront()
                End If
            End If
            MetroToolbar1.Location = New Point((Me.Width - MetroToolbar1.Width) / 2, MetroToolbar1.Parent.Height - MetroToolbar1.Height - 1)
            MetroToolbar2.Location = New Point((Me.Width - MetroToolbar2.Width) / 2, MetroToolbar2.Parent.Height - MetroToolbar2.Height - 1)
            MetroToolbar3.Location = New Point((Me.Width - MetroToolbar3.Width) / 2, MetroToolbar3.Parent.Height - MetroToolbar3.Height - 1)
            MetroToolbar4.Location = New Point((Me.Width - MetroToolbar4.Width) / 2, MetroToolbar4.Parent.Height - MetroToolbar4.Height - 1)
            MetroToolbar5.Location = New Point((Me.Width - MetroToolbar5.Width) / 2, MetroToolbar5.Parent.Height - MetroToolbar5.Height - 1)
            MetroToolbar6.Location = New Point((Me.Width - MetroToolbar6.Width) / 2, MetroToolbar6.Parent.Height - MetroToolbar6.Height - 1)
            MetroToolbar7.Location = New Point((Me.Width - MetroToolbar7.Width) / 2, MetroToolbar7.Parent.Height - MetroToolbar7.Height - 1)

        End Sub
        Private Sub UpdateControlsSizeAndLocation_Login()
            If _LoginControl IsNot Nothing Then
                If Not _LoginControl.IsOpen Then
                    _LoginControl.OpenBounds = GetStartControlBounds()
                Else
                    _LoginControl.Bounds = GetStartControlBounds()
                End If
                If Not IsModalPanelDisplayed Then
                    _LoginControl.BringToFront()
                End If
            End If
            MetroToolbar1.Location = New Point((Me.Width - MetroToolbar1.Width) / 2, MetroToolbar1.Parent.Height - MetroToolbar1.Height - 1)
            MetroToolbar2.Location = New Point((Me.Width - MetroToolbar2.Width) / 2, MetroToolbar2.Parent.Height - MetroToolbar2.Height - 1)
            MetroToolbar3.Location = New Point((Me.Width - MetroToolbar3.Width) / 2, MetroToolbar3.Parent.Height - MetroToolbar3.Height - 1)
            MetroToolbar4.Location = New Point((Me.Width - MetroToolbar4.Width) / 2, MetroToolbar4.Parent.Height - MetroToolbar4.Height - 1)
            MetroToolbar5.Location = New Point((Me.Width - MetroToolbar5.Width) / 2, MetroToolbar5.Parent.Height - MetroToolbar5.Height - 1)
            MetroToolbar6.Location = New Point((Me.Width - MetroToolbar6.Width) / 2, MetroToolbar6.Parent.Height - MetroToolbar6.Height - 1)
            MetroToolbar7.Location = New Point((Me.Width - MetroToolbar7.Width) / 2, MetroToolbar7.Parent.Height - MetroToolbar7.Height - 1)


        End Sub
        Protected Overrides Sub OnResize(ByVal e As EventArgs)
            UpdateControlsSizeAndLocation()
            UpdateControlsSizeAndLocation_Login()
            MyBase.OnResize(e)
        End Sub

        Private Sub metroAppButton1_ExpandChange(ByVal sender As Object, ByVal e As EventArgs) Handles metroAppButton1.ExpandChange
            If Not _StartControl.Visible Then
                _StartControl.SlideOutButtonVisible = Not metroAppButton1.Expanded
            End If
        End Sub

        Private Sub metroShell1_SettingsButtonClick(ByVal sender As Object, ByVal e As EventArgs) Handles metroShell1.SettingsButtonClick
            MessageBoxEx.Show(Me, "TEST", "System", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Sub

        Private Sub metroShell1_HelpButtonClick(ByVal sender As Object, ByVal e As EventArgs) Handles metroShell1.HelpButtonClick
            MessageBoxEx.Show(Me, "TEST", "System", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Sub

        Private Sub metroShell1_SelectedTabChanged(ByVal sender As Object, ByVal e As EventArgs) Handles metroShell1.SelectedTabChanged
            UpdateControlsSizeAndLocation()
        End Sub
#End Region


        Private Sub ListViewEx1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListViewEx1.Click
            Try
                b_id_lbl.Text = ListViewEx1.SelectedItems(0).Text
                si_id_txt.Text = ListViewEx1.SelectedItems(0).Text
                prev_idLbl.Text = ListViewEx1.SelectedItems(0).SubItems(1).Text()
                si_stud_id_txt.Text = ListViewEx1.SelectedItems(0).SubItems(1).Text()
                si_Lname_txt.Text = ListViewEx1.SelectedItems(0).SubItems(2).Text()
                si_Fname_txt.Text = ListViewEx1.SelectedItems(0).SubItems(3).Text()
                si_Mname_txt.Text = ListViewEx1.SelectedItems(0).SubItems(4).Text()

                lbl_fullname.Text = ListViewEx1.SelectedItems(0).SubItems(2).Text() + ", " + ListViewEx1.SelectedItems(0).SubItems(3).Text() + " " + ListViewEx1.SelectedItems(0).SubItems(4).Text()

                si_course_txt.Text = ListViewEx1.SelectedItems(0).SubItems(5).Text()
                si_yr_txt.Text = ListViewEx1.SelectedItems(0).SubItems(6).Text()
                si_semester_txt.Text = ListViewEx1.SelectedItems(0).SubItems(7).Text()
                si_acadyear_txt.Text = ListViewEx1.SelectedItems(0).SubItems(8).Text()
                si_contact_txt.Text = ListViewEx1.SelectedItems(0).SubItems(9).Text()
                si_photo_path_txt.Text = ListViewEx1.SelectedItems(0).SubItems(10).Text

                If si_photo_path_txt.Text = Nothing Then
                    PictureBox1.Image = Nothing
                Else
                    PictureBox1.Image = Image.FromFile(_si_photo_path_txt.Text)
                End If
            Catch ex As Exception

            End Try


        End Sub

        Private Sub ButtonX1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX1.Click
            OpenFileDialog1.Filter = "image file(*.jpg, *.bmp, *.png) | *.jpg; *.bmp; *.png; | all files (*.*) | *.* "
            If OpenFileDialog1.ShowDialog <> Windows.Forms.DialogResult.Cancel Then

                PictureBox1.Image = Image.FromFile(OpenFileDialog1.FileName)

                si_photo_path_txt.Text = OpenFileDialog1.FileName
                'PictureBox1.Image = Image.FromFile(si_photo_path_txt.Text)
            End If
        End Sub


        Private Sub ListViewEx2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListViewEx2.Click
            Try
                b_id_lbl.Text = ListViewEx2.SelectedItems(0).Text
                b_id.Text = ListViewEx2.SelectedItems(0).Text
                business_prev_id.Text = ListViewEx2.SelectedItems(0).SubItems(1).Text()
                b_studid.Text = ListViewEx2.SelectedItems(0).SubItems(1).Text()
                b_lastname.Text = ListViewEx2.SelectedItems(0).SubItems(2).Text()
                b_firstname.Text = ListViewEx2.SelectedItems(0).SubItems(3).Text()
                b_middlename.Text = ListViewEx2.SelectedItems(0).SubItems(4).Text()

                b_fullname.Text = ListViewEx2.SelectedItems(0).SubItems(2).Text() + ", " + ListViewEx2.SelectedItems(0).SubItems(3).Text() + " " + ListViewEx2.SelectedItems(0).SubItems(4).Text()

                b_course.Text = ListViewEx2.SelectedItems(0).SubItems(5).Text()
                b_yearlvl.Text = ListViewEx2.SelectedItems(0).SubItems(6).Text()
                b_semester.Text = ListViewEx2.SelectedItems(0).SubItems(7).Text()
                b_acadyear.Text = ListViewEx2.SelectedItems(0).SubItems(8).Text()
                b_contact.Text = ListViewEx2.SelectedItems(0).SubItems(9).Text()
                b_description.Text = ListViewEx2.SelectedItems(0).SubItems(10).Text
                b_rembalance.Text = ListViewEx2.SelectedItems(0).SubItems(11).Text
                b_status.Text = ListViewEx2.SelectedItems(0).SubItems(12).Text
                b_directorypath.Text = ListViewEx2.SelectedItems(0).SubItems(13).Text

                If b_directorypath.Text = Nothing Then
                    PictureBox2.Image = Nothing
                Else
                    PictureBox2.Image = Image.FromFile(b_directorypath.Text)
                End If
            Catch ex As Exception

            End Try
        End Sub


        Private Sub ButtonX2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX2.Click
            OpenFileDialog1.Filter = "image file(*.jpg, *.bmp, *.png) | *.jpg; *.bmp; *.png; | all files (*.*) | *.* "
            If OpenFileDialog1.ShowDialog <> Windows.Forms.DialogResult.Cancel Then

                PictureBox2.Image = Image.FromFile(OpenFileDialog1.FileName)

                b_directorypath.Text = OpenFileDialog1.FileName
                'PictureBox1.Image = Image.FromFile(si_photo_path_txt.Text)
            End If
        End Sub



        Private Sub ListViewEx3_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListViewEx3.Click
            Try
                g_id_lbl.Text = ListViewEx3.SelectedItems(0).Text
                g_id.Text = ListViewEx3.SelectedItems(0).Text
                'prev_idLbl.Text = ListViewEx2.SelectedItems(0).SubItems(1).Text()
                g_studid.Text = ListViewEx3.SelectedItems(0).SubItems(1).Text()
                g_lastname.Text = ListViewEx3.SelectedItems(0).SubItems(2).Text()
                g_firstname.Text = ListViewEx3.SelectedItems(0).SubItems(3).Text()
                g_middlename.Text = ListViewEx3.SelectedItems(0).SubItems(4).Text()

                g_fullname.Text = ListViewEx3.SelectedItems(0).SubItems(2).Text() + ", " + ListViewEx3.SelectedItems(0).SubItems(3).Text() + " " + ListViewEx3.SelectedItems(0).SubItems(4).Text()

                g_course.Text = ListViewEx3.SelectedItems(0).SubItems(5).Text()
                g_yearlevel.Text = ListViewEx3.SelectedItems(0).SubItems(6).Text()
                g_semester.Text = ListViewEx3.SelectedItems(0).SubItems(7).Text()
                g_acadyear.Text = ListViewEx3.SelectedItems(0).SubItems(8).Text()
                g_contact.Text = ListViewEx3.SelectedItems(0).SubItems(9).Text()

                g_uncollectedTxt.Text = ListViewEx3.SelectedItems(0).SubItems(10).Text

                g_status.Text = ListViewEx3.SelectedItems(0).SubItems(11).Text

                g_directorypath.Text = ListViewEx3.SelectedItems(0).SubItems(12).Text

                If g_directorypath.Text = Nothing Then
                    PictureBox4.Image = Nothing
                Else
                    PictureBox4.Image = Image.FromFile(g_directorypath.Text)
                End If
            Catch ex As Exception

            End Try
        End Sub

        Private Sub ListViewEx7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListViewEx7.Click
            Try
                bk_idlbl.Text = ListViewEx7.SelectedItems(0).Text
                bk_id.Text = ListViewEx7.SelectedItems(0).Text
                'prev_idLbl.Text = ListViewEx2.SelectedItems(0).SubItems(1).Text()
                bk_studid.Text = ListViewEx7.SelectedItems(0).SubItems(1).Text()
                bk_lastname.Text = ListViewEx7.SelectedItems(0).SubItems(2).Text()
                bk_firstname.Text = ListViewEx7.SelectedItems(0).SubItems(3).Text()
                bk_middlename.Text = ListViewEx7.SelectedItems(0).SubItems(4).Text()
                bk_fullnamelbl.Text = ListViewEx7.SelectedItems(0).SubItems(2).Text() + ", " + ListViewEx7.SelectedItems(0).SubItems(3).Text() + " " + ListViewEx7.SelectedItems(0).SubItems(4).Text()
                bk_course.Text = ListViewEx7.SelectedItems(0).SubItems(5).Text()
                bk_year.Text = ListViewEx7.SelectedItems(0).SubItems(6).Text()
                bk_sem.Text = ListViewEx7.SelectedItems(0).SubItems(7).Text()
                bk_acadyear.Text = ListViewEx7.SelectedItems(0).SubItems(8).Text()
                bk_contact.Text = ListViewEx7.SelectedItems(0).SubItems(9).Text()
                bk_status.Text = ListViewEx7.SelectedItems(0).SubItems(10).Text
                bk_photodir.Text = ListViewEx7.SelectedItems(0).SubItems(11).Text
                bk_desc.Text = ListViewEx7.SelectedItems(0).SubItems(12).Text

                If bk_photodir.Text = Nothing Then
                    PictureBox7.Image = Nothing
                Else
                    PictureBox7.Image = Image.FromFile(bk_photodir.Text)
                End If
            Catch ex As Exception

            End Try
        End Sub
        Private Sub ButtonX7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX7.Click
            OpenFileDialog1.Filter = "image file(*.jpg, *.bmp, *.png) | *.jpg; *.bmp; *.png; | all files (*.*) | *.* "
            If OpenFileDialog1.ShowDialog <> Windows.Forms.DialogResult.Cancel Then

                PictureBox7.Image = Image.FromFile(OpenFileDialog1.FileName)

                bk_photodir.Text = OpenFileDialog1.FileName
                'PictureBox1.Image = Image.FromFile(si_photo_path_txt.Text)
            End If
        End Sub

        Private Sub ButtonX4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX4.Click
            OpenFileDialog1.Filter = "image file(*.jpg, *.bmp, *.png) | *.jpg; *.bmp; *.png; | all files (*.*) | *.* "
            If OpenFileDialog1.ShowDialog <> Windows.Forms.DialogResult.Cancel Then

                PictureBox4.Image = Image.FromFile(OpenFileDialog1.FileName)

                g_directorypath.Text = OpenFileDialog1.FileName
                'PictureBox1.Image = Image.FromFile(si_photo_path_txt.Text)
            End If
        End Sub


        Private Sub ListViewEx4_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListViewEx4.Click
            Try
                l_id_lbl.Text = ListViewEx4.SelectedItems(0).Text
                l_id.Text = ListViewEx4.SelectedItems(0).Text
                'prev_idLbl.Text = ListViewEx2.SelectedItems(0).SubItems(1).Text()
                l_studid.Text = ListViewEx4.SelectedItems(0).SubItems(1).Text()
                l_lastname.Text = ListViewEx4.SelectedItems(0).SubItems(2).Text()
                l_fistname.Text = ListViewEx4.SelectedItems(0).SubItems(3).Text()
                l_middlename.Text = ListViewEx4.SelectedItems(0).SubItems(4).Text()

                l_fullname.Text = ListViewEx4.SelectedItems(0).SubItems(2).Text() + ", " + ListViewEx4.SelectedItems(0).SubItems(3).Text() + " " + ListViewEx4.SelectedItems(0).SubItems(4).Text()

                l_course.Text = ListViewEx4.SelectedItems(0).SubItems(5).Text()
                l_yearlevel.Text = ListViewEx4.SelectedItems(0).SubItems(6).Text()
                l_semester.Text = ListViewEx4.SelectedItems(0).SubItems(7).Text()
                l_acadyear.Text = ListViewEx4.SelectedItems(0).SubItems(8).Text()
                l_contact.Text = ListViewEx4.SelectedItems(0).SubItems(9).Text()

                l_unretbook.Text = ListViewEx4.SelectedItems(0).SubItems(10).Text
                l_remainingBal.Text = ListViewEx4.SelectedItems(0).SubItems(11).Text
                l_status.Text = ListViewEx4.SelectedItems(0).SubItems(12).Text
                l_directorypath.Text = ListViewEx4.SelectedItems(0).SubItems(13).Text

                If l_directorypath.Text = Nothing Then
                    PictureBox3.Image = Nothing
                Else
                    PictureBox3.Image = Image.FromFile(l_directorypath.Text)
                End If
            Catch ex As Exception

            End Try
        End Sub


        Private Sub ButtonX3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX3.Click
            OpenFileDialog1.Filter = "image file(*.jpg, *.bmp, *.png) | *.jpg; *.bmp; *.png; | all files (*.*) | *.* "
            If OpenFileDialog1.ShowDialog <> Windows.Forms.DialogResult.Cancel Then

                PictureBox3.Image = Image.FromFile(OpenFileDialog1.FileName)

                l_directorypath.Text = OpenFileDialog1.FileName
                'PictureBox1.Image = Image.FromFile(si_photo_path_txt.Text)
            End If
        End Sub



        Private Sub ListViewEx5_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListViewEx5.Click
            Try
                i_id_lbl.Text = ListViewEx5.SelectedItems(0).Text
                i_id.Text = ListViewEx5.SelectedItems(0).Text
                'prev_idLbl.Text = ListViewEx2.SelectedItems(0).SubItems(1).Text()
                i_empid.Text = ListViewEx5.SelectedItems(0).SubItems(1).Text()
                i_lastname.Text = ListViewEx5.SelectedItems(0).SubItems(2).Text()
                i_firstname.Text = ListViewEx5.SelectedItems(0).SubItems(3).Text()
                i_middlename.Text = ListViewEx5.SelectedItems(0).SubItems(4).Text()

                i_fullname.Text = ListViewEx5.SelectedItems(0).SubItems(2).Text() + ", " + ListViewEx5.SelectedItems(0).SubItems(3).Text() + " " + ListViewEx5.SelectedItems(0).SubItems(4).Text()

                i_subjectcode.Text = ListViewEx5.SelectedItems(0).SubItems(5).Text()
                i_subjdesc.Text = ListViewEx5.SelectedItems(0).SubItems(6).Text()
                i_units.Text = ListViewEx5.SelectedItems(0).SubItems(7).Text()
                i_acadyear.Text = ListViewEx5.SelectedItems(0).SubItems(8).Text()
                i_semester.Text = ListViewEx5.SelectedItems(0).SubItems(9).Text()

                i_yearlevel.Text = ListViewEx5.SelectedItems(0).SubItems(10).Text

                i_directorypath.Text = ListViewEx5.SelectedItems(0).SubItems(11).Text

                If i_directorypath.Text = Nothing Then
                    PictureBox5.Image = Nothing
                Else
                    PictureBox5.Image = Image.FromFile(i_directorypath.Text)
                End If
            Catch ex As Exception

            End Try
        End Sub


        Private Sub ButtonX5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX5.Click
            OpenFileDialog1.Filter = "image file(*.jpg, *.bmp, *.png) | *.jpg; *.bmp; *.png; | all files (*.*) | *.* "
            If OpenFileDialog1.ShowDialog <> Windows.Forms.DialogResult.Cancel Then

                PictureBox5.Image = Image.FromFile(OpenFileDialog1.FileName)

                i_directorypath.Text = OpenFileDialog1.FileName
                'PictureBox1.Image = Image.FromFile(si_photo_path_txt.Text)
            End If
        End Sub


        Private Sub ListViewEx6_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListViewEx6.Click
            Try
                t_id.Text = ListViewEx6.SelectedItems(0).Text
                t_id_lbl.Text = ListViewEx6.SelectedItems(0).Text
                t_empid.Text = ListViewEx6.SelectedItems(0).SubItems(1).Text()

                t_lastname.Text = ListViewEx6.SelectedItems(0).SubItems(2).Text()
                t_firstname.Text = ListViewEx6.SelectedItems(0).SubItems(3).Text()
                t_middlename.Text = ListViewEx6.SelectedItems(0).SubItems(4).Text()

                i_fullname.Text = ListViewEx6.SelectedItems(0).SubItems(2).Text() + ", " + ListViewEx6.SelectedItems(0).SubItems(3).Text() + " " + ListViewEx6.SelectedItems(0).SubItems(4).Text()

                t_subjcode.Text = ListViewEx6.SelectedItems(0).SubItems(5).Text()
                t_subjdesc.Text = ListViewEx6.SelectedItems(0).SubItems(6).Text()
                t_units.Text = ListViewEx6.SelectedItems(0).SubItems(7).Text()
                t_acadyear.Text = ListViewEx6.SelectedItems(0).SubItems(8).Text()
                t_semester.Text = ListViewEx6.SelectedItems(0).SubItems(9).Text()

                t_yearlevel.Text = ListViewEx6.SelectedItems(0).SubItems(10).Text

                t_studid.Text = ListViewEx6.SelectedItems(0).SubItems(11).Text
                t_stud_name.Text = ListViewEx6.SelectedItems(0).SubItems(12).Text

                t_grades.Text = ListViewEx6.SelectedItems(0).SubItems(14).Text
                t_status.Text = ListViewEx6.SelectedItems(0).SubItems(15).Text
                t_course.Text = ListViewEx6.SelectedItems(0).SubItems(13).Text
                t_directorypath.Text = ListViewEx6.SelectedItems(0).SubItems(16).Text

                If t_directorypath.Text = Nothing Then
                    PictureBox6.Image = Nothing
                Else
                    PictureBox6.Image = Image.FromFile(t_directorypath.Text)
                End If
            Catch ex As Exception

            End Try
        End Sub


        Private Sub ButtonX6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX6.Click
            OpenFileDialog1.Filter = "image file(*.jpg, *.bmp, *.png) | *.jpg; *.bmp; *.png; | all files (*.*) | *.* "
            If OpenFileDialog1.ShowDialog <> Windows.Forms.DialogResult.Cancel Then

                PictureBox5.Image = Image.FromFile(OpenFileDialog1.FileName)

                t_directorypath.Text = OpenFileDialog1.FileName
                'PictureBox1.Image = Image.FromFile(si_photo_path_txt.Text)
            End If
        End Sub




        Private Sub ListViewEx2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
            LabelX2.Text = ListViewEx2.SelectedItems(0).Text
        End Sub

        Private Sub ListViewEx4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListViewEx4.Click
            LabelX3.Text = ListViewEx4.SelectedItems(0).Text
        End Sub


        Private Sub ListViewEx3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListViewEx3.Click
            LabelX4.Text = ListViewEx3.SelectedItems(0).Text
        End Sub


        Private Sub ListViewEx5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListViewEx5.Click
            LabelX5.Text = ListViewEx5.SelectedItems(0).Text
        End Sub


        Private Sub ListViewEx6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListViewEx6.Click
            LabelX6.Text = ListViewEx6.SelectedItems(0).Text
        End Sub

        Private Sub MetroTabItem5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles business_tab.Click
            loadregistrardata()
            loadbusinessdata()
            loadbusinessdata()
            loadguidancedata()
            loadinstructordata()
            loadgradesdata()
            loadbookstoredata()

            clear1()
            clear2()
            clear3()
            clear4()
            clear5()
            clear9()

        End Sub

        Private Sub MetroTabItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles library_tab.Click
            loadregistrardata()
            loadbusinessdata()
            loadbusinessdata()
            loadguidancedata()
            loadinstructordata()
            loadgradesdata()
            loadbookstoredata()

            clear1()
            clear2()
            clear3()
            clear4()
            clear5()
            clear9()

        End Sub

        Private Sub MetroTabItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles guidance_tab.Click
            loadregistrardata()
            loadbusinessdata()
            loadbusinessdata()
            loadguidancedata()
            loadinstructordata()
            loadgradesdata()
            loadbookstoredata()

            clear1()
            clear2()
            clear3()
            clear4()
            clear5()
            clear9()

        End Sub

        Private Sub MetroTabItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles instructor_tab.Click
            loadregistrardata()
            loadbusinessdata()
            loadbusinessdata()
            loadguidancedata()
            loadinstructordata()
            loadgradesdata()
            loadbookstoredata()

            clear1()
            clear2()
            clear3()
            clear4()
            clear5()
            clear9()

        End Sub

        Private Sub MetroTabItem6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles grades_tab.Click
            loadregistrardata()
            loadbusinessdata()
            loadbusinessdata()
            loadguidancedata()
            loadinstructordata()
            loadgradesdata()
            loadbookstoredata()

            clear1()
            clear2()
            clear3()
            clear4()
            clear5()
            clear9()

        End Sub
#Region "dummy"
        Private Sub BackgroundWorker1_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
            Try

                rs = New ADODB.Recordset
                rs.Open("SELECT * FROM `tbl_registrar` WHERE stud_id='" & _StartControl.lbl_stud_id.Text & "' ", cn, 1, 2)
                rs = New ADODB.Recordset
                rs.Open("SELECT * FROM `tbl_library` WHERE stud_id='" & _StartControl.lbl_stud_id.Text & "' ", cn, 1, 2)
                Dim y As Integer
                y = 0
                While Not rs.EOF
                    rs.MoveNext()
                    y = y + 1
                End While
                If y = 1 Then
                    rs = New ADODB.Recordset
                    rs.Open("SELECT * FROM `tbl_registrar` WHERE stud_id='" & _StartControl.lbl_stud_id.Text & "' ", cn, 1, 2)
                    _StartControl.lbl_path.Text = rs.Fields("path_image").Value.ToString
                    If _StartControl.lbl_path.Text = Nothing Then
                        _StartControl.PictureBox2.Image = Nothing
                    Else
                        _StartControl.PictureBox2.Image = Image.FromFile(_StartControl.lbl_path.Text)
                    End If
                End If

                'get max id
                'registrarSwitch.Value = False
                'businessSwitch.Value = False
                'guidanceSwitch.Value = False
                'librarySwitch.Value = False
                'bookstoreSwitch.Value = False
                'instructorSwitch.Value = False
                'LabelX11.Text = ""
                'LabelX13.Text = ""
                'LabelX14.Text = ""
                'LabelX15.Text = ""
                'LabelX17.Text = ""
                'LabelX19.Text = ""
                'businessButton.Visible = True
                'guidanceButton.Visible = True
                'libraryButton.Visible = True
                'ButtonX6.Visible = True
                'instructorButton.Visible = True



                rs = New ADODB.Recordset
                rs.Open("SELECT MAX(ID) FROM `tbl_registrar` WHERE stud_id='" & _StartControl.lbl_stud_id.Text & "' ", cn, 1, 2)


                'REGISTRAR
                Dim mxreg As Integer = rs.Fields(0).Value
                rs = New ADODB.Recordset
                rs.Open("SELECT * FROM `tbl_registrar` WHERE ID = " & mxreg, cn, 1, 2)


                'LIBRARY
                rs = New ADODB.Recordset
                rs.Open("SELECT MAX(ID) FROM `tbl_library` WHERE stud_id='" & _StartControl.lbl_stud_id.Text & "' ", cn, 1, 2)
                Dim mxlib As Integer = rs.Fields(0).Value
                rs = New ADODB.Recordset
                rs.Open("SELECT * FROM `tbl_library` WHERE ID = " & mxlib, cn, 1, 2)
                _StartControl.LabelX15.Text = rs.Fields("status").Value.ToString


                'GUIDANCE
                rs = New ADODB.Recordset
                rs.Open("SELECT MAX(ID) FROM `tbl_guidance` WHERE stud_id='" & _StartControl.lbl_stud_id.Text & "' ", cn, 1, 2)
                Dim mxgui As Integer = rs.Fields(0).Value
                rs = New ADODB.Recordset
                rs.Open("SELECT * FROM `tbl_guidance` WHERE ID = " & mxgui, cn, 1, 2)
                _StartControl.LabelX14.Text = rs.Fields("status").Value.ToString


                'BUSINESS
                rs = New ADODB.Recordset
                rs.Open("SELECT MAX(ID) FROM `tbl_business` WHERE stud_id='" & _StartControl.lbl_stud_id.Text & "' ", cn, 1, 2)
                Dim mxbus As Integer = rs.Fields(0).Value
                rs = New ADODB.Recordset
                rs.Open("SELECT * FROM `tbl_business` WHERE ID = " & mxbus, cn, 1, 2)
                LabelX13.Text = rs.Fields("status").Value.ToString


                'BOOKSTORE
                rs = New ADODB.Recordset
                rs.Open("SELECT MAX(ID) FROM `tbl_bookstore` WHERE stud_id='" & _StartControl.lbl_stud_id.Text & "' ", cn, 1, 2)
                Dim mxbook As Integer = rs.Fields(0).Value
                rs = New ADODB.Recordset
                rs.Open("SELECT * FROM `tbl_bookstore` WHERE ID = " & mxbook, cn, 1, 2)
                _StartControl.LabelX17.Text = rs.Fields("status").Value.ToString


                'display details
                _StartControl.lbl_stud_id.Text = rs.Fields("stud_id").Value.ToString
                _StartControl.lbl_student_name.Text = rs.Fields("last_name").Value.ToString + ", " & rs.Fields("first_name").Value.ToString + " " & rs.Fields("middle_name").Value.ToString
                _StartControl.lbl_course_yr.Text = rs.Fields("current_course").Value.ToString + " " & rs.Fields("year_level").Value.ToString
                _StartControl.lbl_acad_year.Text = rs.Fields("school_yr").Value.ToString
                _StartControl.lbl_semester.Text = rs.Fields("semester").Value.ToString



                'INSTRUCTOR
                rs = New ADODB.Recordset
                rs.Open("SELECT * ,(SELECT COUNT (subject_code) FROM tbl_grades WHERE stud_id='" & _StartControl.lbl_stud_id.Text & "' AND semester='" & _StartControl.lbl_semester.Text & "' and school_yr='" & _StartControl.lbl_acad_year.Text & "') as total_subjects FROM(tbl_grades)WHERE stud_id='" & _StartControl.lbl_stud_id.Text & "' AND semester='" & _StartControl.lbl_semester.Text & "' and school_yr='" & _StartControl.lbl_acad_year.Text & "' ", cn, 1, 2)
                _StartControl.lbl_count.Text = rs.Fields(0).Value.ToString

                rs = New ADODB.Recordset
                rs.Open("SELECT * ,(SELECT COUNT (status) FROM tbl_grades WHERE stud_id='" & _StartControl.lbl_stud_id.Text & "' AND semester='" & _StartControl.lbl_semester.Text & "' and school_yr='" & _StartControl.lbl_acad_year.Text & "' and status='CLEARED') as total_cleared FROM(tbl_grades)WHERE stud_id='" & _StartControl.lbl_stud_id.Text & "' AND semester='" & _StartControl.lbl_semester.Text & "' and school_yr='" & _StartControl.lbl_acad_year.Text & "' ", cn, 1, 2)
                _StartControl.lbl_count_cleared.Text = rs.Fields(0).Value.ToString

                If _StartControl.lbl_count_cleared.Text = _StartControl.lbl_count.Text Then
                    _StartControl.LabelX19.Text = "CLEARED"
                    _StartControl.instructorSwitch.Value = True
                    _StartControl.instructorButton.Visible = False
                Else
                    _StartControl.instructorSwitch.Value = False
                    _StartControl.LabelX19.Text = "NOT CLEARED"
                    _StartControl.instructorButton.Visible = True
                End If

                MsgBox("Successful!", MsgBoxStyle.Information, "SUCCESS")



                If LabelX13.Text = "CLEARED" Then
                    _StartControl.businessSwitch.Value = True
                    _StartControl.businessButton.Visible = False
                ElseIf LabelX13.Text = "NOT CLEARED" Then
                    _StartControl.businessSwitch.Value = False
                    _StartControl.businessButton.Visible = True
                End If

                If _StartControl.LabelX14.Text = "CLEARED" Then
                    _StartControl.guidanceSwitch.Value = True
                    _StartControl.guidanceButton.Visible = False
                ElseIf _StartControl.LabelX14.Text = "NOT CLEARED" Then
                    _StartControl.guidanceSwitch.Value = False
                    _StartControl.businessButton.Visible = True
                End If

                If _StartControl.LabelX15.Text = "CLEARED" Then
                    _StartControl.librarySwitch.Value = True
                    _StartControl.libraryButton.Visible = False
                ElseIf _StartControl.LabelX15.Text = "NOT CLEARED" Then
                    _StartControl.librarySwitch.Value = False
                    _StartControl.libraryButton.Visible = True
                End If

                If _StartControl.LabelX17.Text = "CLEARED" Then
                    _StartControl.bookstoreSwitch.Value = True
                    _StartControl.bookstoreButton.Visible = False
                ElseIf _StartControl.LabelX17.Text = "NOT CLEARED" Then
                    _StartControl.bookstoreSwitch.Value = False
                    _StartControl.bookstoreButton.Visible = True

                End If

                If LabelX13.Text = "CLEARED" And _StartControl.LabelX14.Text = "CLEARED" And _StartControl.LabelX15.Text = "CLEARED" And _StartControl.LabelX17.Text = "CLEARED" And _StartControl.LabelX19.Text = "CLEARED" Then
                    _StartControl.LabelX11.Text = "CLEARED"
                    _StartControl.registrarSwitch.Value = True
                Else
                    _StartControl.LabelX11.Text = "NOT CLEARD"
                    _StartControl.registrarSwitch.Value = False
                End If

                System.Threading.Thread.Sleep(1000)
            Catch ex As Exception

            End Try

        End Sub
#End Region


        Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
            Try
                loadregistrardata()
                loadbusinessdata()
                loadbusinessdata()
                loadguidancedata()
                loadinstructordata()
                loadgradesdata()
                loadbookstoredata()

            Catch ex As Exception

            End Try


        End Sub

        Private Sub MetroTabItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles registrar_tab.Click
            loadregistrardata()
            loadbusinessdata()
            loadbusinessdata()
            loadguidancedata()
            loadinstructordata()
            loadgradesdata()
            loadbookstoredata()

            clear1()
            clear2()
            clear3()
            clear4()
            clear5()
            clear9()
        End Sub

    End Class
End Namespace