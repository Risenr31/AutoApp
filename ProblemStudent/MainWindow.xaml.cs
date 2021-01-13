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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
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
    }
}
