using System;
using System.IO;
using System.Text;
using System.Globalization;
using System.Collections.Generic; //to use the List method, this is a must
using Variables2.Math;

namespace Variables2
{
        partial class Program
        {

        //dec 27,2020
        //procedure programming
        //case 1: separate the ReverseName out of the main method
        /*        
                public static string ReverseName(string name)
                {
                    var array = new char[name.Length];
                    for (var i = name.Length; i > 0; i--)
                        array[name.Length - i] = name[i - 1];

                    return new string(array);*/
        //case 2
        /*
                public static List<int> GetUniqueNumbers(List<int> numbers)
                {
                    var uniques = new List<int>();
                    foreach (var number in numbers)
                    {
                        if (!uniques.Contains(number))
                            uniques.Add(number);
                    }
                    return uniques;
                }*/

        //dec 29,2020
        public static List<int>  GetSmallests(List<int> list, int count)
        {
            //the first four lines make sure no null and no meaningless request 
            if (list == null)
                throw new ArgumentNullException("list");
            if (count > list.Count || count <=0)
                throw new ArgumentOutOfRangeException("count", "count should be between one and the number of elements in the list");
            var buffer = new List<int>(list); //create a new list and pass the original list here
            var smallests = new List<int>();
            while (smallests.Count < count)
            {
                var min = GetSmallest(buffer);
                smallests.Add(min);
                buffer.Remove(min);
            }
            return smallests;
        }

        public static int GetSmallest(List<int> list)
        {
            //assume the first number is the smallest
            var min = list[0];
            for (var i =1; i<list.Count; i++)
            {
                if (list[i] < min)
                    min = list[i];
            }
            return min;
        }


