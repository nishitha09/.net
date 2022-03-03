# .net
C# PROGRAM TO PRINT A BINARY TREE
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










C# PROGRAM TO CHECK WHETHER THE ENTERED NUMBER IS AN AMICABLE NUMBER OR NOT
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







C# PROGRAM TO ILLUSTRATE MULTILEVEL INHERITANCE WITH VIRTUAL METHODS
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



C# PROGRAM TO CREATE A GRAY CODE 
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




C# PROGRAM TO CALCULATE VOLUME OF 2 BOXES AND FIND THE RESULTANT VOLUME AFTER ADDITION OF 2 BOXES BY IMPLEMENTING OPERATOR OVERLOADING 
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


C# PROGRAM TO IMPLEMENT PRINCIPLES OF DELEGATES 
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




C# PROGRAM TO FIND THE FREQUENCY OF THE WORD "IS" IN A GIVEN SENTENCE
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




C# PROGRAM THAT BENCHMARKS 2D,JAGGED ARRAY ALLOCATION
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
          
          
C# PROGRAM TO FIND THE SUM OF VALUES ON DIAGONAL OF THE MATRIX
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




C# PROGRAM TO CREATE A FILE, CHECK THE EXISTENCE OF A FILE AND READ THE CNTENTS OF THE FILE
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



C# PROGRAM TO PERFORM FILE COMPARISION
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
    
       



C# PROGRAM TO IMPLEMENT ICOMPARABLE INTERFACE 
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



C# PROGRAM TO IMPLEMENT THREADPOOL
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

C# PROGRAM       
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


