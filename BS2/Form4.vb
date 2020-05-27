Public Class Form4
    Dim ofd As New OpenFileDialog
    Dim spi_con = New spirit_controller()
    Dim spirit_place As Integer
    Dim spirit_status As Integer
    Dim spirit_core As Integer

    Sub first_Load() Handles MyBase.Load
        'プルダウンの値を設定
        ComboBox1.Items.Add("手札")
        ComboBox1.Items.Add("手元(表向き)")
        ComboBox1.Items.Add("手元(裏向き)")
        ComboBox1.Items.Add("フィールド")
        ComboBox1.Items.Add("トラッシュ")
        ComboBox1.Items.Add("山札")
        ComboBox2.Items.Add("回復")
        ComboBox2.Items.Add("疲労")
        ComboBox2.Items.Add("重疲労")
    End Sub
    Sub last_Load() Handles MyBase.Closed
        Form1.Enabled = True
    End Sub
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        '値を登録する
        spirit_place = spi_con.code_spirit_place(ComboBox1.SelectedItem)
        'フィールド以外にカードの状態を設定できないようにする。
        If (ComboBox1.SelectedItem = "フィールド") Then
            ComboBox2.Enabled = True
        Else
            ComboBox2.Enabled = False
        End If
    End Sub
    Private Sub card_value_change()
        Debug.WriteLine(ComboBox1.SelectedItem)
        If (ComboBox1.SelectedItem Is "フィールド") Then
            spirit_core = core_num.Value
        Else
            spirit_core = 0
        End If
        If (ComboBox1.SelectedItem Is "フィールド") Then
            If (ComboBox2.SelectedItem IsNot Nothing) Then
                spirit_status = spi_con.code_spirit_status(ComboBox2.SelectedItem)
            End If
        End If
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        '　ファイルを選択せずに終了したときに追加しない
        Debug.WriteLine("bform:" & spirit_place & "," & spirit_status & "," & spirit_core)
        If ComboBox1.SelectedItem IsNot Nothing Then
            If ofd.FileName IsNot "" Or (ComboBox1.SelectedItem Is "フィールド" And ComboBox2.SelectedItem IsNot Nothing) Then
                Dim spirit_name = name_chenge()

                'スピリットの情報のインスタンスを作成
                Dim spirit As New spirit_info()
                spirit.path = ofd.FileName
                spirit.name = spirit_name
                Form1.spirit_list.add(spirit)

                'スピリットの状態の情報のインスタンスを作成
                Dim spirit_status_info As New spirit_first_status()
                card_value_change()
                spirit_status_info.name = spirit_name
                spirit_status_info.place = spirit_place
                spirit_status_info.status = spirit_status
                spirit_status_info.core = spirit_core
                Debug.WriteLine("form:" & spirit_status_info.place & "," & spirit_status_info.status & "," & spirit_status_info.core)
                Form1.spirit_first_status.add(spirit_status_info)
                Me.Close()
            End If
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'ファイル選択ダイアログを開いて、ファイルを選択する
        ofd.ShowDialog()
        PictureBox1.ImageLocation = ofd.FileName
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        'not_selectedを消す
        If ofd.FileName <> "" Then
            Not_selected.Visible = False
        End If
    End Sub
    Function name_chenge() As String
        Dim spirit_name
        Dim counter = 1
        For i = 0 To Form1.spirit_list.count - 1
            ' 名前 (1) を見る
            Dim spirit_name_counted = System.IO.Path.GetFileNameWithoutExtension(ofd.FileName) & " (" & counter & ")"
            ' 名前が同じなのを見て、名前を変える
            If Form1.spirit_list(i).name = System.IO.Path.GetFileNameWithoutExtension(ofd.FileName) Or Form1.spirit_list(i).name = spirit_name_counted Then
                counter += 1
            End If
        Next
        If counter >= 2 Then
            spirit_name = System.IO.Path.GetFileNameWithoutExtension(ofd.FileName) & " (" & counter & ")"
        Else
            spirit_name = System.IO.Path.GetFileNameWithoutExtension(ofd.FileName)
        End If

        Return spirit_name
    End Function

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub
End Class