    static void Main(string[] args)
    {
            //dec 29,2020
            var numbers = new List<int> { 1,2,3,4,5};
            var smallests = GetSmallests(null, 3);

            foreach (var number in smallests)
                Console.WriteLine(number);



            //dec 28,2020
            //section 76 exercise:
            ///1 - Write a program that reads a text file and displays the number of words.
            ///ReadAllLines takes the file in as a string array.            
            ///ReadAllText take the file in as single string(not an array).
            ///https://stackoverflow.com/questions/2965497/what-is-the-difference-between-file-readalllines-and-file-readalltext
            /*
            var path = @"C:\Users\Maggie\Desktop\exercise_section76.txt";
            var content = File.ReadAllText(path);
            Console.WriteLine(content);

            int length = content.Length; //includs the number of whitespaces
            Console.WriteLine(length);

            ///2 - Write a program that reads a text file and displays the longest word in the file.
            var list = content.Split(' ');
            Console.WriteLine(list);
            foreach (string word in list)
                Console.WriteLine(word);
            var max = list[0].Length;
            for (int i=1; i < list.Length; i++){
                if (list[i].Length > max)
                    max = list[i].Length;
            }
            Console.WriteLine(max);
*/


            // dec 27,2020
            ///file and fileInfo
            /*            var path = @"C:\Users\Maggie\Desktop\copy.jpg";
                        File.Copy(@"C:\Users\Maggie\Desktop\WeChat Image_20201222114032.jpg", @"C:\Users\Maggie\Desktop\copy.jpg",true);
                        //File.Delete(path);//All methods of the File class are static.
            *//*            if (File.Exists(path))
                        {
                            Console.WriteLine("no");
                        }*//*
                        //var content = File.ReadAllText(path);
                        //Console.WriteLine(content);

                        var fileInfo = new FileInfo(path);
                        fileInfo.CopyTo(@"C:\Users\Maggie\Desktop\copy1.jpg",true);
                        fileInfo.Delete();
                        //FileInfo has no ReadAllText method
                        if (fileInfo.Exists)
                        {
                            //
                        }
                        */
            //directory and directryInfo;
            /*            Directory.CreateDirectory(@"C:\Users\Maggie\Desktop\new");
                        var list = Directory.GetFiles(@"C:\Users\Maggie\Desktop\", "*.jpg", SearchOption.AllDirectories);
                        foreach (var file in list)
                            Console.WriteLine(file);*/
            /*
                        var directories = Directory.GetDirectories(@"C:\Users\Maggie\Desktop\", "*.*", SearchOption.AllDirectories);
                        foreach (var directory in directories)
                            Console.WriteLine(directory);

                        Directory.Exists("...");*/
            /*
                        var directoryInfo = new DirectoryInfo(@"C:\Users\Maggie\Desktop\");
                        var list = directoryInfo.GetFiles();
                        foreach (var directory in list)
                            Console.WriteLine(directory);

                        directoryInfo.GetDirectories();*/

            //Path:
            //var path = @"C:\Users\Maggie\Desktop\copy.jpg";
            /*
                        //to get the extension, this is a low level method:
                        var dotIndex = path.IndexOf("."); // then use Substring method to separate key / value pairs 
                                                           //that are delimited by an equals(".") character.
                        var extension = path.Substring(dotIndex); //this will give the extension: '.jpg'
                        Console.WriteLine(extension);*/

            //a preferred method:
            /*            Console.WriteLine("Extension: "+ Path.GetExtension(path)); //result: '.jpg'
                        Console.WriteLine("File name: " + Path.GetFileName(path)); //result: copy.jpg
                        Console.WriteLine("File name without extension: " + Path.GetFileNameWithoutExtension(path)); 
                        Console.WriteLine("Get directory name: " + Path.GetDirectoryName(path)); 

            */

            //procedure programming
            //case 1:

            /*            Console.Write("input your name: ");
                        var name = Console.ReadLine();
                        var reversed = ReverseName(name);


                        Console.WriteLine("reversed name: " + reversed);
            */
            //case 2
            /*
                    var numbers = new List<int>();
                        while (true)
                        {
                            Console.Write("Enter a number (or 'Quit' to exit): ");
                            var input = Console.ReadLine();

                            if (input.ToLower() == "quit")
                                break;

                            numbers.Add(Convert.ToInt32(input));
                        }
            *//*
                        var uniques = new List<int>();
                        foreach (var number in numbers)
                        {
                            if (!uniques.Contains(number))
                                uniques.Add(number);
                        }*//*

                        Console.WriteLine("the unique numbers you have entered: ");
                        foreach (var number in GetUniqueNumbers(numbers))
                            Console.WriteLine(number);

            */
            //Dec 26 2020
            //section 69 exercise
            /// <summary>
            /// Write a program and ask the user to enter a few numbers separated by a hyphen. Work out 
            /// if the numbers are consecutive. For example, if the input is "5-6-7-8-9" or "20-19-18-17-16", 
            /// display a message: "Consecutive"; otherwise, display "Not Consecutive".
            /// </summary>
            /*            /// 
                        Console.Write("enter a few numbers (eg 1-2-3-4):" );
                        var input = Console.ReadLine();

                        var numbers = new List<int>();
                        foreach (var number in input.Split('-')) 
                            numbers.Add(Convert.ToInt32(number));

                        numbers.Sort();

                        var isConsecutive = true;
                        for (var i = 1; i < numbers.Count; i ++)
                        {
                            if (numbers[i] != numbers[i - 1] + 1)
                            {
                                isConsecutive = false;
                                break;
                            }
                        }

                        var message = isConsecutive ? "consecutive" : "not consecutive";
                        Console.WriteLine(message);
            */
            /// <summary>
            /// Write a program and ask the user to enter a few numbers separated by a hyphen. If the user simply 
            /// presses Enter without supplying an input, exit immediately; otherwise, check to see if there are 
            /// any duplicates. If so, display "Duplicate" on the console.
            /// </summary>
            /*            
                        Console.Write("enter a few numbers (eg 1-2-3-4):");
                        var input = Console.ReadLine();

                        if (String.IsNullOrWhiteSpace(input))
                            return;

                        var numbers = new List<int>();
                        foreach (var number in input.Split("-"))
                            numbers.Add(Convert.ToInt32(number));

                        var uniques = new List<int>();
                        var hasDuplicates = false;
                        foreach (var number in numbers)
                        {
                            if (!uniques.Contains(number))  //check if unique has the number
                                uniques.Add(number);
                            else
                            {
                                hasDuplicates = true;
                                break;
                            }
                        }
                        if (hasDuplicates)
                            Console.WriteLine("duplicate");*/

            /// <summary>
            /// Write a program and ask the user to enter a time value in the 24-hour time format (e.g. 19:00).
            /// A valid time should be between 00:00 and 23:59. If the time is valid, display "Ok"; otherwise, 
            /// display "Invalid Time". If the user doesn't provide any values, consider it as invalid time. 
            /*          /// </summary>
                      Console.WriteLine("enter a time: (e.g. 19:00)");
                      var input = Console.ReadLine();

                      if (String.IsNullOrWhiteSpace(input))
                      {
                          Console.WriteLine("invalid");
                          return;
                      }

                      var components = input.Split(':'); //will get a list of two strings
                      if (components.Length != 2)
                      {
                          Console.WriteLine("Invalid time");
                          return;
                      }

                      try
                      {
                          var hour = Convert.ToInt32(components[0]);
                          var min = Convert.ToInt32(components[1]);

                          if (hour >=0 && hour <=23 && min >=0 && min <=59)
                              Console.WriteLine("OK");
                          Console.WriteLine("Invalid time");
                      }

                      catch (Exception)
                      {
                          Console.WriteLine("invalid time");
                      }
          */

            /// <summary>
            /// Write a program and ask the user to enter a few words separated by a space. Use the words to 
            /// create a variable name with PascalCase convention. For example, if the user types: 
            /// "number of students", display "NumberOfStudents". Make sure the program is not dependent on 
            /// the casing of the input. So if the input is "NUMBER OF STUDENTS", it should still display 
            /// "NumberOfStudents". If the user doesn't supply any words, display "Error".
            /// </summary>
            /*/// 
            Console.Write("enter a few words separated by a space: ");
            var input = Console.ReadLine();

            if (String.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("error");
                return;
            }

            var text = "";
            foreach (var word in input.Split(' '))
            {
                var wordPascalCase = char.ToUpper(word[0]) + word.ToLower().Substring(1);
                text += wordPascalCase;
            }
            Console.WriteLine(text);


            var name = "";
            foreach (var word in input.Split(' '))
            {
                var wordPascalCase = char.ToUpper(word[0]) + word.ToLower().Substring(1);
                name += wordPascalCase;
            }

            Console.WriteLine(name);*/

            /// <summary>
            /// Write a program and ask the user to enter an English word. Count the number of vowels 
            /// (a, e, o, u, i) in the word. So, if the user enters "inadequate", the program should display 
            /// 6 on the console. Make sure the program calculates the number of vowels irrespective of the 
            /// casing of the word (eg "Inadequate", "inadequate" and "INADEQUATE" all include 6 vowels).
            /// </summary>
            /// 
            /*
                        Console.Write("enter a word");
                        var input = Console.ReadLine().ToLower();

                        var vowels = new List<char>(new char[] { 'a', 'e', 'i', 'o', 'u' });
                        var vowelsCount = 0;
                        foreach (var letter in input)
                        {
                            if (vowels.Contains(letter))
                                vowelsCount++;
                        }
                        Console.WriteLine(vowelsCount);*/


            //section 67: StringBuilder
            //var builder = new StringBuilder("Hello World");
            /*            builder.Append('-', 10);
                        builder.AppendLine();
                        builder.Append("Header");
                        builder.AppendLine();            
                        builder.Append('-', 10);
            */

            //to make the previous code clean, we can:
            /*
                        builder
                            .Append('-', 10)
                            .AppendLine()
                            .Append("Header")
                            .AppendLine()
                            .Append('-', 10)
                            .Replace('-', '+')
                            .Remove(0, 10)                 //from the beginning, remove 10 chars
                            .Insert(0, new string('-', 10)); //add a line of 10 '-'
                        Console.WriteLine(builder);
                        Console.WriteLine("first Char is: " + builder[0]);*/


            /*
                        //to summarize a long sentence
                        var sentence = "this is going to be a really really really long text.";
                        var sum = StringUtility.SummerizeText(sentence);
                        Console.WriteLine(sum);*/

            /*            the whole thing will be moved to a new class: StringUtility.cs
             *            static string SummerizeText(string sentence, int maxLenghth=26)
                        {
                            if (sentence.Length < maxLenghth)
                                return sentence;

                            var words = sentence.Split(' ');     //use whitespace to separate the sentence;
                            var totalChar = 0;
                            var summaryWords = new List<string>();

                            foreach (var word in words)
                            {
                                summaryWords.Add(word);

                                totalChar += word.Length + 1; //+1 because of the space after the word
                                if (totalChar > maxLenghth)
                                    break;
                            }

                            var summary = String.Join(" ", summaryWords) + "...";
                            return summary;

                        }
            */
            //string
            /*            var fullName = "Mosh Zhang "; //leave a whitespace char at the end
                        //trim method:
                        Console.WriteLine("Trim: '{0}'", fullName.Trim());
                        Console.WriteLine("ToUpper: '{0}'", fullName.Trim().ToUpper());*/
            /*
                        //split the string and captitize the first letter:
                        //using indexOf and Substring method
                        var index = fullName.IndexOf(' '); //use the whitespace to find index
                        var firstName = fullName.Substring(0, index); //from beginning to the index
                        var lastName = fullName.Substring(index + 1); //from index all the way to the end
                        Console.WriteLine("name is: {0}.{1}",firstName,lastName);*/

            /*            //an easier way to split the string and captitize the first letter:
                        var names = fullName.Split(' ');
                        Console.WriteLine("name is: {0}.{1}", names[0], names[1]);
            */
            //replace
            /*            Console.WriteLine(fullName.Replace("Mosh", "Moshy")); 
                        fullName.Replace('o', 'O');*/

            /*            //validate a creditcard number
                        if (String.IsNullOrEmpty(null))
                            Console.WriteLine("invalid");

                        if (String.IsNullOrEmpty(" ".Trim())) //this is trim the whitespace to get the IsNullOrEmpty work
                            Console.WriteLine("invalid");

                        if (String.IsNullOrWhiteSpace("")) //IsNullOrWhiteSpace includes empty as well
                            Console.WriteLine("invalid");

                        //convert numbers to string
                        var str = "25";
                        var number = Convert.ToByte(str);   //no one is older than 255
                        Console.WriteLine("your age is {0}", number);

                        float price = 29.99f;
                        Console.WriteLine(price.ToString("C")); 
                        Console.WriteLine(price.ToString("C0"));  //this will round it to $30*/

            //Dec 25 2020
            //datetime
            /*            var dateTime = new DateTime(2005, 3, 19);
                        var now = DateTime.Now; //this includes time
                        var today = DateTime.Today; //this is only the date
            *//*
                        Console.WriteLine(now.Hour);
                        Console.WriteLine(now.Minute);
            *//*
                        var tomorrow = now.AddDays(1);
                        var yesterday = now.AddDays(-1);

                        //can convert time and date to string
                        Console.WriteLine($"Current culture: \"{CultureInfo.CurrentCulture.Name}\"\n");
                        Console.WriteLine(now.ToLongDateString()); //crtl+D: repeat the line
                        Console.WriteLine(now.ToShortDateString());
                        Console.WriteLine(now.ToLongTimeString());//this include seconds
                        Console.WriteLine(now.ToShortTimeString());
                        Console.WriteLine(now.ToString()); //display both date and time
                        Console.WriteLine(now.ToString("yyyy-MMMM-dd HH:mm")); //if you want to know more, go to google
                                                                               //c# datetime format specifier*/
            //create time span
            /*            var timeSpan = new TimeSpan(1, 2, 3); //args: hour min sec

                        var timeSpan1 = new TimeSpan(1, 0, 0); //args: hour min sec
                        var timeSpan2 = TimeSpan.FromHours(1); //this is more readable

                        var start = DateTime.Now;
                        var end = DateTime.Now.AddMinutes(2);
                        var duration = end - start;
                        Console.WriteLine(duration);

                        //properties
                        Console.WriteLine("minutes: " + timeSpan.Minutes);
                        Console.WriteLine("total minutes: " + timeSpan.TotalMinutes); // this will turn the hour into minutes

                        //time span is immutable, you cannot change the value
                        //but you can create new 
                        Console.WriteLine("Add Example: " + timeSpan.Add(TimeSpan.FromMinutes(8))); //result will be 01:10:03
                        Console.WriteLine("Add Example: " + timeSpan.Subtract(TimeSpan.FromMinutes(8))); //result will be 01:10:03

                        //ToString
                        Console.WriteLine("ToString" + timeSpan.ToString());

                        //Parse method to conversion from a string:
                        Console.WriteLine("Parse: " + TimeSpan.Parse("01:02:03"));
            */


            //section 7 quiz 6



            //section 56 lists exercise 1
            ///1 - When you post a message on Facebook, depending on the number of people who like your post, 
            ///Facebook displays different information.Write a program and continuously ask the user to enter 
            ///different names, until the user presses Enter (without supplying a name). 
            ///Depending on the number of names provided, display a message based on the above pattern.

            /*            var names = new List<string>();
                        while (true)
                        {
                        Console.Write("type a name (or hit Enter to quit): ");
                        var input = Console.ReadLine();

                        if (String.IsNullOrWhiteSpace(input))
                            break;
                            names.Add(input);
                        }

                        if (names.Count >2)
                            Console.WriteLine("{0}, {1}, and {2} others like your post", names[0], names[1], names.Count-2);
                        if (names.Count ==2)
                            Console.WriteLine("{0}, {1}, like your post", names[0], names[1]);
                        if (names.Count ==1)
                            Console.WriteLine("{0} likes your post", names[0]);
                        else
                            Console.WriteLine();*/

            //section 56 lists exercise 2
            /// <summary>
            /// Ask the user to enter their name. Use an array to reverse the name and then store the result in a new string. 
            /// Display the reversed name on the console.
            /// </summary>
            /*            Console.Write("input your name: ");
                        var name = Console.ReadLine();

                        var array = new char[name.Length];
                        for (var i = name.Length; i > 0; i--)
                            array[name.Length - i] = name[i - 1];

                        //Console.WriteLine("reversed name: " + array);//array cannot be displayed,printed as System.Char[]

                        var reversed = new string(array);
                        Console.WriteLine("reversed name: " + reversed);
            */
            /// section 56 lists exercise 3
            /// <summary>
            /// Write a program and ask the user to enter 5 numbers. If a number has been previously entered, display 
            /// an error message and ask the user to re-try. Once the user successfully enters 5 unique numbers, sort them 
            /// and display the result on the console.
            /// </summary>
            /*
                        var numbers = new List<int>();
                        while (numbers.Count < 5)
                        {
                            Console.Write("input 5 different numbers: ");
                            var number = Convert.ToInt32(Console.ReadLine());
                            if (numbers.Contains(number))
                            {
                                Console.WriteLine("This number has been entered " +number);
                                continue;
                            }
                            numbers.Add(number);
                        }

                        numbers.Sort();         
                        foreach (var number in numbers)
                            Console.WriteLine(number);
            */

            /// section 56 lists exercise 4
            /// <summary>
            /// Write a program and ask the user to continuously enter a number or type "Quit" to exit. The list of numbers may 
            /// include duplicates. Display the unique numbers that the user has entered.
            /// </summary>

            /*            var numbers = new List<int>();
                        while (true)
                        {
                            Console.Write("Enter a number (or 'Quit' to exit): ");
                            var input = Console.ReadLine();

                            if (input.ToLower() == "quit")
                                break;

                            numbers.Add(Convert.ToInt32(input));
                        }

                        var uniques = new List<int>();
                        foreach (var number in numbers)
                        {
                            if (!uniques.Contains(number))
                                uniques.Add(number);
                        }
                        Console.WriteLine("the unique numbers you have entered: ");
                        foreach (var number in uniques)
                            Console.WriteLine(number);*/


            /// section 56 lists exercise 5
            /// <summary>
            /// Write a program and ask the user to supply a list of comma separated numbers (e.g 5, 1, 9, 2, 10). If the list is 
            /// empty or includes less than 5 numbers, display "Invalid List" and ask the user to re-try; otherwise, display 
            /// the 3 smallest numbers in the list.
            /// 
            /// </summary>
            /*
                        string[] elements; //Create an Array

                        while (true) 
                        {
                            Console.Write("supply a list of comma separated numbers (e.g 5, 1, 9, 2, 10)");
                            var input = Console.ReadLine();

                            if (!String.IsNullOrWhiteSpace(input))
                            {
                                elements = input.Split(',');
                                if (elements.Length >= 5)
                                    break;
                            }
                            Console.Write("Invalid list");
                        }

                        var numbers = new List<int>();
                        foreach (var number in elements)
                            numbers.Add(Convert.ToInt32(number));

                        *//*
                                    numbers.Sort();
                                    Console.WriteLine("the smallest numbers are: {0},{1},{2} ",numbers[0], numbers[1],numbers[2]);
                                    *//*

                        var smallests = new List<int>();
                        while (smallests.Count < 3)
                        {
                            //assume the first number is the smallest
                            var min = numbers[0];
                            foreach (var number in numbers)
                            {
                                if (number < min)
                                    min = number;
                            }
                            smallests.Add(min);
                            numbers.Remove(min);                   
                        }

                        Console.WriteLine("the 3 smallest nubmers are: "); 
                        foreach (var number in smallests)
                            Console.WriteLine(number); 
            */

            //section 54 lists
            /*            var numbers = new List<int>() { 1,2,3,4};
                        numbers.Add(1); //unlike arrays, list has no limit of length
                        numbers.AddRange(new int[3] { 4, 5, 6 });

                        foreach (var n in numbers)
                            Console.WriteLine(n);*/

            //indexOf
            /*            var indexOf1 = numbers.IndexOf(1);
                        Console.WriteLine(indexOf1); // result is 0, only the first 1 shows
                        var lastIndexOf1 = numbers.LastIndexOf(1);
                        Console.WriteLine(lastIndexOf1);
            */
            //Count
            /*            Console.WriteLine("count: "+ numbers.Count); //shows the number of objects in the list*/

            //Remove
            /*            numbers.Remove(1); //onley removes the first "1"
                        foreach (var n in numbers)
                            Console.WriteLine(n);
            */
            //remove all 1s
            /*            foreach (var number in numbers) //this will throw an error because collection canot be modified
                        {
                            if (number == 1)
                                numbers.Remove(number);
                        }*/
            /*
                        for (var i=0; i<numbers.Count; i++)
                        {
                            if (numbers[i] == 1)
                                numbers.Remove(numbers[i]);
                        }
                        foreach (var n in numbers)
                            Console.WriteLine(n);

                        //Clear() will clear all in the list
                        numbers.Clear();
                        Console.WriteLine("count is: " + numbers.Count ); */

            //section 52 arrays
            //var numbers = new[] { 3, 5, 7, 9, 14, 6};
            /*
                        //Length
                        Console.WriteLine(numbers.Length);
            */
            /*            //IndexOf()
                        var index = Array.IndexOf(numbers, 9);
                        Console.WriteLine(index);*/
            /*
                        //Clear()
                        Array.Clear(numbers, 0, 2);
                        foreach (var n in numbers)
                            Console.WriteLine(n);
            */
            /*            //Copy()
                        int[] another = new int[3];
                        Array.Copy(numbers, another, 3);
                        Console.WriteLine(another);//this will only show "System.Int32[]", not the array
                        foreach (var n in another)
                            Console.WriteLine(n);
            */

            /*            //Sort() //order the array
                        Array.Sort(numbers);
                        foreach (var n in numbers)
                            Console.WriteLine(n);*/


            /*            //Reverse()
                        Array.Reverse(numbers);
                        foreach (var n in numbers)
                            Console.WriteLine(n); */

            /// <summary>
            /// exercise 1 of section 49
            /// Write a program to count how many numbers between 1 and 100 are divisible by 3 with no remainder. 
            /// Display the result on the console.
            /*        /// </summary>

                                var count = 0;
                                for (var i = 1; i <= 100; i++)
                                {
                                    if (i % 3 == 0)
                                        count++;
                                }
                                Console.WriteLine("there are {0} numbers can be devisible by 3 with no remainder", count);
                    */
            /// exercise 2 of section 49
            /// <summary>
            /// Write a program and continuously ask the user to enter a number. The loop terminates when the user 
            /// enters “ok". Calculate the sum of all the previously entered numbers and display it on the console.
            /// </summary>
            /*            var sum = 0;
                        while (true)
                        {
                            Console.Write("enter a number (or 'ok' to exit):");
                            var input = Console.ReadLine();

                            if (input.ToLower() == "ok")
                                break;
                            sum += Convert.ToInt32(input);

                        }
                        Console.WriteLine("sum of all input numbers is: " + sum);
            */
            /// exercise 3 of section 49
            /// <summary>
            /// Write a program which takes a single argument from the console, computes the factorial and prints the 
            /// value on the console. For example, if the user enters 5, the program should calculate 5 x 4 x 3 x 2 x 1 
            /// and display it as 5! = 120.
            /// </summary>
            /// 
            /*
                        var factorial = 1;

                        Console.Write("enter a number: ");
                        var number = Convert.ToInt32(Console.ReadLine());
                        for (var i = 1; i <= number; i++)
                            factorial *= i;
                        Console.WriteLine("{0}! = {1}", number, factorial);*/

            /// <summary>
            /// Write a program that picks a random number between 1 and 10. Give the user 4 chances to guess the number. 
            /// If the user guesses the number, display “You won". Otherwise, display “You lost".
            /// </summary>
            /*            var number = new Random().Next(1, 10);

                        Console.WriteLine("the number is: " + number);
                        for (var i = 0; i< 4; i++)
                        {
                            Console.Write("Guess the secret number: ");
                            var guess = Convert.ToInt32(Console.ReadLine());

                            if(guess == number)
                            {
                                Console.WriteLine("You won!");
                                return;
                            }
                        }
                        Console.WriteLine("you lost");*/

            /// <summary>
            /// Write a program and ask the user to enter a series of numbers separated by comma. Find the maximum of the 
            /// numbers and display it on the result. For example, if the user enters “5, 3, 8, 1, 4", the program should 
            /// display 8 on the console.
            /// </summary>
            /*            Console.Write("Enter comma separated numbers: ");
                        var input = Console.ReadLine();

                        var numbers = input.Split(',');

                        var max = Convert.ToInt32(numbers[0]);

                        foreach (var str in numbers)
                        {
                            var number = Convert.ToInt32(str);
                            if (number > max) 
                                max = number;
                        }
                        Console.WriteLine("the max is: "+ max);*/

            /// <summary>
            /// Write a program which takes a single argument from the console, computes the factorial and prints the 
            /// value on the console. For example, if the user enters 5, the program should calculate 5 x 4 x 3 x 2 x 1 
            /// and display it as 5! = 120.
            /// </summary>
            //exercise 1 of section 43
            /// <summary>
            /// Write a program and ask the user to enter a number. The number should be between 1 to 10. If the user enters 
            /// a valid number, display "Valid" on the console. Otherwise, display "Invalid". (This logic is used a lot in 
            /// applications where values entered into input boxes need to be validated.)
            /// </summary>

            /*            Console.WriteLine("type a number between 1-10:");
                        var input = Console.ReadLine();
                        var number = Convert.ToInt32(input);
                        if (number >=1 && number <=10)
                            Console.WriteLine("VALID");
                        else Console.WriteLine("invalid");*/

            //exercise 2: Write a program which takes two numbers from the console and displays the maximum of the two.
            /*            Console.WriteLine("enter a number for number1:");
                        var number1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("enter a number for number2:");
                        var number2 = Convert.ToInt32(Console.ReadLine());

                        var max = (number1 > number2 ? number1 : number2);
                        Console.WriteLine("max of the 2 numbers is: " + max);*/

            /// <summary>
            /// Write a program and ask the user to enter the width and height of an image. Then tell if the image 
            /// is landscape or portrait.
            /// </summary>
            //exercise 3
            /*            Console.WriteLine("enter a number for the width:");
                        var width = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("enter a number for the height:");
                        var height = Convert.ToInt32(Console.ReadLine());

                        *//*            if (width>height)
                                        Console.WriteLine("this is a protrait");
                                    else if (width<height)
                                        Console.WriteLine("this is a landscape");
                                    else
                                        Console.WriteLine("this is a square");*//*

                        //to use the code underneath, you need to have a class file for ImageOrientation
                        var orientation = width > height ? ImageOrientation.Landscape : ImageOrientation.Portrait;
                        Console.WriteLine("Image orientation is " + orientation);*/
            /// <summary>
            /// Your job is to write a program for a speed camera. For simplicity, ignore the details such as camera, sensors, 
            /// etc and focus purely on the logic. Write a program that asks the user to enter the speed limit. Once set, 
            /// the program asks for the speed of a car. If the user enters a value less than the speed limit, program should 
            /// display Ok on the console. If the value is above the speed limit, the program should calculate the number of 
            /// demerit points. For every 5km/hr above the speed limit, 1 demerit points should be incurred and displayed on 
            /// the console. If the number of demerit points is above 12, the program should display License Suspended.
            /// </summary>
            /*            // exercise 4
                        Console.WriteLine("enter the speed limit:");
                        var speedLimit = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("enter the speed now: ");
                        var speed = Convert.ToInt32(Console.ReadLine());

                        if (speed <= speedLimit)
                            Console.WriteLine("OK");

                        else
                        {
                            const int kmPerDemeritPoint = 5;
                            var demeritPoint = (speed - speedLimit) / kmPerDemeritPoint;
                            if (demeritPoint > 12)
                                Console.WriteLine("License suspended");
                            else
                                Console.WriteLine("Demerit point is: "+ demeritPoint);
                        }   */

            /*            for (var i = 1; i <= 10; i++)
                        {
                            if (i%2 == 0)
                            {
                                Console.WriteLine(i);
                            }
                        }
                        for (var i=10; i >=1; i--)
                        {
                            if (i%2 == 0)
                            {
                                Console.WriteLine(i);
                            }
                        }*/
            /*
                        var i = 0;
                        while (i <= 10) //while loop here is less effective than for loop
                        {
                            if (i%2==0)
                                Console.WriteLine(i);
                            i++;
                        }
            */

            /*            while (true) //when you do not know exact time for the program to run, while is good 
                        {
                            Console.Write("type your name: ");
                            var input = Console.ReadLine();*/
            /*
                            if (String.IsNullOrWhiteSpace(input))
                                break;
                            Console.WriteLine("@Echo: " +input); */
            /*               
                            if (!String.IsNullOrWhiteSpace(input))
                            {
                                Console.WriteLine("@Echo: " +input);
                                continue; //this will go back to the start of the program
                            }
                            break;
                        }
            */

            /*            var random = new Random();

                        const int passwordLength = 10;

                        var buffer = new char[passwordLength]; //this can be char []  buffer as well, var is used to keep cleaner
                        for (var i = 0; i < passwordLength; i++)
                            buffer[i] = (char)('a' + random.Next(0, 26));
                        //Console.WriteLine(random.Next()); //next method
                        //Console.WriteLine((char)random.Next(97,122)); // random strings from a to z in individual lines
                        //Console.Write((char)random.Next(97, 122)); // a random sting in one line using Write method
                        //Console.Write((char)('a'+ random.Next(0, 26))); //this will display 9 random letters 
                        // Console.Write((char)'a');//this will display 10 "a"s

                        var password = new string(buffer);
                        Console.WriteLine(password);*/

            //Console.WriteLine((int) 'a'); //97 represents char a in the computer, ASCII stands for american standard code for international interchange


            /*            var name = "John"; //for loop
                        for (var i = 0; i < name.Length; i++)
                        {
                            Console.WriteLine(name[i]);
                        }
                        foreach (var character in name)//foreach is more effective
                        {
                            Console.WriteLine(character);
                        }
            */
            /*
                        var numbers = new int[] { 1, 2, 3, 4 }; //create new array
                        foreach (var number in numbers)
                        {
                            Console.WriteLine(number);
                        }*/

            /*            Person john = new Person();
                        john.FirstName = "john";
                        john.LastName = "smith";
                        john.Introduce();*/

            /*            Calculator Calculator = new Calculator();
                        var result = Calculator.Add(1, 2);
                        System.Console.WriteLine(result);*/


            /*            //int [] numbers = new int [3];
                        var numbers = new int[3] { 1, 2, 3 };
                        System.Console.WriteLine(numbers[0]);
                        System.Console.WriteLine(numbers[1]);
                        System.Console.WriteLine(numbers[2]);*/
            /*
                        var flags = new bool[3];
                        flags[0] = true;
                        System.Console.WriteLine(flags[0]);
                        System.Console.WriteLine(flags[1]);
                        System.Console.WriteLine(flags[2]);*/

            //var names =  new string[3] {"jack", "john", "mary"};

            /*            var firstName = "Mosh";
                        var lastName = "Ham";

                        var fullName = firstName + " " + lastName;

                        var myFullName = string.Format("my name is {0} {1}", firstName, lastName);

                        var names = new string[3] { "jack", "john", "mary" };
                        var formattedNames = string.Join(",", names);
                        Console.WriteLine(formattedNames);

                        var text = @"hi John
            Look into the following paths
            c:\\folder1\\folder2
            c:\folder3\folde4";
                        Console.WriteLine(text);*/
            /*
                        var method = ShippingMethod.Express;
                        Console.WriteLine((int)method);

                        var methodId = 3;
                        Console.WriteLine((ShippingMethod)methodId);


                        Console.WriteLine(method.ToString());

                        var methodName = "Express";
                        var shippingMethod = (ShippingMethod)Enum.Parse(typeof(ShippingMethod), methodName);
                        Console.WriteLine(shippingMethod);*/
            /*
                        var a = 10;
                        var b = a;
                        b++;
                        Console.WriteLine(string.Format("a: {0}, b:{1}",a,b));

                        var array1 = new int[3] { 1, 2, 3 };
                        var array2 = array1;
                        array2[0] = 0; //this will change array1 as well
                        Console.WriteLine(string.Format("array1[0]:{0}, array2[0]: {1}", array1[0], array2[0]));
            */
            /*            var number = 1;
                        Increment(number);//this is a value type, so the object will not be changed.  they are two independent values in the memory.
                        //Console.WriteLine(number);

                        var person = new Person() { Age = 20 };
                        MakeOld(person); //this is a reference type, so both will be changed.
                        Console.WriteLine(person.Age);*/

            /*            int hour = 19;
                        if (hour >0 && hour <12)
                            Console.WriteLine("it is morning");
                        else if (hour>=12 && hour <18)
                            Console.WriteLine("it is afternoon");
                        else
                        {
                            Console.WriteLine("it is evening");
                        }
            */
            /*            bool isGoldCustomer = true;
                        //float price;

                        *//*            if (isGoldCustomer)
                                        price = 19.95f;
                                    else
                                        price = 29.95f;*//*

                        float price = (isGoldCustomer) ? 19.95f : 29.95f; //this is the same like the code group up this line

                        Console.WriteLine(price);*/
            /*            var season = Season.Fall;
                        switch (season)
                        {
                            case Season.Fall:
                            case Season.Spring: //this is for two seasons
                                Console.WriteLine("it is a nice season");
                                break;

                            default:
                                Console.WriteLine("this season has no fun");
                                break;
                        }*/





        }
        /*        public static void Increment(int number)
                {
                    number += 10;
                    Console.WriteLine(number);
                }

                public static void MakeOld(Person person)
                {
                    person.Age += 10;
                }*/




    }


}
