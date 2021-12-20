using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

namespace _19._12
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            update();
            update_combobox();
        }
 
        public void update()
        {
            var Listprod = App.DB.sotrudnik.ToList();
            var category = c1.SelectedIndex;

            if (category == 0)
            {
                Listprod = App.DB.sotrudnik.ToList();
            }
            if (category == 1)
            {
                Listprod = App.DB.sotrudnik.Where(p => p.id_magazine == 1).ToList();
            }
            if (category == 2)
            {
                Listprod = App.DB.sotrudnik.Where(p => p.id_magazine == 2).ToList();
            }
            if (category == 3)
            {
                Listprod = App.DB.sotrudnik.Where(p => p.id_magazine == 3).ToList();
            }
            if (category == 4)
            {
                Listprod = App.DB.sotrudnik.Where(p => p.id_magazine == 4).ToList();
            }
            if (category == 5)
            {
                Listprod = App.DB.sotrudnik.Where(p => p.id_magazine == 5).ToList();
            }
            if (category == 6)
            {
                Listprod = App.DB.sotrudnik.Where(p => p.id_magazine == 6).ToList();
            }
            if (category == 7)
            {
                Listprod = App.DB.sotrudnik.Where(p => p.id_magazine == 7).ToList();
            }
            if (category == 8)
            {
                Listprod = App.DB.sotrudnik.Where(p => p.id_magazine == 8).ToList();
            }
            if (category == 9)
            {
                Listprod = App.DB.sotrudnik.Where(p => p.id_magazine == 9).ToList();
            }
            if (category == 10)
            {
                Listprod = App.DB.sotrudnik.Where(p => p.id_magazine == 10).ToList();
            }
            var poisk = t5.Text;
            if (poisk != "")
            {
                Listprod = App.DB.sotrudnik.Where(p => p.fio.Contains(poisk)).ToList();
            }
            listView.ItemsSource = Listprod;
        }
        public void update_combobox()
        {
            var list_combo = App.DB.magazine;
            var list = list_combo.ToList();
            List<string> list1 = new List<string>();
            list1.Add("Все");
            foreach (var i in list)
            {
                list1.Add(i.name);
            }
            c1.ItemsSource = list1;
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var Button1 = (Button)sender;
            var izmen = (sotrudnik)Button1.DataContext;
            t1.Text = izmen.fio;
            t2.Text = izmen.id_magazine.ToString();
            App.izmenenie = izmen;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            var Button1 = (Button)sender;
            var prod = (sotrudnik)Button1.DataContext;
            App.DB.sotrudnik.Remove(prod);
            App.DB.SaveChanges();
            update();
            MessageBox.Show($"Удален: {prod.fio}");
        }

        private void t5_TextChanged(object sender, TextChangedEventArgs e)
        {
            update();
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            update();
        }
       
        private void dob_Click(object sender, RoutedEventArgs e)
        {
            red red = new red();
            red.Show();
            Close();
        }

        private void sox_Click(object sender, RoutedEventArgs e)
        {
            var soxranenie = App.DB.sotrudnik
                .Where(sotrudnik => sotrudnik.id == App.izmenenie.id).FirstOrDefault();
            soxranenie.fio = t1.Text;           
            soxranenie.id_magazine = Convert.ToInt32(t2.Text);
            App.DB.SaveChanges();
            update();
        }
    }
}
