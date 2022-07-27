//1.
//using System;
//class ex
//{
//    static void Main()
//    {
//        Console.WriteLine("Hello");
//        Console.WriteLine("Meet Savaliya");
//    }
//}


//2.
//using System;
//class ex1
//{
//    static void Main()
//    {
//        int a,b,sum;
//        a = 10;
//        b = 5;
//        sum = a + b;
//        Console.WriteLine( "sum is :"+sum);
//    }
//}


//3.
//using System;
//class ex1
//{
//    static void Main()
//    {
//        int a,b,div;
//        a = 10;
//        b = 5;
//        div = a / b;
//        Console.WriteLine( "Division is :"+div);
//    }
//}


//4.
//using System;
//class e1
//{
//    static void Main()
//    {
//        int i, j, k, l;
//        i = -1 + 4 * 6;
//        j = ( 35+ 5 ) % 7;
//        k = 14 + -4 * 6 / 11;
//        l = 2 + 15 / 6 * 1 - 7 % 2 ;
//        Console.WriteLine(i);
//        Console.WriteLine(j);
//        Console.WriteLine(k);
//        Console.WriteLine(l);
//    }
//}


//5.
//using System;
//class e
//{
//    static void Main()
//    {
//        int i, j, k;
//        i = 10;
//        j = 20;
//        k = i;
//        i = j;
//        j = k;
//        Console.WriteLine("number1: "+i);
//        Console.WriteLine("number2: "+j);
//    }
//}
//using System;
//class e
//{
//    static void Main()
//    {
//        int i, j, k;
//        Console.WriteLine("enter first number: ");
//        i = int.Parse(Console.ReadLine());
//        Console.WriteLine("enter secind number: ");
//        j = int.Parse(Console.ReadLine());
//        k = i;
//        i = j;
//        j = k;
//        Console.WriteLine("number1: "+i);
//        Console.WriteLine("number2: "+j);
//    }
//}


//6.
//using System;
//class a1
//{
//    static void Main()
//    {
//        int i, j, k ,mul;
//        Console.WriteLine("enter first number: ");
//        i = Convert.ToInt32(Console.ReadLine());
//        Console.WriteLine("enter second number : ");
//        j = Convert.ToInt32(Console.ReadLine());
//        Console.WriteLine("enter third number : ");
//        k = Convert.ToInt32(Console.ReadLine());

//        mul = i * j * k;
//        Console.WriteLine("MULTIPLICATION IS: "+mul);
//    }
//}


//7.
//using System;
//class a1
//{
//    static void Main()
//    {
//        int i, j, addi, sub, mul, div;
//        Console.WriteLine("enter first number: ");
//        i = Convert.ToInt32(Console.ReadLine());
//        Console.WriteLine("enter second number : ");
//        j = Convert.ToInt32(Console.ReadLine());
//        addi = i + j;
//        sub = i - j;
//        mul = i * j;
//        div = i / j;
//        Console.WriteLine("ADDITION IS: "+addi);
//        Console.WriteLine("SUBTRACTION IS: "+sub);
//        Console.WriteLine("MULTIPLICATION IS: "+mul);
//        Console.WriteLine("DIVISION IS: "+div);
//    }
//}


//8.
//using System;
//public class a1
//{
// public static void Main()
// {
//  int x;
//  int result;
 
//  Console.WriteLine("Enter a number:");
//  x = Convert.ToInt32(Console.ReadLine() );
   
//  result = x * 1;
//  Console.WriteLine("The table is : {0} x {1} = {2}", x, 1, result);
//  result = x * 2;
//  Console.WriteLine("             : {0} x {1} = {2}", x, 2, result);
//  result = x * 3;
//  Console.WriteLine("             : {0} x {1} = {2}", x, 3, result);
//  result = x * 4;
//  Console.WriteLine("             : {0} x {1} = {2}", x, 4, result);
//  result = x * 5;
//  Console.WriteLine("             : {0} x {1} = {2}", x, 5, result);
//  result = x * 6;
//  Console.WriteLine("             : {0} x {1} = {2}", x, 6, result);
//  result = x * 7;
//  Console.WriteLine("             : {0} x {1} = {2}", x, 7, result);
//  result = x * 8;
//  Console.WriteLine("             : {0} x {1} = {2}", x, 8, result);
//  result = x * 9;
//  Console.WriteLine("             : {0} x {1} = {2}", x, 9, result);
//  result = x * 10;
//  Console.WriteLine("             : {0} x {1} = {2}", x, 10, result);
// }
//}




