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
        private DiaryDBEntities _diaryDBEntities = new DiaryDBEntities();
        public MainWindow()
        {
            InitializeComponent();
            StudentsList.ItemsSource = _diaryDBEntities.Students.ToList();
        }
        private void StudentsList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void AddStudentButton_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
