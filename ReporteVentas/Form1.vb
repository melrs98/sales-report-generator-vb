Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnImprimir.Click
        pddPrint.Document = pdPrint
        If pddPrint.ShowDialog() = DialogResult.OK Then

            pdPrint.PrinterSettings = pddPrint.PrinterSettings

            pdPrint.Print()
        End If
    End Sub

    Private Sub pdPrint_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles pdPrint.PrintPage
        Dim g As Graphics = e.Graphics


        Dim fuenteNormal As New Font("Arial", 12, FontStyle.Regular)
        Dim fuenteBold As New Font("Arial", 12, FontStyle.Bold)


        Dim margenIzq As Single = e.MarginBounds.Left
        Dim margenSup As Single = e.MarginBounds.Top
        Dim anchoArea As Single = e.MarginBounds.Width


        Dim y As Single = margenSup


        Dim titulo As String = "Reporte de Ventas"
        Dim sizeTitulo As SizeF = g.MeasureString(titulo, fuenteBold)
        Dim xTitulo As Single = margenIzq + (anchoArea - sizeTitulo.Width) / 2

        g.DrawString(titulo, fuenteBold, Brushes.Black, xTitulo, y)


        y += 40


        Dim fechaHoraTexto As String = "Fecha y Hora: " & Now.ToString("MM/dd/yyyy hh:mm tt")
        Dim sizeFecha As SizeF = g.MeasureString(fechaHoraTexto, fuenteBold)
        Dim xFecha As Single = margenIzq + (anchoArea - sizeFecha.Width) / 2

        g.DrawString(fechaHoraTexto, fuenteBold, Brushes.Black, xFecha, y)


        y += 60


        Dim xEmpleado As Single = margenIzq + 40
        Dim xVentas As Single = margenIzq + 350

        Dim tituloEmpleado As String = String.Format("{0}", "Empleado")
        Dim tituloVentas As String = String.Format("{0}", "Ventas")

        g.DrawString(tituloEmpleado, fuenteBold, Brushes.Black, xEmpleado, y)
        g.DrawString(tituloVentas, fuenteBold, Brushes.Black, xVentas, y)

        y += 30

        Dim empleados() As String = {
            "Carlos Rosado",
            "Melanie Acevedo",
            "Pedro Rivera",
            "Yesenia Villa",
            "Diana Machado"
        }


        Dim ventas() As Decimal = {3525D, 2430D, 5600D, 1700D, 2700D}

        Dim totalVentas As Decimal = 0D

        For i As Integer = 0 To empleados.Length - 1
            Dim nombreEmpleado As String = empleados(i)


            Dim montoFormateado As String = ventas(i).ToString("C2")
            Dim textoVentas As String = String.Format("{0}", montoFormateado)


            g.DrawString(nombreEmpleado, fuenteNormal, Brushes.Black, xEmpleado, y)

            g.DrawString(textoVentas, fuenteNormal, Brushes.Black, xVentas, y)

            totalVentas += ventas(i)
            y += 25
        Next


        y += 30


        Dim textoTotal As String = "Ventas Totales:"
        Dim totalFormateado As String = totalVentas.ToString("C2")

        g.DrawString(textoTotal, fuenteBold, Brushes.Black, xEmpleado, y)
        g.DrawString(totalFormateado, fuenteBold, Brushes.Black, xVentas, y)

        e.HasMorePages = False
    End Sub
End Class
