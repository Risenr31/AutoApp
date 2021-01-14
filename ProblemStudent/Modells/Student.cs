using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemStudent.Modells
{
    class Student
    {
        string _name, _nomerGruppi;
        int[] _ocenki;
        char[] _poseshcaemost;
        public string Name;
        public string NomerGruppi;
        public char[] Poseshcaemost;
        public int[] Ocenki;
        public Student()
        {
            _name = Name;
            _nomerGruppi = NomerGruppi;
            _ocenki = Ocenki;
            _poseshcaemost = Poseshcaemost;

        }
        public string name { get => _name; set => _name = value; }
        public string nomerGruppi { get => _nomerGruppi; set => _nomerGruppi = value; }
        public char[] poseshcaemost { get => _poseshcaemost; set => _poseshcaemost = value; }
        public int[] ocenki { get => _ocenki; set => _ocenki = value; }
    }
}
