Public Class Form1
    Public Shared spirit_list = New ArrayList()
    Public Shared spirit_first_status = New ArrayList()
    Public Shared card_name = New ArrayList()
    Public Shared card_action = New ArrayList()
    Dim s_c = New spirit_controller()
    Public Shared hash_spirit_list = New Hashtable()


    Sub this_class_Load() Handles MyBase.Load
    End Sub

    Sub card_list_update()
        'カードリストを更新するメソッド
        ListBox1.Items.Clear()
        hash_spirit_list.clear
        this_class_Load()
        For i = 0 To spirit_list.count - 1
            For j = 0 To spirit_first_status.count - 1
                If (spirit_first_status(j).name Is spirit_list(i).name) Then
                    hash_spirit_list.add(re_name(spirit_first_status(j)), spirit_first_status(j).name)
                    ListBox1.Items.Add(re_name(spirit_first_status(j)))
                End If
            Next
        Next
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles add_card.Click
        Dim f As New Form4()
        f.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim f As New Form3()
        f.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        card_list_update()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim f As New Form2()
        f.Show()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs)
        Dim f As New Form4()
        f.Show()
    End Sub

    Private Sub ListBox1_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        If ListBox1.SelectedItem IsNot Nothing Then
            For i = 0 To spirit_list.count - 1
                If spirit_list(i).name = hash_spirit_list(ListBox1.SelectedItem) Then
                    PictureBox1.ImageLocation = spirit_list(i).path
                    PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
                End If
            Next
        End If
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        ListBox1.ClearSelected()
        PictureBox1.ImageLocation = ""
    End Sub

    Function re_name(spirit)
        Dim name
        Debug.WriteLine(spirit.place & s_c.spirit_place(spirit.place))
        Debug.WriteLine(spirit.status & s_c.spirit_status(spirit.status))
        Debug.WriteLine(spirit.core)
        If (spirit.place = 4) Then
            name = spirit.name & "(" & s_c.spirit_place(spirit.place) & "," & s_c.spirit_status(spirit.status) & "," & spirit.core & ")"
        Else
            name = spirit.name & "(" & s_c.spirit_place(spirit.place) & ")"
        End If
        Return name
    End Function
End Class
