<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.btnEat = New System.Windows.Forms.Button()
        Me.btnWork = New System.Windows.Forms.Button()
        Me.btnExercise = New System.Windows.Forms.Button()
        Me.btnIncreaseIncome = New System.Windows.Forms.Button()
        Me.lblWeight = New System.Windows.Forms.Label()
        Me.lblMoney = New System.Windows.Forms.Label()
        Me.lblIncome = New System.Windows.Forms.Label()
        Me.btnNewPerson = New System.Windows.Forms.Button()
        Me.listPeople = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'btnEat
        '
        Me.btnEat.Location = New System.Drawing.Point(725, 217)
        Me.btnEat.Name = "btnEat"
        Me.btnEat.Size = New System.Drawing.Size(150, 46)
        Me.btnEat.TabIndex = 0
        Me.btnEat.Text = "eat"
        Me.btnEat.UseVisualStyleBackColor = True
        '
        'btnWork
        '
        Me.btnWork.Location = New System.Drawing.Point(725, 311)
        Me.btnWork.Name = "btnWork"
        Me.btnWork.Size = New System.Drawing.Size(150, 46)
        Me.btnWork.TabIndex = 1
        Me.btnWork.Text = "work"
        Me.btnWork.UseVisualStyleBackColor = True
        '
        'btnExercise
        '
        Me.btnExercise.Location = New System.Drawing.Point(725, 423)
        Me.btnExercise.Name = "btnExercise"
        Me.btnExercise.Size = New System.Drawing.Size(150, 46)
        Me.btnExercise.TabIndex = 2
        Me.btnExercise.Text = "exercise"
        Me.btnExercise.UseVisualStyleBackColor = True
        '
        'btnIncreaseIncome
        '
        Me.btnIncreaseIncome.Location = New System.Drawing.Point(725, 513)
        Me.btnIncreaseIncome.Name = "btnIncreaseIncome"
        Me.btnIncreaseIncome.Size = New System.Drawing.Size(196, 46)
        Me.btnIncreaseIncome.TabIndex = 3
        Me.btnIncreaseIncome.Text = "increase income"
        Me.btnIncreaseIncome.UseVisualStyleBackColor = True
        '
        'lblWeight
        '
        Me.lblWeight.AutoSize = True
        Me.lblWeight.Location = New System.Drawing.Point(12, 54)
        Me.lblWeight.Name = "lblWeight"
        Me.lblWeight.Size = New System.Drawing.Size(182, 32)
        Me.lblWeight.TabIndex = 4
        Me.lblWeight.Text = "Current Weight:"
        '
        'lblMoney
        '
        Me.lblMoney.AutoSize = True
        Me.lblMoney.Location = New System.Drawing.Point(332, 54)
        Me.lblMoney.Name = "lblMoney"
        Me.lblMoney.Size = New System.Drawing.Size(181, 32)
        Me.lblMoney.TabIndex = 5
        Me.lblMoney.Text = "Current Money:"
        '
        'lblIncome
        '
        Me.lblIncome.AutoSize = True
        Me.lblIncome.Location = New System.Drawing.Point(635, 54)
        Me.lblIncome.Name = "lblIncome"
        Me.lblIncome.Size = New System.Drawing.Size(185, 32)
        Me.lblIncome.TabIndex = 6
        Me.lblIncome.Text = "Current Income:"
        '
        'btnNewPerson
        '
        Me.btnNewPerson.Location = New System.Drawing.Point(725, 128)
        Me.btnNewPerson.Name = "btnNewPerson"
        Me.btnNewPerson.Size = New System.Drawing.Size(150, 46)
        Me.btnNewPerson.TabIndex = 7
        Me.btnNewPerson.Text = "New Person"
        Me.btnNewPerson.UseVisualStyleBackColor = True
        '
        'listPeople
        '
        Me.listPeople.FormattingEnabled = True
        Me.listPeople.ItemHeight = 32
        Me.listPeople.Location = New System.Drawing.Point(12, 139)
        Me.listPeople.Name = "listPeople"
        Me.listPeople.Size = New System.Drawing.Size(659, 420)
        Me.listPeople.TabIndex = 8
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(13.0!, 32.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(957, 594)
        Me.Controls.Add(Me.listPeople)
        Me.Controls.Add(Me.btnNewPerson)
        Me.Controls.Add(Me.lblIncome)
        Me.Controls.Add(Me.lblMoney)
        Me.Controls.Add(Me.lblWeight)
        Me.Controls.Add(Me.btnIncreaseIncome)
        Me.Controls.Add(Me.btnExercise)
        Me.Controls.Add(Me.btnWork)
        Me.Controls.Add(Me.btnEat)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnEat As Button
    Friend WithEvents btnWork As Button
    Friend WithEvents btnExercise As Button
    Friend WithEvents btnIncreaseIncome As Button
    Friend WithEvents lblWeight As Label
    Friend WithEvents lblMoney As Label
    Friend WithEvents lblIncome As Label
    Friend WithEvents btnNewPerson As Button
    Friend WithEvents listPeople As ListBox
End Class
