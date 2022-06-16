using melo.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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
    /// Interaction logic for calisanwin.xaml
    /// </summary>
    public partial class Books : Window
    {
        Context c = new Context();
   

        SqlCommand com = new SqlCommand();
        public Books()
        {
            

            InitializeComponent();
            LoadGrid();
        }
        public void LoadGrid()
        {
            Context c = new Context();
            var values = c.books.ToList();
            datas.ItemsSource = values;
        }

      

        private void btn_calisan_kaydet_Click(object sender, RoutedEventArgs e)
        {

            Context c = new Context();
            book b = new book();

            b.book_name = txt_book_name.Text;
            b.book_page = txt_book_page.Text;
            b.book_price = txt_book_price.Text;
            b.book_subject = txt_book_subject.Text;
            b.book_writer = txt_book_writer.Text;

            c.books.Add(b);
            c.SaveChanges();

            txt_book_name.Clear();
            txt_book_page.Clear();
            txt_book_price.Clear();
            txt_book_subject.Clear();
            txt_book_writer.Clear();


            var values = c.books.ToList();

            LoadGrid();

        }

       

        private void btn_Book_Delete_Click(object sender, RoutedEventArgs e)
        {
            Context c = new Context();
            int idtxt = Convert.ToInt16(txt_silinecek_book.Text);
            var value = c.books.Find(idtxt);
            c.books.Remove(value);
            c.SaveChanges();
            txt_silinecek_book.Clear();
            LoadGrid();

        }

        private void btn_book_update_Click(object sender, RoutedEventArgs e)
        {
            Context c = new Context();
            int idtxt = Convert.ToInt16(txt_silinecek_book.Text);
            var value = c.books.Find(idtxt);

            txt_book_name.Text = value.book_name;
            txt_book_subject.Text = value.book_subject;
            txt_book_writer.Text = value.book_writer;
            txt_book_price.Text = value.book_price;
            txt_book_page.Text = value.book_page;

            c.books.Update(value);
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
