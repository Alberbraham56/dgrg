<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Button1 = New Button()
        lblp = New Label()
        lblap = New Label()
        lbla = New Label()
        txtap = New TextBox()
        txtp = New TextBox()
        Button2 = New Button()
        txta = New Label()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(32, 205)
        Button1.Name = "Button1"
        Button1.Size = New Size(75, 23)
        Button1.TabIndex = 0
        Button1.Text = "calcular"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' lblp
        ' 
        lblp.AutoSize = True
        lblp.Location = New Point(32, 58)
        lblp.Name = "lblp"
        lblp.Size = New Size(59, 15)
        lblp.TabIndex = 1
        lblp.Text = "Perimetro"
        ' 
        ' lblap
        ' 
        lblap.AutoSize = True
        lblap.Location = New Point(32, 104)
        lblap.Name = "lblap"
        lblap.Size = New Size(56, 15)
        lblap.TabIndex = 2
        lblap.Text = "Apotema"
        ' 
        ' lbla
        ' 
        lbla.AutoSize = True
        lbla.Location = New Point(32, 148)
        lbla.Name = "lbla"
        lbla.Size = New Size(31, 15)
        lbla.TabIndex = 3
        lbla.Text = "Area"
        ' 
        ' txtap
        ' 
        txtap.Location = New Point(97, 101)
        txtap.Name = "txtap"
        txtap.Size = New Size(107, 23)
        txtap.TabIndex = 4
        ' 
        ' txtp
        ' 
        txtp.Location = New Point(97, 55)
        txtp.Name = "txtp"
        txtp.Size = New Size(107, 23)
        txtp.TabIndex = 5
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(136, 205)
        Button2.Name = "Button2"
        Button2.Size = New Size(75, 23)
        Button2.TabIndex = 7
        Button2.Text = "Limpiar"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' txta
        ' 
        txta.AutoSize = True
        txta.Location = New Point(97, 148)
        txta.Name = "txta"
        txta.Size = New Size(15, 15)
        txta.TabIndex = 8
        txta.Text = "="
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(txta)
        Controls.Add(Button2)
        Controls.Add(txtp)
        Controls.Add(txtap)
        Controls.Add(lbla)
        Controls.Add(lblap)
        Controls.Add(lblp)
        Controls.Add(Button1)
        Name = "Form2"
        Text = "Form2"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents lblp As Label
    Friend WithEvents lblap As Label
    Friend WithEvents lbla As Label
    Friend WithEvents txtap As TextBox
    Friend WithEvents txtp As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents txta As Label
End Class
