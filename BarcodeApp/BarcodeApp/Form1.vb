Imports Inlite.ClearImageNet
Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ReadBarcode2D("sample.png", 1)
    End Sub
    Sub ReadBarcode2D(ByVal fileName As String, ByVal page As Integer)
        Try
            Dim reader As New BarcodeReader()
            ' Select barcode type(s) to read
            ' reader.Pdf417 = True
            ' reader.DataMatrix = True
            reader.QR = True
            Dim barcodes As Barcode() = reader.Read(fileName, page)
            ' Process results
            For Each bc As Barcode In barcodes
                RichTextBox1.Text = bc.Text.ToString()
            Next
        Catch ex As Exception

        End Try
    End Sub
End Class
' programmed by ashumeow - https://github.com/ashumeow
' credits - http://how-to.inliteresearch.com/
