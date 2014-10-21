Imports System.IO

Module lvInitial
    Public _path As String = "C:\Users\luxenburgerm\Desktop\test"

    Public Sub setHead(ByRef _listview As Windows.Forms.ListView, ByVal heads As String)
        For Each head As String In Split(heads, ",")
            _listview.Columns.Add(head, -2, HorizontalAlignment.Left)
        Next
    End Sub

    Public Sub fillLV(ByRef _listview As Windows.Forms.ListView)
        Dim folders() As ListViewItem = {}
        Dim folderlength As Integer
        Dim item As ListViewItem

        For Each folder In Directory.GetDirectories(_path)

            item = New ListViewItem(foldername(folder))
            folderlength = folders.Length
            ReDim Preserve folders(folderlength)
            folders(folderlength) = item

        Next

        _listview.Items.AddRange(folders)

    End Sub

End Module
