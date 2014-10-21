Imports System.IO

Module Functions

    Public Function foldername(ByVal folder As String) As String

        Dim result As String = ""

        For Each chara In folder
            result &= chara
            If chara = "\" Then
                result = ""
            End If
        Next
        Return result

    End Function

    Public Sub createFolder(ByVal path As String)
        If (Not System.IO.Directory.Exists(path)) Then
            System.IO.Directory.CreateDirectory(path)
        End If
    End Sub

    Public Sub create_shortcut(ByVal shortcutName As String, ByVal AppPath As String)
        Dim wsh As Object = CreateObject("WScript.Shell")
        Dim MyShortcut, DesktopPath

        wsh = CreateObject("WScript.Shell")

        ' Read desktop path using WshSpecialFolders object
        DesktopPath = wsh.SpecialFolders("Desktop")
        ' Create a shortcut object on the desktop
        MyShortcut = wsh.CreateShortcut(Path.Combine(DesktopPath, shortcutName & ".lnk"))
        ' Set shortcut object properties and save it
        MyShortcut.TargetPath = wsh.ExpandEnvironmentStrings(AppPath)
        MyShortcut.WorkingDirectory = wsh.ExpandEnvironmentStrings("C:\")
        MyShortcut.WindowStyle = 4
        'Use this next line to assign a icon other then the default icon for the exe
        'MyShortcut.IconLocation = "%SystemRoot%\system32\SHELL32.dll,44"
        'Save the shortcut
        MyShortcut.Save()

    End Sub

End Module
