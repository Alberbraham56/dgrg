<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        lblf = New Label()
        lblhombre = New Label()
        lblname = New Label()
        lbledad = New Label()
        lbld = New Label()
        lbls = New Label()
        lblmeses = New Label()
        lblh = New Label()
        txts = New TextBox()
        txtm = New TextBox()
        txth = New TextBox()
        txtd = New TextBox()
        txtg = New TextBox()
        txtname = New TextBox()
        txtedad = New TextBox()
        Button1 = New Button()
        Button2 = New Button()
        SuspendLayout()
        ' 
        ' lblf
        ' 
        lblf.AutoSize = True
        lblf.Location = New Point(52, 20)
        lblf.Name = "lblf"
        lblf.Size = New Size(53, 15)
        lblf.TabIndex = 0
        lblf.Text = "Mujer (f)"
        ' 
        ' lblhombre
        ' 
        lblhombre.AutoSize = True
        lblhombre.Location = New Point(37, 56)
        lblhombre.Name = "lblhombre"
        lblhombre.Size = New Size(73, 15)
        lblhombre.TabIndex = 1
        lblhombre.Text = "Hombre (m)"
        ' 
        ' lblname
        ' 
        lblname.AutoSize = True
        lblname.Location = New Point(322, 39)
        lblname.Name = "lblname"
        lblname.Size = New Size(54, 15)
        lblname.TabIndex = 2
        lblname.Text = "Nombre:"
        ' 
        ' lbledad
        ' 
        lbledad.AutoSize = True
        lbledad.Location = New Point(322, 172)
        lbledad.Name = "lbledad"
        lbledad.Size = New Size(33, 15)
        lbledad.TabIndex = 3
        lbledad.Text = "edad"
        ' 
        ' lbld
        ' 
        lbld.AutoSize = True
        lbld.Location = New Point(37, 255)
        lbld.Name = "lbld"
        lbld.Size = New Size(28, 15)
        lbld.TabIndex = 4
        lbld.Text = "dias"
        ' 
        ' lbls
        ' 
        lbls.AutoSize = True
        lbls.Location = New Point(25, 217)
        lbls.Name = "lbls"
        lbls.Size = New Size(53, 15)
        lbls.TabIndex = 5
        lbls.Text = "semanas"
        ' 
        ' lblmeses
        ' 
        lblmeses.AutoSize = True
        lblmeses.Location = New Point(37, 177)
        lblmeses.Name = "lblmeses"
        lblmeses.Size = New Size(40, 15)
        lblmeses.TabIndex = 6
        lblmeses.Text = "Meses"
        ' 
        ' lblh
        ' 
        lblh.AutoSize = True
        lblh.Location = New Point(37, 293)
        lblh.Name = "lblh"
        lblh.Size = New Size(36, 15)
        lblh.TabIndex = 7
        lblh.Text = "horas"
        ' 
        ' txts
        ' 
        txts.Location = New Point(84, 209)
        txts.Name = "txts"
        txts.Size = New Size(116, 23)
        txts.TabIndex = 8
        ' 
        ' txtm
        ' 
        txtm.Location = New Point(84, 169)
        txtm.Name = "txtm"
        txtm.Size = New Size(116, 23)
        txtm.TabIndex = 9
        ' 
        ' txth
        ' 
        txth.Location = New Point(84, 290)
        txth.Name = "txth"
        txth.Size = New Size(116, 23)
        txth.TabIndex = 10
        ' 
        ' txtd
        ' 
        txtd.Location = New Point(84, 252)
        txtd.Name = "txtd"
        txtd.Size = New Size(116, 23)
        txtd.TabIndex = 11
        ' 
        ' txtg
        ' 
        txtg.Location = New Point(116, 36)
        txtg.Name = "txtg"
        txtg.Size = New Size(100, 23)
        txtg.TabIndex = 12
        ' 
        ' txtname
        ' 
        txtname.Location = New Point(382, 36)
        txtname.Name = "txtname"
        txtname.Size = New Size(250, 23)
        txtname.TabIndex = 13
        ' 
        ' txtedad
        ' 
        txtedad.Location = New Point(369, 169)
        txtedad.Name = "txtedad"
        txtedad.Size = New Size(100, 23)
        txtedad.TabIndex = 14
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(84, 116)
        Button1.Name = "Button1"
        Button1.Size = New Size(75, 23)
        Button1.TabIndex = 15
        Button1.Text = "Calcular"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(226, 116)
        Button2.Name = "Button2"
        Button2.Size = New Size(75, 23)
        Button2.TabIndex = 16
        Button2.Text = "Limpiar"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Form3
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(txtedad)
        Controls.Add(txtname)
        Controls.Add(txtg)
        Controls.Add(txtd)
        Controls.Add(txth)
        Controls.Add(txtm)
        Controls.Add(txts)
        Controls.Add(lblh)
        Controls.Add(lblmeses)
        Controls.Add(lbls)
        Controls.Add(lbld)
        Controls.Add(lbledad)
        Controls.Add(lblname)
        Controls.Add(lblhombre)
        Controls.Add(lblf)
        Name = "Form3"
        Text = "Form3"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblf As Label
    Friend WithEvents lblhombre As Label
    Friend WithEvents lblname As Label
    Friend WithEvents lbledad As Label
    Friend WithEvents lbld As Label
    Friend WithEvents lbls As Label
    Friend WithEvents lblmeses As Label
    Friend WithEvents lblh As Label
    Friend WithEvents txts As TextBox
    Friend WithEvents txtm As TextBox
    Friend WithEvents txth As TextBox
    Friend WithEvents txtd As TextBox
    Friend WithEvents txtg As TextBox
    Friend WithEvents txtname As TextBox
    Friend WithEvents txtedad As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
End Class