//9.
//using System;
//class a1
//{
//    static void Main()
//    {
//        int i, j, k, l ,avg;
//        Console.WriteLine("enter first number: ");
//        i = Convert.ToInt32(Console.ReadLine());
//        Console.WriteLine("enter second number : ");
//        j = Convert.ToInt32(Console.ReadLine());
//        Console.WriteLine("enter third number: ");
//        k = Convert.ToInt32(Console.ReadLine());
//        Console.WriteLine("enter fourth number : ");
//        l = Convert.ToInt32(Console.ReadLine());
//        avg = (i + j + k + l) / 4;
//        Console.WriteLine("AVERAGE IS: "+avg);

//    }
//}


//10.
//using System;
//class m1
//{
//    static void Main()
//    {
//        int x, y, z ,a ,b;
//        Console.WriteLine("ENTER FIRST NUMBER: ");
//        x = Convert.ToInt32(Console.ReadLine());
//        Console.WriteLine("ENTER SECOND NUMBER: ");
//        y = Convert.ToInt32(Console.ReadLine());
//        Console.WriteLine("ENTER THIRD NUMBER: ");
//        z = Convert.ToInt32(Console.ReadLine());
//        a=(x+y)*z;
//        b = x * y + y * z;
//        Console.WriteLine("(x+y)*z : "+a);
//        Console.WriteLine("x*y + y*z : "+b);
//    }
//}


//11.
//using System;
//class m1
//{
//    static void Main()
//    {
//        int age;
//        Console.WriteLine("ENTER YOUR AGE: ");
//        age = Convert.ToInt32(Console.ReadLine());

//        Console.WriteLine("You look older than "+age);
//    }
//}


//12.
//using System;
//public class Exercise12
//{
//    public static void Main()
//    {
//        int num; 
  
//        Console.WriteLine("Enter a digit: ");
//        num = Convert.ToInt32( Console.ReadLine() );
  
//        // Part A: "num num num num" using Write
//        Console.Write( num );
//        Console.Write(" ");
//        Console.Write( num );
//        Console.Write(" ");
//        Console.Write( num );
//        Console.Write(" ");
//        Console.Write( num );
//        Console.WriteLine();
  
//        // Part B: "numnumnumnum" using Write
//        Console.Write( num );
//        Console.Write( num );
//        Console.Write( num );
//        Console.WriteLine( num );
//        Console.WriteLine();
  
//        // Part C: "num num num num" using {0}
//        Console.WriteLine("{0} {0} {0} {0}", num);
  
//        // Part D: "numnumnumnum" using {0}
//        Console.WriteLine("{0}{0}{0}{0}", num);
//   }
//}


//13.
//using System;
//public class Exercise13
//{
//    public static void Main()
//    {
//        int x;

//        Console.Write("Enter a number: ");
//        x = Convert.ToInt32(Console.ReadLine());

//        Console.WriteLine("{0}{0}{0}", x);
//        Console.WriteLine("{0} {0}", x);
//        Console.WriteLine("{0} {0}", x);
//        Console.WriteLine("{0} {0}", x);
//        Console.WriteLine("{0}{0}{0}", x);
//    }
//}


//14.
//using System;
//class s1
//{
//    static void Main()
//    {
        
//        Console.WriteLine("ENTER CELSIUS : ");
//        int c = Convert.ToInt32(Console.ReadLine());

//        int k = c + 273;
//        float f = c * 18 / 10 + 32;

//        Console.WriteLine("Kelvin : "+k);
//        Console.WriteLine("Fehrenheit : "+f);

//    }
//}


//15.
//using System;
//using System.Collections.Generic;

//public class Exercise15
//{
//    static void Main(string[] args)
//    {
//        Console.WriteLine(remove_char("Atmiya University", 1));
//        Console.WriteLine(remove_char("Atmiya niversity", 9));
//        Console.WriteLine(remove_char("Atiya niversity", 0));
//    }
//    public static string remove_char(string str, int n)
//    {
//        return str.Remove(n, 1);
//    }
//}


//16.
//using System;
//using System.Text;

//public class Exercise17 {
//  static void Main(string[] args)
//        {
//           string str; 
//           int l= 0;
//           Console.Write("Input a string : ");
//           str = Console.ReadLine();
//           if (str.Length>=1)
//           {
//           var s = str.Substring(0,1);
//           Console.WriteLine(s + str + s);
//           }
//        }
//}


//17.
//using System;
//class m1
//{
//    static void Main()
//    {
//        int a, b;
//        Console.WriteLine("Enter first number : ");
//        a = Convert.ToInt32(Console.ReadLine());

