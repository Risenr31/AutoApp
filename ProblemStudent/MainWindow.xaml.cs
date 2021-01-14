using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.IO;
using ProblemStudent.Modells;
using ProblemStudent.Kontroller;

namespace ProblemStudent
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        List<Student> StudentList = new List<Student>();
        List<string> names = new List<string>();
        List<string> groups = new List<string>();
        List<string> marks = new List<string>();
        List<string> poseschenie = new List<string>();
        List<string> ProblemSt = new List<string>();

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            AllStudent.Items.Clear();
            names.Clear();
            groups.Clear();
            marks.Clear();
            poseschenie.Clear();
            FileStream file1 = new FileStream("Lerner.txt", FileMode.Open, FileAccess.Read);
            StreamReader reader1 = new StreamReader(file1);
            while (!reader1.EndOfStream)
            {
                string[] odd = new string[2];
                odd = reader1.ReadLine().Split(' ');
                string name = odd[0];
                string group = odd[1];
                AllStudent.Items.Add(name + " " + group);
                names.Add(name);
                groups.Add(group);
            }
            reader1.Close();
            file1.Close();

            FileStream file2 = new FileStream("Ergebnisse.txt", FileMode.Open, FileAccess.Read);
            StreamReader reader2 = new StreamReader(file2);
            while (!reader2.EndOfStream)
            {
                string mark = reader2.ReadLine();
                marks.Add(mark);
            }
            reader2.Close();
            file2.Close();

            FileStream file3 = new FileStream("Teilnahme.txt", FileMode.Open, FileAccess.Read);
            StreamReader reader3 = new StreamReader(file3);
            while (!reader3.EndOfStream)
            {
                string pluss = reader3.ReadLine();
                poseschenie.Add(pluss);
            }
            reader3.Close();
            file3.Close();
        }

        private void MakeO_Click(object sender, RoutedEventArgs e)
        {
            if (names.Count == 0) { }
            else
            {
                StudentList.Clear();
                ProblemSt.Clear();
                PrSt.ItemsSource = default;
                PrSt.Items.Clear();
                for (int i = 0; i < names.Count; i++)
                {
                    string s = marks[i];
                    int n = s.Length / 2 + 1;
                    //char[] a = s.ToCharArray();
                    int[] o = new int[n];
                    string[] odd = new string[n];
                    odd = s.Split(' ');
                    for (int j = 0; j < n; j++)
                        o[j] = Convert.ToInt32(odd[j]);

                    string p = poseschenie[i];
                    char[] l = p.ToCharArray();

                    StudentList.Add(item: new Student() { Name = names[i], NomerGruppi = groups[i], Poseshcaemost = l, Ocenki = o });
                }
                for (int i = 0; i < StudentList.Count; i++)
                {
                    if (Check.Progress_check(StudentList[i].Ocenki, StudentList[i].Poseshcaemost, StudentList[i].Name) != null)
                    ProblemSt.Add(Check.Progress_check(StudentList[i].Ocenki, StudentList[i].Poseshcaemost, StudentList[i].Name));
                }
                PrSt.ItemsSource = ProblemSt;
            }
        }

        private void Transfer_Click(object sender, RoutedEventArgs e)
        {
            if (ProblemSt.Count == 0) { }
            else
            {
                FileStream File = new FileStream("Отчет.txt", FileMode.Create, FileAccess.Write);
                StreamWriter Writer = new StreamWriter(File);
                for (int i = 0; i < ProblemSt.Count; i++)
                    Writer.WriteLine(ProblemSt[i]);
                Writer.Close();
                File.Close();
            }
        }
    }
}