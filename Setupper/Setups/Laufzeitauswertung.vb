Imports System.IO

Module Laufzeitauswertung

    Public Sub installLaufzeitauswertung()
        Dim auswertPath As String = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles), "Laufzeitauswertung")
        Dim auswertApp As String = Path.Combine(_path, "Laufzeitauswertung")

        createFolder(auswertPath)

        My.Computer.FileSystem.DeleteDirectory(auswertPath, FileIO.DeleteDirectoryOption.DeleteAllContents)

        My.Computer.FileSystem.CopyDirectory(auswertApp, auswertPath)

        create_shortcut("Laufzeitauswertung", Path.Combine(auswertPath, "Auswert_Neu_Vor.exe"))

    End Sub

End Module
