Imports System

Module Program
    Sub Main()
        Dim pname As String
        Dim pcode, qty, price, total, discount, final As Integer
        System.Console.Write("Product's Code : ")
        pcode = System.Console.ReadLine()
        System.Console.Write("Product's Name : ")
        pname = System.Console.ReadLine()
        System.Console.Write("Product's Price : ")
        price = System.Console.ReadLine()
        System.Console.Write("Quantity : ")
        qty = System.Console.ReadLine()
        System.Console.WriteLine("--------------------------")
        total = price * qty
        System.Console.WriteLine("Total : " & total)

        If total > 500 Then
            System.Console.WriteLine("Discount Is 10% ")
            discount = total * 0.1
            final = total - discount
            System.Console.WriteLine("Final Price Is : " & final)
        Else
            System.Console.WriteLine("Final Price Is : " & total)
        End If

    End Sub
End Module
