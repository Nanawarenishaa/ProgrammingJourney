Module day2_vbnet
    Sub Main()
        Dim number As Integer = 35
        Dim name As String = "Nisha"
        Dim isTrue As Boolean = True
        Dim floatNumber As Single = 55.5
        Dim doubleNumber As Double = 55.55
        Dim decimalNumber As Decimal = 78.9
        Dim charValue As Char = "A"
        Dim shortValue As Short = 67
        Dim longValue As Long = 645734
        Dim byteValue As Byte = 10
        Dim dateValue As Date = Now
        Dim dateTimeValue As DateTime = Now
        Dim arrayValue As Array = {1, 2, 3, 4, 5}
        Dim listValue As List(Of Integer) = New List(Of Integer) From {1, 2, 3, 4, 5}
        Dim dictionaryValue As Dictionary(Of String, Integer) = New Dictionary(Of String, Integer) From {{"One", 1}, {"Two", 2}, {"Three", 3}}
        Dim tupleValue As Tuple(Of Integer, String, Boolean) = New Tuple(Of Integer, String, Boolean)(1, "One", True)
        Dim keyValue As KeyValuePair(Of String, Integer) = New KeyValuePair(Of String, Integer)("One", 1)


        Console.WriteLine("Number:" & number)
        Console.WriteLine("Name:" & name)
        Console.WriteLine("Is True:" & isTrue)
        Console.WriteLine("Float Number:" & floatNumber)
        Console.WriteLine("Double Number:" & doubleNumber)
        Console.WriteLine("Decimal Number:" & decimalNumber)
        Console.WriteLine("Char Value:" & charValue)
        Console.WriteLine("Short Value:" & shortValue)
        Console.WriteLine("Long Value:" & longValue)
        Console.WriteLine("Byte Value:" & byteValue)
        Console.WriteLine("Date Value:" & dateValue)
        Console.WriteLine("DateTime Value:" & dateTimeValue)
        Console.WriteLine("Array Value:")
        For Each item In arrayValue
            Console.WriteLine(item)
        Next

        Console.WriteLine("List Value:")
        For Each item In listValue
            Console.WriteLine(item)
        Next

        Console.WriteLine("Dictionary Value:")
        For Each item In dictionaryValue
            Console.WriteLine(item.Key & ":" & item.Value)
        Next

        Console.WriteLine("Tuple Value:")

        Console.WriteLine(tupleValue.Item1)
        Console.WriteLine(tupleValue.Item2)
        Console.WriteLine(tupleValue.Item3)

        Console.WriteLine("Key Value Pair:")
        Console.WriteLine(keyValue.Key)
        Console.WriteLine(keyValue.Value)




    End Sub



End Module
