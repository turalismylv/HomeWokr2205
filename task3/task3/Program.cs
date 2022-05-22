using System;

namespace task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Student stud = new Student
            {
                FinalGrades = 80,
                HomeWorkGrades = new int[] { 80, 80, 85 },
                ProjectGrades = new int[] { 80, 80, 85 },
                Davamiyyet = new bool[] { true, true, true, true, true }
            };
            Student stud2 = new Student
            {
                FinalGrades = 99,
                HomeWorkGrades = new int[] { 99, 99, 99 },
                ProjectGrades = new int[] { 99, 99, 99 },
                Davamiyyet = new bool[] { true, true, true, true, true }
            };
            Student stud3 = new Student
            {
                FinalGrades = 65,
                HomeWorkGrades = new int[] { 77, 77, 77 },
                ProjectGrades = new int[] { 88, 88, 88, 88 },
                Davamiyyet = new bool[] { true, true, true, true, true }
            };
            stud.CoursePassed();
            stud2.CoursePassed();
            stud3.CoursePassed();
        }
    }

    public class Student
    {
        public int[] HomeWorkGrades;
        public int[] ProjectGrades;
        public int FinalGrades;
        public bool[] Davamiyyet;
        public int AvHomeWorkGrades()
        {
            int sum = 0;
            int say = 0;
            for (int i = 0; i < HomeWorkGrades.Length; i++)
            {
                sum += HomeWorkGrades[i];
                say++;
            }
            return sum / say;
        }
        public int AvProjectGrades()
        {
            int sum = 0;
            int say = 0;
            for (int i = 0; i < ProjectGrades.Length; i++)
            {
                sum += ProjectGrades[i];
                say++;
            }
            return sum / say;
        }
        public double AvDavamiyyet()
        {
            double say = 0;
            int sum = Davamiyyet.Length;
            for (int i = 0; i < Davamiyyet.Length; i++)
            {
                if (Davamiyyet[i] == true)
                {
                    say++;
                }
            }
            return say / sum * 100;
        }
        public void CoursePassed()
        {
            double UmumiBal = (AvHomeWorkGrades() * 25 / 100) + (AvProjectGrades() * 25 / 100) + (AvDavamiyyet() * 10 / 100) + FinalGrades * 40 / 100;
            if (UmumiBal > 90)
            {
                Console.WriteLine("HighHonour");
            }
            else if (UmumiBal > 80)
            {
                Console.WriteLine("Honor");
            }
            else
            {
                Console.WriteLine("Normal");
            }
        }
    }
}
