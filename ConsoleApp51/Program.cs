using System;
using System.Collections.Generic;
namespace _8may
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<Student> student1 = new List<Student>();
            bool menu1 = true;
            while (menu1)
            {
                Console.WriteLine("Menu");
                Console.WriteLine("1. Tələbə əlavə et");
                Console.WriteLine("2. Tələbəyə imtahan əlavə et");
                Console.WriteLine("3. Tələbənin bir imtahan balına bax");
                Console.WriteLine("4. Tələbənin bütün imtahanlarını göstər");
                Console.WriteLine("5. Tələbənin imtahan ortalamasını göstər");
                Console.WriteLine("6. Tələbədən imtahan sil");
                Console.WriteLine("0. Proqramı bitir");
                int input = int.Parse(Console.ReadLine());
                int no;
                string name;
                Student search;
                switch (input)
                {
                    case 1:
                        Console.WriteLine("Fulname daxil edin");
                        string fullName = Console.ReadLine();
                        Student students = new Student()
                        {
                            FullName = fullName,
                        };
                        student1.Add(students);
                        break;
                    case 2:
                        no = IntInput("No  daxil et", "duzgun et:");
                        name = StringInput("Exam name  daxil ed");
                        double point = DoubleInput("Point", "duzgun et :");
                       search = student1.Find(x=> x.No == no);
                        if (search != null)
                            search.AddExam(name, point);
                        break;
                    case 3:
                        no = IntInput("Student no daxil ed", "Student no duzgun daxil ed");
                        name = StringInput("Exam name");
                        search = student1.Find(x => x.No == no);
                        if (search != null)
                        {
                            Console.WriteLine($"{no} - li nomreli telebenin {name} adli imtahan neticesi :");
                            Console.WriteLine(search.GetExamResult(name));
                        }

                        break;
                    case 4:
                        no = IntInput("Student no daxil et", "Student no duzgun daxil et");
                        search = student1.Find(x => x.No == no);
                        if (search != null)
                        {
                            Console.WriteLine($"{no} nomreli telebenin imtahan ve ballari burdadirrrr");
                            foreach (var item in search.Exams)
                            {
                                Console.WriteLine(item.Key  + item.Value);
                            }
                        }

                        break;
                    case 5:
                        no = IntInput("Student no daxil et :", "Student no duzgun daxil et :");
                        search = student1.Find(x => x.No == no);
                        if (search != null)
                        {
                            Console.WriteLine($"{no} -nomreli telebenin  ortalama bali burdadir");
                            Console.WriteLine(search.GetExamAvg());
                        }

                        break;
                    case 6:
                        no = IntInput("No ", "sehvlik var :");
                        name = StringInput("Exam name");
                        search = student1.Find(x => x.No == no);
                        if (search != null)
                        {
                            if (search.Exams.ContainsKey(name))
                            {
                                search.Exams.Remove(name);
                                Console.WriteLine($"{no} -nomreli telebeden {name}  getdi kuleye");
                            }
                        }

                        break;
                    case 0:
                        menu1 = false;
                        break;
                   
                    
                }
            }
        }
        static string StringInput(string mssg)
        {
            Console.WriteLine(mssg);
            string inputStr = Console.ReadLine();
            return inputStr;
        }
        static double DoubleInput(string mssg1, string mssg2)
        {
            Console.WriteLine(mssg1);
            string inputStr = Console.ReadLine();
            double input1;
            while (!double.TryParse(inputStr, out input1))
            {
                Console.WriteLine(mssg2);
                inputStr = Console.ReadLine();
            }
            double.TryParse(inputStr, out input1);
            return input1;
        }
        static int IntInput(string mssg1, string mssg2)
        {
            Console.WriteLine(mssg1);
            string inputStr = Console.ReadLine();
            int input2;
            while (!int.TryParse(inputStr, out input2))
            {
                Console.WriteLine(mssg2);
                inputStr = Console.ReadLine();
            }
            int.TryParse(inputStr, out input2);
            return input2;
        }
       
       
    }
}