using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemStudent.Kontroller
{
    class Check
    {
        public static string Progress_check(int[] marks, char[] attendance, string name)
        {
            double avgM = 0;
            int avgA = 0;
            for (int i = 0; i < marks.Length; i++)
                avgM += marks[i];
            for (int i = 0; i < attendance.Length; i++)
                if (attendance[i] == '+') avgA++;
            avgM /= marks.Length;
            if ((avgM < 3) && (avgA < (attendance.Length / 2))) return name + " звонить родителям";
            else if (avgM < 3) return name + " плохие оценки";
            else if (avgA < (attendance.Length / 2)) return name + " плохая посещаемость";
            else return null;
        }
    }
}
