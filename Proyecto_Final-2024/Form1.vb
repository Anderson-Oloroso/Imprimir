Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports System.IO

Public Class frmTipoCuenta

    Dim sql As String
    Public ejecutar As New OleDb.OleDbCommand
    Dim buscar As OleDb.OleDbDataReader

    Public Function TamCol(ByVal dgv As DataGridView) As Single()
        Dim valores As Single() = New Single(dgv.ColumnCount - 1) {}
        For i As Integer = 0 To dgv.ColumnCount - 1
            valores(i) = CSng(dgv.Columns(i).Width)
        Next
        Return valores
    End Function

    Public Function ExportarPDF(ByVal Doc As Document)
        'Crear un numero de columnas
        Dim DTabla As New PdfPTable(dgvCuentas.ColumnCount)
        'Crear el relleno de celdas
        DTabla.DefaultCell.Padding = 3
        'Tamaño de las columnas
        Dim TamEncabezado As Single() = TamCol(dgvCuentas)
        DTabla.SetWidths(TamEncabezado)
        DTabla.WidthPercentage = 100
        DTabla.DefaultCell.BorderWidth = 2
        DTabla.DefaultCell.HorizontalAlignment = Element.ALIGN_CENTER
        'Crear un encabezado en el PDF
        Dim PrinEncab As New Paragraph("Tipos de cuenta", New Font(Font.Name = "Tahoma", 20, Font.Bold))
        PrinEncab.Alignment = Element.ALIGN_CENTER
        'Dim SubEncab As New Paragraph("btnImprimir.Text", New Font(Font.Name = "Algerian", 16, Font.Bold))
        'Logo del PDF
        Dim imagen As iTextSharp.text.Image
        imagen = iTextSharp.text.Image.GetInstance(My.Computer.FileSystem.CurrentDirectory & "\Villa.png")
        imagen.ScalePercent(12)
        imagen.SetAbsolutePosition(720, 520)
        '1.Captura de datos
        ' •Nombre de los encabezados
        For i As Integer = 0 To dgvCuentas.ColumnCount - 1
            DTabla.AddCell(dgvCuentas.Columns(i).HeaderText)
        Next
        DTabla.HeaderRows = 1
        DTabla.DefaultCell.BorderWidth = 1
        'Rellenar los registros
        For i As Integer = 0 To dgvCuentas.RowCount - 2 'Se le resta 2 a causa del encabezado
            For j As Integer = 0 To dgvCuentas.ColumnCount - 1
                DTabla.AddCell(dgvCuentas(j, i).Value.ToString()) 'Para el relleno de datos: Las matrices se crean en filas y columnas pero para relleno es columnas y filas
            Next
            DTabla.CompleteRow()
        Next
        'Agregar datos al PDF
        ' Doc.Add(imagen)
        'Doc.Add(New Chunk(" ")) 'Salto de linea
        Doc.Add(PrinEncab)
        Doc.Add(New Chunk(" ")) 'Salto de linea
        'Doc.Add(SubEncab)
        Doc.Add(New Chunk(" ")) 'Salto de linea
        Doc.Add(DTabla)
    End Function

    Private Sub BusCuentas()

        sql = "SELECT * FROM TIPOCUENTA"
        conectar()
        ejecutar.CommandType = CommandType.Text
        ejecutar.Connection = conexion
        ejecutar.CommandText = sql

        Try
            buscar = ejecutar.ExecuteReader
            While buscar.Read
                dgvCuentas.Rows.Add(buscar!cod_tipocuenta, buscar!nombre, buscar!descripcion)
            End While
        Catch ex As Exception
            MsgBox("Error en la búsqueda: " & ex.Message, vbCritical + vbOKOnly, "Error Busqueda")
        End Try

        desconectar()
    End Sub

    Private Sub frmTipoCuenta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BusCuentas()
    End Sub

    Private Sub btnImprimir_Click(sender As Object, e As EventArgs) Handles btnImprimir.Click
        Try
            'Generar el documento
            Dim Documento As New Document(PageSize.LETTER.Rotate(), 10, 10, 10, 10)
            'Guardar en directorio específico
            Dim NArchivo As String = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + "\Tipos de Cuentas.pdf"
            'Crear el archivo físico
            Dim archivo As New FileStream(NArchivo, FileMode.Create, FileAccess.ReadWrite, FileShare.ReadWrite)
            PdfWriter.GetInstance(Documento, archivo)
            Documento.Open()
            ExportarPDF(Documento)
            Documento.Close()
            Process.Start(NArchivo)
            MsgBox("Archivo creado", vbOKOnly + vbInformation, "Exportar a PDF")
        Catch ex As Exception
            MsgBox("Error al crear el archivo: " & ex.Message, vbOKOnly + vbCritical, "Error al exportar a PDF")
        End Try
    End Sub
End Class
