'
' Created by SharpDevelop.
' User: 19ofoster
' Date: 08/10/2021
' Time: 11:04
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'
Module Program
	Sub Main()
		'Defines some variables for use in the prgram
		Dim num1 As Int16 = 0
		Dim num2 As Int16 = 0
		Dim answer As Int16 = 0
		
		'Asks the user for some data
		Console.WriteLine("Please enter the length . . . ")
		num1 = Val(Console.ReadLine())
		Console.WriteLine("Please enter the width . . . ")
		num2 = Val(Console.ReadLine())
		
		'Finds the product of num1 and num2
		answer = num1 * num2
		
		'Displays the answer
		Console.WriteLine("The area is " & answer)
		
		Console.Write("Press any key to continue . . . ")
		Console.ReadKey(True)
	End Sub
End Module
