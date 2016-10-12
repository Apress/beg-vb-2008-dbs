Imports System
Imports System.Text
Imports System.Linq
Imports System.Collections.Generic

Namespace Chapter19
    Class LinqToObjects
        Shared Sub Main(ByVal args As String())

            Dim names As String() = {"James Huddleston", "Pearly", _
            "Rupali Agarwal", "Fabio Claudio", "Vamika Agarwal", _
            "Sofia Merchant", "Vidya Vrat Agarwal"}
            'Dim name As String
            Dim namesOfPeople As IEnumerable(Of String) = _
            From name In names _
            Where (name.Length <= 16) _
            Select name

            For Each name In namesOfPeople
                Console.WriteLine(name)
            Next
        End Sub
    End Class
End Namespace
