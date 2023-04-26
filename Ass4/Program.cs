// See https://aka.ms/new-console-template for more information

namespace ScoreCard
{
    class Student
    {
        public string Name { get; set; }
        public int RollNo { get; set; }
        public int Maths { get; set; }
        public int Science { get; set; }
        public int English { get; set; }
        public int Language { get; set; }
        public int SocialStudies { get; set; }
        public int TotalMarks { get; set; }

        public bool IsPassed()
        {
            return (Maths >= 35 && Science >= 35 && English >= 35 && Language >= 35 && SocialStudies >= 35);
        }

    }

    class ScoreCard
    {
        Student[] students;
        public void getDetails()
        {
            Console.Write("Enter the number of students: ");
            int numStudents = Convert.ToInt16(Console.ReadLine());

            students = new Student[numStudents];

            for (int i = 0; i < numStudents; i++)
            {
                Console.WriteLine($"Enter Details for Student {i + 1}");

                Console.WriteLine("Enter Roll No");
                int rollno = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Student Name");
                string name = Console.ReadLine();
                Console.WriteLine("Enter Marks for Maths");
                int maths = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Marks for Science");
                int science = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Marks for English");
                int english = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Marks for Language");
                int language = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Marks for SocialStudies");
                int socialstudies = Convert.ToInt32(Console.ReadLine());
                int total = maths + science + english + language + socialstudies;
                students[i] = new Student() { RollNo = rollno, Name = name, Maths = maths, Science = science, English = english, Language = language, SocialStudies = socialstudies, TotalMarks = total };
            }
        }

        public void Task1()
        {
            int sum = 0;
            int max = 0;
            for (int i = 0; i < students.Length; i++)
            {
                Console.WriteLine($"Roll No: {students[i].RollNo} Name: {students[i].Name}");
                Console.WriteLine($"Math: {students[i].Maths}, Science: {students[i].Science}, English: {students[i].English}, Language: {students[i].Language}, SocialStudies: {students[i].SocialStudies}");
                Console.WriteLine($"Total Marks: {students[i].TotalMarks}");

            }
            int maxTotalMarks = -1;
            string topScorerName = "";
            int topScorerRollNo = 0;

            foreach (Student student in students)
            {
                if (student.TotalMarks > maxTotalMarks)
                {
                    maxTotalMarks = student.TotalMarks;
                    topScorerName = student.Name;
                    topScorerRollNo = student.RollNo;
                }
            }
            Console.WriteLine($"\nTop Scorer: {topScorerName} (Roll No.: {topScorerRollNo}), Total Marks: {maxTotalMarks}");
            double avgMaths = 0, avgScience = 0, avgEnglish = 0, avgLanguage = 0, avgSocialStudies = 0;

            foreach (Student student in students)
            {
                avgMaths += student.Maths;
                avgScience += student.Science;
                avgEnglish += student.English;
                avgLanguage += student.Language;
                avgSocialStudies += student.SocialStudies;
            }

            avgMaths /= students.Length;
            avgScience /= students.Length;
            avgEnglish /= students.Length;
            avgLanguage /= students.Length;
            avgSocialStudies /= students.Length;

            Console.WriteLine($"\nAverage Marks\nMath: {avgMaths:P2}\nScience: {avgScience:P2}\nEnglish: {avgEnglish:P2}\nLanguage: {avgLanguage:P2}\nSocial Studies: {avgSocialStudies:P2}");
            
            Console.WriteLine("\nStudents who have cleared the examination:");
            foreach (Student student in students)
            {
                if (student.Maths >= 35 && student.Science >= 35 && student.English >= 35 && student.Language >= 35 && student.SocialStudies >= 35)
                {
                    Console.WriteLine($"{student.Name} (Roll No.: {student.RollNo})");
                }
            }

            int failedStudents = 0;
            for (int i = 0; i < students.Length; i++)
            {
                if (!students[i].IsPassed())
                {
                    failedStudents++;
                }
            }

            Console.WriteLine("\nNumber of students who need to mandatorily repeat the examination: {0}", failedStudents);
            Console.WriteLine("\nDetails of students who need to mandatorily repeat the examination:");
            Console.WriteLine("Roll No\tName");
            Console.WriteLine("------");
            for (int i = 0; i < students.Length; i++)
            {
                if (!students[i].IsPassed())
                {
                    Console.WriteLine("{0}\t{1}", students[i].RollNo, students[i].Name);
                }
            }
            Console.WriteLine();
        }

        public void Task3()
        {
            string Grade = "A";
            foreach (Student student in students)
            {
                double studentAverage = 0;
                studentAverage = student.TotalMarks / 5;
                if (studentAverage >= 95)
                {
                    Grade = "A";
                }
                else if (studentAverage >= 80)
                {
                    Grade = "B";
                }
                else if (studentAverage >= 70)
                {
                    Grade = "C";
                }
                else if (studentAverage >= 60)
                {
                    Grade = "D";
                }
                else if (studentAverage >= 50)
                {
                    Grade = "E";
                }
                else
                {
                    Grade = "F";
                }
            }
            Console.WriteLine();
        }

        public void Task4(int roll)
        {
            Console.WriteLine("ScoreCard");
            foreach (Student student in students)
            {
                if (roll == student.RollNo)
                {
                    Console.WriteLine($"Name of the student: {student.Name}");
                    Console.WriteLine($"Roll Number: {student.RollNo}");
                    Console.WriteLine($"Math Marks: {student.Maths}");
                    Console.WriteLine($"Science Marks: {student.Science}");
                    Console.WriteLine($"English Marks: {student.English}");
                    Console.WriteLine($"Language Marks: {student.Language}");
                    Console.WriteLine($"Social Marks: {student.SocialStudies}");
                    Console.WriteLine($"Total Marks Obtained: {student.TotalMarks}");
                    string Grade = "A";
                    double studentAverage = 0;
                    studentAverage = student.TotalMarks / 5;
                    if (studentAverage >= 95)
                    {
                        Grade = "A";
                    }
                    else if (studentAverage >= 80)
                    {
                        Grade = "B";
                    }
                    else if (studentAverage >= 70)
                    {
                        Grade = "C";
                    }
                    else if (studentAverage >= 60)
                    {
                        Grade = "D";
                    }
                    else if (studentAverage >= 50)
                    {
                        Grade = "E";
                    }
                    else
                    {
                        Grade = "F";
                    }

                    Console.WriteLine($"Gradeachived {Grade}");
                }

            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            ScoreCard t = new ScoreCard();
            t.getDetails();
            t.Task1();
            t.Task3();
            Console.WriteLine("Enter a Roll Number:");
            int roll = Convert.ToInt32(Console.ReadLine());
            t.Task4(roll);
        }
    }
}



