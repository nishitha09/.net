# .net
C# PROGRAM TO FIND FIBONACCI SERIES USING RECURSION AND WITHOUT USING RECURSION:

using System;  
 
public class FibonacciExample
{
   
    public static void Main(string[] args)
    {
        
        int n1 = 0, n2 = 1, n3, i, number;
        Console.Write("Enter the number of elements: ");
        number = int.Parse(Console.ReadLine());
        Console.Write(n1 + " " + n2 + " ");
        
        for (i = 2; i < number; ++i)    
        {
            n3 = n1 + n2;
            Console.Write(n3 + " ");
            n1 = n2;
            n2 = n3;
        }
    }
}

OUTPUT:

![image](https://user-images.githubusercontent.com/97939491/156514973-b5cecfd8-9756-4286-aa08-8f1cb17953d3.png)

C# PROGRAM TO CHECK WETHER THE GIVEN NUMBER IS PRME OR NOT:

using System;

public class PrimeNumberExample
{
   
   public static void Main(string[] args)
    {
        
        int n, i, m = 0, flag = 0;
        Console.Write("Enter the Number to check Prime: ");
        n = int.Parse(Console.ReadLine());
        m = n / 2;
        
        for (i = 2; i <= m; i++)
        {
            if (n % i == 0)
            {
                Console.Write("Number is not Prime.");
                flag = 1;
                break;
            }
        }
        if (flag == 0)
            Console.Write("Number is Prime.");
    }
}

OUTPUT:

![image](https://user-images.githubusercontent.com/97939491/156700765-ba32d57e-70a6-4012-8f65-040a78907a0e.png)

![image](https://user-images.githubusercontent.com/97939491/156700828-3a3d7730-1f29-4a26-baa8-d31cd93e2dce.png)

C# PROGRAM TO CHECK WETHER THE GIVEN ELEMENT IS PALINDROME OR NOT:

using System;

public class PalindromeExample
{
   
    public static void Main(string[] args)
    {
        
        int n, r, sum = 0, temp;
        Console.Write("Enter the Number: ");
        n = int.Parse(Console.ReadLine());
        temp = n;
        while (n > 0)
        {
            r = n % 10;
            sum = (sum * 10) + r;
            n = n / 10;
        }
        
        if (temp == sum)
            Console.Write("Number is Palindrome.");
        else
            Console.Write("Number is not Palindrome");
    }
}

OUTPUT:

![image](https://user-images.githubusercontent.com/97939491/156700991-6b8c44c7-2871-45e9-8b69-576a0247b4a1.png)

![image](https://user-images.githubusercontent.com/97939491/156701067-672a44e4-9b31-49cc-b2d9-dc989034690b.png)

C# PROGRAM TO PRINT FACTORIAL OF A NUMBER:

using System;

public class FactorialExample
{
   
    public static void Main(string[] args)
    {
        
        int i, fact = 1, number;
        Console.Write("Enter any Number: ");
        number = int.Parse(Console.ReadLine());
        
        for (i = 1; i <= number; i++)
        {
            fact = fact * i;
        }
        Console.Write("Factorial of " + number + " is: " + fact);
    }
}

OUTPUT:

![image](https://user-images.githubusercontent.com/97939491/157168995-d778c4d9-6aa7-4c2e-8557-53a6010bf23c.png)

C# PROGRAM TO CHECK WETHER THE GIVEN ELEMENT IS ARMSTRONG OR NOT:

using System;

public class Armstrong
{
    
    public static void Main(string[] args)
    {
        i
        nt n, r, sum = 0, temp;
        Console.Write("Enter the number:");
        n = int.Parse(Console.ReadLine());
        temp = n;
        while (n > 0)
        {
            r = n % 10;
            sum = sum + (r * r * r);
            n = n / 10;
        }
        
        if (temp == sum)
            Console.Write("Armstrong Number");
        else
            Console.Write("Not Armstrong Number");
    }
}

OUTPUT:

![image](https://user-images.githubusercontent.com/97939491/158744855-2615989f-c769-43f9-8621-ee4464901285.png)

![image](https://user-images.githubusercontent.com/97939491/158744916-96a63f7a-e586-4230-9594-fd5539134d29.png)

C# PROGRAM TO FIND SUM OF DIGITS:

using System;

public class SumofDigits
{
    
    public static void Main(string[] args)
    {
        
        int n, sum = 0, m;
        Console.Write("Enter a number: ");
        n = int.Parse(Console.ReadLine());
        while (n > 0)
        {
            m = n % 10;
            sum = sum + m;
            n = n / 10;
        }
        Console.Write("Sum is= " + sum);
    }
}

OUTPUT:

![image](https://user-images.githubusercontent.com/97939491/157170234-ad3ca513-c157-4bd5-9963-f5e7ea6a70a7.png)

C# PROGRAM TO REVERSE A GIVEN NUMBER:

using System;

public class ReverseExample
{
    
    public static void Main(string[] args)
    {
        
        int n, reverse = 0, rem;
        Console.Write("Enter a number: ");
        n = int.Parse(Console.ReadLine());
        while (n != 0)
        {
            rem = n % 10;
            reverse = reverse * 10 + rem;
            n /= 10;
        }
        Console.Write("Reversed Number: " + reverse);
    }
}

OUTPUT:

![image](https://user-images.githubusercontent.com/97939491/157172498-e5a79ea9-557f-4575-a211-6ae8542e23f7.png)

C# PROGRAM TO PRINT A BINARY TRIANGLE:

using System;

namespace BINARY_TRIANGLE
{

    class binarytriangle
    {
        static void Main(string[] args)<br>
        {
            int number, digit = 1;
            Console.Write("/n Enter the number of lines:");
            number = Convert.ToInt32(Console.ReadLine());
            for (int i=1;i<=number;i++)
            {
            
              for (int space = number-i; space>0; space--)
            {
                Console.Write("");
            }
            for (int j = 0; j<i; j++)
            {
                Console.Write(digit + "");
                digit=(digit==1) ? 0 : 1;
            }
            Console.Write("\n");
        }
           
      }
    }
}

OUTPUT:

![image](https://user-images.githubusercontent.com/97939491/157173911-24f1ecac-ab21-4456-b973-b68b65f15f2b.png)

C# PROGRAM TO CHECK WHETHER THE ENTERED NUMBER IS AN AMICABLE NUMBER OR NOT:

using System;

namespace Amicablenumber
{ 

    class Amicablenumber
    { 
        static void Main(string[] args)
        {
            int num1, num2, sum1=0, sum2=0;
            Console.WriteLine("\n_____AMICABLENUMBER_____\n");
                Console.Write("\n Enter the first number:");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("\n Enter the second number:");
            num2 = Convert.ToInt32(Console.ReadLine());
            
            for (int i = 1; i < num1; i++)
            {
                if (num1 % i == 0)
                {
                    sum1+= i;
                }
            }
            
            for (int i = 1; i < num2; i++)
            {
                if (num2 % i == 0)
                {
                    sum2 += i;
                }
            }

            if(sum1 == num2 && sum2 == num1)
            {
                Console.WriteLine("\n The numbers {0} and {1} are amicable",num1, num2);

            }
            else
            {
                Console.WriteLine("\n The numbers{0} and {1} are not amicable", num1, num2);
            }
        }
    }
}

OUTPUT:

![image](https://user-images.githubusercontent.com/97939491/157174833-3e772067-9cae-4567-8905-5e00df29dc88.png)

![image](https://user-images.githubusercontent.com/97939491/157174878-c47f8be4-15c1-4e04-9954-ae6b9d041275.png)

C# PROGRAM TO ILLUSTRATE MULTILEVEL INHERITANCE WITH VIRTUAL METHODS:

using System;

namespace Exercise
{
    
    class PersonalDetails
    {
        string name;
        int age;
        string gender;
        public PersonalDetails(string name, int age, string gender)
        {
            this.name = name;
            this.age = age;
            this.gender = gender;
        }
        public virtual void Display()
        {
            Console.WriteLine("\n____PERSONAL DETAILS____\n");
            Console.WriteLine("Name  :" + name);
            Console.WriteLine("Age   :" + age);
            Console.WriteLine("Gender  :" + gender);
        }
    }
    
    class CourseDetails : PersonalDetails
    {
        int regno;
        string course;
        int semester;
        public CourseDetails(string name, int age, string gender, int regno, string course, int semester)
            : base(name, age, gender)
        {
            this.regno = regno;
            this.course = course;
            this.semester = semester;
        }
        
        public override void Display()
        {
            base.Display();
            Console.WriteLine("\n ___COURSE DETAILS___\n");
            Console.WriteLine("Register Number:" + regno);
            Console.WriteLine("Course  :" + course);
            Console.WriteLine("Semester  :" + semester);
        }
    }
    
    class MarksDetails : CourseDetails
    {
        int[] marks = new int[5];
        int total;
        float average;
        string grade;
        int flagFail;
        
        public MarksDetails(string name, int age, string gender, int regno, string course, int semester, int[] marks) : base(name, age, gender,
        regno, course, semester)
        {
            total = 0;
            
            for (int i=0; i<5; i++)
                {
                this.marks[i] = marks[i];
                total += marks[i];
                if (marks[i] < 35)
                {
                    flagFail = 1;
                }
            }
            Calculate();
        }
        
        private void Calculate()
        {
            average = total / 5;
            if (flagFail == 1 || average < 40)
                grade = "fail";
            else if (average >= 70)
                grade = "Distinction";
            else if (average >= 60)
                grade = "First class";
            else if (average >= 50)
                grade = "second class";
            else
                grade = "Pass class";
        }
       
       public override void Display()
        {
            base.Display();
            Console.WriteLine("\n___MARKS DETAILS___\n");
            Console.Write("Marks in 5 subjects:");
            for (int i = 0; i < 5; i++)
                Console.Write(marks[i] + "");
            Console.WriteLine();
            Console.WriteLine("Total  :" + total);
            Console.WriteLine("Average  :" + average);
            Console.WriteLine("Grade   :" + grade);
        }
       
       class Multilevel
        {
            public static void Main(string[] args)
            {
                MarksDetails student1 = new MarksDetails("Nishitha", 22, "Female", 2019001, "MCA", 5, new int[] { 77, 80, 98, 95, 90 });
                student1.Display();
            }
        }
    }
}

OUTPUT:

![image](https://user-images.githubusercontent.com/97939491/157175274-ecb89560-f05c-4f58-ab4d-faff252c56b0.png)

C# PROGRAM TO CREATE A GRAY CODE: 

using System;

namespace Graycode
{
    
    class Graycode
    {
        static int getGray(int n)
        {
            return n ^ (n >> 1);
        }
        static void Main(string[]args)
        {
            int InputNum, GrayNum;
            Console.Write("\n Enter the decimal number:");
            InputNum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n Binary equivalent of {0} : {1}", InputNum, Convert.ToString(InputNum, 2));
            GrayNum = getGray(InputNum);
            Console.WriteLine("\n Gray code equivalent of {0} : {1}",InputNum, Convert.ToString(GrayNum, 2));   
        }
    }
}

OUTPUT:

![image](https://user-images.githubusercontent.com/97939491/157175573-324a6fb8-48ae-4cbf-bb68-7bcd79e1c3de.png)

C# PROGRAM TO CALCULATE VOLUME OF 2 BOXES AND FIND THE RESULTANT VOLUME AFTER ADDITION OF 2 BOXES BY IMPLEMENTING OPERATOR OVERLOADING:

using System;

namespace Box
{
    
    class Box
    {
        float width;
        float height;
        float length;
        public float volume
        {
            get { return width * height * length; }
        }
        
        public Box(float width, float height, float length)
        { 
            this.width = width;
            this.height = height;
            this.length = height;
         }
        
        public static float operator +(Box box1, Box box2)
        {
            return box1.volume + box2.volume;
        }
        
        public override string ToString()
        {
        return "box with width"+ width+", height" +height+"and length"+length;
        }
      }

    class operatoroverloading
    {
    public static void Main()
    {
    
    Box box1 = new Box(10, 20, 30);
    Box box2 = new Box(25, 32, 15);
    Console.WriteLine("Volume of {0} is:{1}", box1, box1.volume);
    Console.WriteLine("Volume of {0} is:{1}", box2, box2.volume);
    Console.WriteLine("Volume after adding boxes: {0}", box1+box2);  
      }
    }
}

OUTPUT:

![image](https://user-images.githubusercontent.com/97939491/157177382-c9c0719f-d399-46ed-b9af-974c1bad1206.png)

C# PROGRAM TO IMPLEMENT PRINCIPLES OF DELEGATES: 

using System;

namespace Exercises
{
   
   class Delegates
    {
        
        delegate string UppercaseDelegate(string input);
       
        static string UppercaseFirst(string input)
        {
            Char[] buffer = input.ToCharArray();
            buffer[0] = Char.ToUpper(buffer[0]);
            return new string(buffer);
        }
        
        static string UppercaseLast(string input)
        {
            Char[] buffer = input.ToCharArray();
            buffer[buffer.Length - 1] = Char.ToUpper(buffer[buffer.Length - 1]);
            return new string(buffer);
        }
        
        static string UppercaseAll(string input)
        { 
            return input.ToUpper();
        }
        
        static void WriteOutput(string input, UppercaseDelegate del)
        {
            Console.WriteLine("Input string:{0}", input);
            Console.WriteLine("output string:{0}",del(input));
        }
        
        static void Main()
        { 
            WriteOutput("tom",new UppercaseDelegate(UppercaseFirst));
            WriteOutput("tom",new UppercaseDelegate(UppercaseLast));
            WriteOutput("tom",new UppercaseDelegate(UppercaseAll));
            Console.ReadLine();
        }
    }
}
     
OUTPUT:

![image](https://user-images.githubusercontent.com/97939491/157178189-77b54953-996f-43ac-9e80-f86f9e1e3cb1.png)

C# PROGRAM TO GENERATE REGISTER NUMBER AUTOMATICALLY FOR 100 STUDENTS USING STATIC CONSTRUCTOR:

using System;

namespace Exercises
{
   
   class RegisterNum
    {
        
        int regNo;
        static int startNum;
        static RegisterNum()
        {
            startNum = 20210000;
            }
        
        RegisterNum()
        {
            regNo=++startNum;
        }
        
        public static void Main(string[] args)
        {
           
           for (int i = 0; i < 100; i++)
            {
                
                RegisterNum Student = new RegisterNum();
                Console.WriteLine("Student{0}:{1}", i+1, Student.regNo);

            }
        }
    }
}

OUTPUT:

![image](https://user-images.githubusercontent.com/97939491/157628250-78a42c0a-3212-40cf-82ce-35f27cb31ccf.png)

C# PROGRAM TO FIND THE FREQUENCY OF THE WORD "IS" IN A GIVEN SENTENCE:

using System;

namespace FrequencyIS
{
    
    class FrequencyIS
    {
        static void Main(string[] args)
        {
            int count = 0;
            string inputString;
            Console.WriteLine("\n____Frequency of word 'is'____");
            Console.Write("\n Enter the input string:");
            inputString = Console.ReadLine();
            char[] separator = { ',',' ','.', '!', '\n' };
            string testString = inputString.ToLower();
            string[] outcomes = testString.Split(separator);
           
           foreach(String s in outcomes)
                {
                Console.WriteLine(s);
                if (s == "is")
                    count++;
                    }
            Console.WriteLine("\n Number of 'is' in '"+inputString+"' is: "+count);
           
        }
    }
}

OUTPUT:

![image](https://user-images.githubusercontent.com/97939491/157628821-84b14d93-ab25-4cbb-a87d-445f5523981d.png)


C# PROGRAM THAT BENCHMARKS 2D,JAGGED ARRAY ALLOCATION:

using System;
using System.Diagnostics;

namespace Exercises
{
    
    class BenchmarkAllocation
    {
        const int _max= 100000;
        static void Main(string[] args)
        {
            var Arr2D = new int[100,100];
            var ArrJagged = new int[100][];
            
            for(int i = 0; i < 100; i++)
            {
                ArrJagged[i] = new int[100];
            }
            var Stopwatch2D = Stopwatch.StartNew();
            
            for (int i = 0; i < _max; i++)
            {
                
                for (int j = 0; j < 100; j++)
                {
                    
                    for (int k = -0; k < 100; k++)
                    {
                        Arr2D[j,k] = k;
                            }
                }
            }
            Stopwatch2D.Stop();
            var StopwatchJagged = Stopwatch.StartNew();
            
            for (int i = 0; i < _max; i++)
            {
                
                for (int j = 0; j < 100; j++)
                { 
                       
                       for (int k = 0; k < 100; k++)
                    {
                        ArrJagged[j][k]= k;
                    }
            }
        }
        StopwatchJagged.Stop();
            Console.Write("\n Time taken for allocation in case of 2D array:");
            Console.Write(Stopwatch2D.Elapsed.TotalMilliseconds+"Millisecond");
            Console.Write("\n Time taken for allocation in case of Jagged array:");
            Console.WriteLine(StopwatchJagged.Elapsed.TotalMilliseconds+"Millisecond");
            }
}
}
          
 OUTPUT:
 
 ![image](https://user-images.githubusercontent.com/97939491/157629583-432953d3-5f26-4532-a44c-a5ddc7ffa8ca.png)

 
C# PROGRAM TO FIND THE SUM OF VALUES ON DIAGONAL OF THE MATRIX:

using System;

namespace Exercises
{
   
   class SumofDiagonals
    {
        static void Main(string[] args)
        {
            
            int MaxRow, MaxCol, Sum = 0;
            int[,] Matrix;
            Console.WriteLine("\n ___SUM OF DIAGONAL OF A MATRIX___\n");
            Console.Write("\n Enter the number of rows:");
            MaxRow = Convert.ToInt32(Console.ReadLine());
            Console.Write("\n Enter the number of columns:");
            MaxCol = Convert.ToInt32(Console.ReadLine());
            if (MaxRow != MaxCol)
            {
                
                Console.WriteLine("\n The Dimensions entered are not a square matrix");
                Console.WriteLine("\n Exiting the program");
                return;
            }
            Matrix = new int[MaxRow, MaxCol];
            
            for (int i = 0; i < MaxRow; i++)
            {
                
                for (int j = 0; j < MaxCol; j++)
                {
                    Console.Write("\n Enter the ({0},{1})th element of matrix:", (i + 1), (j + 1));
                    Matrix[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine("\n the entered Matrix is:");
            
            for (int i = 0; i < MaxRow; i++)
            {

                
                for (int j = 0; j < MaxCol; j++)
                {
                    Console.Write(" " + Matrix[i, j]);
                    if (i == j)
                    {
                        Sum += Matrix[i, j];
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine("\n The Sum of Diagonal is" + Sum);
        }
    }
}   

OUTPUT:

![image](https://user-images.githubusercontent.com/97939491/157630164-e78f300d-4f6d-48a7-a8af-562c2dfe88f4.png)

![image](https://user-images.githubusercontent.com/97939491/157630256-fd02629d-1e90-4168-9281-28a51794712c.png)

C# PROGRAM TO CREATE A FILE, CHECK THE EXISTENCE OF A FILE AND READ THE CONTENTS OF THE FILE:

using System;
using System.IO;

namespace Exercises
{
   
   class FlieRead
    {
        public static void Main()
        {
            
            string fileName;
            while (true)
            {
                
                Console.WriteLine("\n___Menu___\n");
                Console.WriteLine("\n 1.Create a file");
                Console.WriteLine("\n 2.Existence of file");
                Console.WriteLine("\n 3.Read the content of the file");
                Console.WriteLine("\n 4.Exit");
                Console.WriteLine("\n Enter your choice:");
                int ch = int.Parse(Console.ReadLine());
                switch (ch)
                {
                    
                    case 1:
                        Console.Write("\n Enter the file name to create:");
                        fileName = Console.ReadLine();
                        Console.WriteLine("\n Write the contents to the file\n");
                        string r = Console.ReadLine();
                        using (StreamWriter fileStr = File.CreateText(fileName))
                        {
                            fileStr.WriteLine(r);
                        }
                        Console.WriteLine("File is created");
                        break;
                    
                    case 2:
                        Console.Write("Enter the file name to read the contentrs :\n");
                        fileName = Console.ReadLine();
                        if (File.Exists(fileName))
                        {
                            Console.WriteLine("File exist");
                        }
                        else
                        {
                            Console.WriteLine("File doesnot exist in the current directory!");
                        }
                        break;
                    
                    case 3:
                        Console.Write("Enter the fileName to read the contents:\n");
        
                             fileName = Console.ReadLine();
                        if (File.Exists(fileName))
                        {
                            using (StreamReader sr = File.OpenText(fileName))
                            {
                                string s = "";
                                Console.WriteLine("Here is the content of file:");
                                while ((s = sr.ReadLine()) != null)
                                {
                                    Console.WriteLine(s);
                                }
                                Console.WriteLine("");
                            }
                        }
                        else
                        {
                            Console.WriteLine("File doesnot exists");
                        }
                        break;
                    
                    case 4:
                        Console.WriteLine("\n Existing___");
                   return;
                    default:
                        Console.WriteLine("\n Invalid choice");
                        break;
                }
            }
        }
    }
}

OUTPUT:

![image](https://user-images.githubusercontent.com/97939491/157631434-eb44e9bb-5923-4cdd-bbcc-239e2231ff5b.png)

C# PROGRAM TO PERFORM FILE COMPARISION:

using System;
using System.IO;

namespace Exercises
{
    
    class FileRead
    {
        
        public static void Main()
        {
            string file1;
            string file2;
            Console.Write("Enter the first file path:");
            file1 = Console.ReadLine();
            Console.Write("Enter the second file path:");
            file2 = Console.ReadLine();
            if (!File.Exists(file1))
            {
                Console.WriteLine("First file doesnot exist!");
            }
            
            else if (!File.Exists(file2))
            {
                Console.WriteLine("Second file doesnot exist!");
            }
            
            else if (File.ReadAllText(file1) == File.ReadAllText(file2))
            {
                Console.WriteLine("Both file contain the same content");
            }
            
            else
            {
                Console.WriteLine("Contents of files are not same");
            }
        }
    }
}

  OUTPUT:



C# PROGRAM TO IMPLEMENT ICOMPARABLE INTERFACE:

using System;

namespace Exercises
{
    
    class Fraction : IComparable
    {
        int z, n;
        
        public Fraction(int z, int n)
        {
            this.z = z;
            this.n = n;
        }
        public static Fraction operator +(Fraction a, Fraction b)
        {
            return new Fraction(a.z * b.n + a.n * b.z, a.n * b.n);
        }
        public static Fraction operator*(Fraction a,Fraction b)
        {
            return new Fraction(a.z * b.z, a.n * b.n);
        }
        public int CompareTo(object obj)
        {
            Fraction f = (Fraction)obj;
            if ((float)z /n< (float)f.z / f.n)
                return -1;
            else if ((float)z / n > (float)f.z / f.n)
                return 1;
            else
                return 0;
        }
        public override string ToString()
        {
            return z + "/" + n;
        }
    }
    
    class ICompInterface
    { 
        public static void Main()
    {
        Fraction[] a =
        {
        new Fraction(5,2),
        new Fraction(29,6),
        new Fraction(4,5),
        new Fraction(10,8),
        new Fraction(34,7),
        };
            Array.Sort(a);
            Console.WriteLine("Implementing the IComparable Interface in"+"Displaying Fractions:");
            foreach (Fraction f in a)
            {
                Console.WriteLine(f + "");
            }
            Console.WriteLine();

            Console.ReadLine();
        }
    }
}

OUTPUT:

![image](https://user-images.githubusercontent.com/97939491/157633352-ed317f19-f7ee-470c-8332-dea7694224f5.png)

C# PROGRAM TO IMPLEMENT THREADPOOL:

using System;
using System.Threading;

namespace Exercises

{
   
   class ThreadPoolProg
    {
        
        public void ThreadFun1(object obj)
        {
            int loop = 0;
           
           for (loop = 0; loop <= 4; loop++)
            {
                Console.WriteLine("Thread1 is executing");
            }
        }
        public void ThreadFun2(object obj)
        {
            int loop = 0;
           
           for (loop = 0; loop <= 4; loop++)
            {
                Console.WriteLine("Thread2 is executing");
            }
        }
        public static void Main()
        {
            ThreadPoolProg TP = new ThreadPoolProg();
           
           for (int i = 0; i < 2; i++)
            {
                ThreadPool.QueueUserWorkItem(new      WaitCallback(TP.ThreadFun1));
                ThreadPool.QueueUserWorkItem(new WaitCallback(TP.ThreadFun2));
            }
            Console.ReadKey();
        }
    }
}

OUTPUT:

![image](https://user-images.githubusercontent.com/97939491/157634043-471ef298-393c-4b9e-b34a-2ddf8376299f.png)

C# PROGRAM TO DEMONSTRATE ERROR HANDLING USING TRY, CATCH AND FINALLY BLOCK:      

using System;

namespace Exercises
{
    
    class ExceptionHandling
    {
        static void Main(string[] args)
        {
            Age a = new Age();
            try
            {
                a.displayAge();
            }
            catch(AgeIsNegativeException e)
            {
                Console.WriteLine("AgeIsNegativeException:{0}", e.Message);
            }
            finally
            {
                Console.WriteLine("Execution of finally block is done");
            }
          }
       }
    }

public class AgeIsNegativeException : Exception
{
    public AgeIsNegativeException (string message) : base(message)
    {
    }
}

public class Age
{ 
    
    int age = -5;
    public void displayAge()
    {
        
        if (age < 0)
        {
            throw (new AgeIsNegativeException("Age cannot be negative"));
        }
        else
        {
            Console.WriteLine("Age is:{0}", age);
        }
    }
}

OUTPUT:

![image](https://user-images.githubusercontent.com/97939491/157636466-559ee82e-5885-4f56-b2b4-ca2f90e62f02.png)

program 1:

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Program1
{
    
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void convert_Click(object sender, EventArgs e)
        {
                lbl_words.Text = NumtoWord(long.Parse(txt_num.Text));
            }
            public string NumtoWord(long number)
            {
                string word = "";
                if (number == 0)
                {
                    return "Zero";
                }
                if (number < 0)
                {
                    return "Minus" + Math.Abs(number);
                }
                if (number / 10000000 > 0)
                {
                    word += NumtoWord(number / 10000000) + "Corer"; number %= 10000000;
                }
            if (number / 100000 > 0)
                {
                    word += NumtoWord(number / 100000) + "Lacs";
                    number %= 100000;
                }
                if (number / 1000 > 0)
                {
                    word += NumtoWord(number / 1000) + "Thousand";
                    number %= 1000;
                }
                if (number / 100 > 0)
                {
                    word += NumtoWord(number / 100) + "Hundred";
                    number %= 100;
                }
                if (number > 0)
                {
                    string[] units = new string[] { "Zero", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine","Ten", "Eleven", "Twelve", "Thirteen", "Fourteen", "Fifteen", "Sixteen", "Seventeen", "Eighteen", "Nineteen" };
                    string[] Tens = new string[] { "Zero", "Ten", "Twenty", "Thirty", "Fourty", "Fifty", "Sixty", "Seventy", "Eighty", "Ninety" };
                    if (number < 20)
                    {
                        word += units[number];
                    }
                    else
                    {
                        word += Tens[number / 10];
                        if (number % 10 > 0)
                        {
                            word += units[number % 10];
                        }
                    }
                }
                return word;
            }
        }
    }

OUTPUT:

![image](https://user-images.githubusercontent.com/97939491/158944604-d929a499-1284-4eb0-ac82-effd7a061b6d.png)

![image](https://user-images.githubusercontent.com/97939491/158944691-ff771af2-3026-462b-a888-a162edd4b584.png)


Program3:

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Program3
{
    
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void btnrev_Click(object sender, EventArgs e)
        {
            string inputString, revstr = "";
            int Length;
            inputString = txtinput.Text;
            Length = inputString.Length - 1;
            while (Length >= 0)
            {
                revstr = revstr + inputString[Length];
                Length--;
            }
            MessageBox.Show("Reverse String Is : " + revstr, "Result");
        }

        private void btntrim_Click(object sender, EventArgs e)
        {
            {
                string inputString;
                inputString = txtinput.Text;
                MessageBox.Show("The String After Trimming : " + inputString.Trim(), "Result");
            }
        }

        private void Pad_Click(object sender, EventArgs e)
        {
            string inputString;
            inputString = txtinput.Text;
            inputString = inputString.PadLeft(10, '*');
            inputString = inputString.PadRight(15, '*');
            MessageBox.Show("String After Padding : " + inputString, "Result");
        }
    }
}

OUTPUT:

![image](https://user-images.githubusercontent.com/97939491/158945122-4d055abe-b3ab-4134-89af-b07d2ee0561a.png)

![image](https://user-images.githubusercontent.com/97939491/158945187-5b856927-e8fd-4850-ba5e-dcb035d45c46.png)

![image](https://user-images.githubusercontent.com/97939491/158945250-9e4badbd-5458-472e-a09f-cc1d8e5ead0b.png)

![image](https://user-images.githubusercontent.com/97939491/158945410-080da55b-f8a0-4b33-87a6-c65b07ec2010.png)

OUTPUT:

![image](https://user-images.githubusercontent.com/97939491/158954823-ad674bf7-fac6-4c85-af08-bf7f8c3f77bd.png)

![image](https://user-images.githubusercontent.com/97939491/158955202-cfbcd552-9f9c-4b95-ab3c-1bd12e135438.png)

![image](https://user-images.githubusercontent.com/97939491/158955279-90369839-b3f8-4af7-a974-4c38f73c0966.png)

![image](https://user-images.githubusercontent.com/97939491/158955019-91683848-6edd-4027-950d-9b5d7961bd64.png)

Program4:

using System;

namespace Exercises
{
    
    class Armstrong
    { 
    
    public static void Main(string[] args)
    {
        
        int n, r, sum = 0, temp;
        Console.Write("Enter the number");
        n = int.Parse(Console.ReadLine());
        temp = n;
        
        while (n > 0)
        {
            r = n % 10;
            sum = sum + (r * r * r);
            n = n / 10;
        }
        
        if (temp == sum)
            Console.Write("Armstrong Number");
        else
            Console.Write("Not a Armstrong Number");
    }
}

OUTPUT:

![image](https://user-images.githubusercontent.com/97939491/158945631-46bf8924-84e3-48c4-8bdb-6bb9b9ba04ef.png)

![image](https://user-images.githubusercontent.com/97939491/158945680-a23dc33c-7e60-41bd-bdca-f6a1674b3a40.png)

Program5:

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Program5
{
    
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
                System.Timers.Timer timer = new System.Timers.Timer();
                timer.Interval = 1000;//1s
                timer.Elapsed += Timer_Elapsed;
                timer.Start();
            }
            private void Timer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
            {
                circularProgressBar1.Invoke((MethodInvoker)delegate
                {
                    circularProgressBar1.Text = DateTime.Now.ToString("hh:mm:ss");
                    circularProgressBar1.SubscriptText = DateTime.Now.ToString("tt");//AM or PM
                });
            }
        }
    }


 OUTPUT:
 
 ![image](https://user-images.githubusercontent.com/97939491/158948205-f82ebd8a-ce2f-45ea-90c1-6f20cf734935.png)

![image](https://user-images.githubusercontent.com/97939491/158948656-7ab55ed6-21ac-4068-886b-4650e9899446.png)

Program6:
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Program6
{
    public partial class Form1 : Form
    {
        //Initialising component
        static Random r = new Random();
        int value;
        int guessnum;
        int win = 10;
        int guess = 1;
        Button button1;
        TextBox textBox1;
        RichTextBox richTextBox1;
        RichTextBox richTextBox2;
        Label label1;
        Label label2;
        Label label3;
        Label label4;
        public Form1()
        {
            InitializeComponent();
            value = r.Next(10);
            this.Controls.Clear();
            this.BackColor = Color.SkyBlue;
            this.AutoSize = true;
            this.Padding = new Padding(16);

            label1 = new Label();
            label1.Text = "Pick a number between 1 and 100";
            label1.Bounds = new Rectangle(10, 20, 340, 40);
            label1.Font = new Font("Arial", 16);
            textBox1 = new TextBox();
            textBox1.Bounds = new Rectangle(20, 50, 120, 80);
            textBox1.Font = new Font("Arial", 24);
            button1 = new Button();
            button1.Text = " Check Your Guess ";
            button1.Bounds = new Rectangle(160, 50, 120, 40);
            button1.BackColor = Color.LightGray;
            button1.Click += new EventHandler(button1_Click);
            label2 = new Label();
            label2.Text = "Low Guess";
            label2.Bounds = new Rectangle(20, 150, 160, 40);
            label2.Font = new Font("Arial", 18);
            richTextBox1 = new RichTextBox();
            richTextBox1.Bounds = new Rectangle(20, 190, 160, 300);
            richTextBox1.Font = new Font("Arial", 16);
            label3 = new Label();
            label3.Text = "High Guess";
            label3.Bounds = new Rectangle(180, 150, 160, 40);
            label3.Font = new Font("Arial", 18);
            richTextBox2 = new RichTextBox();
            richTextBox2.Bounds = new Rectangle(180, 190, 160, 300);
            richTextBox2.Font = new Font("Arial", 16);
            label4 = new Label();
            label4.Bounds = new Rectangle(20, 100, 340, 40);
            label4.Font = new Font("Arial", 16);
            this.Controls.Add(label1);
            this.Controls.Add(textBox1);
            this.Controls.Add(button1);
            this.Controls.Add(label4);
            this.Controls.Add(label2);
            this.Controls.Add(label3);
            this.Controls.Add(richTextBox1);
            this.Controls.Add(richTextBox2);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Coding of game 
            if (textBox1.Text == "")
            {
                return;
            }
            guessnum = Convert.ToInt32(textBox1.Text);
            textBox1.Text = String.Empty;
            if (win >= 0)
            {
                if (guessnum == value)
                {
                    MessageBox.Show("You have guessed the number! \n The number was " + value);
                    InitializeComponent();
                }
                else if (guessnum < value)
                {
                    richTextBox1.Text += guessnum + "\n";
                    MessageBox.Show("wrong Guess and number of guesses left are  " + (10 - guess));

                }
                else if (guessnum > value)
                {
                    richTextBox2.Text += guessnum + "\n";
                    MessageBox.Show("wrong Guess and number of guesses left are  " + (10 - guess));

                }
                guess++;
                win--;
            }
            if (guess == 11)
            {
                MessageBox.Show("You loose,Correct Guess is " + value);
            }
        }
    }
}

OUTPUT:

![image](https://user-images.githubusercontent.com/97939491/161212794-9a209a4a-8da3-4ae7-bfed-448fe04672ca.png)


