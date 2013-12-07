Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms
Imports Telerik.Reporting
Imports Telerik.Reporting.Drawing

Partial Public Class SOitems
    Inherits Telerik.Reporting.Report
    Public Sub New()
        InitializeComponent()
    End Sub
    ' Call this Function as Str_to_Array("OH,IC,CL,CA,SC,CP")
    ' Split will parse string to array based on delimiter i.e. ","
    Public Shared Function Str_to_Array(ByVal str1 As Object) As Array
        Return str1.ToString.Split(",")
    End Function
End Class