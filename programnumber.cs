class Program
{
	static void Main(string[] args)
	{
		Numbers number - new Numbers();
		
		Console.Writeline("Minimum #1: {0}"), number.FindMinimum(3, 1));
		Console.Writeline("Minimum #2: {0}"), number.FindMinimum(3, 1, 4));
		Console.Writeline();
		Console.Writeline("Maximum #1: {0}"), number.FindMaximum(3, 1));
		Console.Writeline("Maximum #2: {0}"), number.FindMaximum(3, 1, 4));
		
		Console.ReadKey();
	}
}
