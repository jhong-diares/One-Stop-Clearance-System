Namespace one_stop_clearance_system
    Partial Public Class MainForm
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

#Region "Windows Form Designer generated code"

        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
            Me.metroStatusBar1 = New DevComponents.DotNetBar.Metro.MetroStatusBar()
            Me.LabelItem2 = New DevComponents.DotNetBar.LabelItem()
            Me.LabelItem3 = New DevComponents.DotNetBar.LabelItem()
            Me.metroShell1 = New DevComponents.DotNetBar.Metro.MetroShell()
            Me.MetroTabPanel7 = New DevComponents.DotNetBar.Metro.MetroTabPanel()
            Me.ExpandableSplitter13 = New DevComponents.DotNetBar.ExpandableSplitter()
            Me.ExpandablePanel7 = New DevComponents.DotNetBar.ExpandablePanel()
            Me.bk_desc = New DevComponents.DotNetBar.Controls.TextBoxX()
            Me.LabelX51 = New DevComponents.DotNetBar.LabelX()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.bk_status = New DevComponents.DotNetBar.Controls.ComboBoxEx()
            Me.ComboItem9 = New DevComponents.Editors.ComboItem()
            Me.ComboItem10 = New DevComponents.Editors.ComboItem()
            Me.LabelX49 = New DevComponents.DotNetBar.LabelX()
            Me.bk_fullnamelbl = New DevComponents.DotNetBar.LabelX()
            Me.bk_idlbl = New DevComponents.DotNetBar.LabelX()
            Me.ButtonX7 = New DevComponents.DotNetBar.ButtonX()
            Me.bk_photodir = New DevComponents.DotNetBar.Controls.TextBoxX()
            Me.LabelX69 = New DevComponents.DotNetBar.LabelX()
            Me.bk_id = New DevComponents.DotNetBar.Controls.TextBoxX()
            Me.LabelX70 = New DevComponents.DotNetBar.LabelX()
            Me.bk_contact = New DevComponents.DotNetBar.Controls.TextBoxX()
            Me.LabelX71 = New DevComponents.DotNetBar.LabelX()
            Me.bk_sem = New DevComponents.DotNetBar.Controls.TextBoxX()
            Me.bk_acadyear = New DevComponents.DotNetBar.Controls.TextBoxX()
            Me.LabelX72 = New DevComponents.DotNetBar.LabelX()
            Me.bk_year = New DevComponents.DotNetBar.Controls.TextBoxX()
            Me.LabelX73 = New DevComponents.DotNetBar.LabelX()
            Me.bk_course = New DevComponents.DotNetBar.Controls.TextBoxX()
            Me.LabelX74 = New DevComponents.DotNetBar.LabelX()
            Me.bk_middlename = New DevComponents.DotNetBar.Controls.TextBoxX()
            Me.bk_firstname = New DevComponents.DotNetBar.Controls.TextBoxX()
            Me.bk_lastname = New DevComponents.DotNetBar.Controls.TextBoxX()
            Me.LabelX75 = New DevComponents.DotNetBar.LabelX()
            Me.bk_studid = New DevComponents.DotNetBar.Controls.TextBoxX()
            Me.LabelX76 = New DevComponents.DotNetBar.LabelX()
            Me.PictureBox7 = New System.Windows.Forms.PictureBox()
            Me.ExpandableSplitter14 = New DevComponents.DotNetBar.ExpandableSplitter()
            Me.MetroToolbar7 = New DevComponents.DotNetBar.Metro.MetroToolbar()
            Me.deleteBookstoreButton = New DevComponents.DotNetBar.ButtonItem()
            Me.searchBookstoreButton = New DevComponents.DotNetBar.ButtonItem()
            Me.searchBookstoretxt = New DevComponents.DotNetBar.TextBoxItem()
            Me.addBookstoreButton = New DevComponents.DotNetBar.ButtonItem()
            Me.updateBookstoreButton = New DevComponents.DotNetBar.ButtonItem()
            Me.ListViewEx7 = New DevComponents.DotNetBar.Controls.ListViewEx()
            Me.ColumnHeader82 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.ColumnHeader83 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.ColumnHeader84 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.ColumnHeader85 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.ColumnHeader86 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.ColumnHeader87 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.ColumnHeader88 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.ColumnHeader89 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.ColumnHeader90 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.ColumnHeader91 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.ColumnHeader92 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.ColumnHeader94 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.ColumnHeader93 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.MetroTabPanel5 = New DevComponents.DotNetBar.Metro.MetroTabPanel()
            Me.ExpandableSplitter8 = New DevComponents.DotNetBar.ExpandableSplitter()
            Me.ExpandablePanel2 = New DevComponents.DotNetBar.ExpandablePanel()
            Me.business_prev_id = New DevComponents.DotNetBar.LabelX()
            Me.b_status = New DevComponents.DotNetBar.Controls.ComboBoxEx()
            Me.ComboItem1 = New DevComponents.Editors.ComboItem()
            Me.ComboItem2 = New DevComponents.Editors.ComboItem()
            Me.LabelX60 = New DevComponents.DotNetBar.LabelX()
            Me.b_rembalance = New DevComponents.DotNetBar.Controls.TextBoxX()
            Me.LabelX59 = New DevComponents.DotNetBar.LabelX()
            Me.b_description = New DevComponents.DotNetBar.Controls.TextBoxX()
            Me.LabelX58 = New DevComponents.DotNetBar.LabelX()
            Me.LabelX7 = New DevComponents.DotNetBar.LabelX()
            Me.b_fullname = New DevComponents.DotNetBar.LabelX()
            Me.ButtonX2 = New DevComponents.DotNetBar.ButtonX()
            Me.b_directorypath = New DevComponents.DotNetBar.Controls.TextBoxX()
            Me.LabelX9 = New DevComponents.DotNetBar.LabelX()
            Me.b_id = New DevComponents.DotNetBar.Controls.TextBoxX()
            Me.LabelX10 = New DevComponents.DotNetBar.LabelX()
            Me.b_contact = New DevComponents.DotNetBar.Controls.TextBoxX()
            Me.LabelX11 = New DevComponents.DotNetBar.LabelX()
            Me.b_semester = New DevComponents.DotNetBar.Controls.TextBoxX()
            Me.b_acadyear = New DevComponents.DotNetBar.Controls.TextBoxX()
            Me.LabelX12 = New DevComponents.DotNetBar.LabelX()
            Me.b_yearlvl = New DevComponents.DotNetBar.Controls.TextBoxX()
            Me.LabelX14 = New DevComponents.DotNetBar.LabelX()
            Me.b_course = New DevComponents.DotNetBar.Controls.TextBoxX()
            Me.LabelX15 = New DevComponents.DotNetBar.LabelX()
            Me.b_middlename = New DevComponents.DotNetBar.Controls.TextBoxX()
            Me.b_firstname = New DevComponents.DotNetBar.Controls.TextBoxX()
            Me.b_lastname = New DevComponents.DotNetBar.Controls.TextBoxX()
            Me.LabelX16 = New DevComponents.DotNetBar.LabelX()
            Me.b_studid = New DevComponents.DotNetBar.Controls.TextBoxX()
            Me.LabelX17 = New DevComponents.DotNetBar.LabelX()
            Me.PictureBox2 = New System.Windows.Forms.PictureBox()
            Me.MetroToolbar5 = New DevComponents.DotNetBar.Metro.MetroToolbar()
            Me.deleteBusinessButton = New DevComponents.DotNetBar.ButtonItem()
            Me.searchBusinessButton = New DevComponents.DotNetBar.ButtonItem()
            Me.searchBusinessTxt = New DevComponents.DotNetBar.TextBoxItem()
            Me.addBusinessButton = New DevComponents.DotNetBar.ButtonItem()
            Me.updateBusinessButton = New DevComponents.DotNetBar.ButtonItem()
            Me.LabelX2 = New DevComponents.DotNetBar.LabelX()
            Me.ExpandableSplitter3 = New DevComponents.DotNetBar.ExpandableSplitter()
            Me.ListViewEx2 = New DevComponents.DotNetBar.Controls.ListViewEx()
            Me.ColumnHeader12 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.ColumnHeader13 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.ColumnHeader14 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.ColumnHeader15 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.ColumnHeader16 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.ColumnHeader17 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.ColumnHeader18 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.ColumnHeader19 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.ColumnHeader20 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.ColumnHeader21 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.ColumnHeader11 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.ColumnHeader60 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.ColumnHeader61 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.ColumnHeader73 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.MetroTabPanel3 = New DevComponents.DotNetBar.Metro.MetroTabPanel()
            Me.ExpandableSplitter10 = New DevComponents.DotNetBar.ExpandableSplitter()
            Me.ExpandablePanel4 = New DevComponents.DotNetBar.ExpandablePanel()
            Me.g_status = New DevComponents.DotNetBar.Controls.ComboBoxEx()
            Me.ComboItem3 = New DevComponents.Editors.ComboItem()
            Me.ComboItem4 = New DevComponents.Editors.ComboItem()
            Me.LabelX8 = New DevComponents.DotNetBar.LabelX()
            Me.g_uncollectedTxt = New DevComponents.DotNetBar.Controls.TextBoxX()
            Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
            Me.g_fullname = New DevComponents.DotNetBar.LabelX()
            Me.g_id_lbl = New DevComponents.DotNetBar.LabelX()
            Me.ButtonX4 = New DevComponents.DotNetBar.ButtonX()
            Me.g_directorypath = New DevComponents.DotNetBar.Controls.TextBoxX()
            Me.LabelX30 = New DevComponents.DotNetBar.LabelX()
            Me.g_id = New DevComponents.DotNetBar.Controls.TextBoxX()
            Me.LabelX31 = New DevComponents.DotNetBar.LabelX()
            Me.g_contact = New DevComponents.DotNetBar.Controls.TextBoxX()
            Me.LabelX32 = New DevComponents.DotNetBar.LabelX()
            Me.g_semester = New DevComponents.DotNetBar.Controls.TextBoxX()
            Me.g_acadyear = New DevComponents.DotNetBar.Controls.TextBoxX()
            Me.LabelX33 = New DevComponents.DotNetBar.LabelX()
            Me.g_yearlevel = New DevComponents.DotNetBar.Controls.TextBoxX()
            Me.LabelX34 = New DevComponents.DotNetBar.LabelX()
            Me.g_course = New DevComponents.DotNetBar.Controls.TextBoxX()
            Me.LabelX35 = New DevComponents.DotNetBar.LabelX()
            Me.g_middlename = New DevComponents.DotNetBar.Controls.TextBoxX()
            Me.g_firstname = New DevComponents.DotNetBar.Controls.TextBoxX()
            Me.g_lastname = New DevComponents.DotNetBar.Controls.TextBoxX()
            Me.LabelX36 = New DevComponents.DotNetBar.LabelX()
            Me.g_studid = New DevComponents.DotNetBar.Controls.TextBoxX()
            Me.LabelX37 = New DevComponents.DotNetBar.LabelX()
            Me.PictureBox4 = New System.Windows.Forms.PictureBox()
            Me.MetroToolbar3 = New DevComponents.DotNetBar.Metro.MetroToolbar()
            Me.deleteGuidanceButton = New DevComponents.DotNetBar.ButtonItem()
            Me.searchGuidanceButton = New DevComponents.DotNetBar.ButtonItem()
            Me.searchGuidanceTxt = New DevComponents.DotNetBar.TextBoxItem()
            Me.addGuidanceButton = New DevComponents.DotNetBar.ButtonItem()
            Me.updateGuidanceButton = New DevComponents.DotNetBar.ButtonItem()
            Me.LabelX4 = New DevComponents.DotNetBar.LabelX()
            Me.ExpandableSplitter5 = New DevComponents.DotNetBar.ExpandableSplitter()
            Me.ListViewEx3 = New DevComponents.DotNetBar.Controls.ListViewEx()
            Me.ColumnHeader23 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.ColumnHeader24 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.ColumnHeader25 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.ColumnHeader26 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.ColumnHeader27 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.ColumnHeader28 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.ColumnHeader29 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.ColumnHeader30 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.ColumnHeader31 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.ColumnHeader32 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.ColumnHeader33 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.ColumnHeader59 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.ColumnHeader74 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.MetroTabPanel2 = New DevComponents.DotNetBar.Metro.MetroTabPanel()
            Me.ExpandableSplitter11 = New DevComponents.DotNetBar.ExpandableSplitter()
            Me.ExpandablePanel5 = New DevComponents.DotNetBar.ExpandablePanel()
            Me.LabelX42 = New DevComponents.DotNetBar.LabelX()
            Me.i_units = New DevComponents.DotNetBar.Controls.TextBoxX()
            Me.i_subjdesc = New DevComponents.DotNetBar.Controls.TextBoxX()
            Me.LabelX38 = New DevComponents.DotNetBar.LabelX()
            Me.LabelX29 = New DevComponents.DotNetBar.LabelX()
            Me.i_fullname = New DevComponents.DotNetBar.LabelX()
            Me.i_id_lbl = New DevComponents.DotNetBar.LabelX()
            Me.ButtonX5 = New DevComponents.DotNetBar.ButtonX()
            Me.i_directorypath = New DevComponents.DotNetBar.Controls.TextBoxX()
            Me.LabelX40 = New DevComponents.DotNetBar.LabelX()
            Me.i_id = New DevComponents.DotNetBar.Controls.TextBoxX()
            Me.LabelX41 = New DevComponents.DotNetBar.LabelX()
            Me.i_semester = New DevComponents.DotNetBar.Controls.TextBoxX()
            Me.i_acadyear = New DevComponents.DotNetBar.Controls.TextBoxX()
            Me.LabelX43 = New DevComponents.DotNetBar.LabelX()
            Me.i_yearlevel = New DevComponents.DotNetBar.Controls.TextBoxX()
            Me.LabelX44 = New DevComponents.DotNetBar.LabelX()
            Me.i_subjectcode = New DevComponents.DotNetBar.Controls.TextBoxX()
            Me.LabelX45 = New DevComponents.DotNetBar.LabelX()
            Me.i_middlename = New DevComponents.DotNetBar.Controls.TextBoxX()
            Me.i_firstname = New DevComponents.DotNetBar.Controls.TextBoxX()
            Me.i_lastname = New DevComponents.DotNetBar.Controls.TextBoxX()
            Me.LabelX46 = New DevComponents.DotNetBar.LabelX()
            Me.i_empid = New DevComponents.DotNetBar.Controls.TextBoxX()
            Me.LabelX47 = New DevComponents.DotNetBar.LabelX()
            Me.PictureBox5 = New System.Windows.Forms.PictureBox()
            Me.MetroToolbar2 = New DevComponents.DotNetBar.Metro.MetroToolbar()
            Me.deleteInstructorButton = New DevComponents.DotNetBar.ButtonItem()
            Me.searchInstructorButton = New DevComponents.DotNetBar.ButtonItem()
            Me.searchInstructorTxt = New DevComponents.DotNetBar.TextBoxItem()
            Me.addInstructorButton = New DevComponents.DotNetBar.ButtonItem()
            Me.updateInstructorButton = New DevComponents.DotNetBar.ButtonItem()
            Me.LabelX5 = New DevComponents.DotNetBar.LabelX()
            Me.ExpandableSplitter6 = New DevComponents.DotNetBar.ExpandableSplitter()
            Me.ListViewEx5 = New DevComponents.DotNetBar.Controls.ListViewEx()
            Me.ColumnHeader45 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.ColumnHeader46 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.ColumnHeader47 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.ColumnHeader48 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.ColumnHeader49 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.ColumnHeader50 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.ColumnHeader51 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.ColumnHeader52 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.ColumnHeader53 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.ColumnHeader54 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.ColumnHeader55 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.ColumnHeader80 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.MetroTabPanel6 = New DevComponents.DotNetBar.Metro.MetroTabPanel()
            Me.ExpandableSplitter12 = New DevComponents.DotNetBar.ExpandableSplitter()
            Me.ExpandablePanel6 = New DevComponents.DotNetBar.ExpandablePanel()
            Me.t_status = New DevComponents.DotNetBar.Controls.ComboBoxEx()
            Me.ComboItem7 = New DevComponents.Editors.ComboItem()
            Me.ComboItem8 = New DevComponents.Editors.ComboItem()
            Me.LabelX66 = New DevComponents.DotNetBar.LabelX()
            Me.t_grades = New DevComponents.DotNetBar.Controls.TextBoxX()
            Me.LabelX65 = New DevComponents.DotNetBar.LabelX()
            Me.t_course = New DevComponents.DotNetBar.Controls.TextBoxX()
            Me.LabelX62 = New DevComponents.DotNetBar.LabelX()
            Me.t_stud_name = New DevComponents.DotNetBar.Controls.TextBoxX()
            Me.LabelX63 = New DevComponents.DotNetBar.LabelX()
            Me.t_studid = New DevComponents.DotNetBar.Controls.TextBoxX()
            Me.LabelX64 = New DevComponents.DotNetBar.LabelX()
            Me.LabelX39 = New DevComponents.DotNetBar.LabelX()
            Me.t_units = New DevComponents.DotNetBar.Controls.TextBoxX()
            Me.t_subjdesc = New DevComponents.DotNetBar.Controls.TextBoxX()
            Me.LabelX48 = New DevComponents.DotNetBar.LabelX()
            Me.LabelX50 = New DevComponents.DotNetBar.LabelX()
            Me.t_id_lbl = New DevComponents.DotNetBar.LabelX()
            Me.ButtonX6 = New DevComponents.DotNetBar.ButtonX()
            Me.t_directorypath = New DevComponents.DotNetBar.Controls.TextBoxX()
            Me.LabelX52 = New DevComponents.DotNetBar.LabelX()
            Me.t_id = New DevComponents.DotNetBar.Controls.TextBoxX()
            Me.LabelX53 = New DevComponents.DotNetBar.LabelX()
            Me.t_semester = New DevComponents.DotNetBar.Controls.TextBoxX()
            Me.t_acadyear = New DevComponents.DotNetBar.Controls.TextBoxX()
            Me.LabelX54 = New DevComponents.DotNetBar.LabelX()
            Me.t_yearlevel = New DevComponents.DotNetBar.Controls.TextBoxX()
            Me.LabelX55 = New DevComponents.DotNetBar.LabelX()
            Me.t_subjcode = New DevComponents.DotNetBar.Controls.TextBoxX()
            Me.LabelX56 = New DevComponents.DotNetBar.LabelX()
            Me.t_middlename = New DevComponents.DotNetBar.Controls.TextBoxX()
            Me.t_firstname = New DevComponents.DotNetBar.Controls.TextBoxX()
            Me.t_lastname = New DevComponents.DotNetBar.Controls.TextBoxX()
            Me.LabelX57 = New DevComponents.DotNetBar.LabelX()
            Me.t_empid = New DevComponents.DotNetBar.Controls.TextBoxX()
            Me.LabelX61 = New DevComponents.DotNetBar.LabelX()
            Me.PictureBox6 = New System.Windows.Forms.PictureBox()
            Me.LabelX6 = New DevComponents.DotNetBar.LabelX()
            Me.MetroToolbar1 = New DevComponents.DotNetBar.Metro.MetroToolbar()
            Me.deleteGradesButton = New DevComponents.DotNetBar.ButtonItem()
            Me.searchGradessButton = New DevComponents.DotNetBar.ButtonItem()
            Me.searchGradesTxt = New DevComponents.DotNetBar.TextBoxItem()
            Me.addGradesButton = New DevComponents.DotNetBar.ButtonItem()
            Me.updateGradesButton = New DevComponents.DotNetBar.ButtonItem()
            Me.ExpandableSplitter2 = New DevComponents.DotNetBar.ExpandableSplitter()
            Me.ListViewEx6 = New DevComponents.DotNetBar.Controls.ListViewEx()
            Me.ColumnHeader22 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.ColumnHeader56 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.ColumnHeader62 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.ColumnHeader63 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.ColumnHeader64 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.ColumnHeader65 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.ColumnHeader66 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.ColumnHeader67 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.ColumnHeader68 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.ColumnHeader69 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.ColumnHeader70 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.ColumnHeader71 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.ColumnHeader75 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.ColumnHeader76 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.ColumnHeader77 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.ColumnHeader78 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.ColumnHeader81 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.MetroTabPanel4 = New DevComponents.DotNetBar.Metro.MetroTabPanel()
            Me.ExpandableSplitter9 = New DevComponents.DotNetBar.ExpandableSplitter()
            Me.ExpandablePanel3 = New DevComponents.DotNetBar.ExpandablePanel()
            Me.l_status = New DevComponents.DotNetBar.Controls.ComboBoxEx()
            Me.ComboItem5 = New DevComponents.Editors.ComboItem()
            Me.ComboItem6 = New DevComponents.Editors.ComboItem()
            Me.LabelX28 = New DevComponents.DotNetBar.LabelX()
            Me.l_remainingBal = New DevComponents.DotNetBar.Controls.TextBoxX()
            Me.l_unretbook = New DevComponents.DotNetBar.Controls.TextBoxX()
            Me.LabelX18 = New DevComponents.DotNetBar.LabelX()
            Me.LabelX19 = New DevComponents.DotNetBar.LabelX()
            Me.l_fullname = New DevComponents.DotNetBar.LabelX()
            Me.l_id_lbl = New DevComponents.DotNetBar.LabelX()
            Me.ButtonX3 = New DevComponents.DotNetBar.ButtonX()
            Me.l_directorypath = New DevComponents.DotNetBar.Controls.TextBoxX()
            Me.LabelX20 = New DevComponents.DotNetBar.LabelX()
            Me.l_id = New DevComponents.DotNetBar.Controls.TextBoxX()
            Me.LabelX21 = New DevComponents.DotNetBar.LabelX()
            Me.l_contact = New DevComponents.DotNetBar.Controls.TextBoxX()
            Me.LabelX22 = New DevComponents.DotNetBar.LabelX()
            Me.l_semester = New DevComponents.DotNetBar.Controls.TextBoxX()
            Me.l_acadyear = New DevComponents.DotNetBar.Controls.TextBoxX()
            Me.LabelX23 = New DevComponents.DotNetBar.LabelX()
            Me.l_yearlevel = New DevComponents.DotNetBar.Controls.TextBoxX()
            Me.LabelX24 = New DevComponents.DotNetBar.LabelX()
            Me.l_course = New DevComponents.DotNetBar.Controls.TextBoxX()
            Me.LabelX25 = New DevComponents.DotNetBar.LabelX()
            Me.l_middlename = New DevComponents.DotNetBar.Controls.TextBoxX()
            Me.l_fistname = New DevComponents.DotNetBar.Controls.TextBoxX()
            Me.l_lastname = New DevComponents.DotNetBar.Controls.TextBoxX()
            Me.LabelX26 = New DevComponents.DotNetBar.LabelX()
            Me.l_studid = New DevComponents.DotNetBar.Controls.TextBoxX()
            Me.LabelX27 = New DevComponents.DotNetBar.LabelX()
            Me.PictureBox3 = New System.Windows.Forms.PictureBox()
            Me.MetroToolbar4 = New DevComponents.DotNetBar.Metro.MetroToolbar()
            Me.deleteLibraryButton = New DevComponents.DotNetBar.ButtonItem()
            Me.searchLibraryButton = New DevComponents.DotNetBar.ButtonItem()
            Me.searchLibraryTxt = New DevComponents.DotNetBar.TextBoxItem()
            Me.addLibraryButton = New DevComponents.DotNetBar.ButtonItem()
            Me.updateLibraryButton = New DevComponents.DotNetBar.ButtonItem()
            Me.LabelX3 = New DevComponents.DotNetBar.LabelX()
            Me.ExpandableSplitter4 = New DevComponents.DotNetBar.ExpandableSplitter()
            Me.ListViewEx4 = New DevComponents.DotNetBar.Controls.ListViewEx()
            Me.ColumnHeader34 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.ColumnHeader35 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.ColumnHeader36 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.ColumnHeader37 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.ColumnHeader38 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.ColumnHeader39 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.ColumnHeader40 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.ColumnHeader41 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.ColumnHeader42 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.ColumnHeader43 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.ColumnHeader44 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.ColumnHeader57 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.ColumnHeader58 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.ColumnHeader79 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.MetroTabPanel1 = New DevComponents.DotNetBar.Metro.MetroTabPanel()
            Me.ExpandableSplitter7 = New DevComponents.DotNetBar.ExpandableSplitter()
            Me.ExpandablePanel1 = New DevComponents.DotNetBar.ExpandablePanel()
            Me.lbl_fullname = New DevComponents.DotNetBar.LabelX()
            Me.prev_idLbl = New DevComponents.DotNetBar.LabelX()
            Me.ButtonX1 = New DevComponents.DotNetBar.ButtonX()
            Me.si_photo_path_txt = New DevComponents.DotNetBar.Controls.TextBoxX()
            Me.si_photo = New DevComponents.DotNetBar.LabelX()
            Me.si_id_txt = New DevComponents.DotNetBar.Controls.TextBoxX()
            Me.LabelX13 = New DevComponents.DotNetBar.LabelX()
            Me.si_contact_txt = New DevComponents.DotNetBar.Controls.TextBoxX()
            Me.si_contact = New DevComponents.DotNetBar.LabelX()
            Me.si_semester_txt = New DevComponents.DotNetBar.Controls.TextBoxX()
            Me.si_acadyear_txt = New DevComponents.DotNetBar.Controls.TextBoxX()
            Me.si_semester = New DevComponents.DotNetBar.LabelX()
            Me.si_yr_txt = New DevComponents.DotNetBar.Controls.TextBoxX()
            Me.si_acad_yr = New DevComponents.DotNetBar.LabelX()
            Me.si_course_txt = New DevComponents.DotNetBar.Controls.TextBoxX()
            Me.si_course_yr = New DevComponents.DotNetBar.LabelX()
            Me.si_Mname_txt = New DevComponents.DotNetBar.Controls.TextBoxX()
            Me.si_Fname_txt = New DevComponents.DotNetBar.Controls.TextBoxX()
            Me.si_Lname_txt = New DevComponents.DotNetBar.Controls.TextBoxX()
            Me.si_stud_id = New DevComponents.DotNetBar.LabelX()
            Me.si_stud_id_txt = New DevComponents.DotNetBar.Controls.TextBoxX()
            Me.si_name = New DevComponents.DotNetBar.LabelX()
            Me.PictureBox1 = New System.Windows.Forms.PictureBox()
            Me.b_id_lbl = New DevComponents.DotNetBar.LabelX()
            Me.MetroToolbar6 = New DevComponents.DotNetBar.Metro.MetroToolbar()
            Me.deleteRegistrarButton = New DevComponents.DotNetBar.ButtonItem()
            Me.searchRegistrarButton = New DevComponents.DotNetBar.ButtonItem()
            Me.searchRegistrarTxt = New DevComponents.DotNetBar.TextBoxItem()
            Me.addRegistrarButton = New DevComponents.DotNetBar.ButtonItem()
            Me.updateRegistrarButton = New DevComponents.DotNetBar.ButtonItem()
            Me.ExpandableSplitter1 = New DevComponents.DotNetBar.ExpandableSplitter()
            Me.ListViewEx1 = New DevComponents.DotNetBar.Controls.ListViewEx()
            Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.ColumnHeader8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.ColumnHeader9 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.ColumnHeader10 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.ColumnHeader72 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.metroAppButton1 = New DevComponents.DotNetBar.Metro.MetroAppButton()
            Me.superTabControl1 = New DevComponents.DotNetBar.SuperTabControl()
            Me.superTabControlPanel1 = New DevComponents.DotNetBar.SuperTabControlPanel()
            Me.superTabItem1 = New DevComponents.DotNetBar.SuperTabItem()
            Me.superTabControlPanel3 = New DevComponents.DotNetBar.SuperTabControlPanel()
            Me.superTabItem3 = New DevComponents.DotNetBar.SuperTabItem()
            Me.superTabControlPanel4 = New DevComponents.DotNetBar.SuperTabControlPanel()
            Me.superTabItem4 = New DevComponents.DotNetBar.SuperTabItem()
            Me.superTabControlPanel2 = New DevComponents.DotNetBar.SuperTabControlPanel()
            Me.superTabItem2 = New DevComponents.DotNetBar.SuperTabItem()
            Me.buttonItem2 = New DevComponents.DotNetBar.ButtonItem()
            Me.buttonItem3 = New DevComponents.DotNetBar.ButtonItem()
            Me.buttonItem4 = New DevComponents.DotNetBar.ButtonItem()
            Me.buttonItem5 = New DevComponents.DotNetBar.ButtonItem()
            Me.buttonItem6 = New DevComponents.DotNetBar.ButtonItem()
            Me.registrar_tab = New DevComponents.DotNetBar.Metro.MetroTabItem()
            Me.business_tab = New DevComponents.DotNetBar.Metro.MetroTabItem()
            Me.library_tab = New DevComponents.DotNetBar.Metro.MetroTabItem()
            Me.guidance_tab = New DevComponents.DotNetBar.Metro.MetroTabItem()
            Me.instructor_tab = New DevComponents.DotNetBar.Metro.MetroTabItem()
            Me.grades_tab = New DevComponents.DotNetBar.Metro.MetroTabItem()
            Me.bookstore_tab = New DevComponents.DotNetBar.Metro.MetroTabItem()
            Me.colorThemeButton = New DevComponents.DotNetBar.ButtonItem()
            Me.qatCustomizeItem1 = New DevComponents.DotNetBar.QatCustomizeItem()
            Me.styleManager1 = New DevComponents.DotNetBar.StyleManager(Me.components)
            Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
            Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
            Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
            Me.metroShell1.SuspendLayout()
            Me.MetroTabPanel7.SuspendLayout()
            Me.ExpandablePanel7.SuspendLayout()
            CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.MetroTabPanel5.SuspendLayout()
            Me.ExpandablePanel2.SuspendLayout()
            CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.MetroTabPanel3.SuspendLayout()
            Me.ExpandablePanel4.SuspendLayout()
            CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.MetroTabPanel2.SuspendLayout()
            Me.ExpandablePanel5.SuspendLayout()
            CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.MetroTabPanel6.SuspendLayout()
            Me.ExpandablePanel6.SuspendLayout()
            CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.MetroTabPanel4.SuspendLayout()
            Me.ExpandablePanel3.SuspendLayout()
            CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.MetroTabPanel1.SuspendLayout()
            Me.ExpandablePanel1.SuspendLayout()
            CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.superTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.superTabControl1.SuspendLayout()
            Me.SuspendLayout()
            '
            'metroStatusBar1
            '
            Me.metroStatusBar1.BackColor = System.Drawing.Color.White
            '
            '
            '
            Me.metroStatusBar1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.metroStatusBar1.ContainerControlProcessDialogKey = True
            Me.metroStatusBar1.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.metroStatusBar1.DragDropSupport = True
            Me.metroStatusBar1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.metroStatusBar1.ForeColor = System.Drawing.Color.Black
            Me.metroStatusBar1.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.LabelItem2, Me.LabelItem3})
            Me.metroStatusBar1.LicenseKey = "F962CEC7-CD8F-4911-A9E9-CAB39962FC1F"
            Me.metroStatusBar1.Location = New System.Drawing.Point(1, 645)
            Me.metroStatusBar1.Name = "metroStatusBar1"
            Me.metroStatusBar1.Size = New System.Drawing.Size(911, 22)
            Me.metroStatusBar1.TabIndex = 0
            Me.metroStatusBar1.Text = "metroStatusBar1"
            '
            'LabelItem2
            '
            Me.LabelItem2.Name = "LabelItem2"
            Me.LabelItem2.Text = "Department:"
            '
            'LabelItem3
            '
            Me.LabelItem3.Name = "LabelItem3"
            Me.LabelItem3.Text = "LabelItem3"
            '
            'metroShell1
            '
            Me.metroShell1.BackColor = System.Drawing.Color.White
            '
            '
            '
            Me.metroShell1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.metroShell1.CaptionVisible = True
            Me.metroShell1.Controls.Add(Me.MetroTabPanel7)
            Me.metroShell1.Controls.Add(Me.MetroTabPanel6)
            Me.metroShell1.Controls.Add(Me.MetroTabPanel5)
            Me.metroShell1.Controls.Add(Me.MetroTabPanel3)
            Me.metroShell1.Controls.Add(Me.MetroTabPanel2)
            Me.metroShell1.Controls.Add(Me.MetroTabPanel4)
            Me.metroShell1.Controls.Add(Me.MetroTabPanel1)
            Me.metroShell1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.metroShell1.ForeColor = System.Drawing.Color.Black
            Me.metroShell1.HelpButtonText = Nothing
            Me.metroShell1.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.metroAppButton1, Me.registrar_tab, Me.business_tab, Me.library_tab, Me.guidance_tab, Me.instructor_tab, Me.grades_tab, Me.bookstore_tab})
            Me.metroShell1.KeyTipsFont = New System.Drawing.Font("Tahoma", 7.0!)
            Me.metroShell1.Location = New System.Drawing.Point(1, 1)
            Me.metroShell1.Name = "metroShell1"
            Me.metroShell1.QuickToolbarItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.colorThemeButton, Me.qatCustomizeItem1})
            Me.metroShell1.Size = New System.Drawing.Size(911, 644)
            Me.metroShell1.SystemText.MaximizeRibbonText = "&Maximize the Ribbon"
            Me.metroShell1.SystemText.MinimizeRibbonText = "Mi&nimize the Ribbon"
            Me.metroShell1.SystemText.QatAddItemText = "&Add to Quick Access Toolbar"
            Me.metroShell1.SystemText.QatCustomizeMenuLabel = "<b>Customize Quick Access Toolbar</b>"
            Me.metroShell1.SystemText.QatCustomizeText = "&Customize Quick Access Toolbar..."
            Me.metroShell1.SystemText.QatDialogAddButton = "&Add >>"
            Me.metroShell1.SystemText.QatDialogCancelButton = "Cancel"
            Me.metroShell1.SystemText.QatDialogCaption = "Customize Quick Access Toolbar"
            Me.metroShell1.SystemText.QatDialogCategoriesLabel = "&Choose commands from:"
            Me.metroShell1.SystemText.QatDialogOkButton = "OK"
            Me.metroShell1.SystemText.QatDialogPlacementCheckbox = "&Place Quick Access Toolbar below the Ribbon"
            Me.metroShell1.SystemText.QatDialogRemoveButton = "&Remove"
            Me.metroShell1.SystemText.QatPlaceAboveRibbonText = "&Place Quick Access Toolbar above the Ribbon"
            Me.metroShell1.SystemText.QatPlaceBelowRibbonText = "&Place Quick Access Toolbar below the Ribbon"
            Me.metroShell1.SystemText.QatRemoveItemText = "&Remove from Quick Access Toolbar"
            Me.metroShell1.TabIndex = 1
            Me.metroShell1.TabStripFont = New System.Drawing.Font("Segoe UI", 10.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.metroShell1.Text = "metroShell1"
            '
            'MetroTabPanel7
            '
            Me.MetroTabPanel7.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
            Me.MetroTabPanel7.Controls.Add(Me.ExpandableSplitter13)
            Me.MetroTabPanel7.Controls.Add(Me.ExpandablePanel7)
            Me.MetroTabPanel7.Controls.Add(Me.ExpandableSplitter14)
            Me.MetroTabPanel7.Controls.Add(Me.MetroToolbar7)
            Me.MetroTabPanel7.Controls.Add(Me.ListViewEx7)
            Me.MetroTabPanel7.Dock = System.Windows.Forms.DockStyle.Fill
            Me.MetroTabPanel7.Location = New System.Drawing.Point(0, 51)
            Me.MetroTabPanel7.Name = "MetroTabPanel7"
            Me.MetroTabPanel7.Padding = New System.Windows.Forms.Padding(3, 0, 3, 3)
            Me.MetroTabPanel7.Size = New System.Drawing.Size(911, 593)
            '
            '
            '
            Me.MetroTabPanel7.Style.CornerType = DevComponents.DotNetBar.eCornerType.Square
            '
            '
            '
            Me.MetroTabPanel7.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
            '
            '
            '
            Me.MetroTabPanel7.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.MetroTabPanel7.TabIndex = 9
            '
            'ExpandableSplitter13
            '
            Me.ExpandableSplitter13.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer))
            Me.ExpandableSplitter13.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer))
            Me.ExpandableSplitter13.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
            Me.ExpandableSplitter13.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
            Me.ExpandableSplitter13.Dock = System.Windows.Forms.DockStyle.Top
            Me.ExpandableSplitter13.ExpandFillColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer))
            Me.ExpandableSplitter13.ExpandFillColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
            Me.ExpandableSplitter13.ExpandLineColor = System.Drawing.Color.Black
            Me.ExpandableSplitter13.ExpandLineColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText
            Me.ExpandableSplitter13.ForeColor = System.Drawing.Color.Black
            Me.ExpandableSplitter13.GripDarkColor = System.Drawing.Color.Black
            Me.ExpandableSplitter13.GripDarkColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText
            Me.ExpandableSplitter13.GripLightColor = System.Drawing.Color.White
            Me.ExpandableSplitter13.GripLightColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
            Me.ExpandableSplitter13.HotBackColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer))
            Me.ExpandableSplitter13.HotBackColor2 = System.Drawing.Color.Empty
            Me.ExpandableSplitter13.HotBackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemPressedBackground2
            Me.ExpandableSplitter13.HotBackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemPressedBackground
            Me.ExpandableSplitter13.HotExpandFillColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer))
            Me.ExpandableSplitter13.HotExpandFillColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
            Me.ExpandableSplitter13.HotExpandLineColor = System.Drawing.Color.Black
            Me.ExpandableSplitter13.HotExpandLineColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText
            Me.ExpandableSplitter13.HotGripDarkColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer))
            Me.ExpandableSplitter13.HotGripDarkColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
            Me.ExpandableSplitter13.HotGripLightColor = System.Drawing.Color.White
            Me.ExpandableSplitter13.HotGripLightColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
            Me.ExpandableSplitter13.Location = New System.Drawing.Point(3, 495)
            Me.ExpandableSplitter13.Name = "ExpandableSplitter13"
            Me.ExpandableSplitter13.Size = New System.Drawing.Size(905, 10)
            Me.ExpandableSplitter13.Style = DevComponents.DotNetBar.eSplitterStyle.Office2007
            Me.ExpandableSplitter13.TabIndex = 63
            Me.ExpandableSplitter13.TabStop = False
            '
            'ExpandablePanel7
            '
            Me.ExpandablePanel7.CanvasColor = System.Drawing.SystemColors.Window
            Me.ExpandablePanel7.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
            Me.ExpandablePanel7.Controls.Add(Me.bk_desc)
            Me.ExpandablePanel7.Controls.Add(Me.LabelX51)
            Me.ExpandablePanel7.Controls.Add(Me.Label1)
            Me.ExpandablePanel7.Controls.Add(Me.bk_status)
            Me.ExpandablePanel7.Controls.Add(Me.LabelX49)
            Me.ExpandablePanel7.Controls.Add(Me.bk_fullnamelbl)
            Me.ExpandablePanel7.Controls.Add(Me.bk_idlbl)
            Me.ExpandablePanel7.Controls.Add(Me.ButtonX7)
            Me.ExpandablePanel7.Controls.Add(Me.bk_photodir)
            Me.ExpandablePanel7.Controls.Add(Me.LabelX69)
            Me.ExpandablePanel7.Controls.Add(Me.bk_id)
            Me.ExpandablePanel7.Controls.Add(Me.LabelX70)
            Me.ExpandablePanel7.Controls.Add(Me.bk_contact)
            Me.ExpandablePanel7.Controls.Add(Me.LabelX71)
            Me.ExpandablePanel7.Controls.Add(Me.bk_sem)
            Me.ExpandablePanel7.Controls.Add(Me.bk_acadyear)
            Me.ExpandablePanel7.Controls.Add(Me.LabelX72)
            Me.ExpandablePanel7.Controls.Add(Me.bk_year)
            Me.ExpandablePanel7.Controls.Add(Me.LabelX73)
            Me.ExpandablePanel7.Controls.Add(Me.bk_course)
            Me.ExpandablePanel7.Controls.Add(Me.LabelX74)
            Me.ExpandablePanel7.Controls.Add(Me.bk_middlename)
            Me.ExpandablePanel7.Controls.Add(Me.bk_firstname)
            Me.ExpandablePanel7.Controls.Add(Me.bk_lastname)
            Me.ExpandablePanel7.Controls.Add(Me.LabelX75)
            Me.ExpandablePanel7.Controls.Add(Me.bk_studid)
            Me.ExpandablePanel7.Controls.Add(Me.LabelX76)
            Me.ExpandablePanel7.Controls.Add(Me.PictureBox7)
            Me.ExpandablePanel7.DisabledBackColor = System.Drawing.Color.Empty
            Me.ExpandablePanel7.Dock = System.Windows.Forms.DockStyle.Top
            Me.ExpandablePanel7.HideControlsWhenCollapsed = True
            Me.ExpandablePanel7.Location = New System.Drawing.Point(3, 250)
            Me.ExpandablePanel7.Name = "ExpandablePanel7"
            Me.ExpandablePanel7.Size = New System.Drawing.Size(905, 245)
            Me.ExpandablePanel7.Style.Alignment = System.Drawing.StringAlignment.Center
            Me.ExpandablePanel7.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
            Me.ExpandablePanel7.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
            Me.ExpandablePanel7.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText
            Me.ExpandablePanel7.Style.GradientAngle = 90
            Me.ExpandablePanel7.TabIndex = 62
            Me.ExpandablePanel7.TitleStyle.Alignment = System.Drawing.StringAlignment.Center
            Me.ExpandablePanel7.TitleStyle.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
            Me.ExpandablePanel7.TitleStyle.Border = DevComponents.DotNetBar.eBorderType.RaisedInner
            Me.ExpandablePanel7.TitleStyle.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
            Me.ExpandablePanel7.TitleStyle.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
            Me.ExpandablePanel7.TitleStyle.GradientAngle = 90
            Me.ExpandablePanel7.TitleText = "Student Information"
            '
            'bk_desc
            '
            Me.bk_desc.BackColor = System.Drawing.Color.White
            '
            '
            '
            Me.bk_desc.Border.Class = "TextBoxBorder"
            Me.bk_desc.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.bk_desc.DisabledBackColor = System.Drawing.Color.White
            Me.bk_desc.ForeColor = System.Drawing.Color.Black
            Me.bk_desc.Location = New System.Drawing.Point(441, 123)
            Me.bk_desc.Name = "bk_desc"
            Me.bk_desc.PreventEnterBeep = True
            Me.bk_desc.Size = New System.Drawing.Size(100, 22)
            Me.bk_desc.TabIndex = 33
            '
            'LabelX51
            '
            Me.LabelX51.BackColor = System.Drawing.Color.Transparent
            '
            '
            '
            Me.LabelX51.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.LabelX51.ForeColor = System.Drawing.Color.Black
            Me.LabelX51.Location = New System.Drawing.Point(360, 123)
            Me.LabelX51.Name = "LabelX51"
            Me.LabelX51.Size = New System.Drawing.Size(75, 23)
            Me.LabelX51.TabIndex = 32
            Me.LabelX51.Text = "Description:"
            Me.LabelX51.TextAlignment = System.Drawing.StringAlignment.Far
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.BackColor = System.Drawing.Color.White
            Me.Label1.Enabled = False
            Me.Label1.ForeColor = System.Drawing.Color.Black
            Me.Label1.Location = New System.Drawing.Point(699, 147)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(40, 13)
            Me.Label1.TabIndex = 31
            Me.Label1.Text = "Label1"
            Me.Label1.Visible = False
            '
            'bk_status
            '
            Me.bk_status.DisplayMember = "Text"
            Me.bk_status.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
            Me.bk_status.ForeColor = System.Drawing.Color.Black
            Me.bk_status.FormattingEnabled = True
            Me.bk_status.ItemHeight = 17
            Me.bk_status.Items.AddRange(New Object() {Me.ComboItem9, Me.ComboItem10})
            Me.bk_status.Location = New System.Drawing.Point(441, 153)
            Me.bk_status.Name = "bk_status"
            Me.bk_status.Size = New System.Drawing.Size(100, 23)
            Me.bk_status.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
            Me.bk_status.TabIndex = 30
            '
            'ComboItem9
            '
            Me.ComboItem9.Text = "CLEARED"
            '
            'ComboItem10
            '
            Me.ComboItem10.Text = "NOT CLEARED"
            '
            'LabelX49
            '
            Me.LabelX49.BackColor = System.Drawing.Color.Transparent
            '
            '
            '
            Me.LabelX49.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.LabelX49.ForeColor = System.Drawing.Color.Black
            Me.LabelX49.Location = New System.Drawing.Point(339, 151)
            Me.LabelX49.Name = "LabelX49"
            Me.LabelX49.Size = New System.Drawing.Size(96, 23)
            Me.LabelX49.TabIndex = 29
            Me.LabelX49.Text = "Status:"
            Me.LabelX49.TextAlignment = System.Drawing.StringAlignment.Far
            '
            'bk_fullnamelbl
            '
            Me.bk_fullnamelbl.BackColor = System.Drawing.Color.White
            '
            '
            '
            Me.bk_fullnamelbl.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.bk_fullnamelbl.ForeColor = System.Drawing.Color.Black
            Me.bk_fullnamelbl.Location = New System.Drawing.Point(766, 80)
            Me.bk_fullnamelbl.Name = "bk_fullnamelbl"
            Me.bk_fullnamelbl.Size = New System.Drawing.Size(118, 23)
            Me.bk_fullnamelbl.TabIndex = 26
            Me.bk_fullnamelbl.Text = "LabelX7"
            Me.bk_fullnamelbl.Visible = False
            '
            'bk_idlbl
            '
            Me.bk_idlbl.BackColor = System.Drawing.Color.White
            '
            '
            '
            Me.bk_idlbl.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.bk_idlbl.ForeColor = System.Drawing.Color.Black
            Me.bk_idlbl.Location = New System.Drawing.Point(794, 37)
            Me.bk_idlbl.Name = "bk_idlbl"
            Me.bk_idlbl.Size = New System.Drawing.Size(75, 23)
            Me.bk_idlbl.TabIndex = 25
            Me.bk_idlbl.Text = "LabelX7"
            Me.bk_idlbl.Visible = False
            '
            'ButtonX7
            '
            Me.ButtonX7.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
            Me.ButtonX7.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
            Me.ButtonX7.Location = New System.Drawing.Point(12, 206)
            Me.ButtonX7.Name = "ButtonX7"
            Me.ButtonX7.Size = New System.Drawing.Size(130, 23)
            Me.ButtonX7.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
            Me.ButtonX7.TabIndex = 24
            Me.ButtonX7.Text = "Upload"
            '
            'bk_photodir
            '
            Me.bk_photodir.BackColor = System.Drawing.Color.White
            '
            '
            '
            Me.bk_photodir.Border.Class = "TextBoxBorder"
            Me.bk_photodir.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.bk_photodir.DisabledBackColor = System.Drawing.Color.White
            Me.bk_photodir.ForeColor = System.Drawing.Color.Black
            Me.bk_photodir.Location = New System.Drawing.Point(229, 206)
            Me.bk_photodir.Name = "bk_photodir"
            Me.bk_photodir.PreventEnterBeep = True
            Me.bk_photodir.Size = New System.Drawing.Size(312, 22)
            Me.bk_photodir.TabIndex = 23
            '
            'LabelX69
            '
            Me.LabelX69.BackColor = System.Drawing.Color.Transparent
            '
            '
            '
            Me.LabelX69.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.LabelX69.ForeColor = System.Drawing.Color.Black
            Me.LabelX69.Location = New System.Drawing.Point(148, 206)
            Me.LabelX69.Name = "LabelX69"
            Me.LabelX69.Size = New System.Drawing.Size(75, 23)
            Me.LabelX69.TabIndex = 22
            Me.LabelX69.Text = "Directory:"
            '
            'bk_id
            '
            Me.bk_id.BackColor = System.Drawing.Color.White
            '
            '
            '
            Me.bk_id.Border.Class = "TextBoxBorder"
            Me.bk_id.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.bk_id.DisabledBackColor = System.Drawing.Color.White
            Me.bk_id.Enabled = False
            Me.bk_id.ForeColor = System.Drawing.Color.Black
            Me.bk_id.Location = New System.Drawing.Point(34, 37)
            Me.bk_id.Name = "bk_id"
            Me.bk_id.PreventEnterBeep = True
            Me.bk_id.Size = New System.Drawing.Size(25, 22)
            Me.bk_id.TabIndex = 21
            '
            'LabelX70
            '
            Me.LabelX70.BackColor = System.Drawing.Color.Transparent
            '
            '
            '
            Me.LabelX70.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.LabelX70.ForeColor = System.Drawing.Color.Black
            Me.LabelX70.Location = New System.Drawing.Point(8, 36)
            Me.LabelX70.Name = "LabelX70"
            Me.LabelX70.Size = New System.Drawing.Size(20, 23)
            Me.LabelX70.TabIndex = 20
            Me.LabelX70.Text = "ID:"
            '
            'bk_contact
            '
            Me.bk_contact.BackColor = System.Drawing.Color.White
            '
            '
            '
            Me.bk_contact.Border.Class = "TextBoxBorder"
            Me.bk_contact.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.bk_contact.DisabledBackColor = System.Drawing.Color.White
            Me.bk_contact.ForeColor = System.Drawing.Color.Black
            Me.bk_contact.Location = New System.Drawing.Point(229, 179)
            Me.bk_contact.Name = "bk_contact"
            Me.bk_contact.PreventEnterBeep = True
            Me.bk_contact.Size = New System.Drawing.Size(100, 22)
            Me.bk_contact.TabIndex = 19
            '
            'LabelX71
            '
            Me.LabelX71.BackColor = System.Drawing.Color.Transparent
            '
            '
            '
            Me.LabelX71.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.LabelX71.ForeColor = System.Drawing.Color.Black
            Me.LabelX71.Location = New System.Drawing.Point(148, 179)
            Me.LabelX71.Name = "LabelX71"
            Me.LabelX71.Size = New System.Drawing.Size(75, 23)
            Me.LabelX71.TabIndex = 18
            Me.LabelX71.Text = "Contact #:"
            '
            'bk_sem
            '
            Me.bk_sem.BackColor = System.Drawing.Color.White
            '
            '
            '
            Me.bk_sem.Border.Class = "TextBoxBorder"
            Me.bk_sem.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.bk_sem.DisabledBackColor = System.Drawing.Color.White
            Me.bk_sem.ForeColor = System.Drawing.Color.Black
            Me.bk_sem.Location = New System.Drawing.Point(229, 151)
            Me.bk_sem.Name = "bk_sem"
            Me.bk_sem.PreventEnterBeep = True
            Me.bk_sem.Size = New System.Drawing.Size(100, 22)
            Me.bk_sem.TabIndex = 17
            '
            'bk_acadyear
            '
            Me.bk_acadyear.BackColor = System.Drawing.Color.White
            '
            '
            '
            Me.bk_acadyear.Border.Class = "TextBoxBorder"
            Me.bk_acadyear.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.bk_acadyear.DisabledBackColor = System.Drawing.Color.White
            Me.bk_acadyear.ForeColor = System.Drawing.Color.Black
            Me.bk_acadyear.Location = New System.Drawing.Point(229, 123)
            Me.bk_acadyear.Name = "bk_acadyear"
            Me.bk_acadyear.PreventEnterBeep = True
            Me.bk_acadyear.Size = New System.Drawing.Size(100, 22)
            Me.bk_acadyear.TabIndex = 16
            '
            'LabelX72
            '
            Me.LabelX72.BackColor = System.Drawing.Color.Transparent
            '
            '
            '
            Me.LabelX72.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.LabelX72.ForeColor = System.Drawing.Color.Black
            Me.LabelX72.Location = New System.Drawing.Point(148, 151)
            Me.LabelX72.Name = "LabelX72"
            Me.LabelX72.Size = New System.Drawing.Size(75, 23)
            Me.LabelX72.TabIndex = 15
            Me.LabelX72.Text = "Semester:"
            '
            'bk_year
            '
            Me.bk_year.BackColor = System.Drawing.Color.White
            '
            '
            '
            Me.bk_year.Border.Class = "TextBoxBorder"
            Me.bk_year.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.bk_year.DisabledBackColor = System.Drawing.Color.White
            Me.bk_year.ForeColor = System.Drawing.Color.Black
            Me.bk_year.Location = New System.Drawing.Point(281, 94)
            Me.bk_year.Name = "bk_year"
            Me.bk_year.PreventEnterBeep = True
            Me.bk_year.Size = New System.Drawing.Size(48, 22)
            Me.bk_year.TabIndex = 14
            '
            'LabelX73
            '
            Me.LabelX73.BackColor = System.Drawing.Color.Transparent
            '
            '
            '
            Me.LabelX73.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.LabelX73.ForeColor = System.Drawing.Color.Black
            Me.LabelX73.Location = New System.Drawing.Point(148, 123)
            Me.LabelX73.Name = "LabelX73"
            Me.LabelX73.Size = New System.Drawing.Size(75, 23)
            Me.LabelX73.TabIndex = 13
            Me.LabelX73.Text = "Academic Yr:"
            '
            'bk_course
            '
            Me.bk_course.BackColor = System.Drawing.Color.White
            '
            '
            '
            Me.bk_course.Border.Class = "TextBoxBorder"
            Me.bk_course.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.bk_course.DisabledBackColor = System.Drawing.Color.White
            Me.bk_course.ForeColor = System.Drawing.Color.Black
            Me.bk_course.Location = New System.Drawing.Point(229, 95)
            Me.bk_course.Name = "bk_course"
            Me.bk_course.PreventEnterBeep = True
            Me.bk_course.Size = New System.Drawing.Size(46, 22)
            Me.bk_course.TabIndex = 12
            '
            'LabelX74
            '
            Me.LabelX74.BackColor = System.Drawing.Color.Transparent
            '
            '
            '
            Me.LabelX74.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.LabelX74.ForeColor = System.Drawing.Color.Black
            Me.LabelX74.Location = New System.Drawing.Point(148, 94)
            Me.LabelX74.Name = "LabelX74"
            Me.LabelX74.Size = New System.Drawing.Size(75, 23)
            Me.LabelX74.TabIndex = 11
            Me.LabelX74.Text = "Course / Year:"
            '
            'bk_middlename
            '
            Me.bk_middlename.BackColor = System.Drawing.Color.White
            '
            '
            '
            Me.bk_middlename.Border.Class = "TextBoxBorder"
            Me.bk_middlename.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.bk_middlename.DisabledBackColor = System.Drawing.Color.White
            Me.bk_middlename.ForeColor = System.Drawing.Color.Black
            Me.bk_middlename.Location = New System.Drawing.Point(441, 66)
            Me.bk_middlename.Name = "bk_middlename"
            Me.bk_middlename.PreventEnterBeep = True
            Me.bk_middlename.Size = New System.Drawing.Size(100, 22)
            Me.bk_middlename.TabIndex = 10
            '
            'bk_firstname
            '
            Me.bk_firstname.BackColor = System.Drawing.Color.White
            '
            '
            '
            Me.bk_firstname.Border.Class = "TextBoxBorder"
            Me.bk_firstname.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.bk_firstname.DisabledBackColor = System.Drawing.Color.White
            Me.bk_firstname.ForeColor = System.Drawing.Color.Black
            Me.bk_firstname.Location = New System.Drawing.Point(335, 66)
            Me.bk_firstname.Name = "bk_firstname"
            Me.bk_firstname.PreventEnterBeep = True
            Me.bk_firstname.Size = New System.Drawing.Size(100, 22)
            Me.bk_firstname.TabIndex = 9
            '
            'bk_lastname
            '
            Me.bk_lastname.BackColor = System.Drawing.Color.White
            '
            '
            '
            Me.bk_lastname.Border.Class = "TextBoxBorder"
            Me.bk_lastname.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.bk_lastname.DisabledBackColor = System.Drawing.Color.White
            Me.bk_lastname.ForeColor = System.Drawing.Color.Black
            Me.bk_lastname.Location = New System.Drawing.Point(229, 67)
            Me.bk_lastname.Name = "bk_lastname"
            Me.bk_lastname.PreventEnterBeep = True
            Me.bk_lastname.Size = New System.Drawing.Size(100, 22)
            Me.bk_lastname.TabIndex = 8
            '
            'LabelX75
            '
            Me.LabelX75.BackColor = System.Drawing.Color.Transparent
            '
            '
            '
            Me.LabelX75.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.LabelX75.ForeColor = System.Drawing.Color.Black
            Me.LabelX75.Location = New System.Drawing.Point(148, 37)
            Me.LabelX75.Name = "LabelX75"
            Me.LabelX75.Size = New System.Drawing.Size(75, 23)
            Me.LabelX75.TabIndex = 7
            Me.LabelX75.Text = "Student ID:"
            '
            'bk_studid
            '
            Me.bk_studid.BackColor = System.Drawing.Color.White
            '
            '
            '
            Me.bk_studid.Border.Class = "TextBoxBorder"
            Me.bk_studid.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.bk_studid.DisabledBackColor = System.Drawing.Color.White
            Me.bk_studid.ForeColor = System.Drawing.Color.Black
            Me.bk_studid.Location = New System.Drawing.Point(229, 37)
            Me.bk_studid.Name = "bk_studid"
            Me.bk_studid.PreventEnterBeep = True
            Me.bk_studid.Size = New System.Drawing.Size(100, 22)
            Me.bk_studid.TabIndex = 6
            '
            'LabelX76
            '
            Me.LabelX76.BackColor = System.Drawing.Color.Transparent
            '
            '
            '
            Me.LabelX76.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.LabelX76.ForeColor = System.Drawing.Color.Black
            Me.LabelX76.Location = New System.Drawing.Point(148, 66)
            Me.LabelX76.Name = "LabelX76"
            Me.LabelX76.Size = New System.Drawing.Size(75, 23)
            Me.LabelX76.TabIndex = 5
            Me.LabelX76.Text = "Name:"
            '
            'PictureBox7
            '
            Me.PictureBox7.BackColor = System.Drawing.Color.White
            Me.PictureBox7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
            Me.PictureBox7.ForeColor = System.Drawing.Color.Black
            Me.PictureBox7.Location = New System.Drawing.Point(12, 67)
            Me.PictureBox7.Name = "PictureBox7"
            Me.PictureBox7.Size = New System.Drawing.Size(130, 136)
            Me.PictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
            Me.PictureBox7.TabIndex = 4
            Me.PictureBox7.TabStop = False
            '
            'ExpandableSplitter14
            '
            Me.ExpandableSplitter14.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer))
            Me.ExpandableSplitter14.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer))
            Me.ExpandableSplitter14.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
            Me.ExpandableSplitter14.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
            Me.ExpandableSplitter14.Dock = System.Windows.Forms.DockStyle.Top
            Me.ExpandableSplitter14.ExpandFillColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer))
            Me.ExpandableSplitter14.ExpandFillColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
            Me.ExpandableSplitter14.ExpandLineColor = System.Drawing.Color.Black
            Me.ExpandableSplitter14.ExpandLineColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText
            Me.ExpandableSplitter14.ForeColor = System.Drawing.Color.Black
            Me.ExpandableSplitter14.GripDarkColor = System.Drawing.Color.Black
            Me.ExpandableSplitter14.GripDarkColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText
            Me.ExpandableSplitter14.GripLightColor = System.Drawing.Color.White
            Me.ExpandableSplitter14.GripLightColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
            Me.ExpandableSplitter14.HotBackColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer))
            Me.ExpandableSplitter14.HotBackColor2 = System.Drawing.Color.Empty
            Me.ExpandableSplitter14.HotBackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemPressedBackground2
            Me.ExpandableSplitter14.HotBackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemPressedBackground
            Me.ExpandableSplitter14.HotExpandFillColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer))
            Me.ExpandableSplitter14.HotExpandFillColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
            Me.ExpandableSplitter14.HotExpandLineColor = System.Drawing.Color.Black
            Me.ExpandableSplitter14.HotExpandLineColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText
            Me.ExpandableSplitter14.HotGripDarkColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer))
            Me.ExpandableSplitter14.HotGripDarkColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
            Me.ExpandableSplitter14.HotGripLightColor = System.Drawing.Color.White
            Me.ExpandableSplitter14.HotGripLightColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
            Me.ExpandableSplitter14.Location = New System.Drawing.Point(3, 240)
            Me.ExpandableSplitter14.Name = "ExpandableSplitter14"
            Me.ExpandableSplitter14.Size = New System.Drawing.Size(905, 10)
            Me.ExpandableSplitter14.Style = DevComponents.DotNetBar.eSplitterStyle.Office2007
            Me.ExpandableSplitter14.TabIndex = 58
            Me.ExpandableSplitter14.TabStop = False
            '
            'MetroToolbar7
            '
            Me.MetroToolbar7.BackColor = System.Drawing.Color.White
            '
            '
            '
            Me.MetroToolbar7.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.MetroToolbar7.ContainerControlProcessDialogKey = True
            Me.MetroToolbar7.DragDropSupport = True
            Me.MetroToolbar7.ExpandDirection = DevComponents.DotNetBar.Metro.eExpandDirection.Top
            Me.MetroToolbar7.ExtraItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.deleteBookstoreButton})
            Me.MetroToolbar7.ForeColor = System.Drawing.Color.Black
            Me.MetroToolbar7.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.searchBookstoreButton, Me.addBookstoreButton, Me.updateBookstoreButton})
            Me.MetroToolbar7.LicenseKey = "F962CEC7-CD8F-4911-A9E9-CAB39962FC1F"
            Me.MetroToolbar7.Location = New System.Drawing.Point(289, 513)
            Me.MetroToolbar7.Name = "MetroToolbar7"
            Me.MetroToolbar7.Size = New System.Drawing.Size(388, 38)
            Me.MetroToolbar7.TabIndex = 56
            Me.MetroToolbar7.Text = "Invoices"
            '
            'deleteBookstoreButton
            '
            Me.deleteBookstoreButton.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
            Me.deleteBookstoreButton.Image = Global.My.Resources.Resources.Delete1
            Me.deleteBookstoreButton.ImageAlt = Global.My.Resources.Resources.DeleteWhite
            Me.deleteBookstoreButton.Name = "deleteBookstoreButton"
            Me.deleteBookstoreButton.Text = "Delete Record"
            Me.deleteBookstoreButton.Tooltip = "Delete Selected Record"
            '
            'searchBookstoreButton
            '
            Me.searchBookstoreButton.AutoExpandOnClick = True
            Me.searchBookstoreButton.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
            Me.searchBookstoreButton.Image = Global.My.Resources.Resources.search_ic_crop
            Me.searchBookstoreButton.ImageAlt = Global.My.Resources.Resources.NewInvoiceWhite
            Me.searchBookstoreButton.Name = "searchBookstoreButton"
            Me.searchBookstoreButton.PopupSide = DevComponents.DotNetBar.ePopupSide.Top
            Me.searchBookstoreButton.PopupType = DevComponents.DotNetBar.ePopupType.ToolBar
            Me.searchBookstoreButton.PopupWidth = 50
            Me.searchBookstoreButton.Shape = New DevComponents.DotNetBar.RoundRectangleShapeDescriptor(2)
            Me.searchBookstoreButton.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.searchBookstoretxt})
            Me.searchBookstoreButton.Text = "Search Record"
            Me.searchBookstoreButton.Tooltip = "Search"
            '
            'searchBookstoretxt
            '
            Me.searchBookstoretxt.FocusHighlightColor = System.Drawing.Color.YellowGreen
            Me.searchBookstoretxt.Name = "searchBookstoretxt"
            Me.searchBookstoretxt.Stretch = True
            Me.searchBookstoretxt.TextBoxWidth = 200
            Me.searchBookstoretxt.WatermarkColor = System.Drawing.SystemColors.GrayText
            '
            'addBookstoreButton
            '
            Me.addBookstoreButton.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
            Me.addBookstoreButton.Image = Global.My.Resources.Resources.addnew_edit
            Me.addBookstoreButton.ImageAlt = Global.My.Resources.Resources.BookNoteWhite
            Me.addBookstoreButton.Name = "addBookstoreButton"
            Me.addBookstoreButton.PopupSide = DevComponents.DotNetBar.ePopupSide.Top
            Me.addBookstoreButton.Text = "Add Record"
            Me.addBookstoreButton.Tooltip = "Add new Record"
            '
            'updateBookstoreButton
            '
            Me.updateBookstoreButton.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
            Me.updateBookstoreButton.Image = Global.My.Resources.Resources.edit_new_res
            Me.updateBookstoreButton.ImageAlt = Global.My.Resources.Resources.PaperClipWhite
            Me.updateBookstoreButton.Name = "updateBookstoreButton"
            Me.updateBookstoreButton.Text = "Update Record"
            Me.updateBookstoreButton.Tooltip = "Update an existimg Record"
            '
            'ListViewEx7
            '
            Me.ListViewEx7.BackColor = System.Drawing.Color.White
            '
            '
            '
            Me.ListViewEx7.Border.Class = "ListViewBorder"
            Me.ListViewEx7.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.ListViewEx7.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader82, Me.ColumnHeader83, Me.ColumnHeader84, Me.ColumnHeader85, Me.ColumnHeader86, Me.ColumnHeader87, Me.ColumnHeader88, Me.ColumnHeader89, Me.ColumnHeader90, Me.ColumnHeader91, Me.ColumnHeader92, Me.ColumnHeader94, Me.ColumnHeader93})
            Me.ListViewEx7.DisabledBackColor = System.Drawing.Color.Empty
            Me.ListViewEx7.Dock = System.Windows.Forms.DockStyle.Top
            Me.ListViewEx7.ForeColor = System.Drawing.Color.Black
            Me.ListViewEx7.FullRowSelect = True
            Me.ListViewEx7.Location = New System.Drawing.Point(3, 0)
            Me.ListViewEx7.Name = "ListViewEx7"
            Me.ListViewEx7.Size = New System.Drawing.Size(905, 240)
            Me.ListViewEx7.TabIndex = 3
            Me.ListViewEx7.UseCompatibleStateImageBehavior = False
            Me.ListViewEx7.View = System.Windows.Forms.View.Details
            '
            'ColumnHeader82
            '
            Me.ColumnHeader82.Text = "ID"
            '
            'ColumnHeader83
            '
            Me.ColumnHeader83.Text = "Student Number"
            Me.ColumnHeader83.Width = 130
            '
            'ColumnHeader84
            '
            Me.ColumnHeader84.Text = "Lastname"
            Me.ColumnHeader84.Width = 130
            '
            'ColumnHeader85
            '
            Me.ColumnHeader85.Text = "Firstname"
            Me.ColumnHeader85.Width = 130
            '
            'ColumnHeader86
            '
            Me.ColumnHeader86.Text = "Middlename"
            Me.ColumnHeader86.Width = 130
            '
            'ColumnHeader87
            '
            Me.ColumnHeader87.Text = "Course"
            Me.ColumnHeader87.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            Me.ColumnHeader87.Width = 130
            '
            'ColumnHeader88
            '
            Me.ColumnHeader88.Text = "Year Level"
            Me.ColumnHeader88.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            Me.ColumnHeader88.Width = 130
            '
            'ColumnHeader89
            '
            Me.ColumnHeader89.Text = "Semester"
            Me.ColumnHeader89.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            Me.ColumnHeader89.Width = 130
            '
            'ColumnHeader90
            '
            Me.ColumnHeader90.Text = "S.Y"
            Me.ColumnHeader90.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            Me.ColumnHeader90.Width = 130
            '
            'ColumnHeader91
            '
            Me.ColumnHeader91.Text = "Contact"
            Me.ColumnHeader91.Width = 130
            '
            'ColumnHeader92
            '
            Me.ColumnHeader92.DisplayIndex = 12
            Me.ColumnHeader92.Text = "Description"
            Me.ColumnHeader92.Width = 130
            '
            'ColumnHeader94
            '
            Me.ColumnHeader94.Text = "Directory"
            Me.ColumnHeader94.Width = 130
            '
            'ColumnHeader93
            '
            Me.ColumnHeader93.DisplayIndex = 10
            Me.ColumnHeader93.Text = "Status"
            Me.ColumnHeader93.Width = 130
            '
            'MetroTabPanel5
            '
            Me.MetroTabPanel5.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
            Me.MetroTabPanel5.Controls.Add(Me.ExpandableSplitter8)
            Me.MetroTabPanel5.Controls.Add(Me.ExpandablePanel2)
            Me.MetroTabPanel5.Controls.Add(Me.MetroToolbar5)
            Me.MetroTabPanel5.Controls.Add(Me.LabelX2)
            Me.MetroTabPanel5.Controls.Add(Me.ExpandableSplitter3)
            Me.MetroTabPanel5.Controls.Add(Me.ListViewEx2)
            Me.MetroTabPanel5.Dock = System.Windows.Forms.DockStyle.Fill
            Me.MetroTabPanel5.Location = New System.Drawing.Point(0, 51)
            Me.MetroTabPanel5.Name = "MetroTabPanel5"
            Me.MetroTabPanel5.Padding = New System.Windows.Forms.Padding(3, 0, 3, 3)
            Me.MetroTabPanel5.Size = New System.Drawing.Size(911, 593)
            '
            '
            '
            Me.MetroTabPanel5.Style.CornerType = DevComponents.DotNetBar.eCornerType.Square
            '
            '
            '
            Me.MetroTabPanel5.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
            '
            '
            '
            Me.MetroTabPanel5.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.MetroTabPanel5.TabIndex = 6
            Me.MetroTabPanel5.Visible = False
            '
            'ExpandableSplitter8
            '
            Me.ExpandableSplitter8.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer))
            Me.ExpandableSplitter8.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer))
            Me.ExpandableSplitter8.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
            Me.ExpandableSplitter8.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
            Me.ExpandableSplitter8.Dock = System.Windows.Forms.DockStyle.Top
            Me.ExpandableSplitter8.ExpandFillColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer))
            Me.ExpandableSplitter8.ExpandFillColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
            Me.ExpandableSplitter8.ExpandLineColor = System.Drawing.Color.Black
            Me.ExpandableSplitter8.ExpandLineColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText
            Me.ExpandableSplitter8.ForeColor = System.Drawing.Color.Black
            Me.ExpandableSplitter8.GripDarkColor = System.Drawing.Color.Black
            Me.ExpandableSplitter8.GripDarkColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText
            Me.ExpandableSplitter8.GripLightColor = System.Drawing.Color.White
            Me.ExpandableSplitter8.GripLightColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
            Me.ExpandableSplitter8.HotBackColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer))
            Me.ExpandableSplitter8.HotBackColor2 = System.Drawing.Color.Empty
            Me.ExpandableSplitter8.HotBackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemPressedBackground2
            Me.ExpandableSplitter8.HotBackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemPressedBackground
            Me.ExpandableSplitter8.HotExpandFillColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer))
            Me.ExpandableSplitter8.HotExpandFillColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
            Me.ExpandableSplitter8.HotExpandLineColor = System.Drawing.Color.Black
            Me.ExpandableSplitter8.HotExpandLineColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText
            Me.ExpandableSplitter8.HotGripDarkColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer))
            Me.ExpandableSplitter8.HotGripDarkColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
            Me.ExpandableSplitter8.HotGripLightColor = System.Drawing.Color.White
            Me.ExpandableSplitter8.HotGripLightColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
            Me.ExpandableSplitter8.Location = New System.Drawing.Point(3, 491)
            Me.ExpandableSplitter8.Name = "ExpandableSplitter8"
            Me.ExpandableSplitter8.Size = New System.Drawing.Size(905, 10)
            Me.ExpandableSplitter8.Style = DevComponents.DotNetBar.eSplitterStyle.Office2007
            Me.ExpandableSplitter8.TabIndex = 51
            Me.ExpandableSplitter8.TabStop = False
            '
            'ExpandablePanel2
            '
            Me.ExpandablePanel2.CanvasColor = System.Drawing.SystemColors.Window
            Me.ExpandablePanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
            Me.ExpandablePanel2.Controls.Add(Me.business_prev_id)
            Me.ExpandablePanel2.Controls.Add(Me.b_status)
            Me.ExpandablePanel2.Controls.Add(Me.LabelX60)
            Me.ExpandablePanel2.Controls.Add(Me.b_rembalance)
            Me.ExpandablePanel2.Controls.Add(Me.LabelX59)
            Me.ExpandablePanel2.Controls.Add(Me.b_description)
            Me.ExpandablePanel2.Controls.Add(Me.LabelX58)
            Me.ExpandablePanel2.Controls.Add(Me.LabelX7)
            Me.ExpandablePanel2.Controls.Add(Me.b_fullname)
            Me.ExpandablePanel2.Controls.Add(Me.ButtonX2)
            Me.ExpandablePanel2.Controls.Add(Me.b_directorypath)
            Me.ExpandablePanel2.Controls.Add(Me.LabelX9)
            Me.ExpandablePanel2.Controls.Add(Me.b_id)
            Me.ExpandablePanel2.Controls.Add(Me.LabelX10)
            Me.ExpandablePanel2.Controls.Add(Me.b_contact)
            Me.ExpandablePanel2.Controls.Add(Me.LabelX11)
            Me.ExpandablePanel2.Controls.Add(Me.b_semester)
            Me.ExpandablePanel2.Controls.Add(Me.b_acadyear)
            Me.ExpandablePanel2.Controls.Add(Me.LabelX12)
            Me.ExpandablePanel2.Controls.Add(Me.b_yearlvl)
            Me.ExpandablePanel2.Controls.Add(Me.LabelX14)
            Me.ExpandablePanel2.Controls.Add(Me.b_course)
            Me.ExpandablePanel2.Controls.Add(Me.LabelX15)
            Me.ExpandablePanel2.Controls.Add(Me.b_middlename)
            Me.ExpandablePanel2.Controls.Add(Me.b_firstname)
            Me.ExpandablePanel2.Controls.Add(Me.b_lastname)
            Me.ExpandablePanel2.Controls.Add(Me.LabelX16)
            Me.ExpandablePanel2.Controls.Add(Me.b_studid)
            Me.ExpandablePanel2.Controls.Add(Me.LabelX17)
            Me.ExpandablePanel2.Controls.Add(Me.PictureBox2)
            Me.ExpandablePanel2.DisabledBackColor = System.Drawing.Color.Empty
            Me.ExpandablePanel2.Dock = System.Windows.Forms.DockStyle.Top
            Me.ExpandablePanel2.HideControlsWhenCollapsed = True
            Me.ExpandablePanel2.Location = New System.Drawing.Point(3, 246)
            Me.ExpandablePanel2.Name = "ExpandablePanel2"
            Me.ExpandablePanel2.Size = New System.Drawing.Size(905, 245)
            Me.ExpandablePanel2.Style.Alignment = System.Drawing.StringAlignment.Center
            Me.ExpandablePanel2.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
            Me.ExpandablePanel2.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
            Me.ExpandablePanel2.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText
            Me.ExpandablePanel2.Style.GradientAngle = 90
            Me.ExpandablePanel2.TabIndex = 50
            Me.ExpandablePanel2.TitleStyle.Alignment = System.Drawing.StringAlignment.Center
            Me.ExpandablePanel2.TitleStyle.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
            Me.ExpandablePanel2.TitleStyle.Border = DevComponents.DotNetBar.eBorderType.RaisedInner
            Me.ExpandablePanel2.TitleStyle.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
            Me.ExpandablePanel2.TitleStyle.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
            Me.ExpandablePanel2.TitleStyle.GradientAngle = 90
            Me.ExpandablePanel2.TitleText = "Student Information"
            '
            'business_prev_id
            '
            Me.business_prev_id.BackColor = System.Drawing.Color.White
            '
            '
            '
            Me.business_prev_id.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.business_prev_id.ForeColor = System.Drawing.Color.Black
            Me.business_prev_id.Location = New System.Drawing.Point(656, 186)
            Me.business_prev_id.Name = "business_prev_id"
            Me.business_prev_id.Size = New System.Drawing.Size(75, 23)
            Me.business_prev_id.TabIndex = 33
            Me.business_prev_id.Text = "LabelX51"
            '
            'b_status
            '
            Me.b_status.DisplayMember = "Text"
            Me.b_status.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
            Me.b_status.ForeColor = System.Drawing.Color.Black
            Me.b_status.FormattingEnabled = True
            Me.b_status.ItemHeight = 17
            Me.b_status.Items.AddRange(New Object() {Me.ComboItem1, Me.ComboItem2})
            Me.b_status.Location = New System.Drawing.Point(441, 179)
            Me.b_status.Name = "b_status"
            Me.b_status.Size = New System.Drawing.Size(100, 23)
            Me.b_status.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
            Me.b_status.TabIndex = 32
            '
            'ComboItem1
            '
            Me.ComboItem1.Text = "CLEARED"
            '
            'ComboItem2
            '
            Me.ComboItem2.Text = "NOT CLEARED"
            '
            'LabelX60
            '
            Me.LabelX60.BackColor = System.Drawing.Color.Transparent
            '
            '
            '
            Me.LabelX60.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.LabelX60.ForeColor = System.Drawing.Color.Black
            Me.LabelX60.Location = New System.Drawing.Point(360, 178)
            Me.LabelX60.Name = "LabelX60"
            Me.LabelX60.Size = New System.Drawing.Size(75, 23)
            Me.LabelX60.TabIndex = 31
            Me.LabelX60.Text = "Status:"
            Me.LabelX60.TextAlignment = System.Drawing.StringAlignment.Far
            '
            'b_rembalance
            '
            Me.b_rembalance.BackColor = System.Drawing.Color.White
            '
            '
            '
            Me.b_rembalance.Border.Class = "TextBoxBorder"
            Me.b_rembalance.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.b_rembalance.DisabledBackColor = System.Drawing.Color.White
            Me.b_rembalance.ForeColor = System.Drawing.Color.Black
            Me.b_rembalance.Location = New System.Drawing.Point(441, 151)
            Me.b_rembalance.Name = "b_rembalance"
            Me.b_rembalance.PreventEnterBeep = True
            Me.b_rembalance.Size = New System.Drawing.Size(100, 22)
            Me.b_rembalance.TabIndex = 30
            '
            'LabelX59
            '
            Me.LabelX59.BackColor = System.Drawing.Color.Transparent
            '
            '
            '
            Me.LabelX59.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.LabelX59.ForeColor = System.Drawing.Color.Black
            Me.LabelX59.Location = New System.Drawing.Point(335, 150)
            Me.LabelX59.Name = "LabelX59"
            Me.LabelX59.Size = New System.Drawing.Size(100, 23)
            Me.LabelX59.TabIndex = 29
            Me.LabelX59.Text = "Remaining Balance:"
            Me.LabelX59.TextAlignment = System.Drawing.StringAlignment.Far
            '
            'b_description
            '
            Me.b_description.BackColor = System.Drawing.Color.White
            '
            '
            '
            Me.b_description.Border.Class = "TextBoxBorder"
            Me.b_description.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.b_description.DisabledBackColor = System.Drawing.Color.White
            Me.b_description.ForeColor = System.Drawing.Color.Black
            Me.b_description.Location = New System.Drawing.Point(441, 123)
            Me.b_description.Name = "b_description"
            Me.b_description.PreventEnterBeep = True
            Me.b_description.Size = New System.Drawing.Size(100, 22)
            Me.b_description.TabIndex = 28
            '
            'LabelX58
            '
            Me.LabelX58.BackColor = System.Drawing.Color.Transparent
            '
            '
            '
            Me.LabelX58.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.LabelX58.ForeColor = System.Drawing.Color.Black
            Me.LabelX58.Location = New System.Drawing.Point(360, 122)
            Me.LabelX58.Name = "LabelX58"
            Me.LabelX58.Size = New System.Drawing.Size(75, 23)
            Me.LabelX58.TabIndex = 27
            Me.LabelX58.Text = "Description:"
            Me.LabelX58.TextAlignment = System.Drawing.StringAlignment.Far
            '
            'LabelX7
            '
            Me.LabelX7.BackColor = System.Drawing.Color.White
            '
            '
            '
            Me.LabelX7.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.LabelX7.ForeColor = System.Drawing.Color.Black
            Me.LabelX7.Location = New System.Drawing.Point(702, 48)
            Me.LabelX7.Name = "LabelX7"
            Me.LabelX7.Size = New System.Drawing.Size(32, 23)
            Me.LabelX7.TabIndex = 26
            Me.LabelX7.Text = "LabelX7"
            Me.LabelX7.Visible = False
            '
            'b_fullname
            '
            Me.b_fullname.BackColor = System.Drawing.Color.White
            '
            '
            '
            Me.b_fullname.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.b_fullname.ForeColor = System.Drawing.Color.Black
            Me.b_fullname.Location = New System.Drawing.Point(654, 80)
            Me.b_fullname.Name = "b_fullname"
            Me.b_fullname.Size = New System.Drawing.Size(215, 23)
            Me.b_fullname.TabIndex = 25
            Me.b_fullname.Text = "LabelX7"
            Me.b_fullname.Visible = False
            '
            'ButtonX2
            '
            Me.ButtonX2.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
            Me.ButtonX2.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
            Me.ButtonX2.Location = New System.Drawing.Point(12, 206)
            Me.ButtonX2.Name = "ButtonX2"
            Me.ButtonX2.Size = New System.Drawing.Size(130, 23)
            Me.ButtonX2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
            Me.ButtonX2.TabIndex = 24
            Me.ButtonX2.Text = "Upload"
            '
            'b_directorypath
            '
            Me.b_directorypath.BackColor = System.Drawing.Color.White
            '
            '
            '
            Me.b_directorypath.Border.Class = "TextBoxBorder"
            Me.b_directorypath.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.b_directorypath.DisabledBackColor = System.Drawing.Color.White
            Me.b_directorypath.ForeColor = System.Drawing.Color.Black
            Me.b_directorypath.Location = New System.Drawing.Point(229, 206)
            Me.b_directorypath.Name = "b_directorypath"
            Me.b_directorypath.PreventEnterBeep = True
            Me.b_directorypath.Size = New System.Drawing.Size(312, 22)
            Me.b_directorypath.TabIndex = 23
            '
            'LabelX9
            '
            Me.LabelX9.BackColor = System.Drawing.Color.Transparent
            '
            '
            '
            Me.LabelX9.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.LabelX9.ForeColor = System.Drawing.Color.Black
            Me.LabelX9.Location = New System.Drawing.Point(148, 206)
            Me.LabelX9.Name = "LabelX9"
            Me.LabelX9.Size = New System.Drawing.Size(75, 23)
            Me.LabelX9.TabIndex = 22
            Me.LabelX9.Text = "Directory:"
            '
            'b_id
            '
            Me.b_id.BackColor = System.Drawing.Color.White
            '
            '
            '
            Me.b_id.Border.Class = "TextBoxBorder"
            Me.b_id.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.b_id.DisabledBackColor = System.Drawing.Color.White
            Me.b_id.Enabled = False
            Me.b_id.ForeColor = System.Drawing.Color.Black
            Me.b_id.Location = New System.Drawing.Point(34, 37)
            Me.b_id.Name = "b_id"
            Me.b_id.PreventEnterBeep = True
            Me.b_id.Size = New System.Drawing.Size(25, 22)
            Me.b_id.TabIndex = 21
            '
            'LabelX10
            '
            Me.LabelX10.BackColor = System.Drawing.Color.Transparent
            '
            '
            '
            Me.LabelX10.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.LabelX10.ForeColor = System.Drawing.Color.Black
            Me.LabelX10.Location = New System.Drawing.Point(8, 36)
            Me.LabelX10.Name = "LabelX10"
            Me.LabelX10.Size = New System.Drawing.Size(20, 23)
            Me.LabelX10.TabIndex = 20
            Me.LabelX10.Text = "ID:"
            '
            'b_contact
            '
            Me.b_contact.BackColor = System.Drawing.Color.White
            '
            '
            '
            Me.b_contact.Border.Class = "TextBoxBorder"
            Me.b_contact.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.b_contact.DisabledBackColor = System.Drawing.Color.White
            Me.b_contact.ForeColor = System.Drawing.Color.Black
            Me.b_contact.Location = New System.Drawing.Point(229, 179)
            Me.b_contact.Name = "b_contact"
            Me.b_contact.PreventEnterBeep = True
            Me.b_contact.Size = New System.Drawing.Size(100, 22)
            Me.b_contact.TabIndex = 19
            '
            'LabelX11
            '
            Me.LabelX11.BackColor = System.Drawing.Color.Transparent
            '
            '
            '
            Me.LabelX11.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.LabelX11.ForeColor = System.Drawing.Color.Black
            Me.LabelX11.Location = New System.Drawing.Point(148, 179)
            Me.LabelX11.Name = "LabelX11"
            Me.LabelX11.Size = New System.Drawing.Size(75, 23)
            Me.LabelX11.TabIndex = 18
            Me.LabelX11.Text = "Contact #:"
            '
            'b_semester
            '
            Me.b_semester.BackColor = System.Drawing.Color.White
            '
            '
            '
            Me.b_semester.Border.Class = "TextBoxBorder"
            Me.b_semester.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.b_semester.DisabledBackColor = System.Drawing.Color.White
            Me.b_semester.ForeColor = System.Drawing.Color.Black
            Me.b_semester.Location = New System.Drawing.Point(229, 151)
            Me.b_semester.Name = "b_semester"
            Me.b_semester.PreventEnterBeep = True
            Me.b_semester.Size = New System.Drawing.Size(100, 22)
            Me.b_semester.TabIndex = 17
            '
            'b_acadyear
            '
            Me.b_acadyear.BackColor = System.Drawing.Color.White
            '
            '
            '
            Me.b_acadyear.Border.Class = "TextBoxBorder"
            Me.b_acadyear.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.b_acadyear.DisabledBackColor = System.Drawing.Color.White
            Me.b_acadyear.ForeColor = System.Drawing.Color.Black
            Me.b_acadyear.Location = New System.Drawing.Point(229, 123)
            Me.b_acadyear.Name = "b_acadyear"
            Me.b_acadyear.PreventEnterBeep = True
            Me.b_acadyear.Size = New System.Drawing.Size(100, 22)
            Me.b_acadyear.TabIndex = 16
            '
            'LabelX12
            '
            Me.LabelX12.BackColor = System.Drawing.Color.Transparent
            '
            '
            '
            Me.LabelX12.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.LabelX12.ForeColor = System.Drawing.Color.Black
            Me.LabelX12.Location = New System.Drawing.Point(148, 151)
            Me.LabelX12.Name = "LabelX12"
            Me.LabelX12.Size = New System.Drawing.Size(75, 23)
            Me.LabelX12.TabIndex = 15
            Me.LabelX12.Text = "Semester:"
            '
            'b_yearlvl
            '
            Me.b_yearlvl.BackColor = System.Drawing.Color.White
            '
            '
            '
            Me.b_yearlvl.Border.Class = "TextBoxBorder"
            Me.b_yearlvl.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.b_yearlvl.DisabledBackColor = System.Drawing.Color.White
            Me.b_yearlvl.ForeColor = System.Drawing.Color.Black
            Me.b_yearlvl.Location = New System.Drawing.Point(281, 94)
            Me.b_yearlvl.Name = "b_yearlvl"
            Me.b_yearlvl.PreventEnterBeep = True
            Me.b_yearlvl.Size = New System.Drawing.Size(48, 22)
            Me.b_yearlvl.TabIndex = 14
            '
            'LabelX14
            '
            Me.LabelX14.BackColor = System.Drawing.Color.Transparent
            '
            '
            '
            Me.LabelX14.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.LabelX14.ForeColor = System.Drawing.Color.Black
            Me.LabelX14.Location = New System.Drawing.Point(148, 123)
            Me.LabelX14.Name = "LabelX14"
            Me.LabelX14.Size = New System.Drawing.Size(75, 23)
            Me.LabelX14.TabIndex = 13
            Me.LabelX14.Text = "Academic Yr:"
            '
            'b_course
            '
            Me.b_course.BackColor = System.Drawing.Color.White
            '
            '
            '
            Me.b_course.Border.Class = "TextBoxBorder"
            Me.b_course.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.b_course.DisabledBackColor = System.Drawing.Color.White
            Me.b_course.ForeColor = System.Drawing.Color.Black
            Me.b_course.Location = New System.Drawing.Point(229, 95)
            Me.b_course.Name = "b_course"
            Me.b_course.PreventEnterBeep = True
            Me.b_course.Size = New System.Drawing.Size(46, 22)
            Me.b_course.TabIndex = 12
            '
            'LabelX15
            '
            Me.LabelX15.BackColor = System.Drawing.Color.Transparent
            '
            '
            '
            Me.LabelX15.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.LabelX15.ForeColor = System.Drawing.Color.Black
            Me.LabelX15.Location = New System.Drawing.Point(148, 94)
            Me.LabelX15.Name = "LabelX15"
            Me.LabelX15.Size = New System.Drawing.Size(75, 23)
            Me.LabelX15.TabIndex = 11
            Me.LabelX15.Text = "Course / Year:"
            '
            'b_middlename
            '
            Me.b_middlename.BackColor = System.Drawing.Color.White
            '
            '
            '
            Me.b_middlename.Border.Class = "TextBoxBorder"
            Me.b_middlename.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.b_middlename.DisabledBackColor = System.Drawing.Color.White
            Me.b_middlename.ForeColor = System.Drawing.Color.Black
            Me.b_middlename.Location = New System.Drawing.Point(441, 66)
            Me.b_middlename.Name = "b_middlename"
            Me.b_middlename.PreventEnterBeep = True
            Me.b_middlename.Size = New System.Drawing.Size(100, 22)
            Me.b_middlename.TabIndex = 10
            '
            'b_firstname
            '
            Me.b_firstname.BackColor = System.Drawing.Color.White
            '
            '
            '
            Me.b_firstname.Border.Class = "TextBoxBorder"
            Me.b_firstname.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.b_firstname.DisabledBackColor = System.Drawing.Color.White
            Me.b_firstname.ForeColor = System.Drawing.Color.Black
            Me.b_firstname.Location = New System.Drawing.Point(335, 66)
            Me.b_firstname.Name = "b_firstname"
            Me.b_firstname.PreventEnterBeep = True
            Me.b_firstname.Size = New System.Drawing.Size(100, 22)
            Me.b_firstname.TabIndex = 9
            '
            'b_lastname
            '
            Me.b_lastname.BackColor = System.Drawing.Color.White
            '
            '
            '
            Me.b_lastname.Border.Class = "TextBoxBorder"
            Me.b_lastname.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.b_lastname.DisabledBackColor = System.Drawing.Color.White
            Me.b_lastname.ForeColor = System.Drawing.Color.Black
            Me.b_lastname.Location = New System.Drawing.Point(229, 67)
            Me.b_lastname.Name = "b_lastname"
            Me.b_lastname.PreventEnterBeep = True
            Me.b_lastname.Size = New System.Drawing.Size(100, 22)
            Me.b_lastname.TabIndex = 8
            '
            'LabelX16
            '
            Me.LabelX16.BackColor = System.Drawing.Color.Transparent
            '
            '
            '
            Me.LabelX16.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.LabelX16.ForeColor = System.Drawing.Color.Black
            Me.LabelX16.Location = New System.Drawing.Point(148, 37)
            Me.LabelX16.Name = "LabelX16"
            Me.LabelX16.Size = New System.Drawing.Size(75, 23)
            Me.LabelX16.TabIndex = 7
            Me.LabelX16.Text = "Student ID:"
            '
            'b_studid
            '
            Me.b_studid.BackColor = System.Drawing.Color.White
            '
            '
            '
            Me.b_studid.Border.Class = "TextBoxBorder"
            Me.b_studid.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.b_studid.DisabledBackColor = System.Drawing.Color.White
            Me.b_studid.ForeColor = System.Drawing.Color.Black
            Me.b_studid.Location = New System.Drawing.Point(229, 37)
            Me.b_studid.Name = "b_studid"
            Me.b_studid.PreventEnterBeep = True
            Me.b_studid.Size = New System.Drawing.Size(100, 22)
            Me.b_studid.TabIndex = 6
            '
            'LabelX17
            '
            Me.LabelX17.BackColor = System.Drawing.Color.Transparent
            '
            '
            '
            Me.LabelX17.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.LabelX17.ForeColor = System.Drawing.Color.Black
            Me.LabelX17.Location = New System.Drawing.Point(148, 66)
            Me.LabelX17.Name = "LabelX17"
            Me.LabelX17.Size = New System.Drawing.Size(75, 23)
            Me.LabelX17.TabIndex = 5
            Me.LabelX17.Text = "Name:"
            '
            'PictureBox2
            '
            Me.PictureBox2.BackColor = System.Drawing.Color.White
            Me.PictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
            Me.PictureBox2.ForeColor = System.Drawing.Color.Black
            Me.PictureBox2.Location = New System.Drawing.Point(12, 67)
            Me.PictureBox2.Name = "PictureBox2"
            Me.PictureBox2.Size = New System.Drawing.Size(130, 136)
            Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
            Me.PictureBox2.TabIndex = 4
            Me.PictureBox2.TabStop = False
            '
            'MetroToolbar5
            '
            Me.MetroToolbar5.BackColor = System.Drawing.Color.White
            '
            '
            '
            Me.MetroToolbar5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.MetroToolbar5.ContainerControlProcessDialogKey = True
            Me.MetroToolbar5.DragDropSupport = True
            Me.MetroToolbar5.ExpandDirection = DevComponents.DotNetBar.Metro.eExpandDirection.Top
            Me.MetroToolbar5.ExtraItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.deleteBusinessButton})
            Me.MetroToolbar5.ForeColor = System.Drawing.Color.Black
            Me.MetroToolbar5.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.searchBusinessButton, Me.addBusinessButton, Me.updateBusinessButton})
            Me.MetroToolbar5.LicenseKey = "F962CEC7-CD8F-4911-A9E9-CAB39962FC1F"
            Me.MetroToolbar5.Location = New System.Drawing.Point(286, 549)
            Me.MetroToolbar5.Name = "MetroToolbar5"
            Me.MetroToolbar5.Size = New System.Drawing.Size(388, 38)
            Me.MetroToolbar5.TabIndex = 23
            Me.MetroToolbar5.Text = "Invoices"
            '
            'deleteBusinessButton
            '
            Me.deleteBusinessButton.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
            Me.deleteBusinessButton.Image = Global.My.Resources.Resources.Delete1
            Me.deleteBusinessButton.ImageAlt = Global.My.Resources.Resources.DeleteWhite
            Me.deleteBusinessButton.Name = "deleteBusinessButton"
            Me.deleteBusinessButton.Text = "Delete Record"
            Me.deleteBusinessButton.Tooltip = "Delete Selected Record"
            '
            'searchBusinessButton
            '
            Me.searchBusinessButton.AutoExpandOnClick = True
            Me.searchBusinessButton.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
            Me.searchBusinessButton.Image = Global.My.Resources.Resources.search_ic_crop
            Me.searchBusinessButton.ImageAlt = Global.My.Resources.Resources.NewInvoiceWhite
            Me.searchBusinessButton.Name = "searchBusinessButton"
            Me.searchBusinessButton.PopupSide = DevComponents.DotNetBar.ePopupSide.Top
            Me.searchBusinessButton.PopupType = DevComponents.DotNetBar.ePopupType.ToolBar
            Me.searchBusinessButton.PopupWidth = 50
            Me.searchBusinessButton.Shape = New DevComponents.DotNetBar.RoundRectangleShapeDescriptor(2)
            Me.searchBusinessButton.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.searchBusinessTxt})
            Me.searchBusinessButton.Text = "Search Record"
            Me.searchBusinessButton.Tooltip = "Search"
            '
            'searchBusinessTxt
            '
            Me.searchBusinessTxt.FocusHighlightColor = System.Drawing.Color.YellowGreen
            Me.searchBusinessTxt.Name = "searchBusinessTxt"
            Me.searchBusinessTxt.Stretch = True
            Me.searchBusinessTxt.TextBoxWidth = 200
            Me.searchBusinessTxt.WatermarkColor = System.Drawing.SystemColors.GrayText
            '
            'addBusinessButton
            '
            Me.addBusinessButton.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
            Me.addBusinessButton.Image = Global.My.Resources.Resources.addnew_edit
            Me.addBusinessButton.ImageAlt = Global.My.Resources.Resources.BookNoteWhite
            Me.addBusinessButton.Name = "addBusinessButton"
            Me.addBusinessButton.PopupSide = DevComponents.DotNetBar.ePopupSide.Top
            Me.addBusinessButton.Text = "Add Record"
            Me.addBusinessButton.Tooltip = "Add new Record"
            '
            'updateBusinessButton
            '
            Me.updateBusinessButton.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
            Me.updateBusinessButton.Image = Global.My.Resources.Resources.edit_new_res
            Me.updateBusinessButton.ImageAlt = Global.My.Resources.Resources.PaperClipWhite
            Me.updateBusinessButton.Name = "updateBusinessButton"
            Me.updateBusinessButton.Text = "Update Record"
            Me.updateBusinessButton.Tooltip = "Update an existimg Record"
            '
            'LabelX2
            '
            Me.LabelX2.BackColor = System.Drawing.Color.White
            '
            '
            '
            Me.LabelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.LabelX2.Enabled = False
            Me.LabelX2.ForeColor = System.Drawing.Color.Black
            Me.LabelX2.Location = New System.Drawing.Point(47, 252)
            Me.LabelX2.Name = "LabelX2"
            Me.LabelX2.Size = New System.Drawing.Size(98, 23)
            Me.LabelX2.TabIndex = 22
            Me.LabelX2.Text = "LabelX2"
            Me.LabelX2.Visible = False
            '
            'ExpandableSplitter3
            '
            Me.ExpandableSplitter3.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer))
            Me.ExpandableSplitter3.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer))
            Me.ExpandableSplitter3.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
            Me.ExpandableSplitter3.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
            Me.ExpandableSplitter3.Dock = System.Windows.Forms.DockStyle.Top
            Me.ExpandableSplitter3.ExpandFillColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer))
            Me.ExpandableSplitter3.ExpandFillColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
            Me.ExpandableSplitter3.ExpandLineColor = System.Drawing.Color.Black
            Me.ExpandableSplitter3.ExpandLineColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText
            Me.ExpandableSplitter3.ForeColor = System.Drawing.Color.Black
            Me.ExpandableSplitter3.GripDarkColor = System.Drawing.Color.Black
            Me.ExpandableSplitter3.GripDarkColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText
            Me.ExpandableSplitter3.GripLightColor = System.Drawing.Color.White
            Me.ExpandableSplitter3.GripLightColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
            Me.ExpandableSplitter3.HotBackColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer))
            Me.ExpandableSplitter3.HotBackColor2 = System.Drawing.Color.Empty
            Me.ExpandableSplitter3.HotBackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemPressedBackground2
            Me.ExpandableSplitter3.HotBackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemPressedBackground
            Me.ExpandableSplitter3.HotExpandFillColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer))
            Me.ExpandableSplitter3.HotExpandFillColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
            Me.ExpandableSplitter3.HotExpandLineColor = System.Drawing.Color.Black
            Me.ExpandableSplitter3.HotExpandLineColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText
            Me.ExpandableSplitter3.HotGripDarkColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer))
            Me.ExpandableSplitter3.HotGripDarkColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
            Me.ExpandableSplitter3.HotGripLightColor = System.Drawing.Color.White
            Me.ExpandableSplitter3.HotGripLightColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
            Me.ExpandableSplitter3.Location = New System.Drawing.Point(3, 240)
            Me.ExpandableSplitter3.Name = "ExpandableSplitter3"
            Me.ExpandableSplitter3.Size = New System.Drawing.Size(905, 6)
            Me.ExpandableSplitter3.Style = DevComponents.DotNetBar.eSplitterStyle.Office2007
            Me.ExpandableSplitter3.TabIndex = 4
            Me.ExpandableSplitter3.TabStop = False
            '
            'ListViewEx2
            '
            Me.ListViewEx2.BackColor = System.Drawing.Color.White
            '
            '
            '
            Me.ListViewEx2.Border.Class = "ListViewBorder"
            Me.ListViewEx2.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.ListViewEx2.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader12, Me.ColumnHeader13, Me.ColumnHeader14, Me.ColumnHeader15, Me.ColumnHeader16, Me.ColumnHeader17, Me.ColumnHeader18, Me.ColumnHeader19, Me.ColumnHeader20, Me.ColumnHeader21, Me.ColumnHeader11, Me.ColumnHeader60, Me.ColumnHeader61, Me.ColumnHeader73})
            Me.ListViewEx2.DisabledBackColor = System.Drawing.Color.Empty
            Me.ListViewEx2.Dock = System.Windows.Forms.DockStyle.Top
            Me.ListViewEx2.ForeColor = System.Drawing.Color.Black
            Me.ListViewEx2.FullRowSelect = True
            Me.ListViewEx2.Location = New System.Drawing.Point(3, 0)
            Me.ListViewEx2.Name = "ListViewEx2"
            Me.ListViewEx2.Size = New System.Drawing.Size(905, 240)
            Me.ListViewEx2.TabIndex = 2
            Me.ListViewEx2.UseCompatibleStateImageBehavior = False
            Me.ListViewEx2.View = System.Windows.Forms.View.Details
            '
            'ColumnHeader12
            '
            Me.ColumnHeader12.Text = "ID"
            '
            'ColumnHeader13
            '
            Me.ColumnHeader13.Text = "Student Number"
            Me.ColumnHeader13.Width = 130
            '
            'ColumnHeader14
            '
            Me.ColumnHeader14.Text = "Lastname"
            Me.ColumnHeader14.Width = 130
            '
            'ColumnHeader15
            '
            Me.ColumnHeader15.Text = "Firstname"
            Me.ColumnHeader15.Width = 130
            '
            'ColumnHeader16
            '
            Me.ColumnHeader16.Text = "Middlename"
            Me.ColumnHeader16.Width = 130
            '
            'ColumnHeader17
            '
            Me.ColumnHeader17.Text = "Course"
            Me.ColumnHeader17.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            Me.ColumnHeader17.Width = 130
            '
            'ColumnHeader18
            '
            Me.ColumnHeader18.Text = "Year Level"
            Me.ColumnHeader18.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            Me.ColumnHeader18.Width = 130
            '
            'ColumnHeader19
            '
            Me.ColumnHeader19.Text = "Semester"
            Me.ColumnHeader19.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            Me.ColumnHeader19.Width = 130
            '
            'ColumnHeader20
            '
            Me.ColumnHeader20.Text = "S.Y"
            Me.ColumnHeader20.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            Me.ColumnHeader20.Width = 130
            '
            'ColumnHeader21
            '
            Me.ColumnHeader21.Text = "Contact"
            Me.ColumnHeader21.Width = 130
            '
            'ColumnHeader11
            '
            Me.ColumnHeader11.Text = "Description"
            Me.ColumnHeader11.Width = 130
            '
            'ColumnHeader60
            '
            Me.ColumnHeader60.Text = "Remaining Balance"
            Me.ColumnHeader60.Width = 130
            '
            'ColumnHeader61
            '
            Me.ColumnHeader61.Text = "Status"
            Me.ColumnHeader61.Width = 130
            '
            'ColumnHeader73
            '
            Me.ColumnHeader73.Text = "Directory"
            Me.ColumnHeader73.Width = 130
            '
            'MetroTabPanel3
            '
            Me.MetroTabPanel3.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
            Me.MetroTabPanel3.Controls.Add(Me.ExpandableSplitter10)
            Me.MetroTabPanel3.Controls.Add(Me.ExpandablePanel4)
            Me.MetroTabPanel3.Controls.Add(Me.MetroToolbar3)
            Me.MetroTabPanel3.Controls.Add(Me.LabelX4)
            Me.MetroTabPanel3.Controls.Add(Me.ExpandableSplitter5)
            Me.MetroTabPanel3.Controls.Add(Me.ListViewEx3)
            Me.MetroTabPanel3.Dock = System.Windows.Forms.DockStyle.Fill
            Me.MetroTabPanel3.Location = New System.Drawing.Point(0, 51)
            Me.MetroTabPanel3.Name = "MetroTabPanel3"
            Me.MetroTabPanel3.Padding = New System.Windows.Forms.Padding(3, 0, 3, 3)
            Me.MetroTabPanel3.Size = New System.Drawing.Size(911, 593)
            '
            '
            '
            Me.MetroTabPanel3.Style.CornerType = DevComponents.DotNetBar.eCornerType.Square
            '
            '
            '
            Me.MetroTabPanel3.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
            '
            '
            '
            Me.MetroTabPanel3.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.MetroTabPanel3.TabIndex = 3
            Me.MetroTabPanel3.Visible = False
            '
            'ExpandableSplitter10
            '
            Me.ExpandableSplitter10.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer))
            Me.ExpandableSplitter10.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer))
            Me.ExpandableSplitter10.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
            Me.ExpandableSplitter10.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
            Me.ExpandableSplitter10.Dock = System.Windows.Forms.DockStyle.Top
            Me.ExpandableSplitter10.ExpandFillColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer))
            Me.ExpandableSplitter10.ExpandFillColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
            Me.ExpandableSplitter10.ExpandLineColor = System.Drawing.Color.Black
            Me.ExpandableSplitter10.ExpandLineColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText
            Me.ExpandableSplitter10.ForeColor = System.Drawing.Color.Black
            Me.ExpandableSplitter10.GripDarkColor = System.Drawing.Color.Black
            Me.ExpandableSplitter10.GripDarkColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText
            Me.ExpandableSplitter10.GripLightColor = System.Drawing.Color.White
            Me.ExpandableSplitter10.GripLightColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
            Me.ExpandableSplitter10.HotBackColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer))
            Me.ExpandableSplitter10.HotBackColor2 = System.Drawing.Color.Empty
            Me.ExpandableSplitter10.HotBackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemPressedBackground2
            Me.ExpandableSplitter10.HotBackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemPressedBackground
            Me.ExpandableSplitter10.HotExpandFillColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer))
            Me.ExpandableSplitter10.HotExpandFillColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
            Me.ExpandableSplitter10.HotExpandLineColor = System.Drawing.Color.Black
            Me.ExpandableSplitter10.HotExpandLineColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText
            Me.ExpandableSplitter10.HotGripDarkColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer))
            Me.ExpandableSplitter10.HotGripDarkColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
            Me.ExpandableSplitter10.HotGripLightColor = System.Drawing.Color.White
            Me.ExpandableSplitter10.HotGripLightColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
            Me.ExpandableSplitter10.Location = New System.Drawing.Point(3, 491)
            Me.ExpandableSplitter10.Name = "ExpandableSplitter10"
            Me.ExpandableSplitter10.Size = New System.Drawing.Size(905, 10)
            Me.ExpandableSplitter10.Style = DevComponents.DotNetBar.eSplitterStyle.Office2007
            Me.ExpandableSplitter10.TabIndex = 51
            Me.ExpandableSplitter10.TabStop = False
            '
            'ExpandablePanel4
            '
            Me.ExpandablePanel4.CanvasColor = System.Drawing.SystemColors.Window
            Me.ExpandablePanel4.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
            Me.ExpandablePanel4.Controls.Add(Me.g_status)
            Me.ExpandablePanel4.Controls.Add(Me.LabelX8)
            Me.ExpandablePanel4.Controls.Add(Me.g_uncollectedTxt)
            Me.ExpandablePanel4.Controls.Add(Me.LabelX1)
            Me.ExpandablePanel4.Controls.Add(Me.g_fullname)
            Me.ExpandablePanel4.Controls.Add(Me.g_id_lbl)
            Me.ExpandablePanel4.Controls.Add(Me.ButtonX4)
            Me.ExpandablePanel4.Controls.Add(Me.g_directorypath)
            Me.ExpandablePanel4.Controls.Add(Me.LabelX30)
            Me.ExpandablePanel4.Controls.Add(Me.g_id)
            Me.ExpandablePanel4.Controls.Add(Me.LabelX31)
            Me.ExpandablePanel4.Controls.Add(Me.g_contact)
            Me.ExpandablePanel4.Controls.Add(Me.LabelX32)
            Me.ExpandablePanel4.Controls.Add(Me.g_semester)
            Me.ExpandablePanel4.Controls.Add(Me.g_acadyear)
            Me.ExpandablePanel4.Controls.Add(Me.LabelX33)
            Me.ExpandablePanel4.Controls.Add(Me.g_yearlevel)
            Me.ExpandablePanel4.Controls.Add(Me.LabelX34)
            Me.ExpandablePanel4.Controls.Add(Me.g_course)
            Me.ExpandablePanel4.Controls.Add(Me.LabelX35)
            Me.ExpandablePanel4.Controls.Add(Me.g_middlename)
            Me.ExpandablePanel4.Controls.Add(Me.g_firstname)
            Me.ExpandablePanel4.Controls.Add(Me.g_lastname)
            Me.ExpandablePanel4.Controls.Add(Me.LabelX36)
            Me.ExpandablePanel4.Controls.Add(Me.g_studid)
            Me.ExpandablePanel4.Controls.Add(Me.LabelX37)
            Me.ExpandablePanel4.Controls.Add(Me.PictureBox4)
            Me.ExpandablePanel4.DisabledBackColor = System.Drawing.Color.Empty
            Me.ExpandablePanel4.Dock = System.Windows.Forms.DockStyle.Top
            Me.ExpandablePanel4.HideControlsWhenCollapsed = True
            Me.ExpandablePanel4.Location = New System.Drawing.Point(3, 246)
            Me.ExpandablePanel4.Name = "ExpandablePanel4"
            Me.ExpandablePanel4.Size = New System.Drawing.Size(905, 245)
            Me.ExpandablePanel4.Style.Alignment = System.Drawing.StringAlignment.Center
            Me.ExpandablePanel4.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
            Me.ExpandablePanel4.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
            Me.ExpandablePanel4.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText
            Me.ExpandablePanel4.Style.GradientAngle = 90
            Me.ExpandablePanel4.TabIndex = 50
            Me.ExpandablePanel4.TitleStyle.Alignment = System.Drawing.StringAlignment.Center
            Me.ExpandablePanel4.TitleStyle.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
            Me.ExpandablePanel4.TitleStyle.Border = DevComponents.DotNetBar.eBorderType.RaisedInner
            Me.ExpandablePanel4.TitleStyle.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
            Me.ExpandablePanel4.TitleStyle.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
            Me.ExpandablePanel4.TitleStyle.GradientAngle = 90
            Me.ExpandablePanel4.TitleText = "Student Information"
            '
            'g_status
            '
            Me.g_status.DisplayMember = "Text"
            Me.g_status.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
            Me.g_status.ForeColor = System.Drawing.Color.Black
            Me.g_status.FormattingEnabled = True
            Me.g_status.ItemHeight = 17
            Me.g_status.Items.AddRange(New Object() {Me.ComboItem3, Me.ComboItem4})
            Me.g_status.Location = New System.Drawing.Point(441, 153)
            Me.g_status.Name = "g_status"
            Me.g_status.Size = New System.Drawing.Size(100, 23)
            Me.g_status.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
            Me.g_status.TabIndex = 30
            '
            'ComboItem3
            '
            Me.ComboItem3.Text = "CLEARED"
            '
            'ComboItem4
            '
            Me.ComboItem4.Text = "NOT CLEARED"
            '
            'LabelX8
            '
            Me.LabelX8.BackColor = System.Drawing.Color.Transparent
            '
            '
            '
            Me.LabelX8.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.LabelX8.ForeColor = System.Drawing.Color.Black
            Me.LabelX8.Location = New System.Drawing.Point(339, 151)
            Me.LabelX8.Name = "LabelX8"
            Me.LabelX8.Size = New System.Drawing.Size(96, 23)
            Me.LabelX8.TabIndex = 29
            Me.LabelX8.Text = "Status:"
            Me.LabelX8.TextAlignment = System.Drawing.StringAlignment.Far
            '
            'g_uncollectedTxt
            '
            Me.g_uncollectedTxt.BackColor = System.Drawing.Color.White
            '
            '
            '
            Me.g_uncollectedTxt.Border.Class = "TextBoxBorder"
            Me.g_uncollectedTxt.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.g_uncollectedTxt.DisabledBackColor = System.Drawing.Color.White
            Me.g_uncollectedTxt.ForeColor = System.Drawing.Color.Black
            Me.g_uncollectedTxt.Location = New System.Drawing.Point(441, 125)
            Me.g_uncollectedTxt.Name = "g_uncollectedTxt"
            Me.g_uncollectedTxt.PreventEnterBeep = True
            Me.g_uncollectedTxt.Size = New System.Drawing.Size(100, 22)
            Me.g_uncollectedTxt.TabIndex = 28
            '
            'LabelX1
            '
            Me.LabelX1.BackColor = System.Drawing.Color.Transparent
            '
            '
            '
            Me.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.LabelX1.ForeColor = System.Drawing.Color.Black
            Me.LabelX1.Location = New System.Drawing.Point(339, 122)
            Me.LabelX1.Name = "LabelX1"
            Me.LabelX1.Size = New System.Drawing.Size(96, 23)
            Me.LabelX1.TabIndex = 27
            Me.LabelX1.Text = "Uncollected Req:"
            Me.LabelX1.TextAlignment = System.Drawing.StringAlignment.Far
            '
            'g_fullname
            '
            Me.g_fullname.BackColor = System.Drawing.Color.White
            '
            '
            '
            Me.g_fullname.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.g_fullname.ForeColor = System.Drawing.Color.Black
            Me.g_fullname.Location = New System.Drawing.Point(766, 80)
            Me.g_fullname.Name = "g_fullname"
            Me.g_fullname.Size = New System.Drawing.Size(118, 23)
            Me.g_fullname.TabIndex = 26
            Me.g_fullname.Text = "LabelX7"
            Me.g_fullname.Visible = False
            '
            'g_id_lbl
            '
            Me.g_id_lbl.BackColor = System.Drawing.Color.White
            '
            '
            '
            Me.g_id_lbl.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.g_id_lbl.ForeColor = System.Drawing.Color.Black
            Me.g_id_lbl.Location = New System.Drawing.Point(794, 37)
            Me.g_id_lbl.Name = "g_id_lbl"
            Me.g_id_lbl.Size = New System.Drawing.Size(75, 23)
            Me.g_id_lbl.TabIndex = 25
            Me.g_id_lbl.Text = "LabelX7"
            Me.g_id_lbl.Visible = False
            '
            'ButtonX4
            '
            Me.ButtonX4.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
            Me.ButtonX4.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
            Me.ButtonX4.Location = New System.Drawing.Point(12, 206)
            Me.ButtonX4.Name = "ButtonX4"
            Me.ButtonX4.Size = New System.Drawing.Size(130, 23)
            Me.ButtonX4.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
            Me.ButtonX4.TabIndex = 24
            Me.ButtonX4.Text = "Upload"
            '
            'g_directorypath
            '
            Me.g_directorypath.BackColor = System.Drawing.Color.White
            '
            '
            '
            Me.g_directorypath.Border.Class = "TextBoxBorder"
            Me.g_directorypath.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.g_directorypath.DisabledBackColor = System.Drawing.Color.White
            Me.g_directorypath.ForeColor = System.Drawing.Color.Black
            Me.g_directorypath.Location = New System.Drawing.Point(229, 206)
            Me.g_directorypath.Name = "g_directorypath"
            Me.g_directorypath.PreventEnterBeep = True
            Me.g_directorypath.Size = New System.Drawing.Size(312, 22)
            Me.g_directorypath.TabIndex = 23
            '
            'LabelX30
            '
            Me.LabelX30.BackColor = System.Drawing.Color.Transparent
            '
            '
            '
            Me.LabelX30.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.LabelX30.ForeColor = System.Drawing.Color.Black
            Me.LabelX30.Location = New System.Drawing.Point(148, 206)
            Me.LabelX30.Name = "LabelX30"
            Me.LabelX30.Size = New System.Drawing.Size(75, 23)
            Me.LabelX30.TabIndex = 22
            Me.LabelX30.Text = "Directory:"
            '
            'g_id
            '
            Me.g_id.BackColor = System.Drawing.Color.White
            '
            '
            '
            Me.g_id.Border.Class = "TextBoxBorder"
            Me.g_id.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.g_id.DisabledBackColor = System.Drawing.Color.White
            Me.g_id.Enabled = False
            Me.g_id.ForeColor = System.Drawing.Color.Black
            Me.g_id.Location = New System.Drawing.Point(34, 37)
            Me.g_id.Name = "g_id"
            Me.g_id.PreventEnterBeep = True
            Me.g_id.Size = New System.Drawing.Size(25, 22)
            Me.g_id.TabIndex = 21
            '
            'LabelX31
            '
            Me.LabelX31.BackColor = System.Drawing.Color.Transparent
            '
            '
            '
            Me.LabelX31.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.LabelX31.ForeColor = System.Drawing.Color.Black
            Me.LabelX31.Location = New System.Drawing.Point(8, 36)
            Me.LabelX31.Name = "LabelX31"
            Me.LabelX31.Size = New System.Drawing.Size(20, 23)
            Me.LabelX31.TabIndex = 20
            Me.LabelX31.Text = "ID:"
            '
            'g_contact
            '
            Me.g_contact.BackColor = System.Drawing.Color.White
            '
            '
            '
            Me.g_contact.Border.Class = "TextBoxBorder"
            Me.g_contact.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.g_contact.DisabledBackColor = System.Drawing.Color.White
            Me.g_contact.ForeColor = System.Drawing.Color.Black
            Me.g_contact.Location = New System.Drawing.Point(229, 179)
            Me.g_contact.Name = "g_contact"
            Me.g_contact.PreventEnterBeep = True
            Me.g_contact.Size = New System.Drawing.Size(100, 22)
            Me.g_contact.TabIndex = 19
            '
            'LabelX32
            '
            Me.LabelX32.BackColor = System.Drawing.Color.Transparent
            '
            '
            '
            Me.LabelX32.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.LabelX32.ForeColor = System.Drawing.Color.Black
            Me.LabelX32.Location = New System.Drawing.Point(148, 179)
            Me.LabelX32.Name = "LabelX32"
            Me.LabelX32.Size = New System.Drawing.Size(75, 23)
            Me.LabelX32.TabIndex = 18
            Me.LabelX32.Text = "Contact #:"
            '
            'g_semester
            '
            Me.g_semester.BackColor = System.Drawing.Color.White
            '
            '
            '
            Me.g_semester.Border.Class = "TextBoxBorder"
            Me.g_semester.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.g_semester.DisabledBackColor = System.Drawing.Color.White
            Me.g_semester.ForeColor = System.Drawing.Color.Black
            Me.g_semester.Location = New System.Drawing.Point(229, 151)
            Me.g_semester.Name = "g_semester"
            Me.g_semester.PreventEnterBeep = True
            Me.g_semester.Size = New System.Drawing.Size(100, 22)
            Me.g_semester.TabIndex = 17
            '
            'g_acadyear
            '
            Me.g_acadyear.BackColor = System.Drawing.Color.White
            '
            '
            '
            Me.g_acadyear.Border.Class = "TextBoxBorder"
            Me.g_acadyear.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.g_acadyear.DisabledBackColor = System.Drawing.Color.White
            Me.g_acadyear.ForeColor = System.Drawing.Color.Black
            Me.g_acadyear.Location = New System.Drawing.Point(229, 123)
            Me.g_acadyear.Name = "g_acadyear"
            Me.g_acadyear.PreventEnterBeep = True
            Me.g_acadyear.Size = New System.Drawing.Size(100, 22)
            Me.g_acadyear.TabIndex = 16
            '
            'LabelX33
            '
            Me.LabelX33.BackColor = System.Drawing.Color.Transparent
            '
            '
            '
            Me.LabelX33.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.LabelX33.ForeColor = System.Drawing.Color.Black
            Me.LabelX33.Location = New System.Drawing.Point(148, 151)
            Me.LabelX33.Name = "LabelX33"
            Me.LabelX33.Size = New System.Drawing.Size(75, 23)
            Me.LabelX33.TabIndex = 15
            Me.LabelX33.Text = "Semester:"
            '
            'g_yearlevel
            '
            Me.g_yearlevel.BackColor = System.Drawing.Color.White
            '
            '
            '
            Me.g_yearlevel.Border.Class = "TextBoxBorder"
            Me.g_yearlevel.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.g_yearlevel.DisabledBackColor = System.Drawing.Color.White
            Me.g_yearlevel.ForeColor = System.Drawing.Color.Black
            Me.g_yearlevel.Location = New System.Drawing.Point(281, 94)
            Me.g_yearlevel.Name = "g_yearlevel"
            Me.g_yearlevel.PreventEnterBeep = True
            Me.g_yearlevel.Size = New System.Drawing.Size(48, 22)
            Me.g_yearlevel.TabIndex = 14
            '
            'LabelX34
            '
            Me.LabelX34.BackColor = System.Drawing.Color.Transparent
            '
            '
            '
            Me.LabelX34.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.LabelX34.ForeColor = System.Drawing.Color.Black
            Me.LabelX34.Location = New System.Drawing.Point(148, 123)
            Me.LabelX34.Name = "LabelX34"
            Me.LabelX34.Size = New System.Drawing.Size(75, 23)
            Me.LabelX34.TabIndex = 13
            Me.LabelX34.Text = "Academic Yr:"
            '
            'g_course
            '
            Me.g_course.BackColor = System.Drawing.Color.White
            '
            '
            '
            Me.g_course.Border.Class = "TextBoxBorder"
            Me.g_course.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.g_course.DisabledBackColor = System.Drawing.Color.White
            Me.g_course.ForeColor = System.Drawing.Color.Black
            Me.g_course.Location = New System.Drawing.Point(229, 95)
            Me.g_course.Name = "g_course"
            Me.g_course.PreventEnterBeep = True
            Me.g_course.Size = New System.Drawing.Size(46, 22)
            Me.g_course.TabIndex = 12
            '
            'LabelX35
            '
            Me.LabelX35.BackColor = System.Drawing.Color.Transparent
            '
            '
            '
            Me.LabelX35.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.LabelX35.ForeColor = System.Drawing.Color.Black
            Me.LabelX35.Location = New System.Drawing.Point(148, 94)
            Me.LabelX35.Name = "LabelX35"
            Me.LabelX35.Size = New System.Drawing.Size(75, 23)
            Me.LabelX35.TabIndex = 11
            Me.LabelX35.Text = "Course / Year:"
            '
            'g_middlename
            '
            Me.g_middlename.BackColor = System.Drawing.Color.White
            '
            '
            '
            Me.g_middlename.Border.Class = "TextBoxBorder"
            Me.g_middlename.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.g_middlename.DisabledBackColor = System.Drawing.Color.White
            Me.g_middlename.ForeColor = System.Drawing.Color.Black
            Me.g_middlename.Location = New System.Drawing.Point(441, 66)
            Me.g_middlename.Name = "g_middlename"
            Me.g_middlename.PreventEnterBeep = True
            Me.g_middlename.Size = New System.Drawing.Size(100, 22)
            Me.g_middlename.TabIndex = 10
            '
            'g_firstname
            '
            Me.g_firstname.BackColor = System.Drawing.Color.White
            '
            '
            '
            Me.g_firstname.Border.Class = "TextBoxBorder"
            Me.g_firstname.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.g_firstname.DisabledBackColor = System.Drawing.Color.White
            Me.g_firstname.ForeColor = System.Drawing.Color.Black
            Me.g_firstname.Location = New System.Drawing.Point(335, 66)
            Me.g_firstname.Name = "g_firstname"
            Me.g_firstname.PreventEnterBeep = True
            Me.g_firstname.Size = New System.Drawing.Size(100, 22)
            Me.g_firstname.TabIndex = 9
            '
            'g_lastname
            '
            Me.g_lastname.BackColor = System.Drawing.Color.White
            '
            '
            '
            Me.g_lastname.Border.Class = "TextBoxBorder"
            Me.g_lastname.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.g_lastname.DisabledBackColor = System.Drawing.Color.White
            Me.g_lastname.ForeColor = System.Drawing.Color.Black
            Me.g_lastname.Location = New System.Drawing.Point(229, 67)
            Me.g_lastname.Name = "g_lastname"
            Me.g_lastname.PreventEnterBeep = True
            Me.g_lastname.Size = New System.Drawing.Size(100, 22)
            Me.g_lastname.TabIndex = 8
            '
            'LabelX36
            '
            Me.LabelX36.BackColor = System.Drawing.Color.Transparent
            '
            '
            '
            Me.LabelX36.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.LabelX36.ForeColor = System.Drawing.Color.Black
            Me.LabelX36.Location = New System.Drawing.Point(148, 37)
            Me.LabelX36.Name = "LabelX36"
            Me.LabelX36.Size = New System.Drawing.Size(75, 23)
            Me.LabelX36.TabIndex = 7
            Me.LabelX36.Text = "Student ID:"
            '
            'g_studid
            '
            Me.g_studid.BackColor = System.Drawing.Color.White
            '
            '
            '
            Me.g_studid.Border.Class = "TextBoxBorder"
            Me.g_studid.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.g_studid.DisabledBackColor = System.Drawing.Color.White
            Me.g_studid.ForeColor = System.Drawing.Color.Black
            Me.g_studid.Location = New System.Drawing.Point(229, 37)
            Me.g_studid.Name = "g_studid"
            Me.g_studid.PreventEnterBeep = True
            Me.g_studid.Size = New System.Drawing.Size(100, 22)
            Me.g_studid.TabIndex = 6
            '
            'LabelX37
            '
            Me.LabelX37.BackColor = System.Drawing.Color.Transparent
            '
            '
            '
            Me.LabelX37.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.LabelX37.ForeColor = System.Drawing.Color.Black
            Me.LabelX37.Location = New System.Drawing.Point(148, 66)
            Me.LabelX37.Name = "LabelX37"
            Me.LabelX37.Size = New System.Drawing.Size(75, 23)
            Me.LabelX37.TabIndex = 5
            Me.LabelX37.Text = "Name:"
            '
            'PictureBox4
            '
            Me.PictureBox4.BackColor = System.Drawing.Color.White
            Me.PictureBox4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
            Me.PictureBox4.ForeColor = System.Drawing.Color.Black
            Me.PictureBox4.Location = New System.Drawing.Point(12, 67)
            Me.PictureBox4.Name = "PictureBox4"
            Me.PictureBox4.Size = New System.Drawing.Size(130, 136)
            Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
            Me.PictureBox4.TabIndex = 4
            Me.PictureBox4.TabStop = False
            '
            'MetroToolbar3
            '
            Me.MetroToolbar3.BackColor = System.Drawing.Color.White
            '
            '
            '
            Me.MetroToolbar3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.MetroToolbar3.ContainerControlProcessDialogKey = True
            Me.MetroToolbar3.DragDropSupport = True
            Me.MetroToolbar3.ExpandDirection = DevComponents.DotNetBar.Metro.eExpandDirection.Top
            Me.MetroToolbar3.ExtraItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.deleteGuidanceButton})
            Me.MetroToolbar3.ForeColor = System.Drawing.Color.Black
            Me.MetroToolbar3.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.searchGuidanceButton, Me.addGuidanceButton, Me.updateGuidanceButton})
            Me.MetroToolbar3.LicenseKey = "F962CEC7-CD8F-4911-A9E9-CAB39962FC1F"
            Me.MetroToolbar3.Location = New System.Drawing.Point(289, 549)
            Me.MetroToolbar3.Name = "MetroToolbar3"
            Me.MetroToolbar3.Size = New System.Drawing.Size(388, 38)
            Me.MetroToolbar3.TabIndex = 23
            Me.MetroToolbar3.Text = "Invoices"
            '
            'deleteGuidanceButton
            '
            Me.deleteGuidanceButton.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
            Me.deleteGuidanceButton.Image = Global.My.Resources.Resources.Delete1
            Me.deleteGuidanceButton.ImageAlt = Global.My.Resources.Resources.DeleteWhite
            Me.deleteGuidanceButton.Name = "deleteGuidanceButton"
            Me.deleteGuidanceButton.Text = "Delete Record"
            Me.deleteGuidanceButton.Tooltip = "Delete Selected Record"
            '
            'searchGuidanceButton
            '
            Me.searchGuidanceButton.AutoExpandOnClick = True
            Me.searchGuidanceButton.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
            Me.searchGuidanceButton.Image = Global.My.Resources.Resources.search_ic_crop
            Me.searchGuidanceButton.ImageAlt = Global.My.Resources.Resources.NewInvoiceWhite
            Me.searchGuidanceButton.Name = "searchGuidanceButton"
            Me.searchGuidanceButton.PopupSide = DevComponents.DotNetBar.ePopupSide.Top
            Me.searchGuidanceButton.PopupType = DevComponents.DotNetBar.ePopupType.ToolBar
            Me.searchGuidanceButton.PopupWidth = 50
            Me.searchGuidanceButton.Shape = New DevComponents.DotNetBar.RoundRectangleShapeDescriptor(2)
            Me.searchGuidanceButton.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.searchGuidanceTxt})
            Me.searchGuidanceButton.Text = "Search Record"
            Me.searchGuidanceButton.Tooltip = "Search"
            '
            'searchGuidanceTxt
            '
            Me.searchGuidanceTxt.FocusHighlightColor = System.Drawing.Color.YellowGreen
            Me.searchGuidanceTxt.Name = "searchGuidanceTxt"
            Me.searchGuidanceTxt.Stretch = True
            Me.searchGuidanceTxt.TextBoxWidth = 200
            Me.searchGuidanceTxt.WatermarkColor = System.Drawing.SystemColors.GrayText
            '
            'addGuidanceButton
            '
            Me.addGuidanceButton.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
            Me.addGuidanceButton.Image = Global.My.Resources.Resources.addnew_edit
            Me.addGuidanceButton.ImageAlt = Global.My.Resources.Resources.BookNoteWhite
            Me.addGuidanceButton.Name = "addGuidanceButton"
            Me.addGuidanceButton.PopupSide = DevComponents.DotNetBar.ePopupSide.Top
            Me.addGuidanceButton.Text = "Add Record"
            Me.addGuidanceButton.Tooltip = "Add new Record"
            '
            'updateGuidanceButton
            '
            Me.updateGuidanceButton.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
            Me.updateGuidanceButton.Image = Global.My.Resources.Resources.edit_new_res
            Me.updateGuidanceButton.ImageAlt = Global.My.Resources.Resources.PaperClipWhite
            Me.updateGuidanceButton.Name = "updateGuidanceButton"
            Me.updateGuidanceButton.Text = "Update Record"
            Me.updateGuidanceButton.Tooltip = "Update an existimg Record"
            '
            'LabelX4
            '
            Me.LabelX4.BackColor = System.Drawing.Color.White
            '
            '
            '
            Me.LabelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.LabelX4.Enabled = False
            Me.LabelX4.ForeColor = System.Drawing.Color.Black
            Me.LabelX4.Location = New System.Drawing.Point(57, 294)
            Me.LabelX4.Name = "LabelX4"
            Me.LabelX4.Size = New System.Drawing.Size(98, 23)
            Me.LabelX4.TabIndex = 22
            Me.LabelX4.Text = "LabelX4"
            Me.LabelX4.Visible = False
            '
            'ExpandableSplitter5
            '
            Me.ExpandableSplitter5.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer))
            Me.ExpandableSplitter5.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer))
            Me.ExpandableSplitter5.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
            Me.ExpandableSplitter5.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
            Me.ExpandableSplitter5.Dock = System.Windows.Forms.DockStyle.Top
            Me.ExpandableSplitter5.ExpandFillColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer))
            Me.ExpandableSplitter5.ExpandFillColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
            Me.ExpandableSplitter5.ExpandLineColor = System.Drawing.Color.Black
            Me.ExpandableSplitter5.ExpandLineColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText
            Me.ExpandableSplitter5.ForeColor = System.Drawing.Color.Black
            Me.ExpandableSplitter5.GripDarkColor = System.Drawing.Color.Black
            Me.ExpandableSplitter5.GripDarkColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText
            Me.ExpandableSplitter5.GripLightColor = System.Drawing.Color.White
            Me.ExpandableSplitter5.GripLightColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
            Me.ExpandableSplitter5.HotBackColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer))
            Me.ExpandableSplitter5.HotBackColor2 = System.Drawing.Color.Empty
            Me.ExpandableSplitter5.HotBackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemPressedBackground2
            Me.ExpandableSplitter5.HotBackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemPressedBackground
            Me.ExpandableSplitter5.HotExpandFillColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer))
            Me.ExpandableSplitter5.HotExpandFillColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
            Me.ExpandableSplitter5.HotExpandLineColor = System.Drawing.Color.Black
            Me.ExpandableSplitter5.HotExpandLineColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText
            Me.ExpandableSplitter5.HotGripDarkColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer))
            Me.ExpandableSplitter5.HotGripDarkColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
            Me.ExpandableSplitter5.HotGripLightColor = System.Drawing.Color.White
            Me.ExpandableSplitter5.HotGripLightColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
            Me.ExpandableSplitter5.Location = New System.Drawing.Point(3, 240)
            Me.ExpandableSplitter5.Name = "ExpandableSplitter5"
            Me.ExpandableSplitter5.Size = New System.Drawing.Size(905, 6)
            Me.ExpandableSplitter5.Style = DevComponents.DotNetBar.eSplitterStyle.Office2007
            Me.ExpandableSplitter5.TabIndex = 4
            Me.ExpandableSplitter5.TabStop = False
            '
            'ListViewEx3
            '
            Me.ListViewEx3.BackColor = System.Drawing.Color.White
            '
            '
            '
            Me.ListViewEx3.Border.Class = "ListViewBorder"
            Me.ListViewEx3.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.ListViewEx3.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader23, Me.ColumnHeader24, Me.ColumnHeader25, Me.ColumnHeader26, Me.ColumnHeader27, Me.ColumnHeader28, Me.ColumnHeader29, Me.ColumnHeader30, Me.ColumnHeader31, Me.ColumnHeader32, Me.ColumnHeader33, Me.ColumnHeader59, Me.ColumnHeader74})
            Me.ListViewEx3.DisabledBackColor = System.Drawing.Color.Empty
            Me.ListViewEx3.Dock = System.Windows.Forms.DockStyle.Top
            Me.ListViewEx3.ForeColor = System.Drawing.Color.Black
            Me.ListViewEx3.FullRowSelect = True
            Me.ListViewEx3.Location = New System.Drawing.Point(3, 0)
            Me.ListViewEx3.Name = "ListViewEx3"
            Me.ListViewEx3.Size = New System.Drawing.Size(905, 240)
            Me.ListViewEx3.TabIndex = 2
            Me.ListViewEx3.UseCompatibleStateImageBehavior = False
            Me.ListViewEx3.View = System.Windows.Forms.View.Details
            '
            'ColumnHeader23
            '
            Me.ColumnHeader23.Text = "ID"
            '
            'ColumnHeader24
            '
            Me.ColumnHeader24.Text = "Student Number"
            Me.ColumnHeader24.Width = 130
            '
            'ColumnHeader25
            '
            Me.ColumnHeader25.Text = "Lastname"
            Me.ColumnHeader25.Width = 130
            '
            'ColumnHeader26
            '
            Me.ColumnHeader26.Text = "Firstname"
            Me.ColumnHeader26.Width = 130
            '
            'ColumnHeader27
            '
            Me.ColumnHeader27.Text = "Middlename"
            Me.ColumnHeader27.Width = 130
            '
            'ColumnHeader28
            '
            Me.ColumnHeader28.Text = "Course"
            Me.ColumnHeader28.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            Me.ColumnHeader28.Width = 130
            '
            'ColumnHeader29
            '
            Me.ColumnHeader29.Text = "Year Level"
            Me.ColumnHeader29.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            Me.ColumnHeader29.Width = 130
            '
            'ColumnHeader30
            '
            Me.ColumnHeader30.Text = "Semester"
            Me.ColumnHeader30.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            Me.ColumnHeader30.Width = 130
            '
            'ColumnHeader31
            '
            Me.ColumnHeader31.Text = "S.Y"
            Me.ColumnHeader31.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            Me.ColumnHeader31.Width = 130
            '
            'ColumnHeader32
            '
            Me.ColumnHeader32.Text = "Contact"
            Me.ColumnHeader32.Width = 130
            '
            'ColumnHeader33
            '
            Me.ColumnHeader33.Text = "Uncollected Req."
            Me.ColumnHeader33.Width = 130
            '
            'ColumnHeader59
            '
            Me.ColumnHeader59.Text = "Status"
            Me.ColumnHeader59.Width = 130
            '
            'ColumnHeader74
            '
            Me.ColumnHeader74.Text = "Directory"
            Me.ColumnHeader74.Width = 130
            '
            'MetroTabPanel2
            '
            Me.MetroTabPanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
            Me.MetroTabPanel2.Controls.Add(Me.ExpandableSplitter11)
            Me.MetroTabPanel2.Controls.Add(Me.ExpandablePanel5)
            Me.MetroTabPanel2.Controls.Add(Me.MetroToolbar2)
            Me.MetroTabPanel2.Controls.Add(Me.LabelX5)
            Me.MetroTabPanel2.Controls.Add(Me.ExpandableSplitter6)
            Me.MetroTabPanel2.Controls.Add(Me.ListViewEx5)
            Me.MetroTabPanel2.Dock = System.Windows.Forms.DockStyle.Fill
            Me.MetroTabPanel2.Location = New System.Drawing.Point(0, 51)
            Me.MetroTabPanel2.Name = "MetroTabPanel2"
            Me.MetroTabPanel2.Padding = New System.Windows.Forms.Padding(3, 0, 3, 3)
            Me.MetroTabPanel2.Size = New System.Drawing.Size(911, 593)
            '
            '
            '
            Me.MetroTabPanel2.Style.CornerType = DevComponents.DotNetBar.eCornerType.Square
            '
            '
            '
            Me.MetroTabPanel2.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
            '
            '
            '
            Me.MetroTabPanel2.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.MetroTabPanel2.TabIndex = 7
            Me.MetroTabPanel2.Visible = False
            '
            'ExpandableSplitter11
            '
            Me.ExpandableSplitter11.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer))
            Me.ExpandableSplitter11.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer))
            Me.ExpandableSplitter11.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
            Me.ExpandableSplitter11.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
            Me.ExpandableSplitter11.Dock = System.Windows.Forms.DockStyle.Top
            Me.ExpandableSplitter11.ExpandFillColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer))
            Me.ExpandableSplitter11.ExpandFillColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
            Me.ExpandableSplitter11.ExpandLineColor = System.Drawing.Color.Black
            Me.ExpandableSplitter11.ExpandLineColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText
            Me.ExpandableSplitter11.ForeColor = System.Drawing.Color.Black
            Me.ExpandableSplitter11.GripDarkColor = System.Drawing.Color.Black
            Me.ExpandableSplitter11.GripDarkColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText
            Me.ExpandableSplitter11.GripLightColor = System.Drawing.Color.White
            Me.ExpandableSplitter11.GripLightColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
            Me.ExpandableSplitter11.HotBackColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer))
            Me.ExpandableSplitter11.HotBackColor2 = System.Drawing.Color.Empty
            Me.ExpandableSplitter11.HotBackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemPressedBackground2
            Me.ExpandableSplitter11.HotBackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemPressedBackground
            Me.ExpandableSplitter11.HotExpandFillColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer))
            Me.ExpandableSplitter11.HotExpandFillColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
            Me.ExpandableSplitter11.HotExpandLineColor = System.Drawing.Color.Black
            Me.ExpandableSplitter11.HotExpandLineColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText
            Me.ExpandableSplitter11.HotGripDarkColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer))
            Me.ExpandableSplitter11.HotGripDarkColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
            Me.ExpandableSplitter11.HotGripLightColor = System.Drawing.Color.White
            Me.ExpandableSplitter11.HotGripLightColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
            Me.ExpandableSplitter11.Location = New System.Drawing.Point(3, 491)
            Me.ExpandableSplitter11.Name = "ExpandableSplitter11"
            Me.ExpandableSplitter11.Size = New System.Drawing.Size(905, 10)
            Me.ExpandableSplitter11.Style = DevComponents.DotNetBar.eSplitterStyle.Office2007
            Me.ExpandableSplitter11.TabIndex = 51
            Me.ExpandableSplitter11.TabStop = False
            '
            'ExpandablePanel5
            '
            Me.ExpandablePanel5.CanvasColor = System.Drawing.SystemColors.Window
            Me.ExpandablePanel5.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
            Me.ExpandablePanel5.Controls.Add(Me.LabelX42)
            Me.ExpandablePanel5.Controls.Add(Me.i_units)
            Me.ExpandablePanel5.Controls.Add(Me.i_subjdesc)
            Me.ExpandablePanel5.Controls.Add(Me.LabelX38)
            Me.ExpandablePanel5.Controls.Add(Me.LabelX29)
            Me.ExpandablePanel5.Controls.Add(Me.i_fullname)
            Me.ExpandablePanel5.Controls.Add(Me.i_id_lbl)
            Me.ExpandablePanel5.Controls.Add(Me.ButtonX5)
            Me.ExpandablePanel5.Controls.Add(Me.i_directorypath)
            Me.ExpandablePanel5.Controls.Add(Me.LabelX40)
            Me.ExpandablePanel5.Controls.Add(Me.i_id)
            Me.ExpandablePanel5.Controls.Add(Me.LabelX41)
            Me.ExpandablePanel5.Controls.Add(Me.i_semester)
            Me.ExpandablePanel5.Controls.Add(Me.i_acadyear)
            Me.ExpandablePanel5.Controls.Add(Me.LabelX43)
            Me.ExpandablePanel5.Controls.Add(Me.i_yearlevel)
            Me.ExpandablePanel5.Controls.Add(Me.LabelX44)
            Me.ExpandablePanel5.Controls.Add(Me.i_subjectcode)
            Me.ExpandablePanel5.Controls.Add(Me.LabelX45)
            Me.ExpandablePanel5.Controls.Add(Me.i_middlename)
            Me.ExpandablePanel5.Controls.Add(Me.i_firstname)
            Me.ExpandablePanel5.Controls.Add(Me.i_lastname)
            Me.ExpandablePanel5.Controls.Add(Me.LabelX46)
            Me.ExpandablePanel5.Controls.Add(Me.i_empid)
            Me.ExpandablePanel5.Controls.Add(Me.LabelX47)
            Me.ExpandablePanel5.Controls.Add(Me.PictureBox5)
            Me.ExpandablePanel5.DisabledBackColor = System.Drawing.Color.Empty
            Me.ExpandablePanel5.Dock = System.Windows.Forms.DockStyle.Top
            Me.ExpandablePanel5.HideControlsWhenCollapsed = True
            Me.ExpandablePanel5.Location = New System.Drawing.Point(3, 246)
            Me.ExpandablePanel5.Name = "ExpandablePanel5"
            Me.ExpandablePanel5.Size = New System.Drawing.Size(905, 245)
            Me.ExpandablePanel5.Style.Alignment = System.Drawing.StringAlignment.Center
            Me.ExpandablePanel5.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
            Me.ExpandablePanel5.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
            Me.ExpandablePanel5.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText
            Me.ExpandablePanel5.Style.GradientAngle = 90
            Me.ExpandablePanel5.TabIndex = 50
            Me.ExpandablePanel5.TitleStyle.Alignment = System.Drawing.StringAlignment.Center
            Me.ExpandablePanel5.TitleStyle.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
            Me.ExpandablePanel5.TitleStyle.Border = DevComponents.DotNetBar.eBorderType.RaisedInner
            Me.ExpandablePanel5.TitleStyle.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
            Me.ExpandablePanel5.TitleStyle.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
            Me.ExpandablePanel5.TitleStyle.GradientAngle = 90
            Me.ExpandablePanel5.TitleText = "Student Information"
            '
            'LabelX42
            '
            Me.LabelX42.BackColor = System.Drawing.Color.Transparent
            '
            '
            '
            Me.LabelX42.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.LabelX42.ForeColor = System.Drawing.Color.Black
            Me.LabelX42.Location = New System.Drawing.Point(148, 150)
            Me.LabelX42.Name = "LabelX42"
            Me.LabelX42.Size = New System.Drawing.Size(75, 23)
            Me.LabelX42.TabIndex = 31
            Me.LabelX42.Text = "Unit:"
            '
            'i_units
            '
            Me.i_units.BackColor = System.Drawing.Color.White
            '
            '
            '
            Me.i_units.Border.Class = "TextBoxBorder"
            Me.i_units.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.i_units.DisabledBackColor = System.Drawing.Color.White
            Me.i_units.ForeColor = System.Drawing.Color.Black
            Me.i_units.Location = New System.Drawing.Point(229, 150)
            Me.i_units.Name = "i_units"
            Me.i_units.PreventEnterBeep = True
            Me.i_units.Size = New System.Drawing.Size(48, 22)
            Me.i_units.TabIndex = 30
            '
            'i_subjdesc
            '
            Me.i_subjdesc.BackColor = System.Drawing.Color.White
            '
            '
            '
            Me.i_subjdesc.Border.Class = "TextBoxBorder"
            Me.i_subjdesc.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.i_subjdesc.DisabledBackColor = System.Drawing.Color.White
            Me.i_subjdesc.ForeColor = System.Drawing.Color.Black
            Me.i_subjdesc.Location = New System.Drawing.Point(229, 122)
            Me.i_subjdesc.Name = "i_subjdesc"
            Me.i_subjdesc.PreventEnterBeep = True
            Me.i_subjdesc.Size = New System.Drawing.Size(100, 22)
            Me.i_subjdesc.TabIndex = 29
            '
            'LabelX38
            '
            Me.LabelX38.BackColor = System.Drawing.Color.Transparent
            '
            '
            '
            Me.LabelX38.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.LabelX38.ForeColor = System.Drawing.Color.Black
            Me.LabelX38.Location = New System.Drawing.Point(148, 121)
            Me.LabelX38.Name = "LabelX38"
            Me.LabelX38.Size = New System.Drawing.Size(75, 23)
            Me.LabelX38.TabIndex = 28
            Me.LabelX38.Text = "Subject Desc:"
            '
            'LabelX29
            '
            Me.LabelX29.BackColor = System.Drawing.Color.Transparent
            '
            '
            '
            Me.LabelX29.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.LabelX29.ForeColor = System.Drawing.Color.Black
            Me.LabelX29.Location = New System.Drawing.Point(360, 121)
            Me.LabelX29.Name = "LabelX29"
            Me.LabelX29.Size = New System.Drawing.Size(75, 23)
            Me.LabelX29.TabIndex = 27
            Me.LabelX29.Text = "Year Level:"
            '
            'i_fullname
            '
            Me.i_fullname.BackColor = System.Drawing.Color.White
            '
            '
            '
            Me.i_fullname.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.i_fullname.ForeColor = System.Drawing.Color.Black
            Me.i_fullname.Location = New System.Drawing.Point(702, 51)
            Me.i_fullname.Name = "i_fullname"
            Me.i_fullname.Size = New System.Drawing.Size(105, 23)
            Me.i_fullname.TabIndex = 26
            Me.i_fullname.Text = "LabelX7"
            Me.i_fullname.Visible = False
            '
            'i_id_lbl
            '
            Me.i_id_lbl.BackColor = System.Drawing.Color.White
            '
            '
            '
            Me.i_id_lbl.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.i_id_lbl.ForeColor = System.Drawing.Color.Black
            Me.i_id_lbl.Location = New System.Drawing.Point(335, 37)
            Me.i_id_lbl.Name = "i_id_lbl"
            Me.i_id_lbl.Size = New System.Drawing.Size(75, 23)
            Me.i_id_lbl.TabIndex = 25
            Me.i_id_lbl.Text = "LabelX7"
            Me.i_id_lbl.Visible = False
            '
            'ButtonX5
            '
            Me.ButtonX5.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
            Me.ButtonX5.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
            Me.ButtonX5.Location = New System.Drawing.Point(12, 206)
            Me.ButtonX5.Name = "ButtonX5"
            Me.ButtonX5.Size = New System.Drawing.Size(130, 23)
            Me.ButtonX5.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
            Me.ButtonX5.TabIndex = 24
            Me.ButtonX5.Text = "Upload"
            '
            'i_directorypath
            '
            Me.i_directorypath.BackColor = System.Drawing.Color.White
            '
            '
            '
            Me.i_directorypath.Border.Class = "TextBoxBorder"
            Me.i_directorypath.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.i_directorypath.DisabledBackColor = System.Drawing.Color.White
            Me.i_directorypath.ForeColor = System.Drawing.Color.Black
            Me.i_directorypath.Location = New System.Drawing.Point(229, 206)
            Me.i_directorypath.Name = "i_directorypath"
            Me.i_directorypath.PreventEnterBeep = True
            Me.i_directorypath.Size = New System.Drawing.Size(312, 22)
            Me.i_directorypath.TabIndex = 23
            '
            'LabelX40
            '
            Me.LabelX40.BackColor = System.Drawing.Color.Transparent
            '
            '
            '
            Me.LabelX40.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.LabelX40.ForeColor = System.Drawing.Color.Black
            Me.LabelX40.Location = New System.Drawing.Point(148, 206)
            Me.LabelX40.Name = "LabelX40"
            Me.LabelX40.Size = New System.Drawing.Size(75, 23)
            Me.LabelX40.TabIndex = 22
            Me.LabelX40.Text = "Directory:"
            '
            'i_id
            '
            Me.i_id.BackColor = System.Drawing.Color.White
            '
            '
            '
            Me.i_id.Border.Class = "TextBoxBorder"
            Me.i_id.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.i_id.DisabledBackColor = System.Drawing.Color.White
            Me.i_id.Enabled = False
            Me.i_id.ForeColor = System.Drawing.Color.Black
            Me.i_id.Location = New System.Drawing.Point(34, 37)
            Me.i_id.Name = "i_id"
            Me.i_id.PreventEnterBeep = True
            Me.i_id.Size = New System.Drawing.Size(25, 22)
            Me.i_id.TabIndex = 21
            '
            'LabelX41
            '
            Me.LabelX41.BackColor = System.Drawing.Color.Transparent
            '
            '
            '
            Me.LabelX41.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.LabelX41.ForeColor = System.Drawing.Color.Black
            Me.LabelX41.Location = New System.Drawing.Point(8, 36)
            Me.LabelX41.Name = "LabelX41"
            Me.LabelX41.Size = New System.Drawing.Size(20, 23)
            Me.LabelX41.TabIndex = 20
            Me.LabelX41.Text = "ID:"
            '
            'i_semester
            '
            Me.i_semester.BackColor = System.Drawing.Color.White
            '
            '
            '
            Me.i_semester.Border.Class = "TextBoxBorder"
            Me.i_semester.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.i_semester.DisabledBackColor = System.Drawing.Color.White
            Me.i_semester.ForeColor = System.Drawing.Color.Black
            Me.i_semester.Location = New System.Drawing.Point(441, 97)
            Me.i_semester.Name = "i_semester"
            Me.i_semester.PreventEnterBeep = True
            Me.i_semester.Size = New System.Drawing.Size(100, 22)
            Me.i_semester.TabIndex = 17
            '
            'i_acadyear
            '
            Me.i_acadyear.BackColor = System.Drawing.Color.White
            '
            '
            '
            Me.i_acadyear.Border.Class = "TextBoxBorder"
            Me.i_acadyear.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.i_acadyear.DisabledBackColor = System.Drawing.Color.White
            Me.i_acadyear.ForeColor = System.Drawing.Color.Black
            Me.i_acadyear.Location = New System.Drawing.Point(229, 179)
            Me.i_acadyear.Name = "i_acadyear"
            Me.i_acadyear.PreventEnterBeep = True
            Me.i_acadyear.Size = New System.Drawing.Size(100, 22)
            Me.i_acadyear.TabIndex = 16
            '
            'LabelX43
            '
            Me.LabelX43.BackColor = System.Drawing.Color.Transparent
            '
            '
            '
            Me.LabelX43.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.LabelX43.ForeColor = System.Drawing.Color.Black
            Me.LabelX43.Location = New System.Drawing.Point(360, 97)
            Me.LabelX43.Name = "LabelX43"
            Me.LabelX43.Size = New System.Drawing.Size(75, 23)
            Me.LabelX43.TabIndex = 15
            Me.LabelX43.Text = "Semester:"
            '
            'i_yearlevel
            '
            Me.i_yearlevel.BackColor = System.Drawing.Color.White
            '
            '
            '
            Me.i_yearlevel.Border.Class = "TextBoxBorder"
            Me.i_yearlevel.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.i_yearlevel.DisabledBackColor = System.Drawing.Color.White
            Me.i_yearlevel.ForeColor = System.Drawing.Color.Black
            Me.i_yearlevel.Location = New System.Drawing.Point(441, 121)
            Me.i_yearlevel.Name = "i_yearlevel"
            Me.i_yearlevel.PreventEnterBeep = True
            Me.i_yearlevel.Size = New System.Drawing.Size(48, 22)
            Me.i_yearlevel.TabIndex = 14
            '
            'LabelX44
            '
            Me.LabelX44.BackColor = System.Drawing.Color.Transparent
            '
            '
            '
            Me.LabelX44.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.LabelX44.ForeColor = System.Drawing.Color.Black
            Me.LabelX44.Location = New System.Drawing.Point(148, 179)
            Me.LabelX44.Name = "LabelX44"
            Me.LabelX44.Size = New System.Drawing.Size(75, 23)
            Me.LabelX44.TabIndex = 13
            Me.LabelX44.Text = "Academic Yr:"
            '
            'i_subjectcode
            '
            Me.i_subjectcode.BackColor = System.Drawing.Color.White
            '
            '
            '
            Me.i_subjectcode.Border.Class = "TextBoxBorder"
            Me.i_subjectcode.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.i_subjectcode.DisabledBackColor = System.Drawing.Color.White
            Me.i_subjectcode.ForeColor = System.Drawing.Color.Black
            Me.i_subjectcode.Location = New System.Drawing.Point(229, 94)
            Me.i_subjectcode.Name = "i_subjectcode"
            Me.i_subjectcode.PreventEnterBeep = True
            Me.i_subjectcode.Size = New System.Drawing.Size(100, 22)
            Me.i_subjectcode.TabIndex = 12
            '
            'LabelX45
            '
            Me.LabelX45.BackColor = System.Drawing.Color.Transparent
            '
            '
            '
            Me.LabelX45.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.LabelX45.ForeColor = System.Drawing.Color.Black
            Me.LabelX45.Location = New System.Drawing.Point(148, 95)
            Me.LabelX45.Name = "LabelX45"
            Me.LabelX45.Size = New System.Drawing.Size(75, 23)
            Me.LabelX45.TabIndex = 11
            Me.LabelX45.Text = "Subject Code:"
            '
            'i_middlename
            '
            Me.i_middlename.BackColor = System.Drawing.Color.White
            '
            '
            '
            Me.i_middlename.Border.Class = "TextBoxBorder"
            Me.i_middlename.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.i_middlename.DisabledBackColor = System.Drawing.Color.White
            Me.i_middlename.ForeColor = System.Drawing.Color.Black
            Me.i_middlename.Location = New System.Drawing.Point(441, 66)
            Me.i_middlename.Name = "i_middlename"
            Me.i_middlename.PreventEnterBeep = True
            Me.i_middlename.Size = New System.Drawing.Size(100, 22)
            Me.i_middlename.TabIndex = 10
            '
            'i_firstname
            '
            Me.i_firstname.BackColor = System.Drawing.Color.White
            '
            '
            '
            Me.i_firstname.Border.Class = "TextBoxBorder"
            Me.i_firstname.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.i_firstname.DisabledBackColor = System.Drawing.Color.White
            Me.i_firstname.ForeColor = System.Drawing.Color.Black
            Me.i_firstname.Location = New System.Drawing.Point(335, 66)
            Me.i_firstname.Name = "i_firstname"
            Me.i_firstname.PreventEnterBeep = True
            Me.i_firstname.Size = New System.Drawing.Size(100, 22)
            Me.i_firstname.TabIndex = 9
            '
            'i_lastname
            '
            Me.i_lastname.BackColor = System.Drawing.Color.White
            '
            '
            '
            Me.i_lastname.Border.Class = "TextBoxBorder"
            Me.i_lastname.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.i_lastname.DisabledBackColor = System.Drawing.Color.White
            Me.i_lastname.ForeColor = System.Drawing.Color.Black
            Me.i_lastname.Location = New System.Drawing.Point(229, 67)
            Me.i_lastname.Name = "i_lastname"
            Me.i_lastname.PreventEnterBeep = True
            Me.i_lastname.Size = New System.Drawing.Size(100, 22)
            Me.i_lastname.TabIndex = 8
            '
            'LabelX46
            '
            Me.LabelX46.BackColor = System.Drawing.Color.Transparent
            '
            '
            '
            Me.LabelX46.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.LabelX46.ForeColor = System.Drawing.Color.Black
            Me.LabelX46.Location = New System.Drawing.Point(148, 37)
            Me.LabelX46.Name = "LabelX46"
            Me.LabelX46.Size = New System.Drawing.Size(75, 23)
            Me.LabelX46.TabIndex = 7
            Me.LabelX46.Text = "Employee ID:"
            '
            'i_empid
            '
            Me.i_empid.BackColor = System.Drawing.Color.White
            '
            '
            '
            Me.i_empid.Border.Class = "TextBoxBorder"
            Me.i_empid.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.i_empid.DisabledBackColor = System.Drawing.Color.White
            Me.i_empid.ForeColor = System.Drawing.Color.Black
            Me.i_empid.Location = New System.Drawing.Point(229, 37)
            Me.i_empid.Name = "i_empid"
            Me.i_empid.PreventEnterBeep = True
            Me.i_empid.Size = New System.Drawing.Size(100, 22)
            Me.i_empid.TabIndex = 6
            '
            'LabelX47
            '
            Me.LabelX47.BackColor = System.Drawing.Color.Transparent
            '
            '
            '
            Me.LabelX47.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.LabelX47.ForeColor = System.Drawing.Color.Black
            Me.LabelX47.Location = New System.Drawing.Point(148, 66)
            Me.LabelX47.Name = "LabelX47"
            Me.LabelX47.Size = New System.Drawing.Size(75, 23)
            Me.LabelX47.TabIndex = 5
            Me.LabelX47.Text = "Name:"
            '
            'PictureBox5
            '
            Me.PictureBox5.BackColor = System.Drawing.Color.White
            Me.PictureBox5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
            Me.PictureBox5.ForeColor = System.Drawing.Color.Black
            Me.PictureBox5.Location = New System.Drawing.Point(12, 67)
            Me.PictureBox5.Name = "PictureBox5"
            Me.PictureBox5.Size = New System.Drawing.Size(130, 136)
            Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
            Me.PictureBox5.TabIndex = 4
            Me.PictureBox5.TabStop = False
            '
            'MetroToolbar2
            '
            Me.MetroToolbar2.BackColor = System.Drawing.Color.White
            '
            '
            '
            Me.MetroToolbar2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.MetroToolbar2.ContainerControlProcessDialogKey = True
            Me.MetroToolbar2.DragDropSupport = True
            Me.MetroToolbar2.ExpandDirection = DevComponents.DotNetBar.Metro.eExpandDirection.Top
            Me.MetroToolbar2.ExtraItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.deleteInstructorButton})
            Me.MetroToolbar2.ForeColor = System.Drawing.Color.Black
            Me.MetroToolbar2.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.searchInstructorButton, Me.addInstructorButton, Me.updateInstructorButton})
            Me.MetroToolbar2.LicenseKey = "F962CEC7-CD8F-4911-A9E9-CAB39962FC1F"
            Me.MetroToolbar2.Location = New System.Drawing.Point(324, 556)
            Me.MetroToolbar2.Name = "MetroToolbar2"
            Me.MetroToolbar2.Size = New System.Drawing.Size(388, 38)
            Me.MetroToolbar2.TabIndex = 24
            Me.MetroToolbar2.Text = "Invoices"
            '
            'deleteInstructorButton
            '
            Me.deleteInstructorButton.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
            Me.deleteInstructorButton.Image = Global.My.Resources.Resources.Delete1
            Me.deleteInstructorButton.ImageAlt = Global.My.Resources.Resources.DeleteWhite
            Me.deleteInstructorButton.Name = "deleteInstructorButton"
            Me.deleteInstructorButton.Text = "Delete Record"
            Me.deleteInstructorButton.Tooltip = "Delete Selected Record"
            '
            'searchInstructorButton
            '
            Me.searchInstructorButton.AutoExpandOnClick = True
            Me.searchInstructorButton.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
            Me.searchInstructorButton.Image = Global.My.Resources.Resources.search_ic_crop
            Me.searchInstructorButton.ImageAlt = Global.My.Resources.Resources.NewInvoiceWhite
            Me.searchInstructorButton.Name = "searchInstructorButton"
            Me.searchInstructorButton.PopupSide = DevComponents.DotNetBar.ePopupSide.Top
            Me.searchInstructorButton.PopupType = DevComponents.DotNetBar.ePopupType.ToolBar
            Me.searchInstructorButton.PopupWidth = 50
            Me.searchInstructorButton.Shape = New DevComponents.DotNetBar.RoundRectangleShapeDescriptor(2)
            Me.searchInstructorButton.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.searchInstructorTxt})
            Me.searchInstructorButton.Text = "Search Record"
            Me.searchInstructorButton.Tooltip = "Search"
            '
            'searchInstructorTxt
            '
            Me.searchInstructorTxt.FocusHighlightColor = System.Drawing.Color.YellowGreen
            Me.searchInstructorTxt.Name = "searchInstructorTxt"
            Me.searchInstructorTxt.Stretch = True
            Me.searchInstructorTxt.TextBoxWidth = 200
            Me.searchInstructorTxt.WatermarkColor = System.Drawing.SystemColors.GrayText
            '
            'addInstructorButton
            '
            Me.addInstructorButton.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
            Me.addInstructorButton.Image = Global.My.Resources.Resources.addnew_edit
            Me.addInstructorButton.ImageAlt = Global.My.Resources.Resources.BookNoteWhite
            Me.addInstructorButton.Name = "addInstructorButton"
            Me.addInstructorButton.PopupSide = DevComponents.DotNetBar.ePopupSide.Top
            Me.addInstructorButton.Text = "Add Record"
            Me.addInstructorButton.Tooltip = "Add new Record"
            '
            'updateInstructorButton
            '
            Me.updateInstructorButton.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
            Me.updateInstructorButton.Image = Global.My.Resources.Resources.edit_new_res
            Me.updateInstructorButton.ImageAlt = Global.My.Resources.Resources.PaperClipWhite
            Me.updateInstructorButton.Name = "updateInstructorButton"
            Me.updateInstructorButton.Text = "Update Record"
            Me.updateInstructorButton.Tooltip = "Update an existimg Record"
            '
            'LabelX5
            '
            Me.LabelX5.BackColor = System.Drawing.Color.White
            '
            '
            '
            Me.LabelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.LabelX5.Enabled = False
            Me.LabelX5.ForeColor = System.Drawing.Color.Black
            Me.LabelX5.Location = New System.Drawing.Point(37, 294)
            Me.LabelX5.Name = "LabelX5"
            Me.LabelX5.Size = New System.Drawing.Size(98, 23)
            Me.LabelX5.TabIndex = 22
            Me.LabelX5.Text = "LabelX5"
            Me.LabelX5.Visible = False
            '
            'ExpandableSplitter6
            '
            Me.ExpandableSplitter6.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer))
            Me.ExpandableSplitter6.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer))
            Me.ExpandableSplitter6.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
            Me.ExpandableSplitter6.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
            Me.ExpandableSplitter6.Dock = System.Windows.Forms.DockStyle.Top
            Me.ExpandableSplitter6.ExpandFillColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer))
            Me.ExpandableSplitter6.ExpandFillColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
            Me.ExpandableSplitter6.ExpandLineColor = System.Drawing.Color.Black
            Me.ExpandableSplitter6.ExpandLineColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText
            Me.ExpandableSplitter6.ForeColor = System.Drawing.Color.Black
            Me.ExpandableSplitter6.GripDarkColor = System.Drawing.Color.Black
            Me.ExpandableSplitter6.GripDarkColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText
            Me.ExpandableSplitter6.GripLightColor = System.Drawing.Color.White
            Me.ExpandableSplitter6.GripLightColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
            Me.ExpandableSplitter6.HotBackColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer))
            Me.ExpandableSplitter6.HotBackColor2 = System.Drawing.Color.Empty
            Me.ExpandableSplitter6.HotBackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemPressedBackground2
            Me.ExpandableSplitter6.HotBackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemPressedBackground
            Me.ExpandableSplitter6.HotExpandFillColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer))
            Me.ExpandableSplitter6.HotExpandFillColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
            Me.ExpandableSplitter6.HotExpandLineColor = System.Drawing.Color.Black
            Me.ExpandableSplitter6.HotExpandLineColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText
            Me.ExpandableSplitter6.HotGripDarkColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer))
            Me.ExpandableSplitter6.HotGripDarkColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
            Me.ExpandableSplitter6.HotGripLightColor = System.Drawing.Color.White
            Me.ExpandableSplitter6.HotGripLightColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
            Me.ExpandableSplitter6.Location = New System.Drawing.Point(3, 240)
            Me.ExpandableSplitter6.Name = "ExpandableSplitter6"
            Me.ExpandableSplitter6.Size = New System.Drawing.Size(905, 6)
            Me.ExpandableSplitter6.Style = DevComponents.DotNetBar.eSplitterStyle.Office2007
            Me.ExpandableSplitter6.TabIndex = 4
            Me.ExpandableSplitter6.TabStop = False
            '
            'ListViewEx5
            '
            Me.ListViewEx5.BackColor = System.Drawing.Color.White
            '
            '
            '
            Me.ListViewEx5.Border.Class = "ListViewBorder"
            Me.ListViewEx5.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.ListViewEx5.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader45, Me.ColumnHeader46, Me.ColumnHeader47, Me.ColumnHeader48, Me.ColumnHeader49, Me.ColumnHeader50, Me.ColumnHeader51, Me.ColumnHeader52, Me.ColumnHeader53, Me.ColumnHeader54, Me.ColumnHeader55, Me.ColumnHeader80})
            Me.ListViewEx5.DisabledBackColor = System.Drawing.Color.Empty
            Me.ListViewEx5.Dock = System.Windows.Forms.DockStyle.Top
            Me.ListViewEx5.ForeColor = System.Drawing.Color.Black
            Me.ListViewEx5.FullRowSelect = True
            Me.ListViewEx5.Location = New System.Drawing.Point(3, 0)
            Me.ListViewEx5.Name = "ListViewEx5"
            Me.ListViewEx5.Size = New System.Drawing.Size(905, 240)
            Me.ListViewEx5.TabIndex = 3
            Me.ListViewEx5.UseCompatibleStateImageBehavior = False
            Me.ListViewEx5.View = System.Windows.Forms.View.Details
            '
            'ColumnHeader45
            '
            Me.ColumnHeader45.Text = "ID"
            '
            'ColumnHeader46
            '
            Me.ColumnHeader46.Text = "Employee ID"
            Me.ColumnHeader46.Width = 130
            '
            'ColumnHeader47
            '
            Me.ColumnHeader47.Text = "Lastname"
            Me.ColumnHeader47.Width = 130
            '
            'ColumnHeader48
            '
            Me.ColumnHeader48.Text = "Firstname"
            Me.ColumnHeader48.Width = 130
            '
            'ColumnHeader49
            '
            Me.ColumnHeader49.Text = "Middlename"
            Me.ColumnHeader49.Width = 130
            '
            'ColumnHeader50
            '
            Me.ColumnHeader50.Text = "Subject Code"
            Me.ColumnHeader50.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            Me.ColumnHeader50.Width = 130
            '
            'ColumnHeader51
            '
            Me.ColumnHeader51.Text = "Description"
            Me.ColumnHeader51.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            Me.ColumnHeader51.Width = 130
            '
            'ColumnHeader52
            '
            Me.ColumnHeader52.Text = "Units"
            Me.ColumnHeader52.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            '
            'ColumnHeader53
            '
            Me.ColumnHeader53.Text = "S.Y"
            Me.ColumnHeader53.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            Me.ColumnHeader53.Width = 130
            '
            'ColumnHeader54
            '
            Me.ColumnHeader54.Text = "Semester"
            Me.ColumnHeader54.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            Me.ColumnHeader54.Width = 130
            '
            'ColumnHeader55
            '
            Me.ColumnHeader55.Text = "Year Level"
            Me.ColumnHeader55.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            Me.ColumnHeader55.Width = 130
            '
            'ColumnHeader80
            '
            Me.ColumnHeader80.Text = "Directory"
            Me.ColumnHeader80.Width = 130
            '
            'MetroTabPanel6
            '
            Me.MetroTabPanel6.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
            Me.MetroTabPanel6.Controls.Add(Me.ExpandableSplitter12)
            Me.MetroTabPanel6.Controls.Add(Me.ExpandablePanel6)
            Me.MetroTabPanel6.Controls.Add(Me.LabelX6)
            Me.MetroTabPanel6.Controls.Add(Me.MetroToolbar1)
            Me.MetroTabPanel6.Controls.Add(Me.ExpandableSplitter2)
            Me.MetroTabPanel6.Controls.Add(Me.ListViewEx6)
            Me.MetroTabPanel6.Dock = System.Windows.Forms.DockStyle.Fill
            Me.MetroTabPanel6.Location = New System.Drawing.Point(0, 51)
            Me.MetroTabPanel6.Name = "MetroTabPanel6"
            Me.MetroTabPanel6.Padding = New System.Windows.Forms.Padding(3, 0, 3, 3)
            Me.MetroTabPanel6.Size = New System.Drawing.Size(911, 593)
            '
            '
            '
            Me.MetroTabPanel6.Style.CornerType = DevComponents.DotNetBar.eCornerType.Square
            '
            '
            '
            Me.MetroTabPanel6.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
            '
            '
            '
            Me.MetroTabPanel6.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.MetroTabPanel6.TabIndex = 8
            Me.MetroTabPanel6.Visible = False
            '
            'ExpandableSplitter12
            '
            Me.ExpandableSplitter12.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer))
            Me.ExpandableSplitter12.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer))
            Me.ExpandableSplitter12.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
            Me.ExpandableSplitter12.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
            Me.ExpandableSplitter12.Dock = System.Windows.Forms.DockStyle.Top
            Me.ExpandableSplitter12.ExpandFillColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer))
            Me.ExpandableSplitter12.ExpandFillColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
            Me.ExpandableSplitter12.ExpandLineColor = System.Drawing.Color.Black
            Me.ExpandableSplitter12.ExpandLineColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText
            Me.ExpandableSplitter12.ForeColor = System.Drawing.Color.Black
            Me.ExpandableSplitter12.GripDarkColor = System.Drawing.Color.Black
            Me.ExpandableSplitter12.GripDarkColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText
            Me.ExpandableSplitter12.GripLightColor = System.Drawing.Color.White
            Me.ExpandableSplitter12.GripLightColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
            Me.ExpandableSplitter12.HotBackColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer))
            Me.ExpandableSplitter12.HotBackColor2 = System.Drawing.Color.Empty
            Me.ExpandableSplitter12.HotBackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemPressedBackground2
            Me.ExpandableSplitter12.HotBackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemPressedBackground
            Me.ExpandableSplitter12.HotExpandFillColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer))
            Me.ExpandableSplitter12.HotExpandFillColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
            Me.ExpandableSplitter12.HotExpandLineColor = System.Drawing.Color.Black
            Me.ExpandableSplitter12.HotExpandLineColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText
            Me.ExpandableSplitter12.HotGripDarkColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer))
            Me.ExpandableSplitter12.HotGripDarkColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
            Me.ExpandableSplitter12.HotGripLightColor = System.Drawing.Color.White
            Me.ExpandableSplitter12.HotGripLightColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
            Me.ExpandableSplitter12.Location = New System.Drawing.Point(3, 491)
            Me.ExpandableSplitter12.Name = "ExpandableSplitter12"
            Me.ExpandableSplitter12.Size = New System.Drawing.Size(905, 10)
            Me.ExpandableSplitter12.Style = DevComponents.DotNetBar.eSplitterStyle.Office2007
            Me.ExpandableSplitter12.TabIndex = 65
            Me.ExpandableSplitter12.TabStop = False
            '
            'ExpandablePanel6
            '
            Me.ExpandablePanel6.CanvasColor = System.Drawing.SystemColors.Window
            Me.ExpandablePanel6.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
            Me.ExpandablePanel6.Controls.Add(Me.t_status)
            Me.ExpandablePanel6.Controls.Add(Me.LabelX66)
            Me.ExpandablePanel6.Controls.Add(Me.t_grades)
            Me.ExpandablePanel6.Controls.Add(Me.LabelX65)
            Me.ExpandablePanel6.Controls.Add(Me.t_course)
            Me.ExpandablePanel6.Controls.Add(Me.LabelX62)
            Me.ExpandablePanel6.Controls.Add(Me.t_stud_name)
            Me.ExpandablePanel6.Controls.Add(Me.LabelX63)
            Me.ExpandablePanel6.Controls.Add(Me.t_studid)
            Me.ExpandablePanel6.Controls.Add(Me.LabelX64)
            Me.ExpandablePanel6.Controls.Add(Me.LabelX39)
            Me.ExpandablePanel6.Controls.Add(Me.t_units)
            Me.ExpandablePanel6.Controls.Add(Me.t_subjdesc)
            Me.ExpandablePanel6.Controls.Add(Me.LabelX48)
            Me.ExpandablePanel6.Controls.Add(Me.LabelX50)
            Me.ExpandablePanel6.Controls.Add(Me.t_id_lbl)
            Me.ExpandablePanel6.Controls.Add(Me.ButtonX6)
            Me.ExpandablePanel6.Controls.Add(Me.t_directorypath)
            Me.ExpandablePanel6.Controls.Add(Me.LabelX52)
            Me.ExpandablePanel6.Controls.Add(Me.t_id)
            Me.ExpandablePanel6.Controls.Add(Me.LabelX53)
            Me.ExpandablePanel6.Controls.Add(Me.t_semester)
            Me.ExpandablePanel6.Controls.Add(Me.t_acadyear)
            Me.ExpandablePanel6.Controls.Add(Me.LabelX54)
            Me.ExpandablePanel6.Controls.Add(Me.t_yearlevel)
            Me.ExpandablePanel6.Controls.Add(Me.LabelX55)
            Me.ExpandablePanel6.Controls.Add(Me.t_subjcode)
            Me.ExpandablePanel6.Controls.Add(Me.LabelX56)
            Me.ExpandablePanel6.Controls.Add(Me.t_middlename)
            Me.ExpandablePanel6.Controls.Add(Me.t_firstname)
            Me.ExpandablePanel6.Controls.Add(Me.t_lastname)
            Me.ExpandablePanel6.Controls.Add(Me.LabelX57)
            Me.ExpandablePanel6.Controls.Add(Me.t_empid)
            Me.ExpandablePanel6.Controls.Add(Me.LabelX61)
            Me.ExpandablePanel6.Controls.Add(Me.PictureBox6)
            Me.ExpandablePanel6.DisabledBackColor = System.Drawing.Color.Empty
            Me.ExpandablePanel6.Dock = System.Windows.Forms.DockStyle.Top
            Me.ExpandablePanel6.HideControlsWhenCollapsed = True
            Me.ExpandablePanel6.Location = New System.Drawing.Point(3, 246)
            Me.ExpandablePanel6.Name = "ExpandablePanel6"
            Me.ExpandablePanel6.Size = New System.Drawing.Size(905, 245)
            Me.ExpandablePanel6.Style.Alignment = System.Drawing.StringAlignment.Center
            Me.ExpandablePanel6.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
            Me.ExpandablePanel6.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
            Me.ExpandablePanel6.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText
            Me.ExpandablePanel6.Style.GradientAngle = 90
            Me.ExpandablePanel6.TabIndex = 61
            Me.ExpandablePanel6.TitleStyle.Alignment = System.Drawing.StringAlignment.Center
            Me.ExpandablePanel6.TitleStyle.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
            Me.ExpandablePanel6.TitleStyle.Border = DevComponents.DotNetBar.eBorderType.RaisedInner
            Me.ExpandablePanel6.TitleStyle.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
            Me.ExpandablePanel6.TitleStyle.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
            Me.ExpandablePanel6.TitleStyle.GradientAngle = 90
            Me.ExpandablePanel6.TitleText = "Student Information"
            '
            't_status
            '
            Me.t_status.DisplayMember = "Text"
            Me.t_status.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
            Me.t_status.ForeColor = System.Drawing.Color.Black
            Me.t_status.FormattingEnabled = True
            Me.t_status.ItemHeight = 17
            Me.t_status.Items.AddRange(New Object() {Me.ComboItem7, Me.ComboItem8})
            Me.t_status.Location = New System.Drawing.Point(426, 175)
            Me.t_status.Name = "t_status"
            Me.t_status.Size = New System.Drawing.Size(100, 23)
            Me.t_status.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
            Me.t_status.TabIndex = 41
            '
            'ComboItem7
            '
            Me.ComboItem7.Text = "CLEARED"
            '
            'ComboItem8
            '
            Me.ComboItem8.Text = "NOT CLEARED"
            '
            'LabelX66
            '
            Me.LabelX66.BackColor = System.Drawing.Color.Transparent
            '
            '
            '
            Me.LabelX66.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.LabelX66.ForeColor = System.Drawing.Color.Black
            Me.LabelX66.Location = New System.Drawing.Point(345, 173)
            Me.LabelX66.Name = "LabelX66"
            Me.LabelX66.Size = New System.Drawing.Size(75, 23)
            Me.LabelX66.TabIndex = 40
            Me.LabelX66.Text = "Status:"
            '
            't_grades
            '
            Me.t_grades.BackColor = System.Drawing.Color.White
            '
            '
            '
            Me.t_grades.Border.Class = "TextBoxBorder"
            Me.t_grades.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.t_grades.DisabledBackColor = System.Drawing.Color.White
            Me.t_grades.ForeColor = System.Drawing.Color.Black
            Me.t_grades.Location = New System.Drawing.Point(426, 147)
            Me.t_grades.Name = "t_grades"
            Me.t_grades.PreventEnterBeep = True
            Me.t_grades.Size = New System.Drawing.Size(46, 22)
            Me.t_grades.TabIndex = 39
            '
            'LabelX65
            '
            Me.LabelX65.BackColor = System.Drawing.Color.Transparent
            '
            '
            '
            Me.LabelX65.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.LabelX65.ForeColor = System.Drawing.Color.Black
            Me.LabelX65.Location = New System.Drawing.Point(345, 146)
            Me.LabelX65.Name = "LabelX65"
            Me.LabelX65.Size = New System.Drawing.Size(75, 23)
            Me.LabelX65.TabIndex = 38
            Me.LabelX65.Text = "Grades:"
            '
            't_course
            '
            Me.t_course.BackColor = System.Drawing.Color.White
            '
            '
            '
            Me.t_course.Border.Class = "TextBoxBorder"
            Me.t_course.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.t_course.DisabledBackColor = System.Drawing.Color.White
            Me.t_course.ForeColor = System.Drawing.Color.Black
            Me.t_course.Location = New System.Drawing.Point(426, 96)
            Me.t_course.Name = "t_course"
            Me.t_course.PreventEnterBeep = True
            Me.t_course.Size = New System.Drawing.Size(46, 22)
            Me.t_course.TabIndex = 37
            '
            'LabelX62
            '
            Me.LabelX62.BackColor = System.Drawing.Color.Transparent
            '
            '
            '
            Me.LabelX62.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.LabelX62.ForeColor = System.Drawing.Color.Black
            Me.LabelX62.Location = New System.Drawing.Point(345, 95)
            Me.LabelX62.Name = "LabelX62"
            Me.LabelX62.Size = New System.Drawing.Size(75, 23)
            Me.LabelX62.TabIndex = 36
            Me.LabelX62.Text = "Course/ Yr:"
            '
            't_stud_name
            '
            Me.t_stud_name.BackColor = System.Drawing.Color.White
            '
            '
            '
            Me.t_stud_name.Border.Class = "TextBoxBorder"
            Me.t_stud_name.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.t_stud_name.DisabledBackColor = System.Drawing.Color.White
            Me.t_stud_name.ForeColor = System.Drawing.Color.Black
            Me.t_stud_name.Location = New System.Drawing.Point(229, 65)
            Me.t_stud_name.Name = "t_stud_name"
            Me.t_stud_name.PreventEnterBeep = True
            Me.t_stud_name.Size = New System.Drawing.Size(206, 22)
            Me.t_stud_name.TabIndex = 35
            '
            'LabelX63
            '
            Me.LabelX63.BackColor = System.Drawing.Color.Transparent
            '
            '
            '
            Me.LabelX63.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.LabelX63.ForeColor = System.Drawing.Color.Black
            Me.LabelX63.Location = New System.Drawing.Point(148, 37)
            Me.LabelX63.Name = "LabelX63"
            Me.LabelX63.Size = New System.Drawing.Size(75, 23)
            Me.LabelX63.TabIndex = 34
            Me.LabelX63.Text = "Student ID:"
            '
            't_studid
            '
            Me.t_studid.BackColor = System.Drawing.Color.White
            '
            '
            '
            Me.t_studid.Border.Class = "TextBoxBorder"
            Me.t_studid.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.t_studid.DisabledBackColor = System.Drawing.Color.White
            Me.t_studid.ForeColor = System.Drawing.Color.Black
            Me.t_studid.Location = New System.Drawing.Point(229, 37)
            Me.t_studid.Name = "t_studid"
            Me.t_studid.PreventEnterBeep = True
            Me.t_studid.Size = New System.Drawing.Size(100, 22)
            Me.t_studid.TabIndex = 33
            '
            'LabelX64
            '
            Me.LabelX64.BackColor = System.Drawing.Color.Transparent
            '
            '
            '
            Me.LabelX64.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.LabelX64.ForeColor = System.Drawing.Color.Black
            Me.LabelX64.Location = New System.Drawing.Point(142, 64)
            Me.LabelX64.Name = "LabelX64"
            Me.LabelX64.Size = New System.Drawing.Size(83, 23)
            Me.LabelX64.TabIndex = 32
            Me.LabelX64.Text = "Student's name:"
            '
            'LabelX39
            '
            Me.LabelX39.BackColor = System.Drawing.Color.Transparent
            '
            '
            '
            Me.LabelX39.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.LabelX39.ForeColor = System.Drawing.Color.Black
            Me.LabelX39.Location = New System.Drawing.Point(148, 150)
            Me.LabelX39.Name = "LabelX39"
            Me.LabelX39.Size = New System.Drawing.Size(75, 23)
            Me.LabelX39.TabIndex = 31
            Me.LabelX39.Text = "Unit:"
            '
            't_units
            '
            Me.t_units.BackColor = System.Drawing.Color.White
            '
            '
            '
            Me.t_units.Border.Class = "TextBoxBorder"
            Me.t_units.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.t_units.DisabledBackColor = System.Drawing.Color.White
            Me.t_units.ForeColor = System.Drawing.Color.Black
            Me.t_units.Location = New System.Drawing.Point(229, 150)
            Me.t_units.Name = "t_units"
            Me.t_units.PreventEnterBeep = True
            Me.t_units.Size = New System.Drawing.Size(48, 22)
            Me.t_units.TabIndex = 30
            '
            't_subjdesc
            '
            Me.t_subjdesc.BackColor = System.Drawing.Color.White
            '
            '
            '
            Me.t_subjdesc.Border.Class = "TextBoxBorder"
            Me.t_subjdesc.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.t_subjdesc.DisabledBackColor = System.Drawing.Color.White
            Me.t_subjdesc.ForeColor = System.Drawing.Color.Black
            Me.t_subjdesc.Location = New System.Drawing.Point(229, 122)
            Me.t_subjdesc.Name = "t_subjdesc"
            Me.t_subjdesc.PreventEnterBeep = True
            Me.t_subjdesc.Size = New System.Drawing.Size(100, 22)
            Me.t_subjdesc.TabIndex = 29
            '
            'LabelX48
            '
            Me.LabelX48.BackColor = System.Drawing.Color.Transparent
            '
            '
            '
            Me.LabelX48.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.LabelX48.ForeColor = System.Drawing.Color.Black
            Me.LabelX48.Location = New System.Drawing.Point(148, 121)
            Me.LabelX48.Name = "LabelX48"
            Me.LabelX48.Size = New System.Drawing.Size(75, 23)
            Me.LabelX48.TabIndex = 28
            Me.LabelX48.Text = "Subject Desc:"
            '
            'LabelX50
            '
            Me.LabelX50.BackColor = System.Drawing.Color.White
            '
            '
            '
            Me.LabelX50.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.LabelX50.ForeColor = System.Drawing.Color.Black
            Me.LabelX50.Location = New System.Drawing.Point(848, 205)
            Me.LabelX50.Name = "LabelX50"
            Me.LabelX50.Size = New System.Drawing.Size(35, 23)
            Me.LabelX50.TabIndex = 26
            Me.LabelX50.Text = "LabelX7"
            Me.LabelX50.Visible = False
            '
            't_id_lbl
            '
            Me.t_id_lbl.BackColor = System.Drawing.Color.White
            '
            '
            '
            Me.t_id_lbl.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.t_id_lbl.ForeColor = System.Drawing.Color.Black
            Me.t_id_lbl.Location = New System.Drawing.Point(797, 205)
            Me.t_id_lbl.Name = "t_id_lbl"
            Me.t_id_lbl.Size = New System.Drawing.Size(45, 23)
            Me.t_id_lbl.TabIndex = 25
            Me.t_id_lbl.Text = "LabelX7"
            Me.t_id_lbl.Visible = False
            '
            'ButtonX6
            '
            Me.ButtonX6.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
            Me.ButtonX6.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
            Me.ButtonX6.Location = New System.Drawing.Point(12, 206)
            Me.ButtonX6.Name = "ButtonX6"
            Me.ButtonX6.Size = New System.Drawing.Size(130, 23)
            Me.ButtonX6.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
            Me.ButtonX6.TabIndex = 24
            Me.ButtonX6.Text = "Upload"
            '
            't_directorypath
            '
            Me.t_directorypath.BackColor = System.Drawing.Color.White
            '
            '
            '
            Me.t_directorypath.Border.Class = "TextBoxBorder"
            Me.t_directorypath.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.t_directorypath.DisabledBackColor = System.Drawing.Color.White
            Me.t_directorypath.ForeColor = System.Drawing.Color.Black
            Me.t_directorypath.Location = New System.Drawing.Point(229, 206)
            Me.t_directorypath.Name = "t_directorypath"
            Me.t_directorypath.PreventEnterBeep = True
            Me.t_directorypath.Size = New System.Drawing.Size(312, 22)
            Me.t_directorypath.TabIndex = 23
            '
            'LabelX52
            '
            Me.LabelX52.BackColor = System.Drawing.Color.Transparent
            '
            '
            '
            Me.LabelX52.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.LabelX52.ForeColor = System.Drawing.Color.Black
            Me.LabelX52.Location = New System.Drawing.Point(148, 206)
            Me.LabelX52.Name = "LabelX52"
            Me.LabelX52.Size = New System.Drawing.Size(75, 23)
            Me.LabelX52.TabIndex = 22
            Me.LabelX52.Text = "Directory:"
            '
            't_id
            '
            Me.t_id.BackColor = System.Drawing.Color.White
            '
            '
            '
            Me.t_id.Border.Class = "TextBoxBorder"
            Me.t_id.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.t_id.DisabledBackColor = System.Drawing.Color.White
            Me.t_id.Enabled = False
            Me.t_id.ForeColor = System.Drawing.Color.Black
            Me.t_id.Location = New System.Drawing.Point(34, 37)
            Me.t_id.Name = "t_id"
            Me.t_id.PreventEnterBeep = True
            Me.t_id.Size = New System.Drawing.Size(25, 22)
            Me.t_id.TabIndex = 21
            '
            'LabelX53
            '
            Me.LabelX53.BackColor = System.Drawing.Color.Transparent
            '
            '
            '
            Me.LabelX53.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.LabelX53.ForeColor = System.Drawing.Color.Black
            Me.LabelX53.Location = New System.Drawing.Point(8, 36)
            Me.LabelX53.Name = "LabelX53"
            Me.LabelX53.Size = New System.Drawing.Size(20, 23)
            Me.LabelX53.TabIndex = 20
            Me.LabelX53.Text = "ID:"
            '
            't_semester
            '
            Me.t_semester.BackColor = System.Drawing.Color.White
            '
            '
            '
            Me.t_semester.Border.Class = "TextBoxBorder"
            Me.t_semester.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.t_semester.DisabledBackColor = System.Drawing.Color.White
            Me.t_semester.ForeColor = System.Drawing.Color.Black
            Me.t_semester.Location = New System.Drawing.Point(426, 121)
            Me.t_semester.Name = "t_semester"
            Me.t_semester.PreventEnterBeep = True
            Me.t_semester.Size = New System.Drawing.Size(100, 22)
            Me.t_semester.TabIndex = 17
            '
            't_acadyear
            '
            Me.t_acadyear.BackColor = System.Drawing.Color.White
            '
            '
            '
            Me.t_acadyear.Border.Class = "TextBoxBorder"
            Me.t_acadyear.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.t_acadyear.DisabledBackColor = System.Drawing.Color.White
            Me.t_acadyear.ForeColor = System.Drawing.Color.Black
            Me.t_acadyear.Location = New System.Drawing.Point(229, 179)
            Me.t_acadyear.Name = "t_acadyear"
            Me.t_acadyear.PreventEnterBeep = True
            Me.t_acadyear.Size = New System.Drawing.Size(100, 22)
            Me.t_acadyear.TabIndex = 16
            '
            'LabelX54
            '
            Me.LabelX54.BackColor = System.Drawing.Color.Transparent
            '
            '
            '
            Me.LabelX54.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.LabelX54.ForeColor = System.Drawing.Color.Black
            Me.LabelX54.Location = New System.Drawing.Point(345, 121)
            Me.LabelX54.Name = "LabelX54"
            Me.LabelX54.Size = New System.Drawing.Size(75, 23)
            Me.LabelX54.TabIndex = 15
            Me.LabelX54.Text = "Semester:"
            '
            't_yearlevel
            '
            Me.t_yearlevel.BackColor = System.Drawing.Color.White
            '
            '
            '
            Me.t_yearlevel.Border.Class = "TextBoxBorder"
            Me.t_yearlevel.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.t_yearlevel.DisabledBackColor = System.Drawing.Color.White
            Me.t_yearlevel.ForeColor = System.Drawing.Color.Black
            Me.t_yearlevel.Location = New System.Drawing.Point(478, 95)
            Me.t_yearlevel.Name = "t_yearlevel"
            Me.t_yearlevel.PreventEnterBeep = True
            Me.t_yearlevel.Size = New System.Drawing.Size(48, 22)
            Me.t_yearlevel.TabIndex = 14
            '
            'LabelX55
            '
            Me.LabelX55.BackColor = System.Drawing.Color.Transparent
            '
            '
            '
            Me.LabelX55.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.LabelX55.ForeColor = System.Drawing.Color.Black
            Me.LabelX55.Location = New System.Drawing.Point(148, 179)
            Me.LabelX55.Name = "LabelX55"
            Me.LabelX55.Size = New System.Drawing.Size(75, 23)
            Me.LabelX55.TabIndex = 13
            Me.LabelX55.Text = "Academic Yr:"
            '
            't_subjcode
            '
            Me.t_subjcode.BackColor = System.Drawing.Color.White
            '
            '
            '
            Me.t_subjcode.Border.Class = "TextBoxBorder"
            Me.t_subjcode.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.t_subjcode.DisabledBackColor = System.Drawing.Color.White
            Me.t_subjcode.ForeColor = System.Drawing.Color.Black
            Me.t_subjcode.Location = New System.Drawing.Point(229, 94)
            Me.t_subjcode.Name = "t_subjcode"
            Me.t_subjcode.PreventEnterBeep = True
            Me.t_subjcode.Size = New System.Drawing.Size(100, 22)
            Me.t_subjcode.TabIndex = 12
            '
            'LabelX56
            '
            Me.LabelX56.BackColor = System.Drawing.Color.Transparent
            '
            '
            '
            Me.LabelX56.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.LabelX56.ForeColor = System.Drawing.Color.Black
            Me.LabelX56.Location = New System.Drawing.Point(148, 95)
            Me.LabelX56.Name = "LabelX56"
            Me.LabelX56.Size = New System.Drawing.Size(75, 23)
            Me.LabelX56.TabIndex = 11
            Me.LabelX56.Text = "Subject Code:"
            '
            't_middlename
            '
            Me.t_middlename.BackColor = System.Drawing.Color.White
            '
            '
            '
            Me.t_middlename.Border.Class = "TextBoxBorder"
            Me.t_middlename.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.t_middlename.DisabledBackColor = System.Drawing.Color.White
            Me.t_middlename.ForeColor = System.Drawing.Color.Black
            Me.t_middlename.Location = New System.Drawing.Point(639, 179)
            Me.t_middlename.Name = "t_middlename"
            Me.t_middlename.PreventEnterBeep = True
            Me.t_middlename.Size = New System.Drawing.Size(100, 22)
            Me.t_middlename.TabIndex = 10
            '
            't_firstname
            '
            Me.t_firstname.BackColor = System.Drawing.Color.White
            '
            '
            '
            Me.t_firstname.Border.Class = "TextBoxBorder"
            Me.t_firstname.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.t_firstname.DisabledBackColor = System.Drawing.Color.White
            Me.t_firstname.ForeColor = System.Drawing.Color.Black
            Me.t_firstname.Location = New System.Drawing.Point(639, 151)
            Me.t_firstname.Name = "t_firstname"
            Me.t_firstname.PreventEnterBeep = True
            Me.t_firstname.Size = New System.Drawing.Size(100, 22)
            Me.t_firstname.TabIndex = 9
            '
            't_lastname
            '
            Me.t_lastname.BackColor = System.Drawing.Color.White
            '
            '
            '
            Me.t_lastname.Border.Class = "TextBoxBorder"
            Me.t_lastname.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.t_lastname.DisabledBackColor = System.Drawing.Color.White
            Me.t_lastname.ForeColor = System.Drawing.Color.Black
            Me.t_lastname.Location = New System.Drawing.Point(639, 123)
            Me.t_lastname.Name = "t_lastname"
            Me.t_lastname.PreventEnterBeep = True
            Me.t_lastname.Size = New System.Drawing.Size(100, 22)
            Me.t_lastname.TabIndex = 8
            '
            'LabelX57
            '
            Me.LabelX57.BackColor = System.Drawing.Color.Transparent
            '
            '
            '
            Me.LabelX57.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.LabelX57.ForeColor = System.Drawing.Color.Black
            Me.LabelX57.Location = New System.Drawing.Point(558, 95)
            Me.LabelX57.Name = "LabelX57"
            Me.LabelX57.Size = New System.Drawing.Size(75, 23)
            Me.LabelX57.TabIndex = 7
            Me.LabelX57.Text = "Employee ID:"
            '
            't_empid
            '
            Me.t_empid.BackColor = System.Drawing.Color.White
            '
            '
            '
            Me.t_empid.Border.Class = "TextBoxBorder"
            Me.t_empid.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.t_empid.DisabledBackColor = System.Drawing.Color.White
            Me.t_empid.ForeColor = System.Drawing.Color.Black
            Me.t_empid.Location = New System.Drawing.Point(639, 94)
            Me.t_empid.Name = "t_empid"
            Me.t_empid.PreventEnterBeep = True
            Me.t_empid.Size = New System.Drawing.Size(100, 22)
            Me.t_empid.TabIndex = 6
            '
            'LabelX61
            '
            Me.LabelX61.BackColor = System.Drawing.Color.Transparent
            '
            '
            '
            Me.LabelX61.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.LabelX61.ForeColor = System.Drawing.Color.Black
            Me.LabelX61.Location = New System.Drawing.Point(537, 120)
            Me.LabelX61.Name = "LabelX61"
            Me.LabelX61.Size = New System.Drawing.Size(96, 23)
            Me.LabelX61.TabIndex = 5
            Me.LabelX61.Text = "Instructor's name:"
            '
            'PictureBox6
            '
            Me.PictureBox6.BackColor = System.Drawing.Color.White
            Me.PictureBox6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
            Me.PictureBox6.ForeColor = System.Drawing.Color.Black
            Me.PictureBox6.Location = New System.Drawing.Point(12, 67)
            Me.PictureBox6.Name = "PictureBox6"
            Me.PictureBox6.Size = New System.Drawing.Size(130, 136)
            Me.PictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
            Me.PictureBox6.TabIndex = 4
            Me.PictureBox6.TabStop = False
            '
            'LabelX6
            '
            Me.LabelX6.BackColor = System.Drawing.Color.White
            '
            '
            '
            Me.LabelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.LabelX6.ForeColor = System.Drawing.Color.Black
            Me.LabelX6.Location = New System.Drawing.Point(126, 297)
            Me.LabelX6.Name = "LabelX6"
            Me.LabelX6.Size = New System.Drawing.Size(75, 23)
            Me.LabelX6.TabIndex = 22
            Me.LabelX6.Text = "LabelX6"
            Me.LabelX6.Visible = False
            '
            'MetroToolbar1
            '
            Me.MetroToolbar1.BackColor = System.Drawing.Color.White
            '
            '
            '
            Me.MetroToolbar1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.MetroToolbar1.ContainerControlProcessDialogKey = True
            Me.MetroToolbar1.DragDropSupport = True
            Me.MetroToolbar1.ExpandDirection = DevComponents.DotNetBar.Metro.eExpandDirection.Top
            Me.MetroToolbar1.ExtraItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.deleteGradesButton})
            Me.MetroToolbar1.ForeColor = System.Drawing.Color.Black
            Me.MetroToolbar1.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.searchGradessButton, Me.addGradesButton, Me.updateGradesButton})
            Me.MetroToolbar1.LicenseKey = "F962CEC7-CD8F-4911-A9E9-CAB39962FC1F"
            Me.MetroToolbar1.Location = New System.Drawing.Point(292, 553)
            Me.MetroToolbar1.Name = "MetroToolbar1"
            Me.MetroToolbar1.Size = New System.Drawing.Size(388, 38)
            Me.MetroToolbar1.TabIndex = 21
            Me.MetroToolbar1.Text = "Invoices"
            '
            'deleteGradesButton
            '
            Me.deleteGradesButton.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
            Me.deleteGradesButton.Image = Global.My.Resources.Resources.Delete1
            Me.deleteGradesButton.ImageAlt = Global.My.Resources.Resources.DeleteWhite
            Me.deleteGradesButton.Name = "deleteGradesButton"
            Me.deleteGradesButton.Text = "Delete Record"
            Me.deleteGradesButton.Tooltip = "Delete Selected Record"
            '
            'searchGradessButton
            '
            Me.searchGradessButton.AutoExpandOnClick = True
            Me.searchGradessButton.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
            Me.searchGradessButton.Image = Global.My.Resources.Resources.search_ic_crop
            Me.searchGradessButton.ImageAlt = Global.My.Resources.Resources.NewInvoiceWhite
            Me.searchGradessButton.Name = "searchGradessButton"
            Me.searchGradessButton.PopupSide = DevComponents.DotNetBar.ePopupSide.Top
            Me.searchGradessButton.PopupType = DevComponents.DotNetBar.ePopupType.ToolBar
            Me.searchGradessButton.PopupWidth = 50
            Me.searchGradessButton.Shape = New DevComponents.DotNetBar.RoundRectangleShapeDescriptor(2)
            Me.searchGradessButton.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.searchGradesTxt})
            Me.searchGradessButton.Text = "Search Record"
            Me.searchGradessButton.Tooltip = "Search"
            '
            'searchGradesTxt
            '
            Me.searchGradesTxt.FocusHighlightColor = System.Drawing.Color.YellowGreen
            Me.searchGradesTxt.Name = "searchGradesTxt"
            Me.searchGradesTxt.Stretch = True
            Me.searchGradesTxt.TextBoxWidth = 200
            Me.searchGradesTxt.WatermarkColor = System.Drawing.SystemColors.GrayText
            '
            'addGradesButton
            '
            Me.addGradesButton.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
            Me.addGradesButton.Image = Global.My.Resources.Resources.addnew_edit
            Me.addGradesButton.ImageAlt = Global.My.Resources.Resources.BookNoteWhite
            Me.addGradesButton.Name = "addGradesButton"
            Me.addGradesButton.PopupSide = DevComponents.DotNetBar.ePopupSide.Top
            Me.addGradesButton.Text = "Add Record"
            Me.addGradesButton.Tooltip = "Add new Record"
            '
            'updateGradesButton
            '
            Me.updateGradesButton.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
            Me.updateGradesButton.Image = Global.My.Resources.Resources.edit_new_res
            Me.updateGradesButton.ImageAlt = Global.My.Resources.Resources.PaperClipWhite
            Me.updateGradesButton.Name = "updateGradesButton"
            Me.updateGradesButton.Text = "Update Record"
            Me.updateGradesButton.Tooltip = "Update an existimg Record"
            '
            'ExpandableSplitter2
            '
            Me.ExpandableSplitter2.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer))
            Me.ExpandableSplitter2.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer))
            Me.ExpandableSplitter2.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
            Me.ExpandableSplitter2.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
            Me.ExpandableSplitter2.Dock = System.Windows.Forms.DockStyle.Top
            Me.ExpandableSplitter2.ExpandFillColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer))
            Me.ExpandableSplitter2.ExpandFillColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
            Me.ExpandableSplitter2.ExpandLineColor = System.Drawing.Color.Black
            Me.ExpandableSplitter2.ExpandLineColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText
            Me.ExpandableSplitter2.ForeColor = System.Drawing.Color.Black
            Me.ExpandableSplitter2.GripDarkColor = System.Drawing.Color.Black
            Me.ExpandableSplitter2.GripDarkColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText
            Me.ExpandableSplitter2.GripLightColor = System.Drawing.Color.White
            Me.ExpandableSplitter2.GripLightColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
            Me.ExpandableSplitter2.HotBackColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer))
            Me.ExpandableSplitter2.HotBackColor2 = System.Drawing.Color.Empty
            Me.ExpandableSplitter2.HotBackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemPressedBackground2
            Me.ExpandableSplitter2.HotBackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemPressedBackground
            Me.ExpandableSplitter2.HotExpandFillColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer))
            Me.ExpandableSplitter2.HotExpandFillColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
            Me.ExpandableSplitter2.HotExpandLineColor = System.Drawing.Color.Black
            Me.ExpandableSplitter2.HotExpandLineColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText
            Me.ExpandableSplitter2.HotGripDarkColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer))
            Me.ExpandableSplitter2.HotGripDarkColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
            Me.ExpandableSplitter2.HotGripLightColor = System.Drawing.Color.White
            Me.ExpandableSplitter2.HotGripLightColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
            Me.ExpandableSplitter2.Location = New System.Drawing.Point(3, 240)
            Me.ExpandableSplitter2.Name = "ExpandableSplitter2"
            Me.ExpandableSplitter2.Size = New System.Drawing.Size(905, 6)
            Me.ExpandableSplitter2.Style = DevComponents.DotNetBar.eSplitterStyle.Office2007
            Me.ExpandableSplitter2.TabIndex = 18
            Me.ExpandableSplitter2.TabStop = False
            '
            'ListViewEx6
            '
            Me.ListViewEx6.BackColor = System.Drawing.Color.White
            '
            '
            '
            Me.ListViewEx6.Border.Class = "ListViewBorder"
            Me.ListViewEx6.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.ListViewEx6.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader22, Me.ColumnHeader56, Me.ColumnHeader62, Me.ColumnHeader63, Me.ColumnHeader64, Me.ColumnHeader65, Me.ColumnHeader66, Me.ColumnHeader67, Me.ColumnHeader68, Me.ColumnHeader69, Me.ColumnHeader70, Me.ColumnHeader71, Me.ColumnHeader75, Me.ColumnHeader76, Me.ColumnHeader77, Me.ColumnHeader78, Me.ColumnHeader81})
            Me.ListViewEx6.DisabledBackColor = System.Drawing.Color.Empty
            Me.ListViewEx6.Dock = System.Windows.Forms.DockStyle.Top
            Me.ListViewEx6.ForeColor = System.Drawing.Color.Black
            Me.ListViewEx6.FullRowSelect = True
            Me.ListViewEx6.Location = New System.Drawing.Point(3, 0)
            Me.ListViewEx6.Name = "ListViewEx6"
            Me.ListViewEx6.Size = New System.Drawing.Size(905, 240)
            Me.ListViewEx6.TabIndex = 4
            Me.ListViewEx6.UseCompatibleStateImageBehavior = False
            Me.ListViewEx6.View = System.Windows.Forms.View.Details
            '
            'ColumnHeader22
            '
            Me.ColumnHeader22.Text = "ID"
            '
            'ColumnHeader56
            '
            Me.ColumnHeader56.Text = "Employee ID"
            Me.ColumnHeader56.Width = 130
            '
            'ColumnHeader62
            '
            Me.ColumnHeader62.Text = "Lastname"
            Me.ColumnHeader62.Width = 130
            '
            'ColumnHeader63
            '
            Me.ColumnHeader63.Text = "Firstname"
            Me.ColumnHeader63.Width = 130
            '
            'ColumnHeader64
            '
            Me.ColumnHeader64.Text = "Middlename"
            Me.ColumnHeader64.Width = 130
            '
            'ColumnHeader65
            '
            Me.ColumnHeader65.Text = "Subject Code"
            Me.ColumnHeader65.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            Me.ColumnHeader65.Width = 130
            '
            'ColumnHeader66
            '
            Me.ColumnHeader66.Text = "Description"
            Me.ColumnHeader66.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            Me.ColumnHeader66.Width = 130
            '
            'ColumnHeader67
            '
            Me.ColumnHeader67.Text = "Units"
            Me.ColumnHeader67.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            '
            'ColumnHeader68
            '
            Me.ColumnHeader68.Text = "S.Y"
            Me.ColumnHeader68.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            Me.ColumnHeader68.Width = 130
            '
            'ColumnHeader69
            '
            Me.ColumnHeader69.Text = "Semester"
            Me.ColumnHeader69.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            Me.ColumnHeader69.Width = 130
            '
            'ColumnHeader70
            '
            Me.ColumnHeader70.Text = "Year Level"
            Me.ColumnHeader70.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            Me.ColumnHeader70.Width = 130
            '
            'ColumnHeader71
            '
            Me.ColumnHeader71.Text = "Student Number"
            Me.ColumnHeader71.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            Me.ColumnHeader71.Width = 130
            '
            'ColumnHeader75
            '
            Me.ColumnHeader75.Text = "Student Name"
            Me.ColumnHeader75.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            Me.ColumnHeader75.Width = 130
            '
            'ColumnHeader76
            '
            Me.ColumnHeader76.Text = "Course"
            Me.ColumnHeader76.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            '
            'ColumnHeader77
            '
            Me.ColumnHeader77.Text = "Grades"
            Me.ColumnHeader77.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            '
            'ColumnHeader78
            '
            Me.ColumnHeader78.Text = "Status"
            Me.ColumnHeader78.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            Me.ColumnHeader78.Width = 130
            '
            'ColumnHeader81
            '
            Me.ColumnHeader81.Text = "Directory"
            Me.ColumnHeader81.Width = 130
            '
            'MetroTabPanel4
            '
            Me.MetroTabPanel4.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
            Me.MetroTabPanel4.Controls.Add(Me.ExpandableSplitter9)
            Me.MetroTabPanel4.Controls.Add(Me.ExpandablePanel3)
            Me.MetroTabPanel4.Controls.Add(Me.MetroToolbar4)
            Me.MetroTabPanel4.Controls.Add(Me.LabelX3)
            Me.MetroTabPanel4.Controls.Add(Me.ExpandableSplitter4)
            Me.MetroTabPanel4.Controls.Add(Me.ListViewEx4)
            Me.MetroTabPanel4.Dock = System.Windows.Forms.DockStyle.Fill
            Me.MetroTabPanel4.Location = New System.Drawing.Point(0, 51)
            Me.MetroTabPanel4.Name = "MetroTabPanel4"
            Me.MetroTabPanel4.Padding = New System.Windows.Forms.Padding(3, 0, 3, 3)
            Me.MetroTabPanel4.Size = New System.Drawing.Size(911, 593)
            '
            '
            '
            Me.MetroTabPanel4.Style.CornerType = DevComponents.DotNetBar.eCornerType.Square
            '
            '
            '
            Me.MetroTabPanel4.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
            '
            '
            '
            Me.MetroTabPanel4.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.MetroTabPanel4.TabIndex = 4
            Me.MetroTabPanel4.Visible = False
            '
            'ExpandableSplitter9
            '
            Me.ExpandableSplitter9.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer))
            Me.ExpandableSplitter9.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer))
            Me.ExpandableSplitter9.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
            Me.ExpandableSplitter9.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
            Me.ExpandableSplitter9.Dock = System.Windows.Forms.DockStyle.Top
            Me.ExpandableSplitter9.ExpandFillColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer))
            Me.ExpandableSplitter9.ExpandFillColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
            Me.ExpandableSplitter9.ExpandLineColor = System.Drawing.Color.Black
            Me.ExpandableSplitter9.ExpandLineColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText
            Me.ExpandableSplitter9.ForeColor = System.Drawing.Color.Black
            Me.ExpandableSplitter9.GripDarkColor = System.Drawing.Color.Black
            Me.ExpandableSplitter9.GripDarkColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText
            Me.ExpandableSplitter9.GripLightColor = System.Drawing.Color.White
            Me.ExpandableSplitter9.GripLightColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
            Me.ExpandableSplitter9.HotBackColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer))
            Me.ExpandableSplitter9.HotBackColor2 = System.Drawing.Color.Empty
            Me.ExpandableSplitter9.HotBackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemPressedBackground2
            Me.ExpandableSplitter9.HotBackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemPressedBackground
            Me.ExpandableSplitter9.HotExpandFillColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer))
            Me.ExpandableSplitter9.HotExpandFillColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
            Me.ExpandableSplitter9.HotExpandLineColor = System.Drawing.Color.Black
            Me.ExpandableSplitter9.HotExpandLineColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText
            Me.ExpandableSplitter9.HotGripDarkColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer))
            Me.ExpandableSplitter9.HotGripDarkColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
            Me.ExpandableSplitter9.HotGripLightColor = System.Drawing.Color.White
            Me.ExpandableSplitter9.HotGripLightColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
            Me.ExpandableSplitter9.Location = New System.Drawing.Point(3, 491)
            Me.ExpandableSplitter9.Name = "ExpandableSplitter9"
            Me.ExpandableSplitter9.Size = New System.Drawing.Size(905, 10)
            Me.ExpandableSplitter9.Style = DevComponents.DotNetBar.eSplitterStyle.Office2007
            Me.ExpandableSplitter9.TabIndex = 51
            Me.ExpandableSplitter9.TabStop = False
            '
            'ExpandablePanel3
            '
            Me.ExpandablePanel3.CanvasColor = System.Drawing.SystemColors.Window
            Me.ExpandablePanel3.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
            Me.ExpandablePanel3.Controls.Add(Me.l_status)
            Me.ExpandablePanel3.Controls.Add(Me.LabelX28)
            Me.ExpandablePanel3.Controls.Add(Me.l_remainingBal)
            Me.ExpandablePanel3.Controls.Add(Me.l_unretbook)
            Me.ExpandablePanel3.Controls.Add(Me.LabelX18)
            Me.ExpandablePanel3.Controls.Add(Me.LabelX19)
            Me.ExpandablePanel3.Controls.Add(Me.l_fullname)
            Me.ExpandablePanel3.Controls.Add(Me.l_id_lbl)
            Me.ExpandablePanel3.Controls.Add(Me.ButtonX3)
            Me.ExpandablePanel3.Controls.Add(Me.l_directorypath)
            Me.ExpandablePanel3.Controls.Add(Me.LabelX20)
            Me.ExpandablePanel3.Controls.Add(Me.l_id)
            Me.ExpandablePanel3.Controls.Add(Me.LabelX21)
            Me.ExpandablePanel3.Controls.Add(Me.l_contact)
            Me.ExpandablePanel3.Controls.Add(Me.LabelX22)
            Me.ExpandablePanel3.Controls.Add(Me.l_semester)
            Me.ExpandablePanel3.Controls.Add(Me.l_acadyear)
            Me.ExpandablePanel3.Controls.Add(Me.LabelX23)
            Me.ExpandablePanel3.Controls.Add(Me.l_yearlevel)
            Me.ExpandablePanel3.Controls.Add(Me.LabelX24)
            Me.ExpandablePanel3.Controls.Add(Me.l_course)
            Me.ExpandablePanel3.Controls.Add(Me.LabelX25)
            Me.ExpandablePanel3.Controls.Add(Me.l_middlename)
            Me.ExpandablePanel3.Controls.Add(Me.l_fistname)
            Me.ExpandablePanel3.Controls.Add(Me.l_lastname)
            Me.ExpandablePanel3.Controls.Add(Me.LabelX26)
            Me.ExpandablePanel3.Controls.Add(Me.l_studid)
            Me.ExpandablePanel3.Controls.Add(Me.LabelX27)
            Me.ExpandablePanel3.Controls.Add(Me.PictureBox3)
            Me.ExpandablePanel3.DisabledBackColor = System.Drawing.Color.Empty
            Me.ExpandablePanel3.Dock = System.Windows.Forms.DockStyle.Top
            Me.ExpandablePanel3.HideControlsWhenCollapsed = True
            Me.ExpandablePanel3.Location = New System.Drawing.Point(3, 246)
            Me.ExpandablePanel3.Name = "ExpandablePanel3"
            Me.ExpandablePanel3.Size = New System.Drawing.Size(905, 245)
            Me.ExpandablePanel3.Style.Alignment = System.Drawing.StringAlignment.Center
            Me.ExpandablePanel3.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
            Me.ExpandablePanel3.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
            Me.ExpandablePanel3.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText
            Me.ExpandablePanel3.Style.GradientAngle = 90
            Me.ExpandablePanel3.TabIndex = 50
            Me.ExpandablePanel3.TitleStyle.Alignment = System.Drawing.StringAlignment.Center
            Me.ExpandablePanel3.TitleStyle.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
            Me.ExpandablePanel3.TitleStyle.Border = DevComponents.DotNetBar.eBorderType.RaisedInner
            Me.ExpandablePanel3.TitleStyle.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
            Me.ExpandablePanel3.TitleStyle.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
            Me.ExpandablePanel3.TitleStyle.GradientAngle = 90
            Me.ExpandablePanel3.TitleText = "Student Information"
            '
            'l_status
            '
            Me.l_status.DisplayMember = "Text"
            Me.l_status.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
            Me.l_status.ForeColor = System.Drawing.Color.Black
            Me.l_status.FormattingEnabled = True
            Me.l_status.ItemHeight = 17
            Me.l_status.Items.AddRange(New Object() {Me.ComboItem5, Me.ComboItem6})
            Me.l_status.Location = New System.Drawing.Point(441, 178)
            Me.l_status.Name = "l_status"
            Me.l_status.Size = New System.Drawing.Size(100, 23)
            Me.l_status.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
            Me.l_status.TabIndex = 32
            '
            'ComboItem5
            '
            Me.ComboItem5.Text = "CLEARED"
            '
            'ComboItem6
            '
            Me.ComboItem6.Text = "NOT CLEARED"
            '
            'LabelX28
            '
            Me.LabelX28.BackColor = System.Drawing.Color.Transparent
            '
            '
            '
            Me.LabelX28.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.LabelX28.ForeColor = System.Drawing.Color.Black
            Me.LabelX28.Location = New System.Drawing.Point(335, 178)
            Me.LabelX28.Name = "LabelX28"
            Me.LabelX28.Size = New System.Drawing.Size(100, 23)
            Me.LabelX28.TabIndex = 31
            Me.LabelX28.Text = "Status:"
            Me.LabelX28.TextAlignment = System.Drawing.StringAlignment.Far
            '
            'l_remainingBal
            '
            Me.l_remainingBal.BackColor = System.Drawing.Color.White
            '
            '
            '
            Me.l_remainingBal.Border.Class = "TextBoxBorder"
            Me.l_remainingBal.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.l_remainingBal.DisabledBackColor = System.Drawing.Color.White
            Me.l_remainingBal.ForeColor = System.Drawing.Color.Black
            Me.l_remainingBal.Location = New System.Drawing.Point(441, 150)
            Me.l_remainingBal.Name = "l_remainingBal"
            Me.l_remainingBal.PreventEnterBeep = True
            Me.l_remainingBal.Size = New System.Drawing.Size(100, 22)
            Me.l_remainingBal.TabIndex = 30
            '
            'l_unretbook
            '
            Me.l_unretbook.BackColor = System.Drawing.Color.White
            '
            '
            '
            Me.l_unretbook.Border.Class = "TextBoxBorder"
            Me.l_unretbook.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.l_unretbook.DisabledBackColor = System.Drawing.Color.White
            Me.l_unretbook.ForeColor = System.Drawing.Color.Black
            Me.l_unretbook.Location = New System.Drawing.Point(441, 122)
            Me.l_unretbook.Name = "l_unretbook"
            Me.l_unretbook.PreventEnterBeep = True
            Me.l_unretbook.Size = New System.Drawing.Size(100, 22)
            Me.l_unretbook.TabIndex = 29
            '
            'LabelX18
            '
            Me.LabelX18.BackColor = System.Drawing.Color.Transparent
            '
            '
            '
            Me.LabelX18.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.LabelX18.ForeColor = System.Drawing.Color.Black
            Me.LabelX18.Location = New System.Drawing.Point(335, 150)
            Me.LabelX18.Name = "LabelX18"
            Me.LabelX18.Size = New System.Drawing.Size(100, 23)
            Me.LabelX18.TabIndex = 28
            Me.LabelX18.Text = "Remaining Penalty:"
            Me.LabelX18.TextAlignment = System.Drawing.StringAlignment.Far
            '
            'LabelX19
            '
            Me.LabelX19.BackColor = System.Drawing.Color.Transparent
            '
            '
            '
            Me.LabelX19.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.LabelX19.ForeColor = System.Drawing.Color.Black
            Me.LabelX19.Location = New System.Drawing.Point(335, 122)
            Me.LabelX19.Name = "LabelX19"
            Me.LabelX19.Size = New System.Drawing.Size(100, 23)
            Me.LabelX19.TabIndex = 27
            Me.LabelX19.Text = "Unreturned Book:"
            Me.LabelX19.TextAlignment = System.Drawing.StringAlignment.Far
            '
            'l_fullname
            '
            Me.l_fullname.BackColor = System.Drawing.Color.White
            '
            '
            '
            Me.l_fullname.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.l_fullname.ForeColor = System.Drawing.Color.Black
            Me.l_fullname.Location = New System.Drawing.Point(683, 51)
            Me.l_fullname.Name = "l_fullname"
            Me.l_fullname.Size = New System.Drawing.Size(105, 23)
            Me.l_fullname.TabIndex = 26
            Me.l_fullname.Text = "LabelX7"
            Me.l_fullname.Visible = False
            '
            'l_id_lbl
            '
            Me.l_id_lbl.BackColor = System.Drawing.Color.White
            '
            '
            '
            Me.l_id_lbl.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.l_id_lbl.ForeColor = System.Drawing.Color.Black
            Me.l_id_lbl.Location = New System.Drawing.Point(335, 37)
            Me.l_id_lbl.Name = "l_id_lbl"
            Me.l_id_lbl.Size = New System.Drawing.Size(75, 23)
            Me.l_id_lbl.TabIndex = 25
            Me.l_id_lbl.Text = "LabelX7"
            Me.l_id_lbl.Visible = False
            '
            'ButtonX3
            '
            Me.ButtonX3.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
            Me.ButtonX3.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
            Me.ButtonX3.Location = New System.Drawing.Point(12, 206)
            Me.ButtonX3.Name = "ButtonX3"
            Me.ButtonX3.Size = New System.Drawing.Size(130, 23)
            Me.ButtonX3.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
            Me.ButtonX3.TabIndex = 24
            Me.ButtonX3.Text = "Upload"
            '
            'l_directorypath
            '
            Me.l_directorypath.BackColor = System.Drawing.Color.White
            '
            '
            '
            Me.l_directorypath.Border.Class = "TextBoxBorder"
            Me.l_directorypath.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.l_directorypath.DisabledBackColor = System.Drawing.Color.White
            Me.l_directorypath.ForeColor = System.Drawing.Color.Black
            Me.l_directorypath.Location = New System.Drawing.Point(229, 206)
            Me.l_directorypath.Name = "l_directorypath"
            Me.l_directorypath.PreventEnterBeep = True
            Me.l_directorypath.Size = New System.Drawing.Size(312, 22)
            Me.l_directorypath.TabIndex = 23
            '
            'LabelX20
            '
            Me.LabelX20.BackColor = System.Drawing.Color.Transparent
            '
            '
            '
            Me.LabelX20.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.LabelX20.ForeColor = System.Drawing.Color.Black
            Me.LabelX20.Location = New System.Drawing.Point(148, 206)
            Me.LabelX20.Name = "LabelX20"
            Me.LabelX20.Size = New System.Drawing.Size(75, 23)
            Me.LabelX20.TabIndex = 22
            Me.LabelX20.Text = "Directory:"
            '
            'l_id
            '
            Me.l_id.BackColor = System.Drawing.Color.White
            '
            '
            '
            Me.l_id.Border.Class = "TextBoxBorder"
            Me.l_id.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.l_id.DisabledBackColor = System.Drawing.Color.White
            Me.l_id.Enabled = False
            Me.l_id.ForeColor = System.Drawing.Color.Black
            Me.l_id.Location = New System.Drawing.Point(34, 37)
            Me.l_id.Name = "l_id"
            Me.l_id.PreventEnterBeep = True
            Me.l_id.Size = New System.Drawing.Size(25, 22)
            Me.l_id.TabIndex = 21
            '
            'LabelX21
            '
            Me.LabelX21.BackColor = System.Drawing.Color.Transparent
            '
            '
            '
            Me.LabelX21.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.LabelX21.ForeColor = System.Drawing.Color.Black
            Me.LabelX21.Location = New System.Drawing.Point(8, 36)
            Me.LabelX21.Name = "LabelX21"
            Me.LabelX21.Size = New System.Drawing.Size(20, 23)
            Me.LabelX21.TabIndex = 20
            Me.LabelX21.Text = "ID:"
            '
            'l_contact
            '
            Me.l_contact.BackColor = System.Drawing.Color.White
            '
            '
            '
            Me.l_contact.Border.Class = "TextBoxBorder"
            Me.l_contact.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.l_contact.DisabledBackColor = System.Drawing.Color.White
            Me.l_contact.ForeColor = System.Drawing.Color.Black
            Me.l_contact.Location = New System.Drawing.Point(229, 179)
            Me.l_contact.Name = "l_contact"
            Me.l_contact.PreventEnterBeep = True
            Me.l_contact.Size = New System.Drawing.Size(100, 22)
            Me.l_contact.TabIndex = 19
            '
            'LabelX22
            '
            Me.LabelX22.BackColor = System.Drawing.Color.Transparent
            '
            '
            '
            Me.LabelX22.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.LabelX22.ForeColor = System.Drawing.Color.Black
            Me.LabelX22.Location = New System.Drawing.Point(148, 179)
            Me.LabelX22.Name = "LabelX22"
            Me.LabelX22.Size = New System.Drawing.Size(75, 23)
            Me.LabelX22.TabIndex = 18
            Me.LabelX22.Text = "Contact #:"
            '
            'l_semester
            '
            Me.l_semester.BackColor = System.Drawing.Color.White
            '
            '
            '
            Me.l_semester.Border.Class = "TextBoxBorder"
            Me.l_semester.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.l_semester.DisabledBackColor = System.Drawing.Color.White
            Me.l_semester.ForeColor = System.Drawing.Color.Black
            Me.l_semester.Location = New System.Drawing.Point(229, 151)
            Me.l_semester.Name = "l_semester"
            Me.l_semester.PreventEnterBeep = True
            Me.l_semester.Size = New System.Drawing.Size(100, 22)
            Me.l_semester.TabIndex = 17
            '
            'l_acadyear
            '
            Me.l_acadyear.BackColor = System.Drawing.Color.White
            '
            '
            '
            Me.l_acadyear.Border.Class = "TextBoxBorder"
            Me.l_acadyear.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.l_acadyear.DisabledBackColor = System.Drawing.Color.White
            Me.l_acadyear.ForeColor = System.Drawing.Color.Black
            Me.l_acadyear.Location = New System.Drawing.Point(229, 123)
            Me.l_acadyear.Name = "l_acadyear"
            Me.l_acadyear.PreventEnterBeep = True
            Me.l_acadyear.Size = New System.Drawing.Size(100, 22)
            Me.l_acadyear.TabIndex = 16
            '
            'LabelX23
            '
            Me.LabelX23.BackColor = System.Drawing.Color.Transparent
            '
            '
            '
            Me.LabelX23.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.LabelX23.ForeColor = System.Drawing.Color.Black
            Me.LabelX23.Location = New System.Drawing.Point(148, 151)
            Me.LabelX23.Name = "LabelX23"
            Me.LabelX23.Size = New System.Drawing.Size(75, 23)
            Me.LabelX23.TabIndex = 15
            Me.LabelX23.Text = "Semester:"
            '
            'l_yearlevel
            '
            Me.l_yearlevel.BackColor = System.Drawing.Color.White
            '
            '
            '
            Me.l_yearlevel.Border.Class = "TextBoxBorder"
            Me.l_yearlevel.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.l_yearlevel.DisabledBackColor = System.Drawing.Color.White
            Me.l_yearlevel.ForeColor = System.Drawing.Color.Black
            Me.l_yearlevel.Location = New System.Drawing.Point(281, 94)
            Me.l_yearlevel.Name = "l_yearlevel"
            Me.l_yearlevel.PreventEnterBeep = True
            Me.l_yearlevel.Size = New System.Drawing.Size(48, 22)
            Me.l_yearlevel.TabIndex = 14
            '
            'LabelX24
            '
            Me.LabelX24.BackColor = System.Drawing.Color.Transparent
            '
            '
            '
            Me.LabelX24.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.LabelX24.ForeColor = System.Drawing.Color.Black
            Me.LabelX24.Location = New System.Drawing.Point(148, 123)
            Me.LabelX24.Name = "LabelX24"
            Me.LabelX24.Size = New System.Drawing.Size(75, 23)
            Me.LabelX24.TabIndex = 13
            Me.LabelX24.Text = "Academic Yr:"
            '
            'l_course
            '
            Me.l_course.BackColor = System.Drawing.Color.White
            '
            '
            '
            Me.l_course.Border.Class = "TextBoxBorder"
            Me.l_course.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.l_course.DisabledBackColor = System.Drawing.Color.White
            Me.l_course.ForeColor = System.Drawing.Color.Black
            Me.l_course.Location = New System.Drawing.Point(229, 95)
            Me.l_course.Name = "l_course"
            Me.l_course.PreventEnterBeep = True
            Me.l_course.Size = New System.Drawing.Size(46, 22)
            Me.l_course.TabIndex = 12
            '
            'LabelX25
            '
            Me.LabelX25.BackColor = System.Drawing.Color.Transparent
            '
            '
            '
            Me.LabelX25.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.LabelX25.ForeColor = System.Drawing.Color.Black
            Me.LabelX25.Location = New System.Drawing.Point(148, 94)
            Me.LabelX25.Name = "LabelX25"
            Me.LabelX25.Size = New System.Drawing.Size(75, 23)
            Me.LabelX25.TabIndex = 11
            Me.LabelX25.Text = "Course / Year:"
            '
            'l_middlename
            '
            Me.l_middlename.BackColor = System.Drawing.Color.White
            '
            '
            '
            Me.l_middlename.Border.Class = "TextBoxBorder"
            Me.l_middlename.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.l_middlename.DisabledBackColor = System.Drawing.Color.White
            Me.l_middlename.ForeColor = System.Drawing.Color.Black
            Me.l_middlename.Location = New System.Drawing.Point(441, 66)
            Me.l_middlename.Name = "l_middlename"
            Me.l_middlename.PreventEnterBeep = True
            Me.l_middlename.Size = New System.Drawing.Size(100, 22)
            Me.l_middlename.TabIndex = 10
            '
            'l_fistname
            '
            Me.l_fistname.BackColor = System.Drawing.Color.White
            '
            '
            '
            Me.l_fistname.Border.Class = "TextBoxBorder"
            Me.l_fistname.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.l_fistname.DisabledBackColor = System.Drawing.Color.White
            Me.l_fistname.ForeColor = System.Drawing.Color.Black
            Me.l_fistname.Location = New System.Drawing.Point(335, 66)
            Me.l_fistname.Name = "l_fistname"
            Me.l_fistname.PreventEnterBeep = True
            Me.l_fistname.Size = New System.Drawing.Size(100, 22)
            Me.l_fistname.TabIndex = 9
            '
            'l_lastname
            '
            Me.l_lastname.BackColor = System.Drawing.Color.White
            '
            '
            '
            Me.l_lastname.Border.Class = "TextBoxBorder"
            Me.l_lastname.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.l_lastname.DisabledBackColor = System.Drawing.Color.White
            Me.l_lastname.ForeColor = System.Drawing.Color.Black
            Me.l_lastname.Location = New System.Drawing.Point(229, 67)
            Me.l_lastname.Name = "l_lastname"
            Me.l_lastname.PreventEnterBeep = True
            Me.l_lastname.Size = New System.Drawing.Size(100, 22)
            Me.l_lastname.TabIndex = 8
            '
            'LabelX26
            '
            Me.LabelX26.BackColor = System.Drawing.Color.Transparent
            '
            '
            '
            Me.LabelX26.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.LabelX26.ForeColor = System.Drawing.Color.Black
            Me.LabelX26.Location = New System.Drawing.Point(148, 37)
            Me.LabelX26.Name = "LabelX26"
            Me.LabelX26.Size = New System.Drawing.Size(75, 23)
            Me.LabelX26.TabIndex = 7
            Me.LabelX26.Text = "Student ID:"
            '
            'l_studid
            '
            Me.l_studid.BackColor = System.Drawing.Color.White
            '
            '
            '
            Me.l_studid.Border.Class = "TextBoxBorder"
            Me.l_studid.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.l_studid.DisabledBackColor = System.Drawing.Color.White
            Me.l_studid.ForeColor = System.Drawing.Color.Black
            Me.l_studid.Location = New System.Drawing.Point(229, 37)
            Me.l_studid.Name = "l_studid"
            Me.l_studid.PreventEnterBeep = True
            Me.l_studid.Size = New System.Drawing.Size(100, 22)
            Me.l_studid.TabIndex = 6
            '
            'LabelX27
            '
            Me.LabelX27.BackColor = System.Drawing.Color.Transparent
            '
            '
            '
            Me.LabelX27.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.LabelX27.ForeColor = System.Drawing.Color.Black
            Me.LabelX27.Location = New System.Drawing.Point(148, 66)
            Me.LabelX27.Name = "LabelX27"
            Me.LabelX27.Size = New System.Drawing.Size(75, 23)
            Me.LabelX27.TabIndex = 5
            Me.LabelX27.Text = "Name:"
            '
            'PictureBox3
            '
            Me.PictureBox3.BackColor = System.Drawing.Color.White
            Me.PictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
            Me.PictureBox3.ForeColor = System.Drawing.Color.Black
            Me.PictureBox3.Location = New System.Drawing.Point(12, 67)
            Me.PictureBox3.Name = "PictureBox3"
            Me.PictureBox3.Size = New System.Drawing.Size(130, 136)
            Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
            Me.PictureBox3.TabIndex = 4
            Me.PictureBox3.TabStop = False
            '
            'MetroToolbar4
            '
            Me.MetroToolbar4.BackColor = System.Drawing.Color.White
            '
            '
            '
            Me.MetroToolbar4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.MetroToolbar4.ContainerControlProcessDialogKey = True
            Me.MetroToolbar4.DragDropSupport = True
            Me.MetroToolbar4.ExpandDirection = DevComponents.DotNetBar.Metro.eExpandDirection.Top
            Me.MetroToolbar4.ExtraItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.deleteLibraryButton})
            Me.MetroToolbar4.ForeColor = System.Drawing.Color.Black
            Me.MetroToolbar4.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.searchLibraryButton, Me.addLibraryButton, Me.updateLibraryButton})
            Me.MetroToolbar4.LicenseKey = "F962CEC7-CD8F-4911-A9E9-CAB39962FC1F"
            Me.MetroToolbar4.Location = New System.Drawing.Point(286, 555)
            Me.MetroToolbar4.Name = "MetroToolbar4"
            Me.MetroToolbar4.Size = New System.Drawing.Size(388, 38)
            Me.MetroToolbar4.TabIndex = 23
            Me.MetroToolbar4.Text = "Invoices"
            '
            'deleteLibraryButton
            '
            Me.deleteLibraryButton.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
            Me.deleteLibraryButton.Image = Global.My.Resources.Resources.Delete1
            Me.deleteLibraryButton.ImageAlt = Global.My.Resources.Resources.DeleteWhite
            Me.deleteLibraryButton.Name = "deleteLibraryButton"
            Me.deleteLibraryButton.Text = "Delete Record"
            Me.deleteLibraryButton.Tooltip = "Delete Selected Record"
            '
            'searchLibraryButton
            '
            Me.searchLibraryButton.AutoExpandOnClick = True
            Me.searchLibraryButton.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
            Me.searchLibraryButton.Image = Global.My.Resources.Resources.search_ic_crop
            Me.searchLibraryButton.ImageAlt = Global.My.Resources.Resources.NewInvoiceWhite
            Me.searchLibraryButton.Name = "searchLibraryButton"
            Me.searchLibraryButton.PopupSide = DevComponents.DotNetBar.ePopupSide.Top
            Me.searchLibraryButton.PopupType = DevComponents.DotNetBar.ePopupType.ToolBar
            Me.searchLibraryButton.PopupWidth = 50
            Me.searchLibraryButton.Shape = New DevComponents.DotNetBar.RoundRectangleShapeDescriptor(2)
            Me.searchLibraryButton.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.searchLibraryTxt})
            Me.searchLibraryButton.Text = "Search Record"
            Me.searchLibraryButton.Tooltip = "Search"
            '
            'searchLibraryTxt
            '
            Me.searchLibraryTxt.FocusHighlightColor = System.Drawing.Color.YellowGreen
            Me.searchLibraryTxt.Name = "searchLibraryTxt"
            Me.searchLibraryTxt.Stretch = True
            Me.searchLibraryTxt.TextBoxWidth = 200
            Me.searchLibraryTxt.WatermarkColor = System.Drawing.SystemColors.GrayText
            '
            'addLibraryButton
            '
            Me.addLibraryButton.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
            Me.addLibraryButton.Image = Global.My.Resources.Resources.addnew_edit
            Me.addLibraryButton.ImageAlt = Global.My.Resources.Resources.BookNoteWhite
            Me.addLibraryButton.Name = "addLibraryButton"
            Me.addLibraryButton.PopupSide = DevComponents.DotNetBar.ePopupSide.Top
            Me.addLibraryButton.Text = "Add Record"
            Me.addLibraryButton.Tooltip = "Add new Record"
            '
            'updateLibraryButton
            '
            Me.updateLibraryButton.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
            Me.updateLibraryButton.Image = Global.My.Resources.Resources.edit_new_res
            Me.updateLibraryButton.ImageAlt = Global.My.Resources.Resources.PaperClipWhite
            Me.updateLibraryButton.Name = "updateLibraryButton"
            Me.updateLibraryButton.Text = "Update Record"
            Me.updateLibraryButton.Tooltip = "Update an existimg Record"
            '
            'LabelX3
            '
            Me.LabelX3.BackColor = System.Drawing.Color.White
            '
            '
            '
            Me.LabelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.LabelX3.Enabled = False
            Me.LabelX3.ForeColor = System.Drawing.Color.Black
            Me.LabelX3.Location = New System.Drawing.Point(57, 294)
            Me.LabelX3.Name = "LabelX3"
            Me.LabelX3.Size = New System.Drawing.Size(98, 23)
            Me.LabelX3.TabIndex = 22
            Me.LabelX3.Text = "LabelX3"
            Me.LabelX3.Visible = False
            '
            'ExpandableSplitter4
            '
            Me.ExpandableSplitter4.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer))
            Me.ExpandableSplitter4.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer))
            Me.ExpandableSplitter4.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
            Me.ExpandableSplitter4.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
            Me.ExpandableSplitter4.Dock = System.Windows.Forms.DockStyle.Top
            Me.ExpandableSplitter4.ExpandFillColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer))
            Me.ExpandableSplitter4.ExpandFillColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
            Me.ExpandableSplitter4.ExpandLineColor = System.Drawing.Color.Black
            Me.ExpandableSplitter4.ExpandLineColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText
            Me.ExpandableSplitter4.ForeColor = System.Drawing.Color.Black
            Me.ExpandableSplitter4.GripDarkColor = System.Drawing.Color.Black
            Me.ExpandableSplitter4.GripDarkColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText
            Me.ExpandableSplitter4.GripLightColor = System.Drawing.Color.White
            Me.ExpandableSplitter4.GripLightColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
            Me.ExpandableSplitter4.HotBackColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer))
            Me.ExpandableSplitter4.HotBackColor2 = System.Drawing.Color.Empty
            Me.ExpandableSplitter4.HotBackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemPressedBackground2
            Me.ExpandableSplitter4.HotBackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemPressedBackground
            Me.ExpandableSplitter4.HotExpandFillColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer))
            Me.ExpandableSplitter4.HotExpandFillColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
            Me.ExpandableSplitter4.HotExpandLineColor = System.Drawing.Color.Black
            Me.ExpandableSplitter4.HotExpandLineColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText
            Me.ExpandableSplitter4.HotGripDarkColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer))
            Me.ExpandableSplitter4.HotGripDarkColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
            Me.ExpandableSplitter4.HotGripLightColor = System.Drawing.Color.White
            Me.ExpandableSplitter4.HotGripLightColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
            Me.ExpandableSplitter4.Location = New System.Drawing.Point(3, 240)
            Me.ExpandableSplitter4.Name = "ExpandableSplitter4"
            Me.ExpandableSplitter4.Size = New System.Drawing.Size(905, 6)
            Me.ExpandableSplitter4.Style = DevComponents.DotNetBar.eSplitterStyle.Office2007
            Me.ExpandableSplitter4.TabIndex = 4
            Me.ExpandableSplitter4.TabStop = False
            '
            'ListViewEx4
            '
            Me.ListViewEx4.BackColor = System.Drawing.Color.White
            '
            '
            '
            Me.ListViewEx4.Border.Class = "ListViewBorder"
            Me.ListViewEx4.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.ListViewEx4.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader34, Me.ColumnHeader35, Me.ColumnHeader36, Me.ColumnHeader37, Me.ColumnHeader38, Me.ColumnHeader39, Me.ColumnHeader40, Me.ColumnHeader41, Me.ColumnHeader42, Me.ColumnHeader43, Me.ColumnHeader44, Me.ColumnHeader57, Me.ColumnHeader58, Me.ColumnHeader79})
            Me.ListViewEx4.DisabledBackColor = System.Drawing.Color.Empty
            Me.ListViewEx4.Dock = System.Windows.Forms.DockStyle.Top
            Me.ListViewEx4.ForeColor = System.Drawing.Color.Black
            Me.ListViewEx4.FullRowSelect = True
            Me.ListViewEx4.Location = New System.Drawing.Point(3, 0)
            Me.ListViewEx4.Name = "ListViewEx4"
            Me.ListViewEx4.Size = New System.Drawing.Size(905, 240)
            Me.ListViewEx4.TabIndex = 2
            Me.ListViewEx4.UseCompatibleStateImageBehavior = False
            Me.ListViewEx4.View = System.Windows.Forms.View.Details
            '
            'ColumnHeader34
            '
            Me.ColumnHeader34.Text = "ID"
            '
            'ColumnHeader35
            '
            Me.ColumnHeader35.Text = "Student Number"
            Me.ColumnHeader35.Width = 130
            '
            'ColumnHeader36
            '
            Me.ColumnHeader36.Text = "Lastname"
            Me.ColumnHeader36.Width = 130
            '
            'ColumnHeader37
            '
            Me.ColumnHeader37.Text = "Firstname"
            Me.ColumnHeader37.Width = 130
            '
            'ColumnHeader38
            '
            Me.ColumnHeader38.Text = "Middlename"
            Me.ColumnHeader38.Width = 130
            '
            'ColumnHeader39
            '
            Me.ColumnHeader39.Text = "Course"
            Me.ColumnHeader39.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            Me.ColumnHeader39.Width = 130
            '
            'ColumnHeader40
            '
            Me.ColumnHeader40.Text = "Year Level"
            Me.ColumnHeader40.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            Me.ColumnHeader40.Width = 130
            '
            'ColumnHeader41
            '
            Me.ColumnHeader41.Text = "Semester"
            Me.ColumnHeader41.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            Me.ColumnHeader41.Width = 130
            '
            'ColumnHeader42
            '
            Me.ColumnHeader42.Text = "S.Y"
            Me.ColumnHeader42.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            Me.ColumnHeader42.Width = 130
            '
            'ColumnHeader43
            '
            Me.ColumnHeader43.Text = "Contact"
            Me.ColumnHeader43.Width = 130
            '
            'ColumnHeader44
            '
            Me.ColumnHeader44.Text = "Unreturned Book(s)"
            Me.ColumnHeader44.Width = 130
            '
            'ColumnHeader57
            '
            Me.ColumnHeader57.Text = "Remaining Penalty"
            Me.ColumnHeader57.Width = 130
            '
            'ColumnHeader58
            '
            Me.ColumnHeader58.Text = "Status"
            Me.ColumnHeader58.Width = 130
            '
            'ColumnHeader79
            '
            Me.ColumnHeader79.Text = "Directory"
            Me.ColumnHeader79.Width = 130
            '
            'MetroTabPanel1
            '
            Me.MetroTabPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
            Me.MetroTabPanel1.Controls.Add(Me.ExpandableSplitter7)
            Me.MetroTabPanel1.Controls.Add(Me.ExpandablePanel1)
            Me.MetroTabPanel1.Controls.Add(Me.b_id_lbl)
            Me.MetroTabPanel1.Controls.Add(Me.MetroToolbar6)
            Me.MetroTabPanel1.Controls.Add(Me.ExpandableSplitter1)
            Me.MetroTabPanel1.Controls.Add(Me.ListViewEx1)
            Me.MetroTabPanel1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.MetroTabPanel1.Location = New System.Drawing.Point(0, 51)
            Me.MetroTabPanel1.Name = "MetroTabPanel1"
            Me.MetroTabPanel1.Padding = New System.Windows.Forms.Padding(3, 0, 3, 3)
            Me.MetroTabPanel1.Size = New System.Drawing.Size(911, 593)
            '
            '
            '
            Me.MetroTabPanel1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Square
            '
            '
            '
            Me.MetroTabPanel1.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
            '
            '
            '
            Me.MetroTabPanel1.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.MetroTabPanel1.TabIndex = 5
            Me.MetroTabPanel1.Visible = False
            '
            'ExpandableSplitter7
            '
            Me.ExpandableSplitter7.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer))
            Me.ExpandableSplitter7.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer))
            Me.ExpandableSplitter7.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
            Me.ExpandableSplitter7.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
            Me.ExpandableSplitter7.Dock = System.Windows.Forms.DockStyle.Top
            Me.ExpandableSplitter7.ExpandFillColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer))
            Me.ExpandableSplitter7.ExpandFillColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
            Me.ExpandableSplitter7.ExpandLineColor = System.Drawing.Color.Black
            Me.ExpandableSplitter7.ExpandLineColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText
            Me.ExpandableSplitter7.ForeColor = System.Drawing.Color.Black
            Me.ExpandableSplitter7.GripDarkColor = System.Drawing.Color.Black
            Me.ExpandableSplitter7.GripDarkColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText
            Me.ExpandableSplitter7.GripLightColor = System.Drawing.Color.White
            Me.ExpandableSplitter7.GripLightColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
            Me.ExpandableSplitter7.HotBackColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer))
            Me.ExpandableSplitter7.HotBackColor2 = System.Drawing.Color.Empty
            Me.ExpandableSplitter7.HotBackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemPressedBackground2
            Me.ExpandableSplitter7.HotBackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemPressedBackground
            Me.ExpandableSplitter7.HotExpandFillColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer))
            Me.ExpandableSplitter7.HotExpandFillColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
            Me.ExpandableSplitter7.HotExpandLineColor = System.Drawing.Color.Black
            Me.ExpandableSplitter7.HotExpandLineColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText
            Me.ExpandableSplitter7.HotGripDarkColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer))
            Me.ExpandableSplitter7.HotGripDarkColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
            Me.ExpandableSplitter7.HotGripLightColor = System.Drawing.Color.White
            Me.ExpandableSplitter7.HotGripLightColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
            Me.ExpandableSplitter7.Location = New System.Drawing.Point(3, 491)
            Me.ExpandableSplitter7.Name = "ExpandableSplitter7"
            Me.ExpandableSplitter7.Size = New System.Drawing.Size(905, 10)
            Me.ExpandableSplitter7.Style = DevComponents.DotNetBar.eSplitterStyle.Office2007
            Me.ExpandableSplitter7.TabIndex = 46
            Me.ExpandableSplitter7.TabStop = False
            '
            'ExpandablePanel1
            '
            Me.ExpandablePanel1.CanvasColor = System.Drawing.SystemColors.Window
            Me.ExpandablePanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
            Me.ExpandablePanel1.Controls.Add(Me.lbl_fullname)
            Me.ExpandablePanel1.Controls.Add(Me.prev_idLbl)
            Me.ExpandablePanel1.Controls.Add(Me.ButtonX1)
            Me.ExpandablePanel1.Controls.Add(Me.si_photo_path_txt)
            Me.ExpandablePanel1.Controls.Add(Me.si_photo)
            Me.ExpandablePanel1.Controls.Add(Me.si_id_txt)
            Me.ExpandablePanel1.Controls.Add(Me.LabelX13)
            Me.ExpandablePanel1.Controls.Add(Me.si_contact_txt)
            Me.ExpandablePanel1.Controls.Add(Me.si_contact)
            Me.ExpandablePanel1.Controls.Add(Me.si_semester_txt)
            Me.ExpandablePanel1.Controls.Add(Me.si_acadyear_txt)
            Me.ExpandablePanel1.Controls.Add(Me.si_semester)
            Me.ExpandablePanel1.Controls.Add(Me.si_yr_txt)
            Me.ExpandablePanel1.Controls.Add(Me.si_acad_yr)
            Me.ExpandablePanel1.Controls.Add(Me.si_course_txt)
            Me.ExpandablePanel1.Controls.Add(Me.si_course_yr)
            Me.ExpandablePanel1.Controls.Add(Me.si_Mname_txt)
            Me.ExpandablePanel1.Controls.Add(Me.si_Fname_txt)
            Me.ExpandablePanel1.Controls.Add(Me.si_Lname_txt)
            Me.ExpandablePanel1.Controls.Add(Me.si_stud_id)
            Me.ExpandablePanel1.Controls.Add(Me.si_stud_id_txt)
            Me.ExpandablePanel1.Controls.Add(Me.si_name)
            Me.ExpandablePanel1.Controls.Add(Me.PictureBox1)
            Me.ExpandablePanel1.DisabledBackColor = System.Drawing.Color.Empty
            Me.ExpandablePanel1.Dock = System.Windows.Forms.DockStyle.Top
            Me.ExpandablePanel1.HideControlsWhenCollapsed = True
            Me.ExpandablePanel1.Location = New System.Drawing.Point(3, 246)
            Me.ExpandablePanel1.Name = "ExpandablePanel1"
            Me.ExpandablePanel1.Size = New System.Drawing.Size(905, 245)
            Me.ExpandablePanel1.Style.Alignment = System.Drawing.StringAlignment.Center
            Me.ExpandablePanel1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
            Me.ExpandablePanel1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
            Me.ExpandablePanel1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText
            Me.ExpandablePanel1.Style.GradientAngle = 90
            Me.ExpandablePanel1.TabIndex = 42
            Me.ExpandablePanel1.TitleStyle.Alignment = System.Drawing.StringAlignment.Center
            Me.ExpandablePanel1.TitleStyle.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
            Me.ExpandablePanel1.TitleStyle.Border = DevComponents.DotNetBar.eBorderType.RaisedInner
            Me.ExpandablePanel1.TitleStyle.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
            Me.ExpandablePanel1.TitleStyle.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
            Me.ExpandablePanel1.TitleStyle.GradientAngle = 90
            Me.ExpandablePanel1.TitleText = "Student Information"
            '
            'lbl_fullname
            '
            Me.lbl_fullname.BackColor = System.Drawing.Color.White
            '
            '
            '
            Me.lbl_fullname.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.lbl_fullname.ForeColor = System.Drawing.Color.Black
            Me.lbl_fullname.Location = New System.Drawing.Point(415, 111)
            Me.lbl_fullname.Name = "lbl_fullname"
            Me.lbl_fullname.Size = New System.Drawing.Size(237, 23)
            Me.lbl_fullname.TabIndex = 26
            Me.lbl_fullname.Text = "LabelX7"
            Me.lbl_fullname.Visible = False
            '
            'prev_idLbl
            '
            Me.prev_idLbl.BackColor = System.Drawing.Color.White
            '
            '
            '
            Me.prev_idLbl.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.prev_idLbl.ForeColor = System.Drawing.Color.Black
            Me.prev_idLbl.Location = New System.Drawing.Point(335, 37)
            Me.prev_idLbl.Name = "prev_idLbl"
            Me.prev_idLbl.Size = New System.Drawing.Size(75, 23)
            Me.prev_idLbl.TabIndex = 25
            Me.prev_idLbl.Text = "LabelX7"
            Me.prev_idLbl.Visible = False
            '
            'ButtonX1
            '
            Me.ButtonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
            Me.ButtonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
            Me.ButtonX1.Location = New System.Drawing.Point(12, 206)
            Me.ButtonX1.Name = "ButtonX1"
            Me.ButtonX1.Size = New System.Drawing.Size(130, 23)
            Me.ButtonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
            Me.ButtonX1.TabIndex = 24
            Me.ButtonX1.Text = "Upload"
            '
            'si_photo_path_txt
            '
            Me.si_photo_path_txt.BackColor = System.Drawing.Color.White
            '
            '
            '
            Me.si_photo_path_txt.Border.Class = "TextBoxBorder"
            Me.si_photo_path_txt.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.si_photo_path_txt.DisabledBackColor = System.Drawing.Color.White
            Me.si_photo_path_txt.ForeColor = System.Drawing.Color.Black
            Me.si_photo_path_txt.Location = New System.Drawing.Point(229, 206)
            Me.si_photo_path_txt.Name = "si_photo_path_txt"
            Me.si_photo_path_txt.PreventEnterBeep = True
            Me.si_photo_path_txt.Size = New System.Drawing.Size(312, 22)
            Me.si_photo_path_txt.TabIndex = 23
            '
            'si_photo
            '
            Me.si_photo.BackColor = System.Drawing.Color.Transparent
            '
            '
            '
            Me.si_photo.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.si_photo.ForeColor = System.Drawing.Color.Black
            Me.si_photo.Location = New System.Drawing.Point(148, 206)
            Me.si_photo.Name = "si_photo"
            Me.si_photo.Size = New System.Drawing.Size(75, 23)
            Me.si_photo.TabIndex = 22
            Me.si_photo.Text = "Directory:"
            '
            'si_id_txt
            '
            Me.si_id_txt.BackColor = System.Drawing.Color.White
            '
            '
            '
            Me.si_id_txt.Border.Class = "TextBoxBorder"
            Me.si_id_txt.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.si_id_txt.DisabledBackColor = System.Drawing.Color.White
            Me.si_id_txt.Enabled = False
            Me.si_id_txt.ForeColor = System.Drawing.Color.Black
            Me.si_id_txt.Location = New System.Drawing.Point(34, 37)
            Me.si_id_txt.Name = "si_id_txt"
            Me.si_id_txt.PreventEnterBeep = True
            Me.si_id_txt.Size = New System.Drawing.Size(25, 22)
            Me.si_id_txt.TabIndex = 21
            '
            'LabelX13
            '
            Me.LabelX13.BackColor = System.Drawing.Color.Transparent
            '
            '
            '
            Me.LabelX13.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.LabelX13.ForeColor = System.Drawing.Color.Black
            Me.LabelX13.Location = New System.Drawing.Point(8, 36)
            Me.LabelX13.Name = "LabelX13"
            Me.LabelX13.Size = New System.Drawing.Size(20, 23)
            Me.LabelX13.TabIndex = 20
            Me.LabelX13.Text = "ID:"
            '
            'si_contact_txt
            '
            Me.si_contact_txt.BackColor = System.Drawing.Color.White
            '
            '
            '
            Me.si_contact_txt.Border.Class = "TextBoxBorder"
            Me.si_contact_txt.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.si_contact_txt.DisabledBackColor = System.Drawing.Color.White
            Me.si_contact_txt.ForeColor = System.Drawing.Color.Black
            Me.si_contact_txt.Location = New System.Drawing.Point(229, 179)
            Me.si_contact_txt.Name = "si_contact_txt"
            Me.si_contact_txt.PreventEnterBeep = True
            Me.si_contact_txt.Size = New System.Drawing.Size(100, 22)
            Me.si_contact_txt.TabIndex = 19
            '
            'si_contact
            '
            Me.si_contact.BackColor = System.Drawing.Color.Transparent
            '
            '
            '
            Me.si_contact.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.si_contact.ForeColor = System.Drawing.Color.Black
            Me.si_contact.Location = New System.Drawing.Point(148, 179)
            Me.si_contact.Name = "si_contact"
            Me.si_contact.Size = New System.Drawing.Size(75, 23)
            Me.si_contact.TabIndex = 18
            Me.si_contact.Text = "Contact #:"
            '
            'si_semester_txt
            '
            Me.si_semester_txt.BackColor = System.Drawing.Color.White
            '
            '
            '
            Me.si_semester_txt.Border.Class = "TextBoxBorder"
            Me.si_semester_txt.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.si_semester_txt.DisabledBackColor = System.Drawing.Color.White
            Me.si_semester_txt.ForeColor = System.Drawing.Color.Black
            Me.si_semester_txt.Location = New System.Drawing.Point(229, 151)
            Me.si_semester_txt.Name = "si_semester_txt"
            Me.si_semester_txt.PreventEnterBeep = True
            Me.si_semester_txt.Size = New System.Drawing.Size(100, 22)
            Me.si_semester_txt.TabIndex = 17
            '
            'si_acadyear_txt
            '
            Me.si_acadyear_txt.BackColor = System.Drawing.Color.White
            '
            '
            '
            Me.si_acadyear_txt.Border.Class = "TextBoxBorder"
            Me.si_acadyear_txt.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.si_acadyear_txt.DisabledBackColor = System.Drawing.Color.White
            Me.si_acadyear_txt.ForeColor = System.Drawing.Color.Black
            Me.si_acadyear_txt.Location = New System.Drawing.Point(229, 123)
            Me.si_acadyear_txt.Name = "si_acadyear_txt"
            Me.si_acadyear_txt.PreventEnterBeep = True
            Me.si_acadyear_txt.Size = New System.Drawing.Size(100, 22)
            Me.si_acadyear_txt.TabIndex = 16
            '
            'si_semester
            '
            Me.si_semester.BackColor = System.Drawing.Color.Transparent
            '
            '
            '
            Me.si_semester.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.si_semester.ForeColor = System.Drawing.Color.Black
            Me.si_semester.Location = New System.Drawing.Point(148, 151)
            Me.si_semester.Name = "si_semester"
            Me.si_semester.Size = New System.Drawing.Size(75, 23)
            Me.si_semester.TabIndex = 15
            Me.si_semester.Text = "Semester:"
            '
            'si_yr_txt
            '
            Me.si_yr_txt.BackColor = System.Drawing.Color.White
            '
            '
            '
            Me.si_yr_txt.Border.Class = "TextBoxBorder"
            Me.si_yr_txt.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.si_yr_txt.DisabledBackColor = System.Drawing.Color.White
            Me.si_yr_txt.ForeColor = System.Drawing.Color.Black
            Me.si_yr_txt.Location = New System.Drawing.Point(281, 94)
            Me.si_yr_txt.Name = "si_yr_txt"
            Me.si_yr_txt.PreventEnterBeep = True
            Me.si_yr_txt.Size = New System.Drawing.Size(48, 22)
            Me.si_yr_txt.TabIndex = 14
            '
            'si_acad_yr
            '
            Me.si_acad_yr.BackColor = System.Drawing.Color.Transparent
            '
            '
            '
            Me.si_acad_yr.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.si_acad_yr.ForeColor = System.Drawing.Color.Black
            Me.si_acad_yr.Location = New System.Drawing.Point(148, 123)
            Me.si_acad_yr.Name = "si_acad_yr"
            Me.si_acad_yr.Size = New System.Drawing.Size(75, 23)
            Me.si_acad_yr.TabIndex = 13
            Me.si_acad_yr.Text = "Academic Yr:"
            '
            'si_course_txt
            '
            Me.si_course_txt.BackColor = System.Drawing.Color.White
            '
            '
            '
            Me.si_course_txt.Border.Class = "TextBoxBorder"
            Me.si_course_txt.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.si_course_txt.DisabledBackColor = System.Drawing.Color.White
            Me.si_course_txt.ForeColor = System.Drawing.Color.Black
            Me.si_course_txt.Location = New System.Drawing.Point(229, 95)
            Me.si_course_txt.Name = "si_course_txt"
            Me.si_course_txt.PreventEnterBeep = True
            Me.si_course_txt.Size = New System.Drawing.Size(46, 22)
            Me.si_course_txt.TabIndex = 12
            '
            'si_course_yr
            '
            Me.si_course_yr.BackColor = System.Drawing.Color.Transparent
            '
            '
            '
            Me.si_course_yr.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.si_course_yr.ForeColor = System.Drawing.Color.Black
            Me.si_course_yr.Location = New System.Drawing.Point(148, 94)
            Me.si_course_yr.Name = "si_course_yr"
            Me.si_course_yr.Size = New System.Drawing.Size(75, 23)
            Me.si_course_yr.TabIndex = 11
            Me.si_course_yr.Text = "Course / Year:"
            '
            'si_Mname_txt
            '
            Me.si_Mname_txt.BackColor = System.Drawing.Color.White
            '
            '
            '
            Me.si_Mname_txt.Border.Class = "TextBoxBorder"
            Me.si_Mname_txt.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.si_Mname_txt.DisabledBackColor = System.Drawing.Color.White
            Me.si_Mname_txt.ForeColor = System.Drawing.Color.Black
            Me.si_Mname_txt.Location = New System.Drawing.Point(441, 66)
            Me.si_Mname_txt.Name = "si_Mname_txt"
            Me.si_Mname_txt.PreventEnterBeep = True
            Me.si_Mname_txt.Size = New System.Drawing.Size(100, 22)
            Me.si_Mname_txt.TabIndex = 10
            '
            'si_Fname_txt
            '
            Me.si_Fname_txt.BackColor = System.Drawing.Color.White
            '
            '
            '
            Me.si_Fname_txt.Border.Class = "TextBoxBorder"
            Me.si_Fname_txt.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.si_Fname_txt.DisabledBackColor = System.Drawing.Color.White
            Me.si_Fname_txt.ForeColor = System.Drawing.Color.Black
            Me.si_Fname_txt.Location = New System.Drawing.Point(335, 66)
            Me.si_Fname_txt.Name = "si_Fname_txt"
            Me.si_Fname_txt.PreventEnterBeep = True
            Me.si_Fname_txt.Size = New System.Drawing.Size(100, 22)
            Me.si_Fname_txt.TabIndex = 9
            '
            'si_Lname_txt
            '
            Me.si_Lname_txt.BackColor = System.Drawing.Color.White
            '
            '
            '
            Me.si_Lname_txt.Border.Class = "TextBoxBorder"
            Me.si_Lname_txt.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.si_Lname_txt.DisabledBackColor = System.Drawing.Color.White
            Me.si_Lname_txt.ForeColor = System.Drawing.Color.Black
            Me.si_Lname_txt.Location = New System.Drawing.Point(229, 67)
            Me.si_Lname_txt.Name = "si_Lname_txt"
            Me.si_Lname_txt.PreventEnterBeep = True
            Me.si_Lname_txt.Size = New System.Drawing.Size(100, 22)
            Me.si_Lname_txt.TabIndex = 8
            '
            'si_stud_id
            '
            Me.si_stud_id.BackColor = System.Drawing.Color.Transparent
            '
            '
            '
            Me.si_stud_id.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.si_stud_id.ForeColor = System.Drawing.Color.Black
            Me.si_stud_id.Location = New System.Drawing.Point(148, 37)
            Me.si_stud_id.Name = "si_stud_id"
            Me.si_stud_id.Size = New System.Drawing.Size(75, 23)
            Me.si_stud_id.TabIndex = 7
            Me.si_stud_id.Text = "Student ID:"
            '
            'si_stud_id_txt
            '
            Me.si_stud_id_txt.BackColor = System.Drawing.Color.White
            '
            '
            '
            Me.si_stud_id_txt.Border.Class = "TextBoxBorder"
            Me.si_stud_id_txt.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.si_stud_id_txt.DisabledBackColor = System.Drawing.Color.White
            Me.si_stud_id_txt.ForeColor = System.Drawing.Color.Black
            Me.si_stud_id_txt.Location = New System.Drawing.Point(229, 37)
            Me.si_stud_id_txt.Name = "si_stud_id_txt"
            Me.si_stud_id_txt.PreventEnterBeep = True
            Me.si_stud_id_txt.Size = New System.Drawing.Size(100, 22)
            Me.si_stud_id_txt.TabIndex = 6
            '
            'si_name
            '
            Me.si_name.BackColor = System.Drawing.Color.Transparent
            '
            '
            '
            Me.si_name.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.si_name.ForeColor = System.Drawing.Color.Black
            Me.si_name.Location = New System.Drawing.Point(148, 66)
            Me.si_name.Name = "si_name"
            Me.si_name.Size = New System.Drawing.Size(75, 23)
            Me.si_name.TabIndex = 5
            Me.si_name.Text = "Name:"
            '
            'PictureBox1
            '
            Me.PictureBox1.BackColor = System.Drawing.Color.White
            Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
            Me.PictureBox1.ForeColor = System.Drawing.Color.Black
            Me.PictureBox1.Location = New System.Drawing.Point(12, 67)
            Me.PictureBox1.Name = "PictureBox1"
            Me.PictureBox1.Size = New System.Drawing.Size(130, 136)
            Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
            Me.PictureBox1.TabIndex = 4
            Me.PictureBox1.TabStop = False
            '
            'b_id_lbl
            '
            Me.b_id_lbl.BackColor = System.Drawing.Color.White
            '
            '
            '
            Me.b_id_lbl.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.b_id_lbl.Enabled = False
            Me.b_id_lbl.ForeColor = System.Drawing.Color.Black
            Me.b_id_lbl.Location = New System.Drawing.Point(81, 249)
            Me.b_id_lbl.Name = "b_id_lbl"
            Me.b_id_lbl.Size = New System.Drawing.Size(51, 38)
            Me.b_id_lbl.TabIndex = 21
            Me.b_id_lbl.Text = "LabelX1"
            Me.b_id_lbl.Visible = False
            '
            'MetroToolbar6
            '
            Me.MetroToolbar6.BackColor = System.Drawing.Color.White
            '
            '
            '
            Me.MetroToolbar6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.MetroToolbar6.ContainerControlProcessDialogKey = True
            Me.MetroToolbar6.DragDropSupport = True
            Me.MetroToolbar6.ExpandDirection = DevComponents.DotNetBar.Metro.eExpandDirection.Top
            Me.MetroToolbar6.ExtraItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.deleteRegistrarButton})
            Me.MetroToolbar6.ForeColor = System.Drawing.Color.Black
            Me.MetroToolbar6.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.searchRegistrarButton, Me.addRegistrarButton, Me.updateRegistrarButton})
            Me.MetroToolbar6.LicenseKey = "F962CEC7-CD8F-4911-A9E9-CAB39962FC1F"
            Me.MetroToolbar6.Location = New System.Drawing.Point(289, 549)
            Me.MetroToolbar6.Name = "MetroToolbar6"
            Me.MetroToolbar6.Size = New System.Drawing.Size(388, 38)
            Me.MetroToolbar6.TabIndex = 20
            Me.MetroToolbar6.Text = "Invoices"
            '
            'deleteRegistrarButton
            '
            Me.deleteRegistrarButton.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
            Me.deleteRegistrarButton.Image = Global.My.Resources.Resources.Delete1
            Me.deleteRegistrarButton.ImageAlt = Global.My.Resources.Resources.DeleteWhite
            Me.deleteRegistrarButton.Name = "deleteRegistrarButton"
            Me.deleteRegistrarButton.Text = "Delete Record"
            Me.deleteRegistrarButton.Tooltip = "Delete Selected Record"
            '
            'searchRegistrarButton
            '
            Me.searchRegistrarButton.AutoExpandOnClick = True
            Me.searchRegistrarButton.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
            Me.searchRegistrarButton.Image = Global.My.Resources.Resources.search_ic_crop
            Me.searchRegistrarButton.ImageAlt = Global.My.Resources.Resources.NewInvoiceWhite
            Me.searchRegistrarButton.Name = "searchRegistrarButton"
            Me.searchRegistrarButton.PopupSide = DevComponents.DotNetBar.ePopupSide.Top
            Me.searchRegistrarButton.PopupType = DevComponents.DotNetBar.ePopupType.ToolBar
            Me.searchRegistrarButton.PopupWidth = 50
            Me.searchRegistrarButton.Shape = New DevComponents.DotNetBar.RoundRectangleShapeDescriptor(2)
            Me.searchRegistrarButton.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.searchRegistrarTxt})
            Me.searchRegistrarButton.Text = "Search Record"
            Me.searchRegistrarButton.Tooltip = "Search"
            '
            'searchRegistrarTxt
            '
            Me.searchRegistrarTxt.FocusHighlightColor = System.Drawing.Color.YellowGreen
            Me.searchRegistrarTxt.Name = "searchRegistrarTxt"
            Me.searchRegistrarTxt.Stretch = True
            Me.searchRegistrarTxt.TextBoxWidth = 200
            Me.searchRegistrarTxt.WatermarkColor = System.Drawing.SystemColors.GrayText
            '
            'addRegistrarButton
            '
            Me.addRegistrarButton.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
            Me.addRegistrarButton.Image = Global.My.Resources.Resources.addnew_edit
            Me.addRegistrarButton.ImageAlt = Global.My.Resources.Resources.BookNoteWhite
            Me.addRegistrarButton.Name = "addRegistrarButton"
            Me.addRegistrarButton.PopupSide = DevComponents.DotNetBar.ePopupSide.Top
            Me.addRegistrarButton.Text = "Add Record"
            Me.addRegistrarButton.Tooltip = "Add new Record"
            '
            'updateRegistrarButton
            '
            Me.updateRegistrarButton.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
            Me.updateRegistrarButton.Image = Global.My.Resources.Resources.edit_new_res
            Me.updateRegistrarButton.ImageAlt = Global.My.Resources.Resources.PaperClipWhite
            Me.updateRegistrarButton.Name = "updateRegistrarButton"
            Me.updateRegistrarButton.Text = "Update Record"
            Me.updateRegistrarButton.Tooltip = "Update an existimg Record"
            '
            'ExpandableSplitter1
            '
            Me.ExpandableSplitter1.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer))
            Me.ExpandableSplitter1.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer))
            Me.ExpandableSplitter1.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
            Me.ExpandableSplitter1.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
            Me.ExpandableSplitter1.Dock = System.Windows.Forms.DockStyle.Top
            Me.ExpandableSplitter1.ExpandFillColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer))
            Me.ExpandableSplitter1.ExpandFillColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
            Me.ExpandableSplitter1.ExpandLineColor = System.Drawing.Color.Black
            Me.ExpandableSplitter1.ExpandLineColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText
            Me.ExpandableSplitter1.ForeColor = System.Drawing.Color.Black
            Me.ExpandableSplitter1.GripDarkColor = System.Drawing.Color.Black
            Me.ExpandableSplitter1.GripDarkColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText
            Me.ExpandableSplitter1.GripLightColor = System.Drawing.Color.White
            Me.ExpandableSplitter1.GripLightColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
            Me.ExpandableSplitter1.HotBackColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer))
            Me.ExpandableSplitter1.HotBackColor2 = System.Drawing.Color.Empty
            Me.ExpandableSplitter1.HotBackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemPressedBackground2
            Me.ExpandableSplitter1.HotBackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemPressedBackground
            Me.ExpandableSplitter1.HotExpandFillColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer))
            Me.ExpandableSplitter1.HotExpandFillColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
            Me.ExpandableSplitter1.HotExpandLineColor = System.Drawing.Color.Black
            Me.ExpandableSplitter1.HotExpandLineColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText
            Me.ExpandableSplitter1.HotGripDarkColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer))
            Me.ExpandableSplitter1.HotGripDarkColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
            Me.ExpandableSplitter1.HotGripLightColor = System.Drawing.Color.White
            Me.ExpandableSplitter1.HotGripLightColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
            Me.ExpandableSplitter1.Location = New System.Drawing.Point(3, 240)
            Me.ExpandableSplitter1.Name = "ExpandableSplitter1"
            Me.ExpandableSplitter1.Size = New System.Drawing.Size(905, 6)
            Me.ExpandableSplitter1.Style = DevComponents.DotNetBar.eSplitterStyle.Office2007
            Me.ExpandableSplitter1.TabIndex = 3
            Me.ExpandableSplitter1.TabStop = False
            '
            'ListViewEx1
            '
            Me.ListViewEx1.BackColor = System.Drawing.Color.White
            '
            '
            '
            Me.ListViewEx1.Border.Class = "ListViewBorder"
            Me.ListViewEx1.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.ListViewEx1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader7, Me.ColumnHeader8, Me.ColumnHeader9, Me.ColumnHeader10, Me.ColumnHeader72})
            Me.ListViewEx1.DisabledBackColor = System.Drawing.Color.Empty
            Me.ListViewEx1.Dock = System.Windows.Forms.DockStyle.Top
            Me.ListViewEx1.ForeColor = System.Drawing.Color.Black
            Me.ListViewEx1.FullRowSelect = True
            Me.ListViewEx1.Location = New System.Drawing.Point(3, 0)
            Me.ListViewEx1.Name = "ListViewEx1"
            Me.ListViewEx1.Size = New System.Drawing.Size(905, 240)
            Me.ListViewEx1.TabIndex = 1
            Me.ListViewEx1.UseCompatibleStateImageBehavior = False
            Me.ListViewEx1.View = System.Windows.Forms.View.Details
            '
            'ColumnHeader1
            '
            Me.ColumnHeader1.Text = "ID"
            '
            'ColumnHeader2
            '
            Me.ColumnHeader2.Text = "Student Number"
            Me.ColumnHeader2.Width = 130
            '
            'ColumnHeader3
            '
            Me.ColumnHeader3.Text = "Lastname"
            Me.ColumnHeader3.Width = 130
            '
            'ColumnHeader4
            '
            Me.ColumnHeader4.Text = "Firstname"
            Me.ColumnHeader4.Width = 130
            '
            'ColumnHeader5
            '
            Me.ColumnHeader5.Text = "Middlename"
            Me.ColumnHeader5.Width = 130
            '
            'ColumnHeader6
            '
            Me.ColumnHeader6.Text = "Course"
            Me.ColumnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            Me.ColumnHeader6.Width = 130
            '
            'ColumnHeader7
            '
            Me.ColumnHeader7.Text = "Year Level"
            Me.ColumnHeader7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            Me.ColumnHeader7.Width = 130
            '
            'ColumnHeader8
            '
            Me.ColumnHeader8.Text = "Semester"
            Me.ColumnHeader8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            Me.ColumnHeader8.Width = 130
            '
            'ColumnHeader9
            '
            Me.ColumnHeader9.Text = "S.Y"
            Me.ColumnHeader9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            Me.ColumnHeader9.Width = 130
            '
            'ColumnHeader10
            '
            Me.ColumnHeader10.Text = "Contact"
            Me.ColumnHeader10.Width = 130
            '
            'ColumnHeader72
            '
            Me.ColumnHeader72.Text = "Directory"
            Me.ColumnHeader72.Width = 130
            '
            'metroAppButton1
            '
            Me.metroAppButton1.AutoExpandOnClick = True
            Me.metroAppButton1.BackstageTab = Me.superTabControl1
            Me.metroAppButton1.CanCustomize = False
            Me.metroAppButton1.ImageFixedSize = New System.Drawing.Size(16, 16)
            Me.metroAppButton1.ImagePaddingHorizontal = 0
            Me.metroAppButton1.ImagePaddingVertical = 0
            Me.metroAppButton1.Name = "metroAppButton1"
            Me.metroAppButton1.ShowSubItems = False
            Me.metroAppButton1.Text = "&File"
            '
            'superTabControl1
            '
            Me.superTabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                        Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.superTabControl1.BackColor = System.Drawing.Color.White
            '
            '
            '
            '
            '
            '
            Me.superTabControl1.ControlBox.CloseBox.Name = ""
            '
            '
            '
            Me.superTabControl1.ControlBox.MenuBox.Name = ""
            Me.superTabControl1.ControlBox.Name = ""
            Me.superTabControl1.ControlBox.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.superTabControl1.ControlBox.MenuBox, Me.superTabControl1.ControlBox.CloseBox})
            Me.superTabControl1.ControlBox.Visible = False
            Me.superTabControl1.Controls.Add(Me.superTabControlPanel1)
            Me.superTabControl1.Controls.Add(Me.superTabControlPanel3)
            Me.superTabControl1.Controls.Add(Me.superTabControlPanel4)
            Me.superTabControl1.Controls.Add(Me.superTabControlPanel2)
            Me.superTabControl1.ForeColor = System.Drawing.Color.Black
            Me.superTabControl1.ItemPadding.Left = 6
            Me.superTabControl1.ItemPadding.Right = 4
            Me.superTabControl1.ItemPadding.Top = 4
            Me.superTabControl1.Location = New System.Drawing.Point(0, 52)
            Me.superTabControl1.Name = "superTabControl1"
            Me.superTabControl1.ReorderTabsEnabled = False
            Me.superTabControl1.SelectedTabFont = New System.Drawing.Font("Segoe UI", 9.75!)
            Me.superTabControl1.SelectedTabIndex = 3
            Me.superTabControl1.Size = New System.Drawing.Size(912, 615)
            Me.superTabControl1.TabAlignment = DevComponents.DotNetBar.eTabStripAlignment.Left
            Me.superTabControl1.TabFont = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.superTabControl1.TabHorizontalSpacing = 16
            Me.superTabControl1.TabIndex = 2
            Me.superTabControl1.Tabs.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.buttonItem2, Me.buttonItem3, Me.buttonItem4, Me.superTabItem1, Me.superTabItem2, Me.superTabItem3, Me.superTabItem4, Me.buttonItem5, Me.buttonItem6})
            Me.superTabControl1.TabStyle = DevComponents.DotNetBar.eSuperTabStyle.Office2010BackstageBlue
            Me.superTabControl1.TabVerticalSpacing = 8
            '
            'superTabControlPanel1
            '
            Me.superTabControlPanel1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.superTabControlPanel1.Location = New System.Drawing.Point(236, 0)
            Me.superTabControlPanel1.Name = "superTabControlPanel1"
            Me.superTabControlPanel1.Size = New System.Drawing.Size(676, 615)
            Me.superTabControlPanel1.TabIndex = 1
            Me.superTabControlPanel1.TabItem = Me.superTabItem1
            '
            'superTabItem1
            '
            Me.superTabItem1.AttachedControl = Me.superTabControlPanel1
            Me.superTabItem1.GlobalItem = False
            Me.superTabItem1.KeyTips = "R"
            Me.superTabItem1.Name = "superTabItem1"
            Me.superTabItem1.Text = "Recent"
            '
            'superTabControlPanel3
            '
            Me.superTabControlPanel3.Dock = System.Windows.Forms.DockStyle.Fill
            Me.superTabControlPanel3.Location = New System.Drawing.Point(236, 0)
            Me.superTabControlPanel3.Name = "superTabControlPanel3"
            Me.superTabControlPanel3.Size = New System.Drawing.Size(676, 615)
            Me.superTabControlPanel3.TabIndex = 3
            Me.superTabControlPanel3.TabItem = Me.superTabItem3
            '
            'superTabItem3
            '
            Me.superTabItem3.AttachedControl = Me.superTabControlPanel3
            Me.superTabItem3.GlobalItem = False
            Me.superTabItem3.KeyTips = "P"
            Me.superTabItem3.Name = "superTabItem3"
            Me.superTabItem3.Text = "Print"
            '
            'superTabControlPanel4
            '
            Me.superTabControlPanel4.BackgroundImagePosition = DevComponents.DotNetBar.eStyleBackgroundImage.BottomRight
            Me.superTabControlPanel4.Dock = System.Windows.Forms.DockStyle.Fill
            Me.superTabControlPanel4.Location = New System.Drawing.Point(236, 0)
            Me.superTabControlPanel4.Name = "superTabControlPanel4"
            Me.superTabControlPanel4.Size = New System.Drawing.Size(676, 615)
            Me.superTabControlPanel4.TabIndex = 4
            Me.superTabControlPanel4.TabItem = Me.superTabItem4
            '
            'superTabItem4
            '
            Me.superTabItem4.AttachedControl = Me.superTabControlPanel4
            Me.superTabItem4.GlobalItem = False
            Me.superTabItem4.KeyTips = "H"
            Me.superTabItem4.Name = "superTabItem4"
            Me.superTabItem4.Text = "Help"
            '
            'superTabControlPanel2
            '
            Me.superTabControlPanel2.Dock = System.Windows.Forms.DockStyle.Fill
            Me.superTabControlPanel2.Location = New System.Drawing.Point(236, 0)
            Me.superTabControlPanel2.Name = "superTabControlPanel2"
            Me.superTabControlPanel2.Size = New System.Drawing.Size(676, 615)
            Me.superTabControlPanel2.TabIndex = 2
            Me.superTabControlPanel2.TabItem = Me.superTabItem2
            '
            'superTabItem2
            '
            Me.superTabItem2.AttachedControl = Me.superTabControlPanel2
            Me.superTabItem2.GlobalItem = False
            Me.superTabItem2.KeyTips = "N"
            Me.superTabItem2.Name = "superTabItem2"
            Me.superTabItem2.Text = "New"
            '
            'buttonItem2
            '
            Me.buttonItem2.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
            Me.buttonItem2.ColorTable = DevComponents.DotNetBar.eButtonColor.Blue
            Me.buttonItem2.Image = CType(resources.GetObject("buttonItem2.Image"), System.Drawing.Image)
            Me.buttonItem2.ImagePaddingHorizontal = 18
            Me.buttonItem2.ImagePaddingVertical = 10
            Me.buttonItem2.KeyTips = "S"
            Me.buttonItem2.Name = "buttonItem2"
            Me.buttonItem2.Stretch = True
            Me.buttonItem2.Text = "Save"
            '
            'buttonItem3
            '
            Me.buttonItem3.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
            Me.buttonItem3.ColorTable = DevComponents.DotNetBar.eButtonColor.Blue
            Me.buttonItem3.Image = CType(resources.GetObject("buttonItem3.Image"), System.Drawing.Image)
            Me.buttonItem3.ImagePaddingHorizontal = 18
            Me.buttonItem3.ImagePaddingVertical = 10
            Me.buttonItem3.KeyTips = "O"
            Me.buttonItem3.Name = "buttonItem3"
            Me.buttonItem3.Stretch = True
            Me.buttonItem3.Text = "Open"
            '
            'buttonItem4
            '
            Me.buttonItem4.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
            Me.buttonItem4.ColorTable = DevComponents.DotNetBar.eButtonColor.Blue
            Me.buttonItem4.Image = CType(resources.GetObject("buttonItem4.Image"), System.Drawing.Image)
            Me.buttonItem4.ImagePaddingHorizontal = 18
            Me.buttonItem4.ImagePaddingVertical = 10
            Me.buttonItem4.KeyTips = "C"
            Me.buttonItem4.Name = "buttonItem4"
            Me.buttonItem4.Stretch = True
            Me.buttonItem4.Text = "Close"
            '
            'buttonItem5
            '
            Me.buttonItem5.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
            Me.buttonItem5.ColorTable = DevComponents.DotNetBar.eButtonColor.Blue
            Me.buttonItem5.Image = CType(resources.GetObject("buttonItem5.Image"), System.Drawing.Image)
            Me.buttonItem5.ImagePaddingHorizontal = 18
            Me.buttonItem5.ImagePaddingVertical = 10
            Me.buttonItem5.KeyTips = "T"
            Me.buttonItem5.Name = "buttonItem5"
            Me.buttonItem5.Stretch = True
            Me.buttonItem5.Text = "Options"
            '
            'buttonItem6
            '
            Me.buttonItem6.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
            Me.buttonItem6.ColorTable = DevComponents.DotNetBar.eButtonColor.Blue
            Me.buttonItem6.Image = CType(resources.GetObject("buttonItem6.Image"), System.Drawing.Image)
            Me.buttonItem6.ImagePaddingHorizontal = 18
            Me.buttonItem6.ImagePaddingVertical = 10
            Me.buttonItem6.KeyTips = "X"
            Me.buttonItem6.Name = "buttonItem6"
            Me.buttonItem6.Stretch = True
            Me.buttonItem6.Text = "Exit"
            '
            'registrar_tab
            '
            Me.registrar_tab.Name = "registrar_tab"
            Me.registrar_tab.Panel = Me.MetroTabPanel1
            Me.registrar_tab.Tag = "1"
            Me.registrar_tab.Text = "REGISTRAR OFFICE"
            '
            'business_tab
            '
            Me.business_tab.Name = "business_tab"
            Me.business_tab.Panel = Me.MetroTabPanel5
            Me.business_tab.Text = "BUSINESS OFFICE"
            '
            'library_tab
            '
            Me.library_tab.Name = "library_tab"
            Me.library_tab.Panel = Me.MetroTabPanel4
            Me.library_tab.Tag = "4"
            Me.library_tab.Text = "&LIBRARY"
            '
            'guidance_tab
            '
            Me.guidance_tab.Name = "guidance_tab"
            Me.guidance_tab.Panel = Me.MetroTabPanel3
            Me.guidance_tab.Tag = "3"
            Me.guidance_tab.Text = "&GUIDANCE OFFICE"
            '
            'instructor_tab
            '
            Me.instructor_tab.Name = "instructor_tab"
            Me.instructor_tab.Panel = Me.MetroTabPanel2
            Me.instructor_tab.Text = "INSTRUCTORS"
            '
            'grades_tab
            '
            Me.grades_tab.Name = "grades_tab"
            Me.grades_tab.Panel = Me.MetroTabPanel6
            Me.grades_tab.Text = "GRADES"
            '
            'bookstore_tab
            '
            Me.bookstore_tab.Checked = True
            Me.bookstore_tab.Name = "bookstore_tab"
            Me.bookstore_tab.Panel = Me.MetroTabPanel7
            Me.bookstore_tab.Text = "BOOKSTORE"
            '
            'colorThemeButton
            '
            Me.colorThemeButton.AutoExpandOnClick = True
            Me.colorThemeButton.CanCustomize = False
            Me.colorThemeButton.Image = Global.My.Resources.Resources.ColorScheme
            Me.colorThemeButton.Name = "colorThemeButton"
            Me.colorThemeButton.ShowSubItems = False
            Me.colorThemeButton.Text = "Metro Color Themes"
            Me.colorThemeButton.Tooltip = "Choose Metro Color Theme"
            '
            'qatCustomizeItem1
            '
            Me.qatCustomizeItem1.BeginGroup = True
            Me.qatCustomizeItem1.Name = "qatCustomizeItem1"
            '
            'styleManager1
            '
            Me.styleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.Metro
            Me.styleManager1.MetroColorParameters = New DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.White, System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(26, Byte), Integer)))
            '
            'OpenFileDialog1
            '
            Me.OpenFileDialog1.FileName = "OpenFileDialog1"
            '
            'BackgroundWorker1
            '
            '
            'Timer1
            '
            Me.Timer1.Interval = 2000
            '
            'MainForm
            '
            Me.ClientSize = New System.Drawing.Size(913, 668)
            Me.Controls.Add(Me.superTabControl1)
            Me.Controls.Add(Me.metroShell1)
            Me.Controls.Add(Me.metroStatusBar1)
            Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.MinimumSize = New System.Drawing.Size(600, 400)
            Me.Name = "MainForm"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
            Me.metroShell1.ResumeLayout(False)
            Me.metroShell1.PerformLayout()
            Me.MetroTabPanel7.ResumeLayout(False)
            Me.ExpandablePanel7.ResumeLayout(False)
            Me.ExpandablePanel7.PerformLayout()
            CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
            Me.MetroTabPanel5.ResumeLayout(False)
            Me.ExpandablePanel2.ResumeLayout(False)
            CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
            Me.MetroTabPanel3.ResumeLayout(False)
            Me.ExpandablePanel4.ResumeLayout(False)
            CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
            Me.MetroTabPanel2.ResumeLayout(False)
            Me.ExpandablePanel5.ResumeLayout(False)
            CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
            Me.MetroTabPanel6.ResumeLayout(False)
            Me.ExpandablePanel6.ResumeLayout(False)
            CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
            Me.MetroTabPanel4.ResumeLayout(False)
            Me.ExpandablePanel3.ResumeLayout(False)
            CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
            Me.MetroTabPanel1.ResumeLayout(False)
            Me.ExpandablePanel1.ResumeLayout(False)
            CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.superTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.superTabControl1.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub

#End Region

        Private metroStatusBar1 As DevComponents.DotNetBar.Metro.MetroStatusBar
        Private WithEvents metroShell1 As DevComponents.DotNetBar.Metro.MetroShell
        Private WithEvents metroAppButton1 As DevComponents.DotNetBar.Metro.MetroAppButton
        Private qatCustomizeItem1 As DevComponents.DotNetBar.QatCustomizeItem
        Private styleManager1 As DevComponents.DotNetBar.StyleManager
        Private superTabControl1 As DevComponents.DotNetBar.SuperTabControl
        Private superTabControlPanel4 As DevComponents.DotNetBar.SuperTabControlPanel
        Private superTabItem4 As DevComponents.DotNetBar.SuperTabItem
        Private superTabControlPanel3 As DevComponents.DotNetBar.SuperTabControlPanel
        Private superTabItem3 As DevComponents.DotNetBar.SuperTabItem
        Private superTabControlPanel2 As DevComponents.DotNetBar.SuperTabControlPanel
        Private superTabItem2 As DevComponents.DotNetBar.SuperTabItem
        Private superTabControlPanel1 As DevComponents.DotNetBar.SuperTabControlPanel
        Private superTabItem1 As DevComponents.DotNetBar.SuperTabItem
        Private buttonItem2 As DevComponents.DotNetBar.ButtonItem
        Private buttonItem3 As DevComponents.DotNetBar.ButtonItem
        Private buttonItem4 As DevComponents.DotNetBar.ButtonItem
        Private buttonItem5 As DevComponents.DotNetBar.ButtonItem
        Private buttonItem6 As DevComponents.DotNetBar.ButtonItem
        Private colorThemeButton As DevComponents.DotNetBar.ButtonItem
        Friend WithEvents MetroTabPanel4 As DevComponents.DotNetBar.Metro.MetroTabPanel
        Friend WithEvents MetroTabPanel3 As DevComponents.DotNetBar.Metro.MetroTabPanel
        Friend WithEvents guidance_tab As DevComponents.DotNetBar.Metro.MetroTabItem
        Friend WithEvents library_tab As DevComponents.DotNetBar.Metro.MetroTabItem
        Friend WithEvents MetroTabPanel1 As DevComponents.DotNetBar.Metro.MetroTabPanel
        Friend WithEvents ListViewEx1 As DevComponents.DotNetBar.Controls.ListViewEx
        Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
        Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
        Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
        Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
        Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
        Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
        Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
        Friend WithEvents ColumnHeader8 As System.Windows.Forms.ColumnHeader
        Friend WithEvents ColumnHeader9 As System.Windows.Forms.ColumnHeader
        Friend WithEvents ColumnHeader10 As System.Windows.Forms.ColumnHeader
        Friend WithEvents ListViewEx4 As DevComponents.DotNetBar.Controls.ListViewEx
        Friend WithEvents ColumnHeader34 As System.Windows.Forms.ColumnHeader
        Friend WithEvents ColumnHeader35 As System.Windows.Forms.ColumnHeader
        Friend WithEvents ColumnHeader36 As System.Windows.Forms.ColumnHeader
        Friend WithEvents ColumnHeader37 As System.Windows.Forms.ColumnHeader
        Friend WithEvents ColumnHeader38 As System.Windows.Forms.ColumnHeader
        Friend WithEvents ColumnHeader39 As System.Windows.Forms.ColumnHeader
        Friend WithEvents ColumnHeader40 As System.Windows.Forms.ColumnHeader
        Friend WithEvents ColumnHeader41 As System.Windows.Forms.ColumnHeader
        Friend WithEvents ColumnHeader42 As System.Windows.Forms.ColumnHeader
        Friend WithEvents ColumnHeader43 As System.Windows.Forms.ColumnHeader
        Friend WithEvents ColumnHeader44 As System.Windows.Forms.ColumnHeader
        Friend WithEvents ListViewEx3 As DevComponents.DotNetBar.Controls.ListViewEx
        Friend WithEvents ColumnHeader23 As System.Windows.Forms.ColumnHeader
        Friend WithEvents ColumnHeader24 As System.Windows.Forms.ColumnHeader
        Friend WithEvents ColumnHeader25 As System.Windows.Forms.ColumnHeader
        Friend WithEvents ColumnHeader26 As System.Windows.Forms.ColumnHeader
        Friend WithEvents ColumnHeader27 As System.Windows.Forms.ColumnHeader
        Friend WithEvents ColumnHeader28 As System.Windows.Forms.ColumnHeader
        Friend WithEvents ColumnHeader29 As System.Windows.Forms.ColumnHeader
        Friend WithEvents ColumnHeader30 As System.Windows.Forms.ColumnHeader
        Friend WithEvents ColumnHeader31 As System.Windows.Forms.ColumnHeader
        Friend WithEvents ColumnHeader32 As System.Windows.Forms.ColumnHeader
        Friend WithEvents ColumnHeader33 As System.Windows.Forms.ColumnHeader
        Friend WithEvents registrar_tab As DevComponents.DotNetBar.Metro.MetroTabItem
        Friend WithEvents MetroTabPanel5 As DevComponents.DotNetBar.Metro.MetroTabPanel
        Friend WithEvents business_tab As DevComponents.DotNetBar.Metro.MetroTabItem
        Friend WithEvents ListViewEx2 As DevComponents.DotNetBar.Controls.ListViewEx
        Friend WithEvents ColumnHeader12 As System.Windows.Forms.ColumnHeader
        Friend WithEvents ColumnHeader13 As System.Windows.Forms.ColumnHeader
        Friend WithEvents ColumnHeader14 As System.Windows.Forms.ColumnHeader
        Friend WithEvents ColumnHeader15 As System.Windows.Forms.ColumnHeader
        Friend WithEvents ColumnHeader16 As System.Windows.Forms.ColumnHeader
        Friend WithEvents ColumnHeader17 As System.Windows.Forms.ColumnHeader
        Friend WithEvents ColumnHeader18 As System.Windows.Forms.ColumnHeader
        Friend WithEvents ColumnHeader19 As System.Windows.Forms.ColumnHeader
        Friend WithEvents ColumnHeader20 As System.Windows.Forms.ColumnHeader
        Friend WithEvents ColumnHeader21 As System.Windows.Forms.ColumnHeader
        Friend WithEvents MetroTabPanel2 As DevComponents.DotNetBar.Metro.MetroTabPanel
        Friend WithEvents ListViewEx5 As DevComponents.DotNetBar.Controls.ListViewEx
        Friend WithEvents ColumnHeader45 As System.Windows.Forms.ColumnHeader
        Friend WithEvents ColumnHeader46 As System.Windows.Forms.ColumnHeader
        Friend WithEvents ColumnHeader47 As System.Windows.Forms.ColumnHeader
        Friend WithEvents ColumnHeader48 As System.Windows.Forms.ColumnHeader
        Friend WithEvents ColumnHeader49 As System.Windows.Forms.ColumnHeader
        Friend WithEvents ColumnHeader50 As System.Windows.Forms.ColumnHeader
        Friend WithEvents ColumnHeader51 As System.Windows.Forms.ColumnHeader
        Friend WithEvents ColumnHeader52 As System.Windows.Forms.ColumnHeader
        Friend WithEvents ColumnHeader53 As System.Windows.Forms.ColumnHeader
        Friend WithEvents ColumnHeader54 As System.Windows.Forms.ColumnHeader
        Friend WithEvents ColumnHeader55 As System.Windows.Forms.ColumnHeader
        Friend WithEvents instructor_tab As DevComponents.DotNetBar.Metro.MetroTabItem
        Friend WithEvents ColumnHeader59 As System.Windows.Forms.ColumnHeader
        Friend WithEvents ColumnHeader57 As System.Windows.Forms.ColumnHeader
        Friend WithEvents ColumnHeader58 As System.Windows.Forms.ColumnHeader
        Friend WithEvents ColumnHeader11 As System.Windows.Forms.ColumnHeader
        Friend WithEvents ColumnHeader60 As System.Windows.Forms.ColumnHeader
        Friend WithEvents ColumnHeader61 As System.Windows.Forms.ColumnHeader
        Friend WithEvents MetroTabPanel6 As DevComponents.DotNetBar.Metro.MetroTabPanel
        Friend WithEvents grades_tab As DevComponents.DotNetBar.Metro.MetroTabItem
        Friend WithEvents ListViewEx6 As DevComponents.DotNetBar.Controls.ListViewEx
        Friend WithEvents ColumnHeader22 As System.Windows.Forms.ColumnHeader
        Friend WithEvents ColumnHeader56 As System.Windows.Forms.ColumnHeader
        Friend WithEvents ColumnHeader62 As System.Windows.Forms.ColumnHeader
        Friend WithEvents ColumnHeader63 As System.Windows.Forms.ColumnHeader
        Friend WithEvents ColumnHeader64 As System.Windows.Forms.ColumnHeader
        Friend WithEvents ColumnHeader65 As System.Windows.Forms.ColumnHeader
        Friend WithEvents ColumnHeader66 As System.Windows.Forms.ColumnHeader
        Friend WithEvents ColumnHeader67 As System.Windows.Forms.ColumnHeader
        Friend WithEvents ColumnHeader68 As System.Windows.Forms.ColumnHeader
        Friend WithEvents ColumnHeader69 As System.Windows.Forms.ColumnHeader
        Friend WithEvents ColumnHeader70 As System.Windows.Forms.ColumnHeader
        Friend WithEvents ColumnHeader71 As System.Windows.Forms.ColumnHeader
        Friend WithEvents ColumnHeader75 As System.Windows.Forms.ColumnHeader
        Friend WithEvents ColumnHeader76 As System.Windows.Forms.ColumnHeader
        Friend WithEvents ColumnHeader77 As System.Windows.Forms.ColumnHeader
        Friend WithEvents ColumnHeader78 As System.Windows.Forms.ColumnHeader
        Friend WithEvents ExpandableSplitter1 As DevComponents.DotNetBar.ExpandableSplitter
        Friend WithEvents ExpandableSplitter2 As DevComponents.DotNetBar.ExpandableSplitter
        Friend WithEvents ExpandableSplitter6 As DevComponents.DotNetBar.ExpandableSplitter
        Friend WithEvents ExpandableSplitter5 As DevComponents.DotNetBar.ExpandableSplitter
        Friend WithEvents ExpandableSplitter4 As DevComponents.DotNetBar.ExpandableSplitter
        Friend WithEvents ExpandableSplitter3 As DevComponents.DotNetBar.ExpandableSplitter
        Private WithEvents MetroToolbar6 As DevComponents.DotNetBar.Metro.MetroToolbar
        Private WithEvents updateRegistrarButton As DevComponents.DotNetBar.ButtonItem
        Private WithEvents searchRegistrarButton As DevComponents.DotNetBar.ButtonItem
        Friend WithEvents searchRegistrarTxt As DevComponents.DotNetBar.TextBoxItem
        Private WithEvents deleteRegistrarButton As DevComponents.DotNetBar.ButtonItem
        Private WithEvents addRegistrarButton As DevComponents.DotNetBar.ButtonItem
        Friend WithEvents b_id_lbl As DevComponents.DotNetBar.LabelX
        Friend WithEvents LabelX5 As DevComponents.DotNetBar.LabelX
        Friend WithEvents LabelX4 As DevComponents.DotNetBar.LabelX
        Friend WithEvents LabelX3 As DevComponents.DotNetBar.LabelX
        Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
        Friend WithEvents ExpandablePanel1 As DevComponents.DotNetBar.ExpandablePanel
        Friend WithEvents ExpandableSplitter7 As DevComponents.DotNetBar.ExpandableSplitter
        Friend WithEvents si_course_yr As DevComponents.DotNetBar.LabelX
        Friend WithEvents si_Mname_txt As DevComponents.DotNetBar.Controls.TextBoxX
        Friend WithEvents si_Fname_txt As DevComponents.DotNetBar.Controls.TextBoxX
        Friend WithEvents si_Lname_txt As DevComponents.DotNetBar.Controls.TextBoxX
        Friend WithEvents si_stud_id As DevComponents.DotNetBar.LabelX
        Friend WithEvents si_stud_id_txt As DevComponents.DotNetBar.Controls.TextBoxX
        Friend WithEvents si_name As DevComponents.DotNetBar.LabelX
        Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
        Friend WithEvents si_yr_txt As DevComponents.DotNetBar.Controls.TextBoxX
        Friend WithEvents si_acad_yr As DevComponents.DotNetBar.LabelX
        Friend WithEvents si_course_txt As DevComponents.DotNetBar.Controls.TextBoxX
        Friend WithEvents si_semester_txt As DevComponents.DotNetBar.Controls.TextBoxX
        Friend WithEvents si_acadyear_txt As DevComponents.DotNetBar.Controls.TextBoxX
        Friend WithEvents si_semester As DevComponents.DotNetBar.LabelX
        Friend WithEvents si_contact_txt As DevComponents.DotNetBar.Controls.TextBoxX
        Friend WithEvents si_contact As DevComponents.DotNetBar.LabelX
        Friend WithEvents si_photo_path_txt As DevComponents.DotNetBar.Controls.TextBoxX
        Friend WithEvents si_photo As DevComponents.DotNetBar.LabelX
        Friend WithEvents si_id_txt As DevComponents.DotNetBar.Controls.TextBoxX
        Friend WithEvents LabelX13 As DevComponents.DotNetBar.LabelX
        Friend WithEvents ColumnHeader72 As System.Windows.Forms.ColumnHeader
        Friend WithEvents ButtonX1 As DevComponents.DotNetBar.ButtonX
        Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
        Private WithEvents MetroToolbar1 As DevComponents.DotNetBar.Metro.MetroToolbar
        Private WithEvents deleteGradesButton As DevComponents.DotNetBar.ButtonItem
        Private WithEvents searchGradessButton As DevComponents.DotNetBar.ButtonItem
        Friend WithEvents searchGradesTxt As DevComponents.DotNetBar.TextBoxItem
        Private WithEvents MetroToolbar3 As DevComponents.DotNetBar.Metro.MetroToolbar
        Private WithEvents deleteGuidanceButton As DevComponents.DotNetBar.ButtonItem
        Private WithEvents searchGuidanceButton As DevComponents.DotNetBar.ButtonItem
        Friend WithEvents searchGuidanceTxt As DevComponents.DotNetBar.TextBoxItem
        Private WithEvents MetroToolbar4 As DevComponents.DotNetBar.Metro.MetroToolbar
        Private WithEvents deleteLibraryButton As DevComponents.DotNetBar.ButtonItem
        Private WithEvents searchLibraryButton As DevComponents.DotNetBar.ButtonItem
        Friend WithEvents searchLibraryTxt As DevComponents.DotNetBar.TextBoxItem
        Private WithEvents MetroToolbar5 As DevComponents.DotNetBar.Metro.MetroToolbar
        Private WithEvents deleteBusinessButton As DevComponents.DotNetBar.ButtonItem
        Private WithEvents searchBusinessButton As DevComponents.DotNetBar.ButtonItem
        Friend WithEvents searchBusinessTxt As DevComponents.DotNetBar.TextBoxItem
        Friend WithEvents ColumnHeader73 As System.Windows.Forms.ColumnHeader
        Friend WithEvents ColumnHeader74 As System.Windows.Forms.ColumnHeader
        Friend WithEvents ColumnHeader79 As System.Windows.Forms.ColumnHeader
        Private WithEvents MetroToolbar2 As DevComponents.DotNetBar.Metro.MetroToolbar
        Private WithEvents deleteInstructorButton As DevComponents.DotNetBar.ButtonItem
        Private WithEvents searchInstructorButton As DevComponents.DotNetBar.ButtonItem
        Friend WithEvents searchInstructorTxt As DevComponents.DotNetBar.TextBoxItem
        Friend WithEvents ColumnHeader80 As System.Windows.Forms.ColumnHeader
        Friend WithEvents ColumnHeader81 As System.Windows.Forms.ColumnHeader
        Friend WithEvents LabelX6 As DevComponents.DotNetBar.LabelX
        Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
        Friend WithEvents Timer1 As System.Windows.Forms.Timer
        Friend WithEvents prev_idLbl As DevComponents.DotNetBar.LabelX
        Friend WithEvents lbl_fullname As DevComponents.DotNetBar.LabelX
        Friend WithEvents LabelItem2 As DevComponents.DotNetBar.LabelItem
        Friend WithEvents LabelItem3 As DevComponents.DotNetBar.LabelItem
        Private WithEvents updateBusinessButton As DevComponents.DotNetBar.ButtonItem
        Private WithEvents addBusinessButton As DevComponents.DotNetBar.ButtonItem
        Private WithEvents updateGradesButton As DevComponents.DotNetBar.ButtonItem
        Private WithEvents addGradesButton As DevComponents.DotNetBar.ButtonItem
        Friend WithEvents ExpandableSplitter11 As DevComponents.DotNetBar.ExpandableSplitter
        Friend WithEvents ExpandablePanel5 As DevComponents.DotNetBar.ExpandablePanel
        Friend WithEvents i_fullname As DevComponents.DotNetBar.LabelX
        Friend WithEvents i_id_lbl As DevComponents.DotNetBar.LabelX
        Friend WithEvents ButtonX5 As DevComponents.DotNetBar.ButtonX
        Friend WithEvents i_directorypath As DevComponents.DotNetBar.Controls.TextBoxX
        Friend WithEvents LabelX40 As DevComponents.DotNetBar.LabelX
        Friend WithEvents i_id As DevComponents.DotNetBar.Controls.TextBoxX
        Friend WithEvents LabelX41 As DevComponents.DotNetBar.LabelX
        Friend WithEvents i_semester As DevComponents.DotNetBar.Controls.TextBoxX
        Friend WithEvents i_acadyear As DevComponents.DotNetBar.Controls.TextBoxX
        Friend WithEvents LabelX43 As DevComponents.DotNetBar.LabelX
        Friend WithEvents i_yearlevel As DevComponents.DotNetBar.Controls.TextBoxX
        Friend WithEvents LabelX44 As DevComponents.DotNetBar.LabelX
        Friend WithEvents i_subjectcode As DevComponents.DotNetBar.Controls.TextBoxX
        Friend WithEvents LabelX45 As DevComponents.DotNetBar.LabelX
        Friend WithEvents i_middlename As DevComponents.DotNetBar.Controls.TextBoxX
        Friend WithEvents i_firstname As DevComponents.DotNetBar.Controls.TextBoxX
        Friend WithEvents i_lastname As DevComponents.DotNetBar.Controls.TextBoxX
        Friend WithEvents LabelX46 As DevComponents.DotNetBar.LabelX
        Friend WithEvents i_empid As DevComponents.DotNetBar.Controls.TextBoxX
        Friend WithEvents LabelX47 As DevComponents.DotNetBar.LabelX
        Friend WithEvents PictureBox5 As System.Windows.Forms.PictureBox
        Private WithEvents updateInstructorButton As DevComponents.DotNetBar.ButtonItem
        Private WithEvents addInstructorButton As DevComponents.DotNetBar.ButtonItem
        Friend WithEvents ExpandableSplitter10 As DevComponents.DotNetBar.ExpandableSplitter
        Friend WithEvents ExpandablePanel4 As DevComponents.DotNetBar.ExpandablePanel
        Friend WithEvents g_fullname As DevComponents.DotNetBar.LabelX
        Friend WithEvents g_id_lbl As DevComponents.DotNetBar.LabelX
        Friend WithEvents ButtonX4 As DevComponents.DotNetBar.ButtonX
        Friend WithEvents g_directorypath As DevComponents.DotNetBar.Controls.TextBoxX
        Friend WithEvents LabelX30 As DevComponents.DotNetBar.LabelX
        Friend WithEvents g_id As DevComponents.DotNetBar.Controls.TextBoxX
        Friend WithEvents LabelX31 As DevComponents.DotNetBar.LabelX
        Friend WithEvents g_contact As DevComponents.DotNetBar.Controls.TextBoxX
        Friend WithEvents LabelX32 As DevComponents.DotNetBar.LabelX
        Friend WithEvents g_semester As DevComponents.DotNetBar.Controls.TextBoxX
        Friend WithEvents g_acadyear As DevComponents.DotNetBar.Controls.TextBoxX
        Friend WithEvents LabelX33 As DevComponents.DotNetBar.LabelX
        Friend WithEvents g_yearlevel As DevComponents.DotNetBar.Controls.TextBoxX
        Friend WithEvents LabelX34 As DevComponents.DotNetBar.LabelX
        Friend WithEvents g_course As DevComponents.DotNetBar.Controls.TextBoxX
        Friend WithEvents LabelX35 As DevComponents.DotNetBar.LabelX
        Friend WithEvents g_middlename As DevComponents.DotNetBar.Controls.TextBoxX
        Friend WithEvents g_firstname As DevComponents.DotNetBar.Controls.TextBoxX
        Friend WithEvents g_lastname As DevComponents.DotNetBar.Controls.TextBoxX
        Friend WithEvents LabelX36 As DevComponents.DotNetBar.LabelX
        Friend WithEvents g_studid As DevComponents.DotNetBar.Controls.TextBoxX
        Friend WithEvents LabelX37 As DevComponents.DotNetBar.LabelX
        Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
        Private WithEvents updateGuidanceButton As DevComponents.DotNetBar.ButtonItem
        Private WithEvents addGuidanceButton As DevComponents.DotNetBar.ButtonItem
        Friend WithEvents ExpandableSplitter9 As DevComponents.DotNetBar.ExpandableSplitter
        Friend WithEvents ExpandablePanel3 As DevComponents.DotNetBar.ExpandablePanel
        Friend WithEvents l_fullname As DevComponents.DotNetBar.LabelX
        Friend WithEvents l_id_lbl As DevComponents.DotNetBar.LabelX
        Friend WithEvents ButtonX3 As DevComponents.DotNetBar.ButtonX
        Friend WithEvents l_directorypath As DevComponents.DotNetBar.Controls.TextBoxX
        Friend WithEvents LabelX20 As DevComponents.DotNetBar.LabelX
        Friend WithEvents l_id As DevComponents.DotNetBar.Controls.TextBoxX
        Friend WithEvents LabelX21 As DevComponents.DotNetBar.LabelX
        Friend WithEvents l_contact As DevComponents.DotNetBar.Controls.TextBoxX
        Friend WithEvents LabelX22 As DevComponents.DotNetBar.LabelX
        Friend WithEvents l_semester As DevComponents.DotNetBar.Controls.TextBoxX
        Friend WithEvents l_acadyear As DevComponents.DotNetBar.Controls.TextBoxX
        Friend WithEvents LabelX23 As DevComponents.DotNetBar.LabelX
        Friend WithEvents l_yearlevel As DevComponents.DotNetBar.Controls.TextBoxX
        Friend WithEvents LabelX24 As DevComponents.DotNetBar.LabelX
        Friend WithEvents l_course As DevComponents.DotNetBar.Controls.TextBoxX
        Friend WithEvents LabelX25 As DevComponents.DotNetBar.LabelX
        Friend WithEvents l_middlename As DevComponents.DotNetBar.Controls.TextBoxX
        Friend WithEvents l_fistname As DevComponents.DotNetBar.Controls.TextBoxX
        Friend WithEvents l_lastname As DevComponents.DotNetBar.Controls.TextBoxX
        Friend WithEvents LabelX26 As DevComponents.DotNetBar.LabelX
        Friend WithEvents l_studid As DevComponents.DotNetBar.Controls.TextBoxX
        Friend WithEvents LabelX27 As DevComponents.DotNetBar.LabelX
        Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
        Private WithEvents updateLibraryButton As DevComponents.DotNetBar.ButtonItem
        Private WithEvents addLibraryButton As DevComponents.DotNetBar.ButtonItem
        Friend WithEvents ExpandableSplitter8 As DevComponents.DotNetBar.ExpandableSplitter
        Friend WithEvents ExpandablePanel2 As DevComponents.DotNetBar.ExpandablePanel
        Friend WithEvents LabelX7 As DevComponents.DotNetBar.LabelX
        Friend WithEvents b_fullname As DevComponents.DotNetBar.LabelX
        Friend WithEvents ButtonX2 As DevComponents.DotNetBar.ButtonX
        Friend WithEvents b_directorypath As DevComponents.DotNetBar.Controls.TextBoxX
        Friend WithEvents LabelX9 As DevComponents.DotNetBar.LabelX
        Friend WithEvents b_id As DevComponents.DotNetBar.Controls.TextBoxX
        Friend WithEvents LabelX10 As DevComponents.DotNetBar.LabelX
        Friend WithEvents b_contact As DevComponents.DotNetBar.Controls.TextBoxX
        Friend WithEvents LabelX11 As DevComponents.DotNetBar.LabelX
        Friend WithEvents b_semester As DevComponents.DotNetBar.Controls.TextBoxX
        Friend WithEvents b_acadyear As DevComponents.DotNetBar.Controls.TextBoxX
        Friend WithEvents LabelX12 As DevComponents.DotNetBar.LabelX
        Friend WithEvents b_yearlvl As DevComponents.DotNetBar.Controls.TextBoxX
        Friend WithEvents LabelX14 As DevComponents.DotNetBar.LabelX
        Friend WithEvents b_course As DevComponents.DotNetBar.Controls.TextBoxX
        Friend WithEvents LabelX15 As DevComponents.DotNetBar.LabelX
        Friend WithEvents b_middlename As DevComponents.DotNetBar.Controls.TextBoxX
        Friend WithEvents b_firstname As DevComponents.DotNetBar.Controls.TextBoxX
        Friend WithEvents b_lastname As DevComponents.DotNetBar.Controls.TextBoxX
        Friend WithEvents LabelX16 As DevComponents.DotNetBar.LabelX
        Friend WithEvents b_studid As DevComponents.DotNetBar.Controls.TextBoxX
        Friend WithEvents LabelX17 As DevComponents.DotNetBar.LabelX
        Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
        Friend WithEvents LabelX60 As DevComponents.DotNetBar.LabelX
        Friend WithEvents b_rembalance As DevComponents.DotNetBar.Controls.TextBoxX
        Friend WithEvents LabelX59 As DevComponents.DotNetBar.LabelX
        Friend WithEvents b_description As DevComponents.DotNetBar.Controls.TextBoxX
        Friend WithEvents LabelX58 As DevComponents.DotNetBar.LabelX
        Friend WithEvents b_status As DevComponents.DotNetBar.Controls.ComboBoxEx
        Friend WithEvents ComboItem1 As DevComponents.Editors.ComboItem
        Friend WithEvents ComboItem2 As DevComponents.Editors.ComboItem
        Friend WithEvents g_status As DevComponents.DotNetBar.Controls.ComboBoxEx
        Friend WithEvents ComboItem3 As DevComponents.Editors.ComboItem
        Friend WithEvents ComboItem4 As DevComponents.Editors.ComboItem
        Friend WithEvents LabelX8 As DevComponents.DotNetBar.LabelX
        Friend WithEvents g_uncollectedTxt As DevComponents.DotNetBar.Controls.TextBoxX
        Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
        Friend WithEvents l_status As DevComponents.DotNetBar.Controls.ComboBoxEx
        Friend WithEvents ComboItem5 As DevComponents.Editors.ComboItem
        Friend WithEvents ComboItem6 As DevComponents.Editors.ComboItem
        Friend WithEvents LabelX28 As DevComponents.DotNetBar.LabelX
        Friend WithEvents l_remainingBal As DevComponents.DotNetBar.Controls.TextBoxX
        Friend WithEvents l_unretbook As DevComponents.DotNetBar.Controls.TextBoxX
        Friend WithEvents LabelX18 As DevComponents.DotNetBar.LabelX
        Friend WithEvents LabelX19 As DevComponents.DotNetBar.LabelX
        Friend WithEvents LabelX29 As DevComponents.DotNetBar.LabelX
        Friend WithEvents LabelX42 As DevComponents.DotNetBar.LabelX
        Friend WithEvents i_units As DevComponents.DotNetBar.Controls.TextBoxX
        Friend WithEvents i_subjdesc As DevComponents.DotNetBar.Controls.TextBoxX
        Friend WithEvents LabelX38 As DevComponents.DotNetBar.LabelX
        Friend WithEvents ExpandablePanel6 As DevComponents.DotNetBar.ExpandablePanel
        Friend WithEvents LabelX39 As DevComponents.DotNetBar.LabelX
        Friend WithEvents t_units As DevComponents.DotNetBar.Controls.TextBoxX
        Friend WithEvents t_subjdesc As DevComponents.DotNetBar.Controls.TextBoxX
        Friend WithEvents LabelX48 As DevComponents.DotNetBar.LabelX
        Friend WithEvents LabelX50 As DevComponents.DotNetBar.LabelX
        Friend WithEvents t_id_lbl As DevComponents.DotNetBar.LabelX
        Friend WithEvents ButtonX6 As DevComponents.DotNetBar.ButtonX
        Friend WithEvents t_directorypath As DevComponents.DotNetBar.Controls.TextBoxX
        Friend WithEvents LabelX52 As DevComponents.DotNetBar.LabelX
        Friend WithEvents t_id As DevComponents.DotNetBar.Controls.TextBoxX
        Friend WithEvents LabelX53 As DevComponents.DotNetBar.LabelX
        Friend WithEvents t_semester As DevComponents.DotNetBar.Controls.TextBoxX
        Friend WithEvents t_acadyear As DevComponents.DotNetBar.Controls.TextBoxX
        Friend WithEvents LabelX54 As DevComponents.DotNetBar.LabelX
        Friend WithEvents t_yearlevel As DevComponents.DotNetBar.Controls.TextBoxX
        Friend WithEvents LabelX55 As DevComponents.DotNetBar.LabelX
        Friend WithEvents t_subjcode As DevComponents.DotNetBar.Controls.TextBoxX
        Friend WithEvents LabelX56 As DevComponents.DotNetBar.LabelX
        Friend WithEvents t_middlename As DevComponents.DotNetBar.Controls.TextBoxX
        Friend WithEvents t_firstname As DevComponents.DotNetBar.Controls.TextBoxX
        Friend WithEvents t_lastname As DevComponents.DotNetBar.Controls.TextBoxX
        Friend WithEvents LabelX57 As DevComponents.DotNetBar.LabelX
        Friend WithEvents t_empid As DevComponents.DotNetBar.Controls.TextBoxX
        Friend WithEvents LabelX61 As DevComponents.DotNetBar.LabelX
        Friend WithEvents PictureBox6 As System.Windows.Forms.PictureBox
        Friend WithEvents ExpandableSplitter12 As DevComponents.DotNetBar.ExpandableSplitter
        Friend WithEvents t_status As DevComponents.DotNetBar.Controls.ComboBoxEx
        Friend WithEvents ComboItem7 As DevComponents.Editors.ComboItem
        Friend WithEvents ComboItem8 As DevComponents.Editors.ComboItem
        Friend WithEvents LabelX66 As DevComponents.DotNetBar.LabelX
        Friend WithEvents t_grades As DevComponents.DotNetBar.Controls.TextBoxX
        Friend WithEvents LabelX65 As DevComponents.DotNetBar.LabelX
        Friend WithEvents t_course As DevComponents.DotNetBar.Controls.TextBoxX
        Friend WithEvents LabelX62 As DevComponents.DotNetBar.LabelX
        Friend WithEvents t_stud_name As DevComponents.DotNetBar.Controls.TextBoxX
        Friend WithEvents LabelX63 As DevComponents.DotNetBar.LabelX
        Friend WithEvents t_studid As DevComponents.DotNetBar.Controls.TextBoxX
        Friend WithEvents LabelX64 As DevComponents.DotNetBar.LabelX
        Friend WithEvents MetroTabPanel7 As DevComponents.DotNetBar.Metro.MetroTabPanel
        Friend WithEvents ExpandableSplitter13 As DevComponents.DotNetBar.ExpandableSplitter
        Friend WithEvents ExpandablePanel7 As DevComponents.DotNetBar.ExpandablePanel
        Friend WithEvents bk_status As DevComponents.DotNetBar.Controls.ComboBoxEx
        Friend WithEvents ComboItem9 As DevComponents.Editors.ComboItem
        Friend WithEvents ComboItem10 As DevComponents.Editors.ComboItem
        Friend WithEvents LabelX49 As DevComponents.DotNetBar.LabelX
        Friend WithEvents bk_fullnamelbl As DevComponents.DotNetBar.LabelX
        Friend WithEvents bk_idlbl As DevComponents.DotNetBar.LabelX
        Friend WithEvents ButtonX7 As DevComponents.DotNetBar.ButtonX
        Friend WithEvents bk_photodir As DevComponents.DotNetBar.Controls.TextBoxX
        Friend WithEvents LabelX69 As DevComponents.DotNetBar.LabelX
        Friend WithEvents bk_id As DevComponents.DotNetBar.Controls.TextBoxX
        Friend WithEvents LabelX70 As DevComponents.DotNetBar.LabelX
        Friend WithEvents bk_contact As DevComponents.DotNetBar.Controls.TextBoxX
        Friend WithEvents LabelX71 As DevComponents.DotNetBar.LabelX
        Friend WithEvents bk_sem As DevComponents.DotNetBar.Controls.TextBoxX
        Friend WithEvents bk_acadyear As DevComponents.DotNetBar.Controls.TextBoxX
        Friend WithEvents LabelX72 As DevComponents.DotNetBar.LabelX
        Friend WithEvents bk_year As DevComponents.DotNetBar.Controls.TextBoxX
        Friend WithEvents LabelX73 As DevComponents.DotNetBar.LabelX
        Friend WithEvents bk_course As DevComponents.DotNetBar.Controls.TextBoxX
        Friend WithEvents LabelX74 As DevComponents.DotNetBar.LabelX
        Friend WithEvents bk_middlename As DevComponents.DotNetBar.Controls.TextBoxX
        Friend WithEvents bk_firstname As DevComponents.DotNetBar.Controls.TextBoxX
        Friend WithEvents bk_lastname As DevComponents.DotNetBar.Controls.TextBoxX
        Friend WithEvents LabelX75 As DevComponents.DotNetBar.LabelX
        Friend WithEvents bk_studid As DevComponents.DotNetBar.Controls.TextBoxX
        Friend WithEvents LabelX76 As DevComponents.DotNetBar.LabelX
        Friend WithEvents PictureBox7 As System.Windows.Forms.PictureBox
        Friend WithEvents ExpandableSplitter14 As DevComponents.DotNetBar.ExpandableSplitter
        Private WithEvents MetroToolbar7 As DevComponents.DotNetBar.Metro.MetroToolbar
        Private WithEvents deleteBookstoreButton As DevComponents.DotNetBar.ButtonItem
        Private WithEvents searchBookstoreButton As DevComponents.DotNetBar.ButtonItem
        Friend WithEvents searchBookstoretxt As DevComponents.DotNetBar.TextBoxItem
        Private WithEvents addBookstoreButton As DevComponents.DotNetBar.ButtonItem
        Private WithEvents updateBookstoreButton As DevComponents.DotNetBar.ButtonItem
        Friend WithEvents ListViewEx7 As DevComponents.DotNetBar.Controls.ListViewEx
        Friend WithEvents ColumnHeader82 As System.Windows.Forms.ColumnHeader
        Friend WithEvents ColumnHeader83 As System.Windows.Forms.ColumnHeader
        Friend WithEvents ColumnHeader84 As System.Windows.Forms.ColumnHeader
        Friend WithEvents ColumnHeader85 As System.Windows.Forms.ColumnHeader
        Friend WithEvents ColumnHeader86 As System.Windows.Forms.ColumnHeader
        Friend WithEvents ColumnHeader87 As System.Windows.Forms.ColumnHeader
        Friend WithEvents ColumnHeader88 As System.Windows.Forms.ColumnHeader
        Friend WithEvents ColumnHeader89 As System.Windows.Forms.ColumnHeader
        Friend WithEvents ColumnHeader90 As System.Windows.Forms.ColumnHeader
        Friend WithEvents ColumnHeader91 As System.Windows.Forms.ColumnHeader
        Friend WithEvents ColumnHeader93 As System.Windows.Forms.ColumnHeader
        Friend WithEvents ColumnHeader94 As System.Windows.Forms.ColumnHeader
        Friend WithEvents bookstore_tab As DevComponents.DotNetBar.Metro.MetroTabItem
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents business_prev_id As DevComponents.DotNetBar.LabelX
        Friend WithEvents ColumnHeader92 As System.Windows.Forms.ColumnHeader
        Friend WithEvents bk_desc As DevComponents.DotNetBar.Controls.TextBoxX
        Friend WithEvents LabelX51 As DevComponents.DotNetBar.LabelX
    End Class
End Namespace