using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Zd1
{
    internal class Exam
    {
        public string Education {  get; set; } 
        public  string Predmet { get; set; }
        int mark;
        public DateTime DateExam { get; set; }

        public int Mark
        {
            set
            {
                if (value > 0 && value < 11)
                    mark = value;
                else
                {
                    mark = 5;
                }
            }
            get
            {
                return mark;
            }
        } 
        public Exam (string predmet, int mark,DateTime dateExam)
        {
            Predmet = predmet;
            Mark = mark;
            DateExam = dateExam;
      

        }
        public Exam()
        {
            Predmet = "Физика";
            Mark = 9;
            this.DateExam = new DateTime(2024, 3, 10);
        }
        public override string ToString()
        {
            return Predmet + Mark + DateExam;
        }
    }
    }

