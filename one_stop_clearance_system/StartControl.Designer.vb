Namespace one_stop_clearance_system
    Partial Public Class StartControl
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
            Me.components = New System.ComponentModel.Container()
            Me.labelX1 = New DevComponents.DotNetBar.LabelX()
            Me.pic_emp = New System.Windows.Forms.PictureBox()
            Me.chartUpdateTimer = New System.Windows.Forms.Timer(Me.components)
            Me.logoutButton = New DevComponents.DotNetBar.ButtonX()
            Me.registrarSwitch = New DevComponents.DotNetBar.Controls.SwitchButton()
            Me.LabelX3 = New DevComponents.DotNetBar.LabelX()
            Me.LabelX4 = New DevComponents.DotNetBar.LabelX()
            Me.businessSwitch = New DevComponents.DotNetBar.Controls.SwitchButton()
            Me.LabelX5 = New DevComponents.DotNetBar.LabelX()
            Me.guidanceSwitch = New DevComponents.DotNetBar.Controls.SwitchButton()
            Me.LabelX6 = New DevComponents.DotNetBar.LabelX()
            Me.LabelX7 = New DevComponents.DotNetBar.LabelX()
            Me.librarySwitch = New DevComponents.DotNetBar.Controls.SwitchButton()
            Me.bookstoreSwitch = New DevComponents.DotNetBar.Controls.SwitchButton()
            Me.LabelX8 = New DevComponents.DotNetBar.LabelX()
            Me.LabelX9 = New DevComponents.DotNetBar.LabelX()
            Me.LabelX10 = New DevComponents.DotNetBar.LabelX()
            Me.GroupPanel1 = New DevComponents.DotNetBar.Controls.GroupPanel()
            Me.ButtonX1 = New DevComponents.DotNetBar.ButtonX()
            Me.PictureBox2 = New System.Windows.Forms.PictureBox()
            Me.lbl_count_cleared = New DevComponents.DotNetBar.LabelX()
            Me.lbl_count = New DevComponents.DotNetBar.LabelX()
            Me.LabelX19 = New DevComponents.DotNetBar.LabelX()
            Me.LabelX17 = New DevComponents.DotNetBar.LabelX()
            Me.LabelX15 = New DevComponents.DotNetBar.LabelX()
            Me.LabelX14 = New DevComponents.DotNetBar.LabelX()
            Me.LabelX13 = New DevComponents.DotNetBar.LabelX()
            Me.LabelX11 = New DevComponents.DotNetBar.LabelX()
            Me.searchButton = New DevComponents.DotNetBar.ButtonX()
            Me.lbl_semester = New DevComponents.DotNetBar.LabelX()
            Me.LabelX21 = New DevComponents.DotNetBar.LabelX()
            Me.lbl_acad_year = New DevComponents.DotNetBar.LabelX()
            Me.LabelX18 = New DevComponents.DotNetBar.LabelX()
            Me.lbl_course_yr = New DevComponents.DotNetBar.LabelX()
            Me.LabelX16 = New DevComponents.DotNetBar.LabelX()
            Me.lbl_student_name = New DevComponents.DotNetBar.LabelX()
            Me.lbl_stud_id = New DevComponents.DotNetBar.LabelX()
            Me.instructorButton = New DevComponents.DotNetBar.ButtonX()
            Me.instructorSwitch = New DevComponents.DotNetBar.Controls.SwitchButton()
            Me.LabelX12 = New DevComponents.DotNetBar.LabelX()
            Me.bookstoreButton = New DevComponents.DotNetBar.ButtonX()
            Me.libraryButton = New DevComponents.DotNetBar.ButtonX()
            Me.guidanceButton = New DevComponents.DotNetBar.ButtonX()
            Me.businessButton = New DevComponents.DotNetBar.ButtonX()
            Me.LabelX20 = New DevComponents.DotNetBar.LabelX()
            Me.TblregistrarBindingSource = New System.Windows.Forms.BindingSource(Me.components)
            Me.lbl_path = New DevComponents.DotNetBar.LabelX()
            Me.lbl_path2 = New DevComponents.DotNetBar.LabelX()
            Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
            Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
            CType(Me.pic_emp, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.GroupPanel1.SuspendLayout()
            CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.TblregistrarBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'labelX1
            '
            Me.labelX1.BackColor = System.Drawing.Color.Transparent
            '
            '
            '
            Me.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.labelX1.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.labelX1.Location = New System.Drawing.Point(19, 7)
            Me.labelX1.Name = "labelX1"
            Me.labelX1.Size = New System.Drawing.Size(248, 87)
            Me.labelX1.TabIndex = 2
            Me.labelX1.Text = "One-Stop Clearance<br/> System"
            '
            'pic_emp
            '
            Me.pic_emp.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.pic_emp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
            Me.pic_emp.Location = New System.Drawing.Point(808, 21)
            Me.pic_emp.Name = "pic_emp"
            Me.pic_emp.Size = New System.Drawing.Size(44, 33)
            Me.pic_emp.TabIndex = 5
            Me.pic_emp.TabStop = False
            '
            'chartUpdateTimer
            '
            Me.chartUpdateTimer.Enabled = True
            Me.chartUpdateTimer.Interval = 10000
            '
            'logoutButton
            '
            Me.logoutButton.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
            Me.logoutButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.logoutButton.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
            Me.logoutButton.Location = New System.Drawing.Point(726, 60)
            Me.logoutButton.Name = "logoutButton"
            Me.logoutButton.Size = New System.Drawing.Size(110, 23)
            Me.logoutButton.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
            Me.logoutButton.TabIndex = 0
            Me.logoutButton.Text = "Logout"
            '
            'registrarSwitch
            '
            '
            '
            '
            Me.registrarSwitch.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.registrarSwitch.Location = New System.Drawing.Point(196, 173)
            Me.registrarSwitch.Name = "registrarSwitch"
            Me.registrarSwitch.OffBackColor = System.Drawing.Color.Red
            Me.registrarSwitch.OffText = "NOT CLEARED"
            Me.registrarSwitch.OffTextColor = System.Drawing.Color.Black
            Me.registrarSwitch.OnBackColor = System.Drawing.Color.Chartreuse
            Me.registrarSwitch.OnText = "CLEARED"
            Me.registrarSwitch.OnTextColor = System.Drawing.Color.Black
            Me.registrarSwitch.Size = New System.Drawing.Size(163, 22)
            Me.registrarSwitch.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
            Me.registrarSwitch.SwitchBorderColor = System.Drawing.Color.Black
            Me.registrarSwitch.TabIndex = 7
            '
            'LabelX3
            '
            Me.LabelX3.BackColor = System.Drawing.Color.Transparent
            '
            '
            '
            Me.LabelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.LabelX3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.LabelX3.Location = New System.Drawing.Point(39, 173)
            Me.LabelX3.Name = "LabelX3"
            Me.LabelX3.Size = New System.Drawing.Size(145, 23)
            Me.LabelX3.TabIndex = 8
            Me.LabelX3.Text = "REGISTRAR OFFICE: "
            '
            'LabelX4
            '
            Me.LabelX4.BackColor = System.Drawing.Color.Transparent
            '
            '
            '
            Me.LabelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.LabelX4.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.LabelX4.Location = New System.Drawing.Point(39, 201)
            Me.LabelX4.Name = "LabelX4"
            Me.LabelX4.Size = New System.Drawing.Size(145, 23)
            Me.LabelX4.TabIndex = 10
            Me.LabelX4.Text = "BUSINESS OFFICE: "
            '
            'businessSwitch
            '
            '
            '
            '
            Me.businessSwitch.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.businessSwitch.Location = New System.Drawing.Point(196, 201)
            Me.businessSwitch.Name = "businessSwitch"
            Me.businessSwitch.OffBackColor = System.Drawing.Color.Red
            Me.businessSwitch.OffText = "NOT CLEARED"
            Me.businessSwitch.OnBackColor = System.Drawing.Color.Chartreuse
            Me.businessSwitch.OnText = "CLEARED"
            Me.businessSwitch.OnTextColor = System.Drawing.Color.Black
            Me.businessSwitch.Size = New System.Drawing.Size(163, 22)
            Me.businessSwitch.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
            Me.businessSwitch.SwitchBorderColor = System.Drawing.Color.Black
            Me.businessSwitch.TabIndex = 9
            '
            'LabelX5
            '
            Me.LabelX5.BackColor = System.Drawing.Color.Transparent
            '
            '
            '
            Me.LabelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.LabelX5.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.LabelX5.Location = New System.Drawing.Point(39, 229)
            Me.LabelX5.Name = "LabelX5"
            Me.LabelX5.Size = New System.Drawing.Size(145, 23)
            Me.LabelX5.TabIndex = 12
            Me.LabelX5.Text = "STUDENT SERVICES"
            '
            'guidanceSwitch
            '
            '
            '
            '
            Me.guidanceSwitch.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.guidanceSwitch.Location = New System.Drawing.Point(196, 258)
            Me.guidanceSwitch.Name = "guidanceSwitch"
            Me.guidanceSwitch.OffBackColor = System.Drawing.Color.Red
            Me.guidanceSwitch.OffText = "NOT CLEARED"
            Me.guidanceSwitch.OnBackColor = System.Drawing.Color.Chartreuse
            Me.guidanceSwitch.OnText = "CLEARED"
            Me.guidanceSwitch.OnTextColor = System.Drawing.Color.Black
            Me.guidanceSwitch.Size = New System.Drawing.Size(163, 22)
            Me.guidanceSwitch.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
            Me.guidanceSwitch.SwitchBorderColor = System.Drawing.Color.Black
            Me.guidanceSwitch.TabIndex = 11
            '
            'LabelX6
            '
            Me.LabelX6.BackColor = System.Drawing.Color.Transparent
            '
            '
            '
            Me.LabelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.LabelX6.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.LabelX6.Location = New System.Drawing.Point(67, 258)
            Me.LabelX6.Name = "LabelX6"
            Me.LabelX6.Size = New System.Drawing.Size(123, 23)
            Me.LabelX6.TabIndex = 13
            Me.LabelX6.Text = "Guidance Office:"
            '
            'LabelX7
            '
            Me.LabelX7.BackColor = System.Drawing.Color.Transparent
            '
            '
            '
            Me.LabelX7.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.LabelX7.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.LabelX7.Location = New System.Drawing.Point(67, 287)
            Me.LabelX7.Name = "LabelX7"
            Me.LabelX7.Size = New System.Drawing.Size(117, 23)
            Me.LabelX7.TabIndex = 14
            Me.LabelX7.Text = "Library:"
            '
            'librarySwitch
            '
            '
            '
            '
            Me.librarySwitch.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.librarySwitch.Location = New System.Drawing.Point(196, 286)
            Me.librarySwitch.Name = "librarySwitch"
            Me.librarySwitch.OffBackColor = System.Drawing.Color.Red
            Me.librarySwitch.OffText = "NOT CLEARED"
            Me.librarySwitch.OnBackColor = System.Drawing.Color.Chartreuse
            Me.librarySwitch.OnText = "CLEARED"
            Me.librarySwitch.OnTextColor = System.Drawing.Color.Black
            Me.librarySwitch.Size = New System.Drawing.Size(163, 22)
            Me.librarySwitch.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
            Me.librarySwitch.SwitchBorderColor = System.Drawing.Color.Black
            Me.librarySwitch.TabIndex = 15
            '
            'bookstoreSwitch
            '
            '
            '
            '
            Me.bookstoreSwitch.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.bookstoreSwitch.Location = New System.Drawing.Point(196, 314)
            Me.bookstoreSwitch.Name = "bookstoreSwitch"
            Me.bookstoreSwitch.OffBackColor = System.Drawing.Color.Red
            Me.bookstoreSwitch.OffText = "NOT CLEARED"
            Me.bookstoreSwitch.OnBackColor = System.Drawing.Color.Chartreuse
            Me.bookstoreSwitch.OnText = "CLEARED"
            Me.bookstoreSwitch.OnTextColor = System.Drawing.Color.Black
            Me.bookstoreSwitch.Size = New System.Drawing.Size(163, 22)
            Me.bookstoreSwitch.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
            Me.bookstoreSwitch.SwitchBorderColor = System.Drawing.Color.Black
            Me.bookstoreSwitch.TabIndex = 17
            '
            'LabelX8
            '
            Me.LabelX8.BackColor = System.Drawing.Color.Transparent
            '
            '
            '
            Me.LabelX8.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.LabelX8.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.LabelX8.Location = New System.Drawing.Point(67, 315)
            Me.LabelX8.Name = "LabelX8"
            Me.LabelX8.Size = New System.Drawing.Size(123, 23)
            Me.LabelX8.TabIndex = 16
            Me.LabelX8.Text = "Bookstore:"
            '
            'LabelX9
            '
            Me.LabelX9.BackColor = System.Drawing.Color.Transparent
            '
            '
            '
            Me.LabelX9.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.LabelX9.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.LabelX9.Location = New System.Drawing.Point(39, 19)
            Me.LabelX9.Name = "LabelX9"
            Me.LabelX9.Size = New System.Drawing.Size(44, 23)
            Me.LabelX9.TabIndex = 20
            Me.LabelX9.Text = "Student ID:"
            '
            'LabelX10
            '
            Me.LabelX10.BackColor = System.Drawing.Color.Transparent
            '
            '
            '
            Me.LabelX10.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.LabelX10.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.LabelX10.Location = New System.Drawing.Point(39, 48)
            Me.LabelX10.Name = "LabelX10"
            Me.LabelX10.Size = New System.Drawing.Size(44, 23)
            Me.LabelX10.TabIndex = 21
            Me.LabelX10.Text = "Student's Name:"
            '
            'GroupPanel1
            '
            Me.GroupPanel1.BackColor = System.Drawing.Color.Transparent
            Me.GroupPanel1.CanvasColor = System.Drawing.Color.Transparent
            Me.GroupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
            Me.GroupPanel1.Controls.Add(Me.ButtonX1)
            Me.GroupPanel1.Controls.Add(Me.PictureBox2)
            Me.GroupPanel1.Controls.Add(Me.lbl_count_cleared)
            Me.GroupPanel1.Controls.Add(Me.lbl_count)
            Me.GroupPanel1.Controls.Add(Me.LabelX19)
            Me.GroupPanel1.Controls.Add(Me.LabelX17)
            Me.GroupPanel1.Controls.Add(Me.LabelX15)
            Me.GroupPanel1.Controls.Add(Me.LabelX14)
            Me.GroupPanel1.Controls.Add(Me.LabelX13)
            Me.GroupPanel1.Controls.Add(Me.LabelX11)
            Me.GroupPanel1.Controls.Add(Me.searchButton)
            Me.GroupPanel1.Controls.Add(Me.lbl_semester)
            Me.GroupPanel1.Controls.Add(Me.LabelX21)
            Me.GroupPanel1.Controls.Add(Me.lbl_acad_year)
            Me.GroupPanel1.Controls.Add(Me.LabelX18)
            Me.GroupPanel1.Controls.Add(Me.lbl_course_yr)
            Me.GroupPanel1.Controls.Add(Me.LabelX16)
            Me.GroupPanel1.Controls.Add(Me.lbl_student_name)
            Me.GroupPanel1.Controls.Add(Me.lbl_stud_id)
            Me.GroupPanel1.Controls.Add(Me.instructorButton)
            Me.GroupPanel1.Controls.Add(Me.instructorSwitch)
            Me.GroupPanel1.Controls.Add(Me.LabelX12)
            Me.GroupPanel1.Controls.Add(Me.LabelX9)
            Me.GroupPanel1.Controls.Add(Me.bookstoreButton)
            Me.GroupPanel1.Controls.Add(Me.libraryButton)
            Me.GroupPanel1.Controls.Add(Me.guidanceButton)
            Me.GroupPanel1.Controls.Add(Me.businessButton)
            Me.GroupPanel1.Controls.Add(Me.bookstoreSwitch)
            Me.GroupPanel1.Controls.Add(Me.LabelX10)
            Me.GroupPanel1.Controls.Add(Me.LabelX8)
            Me.GroupPanel1.Controls.Add(Me.librarySwitch)
            Me.GroupPanel1.Controls.Add(Me.LabelX7)
            Me.GroupPanel1.Controls.Add(Me.LabelX6)
            Me.GroupPanel1.Controls.Add(Me.LabelX5)
            Me.GroupPanel1.Controls.Add(Me.guidanceSwitch)
            Me.GroupPanel1.Controls.Add(Me.LabelX4)
            Me.GroupPanel1.Controls.Add(Me.businessSwitch)
            Me.GroupPanel1.Controls.Add(Me.LabelX3)
            Me.GroupPanel1.Controls.Add(Me.registrarSwitch)
            Me.GroupPanel1.DisabledBackColor = System.Drawing.Color.Empty
            Me.GroupPanel1.Location = New System.Drawing.Point(3, 100)
            Me.GroupPanel1.Name = "GroupPanel1"
            Me.GroupPanel1.Size = New System.Drawing.Size(487, 399)
            '
            '
            '
            Me.GroupPanel1.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
            Me.GroupPanel1.Style.BackColorGradientAngle = 90
            Me.GroupPanel1.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
            Me.GroupPanel1.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
            Me.GroupPanel1.Style.BorderBottomWidth = 1
            Me.GroupPanel1.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
            Me.GroupPanel1.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
            Me.GroupPanel1.Style.BorderLeftWidth = 1
            Me.GroupPanel1.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
            Me.GroupPanel1.Style.BorderRightWidth = 1
            Me.GroupPanel1.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
            Me.GroupPanel1.Style.BorderTopWidth = 1
            Me.GroupPanel1.Style.CornerDiameter = 4
            Me.GroupPanel1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
            Me.GroupPanel1.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
            Me.GroupPanel1.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
            Me.GroupPanel1.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
            '
            '
            '
            Me.GroupPanel1.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
            '
            '
            '
            Me.GroupPanel1.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.GroupPanel1.TabIndex = 23
            Me.GroupPanel1.Text = "STUDENT INFORMATION"
            '
            'ButtonX1
            '
            Me.ButtonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
            Me.ButtonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
            Me.ButtonX1.Enabled = False
            Me.ButtonX1.Location = New System.Drawing.Point(3, 296)
            Me.ButtonX1.Name = "ButtonX1"
            Me.ButtonX1.Size = New System.Drawing.Size(10, 23)
            Me.ButtonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
            Me.ButtonX1.TabIndex = 54
            Me.ButtonX1.Text = "Test"
            Me.ButtonX1.Visible = False
            '
            'PictureBox2
            '
            Me.PictureBox2.Location = New System.Drawing.Point(24, 16)
            Me.PictureBox2.Name = "PictureBox2"
            Me.PictureBox2.Size = New System.Drawing.Size(159, 140)
            Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
            Me.PictureBox2.TabIndex = 51
            Me.PictureBox2.TabStop = False
            '
            'lbl_count_cleared
            '
            '
            '
            '
            Me.lbl_count_cleared.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.lbl_count_cleared.Location = New System.Drawing.Point(426, 77)
            Me.lbl_count_cleared.Name = "lbl_count_cleared"
            Me.lbl_count_cleared.Size = New System.Drawing.Size(40, 23)
            Me.lbl_count_cleared.TabIndex = 50
            Me.lbl_count_cleared.Text = "LabelX20"
            Me.lbl_count_cleared.Visible = False
            '
            'lbl_count
            '
            '
            '
            '
            Me.lbl_count.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.lbl_count.Location = New System.Drawing.Point(426, 40)
            Me.lbl_count.Name = "lbl_count"
            Me.lbl_count.Size = New System.Drawing.Size(40, 31)
            Me.lbl_count.TabIndex = 49
            Me.lbl_count.Text = "LabelX20"
            Me.lbl_count.Visible = False
            '
            'LabelX19
            '
            '
            '
            '
            Me.LabelX19.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.LabelX19.Location = New System.Drawing.Point(365, 342)
            Me.LabelX19.Name = "LabelX19"
            Me.LabelX19.Size = New System.Drawing.Size(44, 23)
            Me.LabelX19.TabIndex = 48
            Me.LabelX19.Text = "LabelX19"
            Me.LabelX19.Visible = False
            '
            'LabelX17
            '
            '
            '
            '
            Me.LabelX17.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.LabelX17.Location = New System.Drawing.Point(365, 313)
            Me.LabelX17.Name = "LabelX17"
            Me.LabelX17.Size = New System.Drawing.Size(44, 23)
            Me.LabelX17.TabIndex = 47
            Me.LabelX17.Text = "LabelX17"
            Me.LabelX17.Visible = False
            '
            'LabelX15
            '
            '
            '
            '
            Me.LabelX15.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.LabelX15.Location = New System.Drawing.Point(365, 285)
            Me.LabelX15.Name = "LabelX15"
            Me.LabelX15.Size = New System.Drawing.Size(44, 23)
            Me.LabelX15.TabIndex = 46
            Me.LabelX15.Text = "LabelX15"
            Me.LabelX15.Visible = False
            '
            'LabelX14
            '
            '
            '
            '
            Me.LabelX14.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.LabelX14.Location = New System.Drawing.Point(365, 257)
            Me.LabelX14.Name = "LabelX14"
            Me.LabelX14.Size = New System.Drawing.Size(44, 23)
            Me.LabelX14.TabIndex = 45
            Me.LabelX14.Text = "LabelX14"
            Me.LabelX14.Visible = False
            '
            'LabelX13
            '
            '
            '
            '
            Me.LabelX13.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.LabelX13.Location = New System.Drawing.Point(365, 200)
            Me.LabelX13.Name = "LabelX13"
            Me.LabelX13.Size = New System.Drawing.Size(44, 23)
            Me.LabelX13.TabIndex = 44
            Me.LabelX13.Text = "LabelX13"
            Me.LabelX13.Visible = False
            '
            'LabelX11
            '
            '
            '
            '
            Me.LabelX11.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.LabelX11.Location = New System.Drawing.Point(365, 174)
            Me.LabelX11.Name = "LabelX11"
            Me.LabelX11.Size = New System.Drawing.Size(44, 23)
            Me.LabelX11.TabIndex = 43
            Me.LabelX11.Text = "LabelX11"
            Me.LabelX11.Visible = False
            '
            'searchButton
            '
            Me.searchButton.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
            Me.searchButton.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
            Me.searchButton.Location = New System.Drawing.Point(333, 19)
            Me.searchButton.Name = "searchButton"
            Me.searchButton.Size = New System.Drawing.Size(26, 23)
            Me.searchButton.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
            Me.searchButton.Symbol = ""
            Me.searchButton.TabIndex = 42
            '
            'lbl_semester
            '
            Me.lbl_semester.BackColor = System.Drawing.Color.Transparent
            '
            '
            '
            Me.lbl_semester.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.lbl_semester.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lbl_semester.Location = New System.Drawing.Point(196, 134)
            Me.lbl_semester.Name = "lbl_semester"
            Me.lbl_semester.Size = New System.Drawing.Size(184, 23)
            Me.lbl_semester.TabIndex = 41
            Me.lbl_semester.Text = "NOT AVAILABLE"
            '
            'LabelX21
            '
            Me.LabelX21.BackColor = System.Drawing.Color.Transparent
            '
            '
            '
            Me.LabelX21.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.LabelX21.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.LabelX21.Location = New System.Drawing.Point(39, 135)
            Me.LabelX21.Name = "LabelX21"
            Me.LabelX21.Size = New System.Drawing.Size(44, 23)
            Me.LabelX21.TabIndex = 40
            Me.LabelX21.Text = "Semester:"
            '
            'lbl_acad_year
            '
            Me.lbl_acad_year.BackColor = System.Drawing.Color.Transparent
            '
            '
            '
            Me.lbl_acad_year.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.lbl_acad_year.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lbl_acad_year.Location = New System.Drawing.Point(196, 105)
            Me.lbl_acad_year.Name = "lbl_acad_year"
            Me.lbl_acad_year.Size = New System.Drawing.Size(184, 23)
            Me.lbl_acad_year.TabIndex = 39
            Me.lbl_acad_year.Text = "NOT AVAILABLE"
            '
            'LabelX18
            '
            Me.LabelX18.BackColor = System.Drawing.Color.Transparent
            '
            '
            '
            Me.LabelX18.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.LabelX18.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.LabelX18.Location = New System.Drawing.Point(39, 106)
            Me.LabelX18.Name = "LabelX18"
            Me.LabelX18.Size = New System.Drawing.Size(44, 23)
            Me.LabelX18.TabIndex = 37
            Me.LabelX18.Text = "Academic Year:"
            '
            'lbl_course_yr
            '
            Me.lbl_course_yr.BackColor = System.Drawing.Color.Transparent
            '
            '
            '
            Me.lbl_course_yr.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.lbl_course_yr.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lbl_course_yr.Location = New System.Drawing.Point(196, 77)
            Me.lbl_course_yr.Name = "lbl_course_yr"
            Me.lbl_course_yr.Size = New System.Drawing.Size(184, 23)
            Me.lbl_course_yr.TabIndex = 36
            Me.lbl_course_yr.Text = "NOT AVAILABLE"
            '
            'LabelX16
            '
            Me.LabelX16.BackColor = System.Drawing.Color.Transparent
            '
            '
            '
            Me.LabelX16.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.LabelX16.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.LabelX16.Location = New System.Drawing.Point(39, 77)
            Me.LabelX16.Name = "LabelX16"
            Me.LabelX16.Size = New System.Drawing.Size(44, 23)
            Me.LabelX16.TabIndex = 35
            Me.LabelX16.Text = "Course & Yr:"
            '
            'lbl_student_name
            '
            Me.lbl_student_name.BackColor = System.Drawing.Color.Transparent
            '
            '
            '
            Me.lbl_student_name.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.lbl_student_name.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lbl_student_name.Location = New System.Drawing.Point(196, 48)
            Me.lbl_student_name.Name = "lbl_student_name"
            Me.lbl_student_name.Size = New System.Drawing.Size(327, 23)
            Me.lbl_student_name.TabIndex = 34
            Me.lbl_student_name.Text = "NOT AVAILABLE"
            '
            'lbl_stud_id
            '
            Me.lbl_stud_id.BackColor = System.Drawing.Color.Transparent
            '
            '
            '
            Me.lbl_stud_id.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.lbl_stud_id.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lbl_stud_id.Location = New System.Drawing.Point(196, 19)
            Me.lbl_stud_id.Name = "lbl_stud_id"
            Me.lbl_stud_id.Size = New System.Drawing.Size(131, 23)
            Me.lbl_stud_id.TabIndex = 33
            Me.lbl_stud_id.Text = "NOT AVAILABLE"
            '
            'instructorButton
            '
            Me.instructorButton.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
            Me.instructorButton.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
            Me.instructorButton.Location = New System.Drawing.Point(365, 342)
            Me.instructorButton.Name = "instructorButton"
            Me.instructorButton.Size = New System.Drawing.Size(75, 23)
            Me.instructorButton.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
            Me.instructorButton.TabIndex = 32
            Me.instructorButton.Text = "Details"
            Me.instructorButton.Visible = False
            '
            'instructorSwitch
            '
            '
            '
            '
            Me.instructorSwitch.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.instructorSwitch.Location = New System.Drawing.Point(196, 342)
            Me.instructorSwitch.Name = "instructorSwitch"
            Me.instructorSwitch.OffBackColor = System.Drawing.Color.Red
            Me.instructorSwitch.OffText = "NOT CLEARED"
            Me.instructorSwitch.OnBackColor = System.Drawing.Color.Chartreuse
            Me.instructorSwitch.OnText = "CLEARED"
            Me.instructorSwitch.OnTextColor = System.Drawing.Color.Black
            Me.instructorSwitch.Size = New System.Drawing.Size(163, 22)
            Me.instructorSwitch.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
            Me.instructorSwitch.SwitchBorderColor = System.Drawing.Color.Black
            Me.instructorSwitch.TabIndex = 31
            '
            'LabelX12
            '
            Me.LabelX12.BackColor = System.Drawing.Color.Transparent
            '
            '
            '
            Me.LabelX12.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.LabelX12.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.LabelX12.Location = New System.Drawing.Point(67, 343)
            Me.LabelX12.Name = "LabelX12"
            Me.LabelX12.Size = New System.Drawing.Size(123, 23)
            Me.LabelX12.TabIndex = 30
            Me.LabelX12.Text = "Instructor(s):"
            '
            'bookstoreButton
            '
            Me.bookstoreButton.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
            Me.bookstoreButton.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
            Me.bookstoreButton.Location = New System.Drawing.Point(365, 314)
            Me.bookstoreButton.Name = "bookstoreButton"
            Me.bookstoreButton.Size = New System.Drawing.Size(75, 23)
            Me.bookstoreButton.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
            Me.bookstoreButton.TabIndex = 27
            Me.bookstoreButton.Text = "Details"
            Me.bookstoreButton.Visible = False
            '
            'libraryButton
            '
            Me.libraryButton.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
            Me.libraryButton.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
            Me.libraryButton.Location = New System.Drawing.Point(365, 286)
            Me.libraryButton.Name = "libraryButton"
            Me.libraryButton.Size = New System.Drawing.Size(75, 23)
            Me.libraryButton.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
            Me.libraryButton.TabIndex = 26
            Me.libraryButton.Text = "Details"
            Me.libraryButton.Visible = False
            '
            'guidanceButton
            '
            Me.guidanceButton.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
            Me.guidanceButton.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
            Me.guidanceButton.Location = New System.Drawing.Point(365, 257)
            Me.guidanceButton.Name = "guidanceButton"
            Me.guidanceButton.Size = New System.Drawing.Size(75, 23)
            Me.guidanceButton.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
            Me.guidanceButton.TabIndex = 25
            Me.guidanceButton.Text = "Details"
            Me.guidanceButton.Visible = False
            '
            'businessButton
            '
            Me.businessButton.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
            Me.businessButton.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
            Me.businessButton.Location = New System.Drawing.Point(365, 201)
            Me.businessButton.Name = "businessButton"
            Me.businessButton.Size = New System.Drawing.Size(75, 23)
            Me.businessButton.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
            Me.businessButton.TabIndex = 24
            Me.businessButton.Text = "Details"
            Me.businessButton.Visible = False
            '
            'LabelX20
            '
            Me.LabelX20.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.LabelX20.BackColor = System.Drawing.Color.Transparent
            '
            '
            '
            Me.LabelX20.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.LabelX20.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
            Me.LabelX20.Location = New System.Drawing.Point(621, 14)
            Me.LabelX20.Name = "LabelX20"
            Me.LabelX20.Size = New System.Drawing.Size(181, 40)
            Me.LabelX20.TabIndex = 24
            Me.LabelX20.TextAlignment = System.Drawing.StringAlignment.Far
            '
            'TblregistrarBindingSource
            '
            Me.TblregistrarBindingSource.DataMember = "tbl_registrar"
            '
            'lbl_path
            '
            '
            '
            '
            Me.lbl_path.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.lbl_path.Enabled = False
            Me.lbl_path.Location = New System.Drawing.Point(354, 253)
            Me.lbl_path.Name = "lbl_path"
            Me.lbl_path.Size = New System.Drawing.Size(92, 23)
            Me.lbl_path.TabIndex = 52
            Me.lbl_path.Text = "LabelX2"
            Me.lbl_path.Visible = False
            '
            'lbl_path2
            '
            '
            '
            '
            Me.lbl_path2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.lbl_path2.Enabled = False
            Me.lbl_path2.Location = New System.Drawing.Point(572, 160)
            Me.lbl_path2.Name = "lbl_path2"
            Me.lbl_path2.Size = New System.Drawing.Size(176, 23)
            Me.lbl_path2.TabIndex = 53
            Me.lbl_path2.Text = "LabelX2"
            Me.lbl_path2.Visible = False
            '
            'BackgroundWorker1
            '
            '
            'Timer1
            '
            Me.Timer1.Enabled = True
            Me.Timer1.Interval = 500
            '
            'StartControl
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
            Me.Controls.Add(Me.lbl_path2)
            Me.Controls.Add(Me.lbl_path)
            Me.Controls.Add(Me.LabelX20)
            Me.Controls.Add(Me.logoutButton)
            Me.Controls.Add(Me.labelX1)
            Me.Controls.Add(Me.pic_emp)
            Me.Controls.Add(Me.GroupPanel1)
            Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Name = "StartControl"
            Me.Size = New System.Drawing.Size(855, 517)
            CType(Me.pic_emp, System.ComponentModel.ISupportInitialize).EndInit()
            Me.GroupPanel1.ResumeLayout(False)
            CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.TblregistrarBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

#End Region

        Private labelX1 As DevComponents.DotNetBar.LabelX
        Private WithEvents chartUpdateTimer As Timer
        Friend WithEvents logoutButton As DevComponents.DotNetBar.ButtonX
        Friend WithEvents registrarSwitch As DevComponents.DotNetBar.Controls.SwitchButton
        Friend WithEvents LabelX3 As DevComponents.DotNetBar.LabelX
        Friend WithEvents businessSwitch As DevComponents.DotNetBar.Controls.SwitchButton
        Friend WithEvents LabelX4 As DevComponents.DotNetBar.LabelX
        Friend WithEvents guidanceSwitch As DevComponents.DotNetBar.Controls.SwitchButton
        Friend WithEvents LabelX5 As DevComponents.DotNetBar.LabelX
        Friend WithEvents LabelX6 As DevComponents.DotNetBar.LabelX
        Friend WithEvents LabelX7 As DevComponents.DotNetBar.LabelX
        Friend WithEvents librarySwitch As DevComponents.DotNetBar.Controls.SwitchButton
        Friend WithEvents bookstoreSwitch As DevComponents.DotNetBar.Controls.SwitchButton
        Friend WithEvents LabelX8 As DevComponents.DotNetBar.LabelX
        Friend WithEvents LabelX9 As DevComponents.DotNetBar.LabelX
        Friend WithEvents LabelX10 As DevComponents.DotNetBar.LabelX
        Friend WithEvents GroupPanel1 As DevComponents.DotNetBar.Controls.GroupPanel
        Friend WithEvents bookstoreButton As DevComponents.DotNetBar.ButtonX
        Friend WithEvents libraryButton As DevComponents.DotNetBar.ButtonX
        Friend WithEvents guidanceButton As DevComponents.DotNetBar.ButtonX
        Friend WithEvents businessButton As DevComponents.DotNetBar.ButtonX
        Friend WithEvents instructorButton As DevComponents.DotNetBar.ButtonX
        Friend WithEvents instructorSwitch As DevComponents.DotNetBar.Controls.SwitchButton
        Friend WithEvents LabelX12 As DevComponents.DotNetBar.LabelX
        Friend WithEvents LabelX18 As DevComponents.DotNetBar.LabelX
        Friend WithEvents lbl_course_yr As DevComponents.DotNetBar.LabelX
        Friend WithEvents LabelX16 As DevComponents.DotNetBar.LabelX
        Friend WithEvents lbl_student_name As DevComponents.DotNetBar.LabelX
        Friend WithEvents lbl_stud_id As DevComponents.DotNetBar.LabelX
        Friend WithEvents lbl_acad_year As DevComponents.DotNetBar.LabelX
        Friend WithEvents lbl_semester As DevComponents.DotNetBar.LabelX
        Friend WithEvents LabelX21 As DevComponents.DotNetBar.LabelX
        Friend WithEvents searchButton As DevComponents.DotNetBar.ButtonX
        Friend WithEvents LabelX19 As DevComponents.DotNetBar.LabelX
        Friend WithEvents LabelX17 As DevComponents.DotNetBar.LabelX
        Friend WithEvents LabelX15 As DevComponents.DotNetBar.LabelX
        Friend WithEvents LabelX14 As DevComponents.DotNetBar.LabelX
        Friend WithEvents LabelX13 As DevComponents.DotNetBar.LabelX
        Friend WithEvents LabelX11 As DevComponents.DotNetBar.LabelX
        Friend WithEvents lbl_count As DevComponents.DotNetBar.LabelX
        Friend WithEvents lbl_count_cleared As DevComponents.DotNetBar.LabelX
        Friend WithEvents LabelX20 As DevComponents.DotNetBar.LabelX
        Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
        'Friend WithEvents Db_clearance_systemDataSet As db_clearance_systemDataSet
        Friend WithEvents TblregistrarBindingSource As System.Windows.Forms.BindingSource
        Friend WithEvents lbl_path As DevComponents.DotNetBar.LabelX
        Friend WithEvents lbl_path2 As DevComponents.DotNetBar.LabelX
        Friend WithEvents pic_emp As System.Windows.Forms.PictureBox
        Friend WithEvents ButtonX1 As DevComponents.DotNetBar.ButtonX
        Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
        Friend WithEvents Timer1 As System.Windows.Forms.Timer
        'Friend WithEvents Tbl_registrarTableAdapter As db_clearance_systemDataSetTableAdapters.tbl_registrarTableAdapter
    End Class
End Namespace
