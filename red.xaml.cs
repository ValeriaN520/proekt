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
using System.Windows.Shapes;

namespace _19._12
{
    /// <summary>
    /// Логика взаимодействия для red.xaml
    /// </summary>
    public partial class red : Window
    {
        public red()
        {
            InitializeComponent();
            update();
        }
        public void update()
        {
            var Listprod = App.DB.sotrudnik.ToList();           
        }
        private void dob_Click(object sender, RoutedEventArgs e)
        {
            sotrudnik sotrudnik = new sotrudnik
            {
                fio = t1.Text,
                id_magazine = Convert.ToInt32(t2.Text)

            };
            App.DB.sotrudnik.Add(sotrudnik);
            App.DB.SaveChanges();
            //update();
            t1.Text = "";
            t2.Text = "";
            MainWindow main = new MainWindow();
            main.Show();
            Close();
        }

      
        private void t1_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("^[А-Я а-я .]");
            if (!regex.IsMatch(e.Text))
            {
                e.Handled = true;
            }
            base.OnPreviewTextInput(e);
        }
    }
}
