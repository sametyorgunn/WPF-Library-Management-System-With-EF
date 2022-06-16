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

namespace melo
{
    /// <summary>
    /// Interaction logic for form1.xaml
    /// </summary>
    public partial class MainPage : Window
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void calisan_btn_Click(object sender, RoutedEventArgs e)
        {
            Books cls = new Books();
            cls.Show();
            //this.Hide();
        }

        private void recete_btn_Click(object sender, RoutedEventArgs e)
        {
            Author au = new Author();
            au.Show();
            //this.Hide();
        }

        private void is_btn_Click(object sender, RoutedEventArgs e)
        {
            Publishr p = new Publishr();
            p.Show();
            //this.Hide();
        }
    }
}
