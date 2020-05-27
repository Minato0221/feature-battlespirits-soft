Public Class action_controller
    Function field_action(field)
        Dim field_num = 0
        If field Is "回復" Then
            field_num = 1
        End If
        If field Is "疲労" Then
            field_num = 2
        End If
        If field Is "重疲労" Then
            field_num = 3
        End If
        If field Is "トラッシュ" Then
            field_num = 4
        End If
        If field Is "バウンス(山札)" Then
            field_num = 5
        End If
        If field Is "バウンス(手札)" Then
            field_num = 6
        End If
        If field Is "バウンス(手元)" Then
            field_num = 7
        End If
        If field Is "コア移動" Then
            field_num = 8
        End If
        Return field_num
    End Function
    Function before_core(core)
        Dim core_num = 0
        If core Is "このカード" Then
            core_num = 1
        End If
        If core Is "他のカード" Then
            core_num = 2
        End If
        If core Is "リザーブ" Then
            core_num = 3
        End If
        If core Is "トラッシュ" Then
            core_num = 4
        End If
        If core Is "ボイド" Then
            core_num = 5
        End If
        If core Is "ライフ" Then
            core_num = 6
        End If
        Return core_num
    End Function
    Function after_core(core)
        Dim core_num = 0
        If core Is "このカード" Then
            core_num = 1
        End If
        If core Is "他のカード" Then
            core_num = 2
        End If
        If core Is "リザーブ" Then
            core_num = 3
        End If
        If core Is "トラッシュ" Then
            core_num = 4
        End If
        If core Is "ボイド" Then
            core_num = 5
        End If
        If core Is "ライフ" Then
            core_num = 6
        End If
        Return core_num
    End Function
    Function code_field_action(field)
        Dim field_num = 0
        If field = 1 Then
            field_num = "回復"
        End If
        If field = 2 Then
            field_num = "疲労"
        End If
        If field = 3 Then
            field_num = "重疲労"
        End If
        If field = 4 Then
            field_num = "トラッシュ"
        End If
        If field = 5 Then
            field_num = "バウンス(山札)"
        End If
        If field = 6 Then
            field_num = "バウンス(手札)"
        End If
        If field = 7 Then
            field_num = "バウンス(手元)"
        End If
        If field = 8 Then
            field_num = "コア移動"
        End If
        Return field_num
    End Function
    Function code_before_core(core)
        Dim core_num = 0
        If core = 1 Then
            core_num = "このカード"
        End If
        If core = 2 Then
            core_num = "他のカード"
        End If
        If core = 3 Then
            core_num = "リザーブ"
        End If
        If core = 4 Then
            core_num = "トラッシュ"
        End If
        If core = 5 Then
            core_num = "ボイド"
        End If
        If core = 6 Then
            core_num = "ライフ"
        End If
        Return core_num
    End Function
    Function code_after_core(core)
        Dim core_num = 0
        If core = 1 Then
            core_num = "このカード"
        End If
        If core = 2 Then
            core_num = "他のカード"
        End If
        If core = 3 Then
            core_num = "リザーブ"
        End If
        If core = 4 Then
            core_num = "トラッシュ"
        End If
        If core = 5 Then
            core_num = "ボイド"
        End If
        If core = 6 Then
            core_num = "ライフ"
        End If
        Return core_num
    End Function
End Class
