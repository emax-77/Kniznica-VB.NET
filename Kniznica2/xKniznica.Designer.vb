﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class xKniznica
    Inherits DevExpress.XtraEditors.XtraForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(xKniznica))
        Me.SuspendLayout()
        '
        'xKniznica
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1918, 1048)
        Me.IconOptions.LargeImage = CType(resources.GetObject("xKniznica.IconOptions.LargeImage"), System.Drawing.Image)
        Me.IsMdiContainer = True
        Me.Name = "xKniznica"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "xKniznica"
        Me.ResumeLayout(False)

    End Sub
End Class
