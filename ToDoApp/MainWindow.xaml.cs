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

namespace ToDoApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Task> tasks = new List<Task>();
        public MainWindow()
        {
            InitializeComponent();


            Task t1= new Task();
            t1.Name = "Купити молоко";
            t1.IsCompleted= false;
            t1.Description = "Купити 2л молока";

            Task t2 = new Task();
            t2.Name = "Вивчити С#";
            t2.IsCompleted = false;
            t2.Description = "Вивчити основи С#";

            Task t3 = new Task();
            t3.Name = "Створити резюме";
            t3.IsCompleted = false;
            t3.Description = "Резюме на позицію Junior .NET developer";

            tasks.Add(t1);
            tasks.Add(t2);
            tasks.Add(t3);

            ToDoListBox.ItemsSource = tasks;
            ToDoListBox.DisplayMemberPath = "Name";

        }

        private void ToDoListBox_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            Task? selected = ToDoListBox.SelectedItem as Task;
            if (selected != null) 
            {
                MessageBox.Show(selected.Description);
            }
        }
    }
}
