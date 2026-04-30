<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnImprimir = New System.Windows.Forms.Button()
        Me.pdPrint = New System.Drawing.Printing.PrintDocument()
        Me.pddPrint = New System.Windows.Forms.PrintDialog()
        Me.SuspendLayout()
        '
        'btnImprimir
        '
        Me.btnImprimir.Location = New System.Drawing.Point(317, 337)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(162, 50)
        Me.btnImprimir.TabIndex = 0
        Me.btnImprimir.Text = "Imprimir Reporte"
        Me.btnImprimir.UseVisualStyleBackColor = True
        '
        'pdPrint
        '
        '
        'pddPrint
        '
        Me.pddPrint.UseEXDialog = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnImprimir)
        Me.Name = "Form1"
        Me.Text = "Reporte de Ventas"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnImprimir As Button
    Friend WithEvents pdPrint As Printing.PrintDocument
    Friend WithEvents pddPrint As PrintDialog
End Class
