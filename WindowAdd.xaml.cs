using ExamplePracWork13.Classes;
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
using System.Windows.Shapes;

namespace ExamplePracWork13
{
    /// <summary>
    /// Логика взаимодействия для WindowAdd.xaml
    /// </summary>
    public partial class WindowAdd : Window
    {
        public WindowAdd()
        {
            InitializeComponent();
            CmbGroup.ItemsSource = ClassHelp.groups;
        }

        private void BtnAddReader_Click(object sender, RoutedEventArgs e)
        {
            ClassStudent student = new ClassStudent()
            {
                Fullname = TxbFIO.Text,
                Numbergroup = CmbGroup.Text,
                Oap = TxbOAP.Text,
                Mdk = TxbMDK.Text,
                Math = TxbMath.Text,
                English = TxbEngl.Text,
                Tsi = TxbTSI.Text
            };
            ClassHelp.students.Add(student);
        }
    }
}
