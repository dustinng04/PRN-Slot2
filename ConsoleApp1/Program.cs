using System;
using System.Net.Http.Headers;
using System.Numerics;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using System.Linq;
using System.Drawing;

internal class Program()
{
    private static String HEXADECIMAL_VALID = "^[A-Fa-f0-9]+$";
    public static void exe1(String name)
    {
        Console.WriteLine($"Hello {name}");
    }
    public static String inputString(String mess)
    {
        Console.WriteLine(mess);
        //force user input exectly non-empty string
        while (true)
        {
            String input = Console.ReadLine().Trim();
            if (input.Equals(""))
            {
                Console.WriteLine("Please input a non-empty string: ");
                continue;
            }
            return input;
        }
    }
    public static double inputNumber(String mess)
    {
        while (true)
        {
            Console.WriteLine(mess);
            String input = Console.ReadLine();
            try
            {
                double number = Convert.ToInt32(input);
                return number;
            } catch (FormatException)
            {
                Console.WriteLine("Please enter a valid number");
            }

        }
    }
    public static char inputChar(string prompt)
    {
        while (true)
        {
            Console.Write(prompt);
            string input = Console.ReadLine();
            try
            {
                if (input.Length == 1)
                {
                    return input[0];
                }
                else
                {
                    throw new ArgumentException("Input must be a single character.");
                }
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message); // Print the error message
            }
        }
    }
    public static void exe2()
    {
        // Take numbers by input
        double num1 = inputNumber("Enter number 1: ");
        double num2 = inputNumber("Enter number 2: ");
        double sum = num1 + num2;
        Console.WriteLine($"The sum of {num1} and {num2} is {sum} ");
    }

    public static void exe3()
    {
        double num1 = inputNumber("Nhap so bi chia: ");
        double num2 = inputNumber("Nhap so chia: ");
        if (num2 == 0)
        {
            Console.WriteLine("Nhap so chia khac 0: ");
            return;
        }
        else
        {
            Console.WriteLine($"Thuong cua {num1} va {num2} la {num1 / num2}");
        }
    }

    public static void exe4()
    {
        Console.WriteLine("-1 + 4 * 6 = " + Operation1());
        Console.WriteLine("( 35 + 5 ) % 7 = " + Operation2());
        Console.WriteLine("14 + -4 * 6 / 11 = " + Operation3());
        Console.WriteLine("2 + 15 / 6 * 1 - 7 % 2 = " + Operation4());

        static int Operation1()
        {
            return -1 + 4 * 6;
        }

        static int Operation2()
        {
            return (35 + 5) % 7;
        }

        static int Operation3()
        {
            return 14 + -4 * 6 / 11;
        }

        static int Operation4()
        {
            return 2 + 15 / 6 * 1 - 7 % 2;
        }
    }

    public static void exe5()
    {
        double a = inputNumber("Input the First Number");
        double b = inputNumber("Input the Second Number");

        double temp = a;
        a = b;
        b = temp;

        Console.WriteLine("After swapping: ");
        Console.WriteLine("First number: " + a);
        Console.WriteLine("Second number: " + b);
    }

    public static void exe6()
    {
        double a = inputNumber("Input the first number to multiply: ");
        double b = inputNumber("Input the second number to multiply:");
        double c = inputNumber("Input the third number to multiply: ");
        Console.WriteLine($"{a} * {b} * {c} = {a * b * c}");
    }

    public static void exe7()
    {
        double a = inputNumber("Input the first number: ");
        double b = inputNumber("Input the second number:");
        Console.WriteLine($"{a} + {b} = {a + b}");
        Console.WriteLine($"{a} - {b} = {a - b}");
        Console.WriteLine($"{a} x {b} = {a * b}");
        Console.WriteLine($"{a} / {b} = {a / b}");
        Console.WriteLine($"{a} mod {b} = {a % b}");
    }

    public static void exe8()
    {
        int a = Convert.ToInt32(inputNumber("Enter a number: "));
        for (int i = 0; i <= 10; i++)
        {
            Console.WriteLine($"{a} * {i} = {a * i}");
        }
    }

    public static void exe9()
    {
        double a = inputNumber("Enter the first number: ");
        double b = inputNumber("Enter the second number: ");
        double c = inputNumber("Enter the third number: ");
        double d = inputNumber("Enter the fourth number: ");
        /*Calculator*/
        double e = (a + b + c + d) / 4;
        Console.WriteLine($"The average of {a}, {b}, {c}, {d} is: {e}");
    }
    public static void exe10()
    {
        // Input three numbers
        int x = Convert.ToInt32(inputNumber("Enter first number: "));
        int y = Convert.ToInt32(inputNumber("Enter second number: "));
        int z = Convert.ToInt32(inputNumber("Enter third number: "));

        // Perform calculations
        int result1 = (x + y) * z;
        int result2 = x * y + y * z;

        // Print results
        Console.WriteLine($"Result of specified numbers {x}, {y} and {z}, (x+y).z is {result1} and x.y + y.z is {result2}");
    }
    public static void exe11(int age)
    {
        int res = age < 0 ? -age : age;
        Console.Write("You look younger than " + res);
    }
    public static void exe12() {
        int x = Convert.ToInt32(inputNumber("Enter a digit: "));
        Console.WriteLine($"{x} {x} {x} {x}");
        Console.WriteLine($"{x}{x}{x}{x}");
        Console.WriteLine($"{x} {x} {x} {x}");
        Console.WriteLine($"{x}{x}{x}{x}");
    }
    public static void exe13()
    {
        int x = Convert.ToInt32(inputNumber("Enter a digit: "));

        // Print rectangle using the input number
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                if (i == 0 || i == 4 || j == 0 || j == 2)
                {
                    Console.Write(x);
                }
                else
                {
                    Console.Write(" ");
                }
            }
            Console.WriteLine();
        }
    }
    public static void exe14()
    {
        double celsius = inputNumber("Enter temperature in Celsius: ");

        // Convert Celsius to Kelvin
        double kelvin = celsius + 273.15;

        // Convert Celsius to Fahrenheit
        double fahrenheit = celsius * 9 / 5 + 32;

        // Print results
        Console.WriteLine($"Temperature in Kelvin: {kelvin}");
        Console.WriteLine($"Temperature in Fahrenheit: {fahrenheit}");
    }
    public static void exe15()
    {
        String s = inputString("Test data: ");
        /*Input n then compare with length of s*/

        for (int i = 0; i < 3; i++)
        {
            /*Find a random num < length => print string*/
            Console.WriteLine(s.Remove(new Random().Next(s.Length - 1), 1));
        }
    }
    public static String exe16(String str)
    {
        if (str.Length >= 2)
        {
            // Swap first and last characters
            char[] chars = str.ToCharArray();
            char firstChar = chars[0];
            chars[0] = chars[str.Length - 1];
            chars[str.Length - 1] = firstChar;
            return new string(chars);
        }
        else
        {
            // < 2 chars => original string
            return str;
        }
    }
    public static String exe17(String str)
    {
        if (str.Length >= 1)
        {
            var s = str.Substring(0, 1);
            return s + str + s;
        }
        return str;
    }
    public static void exe18() {
        int firstInt = Convert.ToInt32(inputNumber("Input first integer:"));
        int secondInt = Convert.ToInt32(inputNumber("Input second integer:"));

        // Check if one is negative and one is positive
        bool result = (firstInt < 0 && secondInt > 0) || (firstInt > 0 && secondInt < 0);

        Console.WriteLine("Check if one is negative and one is positive:");
        Console.WriteLine(result);
    }
    public static void exe19()
    {
        int firstInt = Convert.ToInt32(inputNumber("Input first integer:"));
        int secondInt = Convert.ToInt32(inputNumber("Input second integer:"));

        // Compute the sum
        int sum = firstInt + secondInt;

        // Check if the two values are the same
        if (firstInt == secondInt)
        {
            // Return triple of their sum
            sum *= 3;
        }

        // Print the result
        Console.WriteLine("Result: " + sum);
    }
    public static void exe20()
    {
        double firstNum = inputNumber("Input first number:");
        double secondNum = inputNumber("Input second number:");

        // Compute the absolute difference
        double difference = Math.Abs(firstNum - secondNum);

        if (firstNum > secondNum)
        {
            difference *= 2;
        }
        Console.WriteLine("Result: " + difference);
    }
    public static void exe21()
    {
        int firstInt = Convert.ToInt32(inputNumber("Input first integer:"));
        int secondInt = Convert.ToInt32(inputNumber("Input second integer:"));

        // Check if one of the integers is 20 or if their sum is 20
        bool result = !(firstInt == 20 && secondInt == 20) || (firstInt + secondInt == 20);

        // Print the result
        Console.WriteLine("Result: " + result);
    }
    public static void exe22()
    {
        // Input an integer
        int number = Convert.ToInt32(inputNumber("Input an integer:"));

        // Check if the integer is within 20 of 100 or 200
        bool result = (Math.Abs(number - 100) <= 20 || Math.Abs(number - 200) <= 20);

        // Print the result
        Console.WriteLine("Result: " + result);
    }
    public static String exe23(String str)
    {
        return str.ToLower();
    }
    public static void exe24()
    {
        String str = inputString("Input a string: ");
        String[] words = Regex.Split(str, "\\s+");
        string longestWord = "";
        int maxLength = 0;

        // Iterate through each word to find the longest one
        foreach (string word in words)
        {
            if (word.Length > maxLength)
            {
                maxLength = word.Length;
                longestWord = word;
            }
        }

        Console.Write("Longest word: " + longestWord);
    }
    public static void exe25()
    {
        Console.Write("Odd numbers from 1 to 99: ");
        for (int i = 0; i <= 99; i++)
        {
            if (i % 2 == 1)
            {
                Console.WriteLine(i);
            }
        }
    }
    static bool IsPrime(int number)
    {
        if (number <= 1)
            return false;

        for (int i = 2; i <= Math.Sqrt(number); i++)
        {
            if (number % i == 0)
                return false;
        }

        return true;
    }
    public static void exe26()
    {
        int count = 0; // Counter for the number of prime numbers found
        int num = 2; // Starting number 
        long sum = 0;

        // Keep finding prime numbers until count reaches 500
        while (count < 500)
        {
            if (IsPrime(num))
            {
                sum += num;
                count++;
            }
            num++;
        }

        Console.WriteLine("Sum of the first 500 prime numbers: " + sum);
    }
    public static int exe27(int num)
    {
        int sum = 0;
        num = Math.Abs(num);

        while (num > 0)
        {
            // Extract the last digit of the number and add it to the sum
            sum += num % 10;

            num /= 10;
        }
        return sum;
    }

    public static void exe28()
    {
        String str = inputString("input a sentence: ").Trim();
        String[] words = Regex.Split(str, "\\s+");
        Array.Reverse(words);
        String reversedSentece = string.Join(" ", words);
        Console.WriteLine("Reverse String: " + reversedSentece);
    }
    public static long exe29(String filePath)
    {
        if (File.Exists(filePath))
        {
            // Create a FileInfo object for the specified file
            FileInfo fileInfo = new FileInfo(filePath);

            // Get the size of the file in bytes
            return fileInfo.Length;
        }
        else
        {
            // If the file does not exist, return -1
            return -1;
        }
    }
    public static String checkInputHex()
    {
        Console.WriteLine("Enter number hexadecimal: ");
        String result;
        //loop until user input correct
        while (true)
        {
            result = Console.ReadLine().Trim();
            if (Regex.IsMatch(result, HEXADECIMAL_VALID))
            {
                return result;
            }
            Console.WriteLine("Must be enter 0-9 A-F");
            Console.WriteLine("Enter again: ");
        }
    }
    public static void exe30()
    {
        String hex = checkInputHex();
        int decimalNumber = Convert.ToInt32(hex, 16);
        Console.WriteLine($"Hexadecimal number: {hex} convert to decimal number: {decimalNumber}");
    }
    public static void exe31(int[] array1, int[] array2)
    {

        // Multiply corresponding elements of two arrays
        if (array1.Length != array2.Length)
        {
            throw new ArgumentException("Arrays must have the same length");
        }

        // Create a new array to store the result
        int[] result = new int[array1.Length];

        // Multiply corresponding elements
        for (int i = 0; i < array1.Length; i++)
        {
            result[i] = array1[i] * array2[i];
        }

        // Print the result
        Console.WriteLine("Multiply corresponding elements of two arrays:");

        foreach (int num in result)
        {
            Console.Write(num + " ");
        }
    }
    public static String exe32()
    {
        String str = inputString("Input a String: ");
        if (str.Length < 4)
        {
            return str;
        } else
        {
            String res = str.Substring(str.Length - 4);
            return res + res + res + res;
        }
    }
    public static void exe33() {
        int num = Convert.ToInt32(inputNumber("Input a integer: "));
        bool res = !((num % 3 == 0) && (num % 7 == 0));
        Console.WriteLine(res);
    }
    public static void exe34()
    {
        String str = inputString("input a string: ");
        String[] words = Regex.Split(str, "\\s+");
        bool check = false;
        if (words.Length >= 2)
        {
            check = true;
        }
        Console.WriteLine(check);
    }
    public static void exe36()
    {
        int firstInt = Convert.ToInt32(inputNumber("Input first integer:"));
        int secondInt = Convert.ToInt32(inputNumber("Input second integer:"));
        bool res = (firstInt >= -10 && firstInt <= 10) || (secondInt >= -10 && secondInt <= 10);
        Console.WriteLine(res);
    }
    public static void exe35()
    {
        int firstInt = Convert.ToInt32(inputNumber("Input first integer:"));
        int secondInt = Convert.ToInt32(inputNumber("Input second integer:"));
        bool res = (firstInt < 100 && secondInt > 200) || (firstInt > 200 && secondInt < 100);
        Console.WriteLine(res);
    }
    public static void exe37()
    {
        String str = inputString("Input a string: ").Trim();
        String res = str.Substring(1, 2).Equals("HP") ? str.Remove(1, 2) : str;
        Console.WriteLine(res);
    }
    public static void exe38()
    {
        String str = inputString("Input a string: ");
        var res = "";
        if (str.Length >= 1 && str[0] == 'P') res += str[0];
        if (str.Length >= 2 && str[1] == 'H') res += str[1];
        Console.WriteLine(res);
    }
    public static void exe39()
    {
        int firstNum = Convert.ToInt32(inputNumber("Input first integer: "));
        int secondNum = Convert.ToInt32(inputNumber("Input second integer: "));
        int thirdNum = Convert.ToInt32(inputNumber("Input third integer: "));
        int max = Math.Max(Math.Max(firstNum, secondNum), thirdNum);
        int min = Math.Min(Math.Min(firstNum, secondNum), thirdNum);
        Console.WriteLine($"Min: {min}, Max: {max}");
    }
    public static void exe40()
    {
        int a = Convert.ToInt32(inputNumber("Input first integer:"));
        int b = Convert.ToInt32(inputNumber("Input second integer:"));
        int res = Math.Abs(20 - a) - Math.Abs(20 - b);
        if (res > 0) res = b;
        else if (res < 0) res = a;
        else res = 0;
        Console.WriteLine(res);
    }
    public static void exe41()
    {
        String str = inputString("input a string: ");
        int count = 0;
        bool res = false;
        char[] ch = str.ToCharArray();
        foreach (Char c in ch)
        {
            if (c == 'w')
            {
                count++;
            }
        }
        if (count >= 1 && count <= 3) res = true;
        Console.WriteLine(res);
    }
    public static void exe42()
    {
        String str = inputString("Input a string: ");
        var res = "";
        if (str.Length <= 4) res = str.ToUpper();
        else {
            res = str.Substring(0, 4).ToUpper() + str.Substring(4);
        }
        Console.WriteLine(res);
    }
    public static void exe43()
    {
        String str = inputString("Input a string: ");
        var res = false;
        if (str.Length >= 3 && str[0] == 'w')
        {
            if (str[1] == 'w' && str[2] == 'w') res = true;
        }
        Console.Write(res);
    }
    public static void exe44()
    {
        String str = inputString("Input a string: ");
        var res = "";
        for (int i = 0; i < str.Length; i += 2)
        {
            res += str[i];
        }
        Console.Write(res);
    }
    public static void exe45(int[] arr)
    {
        int x = Convert.ToInt32(inputNumber("Input an integer: "));
        Console.WriteLine($"Number of {x} in array: {arr.Count(n => n == x)} ");
    }
    public static void exe46(int[] arr)
    {
        int x = Convert.ToInt32(inputNumber("Input an integer: "));
        Console.WriteLine((arr[0] == x) || (arr[arr.Length - 1] == x));
    }
    public static void exe47(int[] arr)
    {
        int sum = 0;
        foreach (int i in arr) {
            sum += i;
        }
        Console.Write(sum);
    }
    public static void exe48(int[] arr)
    {
        Console.WriteLine(arr[0] == arr[arr.Length - 1]);
    }
    public static void exe49(int[] arr1, int[] arr2)
    {
        Console.WriteLine((arr1[0] == arr2[0]) || (arr1[arr1.Length - 1] == arr2[arr2.Length - 1]));
    }
    public static void exe50(int[] arr)
    {
        // Store the first element in a temporary variable
        int temp = arr[0];

        // Shift all elements to the left
        for (int i = 0; i < arr.Length - 1; i++)
        {
            arr[i] = arr[i + 1];
        }

        // Move the first element to the end of the array
        arr[arr.Length - 1] = temp;
        foreach (int i in arr) Console.Write(i + " ");
    }
    public static void exe51(int[] arr)
    {
        int max = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] - arr[0] > max) max = arr[i] - arr[0];
        }
        Console.WriteLine("Highest value between first and last values of the said array: " + max);
    }
    public static void exe52(int[] arr1, int[] arr2, int[] arr3)
    {
        if (arr1.Length != 3 || arr2.Length != 3 || arr3.Length != 3) return;
        Console.WriteLine($"New Array: [{arr1[1]}, {arr2[1]}, {arr3[1]}]");
    }
    public static void exe53(int[] arr)
    {
        Console.WriteLine(arr.Count(n => n % 2 == 1) != 0 ? true : false);
    }
    public static void exe54()
    {
        int year = Convert.ToInt32(inputNumber("Enter a year: "));
        int century = (year % 100 != 0) ? (year / 100 + 1) : (year / 100);
        Console.WriteLine(century);
    }
    public static void exe55(int[] arr)
    {
        int max = 0;
        for (int i = 0; i < arr.Length - 1; i++)
        {
            if (arr[i] * arr[i + 1] >= max) max = arr[i] * arr[i + 1];
        }
        Console.WriteLine(max);
    }
    public static void exe56()
    {
        String str = inputString("Enter a string: ");
        String res = "";
        char[] c = str.ToCharArray();
        Array.Reverse(c);
        foreach (char c2 in c) res += c2;
        Console.WriteLine(res.Equals(str));
    }
    public static void exe57(int[] arr)
    {
        int max = arr[0] * arr[1];
        for (int i = 0; i < arr.Length - 1; i++)
        {
            max = Math.Max(max, arr[i] * arr[i + 1]);
        }
        Console.WriteLine(max);
    }
    public static void exe58(int[] arr)
    {
        int max = arr[0]; int min = arr[0];
        int count = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            max = Math.Max(max, arr[i]);
            min = Math.Min(min, arr[i]);
        }
        for (int j = min; j <= max; j++)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == j) count++;
            }
        }
        Console.WriteLine(max - min + 1 - count);
    }
    public static void exe59(int[] arr)
    {
        var res = true;
        for (int i = 0; i < arr.Length - 1; i++)
        {
            if (arr[i] >= arr[i + 1]) res = false;
        }
        Console.WriteLine(res);
    }
    public static void exe61(int[] arr)
    {
        // List holding -5's positions & non -5 elements
        List<int> positions = new List<int>();
        List<int> list = new List<int>();
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == -5) positions.Add(i);
            else list.Add(arr[i]);
        }
        list.Sort();
        int[] res = new int[arr.Length]; int index = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            if (positions.Contains(i)) res[i] = -5;
            else
            {
                res[i] = list[index];
                index++;
            }
        }
        foreach (var i in res) Console.Write(i + " ");
    }
    public static void exe62()
    {
        String str = inputString("Input a string: ");
        Stack<StringBuilder> stack = new Stack<StringBuilder>();
        StringBuilder current = new StringBuilder();

        foreach (char c in str)
        {
            // Take chars from ( to ) => Push to stack, then take from top
            if (c == '(')
            {
                stack.Push(current);
                current = new StringBuilder();
            }
            else if (c == ')')
            {
                //Reverse
                char[] ch = current.ToString().ToCharArray();
                Array.Reverse(ch);
                current = new StringBuilder(new String(ch));
                if (stack.Count > 0) { current = stack.Pop().Append(current); }
            }
            else
            {
                current.Append(c);
            }
        }

        Console.WriteLine(current.ToString());
    }

    public static void exe63(int[] arr)
    {
        int n = Convert.ToInt32(inputNumber("Input a number: "));
        Console.Write(arr.Contains(n));
    }
    public static void exe64(String filePath)
    {
        Console.WriteLine(filePath.Split('/').Last());
    }
    public static void exe65(int[] arr)
    {
        foreach (var i in arr)
        {
            Console.WriteLine(i * arr.Length);
        }
    }
    public static void exe66()
    {
        String s1 = inputString("enter first number: ");
        String s2 = inputString("enter second number: ");
        var res = Convert.ToInt32(s1) < Convert.ToInt32(s2) ? s1 : s2;
        Console.Write(res);
    }
    public static void exe67()
    {
        String str = inputString("input a string: ");
        Console.WriteLine(str.Replace("P", "9").Replace("T", "0").Replace("S", "1").Replace("H", "6").Replace("A", "8"));
    }
    public static void exe68()
    {
        String str = inputString("input a string: ");
        char c = inputChar("enter a character: ");
        if (Char.IsLetter(c))
        {
            int count = 0;
            char upper = char.ToUpper(c); char lower = char.ToLower(c);
            foreach (char ch in str)
            {
                if (ch == upper || ch == lower) count++;
            }
            Console.Write(count);
        }
        else return;
    }
    public static void exe69()
    {
        String str = inputString("Input a string: ");
        Console.WriteLine((str == str.ToLower()) || (str == str.ToUpper()));
    }
    public static void exe70()
    {
        String str = inputString("Input a string: ");
        Console.WriteLine("After removing first and last elements: " + str.Substring(1, str.Length - 2));
    }
    public static void exe71()
    {
        String str = inputString("Input a string: ");
        var res = false;
        for (int i = 0; i < str.Length - 1; i++)
        {
            if (str[i] == str[i + 1]) res = true;
        }
        Console.WriteLine(res);
    }
    public static void exe72(int[] arr)
    {
        int sum = 0;
        foreach (var i in arr) sum += i;
        var res = sum / arr.Length;
        Console.WriteLine(res % 1 == 0);
    }
    public static void exe73()
    {
        String str = inputString("Input a string: ");
        Console.Write(new String(str.OrderBy(x => x).ToArray()));
    }
    public static void exe74()
    {
        String str = inputString("Input a string: ");
        var res = "Even length";
        if (str.Length % 2 == 1)
        {
            res = "Odd length";
        }
        Console.WriteLine(res);
    }
    public static void exe75()
    {
        int n = Convert.ToInt32(inputNumber("Input a positive number: "));
        if (n > 0)
        {
            var tail = "th";
            if (n % 10 == 2) tail = "nd"; if (n % 10 == 3) tail = "rd"; if (n % 10 == 1) tail = "st";
            Console.WriteLine($"{n}{tail} odd number: {n * 2 - 1}");
        }
    }
    public static void exe76()
    {
        char c = inputChar("Enter a character: ");
        Console.WriteLine("Ascii value of " + c + " is: " + (int)c);
    }
    public static void exe77()
    {
        String word = inputString("Input a word: ");
        if (word.Split(' ').Length == 1)
        {
            Console.WriteLine($"Is {word} a plural? {word.EndsWith("s") || word.EndsWith("es") || word.EndsWith("ss")}");
        } else
        {
            Console.WriteLine("please enter only a word: ");
        }
    }
    public static void exe78(int[] arr)
    {
        int sum = 0;
        foreach (var i in arr) sum += i * i;
        Console.Write("Sum of squares of elements of the said array: " + sum);
    }
    public static void exe79()
    {
        string str = "50";

        Console.WriteLine($"Original value and type: {str}, {str.GetType()}");
        int result = Convert.ToInt32(str);

        Console.WriteLine("Convert string to integer:");
        Console.WriteLine($"Return value and type: {result}, {result.GetType()}");

        int n = 122;
        Console.WriteLine($"Original value and type: {n}, {n.GetType()}");

        string result1 = Convert.ToString(n);

        Console.WriteLine("Convert integer to string:");
        Console.WriteLine($"Return value and type: {result1}, {result1.GetType()}");
    }
    public static void exe80(object[] arr)
    {
        Console.WriteLine("Printing original array elements and their types: ");
        foreach (var i in arr)
        {
            Console.WriteLine($"Value->{i}::Type->{i.GetType()}");
        }
    }
    public static void exe81()
    {
        int n = Convert.ToInt32(inputNumber("Input a two-digit number: "));
        if (n / 10 >= 1)
        {
            int tens = n / 10;
            int ones = n % 10;
            int swapped = ones * 10 + tens;
            Console.WriteLine(swapped <= n);
        } else
        {
            Console.WriteLine("Enter a two-digit number: ");
            return;
        }
    }
    public static void exe82()
    {
        String str = inputString("Input a string: ");
        StringBuilder stringBuilder = new StringBuilder();
        foreach (char c in str)
        {
            if (char.IsLetter(c))
            {
                stringBuilder.Append(c);
            }
        }
        Console.WriteLine("Remove all characters from the said string which are non-letters: " + stringBuilder.ToString());
    }
    public static void exe83()
    {
        String str = inputString("Input a string: ");
        String res = "";
        var vowels = "AEIOUaeiou";
        for (int i = 0; i < str.Length; i++) {
            if (!vowels.Contains(str[i])) res += str[i];
        }
        Console.WriteLine(res);
    }
    public static void exe84()
    {
        String str = inputString("Input a String: ");
        var res = "";
        Console.Write("Indices of all lower case letters of the said string:");
        for (int i = 0; i < str.Length; i++)
        {
            if (Char.IsLower(str[i]))
            {
                res += " " + i;
            }
        }
        Console.WriteLine(res.ToString());
    }
    public static void exe85(float[] arr)
    {
        Console.WriteLine("Orginal Array elements: \n");
        foreach (var i in arr) Console.Write(i + " ");
        float[] cummulative = new float[arr.Length];
        cummulative[0] = arr[0];
        for (int i = 1; i < arr.Length; i++)
        {
            cummulative[i] = cummulative[i - 1] + arr[i];
        }
        Console.WriteLine("\nCumulative sum of the said array elements: \n");
        foreach (var i in cummulative) Console.Write(i + " ");
    }
    public static void exe86()
    {
        String str = inputString("input a string: ");
        Console.WriteLine("Original string: " + str);
        Console.WriteLine($"Number of letters: {str.Count(char.IsLetter)} Number of digits: {str.Count(char.IsDigit)}");
    }
    public static void exe87()
    {
        var bool1 = false; var bool2 = true;
        Console.WriteLine($"Original value: {bool1}\nReversed Value: {!bool1}");
        Console.WriteLine($"Original value: {bool2}\nReversed Value: {!bool2}");
    }
    public static void exe88()
    {
        int n = Convert.ToInt32(inputNumber("Input the number of straight lines: "));
        Console.WriteLine("Sum of the interior angles (in degrees) of the said polygon: " + 180 * (n - 2));
    }
    public static void exe89(int[] arr)
    {
        Console.WriteLine("Original Array elements: ");
        foreach (var i in arr) Console.Write(i + " ");
        Console.WriteLine($"\nNumber of positive numbers: {arr.Count(x => x > 0)}\nNumber of negative numbers: {arr.Count(x => x < 0)}");
    }
    public static void exe90()
    {
        int n = Convert.ToInt32(inputNumber("Enter an integer: "));
        var res = Convert.ToString(n, 2);
        Console.WriteLine("Original number: " + n);
        Console.WriteLine("Number of ones and zeros in the binary representation of the said number:");
        Console.WriteLine($"Number of ones: {res.Count(c => c == '1')}\nNumber of zeros: {res.Count(c => c == '0')}");
    }
    public static void exe91(object[] mixArray)
    {
        Console.WriteLine("Original array elements: ");
        foreach (var i in mixArray) Console.Write(i + " ");
        var intValues = mixArray.OfType<int>().ToArray();
        Console.WriteLine("\nAfter removing all the values except integer values from the said array of mixed values:");
        foreach (var i in intValues) Console.Write(i + " ");
    }
    public static void exe92()
    {
        int n = Convert.ToInt32(inputNumber("Enter a positive integer: "));
        int next = n;
        while (!IsPrime(next))
        {
            next++;
        }
        Console.WriteLine($"Original number: {n}");
        Console.WriteLine("Next prime number: " + next);
    }
    public static void exe93()
    {
        var n = inputNumber("Enter a positive number: ");
        int count = 1;
        while (n / count >= count) count++;

        Console.WriteLine(count - 1);
    }
    public static void exe94(String[] arr)
    {
        if (arr.Length == 0 || Array.IndexOf(arr, "") != -1)
        {
            return;
        }
        String res = arr[0];
        int i = res.Length;
        foreach (String word in arr)
        {
            int j = 0;
            foreach (char c in word)
            {
                //Break if chars dont match or j >= i
                if (j >= i || res[j] != c) break;
                j++;    
            }
            i = Math.Min(i, j);
        }
        Console.WriteLine(res.Substring(0, i));
    }
    public static void exe95()
    {
        String s = inputString("input a string: ");
        Stack<char> ch = new Stack<char>();
        // Iterating through each character in the input string
        foreach (var item in s.ToCharArray())
        {
            // Checking the type of parentheses and pushing the respective closing parentheses onto the stack
            if (item == '(')
                ch.Push(')');
            else if (item == '<')
                ch.Push('>');
            else if (item == '[')
                ch.Push(']');
            else if (item == '{')
                ch.Push('}');
            else if (ch.Count == 0 || ch.Pop() != item)
                Console.WriteLine(false);
                return; // If the closing parentheses don't match the top of the stack or stack is empty, return false
        }

        // empty stack after pop all chars => true otherwise false;
        Console.WriteLine(ch.Count == 0);
    }
    public static void exe96()
    {
        String s = inputString("input a string: ");
        char c = s[0];
        Console.WriteLine(s.Count(ch => ch == c) == s.Length);
    }
    public static void exe97()
    {
        String s = inputString("Input a string: ");
        double result;
        Console.WriteLine(double.TryParse(s, out result));
    }
    public static bool exe100<T1, T2>(T1 param1, T2 param2)
    {
        return param1.Equals(param2) && param1.GetType() == param2.GetType();
    }
    public static void exe101()
    {
        double e = 1.0;
        double factorial = 1.0;
        double term = 1.0;

        for (int i = 1; i <= 20; i++) 
        {
            factorial *= i;
            term = 1.0 / factorial;
            e += term;
        }
        Console.WriteLine(e);
    }
    public static void exe102()
    {
        int size = Convert.ToInt32(inputNumber("input a number: "));
        for (int row = 0; row < size; row++)
        {
            for (int col = 0; col < size; col++)
            {
                if (row == col)
                {
                    Console.Write("1 ");
                }
                else
                {
                    Console.Write("0 ");
                }
            }
            Console.WriteLine();
        }
    }
    public static void exe103()
    {
        String str = inputString("input a string: ");
        char[] ch = str.ToCharArray();
        Array.Sort(ch);
        var chars = ch.Where(char.IsLetter).OrderBy(c => c);
        var numbers = ch.Where(char.IsDigit).OrderBy(c => c);
        String sorted = new string(chars.ToArray()) + new string(numbers.ToArray());
        Console.WriteLine(string.IsNullOrWhiteSpace(sorted) ? "Blank String!" : sorted);
    }
    public static void Main()
    {
        //String name = "Duc";
        /*exe1(name);*
         * /*exe2();*/
        /*exe3();*/
        /* exe4();*/
        /*exe5();*/
        /*exe6();*/
        /*exe7();*/
        /*exe8();*/
        /* exe9();*/
        /*exe10();*/
        /*int a = Convert.ToInt32(inputNumber("Enter your age")); exe11(a);*/
        /*exe12();*/
        /*exe13();*/
        //exe14();
        //exe15();
        //Console.writeLine(exe16(inputString("Test data: ")));
        /*Console.WriteLine(exe17(inputString("input a string")));*/
        //exe18();
        //exe19();
        //exe20();
        //exe21();
        //exe22();
        //Console.WriteLine(exe23(inputString("Input a string")));
        //exe24();
        //exe25();
        //exe26();
        //Console.WriteLine("Sum of the digits of the said integer: " + exe27(Convert.ToInt32(inputNumber("Input a number: "))));
        //exe28();
        //Console.WriteLine("Size of a file: " + exe29("your_file_path"));
        //exe30();
        //int[] array1 = { 1, 3, -5, 4 };
        //int[] array2 = { 1, 4, -5, -2 }; exe31(array1, array2);
        //Console.WriteLine(exe32());
        //exe33();
        //exe34();
        //exe35();
        //exe36();
        //exe37();
        //exe38();
        //exe39();
        //exe40();
        //exe41();
        //exe42();
        //exe43();
        //exe44();    
        //int[] nums = { 1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 9 }; exe45(nums);
        //int[] nums = { 1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 9 }; exe46(nums);
        //int[] nums = { 1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 1 }; exe47(nums);
        //int[] nums = { 1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 1 }; exe48(nums);
        //int[] nums1 = {1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 1}; int[] nums2 = { 1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 5 }; exe49(nums1, nums2);
        //int[] arr = { 1, 2, 8 };exe50(arr);
        //int[] arr = { 1, 2, 5, 7, 8 }; exe51(arr);
        //int[] arr1 = { 1, 2, 5 }, arr2 = { 0, 3, 8 }, arr3 = { -1, 0, 2 }; exe52(arr1 , arr2, arr3);
        //int[] arr = { 2, 4, 7, 8, 6 }; exe53(arr);
        //exe54();
        //int[] arr = { 2, 4, 2, 6, 9, 3 }; exe55(arr);
        //exe56();
        //int[] arr = { 1, -3, 4, -5, 1 }; exe57(arr);
        //int[] arr = { 1, 3, 4, 7, 9 }; exe58(arr);
        //int[] arr = { 1, 3, 5, 6, 9 };exe59(arr);
        //int[] arr = { -5, 236, 120, 70, -5, -5, 698, 280 }; exe61(arr);    
        //exe62();
        //int[] arr = { 1, 3, 5, 7, 9 }; exe63(arr);
        //String filePath = "c:/csharp/ex/test.cpp"; exe64(filePath);
        //int[] arr = { 1, 3, 5, 7, 9 }; exe65(arr);
        //exe66();
        //exe67();
        //exe68();
        //exe69();
        //exe70();
        //exe71();
        //int[] arr = { 1, 2, 3, 5, 4, 2, 3, 4 }; exe72(arr);
        //exe73();
        //exe74();
        //exe75();
        //exe76();
        //exe77();
        //int[] arr = { -2, 0, 3, 4 }; exe78(arr);
        //exe79();
        //object[] mixArray = { 25, "anna", false, System.DateTime.Now, 112.22 };exe80(mixArray);
        //exe81();
        //exe82();
        //exe83();
        //exe84();
        //float[] arr = { 1, 3 ,4, 5, 6, 7 }; exe85(arr);
        //exe86();
        //exe87();
        //exe88();
        //int[] arr = { 10, -11, 12, -13, 14, -18, 19, -20 }; exe89(arr);
        //exe90();
        //object[] mixArray = { 25, "anna", false, System.DateTime.Now, 112.22 };exe91(mixArray);
        //exe92();
        //exe93();
        //String[] arr = { "Padas", "Packed", "Pace", "Pacha" }; exe94(arr);
        //exe95();
        //exe96();
        //exe97();
        //Console.WriteLine(exe100("AAA", "BBB")); Console.WriteLine(exe100(true, "true"));
        //exe101();
        //exe102();
        //exe103();
    }


}

