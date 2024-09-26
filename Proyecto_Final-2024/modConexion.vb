Module modConexion

    Public conexion As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=CIUDADANOS.accdb")

    Public Sub conectar()
        Try
            conexion.Open()
        Catch ex As Exception
            MsgBox("Error al conectar", vbCritical + vbOKOnly, "Error al conectar")
        End Try
    End Sub

    Public Sub desconectar()
        Try
            conexion.Close()
        Catch ex As Exception
            MsgBox("Error al desconectar", vbCritical + vbOKOnly, "Error al desconectar")
        End Try
    End Sub
End Module
