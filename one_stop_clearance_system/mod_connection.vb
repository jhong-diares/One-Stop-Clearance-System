Module mod_connection
    Public rs As New ADODB.Recordset
    Public cn As New ADODB.Connection
    Sub connect_database()
        Try
            cn = New ADODB.Connection
            cn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\indio\OneDrive\Desktop\one_stop_clearance_system(main)\one_stop_clearance_system\db_clearance_system.accdb; Jet OLEDB:Database Password=admin"
            cn.Open()
            MsgBox("Database loaded successfuly !", MsgBoxStyle.Information, "SYSTEM")

        Catch ex As Exception
            Try
                cn = New ADODB.Connection
                cn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\indio\OneDrive\Desktop\one_stop_clearance_system(main)\one_stop_clearance_system\db_clearance_system.accdb; Jet OLEDB:Database Password=admin"
                cn.Open()

            Catch exq As Exception
                MsgBox("Database not found !", MsgBoxStyle.Critical, "SYSTEM")
            End Try

        End Try
    End Sub
End Module
