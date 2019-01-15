Imports System.Runtime.InteropServices

Public Class Main

    <DllImport("user32.dll")>
    Private Shared Function SendMessage(hWnd As Integer, hMsg As Integer, wParam As Integer, lParam As Integer) As Integer
    End Function

    Protected Overrides Sub SetVisibleCore(ByVal value As Boolean)
        If Not IsHandleCreated Then
            CreateHandle()
            value = False
            Threading.Thread.Sleep(1000)
            SendMessage(Handle.ToInt32(), &H112, &HF170, 2)
        End If
        MyBase.SetVisibleCore(value)
        Application.Exit()
    End Sub

End Class
