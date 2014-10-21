Public Class Form1

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        ListView1.View = View.Details
        ListView1.AllowColumnReorder = True
        ListView1.CheckBoxes = True
        ListView1.FullRowSelect = True
        ListView1.Sorting = SortOrder.Ascending

        lvInitial.setHead(ListView1, "Programm")

        lvInitial.fillLV(ListView1)

    End Sub

    Private Sub cmdStart_Click(sender As System.Object, e As System.EventArgs) Handles cmdStart.Click

        For Each item In ListView1.Items
            If item.Checked Then
                Select Case item.Text
                    Case "Abrechnungsauswertung AB"
                        installAbrechnungsauswertungAB()
                    Case "Abrechnungsauswertung SE"
                        installAbrechnungsauswertungSE()
                    Case "Charter"
                        installCharter()
                    Case "Laufzeitauswertung"
                        installLaufzeitauswertung()
                End Select
            End If
        Next

    End Sub
End Class