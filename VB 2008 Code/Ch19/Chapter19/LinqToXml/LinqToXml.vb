﻿Imports System
Imports System.Linq
Imports System.Xml.Linq


Namespace Chapter19
    Class LinqToXml
        Shared Sub Main(ByVal args() As String)
            'load the productstable.xml in memory
            Dim doc As XElement = XElement.Load _
            ("C:\Documents and Settings" & _
            "\Toshiba User\My Documents\Visual Studio 2008" & _
            "\Projects\Chapter19\productstable.xml")
            'Dim prodname As VariantType
            'query xml doc
            Dim products = From prodname In doc.Descendants("products") _
             Select prodname.Value

            'display details
            For Each prodname In products
                Console.WriteLine("Product's Detail = {0}", prodname)
            Next
        End Sub
    End Class
End Namespace
