using NumberReplacer;

namespace NumberReplacerTests

{
	public class UnitTest1
	{
		[Fact]
		public void Test1()
		{                                                          
			// Arrange
			List<int> input = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15};
			List<string> expectedOutput = new List<string>() { "1", "2", "fizz", "4", "buzz", "fizz", "7", "8", "fizz", "buzz", "11", 
				"fizz", "13", "14", "fizz-buzz" };

			NumberReplacerCalc numberReplacer = new();

			// Act
			List<string> actualOutput = numberReplacer.ReplaceNumber1(input);

			//Assert
			Assert.Equal(expectedOutput, actualOutput); 
		}

		[Fact]
		public void Test2()
		{                                                          		  
			// Arrange
			List<int> input = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 60, 105, 420};
			List<string> expectedOutput = new List<string>() { "1", "2", "fizz", "muzz", "buzz", "fizz", "guzz", "muzz", "fizz", "buzz", "11", 
				"fizz-muzz", "13", "guzz", "fizz-buzz", "fizz-buzz-muzz", "fizz-buzz-guzz", "fizz-buzz-muzz-guzz"};

			NumberReplacerCalc numberReplacer = new();

			// Act
			List<string> actualOutput = numberReplacer.ReplaceNumber2(input);

			//Assert
			Assert.Equal(expectedOutput, actualOutput); 
		}

		[Fact]
		public void Test3()
		{		
			List<int> input = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 60, 105, 420 };
			List<string> expectedOutput = new List<string>() { "1", "2", "dog", "muzz", "cat", "dog", "guzz", "muzz", "dog", "cat", "11", 
				"dog-muzz", "13", "guzz", "good-boy", "good-boy-muzz", "good-boy-guzz", "good-boy-muzz-guzz" };

			NumberReplacerCalc numberReplacer = new(); 

			// Act
			List<string> actualOutput = numberReplacer.ReplaceNumber3(input);

			//Assert
			Assert.Equal(expectedOutput, actualOutput); 
		}
	}

}