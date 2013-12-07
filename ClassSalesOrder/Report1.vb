Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms
Imports Telerik.Reporting
Imports Telerik.Reporting.Drawing

Partial Public Class Report1
    Inherits Telerik.Reporting.Report
    Public Sub New()
        InitializeComponent()
    End Sub
    'Moved to SOItems.vb
    'Public Shared Function Str_to_Array(ByVal str1 As Object) As Array
    '    Return str1.ToString.Split(",")
    'End Function

End Class