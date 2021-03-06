Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
Namespace LoadImages
    Friend Class LoadImages

        Private imageFileLocation As String = _
        "C:\Documents and Settings\Toshiba User" & _
        "\My Documents\Visual Studio 2008\Projects\Chapter18\Image\"
        Private imageFilePrefix As String = "painting-almirah"
        Private numberImageFiles As Integer = 1
        Private imageFileType As String = ".jpg"
        Private maxImageSize As Integer = 10000
        Private conn As SqlConnection = Nothing
        Private cmd As SqlCommand = Nothing
        Shared Sub Main()
            Dim loader As New LoadImages()

            Try
                ' Open connection
                loader.OpenConnection()
                ' Create command
                loader.CreateCommand()
                ' Create table
                loader.CreateImageTable()
                ' Prepare insert
                loader.PrepareInsertImages()
                ' Insert images
                Dim i As Integer
                For i = 1 To loader.numberImageFiles
                    loader.ExecuteInsertImages(i)
                Next i
            Catch ex As Exception
                Console.WriteLine(ex.ToString())
            Finally
                loader.CloseConnection()
                Console.WriteLine("Press any key to continue......")
                Console.ReadLine()
            End Try
        End Sub
        Private Sub OpenConnection()
            ' Create connection
            conn = New SqlConnection("Server=.\sqlexpress;" & _
                   "Integrated Security=True;Database=tempdb")
            ' Open connection
            conn.Open()
        End Sub
        Private Sub CloseConnection()
            ' close connection
            conn.Close()
            Console.WriteLine("Connection Closed.")            
        End Sub
        Private Sub CreateCommand()
            cmd = New SqlCommand()
            cmd.Connection = conn
        End Sub
        Private Sub ExecuteCommand(ByVal cmdText As String)
            Dim cmdResult As Integer
            cmd.CommandText = cmdText
            Console.WriteLine("Executing command:")
            Console.WriteLine(cmd.CommandText)
            cmdResult = cmd.ExecuteNonQuery()
        End Sub

        Private Sub CreateImageTable()
            ExecuteCommand("CREATE Table imagetable" & _
                           "(imagefile nvarchar(20)," & _
                           "imagedata varbinary(max))")
        End Sub
        Private Sub PrepareInsertImages()
            cmd.CommandText = "" & ControlChars.CrLf & _
            "insert into imagetable" & ControlChars.CrLf & _
            "values (@imagefile, @imagedata)" & ControlChars.CrLf

            cmd.Parameters.Add("@imagefile", SqlDbType.NVarChar, 20)
            cmd.Parameters.Add("@imagedata", SqlDbType.Image, 1000000)

            cmd.Prepare()
        End Sub

        Private Sub ExecuteInsertImages(ByVal _
        imageFileNumber As Integer)
            Dim imageFileName As String = Nothing
            Dim imageImageData() As Byte = Nothing

            imageFileName = imageFilePrefix + _
            imageFileNumber.ToString() _
            & imageFileType
            imageImageData = LoadImageFile _
            (imageFileName, imageFileLocation, maxImageSize)

            cmd.Parameters("@imagefile").Value = imageFileName
            cmd.Parameters("@imagedata").Value = imageImageData

            ExecuteCommand(cmd.CommandText)
            Console.WriteLine(ControlChars.NewLine)
        End Sub
        Private Function LoadImageFile(ByVal fileName As String, _
        ByVal fileLocation As String, ByVal maxImageSize _
        As Integer) As Byte()
            Dim imagebytes() As Byte = Nothing
            Dim fullpath As String = fileLocation & fileName
            Console.WriteLine(ControlChars.NewLine)
            Console.WriteLine("Loading File:")
            Console.WriteLine(fullpath)
            Dim fs As New FileStream(fullpath, _
            FileMode.Open, FileAccess.Read)
            Dim br As New BinaryReader(fs)
            imagebytes = br.ReadBytes(maxImageSize)

            Console.WriteLine("Imagebytes has length {0} bytes.", _
                              imagebytes.GetLength(0))
            Console.WriteLine(ControlChars.NewLine)
            Return imagebytes
        End Function
    End Class
End Namespace

