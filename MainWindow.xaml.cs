using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace WpfApp2
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<Student> students = new ObservableCollection<Student>();
        public ObservableCollection<Group> groups = new ObservableCollection<Group>();
        private DiaryDBEntities _diaryDBEntities = new DiaryDBEntities();
        public MainWindow()
        {
            InitializeComponent();
            groups.Add(new Group()
            {
                Id = new Random().Next(0, 1000),
                NumberGroup = 4332,
                YearOfAdmission = new DateTime(2019, 9, 1)
            });
            students.Add(new Student()
            {
                Id = new Random().Next(0, 1000),
                Name = "Рахимов Р.Р.",
                Group = groups[0]
            });
            StudentsList.ItemsSource = students;
            NumberGroupNewStudent.ItemsSource = groups;
            //StudentsList.ItemsSource = _diaryDBEntities.Students.ToList();
        }
        private void StudentsList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            NameEditStudent.Text = ((Student)StudentsList.SelectedItem).Name;
            NumberGroupEditStudent.Text = ((Student)StudentsList.SelectedItem).Group.NumberGroup.ToString();
        }

        private void AddStudentButton_Click(object sender, RoutedEventArgs e)
        {
            Student NewStudent = new Student()
            {
                Id = new Random().Next(0, 1000),
                Name = NameNewStudent.Text,
                Group = (Group)NumberGroupNewStudent.SelectedItem
            };
            this.students.Add(NewStudent);
        }

        private void EditStudentButton_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
