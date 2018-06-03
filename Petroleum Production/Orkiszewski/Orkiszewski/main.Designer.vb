<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class main
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.T_H = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.T_T = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.T_D = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.T_p_b = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.T_p = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.T_gama_g = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.T_gama_o = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.T_Q_g = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.T_Q_o = New System.Windows.Forms.TextBox()
        Me.calc = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.T_H)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.T_T)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.T_D)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.T_p_b)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.T_p)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.T_gama_g)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.T_gama_o)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.T_Q_g)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.T_Q_o)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(264, 359)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "入口参数"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(114, 299)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(47, 12)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "井深(m)"
        '
        'T_H
        '
        Me.T_H.Location = New System.Drawing.Point(7, 291)
        Me.T_H.Name = "T_H"
        Me.T_H.Size = New System.Drawing.Size(100, 21)
        Me.T_H.TabIndex = 16
        Me.T_H.Text = "3000"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(112, 257)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(77, 12)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "井口温度(℃)"
        '
        'T_T
        '
        Me.T_T.Location = New System.Drawing.Point(6, 254)
        Me.T_T.Name = "T_T"
        Me.T_T.Size = New System.Drawing.Size(100, 21)
        Me.T_T.TabIndex = 14
        Me.T_T.Text = "25"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(112, 218)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(77, 12)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "油管内径(mm)"
        '
        'T_D
        '
        Me.T_D.Location = New System.Drawing.Point(6, 215)
        Me.T_D.Name = "T_D"
        Me.T_D.Size = New System.Drawing.Size(100, 21)
        Me.T_D.TabIndex = 12
        Me.T_D.Text = "62"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(112, 187)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(107, 12)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "原油饱和压力(MPa)"
        '
        'T_p_b
        '
        Me.T_p_b.Location = New System.Drawing.Point(6, 184)
        Me.T_p_b.Name = "T_p_b"
        Me.T_p_b.Size = New System.Drawing.Size(100, 21)
        Me.T_p_b.TabIndex = 10
        Me.T_p_b.Text = "8.66"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(112, 156)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(59, 12)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "油压(MPa)"
        '
        'T_p
        '
        Me.T_p.Location = New System.Drawing.Point(6, 153)
        Me.T_p.Name = "T_p"
        Me.T_p.Size = New System.Drawing.Size(100, 21)
        Me.T_p.TabIndex = 8
        Me.T_p.Text = "2.352"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(112, 125)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(89, 12)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "天然气相对密度"
        '
        'T_gama_g
        '
        Me.T_gama_g.Location = New System.Drawing.Point(6, 122)
        Me.T_gama_g.Name = "T_gama_g"
        Me.T_gama_g.Size = New System.Drawing.Size(100, 21)
        Me.T_gama_g.TabIndex = 6
        Me.T_gama_g.Text = "0.65"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(112, 94)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 12)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "原油相对密度"
        '
        'T_gama_o
        '
        Me.T_gama_o.Location = New System.Drawing.Point(6, 91)
        Me.T_gama_o.Name = "T_gama_o"
        Me.T_gama_o.Size = New System.Drawing.Size(100, 21)
        Me.T_gama_o.TabIndex = 4
        Me.T_gama_o.Text = "0.85"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(112, 63)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 12)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "产气量(m^3/d)"
        '
        'T_Q_g
        '
        Me.T_Q_g.Location = New System.Drawing.Point(6, 60)
        Me.T_Q_g.Name = "T_Q_g"
        Me.T_Q_g.Size = New System.Drawing.Size(100, 21)
        Me.T_Q_g.TabIndex = 2
        Me.T_Q_g.Text = "2027.4"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(112, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 12)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "产油量(m^3/d)"
        '
        'T_Q_o
        '
        Me.T_Q_o.Location = New System.Drawing.Point(6, 29)
        Me.T_Q_o.Name = "T_Q_o"
        Me.T_Q_o.Size = New System.Drawing.Size(100, 21)
        Me.T_Q_o.TabIndex = 0
        Me.T_Q_o.Text = "38"
        '
        'calc
        '
        Me.calc.Location = New System.Drawing.Point(309, 146)
        Me.calc.Name = "calc"
        Me.calc.Size = New System.Drawing.Size(190, 80)
        Me.calc.TabIndex = 1
        Me.calc.Text = "计算"
        Me.calc.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(307, 251)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(65, 12)
        Me.Label10.TabIndex = 2
        Me.Label10.Text = "作者：都旭"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(307, 277)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(131, 12)
        Me.Label11.TabIndex = 3
        Me.Label11.Text = "版权所有@西南石油大学"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(307, 303)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(113, 12)
        Me.Label12.TabIndex = 4
        Me.Label12.Text = "联系QQ：1178946575"
        '
        'main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(521, 433)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.calc)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "main"
        Me.Text = "Orkiszewski Tool"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents T_Q_o As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents T_Q_g As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents T_gama_g As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents T_gama_o As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents T_p As TextBox
    Friend WithEvents T_D As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents T_p_b As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents calc As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents T_T As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents T_H As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
End Class