//        Console.WriteLine("Enter second number : ");
//        b = Convert.ToInt32(Console.ReadLine());

//        Console.WriteLine("Check if one is negative and one is positive : ");
//        if (a >= 0 && b >= 0)
//        {
//            Console.WriteLine("true");
//        }
//        else 
//        {
//            Console.WriteLine("false");
//        }
//    }
//}


//18.
//using System;
//class m1
//{
//    static void Main()
//    {
//        int a, b ,c ,d;
//        Console.WriteLine("Enter first number : ");
//        a = Convert.ToInt32(Console.ReadLine());

//        Console.WriteLine("Enter second number : ");
//        b = Convert.ToInt32(Console.ReadLine());

//        if (a == b)
//        {
//            c = (a + b) * 3;
//            Console.WriteLine("triple sum is :" + c);
//        }
//        else
//        {
//            d = a + b;
//            Console.WriteLine("sum is: "+d);
//        }
//    }
//}


//19.
//using System;
//class m
//{
//    static void Main()
//    {
//        double i, j;
//        Console.WriteLine("Enter first number: ");
//        i = Convert.ToInt32(Console.ReadLine());

//        Console.WriteLine("Enter second number: ");
//        j = Convert.ToInt32(Console.ReadLine());

//        if (i > j)
//        {
//            Console.WriteLine("first number is greater than second number ..");
//        }
//        else
//        {
//            Console.WriteLine("second number is greater than first number ..");
//        }
//    }
//}


//20.
//using System;
//class s
//{
//    static void Main()
//    {
//        int a, b;
//        Console.WriteLine("Enter first number: ");
//        a = Convert.ToInt32(Console.ReadLine());

//        Console.WriteLine("Enter second number:  ");
//        b = Convert.ToInt32(Console.ReadLine());

//        if (a == 20 || b == 20 || (a + b) == 20)
//        {
//            Console.WriteLine("TRUE");
//        }

//        else
//        {
//            Console.WriteLine("FALSE");
//        }
//    }
//}


//21.
//using System;
//using System.Collections.Generic;

//public class Ex {
// static void Main(string[] args) {
//  Console.WriteLine("\nInput an integer:");
//  int x = Convert.ToInt32(Console.ReadLine());
//  Console.WriteLine(result(x));
// }

// public static bool result(int n) {
//  if (Math.Abs(n - 100) <= 20 || Math.Abs(n - 200) <= 20)
//   return true;
//  return false;
// }
//}


//22. 
//using System;
//class m
//{
//    static void Main()
//    {
       
//        Console.WriteLine("Enter string : ");
//         string a = Convert.ToString(Console.ReadLine());

//        string b = a.ToLower();
//        Console.WriteLine("lower  :"+b);

//    }
//}

//23.
//using System;  
//public class Ex
//{  
//    public static void Main() 
//      {     
//          Console.WriteLine("Odd numbers from 1 to 99. Prints one number per line.");
//          for (int n = 1; n < (99 + 1); n++)
//            {
//                if (n % 2 != 0)
//                {
//                    Console.WriteLine(n.ToString());
//                }
//            }
                    
//    }
//}


//24. 
//using System;  
//public class Ex
//{  
//    public static void Main() 
//      {     
//          Console.WriteLine("\nSum of the first 500 prime numbers: ");
//           long sum = 0;
//            int ctr = 0;
//            int n = 2;
//            while (ctr < 500)
//              {
//                if (isPrime(n))
//                {
//                    sum += n;
//                    ctr++;
//                }
//                n++;
//            }

//            Console.WriteLine(sum.ToString());
                    
//    }
//     public static bool isPrime(int n)
//        {
//            int x = (int)Math.Floor(Math.Sqrt(n));

//            if (n == 1) return false;
//            if (n == 2) return true;

//            for (int i = 2; i <= x; ++i)
//            {
//                if (n % i == 0) return false;
//            }

//            return true;
//        }
//}


//25.
//using System;
//public class Ex {
// public static void Main() {
//  Console.Write("Input  a number(integer): ");
//  int n = Convert.ToInt32(Console.ReadLine());
//  int sum = 0;
//  while (n != 0) {
//   sum += n % 10;
//   n /= 10;
//  }
//  Console.WriteLine("Sum of the digits of the said integer: " + sum);
// }
//}


//26.
//using System;
//using System.Collections.Generic;
//public class Ex {
// public static void Main() {
//  string line = "Display the pattern like pyramid using the alphabet.";
//  Console.WriteLine("\nOriginal String: " + line);
//  string result = "";
//  List < string > wordsList = new List < string > ();
//  string[] words = line.Split(new [] {
//   " "
//  }, StringSplitOptions.None);
//  for (int i = words.Length - 1; i >= 0; i--) {
//   result += words[i] + " ";
//  }
//  wordsList.Add(result);
//  foreach(String s in wordsList) {

