<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.add_card = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.ListBox2 = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'add_card
        '
        Me.add_card.Location = New System.Drawing.Point(499, 41)
        Me.add_card.Name = "add_card"
        Me.add_card.Size = New System.Drawing.Size(173, 107)
        Me.add_card.TabIndex = 0
        Me.add_card.Text = "カードを追加する"
        Me.add_card.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(501, 151)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(171, 251)
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(322, 408)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(352, 40)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "スタート"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(322, 129)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(173, 19)
        Me.Button3.TabIndex = 4
        Me.Button3.Text = "カードリストを更新する"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(322, 41)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(173, 82)
        Me.Button4.TabIndex = 5
        Me.Button4.Text = "アクションを設定する"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'ListBox2
        '
        Me.ListBox2.FormattingEnabled = True
        Me.ListBox2.ItemHeight = 12
        Me.ListBox2.Location = New System.Drawing.Point(12, 24)
        Me.ListBox2.Name = "ListBox2"
        Me.ListBox2.Size = New System.Drawing.Size(304, 424)
        Me.ListBox2.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(383, 151)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 12)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "カードリスト"
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 12
        Me.ListBox1.Location = New System.Drawing.Point(322, 170)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(172, 208)
        Me.ListBox1.TabIndex = 10
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("MS UI Gothic", 20.0!)
        Me.Label2.Location = New System.Drawing.Point(426, 11)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(150, 27)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "メインメニュー"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(321, 381)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(173, 21)
        Me.Button1.TabIndex = 23
        Me.Button1.Text = "選択を解除する"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(112, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 12)
        Me.Label3.TabIndex = 24
        Me.Label3.Text = "アクションリスト"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(684, 461)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ListBox2)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.add_card)
        Me.Name = "Form1"
        Me.ShowIcon = False
        Me.Text = "Form1"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents add_card As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents ListBox2 As ListBox
    Friend WithEvents Label1 As Label
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label3 As Label
End Class
