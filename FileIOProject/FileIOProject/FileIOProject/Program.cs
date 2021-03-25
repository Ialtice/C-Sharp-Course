//Isaac Altice 
//ID Number: 801077284
//ITCS: 3112-051

using System;
using System.IO;
using System.Text;




public class FileIOProgram
{
	static void Main(string[] args)
	{
		string[] numbers; // array to hold numbers from numbers file
		int oddOrEven;// variable that when 0 means current number is even, when 1 current number is odd

		try
		{
			FileInfo file = new FileInfo(@"C:\\Numbers.txt"); //searches drive C for the numbers file
			string path = file.FullName;// path contains full file path for numbers.txt file
			numbers = File.ReadAllLines(path);//each line of numbers.txt file put into a array
			StreamWriter swEven = new StreamWriter("C:\\Even.txt");// swEven writes data to Even,txt file located in C drive
			StreamWriter swOdd = new StreamWriter("C:\\Odd.txt");// swOdd writes data to Even,txt file located in C drive
			for (int i = 0; i < numbers.Length; i++)// loop through numbers array 
			{
				oddOrEven = Int32.Parse(numbers[i]) % 2;//checks whether each value in the array is odd or even

				if (oddOrEven == 1)// if value in current array location is odd gets writen into file Odd.txt
				{
					swOdd.WriteLine(numbers[i]);
				}
				else// if value in current array location is even gets writen into file Even.txt
				{
					swEven.WriteLine(numbers[i]);
				}
			}
			swEven.Close();// close file writers
			swOdd.Close();

		}
		catch (Exception e)//displays to console if error is thown
		{
			Console.WriteLine("Exception: " + e.Message);
		}
	}
}