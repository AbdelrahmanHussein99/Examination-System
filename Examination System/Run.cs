using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_System
{
    internal static class Run
    {
       
        public static void RunProgram()
        {
            Subject subject = new Subject(1, "c#");
            subject.CreateExam();
            Console.Clear();
            Console.WriteLine("Do You Want To Start The Exam ( y | n ):");


            if (char.Parse(Console.ReadLine()) == 'y')
            {
                Console.Clear();

                Stopwatch SW = new Stopwatch();
                SW.Start();
                subject.ExamOfSubject?.ShowExam();
                Console.WriteLine($"The Elapsed Time = {SW.Elapsed}");

            }
        }
    }
}
