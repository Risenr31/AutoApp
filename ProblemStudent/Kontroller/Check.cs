using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemStudent.Kontroller
{
    class Check
    {
        public static List<string> progress_check(double[] marks, bool[] attendance, string name)
        {
            List<string> problem = new List<string>();
            double avgM = 0; 
            int avgA = 0;
            for (int i = 0; i <= marks.Length; i++)
                avgM += marks[i];
            avgM /= marks.Length;
            for (int i = 0; i <= attendance.Length; i++)
                if (attendance[i] == true) avgA++;
            if ((avgM < 3) && (avgA < (attendance.Length / 2)))
                problem.Add(name);
            return problem;
        }
    }
}
