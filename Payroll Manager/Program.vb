Imports System.Windows.Forms

Public Module Program
    Sub Main()
#If Not WindowsCE Then
        Application.EnableVisualStyles()
        Application.SetCompatibleTextRenderingDefault(False)
        Application.EnableVisualStyles()
#End If
        Application.Run(New BiometricsScan())
    End Sub
End Module