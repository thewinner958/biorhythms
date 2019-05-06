<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBiorhythms
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
        Me.lblHead = New System.Windows.Forms.Label()
        Me.lblDOB = New System.Windows.Forms.Label()
        Me.BirthDay = New System.Windows.Forms.DateTimePicker()
        Me.Physical = New System.Windows.Forms.RadioButton()
        Me.Emotional = New System.Windows.Forms.RadioButton()
        Me.Intellectual = New System.Windows.Forms.RadioButton()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblHead
        '
        Me.lblHead.AutoSize = True
        Me.lblHead.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHead.ForeColor = System.Drawing.SystemColors.Highlight
        Me.lblHead.Location = New System.Drawing.Point(30, 29)
        Me.lblHead.Name = "lblHead"
        Me.lblHead.Size = New System.Drawing.Size(191, 24)
        Me.lblHead.TabIndex = 0
        Me.lblHead.Text = "Biorhythms Calculator"
        '
        'lblDOB
        '
        Me.lblDOB.AutoSize = True
        Me.lblDOB.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDOB.Location = New System.Drawing.Point(31, 76)
        Me.lblDOB.Name = "lblDOB"
        Me.lblDOB.Size = New System.Drawing.Size(103, 18)
        Me.lblDOB.TabIndex = 1
        Me.lblDOB.Text = "Date of Birth"
        '
        'BirthDay
        '
        Me.BirthDay.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.BirthDay.Location = New System.Drawing.Point(220, 74)
        Me.BirthDay.Name = "BirthDay"
        Me.BirthDay.Size = New System.Drawing.Size(114, 20)
        Me.BirthDay.TabIndex = 2
        '
        'Physical
        '
        Me.Physical.AutoSize = True
        Me.Physical.Location = New System.Drawing.Point(34, 159)
        Me.Physical.Name = "Physical"
        Me.Physical.Size = New System.Drawing.Size(92, 17)
        Me.Physical.TabIndex = 3
        Me.Physical.TabStop = True
        Me.Physical.Text = "Physical State"
        Me.Physical.UseVisualStyleBackColor = True
        '
        'Emotional
        '
        Me.Emotional.AutoSize = True
        Me.Emotional.Location = New System.Drawing.Point(34, 219)
        Me.Emotional.Name = "Emotional"
        Me.Emotional.Size = New System.Drawing.Size(99, 17)
        Me.Emotional.TabIndex = 4
        Me.Emotional.TabStop = True
        Me.Emotional.Text = "Emotional State"
        Me.Emotional.UseVisualStyleBackColor = True
        '
        'Intellectual
        '
        Me.Intellectual.AutoSize = True
        Me.Intellectual.Location = New System.Drawing.Point(34, 279)
        Me.Intellectual.Name = "Intellectual"
        Me.Intellectual.Size = New System.Drawing.Size(104, 17)
        Me.Intellectual.TabIndex = 5
        Me.Intellectual.TabStop = True
        Me.Intellectual.Text = "Intellectual State"
        Me.Intellectual.UseVisualStyleBackColor = True
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(34, 319)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(90, 23)
        Me.btnCalculate.TabIndex = 6
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'frmBiorhythms
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(387, 386)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.Intellectual)
        Me.Controls.Add(Me.Emotional)
        Me.Controls.Add(Me.Physical)
        Me.Controls.Add(Me.BirthDay)
        Me.Controls.Add(Me.lblDOB)
        Me.Controls.Add(Me.lblHead)
        Me.Name = "frmBiorhythms"
        Me.Text = "Biorhythms"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblHead As Label
    Friend WithEvents lblDOB As Label
    Friend WithEvents BirthDay As DateTimePicker
    Friend WithEvents Physical As RadioButton
    Friend WithEvents Emotional As RadioButton
    Friend WithEvents Intellectual As RadioButton
    Friend WithEvents btnCalculate As Button
End Class
