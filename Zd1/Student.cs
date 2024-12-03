using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zd1
{
    internal class Student
    {
        private Person studentData { get; set; }
        Education education = Education.Specialist;
        
        public int group {  get; set; }
        private Exam[] exams {  get; set; }

        public enum Education
        {
            Specialist,
            Bachelor,
            SecondEducation
        }

        public Student(Person studentData, Education education, int group)
        {
            this.studentData = studentData;
            this.education = education;
            this.group = group;
            exams = new Exam[0];
        }

        public Student()
        {
            studentData = new Person();
            education = Education.Bachelor;
            group = 0;
            exams = new Exam[0];

        }
        public double AverageGrade
        {
            get
            {
                if (exams.Length == 0) return 0;
                double sum = 0;
                foreach (var exam in exams)
                    sum += exam.Mark;
                return sum / exams.Length;
            }

        }
        public bool this[Education edu]
        {
            get { return education == edu; }
        }
        public void AddExams(params Exam[] newExams)
        {
            for(int i = 0; i < newExams.Length; i++)
            {
                newExams[i].Education = Console.ReadLine();
            }
        }

        public virtual string ToString()
        {
            return $"Student: {studentData}, Education: {education}, Group: {group}, AverageGrade: {AverageGrade:F2}";
        }
        public virtual string ToShortString()
        {
            return $"Student: {studentData}, Education: {education}, Group: {group}, AverageGrade: {AverageGrade:F2}";
        }
    }
}
