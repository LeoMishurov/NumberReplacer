using System.Collections.Generic;

namespace NumberReplacer
{
	public class NumberReplacerCalc
	{
		static void Main(string[] args) { }

		/* 
		  1. Если число делится на 3 без остатка - заменить его на "fizz", если делится на 5 без остатка - заменить его на "buzz",
			 если делится на 3 и на 5 без остатка - заменить на "fizz-buzz"	
		*/
		public List<string> ReplaceNumber1(List<int> numbers)
		{
			List<string> resultList = new List<string>();

			foreach (int number in numbers)
			{
				string result;

				if (number % 3 == 0 && number % 5 == 0)
					result = "fizz-buzz";
				else if (number % 3 == 0)
					result = "fizz";
				else if (number % 5 == 0)
					result = "buzz";
				else
					result = number.ToString();

				resultList.Add(result);
			}

			return resultList;
		}

		/* 
		   2.Если число кратно 7 и 4. Если делится на 4 без остатка - заменить на "muzz", если делится на 7 без остатка - заменить на "guzz",
			 если делится на 4 и 7 без остатка - заменить на "muzz-guzz".
			 Аналогичное поведения для всех комбинаций чисел при кратности.
			 Пример: число 105 кратно 3, 5, 7 и не кратно 4 - его нужно заменить на "fizz-buzz-guzz" 
		*/
		public List<string> ReplaceNumber2(List<int> numbers)
		{
			List<string> resultList = new List<string>();

			foreach (int number in numbers)
			{
				List<string> replacements = new List<string>();

				if (number % 3 == 0)
					replacements.Add("fizz");

				if (number % 5 == 0)
					replacements.Add("buzz");

				if (number % 4 == 0)
					replacements.Add("muzz");

				if (number % 7 == 0)
					replacements.Add("guzz");

				if (replacements.Count == 0)
					resultList.Add(number.ToString());
				else
					resultList.Add(string.Join("-", replacements));
			}
			return resultList;
		}

		/*.
		   3.Если делится на 3 без остатка - заменить на "dog", если делится на 5 без остатка - заменить на "cat, если на 3 и 5 без остатка - заменить на "good-boy".
			 При кратности на 3 и 5 и другие числа - "good-boy" выводить вначале замены.
		*/
		public List<string> ReplaceNumber3(List<int> numbers)
		{
			List<string> resultList = new List<string>();

			foreach (int number in numbers)
			{
				List<string> replacements = new List<string>();

				if (number % 3 == 0 && number % 5 == 0)
					replacements.Add("good-boy");
				else if (number % 3 == 0)
					replacements.Add("dog");
				else if (number % 5 == 0)
					replacements.Add("cat");

				if (number % 4 == 0)
					replacements.Add("muzz");

				if (number % 7 == 0)
					replacements.Add("guzz");

				if (replacements.Count == 0)
					resultList.Add(number.ToString());
				else
					resultList.Add(string.Join("-", replacements));
			}
			return resultList;
		}
	}
}
