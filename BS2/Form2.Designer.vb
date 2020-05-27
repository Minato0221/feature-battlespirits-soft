<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
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

    'Windows フォーム デザイナーで必要です。
    Private components As System.ComponentModel.IContainer

    'メモ: 以下のプロシージャは Windows フォーム デザイナーで必要です。
    'Windows フォーム デザイナーを使用して変更できます。  
    'コード エディターを使って変更しないでください。
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Not_selected = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.core_num = New System.Windows.Forms.NumericUpDown()
        Me.move_core_num = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Field_action = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.before_core = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.after_core = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.split_list = New System.Windows.Forms.ComboBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.core_num, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(3, 418)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(669, 31)
        Me.Button3.TabIndex = 4
        Me.Button3.Text = "戻る"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(12, 37)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(257, 375)
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'Not_selected
        '
        Me.Not_selected.AutoSize = True
        Me.Not_selected.Font = New System.Drawing.Font("MS UI Gothic", 25.0!)
        Me.Not_selected.Location = New System.Drawing.Point(43, 198)
        Me.Not_selected.Name = "Not_selected"
        Me.Not_selected.Size = New System.Drawing.Size(191, 34)
        Me.Not_selected.TabIndex = 14
        Me.Not_selected.Text = "not selected"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 12)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Not selected"
        '
        'core_num
        '
        Me.core_num.Location = New System.Drawing.Point(343, 94)
        Me.core_num.Name = "core_num"
        Me.core_num.Size = New System.Drawing.Size(329, 19)
        Me.core_num.TabIndex = 16
        '
        'move_core_num
        '
        Me.move_core_num.AutoSize = True
        Me.move_core_num.Location = New System.Drawing.Point(275, 96)
        Me.move_core_num.Name = "move_core_num"
        Me.move_core_num.Size = New System.Drawing.Size(58, 12)
        Me.move_core_num.TabIndex = 17
        Me.move_core_num.Text = "コア移動数"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(277, 377)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(395, 35)
        Me.Button1.TabIndex = 18
        Me.Button1.Text = "決定"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Field_action
        '
        Me.Field_action.FormattingEnabled = True
        Me.Field_action.Location = New System.Drawing.Point(378, 42)
        Me.Field_action.Name = "Field_action"
        Me.Field_action.Size = New System.Drawing.Size(294, 20)
        Me.Field_action.TabIndex = 19
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(275, 45)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(91, 12)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "フィールドアクション"
        '
        'before_core
        '
        Me.before_core.FormattingEnabled = True
        Me.before_core.Location = New System.Drawing.Point(343, 68)
        Me.before_core.Name = "before_core"
        Me.before_core.Size = New System.Drawing.Size(119, 20)
        Me.before_core.TabIndex = 21
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(482, 71)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 12)
        Me.Label4.TabIndex = 22
        Me.Label4.Text = "コア移動先"
        '
        'after_core
        '
        Me.after_core.FormattingEnabled = True
        Me.after_core.Location = New System.Drawing.Point(553, 68)
        Me.after_core.Name = "after_core"
        Me.after_core.Size = New System.Drawing.Size(119, 20)
        Me.after_core.TabIndex = 23
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(275, 71)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(58, 12)
        Me.Label5.TabIndex = 24
        Me.Label5.Text = "コア移動元"
        '
        'PictureBox2
        '
        Me.PictureBox2.Location = New System.Drawing.Point(277, 153)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(163, 218)
        Me.PictureBox2.TabIndex = 25
        Me.PictureBox2.TabStop = False
        '
        'split_list
        '
        Me.split_list.FormattingEnabled = True
        Me.split_list.Location = New System.Drawing.Point(275, 127)
        Me.split_list.Name = "split_list"
        Me.split_list.Size = New System.Drawing.Size(165, 20)
        Me.split_list.TabIndex = 26
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(684, 461)
        Me.Controls.Add(Me.split_list)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.after_core)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.before_core)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Field_action)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.move_core_num)
        Me.Controls.Add(Me.core_num)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Not_selected)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Button3)
        Me.Name = "Form2"
        Me.Text = "Form2"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.core_num, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button3 As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Not_selected As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents core_num As NumericUpDown
    Friend WithEvents move_core_num As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Field_action As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents before_core As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents after_core As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents split_list As ComboBox
End Class
