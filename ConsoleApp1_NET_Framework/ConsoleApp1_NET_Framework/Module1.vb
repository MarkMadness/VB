Module Module1

    Sub Main()
        'Console.WriteLine("Hello World!")
        'Console.Write("Today is...")
        'Console.ForegroundColor = ConsoleColor.Red
        'Console.Write(DateTime.Now.DayOfWeek.ToString)
        'Console.ResetColor()
        'Console.Read()

        'This will endlessly loop the program until the user licks the "X" button to close the window
        'Do

        'Loop While True

        Dim counter = 2
        Dim outputString
        Dim currentChar = "-"c
        Do
            counter = counter + 1
            If counter > 30 Then
                counter = 2
            End If
            If Console.KeyAvailable Then
                currentChar = Console.ReadKey.KeyChar
            End If
            outputString = New String(currentChar, counter)
            Console.WriteLine(outputString)
            Threading.Thread.Sleep(600)
        Loop While currentChar <> " "c


    End Sub

End Module
