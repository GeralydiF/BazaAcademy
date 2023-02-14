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
using WpfApp1.NewFolder1;

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            using (АльшаковаEntities context =  new АльшаковаEntities())
            {
                context.Students.ToList().ForEach(x => MainStackPanel.Children.Add(new TextBox() { Text = $"{x.StudentID}\t{x.Name} {x.Surname} {x.Patronymic} {(x.BirthDay.HasValue ? x.BirthDay.Value.ToString("d") : String.Empty)} {x.Cities.Name}" }));
            }
            this.Height = MainStackPanel.Height;
        }
    }
}
