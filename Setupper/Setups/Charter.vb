Imports System.IO

Module Charter

    Public Sub installCharter()
        Dim setPath As String = Path.Combine(_path, "Charter\Charter_Setup\setup.exe")
        Dim appPath As String = Path.Combine(_path, "Charter\Charter")
        Dim chartpath As String = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles), "Charter")
        Dim success As Boolean = False

        createFolder(chartpath)

        Dim chartersetup As Process = Process.Start(setPath)

        chartersetup.WaitForExit()

        For Each item In Directory.GetFiles(appPath)
            Do
                Try
                    File.Copy(item, Path.Combine(chartpath, Path.GetFileName(item)), True)
                    success = Not success
                Catch ex As Exception

                End Try
            Loop While Not success

        Next

        create_shortcut("Charter", Path.Combine(appPath, "Charter Control.exe"))

    End Sub
End Module