//   Console.WriteLine("\nReverse String: " + s);
//  }
// }
//}


//27.
//using System;
//using System.Collections.Generic;
//using System.IO;

//public class Ex
//{
//    public static void Main()
//    {
//        FileInfo f = new FileInfo("d:/c#/ex.txt");
//        Console.WriteLine("\nSize of a file: " + f.Length.ToString());
//    }
//}


//28.
//using System;
//using System.Collections.Generic;
//public class Ex {
// public static void Main() {
      
//     string hexval = "4B0";
//     Console.WriteLine("Hexadecimal number: "+hexval);
//     int decValue = int.Parse(hexval, System.Globalization.NumberStyles.HexNumber);
//     Console.WriteLine("Convert to-");
//     Console.WriteLine("Decimal number: "+decValue);
//   }
//}


//29.
//using System;
//using System.Collections.Generic;

//public class Ex {
// public static void Main() {
//     int[] first_array = {1, 3, -5, 4};
//     int[] second_array = {1, 4, -5, -2};
     
//      Console.WriteLine("\nArray1: [{0}]", string.Join(", ", first_array));
//      Console.WriteLine("Array2: [{0}]", string.Join(", ", second_array));
      
//      Console.WriteLine("\nMultiply corresponding elements of two arrays: ");
    
//     for (int i = 0; i < first_array.Length; i++)
//          {
                
//          Console.Write(first_array[i] * second_array[i]+" ");
//        }
//     Console.WriteLine("\n");
//   }
//}


//30.
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//public class Ex {
//  static void Main(string[] args)
//        {
//           string str; 
//           int l= 0;
//           Console.Write("Input a string : ");
//           str = Console.ReadLine();
//           if (str.Length>4)
//           {
//              Console.WriteLine(str.Length < 4 ? str + str + str : str.Substring(str.Length - 4)+ str.Substring(str.Length - 4) + str.Substring(str.Length - 4) + str.Substring(str.Length - 4));
//           }
//        }
//}


//31.
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//public class Exercise31 {
//  static void Main(string[] args)
//        {
//           Console.WriteLine("\nInput first integer:");  
//           int x = Convert.ToInt32(Console.ReadLine());
//           if (x > 0)
//           {
//              Console.WriteLine(x % 3 == 0 || x % 7 == 0);
//           }
//        }
//}


//32.
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//public class Exercise32 {
//  static void Main(string[] args)
//        {
//           string str; 
//           Console.Write("Input a string : ");
//           str = Console.ReadLine();
//           Console.WriteLine((str.Length < 6 && str.Equals("Hello")) || (str.StartsWith("Hello") && str[5] == ' '));
//        }
//}


//33.
//using System;
//class a
//{
//    static void Main()
//    {
//        int a, b;
//        Console.WriteLine("enter 1st number: ");
//        a = Convert.ToInt32(Console.ReadLine());

//        Console.WriteLine("enter 2nd number:  ");
//        b = Convert.ToInt32(Console.ReadLine());

//        if (a < 100 && b > 200)
//        {
//            Console.WriteLine("true");
//        }
//        else
//        {
//            Console.WriteLine("false");
//        }
//    }
//}

//34.
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//public class Exercise34 {
//  static void Main(string[] args)
//        {
//            Console.Write("Input a first number: ");
//            int m = Convert.ToInt32(Console.ReadLine());
//            Console.Write("Input a second number: ");
//            int n = Convert.ToInt32(Console.ReadLine());
//            Console.WriteLine(((m >= -10 && m <= 10)) || ((n >= -10 && n <= 10)));
//        }
//}


//35.
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//public class Exercise35 {
//static void Main(string[] args)
//        {
//string str= "PHP Tutorial";
//Console.WriteLine((str.Substring(1, 2).Equals("HP") ? str.Remove(1, 2) : str));
//        }
//}


//36.
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//public class Exercise36 {
//static void Main(string[] args)
//        {
//Console.WriteLine("\nInput first integer:");  
//int x = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Input second integer:");  
//int y = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Input third integer:");  
//int z = Convert.ToInt32(Console.ReadLine());
              
//Console.WriteLine("Largest of three: "+Math.Max(x, Math.Max(y, z)));
//Console.WriteLine("Lowest of three: "+Math.Min(x, Math.Min(y, z)));
//        }
//}


