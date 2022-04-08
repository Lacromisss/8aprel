using System;
using System.Collections.Generic;
using System.Text;

namespace _8may
{
    internal class Student
    {
        private static int _id;
        public Student()
        {
            _id++;
            this.No = _id;
        }
        public Dictionary<string, double> Exams = new Dictionary<string, double>();
        public int No { get; }
        public string FullName { get; set; }
       
        public double GetExamAvg()
        {
            double dbl = 0;
            foreach (var item in Exams)
            {
                dbl += item.Value;
            }
            return dbl / Exams.Count;
        }
        public void AddExam(string examName, double point)
        {
            if (!string.IsNullOrWhiteSpace(examName) && point >= 0 && point <= 100)
            {
                Exams.Add(examName, point);
            }
            else
            {
                throw new Exception("null olmamalidir. xetaaa");
            }

        }
        public double GetExamResult(string examName)
        {
            if (!string.IsNullOrWhiteSpace(examName))
            {
                if (Exams.ContainsKey(examName))
                {
                    return Exams[examName];
                }
                throw new Exception("xeta");
            }
            else
            {
                throw new Exception("xeta var");
            }
        }
       
    }
}
