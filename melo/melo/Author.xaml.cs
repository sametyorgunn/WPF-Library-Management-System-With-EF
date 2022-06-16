using melo.Model;
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
    /// Interaction logic for Author.xaml
    /// </summary>
    public partial class Author : Window
    {
        public Author()
        {
            InitializeComponent();
            LoadGrid();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Context c = new Context();
            author a = new author();

            a.author_name = txt_author_name.Text;
            a.author_age = txt_author_age.Text;
            a.author_life = txt_author_life.Text;
            a.author_books = txt_author_books.Text;

            c.authors.Add(a);
            c.SaveChanges();

            txt_author_age.Clear();
            txt_author_books.Clear();
            txt_author_life.Clear();
            txt_author_name.Clear();

            LoadGrid();
        }


        public void LoadGrid()
        {
            Context c = new Context();
            var values = c.authors.ToList();
            datas2.ItemsSource = values;
        }

      

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Context c = new Context();
            int idtxt = Convert.ToInt16(txt_silinecek_book.Text);
            var value = c.authors.Find(idtxt);

            txt_author_name.Text = value.author_name;
            txt_author_age.Text = value.author_age;
            txt_author_life.Text = value.author_life;
            txt_author_books.Text = value.author_books;


            c.authors.Update(value);
            c.SaveChanges();
            txt_silinecek_book.Clear();
            LoadGrid();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Context c = new Context();
            int idtxt = Convert.ToInt16(txt_silinecek_book.Text);
            var value = c.authors.Find(idtxt);
            c.authors.Remove(value);
            c.SaveChanges();
            txt_silinecek_book.Clear();
            LoadGrid();
        }
        private void datas_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
        private void ListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
