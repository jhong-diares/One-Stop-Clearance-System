Imports System.ComponentModel
Imports System.Text
Imports DevComponents.DotNetBar

Namespace one_stop_clearance_system
    Partial Public Class StartControl
        Inherits DevComponents.DotNetBar.Controls.SlidePanel
        Public Sub New()
            InitializeComponent()
        End Sub
        Public _SearchControl As New SearchControl

        Protected Overrides Sub OnResize(ByVal e As EventArgs)
            ' Center the panel
            GroupPanel1.Location = New Point((Me.Width - GroupPanel1.Width) / 2 + 16, ((Me.Height - labelX1.Height - 16) - GroupPanel1.Height) / 2 + labelX1.Height + 16)
            'GroupPanel2.Location = New Point((Me.Width - GroupPanel2.Width) / 2 + 16, ((Me.Height - GroupPanel1.Height - 830) - GroupPanel2.Height) / 2 + GroupPanel1.Height + 16)
            MyBase.OnResize(e)
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
                searchButton.Command = newValue.SearchCommands.Find
                logoutButton.Command = newValue.LogoutCommands.Logout
                businessButton.Command = newValue.BusinessCommands.Display
                guidanceButton.Command = newValue.GuidanceCommands.Display
                libraryButton.Command = newValue.LibraryCommands.Display
                instructorButton.Command = newValue.InstructorCommands.Display
                bookstoreButton.Command = newValue.BookstoreCommands.Display
            Else
                searchButton.Command = Nothing
                logoutButton.Command = Nothing
                businessButton.Command = Nothing
                guidanceButton.Command = Nothing
                libraryButton.Command = Nothing
                instructorButton.Command = Nothing
                bookstoreButton.Command = Nothing
            End If
        End Sub


        Sub test123()


            'STUDENT NUMBER NOT FOUND
            rs = New ADODB.Recordset
            rs.Open("SELECT * FROM `tbl_library` WHERE stud_id='" & lbl_stud_id.Text & "' ", cn, 1, 2)
            Dim count As Integer
            count = 0
            While Not rs.EOF
                rs.MoveNext()
                count = count + 1
            End While
            If count = 0 Then
                LabelX15.Text = "CLEARED"
                librarySwitch.Value = True
                libraryButton.Visible = False
            End If




            'STUDENT NUMBER NOT FOUND
            rs = New ADODB.Recordset
            rs.Open("SELECT * FROM `tbl_guidance` WHERE stud_id='" & lbl_stud_id.Text & "' ", cn, 1, 2)
            Dim count1 As Integer
            count1 = 0
            While Not rs.EOF
                rs.MoveNext()
                count1 = count1 + 1
            End While
            If count1 = 0 Then
                LabelX14.Text = "CLEARED"
                guidanceSwitch.Value = True
                guidanceButton.Visible = False
            End If



            'STUDENT NUMBER NOT FOUND
            rs = New ADODB.Recordset
            rs.Open("SELECT * FROM `tbl_business` WHERE stud_id='" & lbl_stud_id.Text & "' ", cn, 1, 2)
            Dim count2 As Integer
            count2 = 0
            While Not rs.EOF
                rs.MoveNext()
                count2 = count2 + 1
            End While
            If count2 = 0 Then
                LabelX13.Text = "CLEARED"
                businessSwitch.Value = True
                businessButton.Visible = False
            End If



            'STUDENT NUMBER NOT FOUND
            rs = New ADODB.Recordset
            rs.Open("SELECT * FROM `tbl_bookstore` WHERE stud_id='" & lbl_stud_id.Text & "' ", cn, 1, 2)
            Dim count3 As Integer
            count3 = 0
            While Not rs.EOF
                rs.MoveNext()
                count3 = count3 + 1
            End While
            If count3 = 0 Then
                LabelX17.Text = "CLEARED"
                bookstoreSwitch.Value = True
                bookstoreButton.Visible = False

            End If




            'STUDENT NUMBER NOT FOUND
            rs = New ADODB.Recordset
            rs.Open("SELECT * FROM `tbl_grades` WHERE stud_id='" & lbl_stud_id.Text & "' ", cn, 1, 2)
            Dim count4 As Integer
            count4 = 0
            While Not rs.EOF
                rs.MoveNext()
                count4 = count4 + 1
            End While
            If count4 = 0 Then
                LabelX19.Text = "CLEARED"
                instructorSwitch.Value = True
                instructorButton.Visible = False
            End If







        End Sub




        Sub test()
            Try

                rs = New ADODB.Recordset
                rs.Open("SELECT * FROM `tbl_registrar` WHERE stud_id='" & lbl_stud_id.Text & "' ", cn, 1, 2)
                'rs = New ADODB.Recordset
                'rs.Open("SELECT * FROM `tbl_library` WHERE stud_id='" & lbl_stud_id.Text & "' ", cn, 1, 2)
                Dim y As Integer
                y = 0
                While Not rs.EOF
                    rs.MoveNext()
                    y = y + 1
                End While
                If y = 1 Then
                    rs = New ADODB.Recordset
                    rs.Open("SELECT * FROM `tbl_registrar` WHERE stud_id='" & lbl_stud_id.Text & "' ", cn, 1, 2)
                    lbl_path.Text = rs.Fields("path_image").Value.ToString
                    If lbl_path.Text = Nothing Then
                        PictureBox2.Image = Nothing
                    Else
                        PictureBox2.Image = Image.FromFile(lbl_path.Text)
                    End If
                End If




                'REGISTRAR
                rs = New ADODB.Recordset
                rs.Open("SELECT MAX(ID) FROM `tbl_registrar` WHERE stud_id='" & lbl_stud_id.Text & "' ", cn, 1, 2)
                Dim mxreg As Integer = rs.Fields(0).Value
                rs = New ADODB.Recordset
                rs.Open("SELECT * FROM `tbl_registrar` WHERE ID = " & mxreg, cn, 1, 2)

                Try
                    'LIBRARY
                    rs = New ADODB.Recordset
                    rs.Open("SELECT MAX(ID) FROM `tbl_library` WHERE stud_id='" & lbl_stud_id.Text & "' ", cn, 1, 2)
                    Dim mxlib As Integer = rs.Fields(0).Value
                    rs = New ADODB.Recordset
                    rs.Open("SELECT * FROM `tbl_library` WHERE ID = " & mxlib, cn, 1, 2)
                    LabelX15.Text = rs.Fields("status").Value.ToString
                Catch ex As Exception

                End Try

                Try
                    'GUIDANCE
                    rs = New ADODB.Recordset
                    rs.Open("SELECT MAX(ID) FROM `tbl_guidance` WHERE stud_id='" & _lbl_stud_id.Text & "' ", cn, 1, 2)
                    Dim mxgui As Integer = rs.Fields(0).Value
                    rs = New ADODB.Recordset
                    rs.Open("SELECT * FROM `tbl_guidance` WHERE ID = " & mxgui, cn, 1, 2)
                    LabelX14.Text = rs.Fields("status").Value.ToString
                Catch ex As Exception

                End Try

                Try

                    'BUSINESS
                    rs = New ADODB.Recordset
                    rs.Open("SELECT MAX(ID) FROM `tbl_business` WHERE stud_id='" & lbl_stud_id.Text & "' ", cn, 1, 2)
                    Dim mxbus As Integer = rs.Fields(0).Value
                    rs = New ADODB.Recordset
                    rs.Open("SELECT * FROM `tbl_business` WHERE ID = " & mxbus, cn, 1, 2)
                    LabelX13.Text = rs.Fields("status").Value.ToString

                Catch ex As Exception

                End Try


                Try
                    'BOOKSTORE
                    rs = New ADODB.Recordset
                    rs.Open("SELECT MAX(ID) FROM `tbl_bookstore` WHERE stud_id='" & lbl_stud_id.Text & "' ", cn, 1, 2)
                    Dim mxbook As Integer = rs.Fields(0).Value
                    rs = New ADODB.Recordset
                    rs.Open("SELECT * FROM `tbl_bookstore` WHERE ID = " & mxbook, cn, 1, 2)
                    LabelX17.Text = rs.Fields("status").Value.ToString

                Catch ex As Exception

                End Try

                'display details
                lbl_stud_id.Text = rs.Fields("stud_id").Value.ToString
                lbl_student_name.Text = rs.Fields("last_name").Value.ToString + ", " & rs.Fields("first_name").Value.ToString + " " & rs.Fields("middle_name").Value.ToString
                lbl_course_yr.Text = rs.Fields("current_course").Value.ToString + " " & rs.Fields("year_level").Value.ToString
                lbl_acad_year.Text = rs.Fields("school_yr").Value.ToString
                lbl_semester.Text = rs.Fields("semester").Value.ToString

                Try
                    'INSTRUCTOR
                    rs = New ADODB.Recordset
                    rs.Open("SELECT * ,(SELECT COUNT (subject_code) FROM tbl_grades WHERE stud_id='" & lbl_stud_id.Text & "' AND semester='" & lbl_semester.Text & "' and school_yr='" & lbl_acad_year.Text & "') as total_subjects FROM(tbl_grades)WHERE stud_id='" & lbl_stud_id.Text & "' AND semester='" & lbl_semester.Text & "' and school_yr='" & lbl_acad_year.Text & "' ", cn, 1, 2)
                    lbl_count.Text = rs.Fields(0).Value.ToString

                    rs = New ADODB.Recordset
                    rs.Open("SELECT * ,(SELECT COUNT (status) FROM tbl_grades WHERE stud_id='" & lbl_stud_id.Text & "' AND semester='" & lbl_semester.Text & "' and school_yr='" & lbl_acad_year.Text & "' and status='CLEARED') as total_cleared FROM(tbl_grades)WHERE stud_id='" & lbl_stud_id.Text & "' AND semester='" & lbl_semester.Text & "' and school_yr='" & lbl_acad_year.Text & "' ", cn, 1, 2)
                    lbl_count_cleared.Text = rs.Fields(0).Value.ToString

                Catch ex As Exception

                End Try

            Catch ex As Exception

            End Try



            If lbl_count_cleared.Text = lbl_count.Text Then
                LabelX19.Text = "CLEARED"
                instructorSwitch.Value = True
                instructorButton.Visible = False
            Else
                instructorSwitch.Value = False
                LabelX19.Text = "NOT CLEARED"
                instructorButton.Visible = True
            End If

            If LabelX13.Text = "CLEARED" Then
                businessSwitch.Value = True
                businessButton.Visible = False
            ElseIf LabelX13.Text = "NOT CLEARED" Then
                businessSwitch.Value = False
                businessButton.Visible = True
            End If

            If LabelX14.Text = "CLEARED" Then
                guidanceSwitch.Value = True
                guidanceButton.Visible = False
            ElseIf LabelX14.Text = "NOT CLEARED" Then
                guidanceSwitch.Value = False
                businessButton.Visible = True
            End If

            If LabelX15.Text = "CLEARED" Then
                librarySwitch.Value = True
                libraryButton.Visible = False
            ElseIf LabelX15.Text = "NOT CLEARED" Then
                librarySwitch.Value = False
                libraryButton.Visible = True
            End If

            If LabelX17.Text = "CLEARED" Then
                bookstoreSwitch.Value = True
                bookstoreButton.Visible = False
            ElseIf LabelX17.Text = "NOT CLEARED" Then
                bookstoreSwitch.Value = False
                bookstoreButton.Visible = True
            End If

            If LabelX13.Text = "CLEARED" And LabelX14.Text = "CLEARED" And LabelX15.Text = "CLEARED" And LabelX17.Text = "CLEARED" And LabelX19.Text = "CLEARED" Then
                LabelX11.Text = "CLEARED"
                registrarSwitch.Value = True
            Else
                LabelX11.Text = "NOT CLEARED"
                registrarSwitch.Value = False
            End If



        End Sub


        Private Sub ButtonX1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX1.Click
            test()

        End Sub


        Private Sub BackgroundWorker1_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
            test()
        End Sub

        Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
            test()
            test123()
        End Sub

        Private Sub ButtonX6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bookstoreButton.Click

        End Sub

    End Class
End Namespace
