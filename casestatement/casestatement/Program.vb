Module Program
    Sub Main()
        Dim choice As Integer
        System.Console.Write("Enter Your Choice : ")
        choice = System.Console.ReadLine()
        Select Case choice
            Case "1"
                Dim No As Integer
                System.Console.Write("Enter Number : ")
                No = System.Console.ReadLine()
                If No Mod 2 = 0 Then
                    System.Console.WriteLine("Number Is Even Number")
                Else
                    System.Console.WriteLine("Number Is Odd Number")
                End If
            Case "2"
                Dim ch As String
                System.Console.Write("Enter Character : ")
                ch = System.Console.ReadLine()
                If ch = "a" Or ch = "e" Or ch = "i" Or ch = "o" Or ch = "u" Then
                    System.Console.WriteLine("Entered Character Is Vowel")
                Else
                    System.Console.WriteLine("Entered Character Is Consonent")

                End If
            Case "3"
                Dim pname As String
                Dim pcode, qty, price, total, discount, final, gst As Integer
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
                System.Console.WriteLine("GST Is 12")
                gst = (total * 12) / 100
                System.Console.WriteLine("Discount Is 10% ")
                discount = (total + gst) * 0.1
                final = total + gst - discount
                System.Console.WriteLine("Final Price Is : " & final)
        End Select
    End Sub
End Module