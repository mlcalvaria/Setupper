Imports System.IO

Module AbrechnungsauswertungSE

    Public Sub installAbrechnungsauswertungSE()
        Dim abPath As String = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles), "Robert Müller GmbH\Abrechnungsauswertung AB")
        Dim sePath As String = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles), "Robert Müller GmbH\Abrechnungsauswertung SE .NET")
        Dim abApp As String = Path.Combine(_path, "Abrechnungsauswertung AB")
        Dim seApp As String = Path.Combine(_path, "Abrechnungsauswertung SE")

        createFolder(abPath)
        createFolder(sePath)

        For Each item In Directory.GetFiles(abApp)
            File.Copy(item, Path.Combine(abPath, Path.GetFileName(item)), True)
        Next

        For Each item In Directory.GetFiles(seApp)
            File.Copy(item, Path.Combine(sePath, Path.GetFileName(item)), True)
        Next

        create_shortcut("Abrechnungsauswertung SE", Path.Combine(abPath, "Updater.exe"))

    End Sub

End Module
