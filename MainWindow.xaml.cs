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
using ExamplePracWork13.Classes;

namespace ExamplePracWork13
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            

            //один объект класса ClassLibrary
            ClassStudent library = new ClassStudent()
            {
                Fullname = "Глазкова Александра Андреевна",
                Numbergroup = "ИСП.21.1А",
                Oap = "4",
                Mdk = "5",
                Math = "4",
                English = "5",
                Tsi = "5"
            };
            ClassHelp.students.Add(library);

            //источник данных таблицы - список объектов
            DtgListBooks.ItemsSource = ClassHelp.students;
        }

        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {//переход на форму добавления
            WindowAdd windowAdd = new WindowAdd();
            windowAdd.ShowDialog();
        }

        private void TxtSearch_TextChanged(object sender, TextChangedEventArgs e)
        {
            DtgListBooks.ItemsSource = ClassHelp.students.Where(x=>x.Fullname.Contains(TxtSearch.Text)).ToList();
        }

        private void CmbFilter_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //фильтр по группам
            string groups = ClassHelp.groups[CmbFilter.SelectedIndex];
            if (CmbFilter.SelectedIndex != 0)
                DtgListBooks.ItemsSource = ClassHelp.students.Where(x => x.Numbergroup == groups).ToList();
            else
                DtgListBooks.ItemsSource = ClassHelp.students;
        }

        private void RbUp_Checked(object sender, RoutedEventArgs e)
        {
            //сортировка от А до Я
            DtgListBooks.ItemsSource = ClassHelp.students.OrderBy(x=>x.Fullname).ToList();
        }

        private void RbDown_Checked(object sender, RoutedEventArgs e)
        {
            //Сортировка от Я до А
            DtgListBooks.ItemsSource = ClassHelp.students.OrderByDescending(x => x.Fullname).ToList();
        }
    }
}
