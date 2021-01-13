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
        bool[] _poseshcaemost;
        public Student(string Name, string NomerGruppi, bool[] Poseshcaemost, int[] Ocenki)
        {
            _name = Name;
            _nomerGruppi = NomerGruppi;
            _ocenki = Ocenki;
            _poseshcaemost = Poseshcaemost;

        }
        public string name { get => _name; set => _name = value; }
        public string nomerGruppi { get => _nomerGruppi; set => _nomerGruppi = value; }
        public bool[] poseshcaemost { get => _poseshcaemost; set => _poseshcaemost = value; }
        public int[] ocenki { get => _ocenki; set => _ocenki = value; }
    }
}
