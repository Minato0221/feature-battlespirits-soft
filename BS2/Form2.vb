Public Class Form2
    Public Shared card = "TEST"
    Sub first_Load() Handles MyBase.Load
        Field_action.Items.Add("コア移動")
        before_core.Items.Add("他のカード")
        before_core.Items.Add("リザーブ")
        before_core.Items.Add("トラッシュ")
        before_core.Items.Add("ボイド")
        before_core.Items.Add("ライフ")
        after_core.Items.Add("他のカード")
        after_core.Items.Add("リザーブ")
        after_core.Items.Add("トラッシュ")
        after_core.Items.Add("ボイド")
        after_core.Items.Add("ライフ")
        If Form1.ListBox1.SelectedItem IsNot Nothing Then
            If card_place_is_feild(Form1.ListBox1.SelectedItem) Then
                Field_action.Items.Add("回復")
                Field_action.Items.Add("疲労")
                Field_action.Items.Add("重疲労")
                Field_action.Items.Add("トラッシュ")
                Field_action.Items.Add("バウンス(山札)")
                Field_action.Items.Add("バウンス(手札)")
                Field_action.Items.Add("バウンス(手元)")
                before_core.Items.Add("このカード")
                after_core.Items.Add("このカード")
            End If

            For i = 0 To Form1.spirit_list.count - 1
                If Form1.spirit_list(i).name = Form1.hash_spirit_list(Form1.ListBox1.SelectedItem) Then
                    PictureBox1.ImageLocation = Form1.spirit_list(i).path
                    PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
                    Not_selected.Visible = False
                Else
                    split_list.Items.Add(Form1.spirit_list(i).name)
                End If
            Next
        End If
    End Sub

    Sub last_Load() Handles MyBase.Closed
        Form1.Enabled = True
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
    End Sub

    Private Sub Field_action_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Field_action.SelectedIndexChanged
        If Field_action.SelectedItem Is "コア移動" Then
            before_core.Enabled = True
            after_core.Enabled = True
            core_num.Enabled = True
        Else
            before_core.Enabled = False
            after_core.Enabled = False
            core_num.Enabled = False
        End If
    End Sub

    Private Sub NumericUpDown1_ValueChanged(sender As Object, e As EventArgs) Handles core_num.ValueChanged

    End Sub

    Private Sub split_list_SelectedIndexChanged(sender As Object, e As EventArgs) Handles split_list.SelectedIndexChanged
        If split_list.SelectedItem IsNot Nothing Then
            For i = 0 To Form1.spirit_list.count - 1
                If Form1.spirit_list(i).name = split_list.SelectedItem Then
                    PictureBox1.ImageLocation = Form1.spirit_list(i).path
                    PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
                End If
            Next
        End If
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click

    End Sub

    Function card_place_is_feild(card_name)
        Dim card_place = False
        card_name = Form1.hash_spirit_list(card_name)
        Debug.WriteLine("--------------------card_place")
        Debug.WriteLine(card_name)
        For j = 0 To Form1.spirit_first_status.count - 1
            Debug.WriteLine(Form1.spirit_first_status(j).name & "," & Form1.spirit_first_status(j).place & ":" & card_name)
            If Form1.spirit_first_status(j).name Is card_name And Form1.spirit_first_status(j).place = 4 Then
                card_place = True
            End If
        Next
        Debug.WriteLine("end--------------------card_place")
        Return card_place
    End Function
End Class