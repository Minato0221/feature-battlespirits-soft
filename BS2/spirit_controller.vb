Public Class spirit_controller

    Function spirit_place(place)
        Dim place_name = "not_set"
        If place = 1 Then
            place_name = "手札"
        End If
        If place = 2 Then
            place_name = "手元(表向き)"
        End If
        If place = 3 Then
            place_name = "手元(裏向き)"
        End If
        If place = 4 Then
            place_name = "フィールド"
        End If
        If place = 5 Then
            place_name = "トラッシュ"
        End If
        If place = 6 Then
            place_name = "山札"
        End If
        Return place_name
    End Function
    Function spirit_status(status)
        Dim status_name = "not_set"
        If status = 1 Then
            status_name = "回復"
        End If
        If status = 2 Then
            status_name = "疲労"
        End If
        If status = 3 Then
            status_name = "重疲労"
        End If
        Return status_name
    End Function
    Function code_spirit_place(place_name)
        Dim place = "not_set"
        If place_name = "手札" Then
            place = 1
        End If
        If place_name = "手元(表向き)" Then
            place = 2
        End If
        If place_name = "手元(裏向き)" Then
            place = 3
        End If
        If place_name = "フィールド" Then
            place = 4
        End If
        If place_name = "トラッシュ" Then
            place = 5
        End If
        If place_name = "山札" Then
            place = 6
        End If
        Return place
    End Function

    Function code_spirit_status(status_name)
        Dim status = "not_set"
        If status_name = "回復" Then
            status = 1
        End If
        If status_name = "疲労" Then
            status = 2
        End If
        If status_name = "重疲労" Then
            status = 3
        End If
        Return status
    End Function
End Class
