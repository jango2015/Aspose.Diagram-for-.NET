﻿
Imports Aspose.Diagram
Imports System
Imports Aspose.Diagram.Saving

Public Class ExportOfHiddenVisioPagesToHTML
    Public Shared Sub Run()
        Try
            ' ExStart:ExportOfHiddenVisioPagesToHTML
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_Intro()

            ' Load an existing Visio
            Dim diagram As New Diagram(dataDir & Convert.ToString("Drawing1.vsdx"))
            ' Get a particular page
            Dim page As Page = diagram.Pages.GetPage("Flow 2")
            ' Set Visio page visiblity
            page.PageSheet.PageProps.UIVisibility.Value = BOOL.True
            ' Initialize PDF save options
            Dim options As New HTMLSaveOptions()
            ' Set export option of hidden Visio pages
            options.ExportHiddenPage = False

            ' Save the Visio diagram
            diagram.Save(dataDir & Convert.ToString("ExportOfHiddenVisioPagesToHTML_Out.html"), options)
            ' ExEnd:ExportOfHiddenVisioPagesToHTML
        Catch ex As System.Exception
            System.Console.WriteLine("This example will only work if you apply a valid Aspose License. You can purchase full license or get 30 day temporary license from http://www.aspose.com/purchase/default.aspx.")
        End Try
    End Sub
End Class