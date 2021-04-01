Imports System

Module Program
    Sub Main(args As String())
        Console.WriteLine("Hello World!")
        Console.Write("Today is...")
        Console.ForegroundColor = ConsoleColor.Red
        Console.Write(DateTime.Now.DayOfWeek.ToString)
        Console.ResetColor()
        Console.Read()
    End Sub
End Module
