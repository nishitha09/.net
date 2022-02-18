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
     