//37.
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//public class Exercise37
//{
//    public static void Main( )
//    {
//        Console.WriteLine("\nInput first integer:");  
//        int x = Convert.ToInt32(Console.ReadLine());
//        Console.WriteLine("Input second integer:");  
//        int y = Convert.ToInt32(Console.ReadLine());
//        int n = 20;
//        var val1 = Math.Abs(x - n);
//        var val2 = Math.Abs(y - n);
//        Console.WriteLine(val1 == val2 ? 0 : (val1 < val2 ? x : y));   
//    }
//}


//38.
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//public class Exercise38 {
//static void Main(string[] args)
//    {
//            Console.WriteLine("\nInput an integer:");  
//            int x = Convert.ToInt32(Console.ReadLine());
//            int[] nums = {1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 9};
//            Console.WriteLine("Number of " + x + " present in the said array:");
//            Console.WriteLine(nums.Count(n => n == x));
//    }
//}


//39.
//using System;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//public class Exercise39
//{  
//    public static void Main() 
//  {
//            Console.WriteLine("\nInput an integer:");  
//            int x = Convert.ToInt32(Console.ReadLine());
//            int[] nums = {1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 9};
//            Console.WriteLine( (nums[0] == x) || (nums[nums.Length - 1] == x));
//    } 
//}


//40.
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//public class Exercise40
//{  
//   public static void Main() 
//      {
//         int[] nums = {1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 1};
//         Console.WriteLine("\nArray1: [{0}]", string.Join(", ", nums));
//         var sum = 0;
//            for (var i = 0; i < nums.Length; i++)
//            {
//                sum += nums[i];
//            }
//           Console.WriteLine("Sum: "+ sum);
//    } 
//}


//41.
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//public class Exercise41
//{  
//    public static void Main() 
//  {
//            int[] nums1 = {1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 1};
//            Console.WriteLine("\nArray1: [{0}]", string.Join(", ", nums1));
//            int[] nums2 = {1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 5};
//            Console.WriteLine("\nArray2: [{0}]", string.Join(", ", nums2));
            
//            Console.WriteLine("\nCheck if the first element or the last element of the two arrays ( length 1 or more) are equal.");
//            Console.WriteLine((nums1[0].Equals(nums2[0])) || (nums1[nums1.Length - 1].Equals(nums2[nums2.Length - 1])));
//    } 
//}


//42.
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//public class Exercise42
//{  
//   public static void Main() 
//      {
//         int[] nums = {1, 2, 8};
//         Console.WriteLine("\nArray1: [{0}]", string.Join(", ", nums));
//         var temp = nums[0];
//            for (var i = 0; i < nums.Length - 1; i++)
//            {
//                nums[i] = nums[i + 1];
//            }
//            nums[nums.Length - 1] = temp;
//            Console.WriteLine("\nAfter rotating array becomes: [{0}]", string.Join(", ", nums));
         
//    } 
//}


//43.
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//public class Exercise43
//{  
//   public static void Main() 
//      {
//         int[] nums = {1, 2, 5, 7,  8};
//         Console.WriteLine("\nArray1: [{0}]", string.Join(", ", nums));
//         var h_val = nums[0];
//            for (var i = 0; i < nums.Length; i++)
//            {
//                if (nums[i] > nums[0])
//                    h_val = nums[i];
//            }
//            Console.WriteLine("\nHighest value between first and last values of the said array: {0}", h_val);
         
//    } 
//}


//44.
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//public class Exercise44
//{  
//   public static void Main() 
//      {
//         int[] array1 = {1, 2, 5};
//         Console.WriteLine("\nArray1: [{0}]", string.Join(", ", array1));
//         int[] array2 = {0, 3, 8};
//         Console.WriteLine("\nArray2: [{0}]", string.Join(", ", array2));
//         int[] array3 = {-1, 0, 2};
//         Console.WriteLine("\nArray3: [{0}]", string.Join(", ", array3));
//         int[] new_array = { array1[1], array2[1], array3[1] };
//         Console.WriteLine("\nNew array: [{0}]", string.Join(", ", new_array));
         
//    } 
//}


//45.
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//public class Exercise45
//{  
//   public static void Main() 
//      {
//         int[] nums = {2, 4, 7, 8, 6};
//         Console.WriteLine("\nOriginal array: [{0}]", string.Join(", ", nums));
//         Console.WriteLine("Check if an array contains an odd number? "+even_odd(nums));
//      }  
        
//    public static bool even_odd(int[] nums)  
//    {
//         foreach (var n in nums)
//            {
//                if (n % 2 != 0) 
//                return true;
//            }
//        return false;
              
//     } 
//}
















































